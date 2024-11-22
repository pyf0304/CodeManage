﻿
 /**
 * 类名:clsvgs_PaperAttentionWApi
 * 表名:vgs_PaperAttention(01120750)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:26
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
 * 论文关注视图(vgs_PaperAttention)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvgs_PaperAttentionEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PaperAttentionEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PaperAttention_Controller = "vgs_PaperAttentionApi";
 export const vgs_PaperAttention_ConstructorName = "vgs_PaperAttention";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperAttentionId:关键字
 * @returns 对象
 **/
export async function vgs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId: number): Promise<clsvgs_PaperAttentionEN|null>  
{
const strThisFuncName = "GetObjByPaperAttentionIdAsync";

if (lngPaperAttentionId == 0)
{
  const strMsg = Format("参数:[lngPaperAttentionId]不能为空！(In clsvgs_PaperAttentionWApi.GetObjByPaperAttentionIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperAttentionId";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperAttentionId": lngPaperAttentionId,
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
const objvgs_PaperAttention = vgs_PaperAttention_GetObjFromJsonObj(returnObj);
return objvgs_PaperAttention;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttentionId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperAttention_GetObjByPaperAttentionId_Cache(lngPaperAttentionId:number,strUserId:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperAttentionId_Cache";

if (lngPaperAttentionId == 0)
{
  const strMsg = Format("参数:[lngPaperAttentionId]不能为空！(In clsvgs_PaperAttentionWApi.GetObjByPaperAttentionId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
try
{
const arrvgs_PaperAttention_Sel: Array <clsvgs_PaperAttentionEN> = arrvgs_PaperAttentionObjLst_Cache.filter(x => 
 x.paperAttentionId == lngPaperAttentionId );
let objvgs_PaperAttention: clsvgs_PaperAttentionEN;
if (arrvgs_PaperAttention_Sel.length > 0)
{
objvgs_PaperAttention = arrvgs_PaperAttention_Sel[0];
return objvgs_PaperAttention;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvgs_PaperAttention_Const = await vgs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
if (objvgs_PaperAttention_Const != null)
{
vgs_PaperAttention_ReFreshThisCache(strUserId);
return objvgs_PaperAttention_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttentionId, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperAttentionId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperAttention_GetObjByPaperAttentionId_localStorage(lngPaperAttentionId: number) {
const strThisFuncName = "GetObjByPaperAttentionId_localStorage";

if (lngPaperAttentionId == 0)
{
  const strMsg = Format("参数:[lngPaperAttentionId]不能为空！(In clsvgs_PaperAttentionWApi.GetObjByPaperAttentionId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, lngPaperAttentionId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_PaperAttention_Cache: clsvgs_PaperAttentionEN = JSON.parse(strTempObj);
return objvgs_PaperAttention_Cache;
}
try
{
const objvgs_PaperAttention = await vgs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
if (objvgs_PaperAttention != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_PaperAttention));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_PaperAttention;
}
return objvgs_PaperAttention;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttentionId, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
 @param strUserId:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vgs_PaperAttention_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strUserId_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strUserId_C) == true)
{
  const strMsg = Format("参数:[strUserId_C]不能为空！(In clsvgs_PaperAttentionWApi.func)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName != clsvgs_PaperAttentionEN.con_PaperAttentionId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_PaperAttentionEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvgs_PaperAttentionEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperAttentionId = Number(strInValue);
if (lngPaperAttentionId == 0)
{
return "";
}
const objvgs_PaperAttention = await vgs_PaperAttention_GetObjByPaperAttentionId_Cache(lngPaperAttentionId , strUserId_C);
if (objvgs_PaperAttention == null) return "";
if (objvgs_PaperAttention.GetFldValue(strOutFldName) == null) return "";
return objvgs_PaperAttention.GetFldValue(strOutFldName).toString();
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
export function vgs_PaperAttention_SortFun_Defa(a:clsvgs_PaperAttentionEN , b:clsvgs_PaperAttentionEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperAttentionId-b.paperAttentionId;
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
export function vgs_PaperAttention_SortFun_Defa_2Fld(a:clsvgs_PaperAttentionEN , b:clsvgs_PaperAttentionEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.paperTitle.localeCompare(b.paperTitle);
else return a.paperId.localeCompare(b.paperId);
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
export function vgs_PaperAttention_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PaperAttentionEN.con_PaperAttentionId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.paperAttentionId-b.paperAttentionId;
}
case clsvgs_PaperAttentionEN.con_PaperId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PaperAttentionEN.con_PaperTitle:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_PaperAttentionEN.con_Author:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsvgs_PaperAttentionEN.con_Keyword:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.keyword == null) return -1;
if (b.keyword == null) return 1;
return a.keyword.localeCompare(b.keyword);
}
case clsvgs_PaperAttentionEN.con_BrowseNumber:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.browseNumber-b.browseNumber;
}
case clsvgs_PaperAttentionEN.con_UserId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
case clsvgs_PaperAttentionEN.con_PaperGroupId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.paperGroupId == null) return -1;
if (b.paperGroupId == null) return 1;
return a.paperGroupId.localeCompare(b.paperGroupId);
}
case clsvgs_PaperAttentionEN.con_UpdUser:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PaperAttentionEN.con_UpdDate:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PaperAttentionEN.con_Meno:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.meno == null) return -1;
if (b.meno == null) return 1;
return a.meno.localeCompare(b.meno);
}
case clsvgs_PaperAttentionEN.con_PaperGroupName:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (a.paperGroupName == null) return -1;
if (b.paperGroupName == null) return 1;
return a.paperGroupName.localeCompare(b.paperGroupName);
}
case clsvgs_PaperAttentionEN.con_PaperQCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.paperQCount-b.paperQCount;
}
case clsvgs_PaperAttentionEN.con_SubVCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.subVCount-b.subVCount;
}
case clsvgs_PaperAttentionEN.con_TagsCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.tagsCount-b.tagsCount;
}
case clsvgs_PaperAttentionEN.con_TeaQCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return a.teaQCount-b.teaQCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperAttention]中不存在！(in ${ vgs_PaperAttention_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PaperAttentionEN.con_PaperAttentionId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.paperAttentionId-a.paperAttentionId;
}
case clsvgs_PaperAttentionEN.con_PaperId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PaperAttentionEN.con_PaperTitle:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_PaperAttentionEN.con_Author:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsvgs_PaperAttentionEN.con_Keyword:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.keyword == null) return -1;
if (a.keyword == null) return 1;
return b.keyword.localeCompare(a.keyword);
}
case clsvgs_PaperAttentionEN.con_BrowseNumber:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.browseNumber-a.browseNumber;
}
case clsvgs_PaperAttentionEN.con_UserId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
case clsvgs_PaperAttentionEN.con_PaperGroupId:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.paperGroupId == null) return -1;
if (a.paperGroupId == null) return 1;
return b.paperGroupId.localeCompare(a.paperGroupId);
}
case clsvgs_PaperAttentionEN.con_UpdUser:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PaperAttentionEN.con_UpdDate:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PaperAttentionEN.con_Meno:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.meno == null) return -1;
if (a.meno == null) return 1;
return b.meno.localeCompare(a.meno);
}
case clsvgs_PaperAttentionEN.con_PaperGroupName:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
if (b.paperGroupName == null) return -1;
if (a.paperGroupName == null) return 1;
return b.paperGroupName.localeCompare(a.paperGroupName);
}
case clsvgs_PaperAttentionEN.con_PaperQCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.paperQCount-a.paperQCount;
}
case clsvgs_PaperAttentionEN.con_SubVCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.subVCount-a.subVCount;
}
case clsvgs_PaperAttentionEN.con_TagsCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.tagsCount-a.tagsCount;
}
case clsvgs_PaperAttentionEN.con_TeaQCount:
return (a: clsvgs_PaperAttentionEN, b: clsvgs_PaperAttentionEN) => {
return b.teaQCount-a.teaQCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperAttention]中不存在！(in ${ vgs_PaperAttention_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperAttention_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PaperAttentionEN.con_PaperAttentionId:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperAttentionId === value;
}
case clsvgs_PaperAttentionEN.con_PaperId:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperId === value;
}
case clsvgs_PaperAttentionEN.con_PaperTitle:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperTitle === value;
}
case clsvgs_PaperAttentionEN.con_Author:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.author === value;
}
case clsvgs_PaperAttentionEN.con_Keyword:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.keyword === value;
}
case clsvgs_PaperAttentionEN.con_BrowseNumber:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.browseNumber === value;
}
case clsvgs_PaperAttentionEN.con_UserId:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.userId === value;
}
case clsvgs_PaperAttentionEN.con_PaperGroupId:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperGroupId === value;
}
case clsvgs_PaperAttentionEN.con_UpdUser:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.updUser === value;
}
case clsvgs_PaperAttentionEN.con_UpdDate:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.updDate === value;
}
case clsvgs_PaperAttentionEN.con_Meno:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.meno === value;
}
case clsvgs_PaperAttentionEN.con_PaperGroupName:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperGroupName === value;
}
case clsvgs_PaperAttentionEN.con_PaperQCount:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.paperQCount === value;
}
case clsvgs_PaperAttentionEN.con_SubVCount:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.subVCount === value;
}
case clsvgs_PaperAttentionEN.con_TagsCount:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.tagsCount === value;
}
case clsvgs_PaperAttentionEN.con_TeaQCount:
return (obj: clsvgs_PaperAttentionEN) => {
return obj.teaQCount === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperAttention]中不存在！(in ${ vgs_PaperAttention_ConstructorName}.${ strThisFuncName})`;
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
 @param strUserId:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function vgs_PaperAttention_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strUserId_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strUserId_C) == true)
{
  const strMsg = Format("参数:[strUserId_C]不能为空！(In clsvgs_PaperAttentionWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName == clsvgs_PaperAttentionEN.con_PaperAttentionId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrvgs_PaperAttention = await vgs_PaperAttention_GetObjLst_Cache(strUserId_C);
if (arrvgs_PaperAttention == null) return [];
let arrvgs_PaperAttention_Sel = arrvgs_PaperAttention;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvgs_PaperAttention_Sel.length == 0) return [];
return arrvgs_PaperAttention_Sel.map(x=>x.paperAttentionId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vgs_PaperAttention_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PaperAttentionEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const objvgs_PaperAttention = vgs_PaperAttention_GetObjFromJsonObj(returnObj);
return objvgs_PaperAttention;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetObjLst_ClientCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_PaperAttentionEN.WhereFormat, strUserId);
}
else
{
strWhereCond = Format("UserId='{0}'", strUserId);
}
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperAttentionEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_PaperAttentionExObjLst_Cache: Array<clsvgs_PaperAttentionEN> = CacheHelper.Get(strKey);
const arrvgs_PaperAttentionObjLst_T = vgs_PaperAttention_GetObjLstByJSONObjLst(arrvgs_PaperAttentionExObjLst_Cache);
return arrvgs_PaperAttentionObjLst_T;
}
try
{
const arrvgs_PaperAttentionExObjLst = await vgs_PaperAttention_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_PaperAttentionExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperAttentionExObjLst.length);
console.log(strInfo);
return arrvgs_PaperAttentionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperAttention_GetObjLst_localStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_PaperAttentionEN.WhereFormat, strUserId);
}
else
{
strWhereCond = Format("UserId='{0}'", strUserId);
}
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperAttentionEN.CacheAddiCondition);
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
const arrvgs_PaperAttentionExObjLst_Cache: Array<clsvgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperAttentionObjLst_T = vgs_PaperAttention_GetObjLstByJSONObjLst(arrvgs_PaperAttentionExObjLst_Cache);
return arrvgs_PaperAttentionObjLst_T;
}
try
{
const arrvgs_PaperAttentionExObjLst = await vgs_PaperAttention_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_PaperAttentionExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperAttentionExObjLst.length);
console.log(strInfo);
return arrvgs_PaperAttentionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperAttention_GetObjLst_localStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_PaperAttentionObjLst_Cache: Array<clsvgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperAttentionObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_PaperAttention_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PaperAttentionEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetObjLst_sessionStorage(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.WhereFormat) == false)
{
strWhereCond = Format(clsvgs_PaperAttentionEN.WhereFormat, strUserId);
}
else
{
strWhereCond = Format("UserId='{0}'", strUserId);
}
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
if (IsNullOrEmpty(clsvgs_PaperAttentionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperAttentionEN.CacheAddiCondition);
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
const arrvgs_PaperAttentionExObjLst_Cache: Array<clsvgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperAttentionObjLst_T = vgs_PaperAttention_GetObjLstByJSONObjLst(arrvgs_PaperAttentionExObjLst_Cache);
return arrvgs_PaperAttentionObjLst_T;
}
try
{
const arrvgs_PaperAttentionExObjLst = await vgs_PaperAttention_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_PaperAttentionExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperAttentionExObjLst.length);
console.log(strInfo);
return arrvgs_PaperAttentionExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperAttention_GetObjLst_sessionStorage_PureCache(strUserId: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UserId='{0}'", strUserId);
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_PaperAttentionObjLst_Cache: Array<clsvgs_PaperAttentionEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperAttentionObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperAttention_GetObjLst_Cache(strUserId: string): Promise<Array<clsvgs_PaperAttentionEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
const strMsg = Format("缓存分类变量:[UserId]不能为空！(in clsvgs_PaperAttentionWApi.vgs_PaperAttention_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
let arrvgs_PaperAttentionObjLst_Cache;
switch (clsvgs_PaperAttentionEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_sessionStorage(strUserId);
break;
case "03"://localStorage
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_localStorage(strUserId);
break;
case "02"://ClientCache
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_ClientCache(strUserId);
break;
default:
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_ClientCache(strUserId);
break;
}
const arrvgs_PaperAttentionObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(arrvgs_PaperAttentionObjLst_Cache);
return arrvgs_PaperAttentionObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperAttention_GetObjLst_PureCache(strUserId: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_PaperAttentionObjLst_Cache;
switch (clsvgs_PaperAttentionEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_sessionStorage_PureCache(strUserId);
break;
case "03"://localStorage
arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_localStorage_PureCache(strUserId);
break;
case "02"://ClientCache
arrvgs_PaperAttentionObjLst_Cache = null;
break;
default:
arrvgs_PaperAttentionObjLst_Cache = null;
break;
}
return arrvgs_PaperAttentionObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperAttentionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_PaperAttention_GetSubObjLst_Cache(objvgs_PaperAttention_Cond: clsvgs_PaperAttentionEN,strUserId: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
let arrvgs_PaperAttention_Sel: Array < clsvgs_PaperAttentionEN > = arrvgs_PaperAttentionObjLst_Cache;
if (objvgs_PaperAttention_Cond.sf_FldComparisonOp == null || objvgs_PaperAttention_Cond.sf_FldComparisonOp == "") return arrvgs_PaperAttention_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperAttention_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperAttention_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperAttention_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperAttention_Cond), vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperAttentionEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperAttentionId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_PaperAttention_GetObjLstByPaperAttentionIdLstAsync(arrPaperAttentionId: Array<string>): Promise<Array<clsvgs_PaperAttentionEN>>  
{
const strThisFuncName = "GetObjLstByPaperAttentionIdLstAsync";
const strAction = "GetObjLstByPaperAttentionIdLst";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperAttentionId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperAttentionIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_PaperAttention_GetObjLstByPaperAttentionIdLst_Cache(arrPaperAttentionIdLst: Array<number>,strUserId: string) {
const strThisFuncName = "GetObjLstByPaperAttentionIdLst_Cache";
try
{
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
const arrvgs_PaperAttention_Sel: Array <clsvgs_PaperAttentionEN> = arrvgs_PaperAttentionObjLst_Cache.filter(x => arrPaperAttentionIdLst.indexOf(x.paperAttentionId)>-1);
return arrvgs_PaperAttention_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperAttentionIdLst.join(","), vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PaperAttentionEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PaperAttentionEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strUserId: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_PaperAttentionEN>();
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
if (arrvgs_PaperAttentionObjLst_Cache.length == 0) return arrvgs_PaperAttentionObjLst_Cache;
let arrvgs_PaperAttention_Sel = arrvgs_PaperAttentionObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_PaperAttention_Cond = new clsvgs_PaperAttentionEN();
ObjectAssign(objvgs_PaperAttention_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperAttention_Sel.length == 0) return arrvgs_PaperAttention_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(vgs_PaperAttention_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
}
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.slice(intStart, intEnd);     
return arrvgs_PaperAttention_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperAttentionEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_PaperAttention_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PaperAttentionEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvgs_PaperAttentionEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param objlngPaperAttentionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_PaperAttention_IsExistRecord_Cache(objvgs_PaperAttention_Cond: clsvgs_PaperAttentionEN,strUserId: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
if (arrvgs_PaperAttentionObjLst_Cache == null) return false;
let arrvgs_PaperAttention_Sel: Array < clsvgs_PaperAttentionEN > = arrvgs_PaperAttentionObjLst_Cache;
if (objvgs_PaperAttention_Cond.sf_FldComparisonOp == null || objvgs_PaperAttention_Cond.sf_FldComparisonOp == "") return arrvgs_PaperAttention_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperAttention_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperAttention_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperAttention_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_PaperAttention_Cond), vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttentionId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_PaperAttention_IsExist(lngPaperAttentionId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperAttentionId": lngPaperAttentionId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param lngPaperAttentionId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperAttention_IsExist_Cache(lngPaperAttentionId:number,strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
if (arrvgs_PaperAttentionObjLst_Cache == null) return false;
try
{
const arrvgs_PaperAttention_Sel: Array <clsvgs_PaperAttentionEN> = arrvgs_PaperAttentionObjLst_Cache.filter(x => x.paperAttentionId == lngPaperAttentionId);
if (arrvgs_PaperAttention_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperAttentionId, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperAttentionId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_PaperAttention_IsExistAsync(lngPaperAttentionId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperAttentionId": lngPaperAttentionId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export async function vgs_PaperAttention_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PaperAttention_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperAttention_ConstructorName, strThisFuncName);
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
 * @param objvgs_PaperAttention_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_PaperAttention_GetRecCountByCond_Cache(objvgs_PaperAttention_Cond: clsvgs_PaperAttentionEN,strUserId: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_PaperAttentionObjLst_Cache = await vgs_PaperAttention_GetObjLst_Cache(strUserId);
if (arrvgs_PaperAttentionObjLst_Cache == null) return 0;
let arrvgs_PaperAttention_Sel: Array < clsvgs_PaperAttentionEN > = arrvgs_PaperAttentionObjLst_Cache;
if (objvgs_PaperAttention_Cond.sf_FldComparisonOp == null || objvgs_PaperAttention_Cond.sf_FldComparisonOp == "") return arrvgs_PaperAttention_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperAttention_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperAttention_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperAttention_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperAttention_Sel = arrvgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperAttention_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperAttention_Cond), vgs_PaperAttention_ConstructorName, strThisFuncName);
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
export function vgs_PaperAttention_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_PaperAttention_ReFreshThisCache(strUserId: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvgs_PaperAttentionEN._CurrTabName, strUserId);
switch (clsvgs_PaperAttentionEN.CacheModeId)
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperAttention_GetJSONStrByObj (pobjvgs_PaperAttentionEN: clsvgs_PaperAttentionEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PaperAttentionEN);
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
export function vgs_PaperAttention_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PaperAttentionEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PaperAttentionObjLst = new Array<clsvgs_PaperAttentionEN>();
if (strJSON === "")
{
return arrvgs_PaperAttentionObjLst;
}
try
{
arrvgs_PaperAttentionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PaperAttentionObjLst;
}
return arrvgs_PaperAttentionObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PaperAttentionObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PaperAttention_GetObjLstByJSONObjLst (arrvgs_PaperAttentionObjLstS: Array<clsvgs_PaperAttentionEN>): Array<clsvgs_PaperAttentionEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PaperAttentionObjLst = new Array<clsvgs_PaperAttentionEN>();
for (const objInFor of arrvgs_PaperAttentionObjLstS) {
const obj1 = vgs_PaperAttention_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PaperAttentionObjLst.push(obj1);
}
return arrvgs_PaperAttentionObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperAttention_GetObjByJSONStr (strJSON: string): clsvgs_PaperAttentionEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
if (strJSON === "")
{
return pobjvgs_PaperAttentionEN;
}
try
{
pobjvgs_PaperAttentionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PaperAttentionEN;
}
return pobjvgs_PaperAttentionEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PaperAttention_GetCombineCondition(objvgs_PaperAttention_Cond: clsvgs_PaperAttentionEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperAttentionId) == true)
{
const strComparisonOp_PaperAttentionId:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperAttentionId];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_PaperAttentionId, objvgs_PaperAttention_Cond.paperAttentionId, strComparisonOp_PaperAttentionId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_PaperId, objvgs_PaperAttention_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_PaperTitle, objvgs_PaperAttention_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_Author, objvgs_PaperAttention_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_Keyword, objvgs_PaperAttention_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_BrowseNumber, objvgs_PaperAttention_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_UserId, objvgs_PaperAttention_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperGroupId) == true)
{
const strComparisonOp_PaperGroupId:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperGroupId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_PaperGroupId, objvgs_PaperAttention_Cond.paperGroupId, strComparisonOp_PaperGroupId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_UpdUser, objvgs_PaperAttention_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_UpdDate, objvgs_PaperAttention_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_Meno) == true)
{
const strComparisonOp_Meno:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_Meno];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_Meno, objvgs_PaperAttention_Cond.meno, strComparisonOp_Meno);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperGroupName) == true)
{
const strComparisonOp_PaperGroupName:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperGroupName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperAttentionEN.con_PaperGroupName, objvgs_PaperAttention_Cond.paperGroupName, strComparisonOp_PaperGroupName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_PaperQCount) == true)
{
const strComparisonOp_PaperQCount:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_PaperQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_PaperQCount, objvgs_PaperAttention_Cond.paperQCount, strComparisonOp_PaperQCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_SubVCount) == true)
{
const strComparisonOp_SubVCount:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_SubVCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_SubVCount, objvgs_PaperAttention_Cond.subVCount, strComparisonOp_SubVCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_TagsCount, objvgs_PaperAttention_Cond.tagsCount, strComparisonOp_TagsCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperAttention_Cond.dicFldComparisonOp, clsvgs_PaperAttentionEN.con_TeaQCount) == true)
{
const strComparisonOp_TeaQCount:string = objvgs_PaperAttention_Cond.dicFldComparisonOp[clsvgs_PaperAttentionEN.con_TeaQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperAttentionEN.con_TeaQCount, objvgs_PaperAttention_Cond.teaQCount, strComparisonOp_TeaQCount);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PaperAttentionENS:源对象
 * @param objvgs_PaperAttentionENT:目标对象
*/
export function vgs_PaperAttention_CopyObjTo(objvgs_PaperAttentionENS: clsvgs_PaperAttentionEN , objvgs_PaperAttentionENT: clsvgs_PaperAttentionEN ): void 
{
objvgs_PaperAttentionENT.paperAttentionId = objvgs_PaperAttentionENS.paperAttentionId; //论文收藏Id
objvgs_PaperAttentionENT.paperId = objvgs_PaperAttentionENS.paperId; //论文Id
objvgs_PaperAttentionENT.paperTitle = objvgs_PaperAttentionENS.paperTitle; //论文标题
objvgs_PaperAttentionENT.author = objvgs_PaperAttentionENS.author; //作者
objvgs_PaperAttentionENT.keyword = objvgs_PaperAttentionENS.keyword; //关键字
objvgs_PaperAttentionENT.browseNumber = objvgs_PaperAttentionENS.browseNumber; //浏览量
objvgs_PaperAttentionENT.userId = objvgs_PaperAttentionENS.userId; //用户ID
objvgs_PaperAttentionENT.paperGroupId = objvgs_PaperAttentionENS.paperGroupId; //组Id
objvgs_PaperAttentionENT.updUser = objvgs_PaperAttentionENS.updUser; //修改人
objvgs_PaperAttentionENT.updDate = objvgs_PaperAttentionENS.updDate; //修改日期
objvgs_PaperAttentionENT.meno = objvgs_PaperAttentionENS.meno; //备注
objvgs_PaperAttentionENT.paperGroupName = objvgs_PaperAttentionENS.paperGroupName; //组名
objvgs_PaperAttentionENT.paperQCount = objvgs_PaperAttentionENS.paperQCount; //论文答疑数
objvgs_PaperAttentionENT.subVCount = objvgs_PaperAttentionENS.subVCount; //论文子观点数
objvgs_PaperAttentionENT.tagsCount = objvgs_PaperAttentionENS.tagsCount; //论文标注数
objvgs_PaperAttentionENT.teaQCount = objvgs_PaperAttentionENS.teaQCount; //教师提问数
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PaperAttentionENS:源对象
 * @param objvgs_PaperAttentionENT:目标对象
*/
export function vgs_PaperAttention_GetObjFromJsonObj(objvgs_PaperAttentionENS: clsvgs_PaperAttentionEN): clsvgs_PaperAttentionEN 
{
 const objvgs_PaperAttentionENT: clsvgs_PaperAttentionEN = new clsvgs_PaperAttentionEN();
ObjectAssign(objvgs_PaperAttentionENT, objvgs_PaperAttentionENS);
 return objvgs_PaperAttentionENT;
}