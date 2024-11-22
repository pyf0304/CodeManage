﻿
 /**
 * 类名:clsPaperAttachmentWApi
 * 表名:PaperAttachment(01120578)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:54
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 论文附件(PaperAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPaperAttachmentEN } from "../../L0_Entity/GraduateEduPaper/clsPaperAttachmentEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperAttachment_Controller = "PaperAttachmentApi";
 export const paperAttachment_ConstructorName = "paperAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperAttachmentId:关键字
 * @returns 对象
 **/
export async function PaperAttachment_GetObjByPaperAttachmentIdAsync(lngPaperAttachmentId: number): Promise<clsPaperAttachmentEN|null>  
{
const strThisFuncName = "GetObjByPaperAttachmentIdAsync";

if (lngPaperAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperAttachmentId]不能为空！(In clsPaperAttachmentWApi.GetObjByPaperAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperAttachmentId";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperAttachmentId": lngPaperAttachmentId,
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
const objPaperAttachment = PaperAttachment_GetObjFromJsonObj(returnObj);
return objPaperAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperAttachment_GetObjByPaperAttachmentId_Cache(lngPaperAttachmentId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperAttachmentId_Cache";

if (lngPaperAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperAttachmentId]不能为空！(In clsPaperAttachmentWApi.GetObjByPaperAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrPaperAttachment_Sel: Array <clsPaperAttachmentEN> = arrPaperAttachmentObjLst_Cache.filter(x => 
 x.paperAttachmentId == lngPaperAttachmentId );
let objPaperAttachment: clsPaperAttachmentEN;
if (arrPaperAttachment_Sel.length > 0)
{
objPaperAttachment = arrPaperAttachment_Sel[0];
return objPaperAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPaperAttachment_Const = await PaperAttachment_GetObjByPaperAttachmentIdAsync(lngPaperAttachmentId);
if (objPaperAttachment_Const != null)
{
PaperAttachment_ReFreshThisCache(strid_CurrEduCls);
return objPaperAttachment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttachmentId, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperAttachment_GetObjByPaperAttachmentId_localStorage(lngPaperAttachmentId: number) {
const strThisFuncName = "GetObjByPaperAttachmentId_localStorage";

if (lngPaperAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperAttachmentId]不能为空！(In clsPaperAttachmentWApi.GetObjByPaperAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, lngPaperAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperAttachment_Cache: clsPaperAttachmentEN = JSON.parse(strTempObj);
return objPaperAttachment_Cache;
}
try
{
const objPaperAttachment = await PaperAttachment_GetObjByPaperAttachmentIdAsync(lngPaperAttachmentId);
if (objPaperAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperAttachment;
}
return objPaperAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttachmentId, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperAttachment:所给的对象
 * @returns 对象
*/
export async function PaperAttachment_UpdateObjInLst_Cache(objPaperAttachment: clsPaperAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrPaperAttachmentObjLst_Cache.find(x => x.paperAttachmentName == objPaperAttachment.paperAttachmentName && x.paperId == objPaperAttachment.paperId);
if (obj != null)
{
objPaperAttachment.paperAttachmentId = obj.paperAttachmentId;
ObjectAssign( obj, objPaperAttachment);
}
else
{
arrPaperAttachmentObjLst_Cache.push(objPaperAttachment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperAttachment_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function PaperAttachment_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperAttachmentWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperAttachmentWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsPaperAttachmentEN.con_PaperAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPaperAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperAttachmentId = Number(strInValue);
if (lngPaperAttachmentId == 0)
{
return "";
}
const objPaperAttachment = await PaperAttachment_GetObjByPaperAttachmentId_Cache(lngPaperAttachmentId , strid_CurrEduCls_C);
if (objPaperAttachment == null) return "";
if (objPaperAttachment.GetFldValue(strOutFldName) == null) return "";
return objPaperAttachment.GetFldValue(strOutFldName).toString();
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
export function PaperAttachment_SortFun_Defa(a:clsPaperAttachmentEN , b:clsPaperAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperAttachmentId-b.paperAttachmentId;
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
export function PaperAttachment_SortFun_Defa_2Fld(a:clsPaperAttachmentEN , b:clsPaperAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperAttachmentName == b.paperAttachmentName) return a.paperId.localeCompare(b.paperId);
else return a.paperAttachmentName.localeCompare(b.paperAttachmentName);
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
export function PaperAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperAttachmentEN.con_PaperAttachmentId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
return a.paperAttachmentId-b.paperAttachmentId;
}
case clsPaperAttachmentEN.con_PaperAttachmentName:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.paperAttachmentName == null) return -1;
if (b.paperAttachmentName == null) return 1;
return a.paperAttachmentName.localeCompare(b.paperAttachmentName);
}
case clsPaperAttachmentEN.con_PaperId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsPaperAttachmentEN.con_FilePath:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsPaperAttachmentEN.con_id_CurrEduCls:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsPaperAttachmentEN.con_UpdUserId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.updUserId == null) return -1;
if (b.updUserId == null) return 1;
return a.updUserId.localeCompare(b.updUserId);
}
case clsPaperAttachmentEN.con_UpdDate:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsPaperAttachmentEN.con_Memo:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAttachment]中不存在！(in ${ paperAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperAttachmentEN.con_PaperAttachmentId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
return b.paperAttachmentId-a.paperAttachmentId;
}
case clsPaperAttachmentEN.con_PaperAttachmentName:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.paperAttachmentName == null) return -1;
if (a.paperAttachmentName == null) return 1;
return b.paperAttachmentName.localeCompare(a.paperAttachmentName);
}
case clsPaperAttachmentEN.con_PaperId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsPaperAttachmentEN.con_FilePath:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsPaperAttachmentEN.con_id_CurrEduCls:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsPaperAttachmentEN.con_UpdUserId:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.updUserId == null) return -1;
if (a.updUserId == null) return 1;
return b.updUserId.localeCompare(a.updUserId);
}
case clsPaperAttachmentEN.con_UpdDate:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsPaperAttachmentEN.con_Memo:
return (a: clsPaperAttachmentEN, b: clsPaperAttachmentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAttachment]中不存在！(in ${ paperAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperAttachmentEN.con_PaperAttachmentId:
return (obj: clsPaperAttachmentEN) => {
return obj.paperAttachmentId === value;
}
case clsPaperAttachmentEN.con_PaperAttachmentName:
return (obj: clsPaperAttachmentEN) => {
return obj.paperAttachmentName === value;
}
case clsPaperAttachmentEN.con_PaperId:
return (obj: clsPaperAttachmentEN) => {
return obj.paperId === value;
}
case clsPaperAttachmentEN.con_FilePath:
return (obj: clsPaperAttachmentEN) => {
return obj.filePath === value;
}
case clsPaperAttachmentEN.con_id_CurrEduCls:
return (obj: clsPaperAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
case clsPaperAttachmentEN.con_UpdUserId:
return (obj: clsPaperAttachmentEN) => {
return obj.updUserId === value;
}
case clsPaperAttachmentEN.con_UpdDate:
return (obj: clsPaperAttachmentEN) => {
return obj.updDate === value;
}
case clsPaperAttachmentEN.con_Memo:
return (obj: clsPaperAttachmentEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAttachment]中不存在！(in ${ paperAttachment_ConstructorName}.${ strThisFuncName})`;
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function PaperAttachment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperAttachmentWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperAttachmentWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsPaperAttachmentEN.con_PaperAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrPaperAttachment = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrPaperAttachment == null) return [];
let arrPaperAttachment_Sel = arrPaperAttachment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPaperAttachment_Sel.length == 0) return [];
return arrPaperAttachment_Sel.map(x=>x.paperAttachmentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperAttachmentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const objPaperAttachment = PaperAttachment_GetObjFromJsonObj(returnObj);
return objPaperAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperAttachmentExObjLst_Cache: Array<clsPaperAttachmentEN> = CacheHelper.Get(strKey);
const arrPaperAttachmentObjLst_T = PaperAttachment_GetObjLstByJSONObjLst(arrPaperAttachmentExObjLst_Cache);
return arrPaperAttachmentObjLst_T;
}
try
{
const arrPaperAttachmentExObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAttachment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAttachmentEN.CacheAddiCondition);
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
const arrPaperAttachmentExObjLst_Cache: Array<clsPaperAttachmentEN> = JSON.parse(strTempObjLst);
const arrPaperAttachmentObjLst_T = PaperAttachment_GetObjLstByJSONObjLst(arrPaperAttachmentExObjLst_Cache);
return arrPaperAttachmentObjLst_T;
}
try
{
const arrPaperAttachmentExObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperAttachmentObjLst_Cache: Array<clsPaperAttachmentEN> = JSON.parse(strTempObjLst);
return arrPaperAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAttachmentEN.CacheAddiCondition);
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
const arrPaperAttachmentExObjLst_Cache: Array<clsPaperAttachmentEN> = JSON.parse(strTempObjLst);
const arrPaperAttachmentObjLst_T = PaperAttachment_GetObjLstByJSONObjLst(arrPaperAttachmentExObjLst_Cache);
return arrPaperAttachmentObjLst_T;
}
try
{
const arrPaperAttachmentExObjLst = await PaperAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperAttachmentObjLst_Cache: Array<clsPaperAttachmentEN> = JSON.parse(strTempObjLst);
return arrPaperAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAttachment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsPaperAttachmentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsPaperAttachmentWApi.PaperAttachment_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsPaperAttachmentWApi.PaperAttachment_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrPaperAttachmentObjLst_Cache;
switch (clsPaperAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrPaperAttachmentObjLst = PaperAttachment_GetObjLstByJSONObjLst(arrPaperAttachmentObjLst_Cache);
return arrPaperAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAttachment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperAttachmentObjLst_Cache;
switch (clsPaperAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperAttachmentObjLst_Cache = null;
break;
default:
arrPaperAttachmentObjLst_Cache = null;
break;
}
return arrPaperAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperAttachment_GetSubObjLst_Cache(objPaperAttachment_Cond: clsPaperAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
let arrPaperAttachment_Sel: Array < clsPaperAttachmentEN > = arrPaperAttachmentObjLst_Cache;
if (objPaperAttachment_Cond.sf_FldComparisonOp == null || objPaperAttachment_Cond.sf_FldComparisonOp == "") return arrPaperAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperAttachment_Cond), paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function PaperAttachment_GetObjLstByPaperAttachmentIdLstAsync(arrPaperAttachmentId: Array<string>): Promise<Array<clsPaperAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPaperAttachmentIdLstAsync";
const strAction = "GetObjLstByPaperAttachmentIdLst";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperAttachmentIdLst:关键字列表
 * @returns 对象列表
*/
export async function PaperAttachment_GetObjLstByPaperAttachmentIdLst_Cache(arrPaperAttachmentIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPaperAttachmentIdLst_Cache";
try
{
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
const arrPaperAttachment_Sel: Array <clsPaperAttachmentEN> = arrPaperAttachmentObjLst_Cache.filter(x => arrPaperAttachmentIdLst.indexOf(x.paperAttachmentId)>-1);
return arrPaperAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperAttachmentIdLst.join(","), paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperAttachmentEN>();
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperAttachmentObjLst_Cache.length == 0) return arrPaperAttachmentObjLst_Cache;
let arrPaperAttachment_Sel = arrPaperAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperAttachment_Cond = new clsPaperAttachmentEN();
ObjectAssign(objPaperAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperAttachment_Sel.length == 0) return arrPaperAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperAttachment_Sel = arrPaperAttachment_Sel.sort(PaperAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperAttachment_Sel = arrPaperAttachment_Sel.sort(objPagerPara.sortFun);
}
arrPaperAttachment_Sel = arrPaperAttachment_Sel.slice(intStart, intEnd);     
return arrPaperAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperAttachmentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperAttachment_DelRecordAsync(lngPaperAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param arrPaperAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperAttachment_DelPaperAttachmentsAsync(arrPaperAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperAttachmentsAsync";
const strAction = "DelPaperAttachments";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_DelPaperAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperAttachmentsByCondAsync";
const strAction = "DelPaperAttachmentsByCond";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperAttachment_AddNewRecordAsync(objPaperAttachmentEN: clsPaperAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperAttachmentEN);
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperAttachment_AddNewRecordWithReturnKeyAsync(objPaperAttachmentEN: clsPaperAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperAttachment_AddNewRecordWithReturnKey(objPaperAttachmentEN: clsPaperAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperAttachmentEN.paperAttachmentId === null || objPaperAttachmentEN.paperAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperAttachment_UpdateRecordAsync(objPaperAttachmentEN: clsPaperAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperAttachmentEN.sfUpdFldSetStr === undefined || objPaperAttachmentEN.sfUpdFldSetStr === null || objPaperAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAttachmentEN.paperAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperAttachment_UpdateWithConditionAsync(objPaperAttachmentEN: clsPaperAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperAttachmentEN.sfUpdFldSetStr === undefined || objPaperAttachmentEN.sfUpdFldSetStr === null || objPaperAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAttachmentEN.paperAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
objPaperAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objlngPaperAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperAttachment_IsExistRecord_Cache(objPaperAttachment_Cond: clsPaperAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperAttachmentObjLst_Cache == null) return false;
let arrPaperAttachment_Sel: Array < clsPaperAttachmentEN > = arrPaperAttachmentObjLst_Cache;
if (objPaperAttachment_Cond.sf_FldComparisonOp == null || objPaperAttachment_Cond.sf_FldComparisonOp == "") return arrPaperAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperAttachment_Cond), paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PaperAttachment_IsExist(lngPaperAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperAttachmentId": lngPaperAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperAttachment_IsExist_Cache(lngPaperAttachmentId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperAttachmentObjLst_Cache == null) return false;
try
{
const arrPaperAttachment_Sel: Array <clsPaperAttachmentEN> = arrPaperAttachmentObjLst_Cache.filter(x => x.paperAttachmentId == lngPaperAttachmentId);
if (arrPaperAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperAttachmentId, paperAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PaperAttachment_IsExistAsync(lngPaperAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperAttachmentId": lngPaperAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperAttachment_GetRecCountByCond_Cache(objPaperAttachment_Cond: clsPaperAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperAttachmentObjLst_Cache = await PaperAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperAttachmentObjLst_Cache == null) return 0;
let arrPaperAttachment_Sel: Array < clsPaperAttachmentEN > = arrPaperAttachmentObjLst_Cache;
if (objPaperAttachment_Cond.sf_FldComparisonOp == null || objPaperAttachment_Cond.sf_FldComparisonOp == "") return arrPaperAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAttachment_Sel = arrPaperAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperAttachment_Cond), paperAttachment_ConstructorName, strThisFuncName);
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
export async function PaperAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAttachment_ConstructorName, strThisFuncName);
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
export function PaperAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperAttachment_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsPaperAttachmentWApi.clsPaperAttachmentWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsPaperAttachmentWApi.clsPaperAttachmentWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperAttachmentEN.CacheModeId)
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
export function PaperAttachment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsPaperAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperAttachmentEN.CacheModeId)
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
export function PaperAttachment_CheckPropertyNew(pobjPaperAttachmentEN: clsPaperAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 论文附件)!(clsPaperAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperAttachmentName) == false && GetStrLen(pobjPaperAttachmentEN.paperAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(paperAttachmentName)]的长度不能超过200(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.paperAttachmentName)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperId) == false && GetStrLen(pobjPaperAttachmentEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.paperId)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.filePath) == false && GetStrLen(pobjPaperAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.filePath)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjPaperAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.id_CurrEduCls)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updUserId) == false && GetStrLen(pobjPaperAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.updUserId)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updDate) == false && GetStrLen(pobjPaperAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.updDate)(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.memo) == false && GetStrLen(pobjPaperAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.memo)(clsPaperAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperAttachmentEN.paperAttachmentId && undefined !== pobjPaperAttachmentEN.paperAttachmentId && tzDataType.isNumber(pobjPaperAttachmentEN.paperAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文附件Id(paperAttachmentId)]的值:[$(pobjPaperAttachmentEN.paperAttachmentId)], 非法，应该为数值型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperAttachmentName) == false && undefined !== pobjPaperAttachmentEN.paperAttachmentName && tzDataType.isString(pobjPaperAttachmentEN.paperAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(paperAttachmentName)]的值:[$(pobjPaperAttachmentEN.paperAttachmentName)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperId) == false && undefined !== pobjPaperAttachmentEN.paperId && tzDataType.isString(pobjPaperAttachmentEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperAttachmentEN.paperId)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.filePath) == false && undefined !== pobjPaperAttachmentEN.filePath && tzDataType.isString(pobjPaperAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjPaperAttachmentEN.filePath)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.id_CurrEduCls) == false && undefined !== pobjPaperAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjPaperAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updUserId) == false && undefined !== pobjPaperAttachmentEN.updUserId && tzDataType.isString(pobjPaperAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjPaperAttachmentEN.updUserId)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updDate) == false && undefined !== pobjPaperAttachmentEN.updDate && tzDataType.isString(pobjPaperAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperAttachmentEN.updDate)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.memo) == false && undefined !== pobjPaperAttachmentEN.memo && tzDataType.isString(pobjPaperAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperAttachmentEN.memo)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperAttachment_CheckProperty4Update (pobjPaperAttachmentEN: clsPaperAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperAttachmentName) == false && GetStrLen(pobjPaperAttachmentEN.paperAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(paperAttachmentName)]的长度不能超过200(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.paperAttachmentName)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperId) == false && GetStrLen(pobjPaperAttachmentEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.paperId)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.filePath) == false && GetStrLen(pobjPaperAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.filePath)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjPaperAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.id_CurrEduCls)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updUserId) == false && GetStrLen(pobjPaperAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.updUserId)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updDate) == false && GetStrLen(pobjPaperAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.updDate)(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.memo) == false && GetStrLen(pobjPaperAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文附件(PaperAttachment))!值:$(pobjPaperAttachmentEN.memo)(clsPaperAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperAttachmentEN.paperAttachmentId && undefined !== pobjPaperAttachmentEN.paperAttachmentId && tzDataType.isNumber(pobjPaperAttachmentEN.paperAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文附件Id(paperAttachmentId)]的值:[$(pobjPaperAttachmentEN.paperAttachmentId)], 非法，应该为数值型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperAttachmentName) == false && undefined !== pobjPaperAttachmentEN.paperAttachmentName && tzDataType.isString(pobjPaperAttachmentEN.paperAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(paperAttachmentName)]的值:[$(pobjPaperAttachmentEN.paperAttachmentName)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.paperId) == false && undefined !== pobjPaperAttachmentEN.paperId && tzDataType.isString(pobjPaperAttachmentEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperAttachmentEN.paperId)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.filePath) == false && undefined !== pobjPaperAttachmentEN.filePath && tzDataType.isString(pobjPaperAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjPaperAttachmentEN.filePath)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.id_CurrEduCls) == false && undefined !== pobjPaperAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjPaperAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updUserId) == false && undefined !== pobjPaperAttachmentEN.updUserId && tzDataType.isString(pobjPaperAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjPaperAttachmentEN.updUserId)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.updDate) == false && undefined !== pobjPaperAttachmentEN.updDate && tzDataType.isString(pobjPaperAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperAttachmentEN.updDate)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAttachmentEN.memo) == false && undefined !== pobjPaperAttachmentEN.memo && tzDataType.isString(pobjPaperAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperAttachmentEN.memo)], 非法，应该为字符型(In 论文附件(PaperAttachment))!(clsPaperAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperAttachmentEN.paperAttachmentId 
 || pobjPaperAttachmentEN.paperAttachmentId != null && pobjPaperAttachmentEN.paperAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[论文附件Id]不能为空(In 论文附件)!(clsPaperAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperAttachment_GetJSONStrByObj (pobjPaperAttachmentEN: clsPaperAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperAttachmentEN.sfUpdFldSetStr = pobjPaperAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperAttachmentEN);
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
export function PaperAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsPaperAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperAttachmentObjLst = new Array<clsPaperAttachmentEN>();
if (strJSON === "")
{
return arrPaperAttachmentObjLst;
}
try
{
arrPaperAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperAttachmentObjLst;
}
return arrPaperAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperAttachment_GetObjLstByJSONObjLst (arrPaperAttachmentObjLstS: Array<clsPaperAttachmentEN>): Array<clsPaperAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperAttachmentObjLst = new Array<clsPaperAttachmentEN>();
for (const objInFor of arrPaperAttachmentObjLstS) {
const obj1 = PaperAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperAttachmentObjLst.push(obj1);
}
return arrPaperAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperAttachment_GetObjByJSONStr (strJSON: string): clsPaperAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperAttachmentEN = new clsPaperAttachmentEN();
if (strJSON === "")
{
return pobjPaperAttachmentEN;
}
try
{
pobjPaperAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperAttachmentEN;
}
return pobjPaperAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperAttachment_GetCombineCondition(objPaperAttachment_Cond: clsPaperAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_PaperAttachmentId) == true)
{
const strComparisonOp_PaperAttachmentId:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_PaperAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperAttachmentEN.con_PaperAttachmentId, objPaperAttachment_Cond.paperAttachmentId, strComparisonOp_PaperAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_PaperAttachmentName) == true)
{
const strComparisonOp_PaperAttachmentName:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_PaperAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_PaperAttachmentName, objPaperAttachment_Cond.paperAttachmentName, strComparisonOp_PaperAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_PaperId, objPaperAttachment_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_FilePath, objPaperAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_id_CurrEduCls, objPaperAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_UpdUserId, objPaperAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_UpdDate, objPaperAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperAttachment_Cond.dicFldComparisonOp, clsPaperAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperAttachment_Cond.dicFldComparisonOp[clsPaperAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAttachmentEN.con_Memo, objPaperAttachment_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperAttachment(论文附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperAttachmentName: 附件名称(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperAttachment_GetUniCondStr_PaperAttachmentName_PaperId(objPaperAttachmentEN: clsPaperAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.paperAttachmentName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperAttachmentEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperAttachment(论文附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperAttachmentName: 附件名称(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperAttachment_GetUniCondStr4Update_PaperAttachmentName_PaperId(objPaperAttachmentEN: clsPaperAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperAttachmentId <> '{0}'", objPaperAttachmentEN.paperAttachmentId);
 strWhereCond +=  Format(" and PaperAttachmentName = '{0}'", objPaperAttachmentEN.paperAttachmentName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperAttachmentEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperAttachmentENS:源对象
 * @param objPaperAttachmentENT:目标对象
*/
export function PaperAttachment_CopyObjTo(objPaperAttachmentENS: clsPaperAttachmentEN , objPaperAttachmentENT: clsPaperAttachmentEN ): void 
{
objPaperAttachmentENT.paperAttachmentId = objPaperAttachmentENS.paperAttachmentId; //论文附件Id
objPaperAttachmentENT.paperAttachmentName = objPaperAttachmentENS.paperAttachmentName; //附件名称
objPaperAttachmentENT.paperId = objPaperAttachmentENS.paperId; //论文Id
objPaperAttachmentENT.filePath = objPaperAttachmentENS.filePath; //文件路径
objPaperAttachmentENT.id_CurrEduCls = objPaperAttachmentENS.id_CurrEduCls; //教学班流水号
objPaperAttachmentENT.updUserId = objPaperAttachmentENS.updUserId; //修改用户Id
objPaperAttachmentENT.updDate = objPaperAttachmentENS.updDate; //修改日期
objPaperAttachmentENT.memo = objPaperAttachmentENS.memo; //备注
objPaperAttachmentENT.sfUpdFldSetStr = objPaperAttachmentENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperAttachmentENS:源对象
 * @param objPaperAttachmentENT:目标对象
*/
export function PaperAttachment_GetObjFromJsonObj(objPaperAttachmentENS: clsPaperAttachmentEN): clsPaperAttachmentEN 
{
 const objPaperAttachmentENT: clsPaperAttachmentEN = new clsPaperAttachmentEN();
ObjectAssign(objPaperAttachmentENT, objPaperAttachmentENS);
 return objPaperAttachmentENT;
}