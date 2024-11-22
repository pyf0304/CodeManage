
 /**
 * 类名:clsgs_ViewsClassificationWApi
 * 表名:gs_ViewsClassification(01120777)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:28
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
 * 各观点分类表(gs_ViewsClassification)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_ViewsClassificationEN } from "../../L0_Entity/GraduateEduTopic/clsgs_ViewsClassificationEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ViewsClassification_Controller = "gs_ViewsClassificationApi";
 export const gs_ViewsClassification_ConstructorName = "gs_ViewsClassification";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strClassificationId:关键字
 * @returns 对象
 **/
export async function gs_ViewsClassification_GetObjByClassificationIdAsync(strClassificationId: string): Promise<clsgs_ViewsClassificationEN|null>  
{
const strThisFuncName = "GetObjByClassificationIdAsync";

if (IsNullOrEmpty(strClassificationId) == true)
{
  const strMsg = Format("参数:[strClassificationId]不能为空！(In clsgs_ViewsClassificationWApi.GetObjByClassificationIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strClassificationId.length != 10)
{
const strMsg = Format("缓存分类变量:[strClassificationId]的长度:[{0}]不正确！(clsgs_ViewsClassificationWApi.GetObjByClassificationIdAsync)", strClassificationId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByClassificationId";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strClassificationId": strClassificationId,
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
const objgs_ViewsClassification = gs_ViewsClassification_GetObjFromJsonObj(returnObj);
return objgs_ViewsClassification;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param strClassificationId:所给的关键字
 * @returns 对象
*/
export async function gs_ViewsClassification_GetObjByClassificationId_Cache(strClassificationId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByClassificationId_Cache";

if (IsNullOrEmpty(strClassificationId) == true)
{
  const strMsg = Format("参数:[strClassificationId]不能为空！(In clsgs_ViewsClassificationWApi.GetObjByClassificationId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strClassificationId.length != 10)
{
const strMsg = Format("缓存分类变量:[strClassificationId]的长度:[{0}]不正确！(clsgs_ViewsClassificationWApi.GetObjByClassificationId_Cache)", strClassificationId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
try
{
const arrgs_ViewsClassification_Sel: Array <clsgs_ViewsClassificationEN> = arrgs_ViewsClassificationObjLst_Cache.filter(x => 
 x.classificationId == strClassificationId );
let objgs_ViewsClassification: clsgs_ViewsClassificationEN;
if (arrgs_ViewsClassification_Sel.length > 0)
{
objgs_ViewsClassification = arrgs_ViewsClassification_Sel[0];
return objgs_ViewsClassification;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_ViewsClassification_Const = await gs_ViewsClassification_GetObjByClassificationIdAsync(strClassificationId);
if (objgs_ViewsClassification_Const != null)
{
gs_ViewsClassification_ReFreshThisCache();
return objgs_ViewsClassification_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strClassificationId, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strClassificationId:所给的关键字
 * @returns 对象
*/
export async function gs_ViewsClassification_GetObjByClassificationId_localStorage(strClassificationId: string) {
const strThisFuncName = "GetObjByClassificationId_localStorage";

if (IsNullOrEmpty(strClassificationId) == true)
{
  const strMsg = Format("参数:[strClassificationId]不能为空！(In clsgs_ViewsClassificationWApi.GetObjByClassificationId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strClassificationId.length != 10)
{
const strMsg = Format("缓存分类变量:[strClassificationId]的长度:[{0}]不正确！(clsgs_ViewsClassificationWApi.GetObjByClassificationId_localStorage)", strClassificationId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_ViewsClassificationEN._CurrTabName, strClassificationId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_ViewsClassification_Cache: clsgs_ViewsClassificationEN = JSON.parse(strTempObj);
return objgs_ViewsClassification_Cache;
}
try
{
const objgs_ViewsClassification = await gs_ViewsClassification_GetObjByClassificationIdAsync(strClassificationId);
if (objgs_ViewsClassification != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_ViewsClassification));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_ViewsClassification;
}
return objgs_ViewsClassification;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strClassificationId, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_ViewsClassification:所给的对象
 * @returns 对象
*/
export async function gs_ViewsClassification_UpdateObjInLst_Cache(objgs_ViewsClassification: clsgs_ViewsClassificationEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
const obj = arrgs_ViewsClassificationObjLst_Cache.find(x => x.classificationName == objgs_ViewsClassification.classificationName && x.topicId == objgs_ViewsClassification.topicId);
if (obj != null)
{
objgs_ViewsClassification.classificationId = obj.classificationId;
ObjectAssign( obj, objgs_ViewsClassification);
}
else
{
arrgs_ViewsClassificationObjLst_Cache.push(objgs_ViewsClassification);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strClassificationId:所给的关键字
 * @returns 对象
*/
export async function gs_ViewsClassification_GetNameByClassificationId_Cache(strClassificationId: string) {
const strThisFuncName = "GetNameByClassificationId_Cache";

if (IsNullOrEmpty(strClassificationId) == true)
{
  const strMsg = Format("参数:[strClassificationId]不能为空！(In clsgs_ViewsClassificationWApi.GetNameByClassificationId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strClassificationId.length != 10)
{
const strMsg = Format("缓存分类变量:[strClassificationId]的长度:[{0}]不正确！(clsgs_ViewsClassificationWApi.GetNameByClassificationId_Cache)", strClassificationId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassificationObjLst_Cache == null) return "";
try
{
const arrgs_ViewsClassification_Sel: Array <clsgs_ViewsClassificationEN> = arrgs_ViewsClassificationObjLst_Cache.filter(x => 
 x.classificationId == strClassificationId );
let objgs_ViewsClassification: clsgs_ViewsClassificationEN;
if (arrgs_ViewsClassification_Sel.length > 0)
{
objgs_ViewsClassification = arrgs_ViewsClassification_Sel[0];
return objgs_ViewsClassification.classificationName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strClassificationId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

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
export async function gs_ViewsClassification_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_ViewsClassificationEN.con_ClassificationId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_ViewsClassificationEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_ViewsClassificationEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strClassificationId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_ViewsClassification = await gs_ViewsClassification_GetObjByClassificationId_Cache(strClassificationId );
if (objgs_ViewsClassification == null) return "";
if (objgs_ViewsClassification.GetFldValue(strOutFldName) == null) return "";
return objgs_ViewsClassification.GetFldValue(strOutFldName).toString();
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
export function gs_ViewsClassification_SortFun_Defa(a:clsgs_ViewsClassificationEN , b:clsgs_ViewsClassificationEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.classificationId.localeCompare(b.classificationId);
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
export function gs_ViewsClassification_SortFun_Defa_2Fld(a:clsgs_ViewsClassificationEN , b:clsgs_ViewsClassificationEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.classificationName == b.classificationName) return a.topicId.localeCompare(b.topicId);
else return a.classificationName.localeCompare(b.classificationName);
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
export function gs_ViewsClassification_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ViewsClassificationEN.con_ClassificationId:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return a.classificationId.localeCompare(b.classificationId);
}
case clsgs_ViewsClassificationEN.con_ClassificationName:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return a.classificationName.localeCompare(b.classificationName);
}
case clsgs_ViewsClassificationEN.con_TopicId:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_ViewsClassificationEN.con_OrderNum:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return a.orderNum-b.orderNum;
}
case clsgs_ViewsClassificationEN.con_UpdDate:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_ViewsClassificationEN.con_UpdUser:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_ViewsClassificationEN.con_Memo:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ViewsClassification]中不存在！(in ${ gs_ViewsClassification_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ViewsClassificationEN.con_ClassificationId:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return b.classificationId.localeCompare(a.classificationId);
}
case clsgs_ViewsClassificationEN.con_ClassificationName:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return b.classificationName.localeCompare(a.classificationName);
}
case clsgs_ViewsClassificationEN.con_TopicId:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_ViewsClassificationEN.con_OrderNum:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
return b.orderNum-a.orderNum;
}
case clsgs_ViewsClassificationEN.con_UpdDate:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_ViewsClassificationEN.con_UpdUser:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_ViewsClassificationEN.con_Memo:
return (a: clsgs_ViewsClassificationEN, b: clsgs_ViewsClassificationEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ViewsClassification]中不存在！(in ${ gs_ViewsClassification_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ViewsClassification_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ViewsClassificationEN.con_ClassificationId:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.classificationId === value;
}
case clsgs_ViewsClassificationEN.con_ClassificationName:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.classificationName === value;
}
case clsgs_ViewsClassificationEN.con_TopicId:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.topicId === value;
}
case clsgs_ViewsClassificationEN.con_OrderNum:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.orderNum === value;
}
case clsgs_ViewsClassificationEN.con_UpdDate:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.updDate === value;
}
case clsgs_ViewsClassificationEN.con_UpdUser:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.updUser === value;
}
case clsgs_ViewsClassificationEN.con_Memo:
return (obj: clsgs_ViewsClassificationEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ViewsClassification]中不存在！(in ${ gs_ViewsClassification_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ViewsClassification_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_ViewsClassificationEN.con_ClassificationId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_ViewsClassification = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassification == null) return [];
let arrgs_ViewsClassification_Sel = arrgs_ViewsClassification;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_ViewsClassification_Sel.length == 0) return [];
return arrgs_ViewsClassification_Sel.map(x=>x.classificationId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ViewsClassification_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ViewsClassificationEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const objgs_ViewsClassification = gs_ViewsClassification_GetObjFromJsonObj(returnObj);
return objgs_ViewsClassification;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ViewsClassificationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ViewsClassificationEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_ViewsClassificationExObjLst_Cache: Array<clsgs_ViewsClassificationEN> = CacheHelper.Get(strKey);
const arrgs_ViewsClassificationObjLst_T = gs_ViewsClassification_GetObjLstByJSONObjLst(arrgs_ViewsClassificationExObjLst_Cache);
return arrgs_ViewsClassificationObjLst_T;
}
try
{
const arrgs_ViewsClassificationExObjLst = await gs_ViewsClassification_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_ViewsClassificationExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ViewsClassificationExObjLst.length);
console.log(strInfo);
return arrgs_ViewsClassificationExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ViewsClassification_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ViewsClassificationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ViewsClassificationEN.CacheAddiCondition);
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
const arrgs_ViewsClassificationExObjLst_Cache: Array<clsgs_ViewsClassificationEN> = JSON.parse(strTempObjLst);
const arrgs_ViewsClassificationObjLst_T = gs_ViewsClassification_GetObjLstByJSONObjLst(arrgs_ViewsClassificationExObjLst_Cache);
return arrgs_ViewsClassificationObjLst_T;
}
try
{
const arrgs_ViewsClassificationExObjLst = await gs_ViewsClassification_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_ViewsClassificationExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ViewsClassificationExObjLst.length);
console.log(strInfo);
return arrgs_ViewsClassificationExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ViewsClassification_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ViewsClassificationObjLst_Cache: Array<clsgs_ViewsClassificationEN> = JSON.parse(strTempObjLst);
return arrgs_ViewsClassificationObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_ViewsClassification_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ViewsClassificationEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ViewsClassificationEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ViewsClassificationEN.CacheAddiCondition);
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
const arrgs_ViewsClassificationExObjLst_Cache: Array<clsgs_ViewsClassificationEN> = JSON.parse(strTempObjLst);
const arrgs_ViewsClassificationObjLst_T = gs_ViewsClassification_GetObjLstByJSONObjLst(arrgs_ViewsClassificationExObjLst_Cache);
return arrgs_ViewsClassificationObjLst_T;
}
try
{
const arrgs_ViewsClassificationExObjLst = await gs_ViewsClassification_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_ViewsClassificationExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ViewsClassificationExObjLst.length);
console.log(strInfo);
return arrgs_ViewsClassificationExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ViewsClassification_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ViewsClassificationObjLst_Cache: Array<clsgs_ViewsClassificationEN> = JSON.parse(strTempObjLst);
return arrgs_ViewsClassificationObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ViewsClassification_GetObjLst_Cache(): Promise<Array<clsgs_ViewsClassificationEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_ViewsClassificationObjLst_Cache;
switch (clsgs_ViewsClassificationEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_ClientCache();
break;
default:
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_ClientCache();
break;
}
const arrgs_ViewsClassificationObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(arrgs_ViewsClassificationObjLst_Cache);
return arrgs_ViewsClassificationObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ViewsClassification_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_ViewsClassificationObjLst_Cache;
switch (clsgs_ViewsClassificationEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_ViewsClassificationObjLst_Cache = null;
break;
default:
arrgs_ViewsClassificationObjLst_Cache = null;
break;
}
return arrgs_ViewsClassificationObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrClassificationId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ViewsClassification_GetSubObjLst_Cache(objgs_ViewsClassification_Cond: clsgs_ViewsClassificationEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
let arrgs_ViewsClassification_Sel: Array < clsgs_ViewsClassificationEN > = arrgs_ViewsClassificationObjLst_Cache;
if (objgs_ViewsClassification_Cond.sf_FldComparisonOp == null || objgs_ViewsClassification_Cond.sf_FldComparisonOp == "") return arrgs_ViewsClassification_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ViewsClassification_Cond.sf_FldComparisonOp);
//console.log("clsgs_ViewsClassificationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ViewsClassification_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ViewsClassification_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ViewsClassification_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_ViewsClassification_Cond), gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ViewsClassificationEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrClassificationId:关键字列表
 * @returns 对象列表
 **/
export async function gs_ViewsClassification_GetObjLstByClassificationIdLstAsync(arrClassificationId: Array<string>): Promise<Array<clsgs_ViewsClassificationEN>>  
{
const strThisFuncName = "GetObjLstByClassificationIdLstAsync";
const strAction = "GetObjLstByClassificationIdLst";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrClassificationId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param arrstrClassificationIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_ViewsClassification_GetObjLstByClassificationIdLst_Cache(arrClassificationIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByClassificationIdLst_Cache";
try
{
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
const arrgs_ViewsClassification_Sel: Array <clsgs_ViewsClassificationEN> = arrgs_ViewsClassificationObjLst_Cache.filter(x => arrClassificationIdLst.indexOf(x.classificationId)>-1);
return arrgs_ViewsClassification_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrClassificationIdLst.join(","), gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ViewsClassificationEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ViewsClassificationEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ViewsClassificationEN>();
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassificationObjLst_Cache.length == 0) return arrgs_ViewsClassificationObjLst_Cache;
let arrgs_ViewsClassification_Sel = arrgs_ViewsClassificationObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_ViewsClassification_Cond = new clsgs_ViewsClassificationEN();
ObjectAssign(objgs_ViewsClassification_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_ViewsClassificationWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ViewsClassification_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ViewsClassification_Sel.length == 0) return arrgs_ViewsClassification_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(gs_ViewsClassification_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.sort(objPagerPara.sortFun);
}
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.slice(intStart, intEnd);     
return arrgs_ViewsClassification_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ViewsClassificationEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_ViewsClassification_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ViewsClassificationEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ViewsClassificationEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ViewsClassification_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param strClassificationId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_ViewsClassification_DelRecordAsync(strClassificationId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strClassificationId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param arrClassificationId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_ViewsClassification_Delgs_ViewsClassificationsAsync(arrClassificationId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ViewsClassificationsAsync";
const strAction = "Delgs_ViewsClassifications";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrClassificationId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_Delgs_ViewsClassificationsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ViewsClassificationsByCondAsync";
const strAction = "Delgs_ViewsClassificationsByCond";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_AddNewRecordAsync(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ViewsClassificationEN);
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_AddNewRecordWithMaxIdAsync(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_ViewsClassificationEN);
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_ViewsClassificationEN);
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_ViewsClassificationEN);
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ViewsClassification_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objgs_ViewsClassificationEN);
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ViewsClassification_AddNewRecordWithReturnKeyAsync(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ViewsClassification_AddNewRecordWithReturnKey(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ViewsClassificationEN.classificationId === null || objgs_ViewsClassificationEN.classificationId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ViewsClassification_UpdateRecordAsync(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ViewsClassificationEN.sfUpdFldSetStr === undefined || objgs_ViewsClassificationEN.sfUpdFldSetStr === null || objgs_ViewsClassificationEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ViewsClassificationEN.classificationId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassificationEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ViewsClassification_UpdateWithConditionAsync(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ViewsClassificationEN.sfUpdFldSetStr === undefined || objgs_ViewsClassificationEN.sfUpdFldSetStr === null || objgs_ViewsClassificationEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ViewsClassificationEN.classificationId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
objgs_ViewsClassificationEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ViewsClassificationEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objstrClassificationId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ViewsClassification_IsExistRecord_Cache(objgs_ViewsClassification_Cond: clsgs_ViewsClassificationEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassificationObjLst_Cache == null) return false;
let arrgs_ViewsClassification_Sel: Array < clsgs_ViewsClassificationEN > = arrgs_ViewsClassificationObjLst_Cache;
if (objgs_ViewsClassification_Cond.sf_FldComparisonOp == null || objgs_ViewsClassification_Cond.sf_FldComparisonOp == "") return arrgs_ViewsClassification_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ViewsClassification_Cond.sf_FldComparisonOp);
//console.log("clsgs_ViewsClassificationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ViewsClassification_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ViewsClassification_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ViewsClassification_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_ViewsClassification_Cond), gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param strClassificationId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_ViewsClassification_IsExist(strClassificationId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ClassificationId": strClassificationId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param strClassificationId:所给的关键字
 * @returns 对象
*/
export async function gs_ViewsClassification_IsExist_Cache(strClassificationId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassificationObjLst_Cache == null) return false;
try
{
const arrgs_ViewsClassification_Sel: Array <clsgs_ViewsClassificationEN> = arrgs_ViewsClassificationObjLst_Cache.filter(x => x.classificationId == strClassificationId);
if (arrgs_ViewsClassification_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strClassificationId, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strClassificationId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_ViewsClassification_IsExistAsync(strClassificationId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strClassificationId": strClassificationId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
 * @param objgs_ViewsClassification_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_ViewsClassification_GetRecCountByCond_Cache(objgs_ViewsClassification_Cond: clsgs_ViewsClassificationEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_ViewsClassificationObjLst_Cache = await gs_ViewsClassification_GetObjLst_Cache();
if (arrgs_ViewsClassificationObjLst_Cache == null) return 0;
let arrgs_ViewsClassification_Sel: Array < clsgs_ViewsClassificationEN > = arrgs_ViewsClassificationObjLst_Cache;
if (objgs_ViewsClassification_Cond.sf_FldComparisonOp == null || objgs_ViewsClassification_Cond.sf_FldComparisonOp == "") return arrgs_ViewsClassification_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ViewsClassification_Cond.sf_FldComparisonOp);
//console.log("clsgs_ViewsClassificationWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ViewsClassification_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ViewsClassification_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ViewsClassification_Sel = arrgs_ViewsClassification_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ViewsClassification_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_ViewsClassification_Cond), gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export async function gs_ViewsClassification_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ViewsClassification_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ViewsClassification_ConstructorName, strThisFuncName);
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
export function gs_ViewsClassification_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_ViewsClassification_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
switch (clsgs_ViewsClassificationEN.CacheModeId)
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
export function gs_ViewsClassification_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_ViewsClassificationEN._CurrTabName;
switch (clsgs_ViewsClassificationEN.CacheModeId)
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
export function gs_ViewsClassification_CheckPropertyNew(pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationName) === true )
{
 throw new Error("(errid:Watl000058)字段[分类名称]不能为空(In 各观点分类表)!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.topicId) === true 
 || pobjgs_ViewsClassificationEN.topicId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In 各观点分类表)!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationId) == false && GetStrLen(pobjgs_ViewsClassificationEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000059)字段[分类Id(classificationId)]的长度不能超过10(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.classificationId)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationName) == false && GetStrLen(pobjgs_ViewsClassificationEN.classificationName) > 200)
{
 throw new Error("(errid:Watl000059)字段[分类名称(classificationName)]的长度不能超过200(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.classificationName)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.topicId) == false && GetStrLen(pobjgs_ViewsClassificationEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.topicId)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updDate) == false && GetStrLen(pobjgs_ViewsClassificationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.updDate)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updUser) == false && GetStrLen(pobjgs_ViewsClassificationEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.updUser)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.memo) == false && GetStrLen(pobjgs_ViewsClassificationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.memo)(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationId) == false && undefined !== pobjgs_ViewsClassificationEN.classificationId && tzDataType.isString(pobjgs_ViewsClassificationEN.classificationId) === false)
{
 throw new Error("(errid:Watl000060)字段[分类Id(classificationId)]的值:[$(pobjgs_ViewsClassificationEN.classificationId)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationName) == false && undefined !== pobjgs_ViewsClassificationEN.classificationName && tzDataType.isString(pobjgs_ViewsClassificationEN.classificationName) === false)
{
 throw new Error("(errid:Watl000060)字段[分类名称(classificationName)]的值:[$(pobjgs_ViewsClassificationEN.classificationName)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.topicId) == false && undefined !== pobjgs_ViewsClassificationEN.topicId && tzDataType.isString(pobjgs_ViewsClassificationEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_ViewsClassificationEN.topicId)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (null != pobjgs_ViewsClassificationEN.orderNum && undefined !== pobjgs_ViewsClassificationEN.orderNum && tzDataType.isNumber(pobjgs_ViewsClassificationEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_ViewsClassificationEN.orderNum)], 非法，应该为数值型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updDate) == false && undefined !== pobjgs_ViewsClassificationEN.updDate && tzDataType.isString(pobjgs_ViewsClassificationEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_ViewsClassificationEN.updDate)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updUser) == false && undefined !== pobjgs_ViewsClassificationEN.updUser && tzDataType.isString(pobjgs_ViewsClassificationEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_ViewsClassificationEN.updUser)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.memo) == false && undefined !== pobjgs_ViewsClassificationEN.memo && tzDataType.isString(pobjgs_ViewsClassificationEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ViewsClassificationEN.memo)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ViewsClassificationEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ViewsClassification_CheckProperty4Update (pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationId) == false && GetStrLen(pobjgs_ViewsClassificationEN.classificationId) > 10)
{
 throw new Error("(errid:Watl000062)字段[分类Id(classificationId)]的长度不能超过10(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.classificationId)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationName) == false && GetStrLen(pobjgs_ViewsClassificationEN.classificationName) > 200)
{
 throw new Error("(errid:Watl000062)字段[分类名称(classificationName)]的长度不能超过200(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.classificationName)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.topicId) == false && GetStrLen(pobjgs_ViewsClassificationEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.topicId)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updDate) == false && GetStrLen(pobjgs_ViewsClassificationEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.updDate)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updUser) == false && GetStrLen(pobjgs_ViewsClassificationEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.updUser)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.memo) == false && GetStrLen(pobjgs_ViewsClassificationEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 各观点分类表(gs_ViewsClassification))!值:$(pobjgs_ViewsClassificationEN.memo)(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationId) == false && undefined !== pobjgs_ViewsClassificationEN.classificationId && tzDataType.isString(pobjgs_ViewsClassificationEN.classificationId) === false)
{
 throw new Error("(errid:Watl000063)字段[分类Id(classificationId)]的值:[$(pobjgs_ViewsClassificationEN.classificationId)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationName) == false && undefined !== pobjgs_ViewsClassificationEN.classificationName && tzDataType.isString(pobjgs_ViewsClassificationEN.classificationName) === false)
{
 throw new Error("(errid:Watl000063)字段[分类名称(classificationName)]的值:[$(pobjgs_ViewsClassificationEN.classificationName)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.topicId) == false && undefined !== pobjgs_ViewsClassificationEN.topicId && tzDataType.isString(pobjgs_ViewsClassificationEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_ViewsClassificationEN.topicId)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (null != pobjgs_ViewsClassificationEN.orderNum && undefined !== pobjgs_ViewsClassificationEN.orderNum && tzDataType.isNumber(pobjgs_ViewsClassificationEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_ViewsClassificationEN.orderNum)], 非法，应该为数值型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updDate) == false && undefined !== pobjgs_ViewsClassificationEN.updDate && tzDataType.isString(pobjgs_ViewsClassificationEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_ViewsClassificationEN.updDate)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.updUser) == false && undefined !== pobjgs_ViewsClassificationEN.updUser && tzDataType.isString(pobjgs_ViewsClassificationEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_ViewsClassificationEN.updUser)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.memo) == false && undefined !== pobjgs_ViewsClassificationEN.memo && tzDataType.isString(pobjgs_ViewsClassificationEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ViewsClassificationEN.memo)], 非法，应该为字符型(In 各观点分类表(gs_ViewsClassification))!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_ViewsClassificationEN.classificationId) === true )
{
 throw new Error("(errid:Watl000064)字段[分类Id]不能为空(In 各观点分类表)!(clsgs_ViewsClassificationBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ViewsClassificationEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ViewsClassification_GetJSONStrByObj (pobjgs_ViewsClassificationEN: clsgs_ViewsClassificationEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ViewsClassificationEN.sfUpdFldSetStr = pobjgs_ViewsClassificationEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ViewsClassificationEN);
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
export function gs_ViewsClassification_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ViewsClassificationEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ViewsClassificationObjLst = new Array<clsgs_ViewsClassificationEN>();
if (strJSON === "")
{
return arrgs_ViewsClassificationObjLst;
}
try
{
arrgs_ViewsClassificationObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ViewsClassificationObjLst;
}
return arrgs_ViewsClassificationObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ViewsClassificationObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ViewsClassification_GetObjLstByJSONObjLst (arrgs_ViewsClassificationObjLstS: Array<clsgs_ViewsClassificationEN>): Array<clsgs_ViewsClassificationEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ViewsClassificationObjLst = new Array<clsgs_ViewsClassificationEN>();
for (const objInFor of arrgs_ViewsClassificationObjLstS) {
const obj1 = gs_ViewsClassification_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ViewsClassificationObjLst.push(obj1);
}
return arrgs_ViewsClassificationObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ViewsClassification_GetObjByJSONStr (strJSON: string): clsgs_ViewsClassificationEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN();
if (strJSON === "")
{
return pobjgs_ViewsClassificationEN;
}
try
{
pobjgs_ViewsClassificationEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ViewsClassificationEN;
}
return pobjgs_ViewsClassificationEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ViewsClassification_GetCombineCondition(objgs_ViewsClassification_Cond: clsgs_ViewsClassificationEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_ClassificationId, objgs_ViewsClassification_Cond.classificationId, strComparisonOp_ClassificationId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_ClassificationName) == true)
{
const strComparisonOp_ClassificationName:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_ClassificationName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_ClassificationName, objgs_ViewsClassification_Cond.classificationName, strComparisonOp_ClassificationName);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_TopicId, objgs_ViewsClassification_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ViewsClassificationEN.con_OrderNum, objgs_ViewsClassification_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_UpdDate, objgs_ViewsClassification_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_UpdUser, objgs_ViewsClassification_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_ViewsClassification_Cond.dicFldComparisonOp, clsgs_ViewsClassificationEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ViewsClassification_Cond.dicFldComparisonOp[clsgs_ViewsClassificationEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ViewsClassificationEN.con_Memo, objgs_ViewsClassification_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ViewsClassification(各观点分类表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strClassificationName: 分类名称(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ViewsClassification_GetUniCondStr_ClassificationName_TopicId(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ClassificationName = '{0}'", objgs_ViewsClassificationEN.classificationName);
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_ViewsClassificationEN.topicId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ViewsClassification(各观点分类表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strClassificationName: 分类名称(要求唯一的字段)
 * @param strTopicId: 主题Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ViewsClassification_GetUniCondStr4Update_ClassificationName_TopicId(objgs_ViewsClassificationEN: clsgs_ViewsClassificationEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ClassificationId <> '{0}'", objgs_ViewsClassificationEN.classificationId);
 strWhereCond +=  Format(" and ClassificationName = '{0}'", objgs_ViewsClassificationEN.classificationName);
 strWhereCond +=  Format(" and TopicId = '{0}'", objgs_ViewsClassificationEN.topicId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ViewsClassificationENS:源对象
 * @param objgs_ViewsClassificationENT:目标对象
*/
export function gs_ViewsClassification_CopyObjTo(objgs_ViewsClassificationENS: clsgs_ViewsClassificationEN , objgs_ViewsClassificationENT: clsgs_ViewsClassificationEN ): void 
{
objgs_ViewsClassificationENT.classificationId = objgs_ViewsClassificationENS.classificationId; //分类Id
objgs_ViewsClassificationENT.classificationName = objgs_ViewsClassificationENS.classificationName; //分类名称
objgs_ViewsClassificationENT.topicId = objgs_ViewsClassificationENS.topicId; //主题Id
objgs_ViewsClassificationENT.orderNum = objgs_ViewsClassificationENS.orderNum; //序号
objgs_ViewsClassificationENT.updDate = objgs_ViewsClassificationENS.updDate; //修改日期
objgs_ViewsClassificationENT.updUser = objgs_ViewsClassificationENS.updUser; //修改人
objgs_ViewsClassificationENT.memo = objgs_ViewsClassificationENS.memo; //备注
objgs_ViewsClassificationENT.sfUpdFldSetStr = objgs_ViewsClassificationENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ViewsClassificationENS:源对象
 * @param objgs_ViewsClassificationENT:目标对象
*/
export function gs_ViewsClassification_GetObjFromJsonObj(objgs_ViewsClassificationENS: clsgs_ViewsClassificationEN): clsgs_ViewsClassificationEN 
{
 const objgs_ViewsClassificationENT: clsgs_ViewsClassificationEN = new clsgs_ViewsClassificationEN();
ObjectAssign(objgs_ViewsClassificationENT, objgs_ViewsClassificationENS);
 return objgs_ViewsClassificationENT;
}