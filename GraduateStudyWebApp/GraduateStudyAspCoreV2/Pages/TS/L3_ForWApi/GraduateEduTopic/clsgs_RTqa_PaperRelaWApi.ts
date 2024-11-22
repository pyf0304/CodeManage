﻿
 /**
 * 类名:clsgs_RTqa_PaperRelaWApi
 * 表名:gs_RTqa_PaperRela(01120696)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:00
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
 * 答疑关系表(gs_RTqa_PaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_RTqa_PaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsgs_RTqa_PaperRelaEN.js";
import { vgs_RTqa_PaperRela_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvgs_RTqa_PaperRelaWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_RTqa_PaperRela_Controller = "gs_RTqa_PaperRelaApi";
 export const gs_RTqa_PaperRela_ConstructorName = "gs_RTqa_PaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsgs_RTqa_PaperRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_RTqa_PaperRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const objgs_RTqa_PaperRela = gs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
return objgs_RTqa_PaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjBymId_Cache(lngmId:number,strTopicId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_RTqa_PaperRelaWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
try
{
const arrgs_RTqa_PaperRela_Sel: Array <clsgs_RTqa_PaperRelaEN> = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objgs_RTqa_PaperRela: clsgs_RTqa_PaperRelaEN;
if (arrgs_RTqa_PaperRela_Sel.length > 0)
{
objgs_RTqa_PaperRela = arrgs_RTqa_PaperRela_Sel[0];
return objgs_RTqa_PaperRela;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_RTqa_PaperRela_Const = await gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
if (objgs_RTqa_PaperRela_Const != null)
{
gs_RTqa_PaperRela_ReFreshThisCache(strTopicId);
return objgs_RTqa_PaperRela_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsgs_RTqa_PaperRelaWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_RTqa_PaperRela_Cache: clsgs_RTqa_PaperRelaEN = JSON.parse(strTempObj);
return objgs_RTqa_PaperRela_Cache;
}
try
{
const objgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjBymIdAsync(lngmId);
if (objgs_RTqa_PaperRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_RTqa_PaperRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_RTqa_PaperRela;
}
return objgs_RTqa_PaperRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_RTqa_PaperRela:所给的对象
 * @returns 对象
*/
export async function gs_RTqa_PaperRela_UpdateObjInLst_Cache(objgs_RTqa_PaperRela: clsgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
const obj = arrgs_RTqa_PaperRelaObjLst_Cache.find(x => x.mId == objgs_RTqa_PaperRela.mId);
if (obj != null)
{
objgs_RTqa_PaperRela.mId = obj.mId;
ObjectAssign( obj, objgs_RTqa_PaperRela);
}
else
{
arrgs_RTqa_PaperRelaObjLst_Cache.push(objgs_RTqa_PaperRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 @param strTopicId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function gs_RTqa_PaperRela_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strTopicId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsgs_RTqa_PaperRelaWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsgs_RTqa_PaperRelaWApi.func)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsgs_RTqa_PaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_RTqa_PaperRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_RTqa_PaperRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjBymId_Cache(lngmId , strTopicId_C);
if (objgs_RTqa_PaperRela == null) return "";
if (objgs_RTqa_PaperRela.GetFldValue(strOutFldName) == null) return "";
return objgs_RTqa_PaperRela.GetFldValue(strOutFldName).toString();
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
export function gs_RTqa_PaperRela_SortFun_Defa(a:clsgs_RTqa_PaperRelaEN , b:clsgs_RTqa_PaperRelaEN): number 
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
export function gs_RTqa_PaperRela_SortFun_Defa_2Fld(a:clsgs_RTqa_PaperRelaEN , b:clsgs_RTqa_PaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.qa_PaperId.localeCompare(b.qa_PaperId);
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
export function gs_RTqa_PaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_RTqa_PaperRelaEN.con_mId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return a.mId-b.mId;
}
case clsgs_RTqa_PaperRelaEN.con_TopicId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return a.qa_PaperId.localeCompare(b.qa_PaperId);
}
case clsgs_RTqa_PaperRelaEN.con_UpdDate:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_RTqa_PaperRelaEN.con_UpdUser:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_RTqa_PaperRelaEN.con_Memo:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${ gs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_RTqa_PaperRelaEN.con_mId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return b.mId-a.mId;
}
case clsgs_RTqa_PaperRelaEN.con_TopicId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
return b.qa_PaperId.localeCompare(a.qa_PaperId);
}
case clsgs_RTqa_PaperRelaEN.con_UpdDate:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_RTqa_PaperRelaEN.con_UpdUser:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_RTqa_PaperRelaEN.con_Memo:
return (a: clsgs_RTqa_PaperRelaEN, b: clsgs_RTqa_PaperRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${ gs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_RTqa_PaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_RTqa_PaperRelaEN.con_mId:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.mId === value;
}
case clsgs_RTqa_PaperRelaEN.con_TopicId:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.topicId === value;
}
case clsgs_RTqa_PaperRelaEN.con_qa_PaperId:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.qa_PaperId === value;
}
case clsgs_RTqa_PaperRelaEN.con_UpdDate:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.updDate === value;
}
case clsgs_RTqa_PaperRelaEN.con_UpdUser:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.updUser === value;
}
case clsgs_RTqa_PaperRelaEN.con_Memo:
return (obj: clsgs_RTqa_PaperRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_RTqa_PaperRela]中不存在！(in ${ gs_RTqa_PaperRela_ConstructorName}.${ strThisFuncName})`;
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
 @param strTopicId:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function gs_RTqa_PaperRela_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strTopicId_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strTopicId_C) == true)
{
  const strMsg = Format("参数:[strTopicId_C]不能为空！(In clsgs_RTqa_PaperRelaWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsgs_RTqa_PaperRelaWApi.funcKey)", strTopicId_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsgs_RTqa_PaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrgs_RTqa_PaperRela = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId_C);
if (arrgs_RTqa_PaperRela == null) return [];
let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_RTqa_PaperRela_Sel.length == 0) return [];
return arrgs_RTqa_PaperRela_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_RTqa_PaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_RTqa_PaperRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const objgs_RTqa_PaperRela = gs_RTqa_PaperRela_GetObjFromJsonObj(returnObj);
return objgs_RTqa_PaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_RTqa_PaperRelaExObjLst_Cache: Array<clsgs_RTqa_PaperRelaEN> = CacheHelper.Get(strKey);
const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
return arrgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_RTqa_PaperRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
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
const arrgs_RTqa_PaperRelaExObjLst_Cache: Array<clsgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
return arrgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_RTqa_PaperRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_RTqa_PaperRelaObjLst_Cache: Array<clsgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
return arrgs_RTqa_PaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsgs_RTqa_PaperRelaEN.WhereFormat, strTopicId);
}
else
{
strWhereCond = Format("TopicId='{0}'", strTopicId);
}
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (IsNullOrEmpty(clsgs_RTqa_PaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_RTqa_PaperRelaEN.CacheAddiCondition);
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
const arrgs_RTqa_PaperRelaExObjLst_Cache: Array<clsgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
const arrgs_RTqa_PaperRelaObjLst_T = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaExObjLst_Cache);
return arrgs_RTqa_PaperRelaObjLst_T;
}
try
{
const arrgs_RTqa_PaperRelaExObjLst = await gs_RTqa_PaperRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_RTqa_PaperRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RTqa_PaperRelaExObjLst.length);
console.log(strInfo);
return arrgs_RTqa_PaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("TopicId='{0}'", strTopicId);
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_RTqa_PaperRelaObjLst_Cache: Array<clsgs_RTqa_PaperRelaEN> = JSON.parse(strTempObjLst);
return arrgs_RTqa_PaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId: string): Promise<Array<clsgs_RTqa_PaperRelaEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
const strMsg = Format("缓存分类变量:[TopicId]不能为空！(in clsgs_RTqa_PaperRelaWApi.gs_RTqa_PaperRela_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(in clsgs_RTqa_PaperRelaWApi.gs_RTqa_PaperRela_GetObjLst_Cache() )", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
let arrgs_RTqa_PaperRelaObjLst_Cache;
switch (clsgs_RTqa_PaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_sessionStorage(strTopicId);
break;
case "03"://localStorage
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_localStorage(strTopicId);
break;
case "02"://ClientCache
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
break;
default:
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_ClientCache(strTopicId);
break;
}
const arrgs_RTqa_PaperRelaObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(arrgs_RTqa_PaperRelaObjLst_Cache);
return arrgs_RTqa_PaperRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLst_PureCache(strTopicId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_RTqa_PaperRelaObjLst_Cache;
switch (clsgs_RTqa_PaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_sessionStorage_PureCache(strTopicId);
break;
case "03"://localStorage
arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_localStorage_PureCache(strTopicId);
break;
case "02"://ClientCache
arrgs_RTqa_PaperRelaObjLst_Cache = null;
break;
default:
arrgs_RTqa_PaperRelaObjLst_Cache = null;
break;
}
return arrgs_RTqa_PaperRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_RTqa_PaperRela_GetSubObjLst_Cache(objgs_RTqa_PaperRela_Cond: clsgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
let arrgs_RTqa_PaperRela_Sel: Array < clsgs_RTqa_PaperRelaEN > = arrgs_RTqa_PaperRelaObjLst_Cache;
if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrgs_RTqa_PaperRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_RTqa_PaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_RTqa_PaperRela_Cond), gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_RTqa_PaperRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strTopicId: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
const arrgs_RTqa_PaperRela_Sel: Array <clsgs_RTqa_PaperRelaEN> = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrgs_RTqa_PaperRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strTopicId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_RTqa_PaperRelaEN>();
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrgs_RTqa_PaperRelaObjLst_Cache.length == 0) return arrgs_RTqa_PaperRelaObjLst_Cache;
let arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_RTqa_PaperRela_Cond = new clsgs_RTqa_PaperRelaEN();
ObjectAssign(objgs_RTqa_PaperRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_RTqa_PaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_RTqa_PaperRela_Sel.length == 0) return arrgs_RTqa_PaperRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.sort(gs_RTqa_PaperRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.sort(objPagerPara.sortFun);
}
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.slice(intStart, intEnd);     
return arrgs_RTqa_PaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_RTqa_PaperRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_RTqa_PaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_RTqa_PaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_RTqa_PaperRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_RTqa_PaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_RTqa_PaperRelasAsync";
const strAction = "Delgs_RTqa_PaperRelas";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_Delgs_RTqa_PaperRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_RTqa_PaperRelasByCondAsync";
const strAction = "Delgs_RTqa_PaperRelasByCond";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_RTqa_PaperRela_AddNewRecordAsync(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_RTqa_PaperRelaEN);
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_RTqa_PaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_RTqa_PaperRela_AddNewRecordWithReturnKeyAsync(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_RTqa_PaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_RTqa_PaperRela_AddNewRecordWithReturnKey(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_RTqa_PaperRelaEN.mId === null || objgs_RTqa_PaperRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_RTqa_PaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_RTqa_PaperRela_UpdateRecordAsync(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === undefined || objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === null || objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RTqa_PaperRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_RTqa_PaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_RTqa_PaperRela_UpdateWithConditionAsync(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === undefined || objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === null || objgs_RTqa_PaperRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RTqa_PaperRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
objgs_RTqa_PaperRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_RTqa_PaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_IsExistRecord_Cache(objgs_RTqa_PaperRela_Cond: clsgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrgs_RTqa_PaperRelaObjLst_Cache == null) return false;
let arrgs_RTqa_PaperRela_Sel: Array < clsgs_RTqa_PaperRelaEN > = arrgs_RTqa_PaperRelaObjLst_Cache;
if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrgs_RTqa_PaperRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_RTqa_PaperRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_RTqa_PaperRela_Cond), gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_IsExist_Cache(lngmId:number,strTopicId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrgs_RTqa_PaperRelaObjLst_Cache == null) return false;
try
{
const arrgs_RTqa_PaperRela_Sel: Array <clsgs_RTqa_PaperRelaEN> = arrgs_RTqa_PaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrgs_RTqa_PaperRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
 * @param objgs_RTqa_PaperRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_RTqa_PaperRela_GetRecCountByCond_Cache(objgs_RTqa_PaperRela_Cond: clsgs_RTqa_PaperRelaEN,strTopicId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_RTqa_PaperRelaObjLst_Cache = await gs_RTqa_PaperRela_GetObjLst_Cache(strTopicId);
if (arrgs_RTqa_PaperRelaObjLst_Cache == null) return 0;
let arrgs_RTqa_PaperRela_Sel: Array < clsgs_RTqa_PaperRelaEN > = arrgs_RTqa_PaperRelaObjLst_Cache;
if (objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == null || objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp == "") return arrgs_RTqa_PaperRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_RTqa_PaperRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_RTqa_PaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_RTqa_PaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_RTqa_PaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_RTqa_PaperRela_Sel = arrgs_RTqa_PaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_RTqa_PaperRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_RTqa_PaperRela_Cond), gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export async function gs_RTqa_PaperRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_RTqa_PaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_RTqa_PaperRela_ConstructorName, strThisFuncName);
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
export function gs_RTqa_PaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_RTqa_PaperRela_ReFreshCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In clsgs_RTqa_PaperRelaWApi.clsgs_RTqa_PaperRelaWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsgs_RTqa_PaperRelaWApi.clsgs_RTqa_PaperRelaWApi.ReFreshCache)", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
switch (clsgs_RTqa_PaperRelaEN.CacheModeId)
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
vgs_RTqa_PaperRela_ReFreshThisCache(strTopicId);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_RTqa_PaperRela_ReFreshThisCache(strTopicId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_RTqa_PaperRelaEN._CurrTabName, strTopicId);
switch (clsgs_RTqa_PaperRelaEN.CacheModeId)
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
export function gs_RTqa_PaperRela_CheckPropertyNew(pobjgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.topicId) === true 
 || pobjgs_RTqa_PaperRelaEN.topicId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[主题Id]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === true )
{
 throw new Error("(errid:Watl000058)字段[论文答疑Id]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.topicId) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.topicId)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.qa_PaperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updDate) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updDate)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updUser) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updUser)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.memo) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.memo)(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_RTqa_PaperRelaEN.mId && undefined !== pobjgs_RTqa_PaperRelaEN.mId && tzDataType.isNumber(pobjgs_RTqa_PaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_RTqa_PaperRelaEN.mId)], 非法，应该为数值型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.topicId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.topicId && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_RTqa_PaperRelaEN.topicId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.qa_PaperId && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updDate) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updDate && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_RTqa_PaperRelaEN.updDate)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updUser) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updUser && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_RTqa_PaperRelaEN.updUser)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.memo) == false && undefined !== pobjgs_RTqa_PaperRelaEN.memo && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_RTqa_PaperRelaEN.memo)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_RTqa_PaperRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_RTqa_PaperRela_CheckProperty4Update (pobjgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.topicId) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.topicId)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.qa_PaperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updDate) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updDate)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updUser) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.updUser)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.memo) == false && GetStrLen(pobjgs_RTqa_PaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑关系表(gs_RTqa_PaperRela))!值:$(pobjgs_RTqa_PaperRelaEN.memo)(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_RTqa_PaperRelaEN.mId && undefined !== pobjgs_RTqa_PaperRelaEN.mId && tzDataType.isNumber(pobjgs_RTqa_PaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_RTqa_PaperRelaEN.mId)], 非法，应该为数值型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.topicId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.topicId && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_RTqa_PaperRelaEN.topicId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.qa_PaperId) == false && undefined !== pobjgs_RTqa_PaperRelaEN.qa_PaperId && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.qa_PaperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjgs_RTqa_PaperRelaEN.qa_PaperId)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updDate) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updDate && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_RTqa_PaperRelaEN.updDate)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.updUser) == false && undefined !== pobjgs_RTqa_PaperRelaEN.updUser && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_RTqa_PaperRelaEN.updUser)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_RTqa_PaperRelaEN.memo) == false && undefined !== pobjgs_RTqa_PaperRelaEN.memo && tzDataType.isString(pobjgs_RTqa_PaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_RTqa_PaperRelaEN.memo)], 非法，应该为字符型(In 答疑关系表(gs_RTqa_PaperRela))!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_RTqa_PaperRelaEN.mId 
 || pobjgs_RTqa_PaperRelaEN.mId != null && pobjgs_RTqa_PaperRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 答疑关系表)!(clsgs_RTqa_PaperRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_RTqa_PaperRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_RTqa_PaperRela_GetJSONStrByObj (pobjgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_RTqa_PaperRelaEN.sfUpdFldSetStr = pobjgs_RTqa_PaperRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_RTqa_PaperRelaEN);
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
export function gs_RTqa_PaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsgs_RTqa_PaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_RTqa_PaperRelaObjLst = new Array<clsgs_RTqa_PaperRelaEN>();
if (strJSON === "")
{
return arrgs_RTqa_PaperRelaObjLst;
}
try
{
arrgs_RTqa_PaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_RTqa_PaperRelaObjLst;
}
return arrgs_RTqa_PaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_RTqa_PaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_RTqa_PaperRela_GetObjLstByJSONObjLst (arrgs_RTqa_PaperRelaObjLstS: Array<clsgs_RTqa_PaperRelaEN>): Array<clsgs_RTqa_PaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_RTqa_PaperRelaObjLst = new Array<clsgs_RTqa_PaperRelaEN>();
for (const objInFor of arrgs_RTqa_PaperRelaObjLstS) {
const obj1 = gs_RTqa_PaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_RTqa_PaperRelaObjLst.push(obj1);
}
return arrgs_RTqa_PaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_RTqa_PaperRela_GetObjByJSONStr (strJSON: string): clsgs_RTqa_PaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN();
if (strJSON === "")
{
return pobjgs_RTqa_PaperRelaEN;
}
try
{
pobjgs_RTqa_PaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_RTqa_PaperRelaEN;
}
return pobjgs_RTqa_PaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_RTqa_PaperRela_GetCombineCondition(objgs_RTqa_PaperRela_Cond: clsgs_RTqa_PaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_RTqa_PaperRelaEN.con_mId, objgs_RTqa_PaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN.con_TopicId, objgs_RTqa_PaperRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_qa_PaperId) == true)
{
const strComparisonOp_qa_PaperId:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_qa_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN.con_qa_PaperId, objgs_RTqa_PaperRela_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN.con_UpdDate, objgs_RTqa_PaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN.con_UpdUser, objgs_RTqa_PaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_RTqa_PaperRela_Cond.dicFldComparisonOp, clsgs_RTqa_PaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_RTqa_PaperRela_Cond.dicFldComparisonOp[clsgs_RTqa_PaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_RTqa_PaperRelaEN.con_Memo, objgs_RTqa_PaperRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_RTqa_PaperRela(答疑关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_RTqa_PaperRela_GetUniCondStr_mId(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_RTqa_PaperRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_RTqa_PaperRela(答疑关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_RTqa_PaperRela_GetUniCondStr4Update_mId(objgs_RTqa_PaperRelaEN: clsgs_RTqa_PaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_RTqa_PaperRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_RTqa_PaperRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_RTqa_PaperRelaENS:源对象
 * @param objgs_RTqa_PaperRelaENT:目标对象
*/
export function gs_RTqa_PaperRela_CopyObjTo(objgs_RTqa_PaperRelaENS: clsgs_RTqa_PaperRelaEN , objgs_RTqa_PaperRelaENT: clsgs_RTqa_PaperRelaEN ): void 
{
objgs_RTqa_PaperRelaENT.mId = objgs_RTqa_PaperRelaENS.mId; //mId
objgs_RTqa_PaperRelaENT.topicId = objgs_RTqa_PaperRelaENS.topicId; //主题Id
objgs_RTqa_PaperRelaENT.qa_PaperId = objgs_RTqa_PaperRelaENS.qa_PaperId; //论文答疑Id
objgs_RTqa_PaperRelaENT.updDate = objgs_RTqa_PaperRelaENS.updDate; //修改日期
objgs_RTqa_PaperRelaENT.updUser = objgs_RTqa_PaperRelaENS.updUser; //修改人
objgs_RTqa_PaperRelaENT.memo = objgs_RTqa_PaperRelaENS.memo; //备注
objgs_RTqa_PaperRelaENT.sfUpdFldSetStr = objgs_RTqa_PaperRelaENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_RTqa_PaperRelaENS:源对象
 * @param objgs_RTqa_PaperRelaENT:目标对象
*/
export function gs_RTqa_PaperRela_GetObjFromJsonObj(objgs_RTqa_PaperRelaENS: clsgs_RTqa_PaperRelaEN): clsgs_RTqa_PaperRelaEN 
{
 const objgs_RTqa_PaperRelaENT: clsgs_RTqa_PaperRelaEN = new clsgs_RTqa_PaperRelaEN();
ObjectAssign(objgs_RTqa_PaperRelaENT, objgs_RTqa_PaperRelaENS);
 return objgs_RTqa_PaperRelaENT;
}