
 /**
 * 类名:clsvgs_PaperParagraphWApi
 * 表名:vgs_PaperParagraph(01120747)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:43
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
 * 论文段落视图(vgs_PaperParagraph)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvgs_PaperParagraphEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PaperParagraph_Controller = "vgs_PaperParagraphApi";
 export const vgs_PaperParagraph_ConstructorName = "vgs_PaperParagraph";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strParagraphId:关键字
 * @returns 对象
 **/
export async function vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId: string): Promise<clsvgs_PaperParagraphEN>  
{
const strThisFuncName = "GetObjByParagraphIdAsync";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In GetObjByParagraphIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByParagraphId";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strParagraphId": strParagraphId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperParagraph = vgs_PaperParagraph_GetObjFromJsonObj(returnObj);
return objvgs_PaperParagraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param strParagraphId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByParagraphId_Cache";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In GetObjByParagraphId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
try
{
const arrvgs_PaperParagraph_Sel: Array <clsvgs_PaperParagraphEN> = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
let objvgs_PaperParagraph: clsvgs_PaperParagraphEN;
if (arrvgs_PaperParagraph_Sel.length > 0)
{
objvgs_PaperParagraph = arrvgs_PaperParagraph_Sel[0];
return objvgs_PaperParagraph;
}
else
{
if (bolTryAsyncOnce == true)
{
objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
if (objvgs_PaperParagraph != null)
{
vgs_PaperParagraph_ReFreshThisCache();
return objvgs_PaperParagraph;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strParagraphId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperParagraph_GetObjByParagraphId_localStorage(strParagraphId: string) {
const strThisFuncName = "GetObjByParagraphId_localStorage";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In GetObjByParagraphId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvgs_PaperParagraphEN._CurrTabName, strParagraphId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvgs_PaperParagraph_Cache: clsvgs_PaperParagraphEN = JSON.parse(strTempObj);
return objvgs_PaperParagraph_Cache;
}
try
{
const objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
if (objvgs_PaperParagraph != null)
{
localStorage.setItem(strKey, JSON.stringify(objvgs_PaperParagraph));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvgs_PaperParagraph;
}
return objvgs_PaperParagraph;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strParagraphId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperParagraph_GetNameByParagraphId_Cache(strParagraphId: string) {
const strThisFuncName = "GetNameByParagraphId_Cache";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In GetNameByParagraphId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrvgs_PaperParagraphObjLst_Cache == null) return "";
try
{
const arrvgs_PaperParagraph_Sel: Array <clsvgs_PaperParagraphEN> = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
let objvgs_PaperParagraph: clsvgs_PaperParagraphEN;
if (arrvgs_PaperParagraph_Sel.length > 0)
{
objvgs_PaperParagraph = arrvgs_PaperParagraph_Sel[0];
return objvgs_PaperParagraph.paragraphStateName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strParagraphId);
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
export async function vgs_PaperParagraph_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvgs_PaperParagraphEN.con_ParagraphId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvgs_PaperParagraphEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvgs_PaperParagraphEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strParagraphId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId );
if (objvgs_PaperParagraph == null) return "";
return objvgs_PaperParagraph.GetFldValue(strOutFldName).toString();
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
export function vgs_PaperParagraph_SortFun_Defa(a:clsvgs_PaperParagraphEN , b:clsvgs_PaperParagraphEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paragraphId.localeCompare(b.paragraphId);
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
export function vgs_PaperParagraph_SortFun_Defa_2Fld(a:clsvgs_PaperParagraphEN , b:clsvgs_PaperParagraphEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paragraphStateName == b.paragraphStateName) return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
else return a.paragraphStateName.localeCompare(b.paragraphStateName);
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
export function vgs_PaperParagraph_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PaperParagraphEN.con_ParagraphId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphId.localeCompare(b.paragraphId);
}
case clsvgs_PaperParagraphEN.con_ParagraphStateName:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphStateName.localeCompare(b.paragraphStateName);
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeName:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
}
case clsvgs_PaperParagraphEN.con_PaperId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PaperParagraphEN.con_SectionId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvgs_PaperParagraphEN.con_ParagraphStateId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphStateId.localeCompare(b.paragraphStateId);
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
}
case clsvgs_PaperParagraphEN.con_ParagraphContent:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.paragraphContent.localeCompare(b.paragraphContent);
}
case clsvgs_PaperParagraphEN.con_VoteCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.voteCount-b.voteCount;
}
case clsvgs_PaperParagraphEN.con_CommentCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.commentCount-b.commentCount;
}
case clsvgs_PaperParagraphEN.con_VersionCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_PaperParagraphEN.con_CreateDate:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvgs_PaperParagraphEN.con_CreateUser:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.createUser.localeCompare(b.createUser);
}
case clsvgs_PaperParagraphEN.con_UpdDate:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PaperParagraphEN.con_UpdUser:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PaperParagraphEN.con_Memo:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvgs_PaperParagraphEN.con_OrderNum:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return a.orderNum-b.orderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${ vgs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PaperParagraphEN.con_ParagraphId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphId.localeCompare(a.paragraphId);
}
case clsvgs_PaperParagraphEN.con_ParagraphStateName:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphStateName.localeCompare(a.paragraphStateName);
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeName:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphTypeName.localeCompare(a.paragraphTypeName);
}
case clsvgs_PaperParagraphEN.con_PaperId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PaperParagraphEN.con_SectionId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvgs_PaperParagraphEN.con_ParagraphStateId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphStateId.localeCompare(a.paragraphStateId);
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeId:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
}
case clsvgs_PaperParagraphEN.con_ParagraphContent:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.paragraphContent.localeCompare(a.paragraphContent);
}
case clsvgs_PaperParagraphEN.con_VoteCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.voteCount-a.voteCount;
}
case clsvgs_PaperParagraphEN.con_CommentCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.commentCount-a.commentCount;
}
case clsvgs_PaperParagraphEN.con_VersionCount:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_PaperParagraphEN.con_CreateDate:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvgs_PaperParagraphEN.con_CreateUser:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.createUser.localeCompare(a.createUser);
}
case clsvgs_PaperParagraphEN.con_UpdDate:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PaperParagraphEN.con_UpdUser:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PaperParagraphEN.con_Memo:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvgs_PaperParagraphEN.con_OrderNum:
return (a: clsvgs_PaperParagraphEN, b: clsvgs_PaperParagraphEN) => {
return b.orderNum-a.orderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${ vgs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperParagraph_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PaperParagraphEN.con_ParagraphId:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphId === value;
}
case clsvgs_PaperParagraphEN.con_ParagraphStateName:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphStateName === value;
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeName:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphTypeName === value;
}
case clsvgs_PaperParagraphEN.con_PaperId:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paperId === value;
}
case clsvgs_PaperParagraphEN.con_SectionId:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.sectionId === value;
}
case clsvgs_PaperParagraphEN.con_ParagraphStateId:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphStateId === value;
}
case clsvgs_PaperParagraphEN.con_ParagraphTypeId:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphTypeId === value;
}
case clsvgs_PaperParagraphEN.con_ParagraphContent:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.paragraphContent === value;
}
case clsvgs_PaperParagraphEN.con_VoteCount:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.voteCount === value;
}
case clsvgs_PaperParagraphEN.con_CommentCount:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.commentCount === value;
}
case clsvgs_PaperParagraphEN.con_VersionCount:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.versionCount === value;
}
case clsvgs_PaperParagraphEN.con_CreateDate:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.createDate === value;
}
case clsvgs_PaperParagraphEN.con_CreateUser:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.createUser === value;
}
case clsvgs_PaperParagraphEN.con_UpdDate:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.updDate === value;
}
case clsvgs_PaperParagraphEN.con_UpdUser:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.updUser === value;
}
case clsvgs_PaperParagraphEN.con_Memo:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.memo === value;
}
case clsvgs_PaperParagraphEN.con_OrderNum:
return (obj: clsvgs_PaperParagraphEN) => {
return obj.orderNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${ vgs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperParagraph_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PaperParagraphEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperParagraph = vgs_PaperParagraph_GetObjFromJsonObj(returnObj);
return objvgs_PaperParagraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
clsvgs_PaperParagraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperParagraphEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperParagraphEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvgs_PaperParagraphExObjLst_Cache: Array<clsvgs_PaperParagraphEN> = CacheHelper.Get(strKey);
const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
return arrvgs_PaperParagraphObjLst_T;
}
try
{
const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvgs_PaperParagraphExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrvgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperParagraph_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
clsvgs_PaperParagraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperParagraphEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperParagraphEN.CacheAddiCondition);
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
const arrvgs_PaperParagraphExObjLst_Cache: Array<clsvgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
return arrvgs_PaperParagraphObjLst_T;
}
try
{
const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvgs_PaperParagraphExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrvgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperParagraph_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvgs_PaperParagraphObjLst_Cache: Array<clsvgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperParagraphObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vgs_PaperParagraph_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
clsvgs_PaperParagraphEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvgs_PaperParagraphEN._CurrTabName);
if (IsNullOrEmpty(clsvgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvgs_PaperParagraphEN.CacheAddiCondition);
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
const arrvgs_PaperParagraphExObjLst_Cache: Array<clsvgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
return arrvgs_PaperParagraphObjLst_T;
}
try
{
const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvgs_PaperParagraphExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrvgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvgs_PaperParagraphObjLst_Cache: Array<clsvgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
return arrvgs_PaperParagraphObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperParagraph_GetObjLst_Cache(): Promise<Array<clsvgs_PaperParagraphEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvgs_PaperParagraphObjLst_Cache;
switch (clsvgs_PaperParagraphEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_ClientCache();
break;
default:
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_ClientCache();
break;
}
const arrvgs_PaperParagraphObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphObjLst_Cache);
return arrvgs_PaperParagraphObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vgs_PaperParagraph_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvgs_PaperParagraphObjLst_Cache;
switch (clsvgs_PaperParagraphEN.CacheModeId)
{
case "04"://sessionStorage
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvgs_PaperParagraphObjLst_Cache = null;
break;
default:
arrvgs_PaperParagraphObjLst_Cache = null;
break;
}
return arrvgs_PaperParagraphObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrParagraphId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_PaperParagraph_GetSubObjLst_Cache(objvgs_PaperParagraph_Cond: clsvgs_PaperParagraphEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
let arrvgs_PaperParagraph_Sel: Array < clsvgs_PaperParagraphEN > = arrvgs_PaperParagraphObjLst_Cache;
if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrvgs_PaperParagraph_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperParagraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperParagraph_Cond), vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperParagraphEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrParagraphId:关键字列表
 * @returns 对象列表
 **/
export async function vgs_PaperParagraph_GetObjLstByParagraphIdLstAsync(arrParagraphId: Array<string>): Promise<Array<clsvgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByParagraphIdLstAsync";
const strAction = "GetObjLstByParagraphIdLst";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrParagraphId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param arrstrParagraphIdLst:关键字列表
 * @returns 对象列表
*/
export async function vgs_PaperParagraph_GetObjLstByParagraphIdLst_Cache(arrParagraphIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByParagraphIdLst_Cache";
try
{
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
const arrvgs_PaperParagraph_Sel: Array <clsvgs_PaperParagraphEN> = arrvgs_PaperParagraphObjLst_Cache.filter(x => arrParagraphIdLst.indexOf(x.paragraphId)>-1);
return arrvgs_PaperParagraph_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrParagraphIdLst.join(","), vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperParagraphEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vgs_PaperParagraph_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrvgs_PaperParagraphObjLst_Cache.length == 0) return arrvgs_PaperParagraphObjLst_Cache;
let arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvgs_PaperParagraph_Cond = new clsvgs_PaperParagraphEN();
ObjectAssign(objvgs_PaperParagraph_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperParagraph_Sel.length == 0) return arrvgs_PaperParagraph_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.sort(vgs_PaperParagraph_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
}
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.slice(intStart, intEnd);     
return arrvgs_PaperParagraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvgs_PaperParagraphEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objstrParagraphId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vgs_PaperParagraph_IsExistRecord_Cache(objvgs_PaperParagraph_Cond: clsvgs_PaperParagraphEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrvgs_PaperParagraphObjLst_Cache == null) return false;
let arrvgs_PaperParagraph_Sel: Array < clsvgs_PaperParagraphEN > = arrvgs_PaperParagraphObjLst_Cache;
if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrvgs_PaperParagraph_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvgs_PaperParagraph_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvgs_PaperParagraph_Cond), vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param strParagraphId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vgs_PaperParagraph_IsExist(strParagraphId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ParagraphId": strParagraphId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param strParagraphId:所给的关键字
 * @returns 对象
*/
export async function vgs_PaperParagraph_IsExist_Cache(strParagraphId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrvgs_PaperParagraphObjLst_Cache == null) return false;
try
{
const arrvgs_PaperParagraph_Sel: Array <clsvgs_PaperParagraphEN> = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
if (arrvgs_PaperParagraph_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strParagraphId, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strParagraphId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vgs_PaperParagraph_IsExistAsync(strParagraphId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strParagraphId": strParagraphId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objvgs_PaperParagraph_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vgs_PaperParagraph_GetRecCountByCond_Cache(objvgs_PaperParagraph_Cond: clsvgs_PaperParagraphEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrvgs_PaperParagraphObjLst_Cache == null) return 0;
let arrvgs_PaperParagraph_Sel: Array < clsvgs_PaperParagraphEN > = arrvgs_PaperParagraphObjLst_Cache;
if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrvgs_PaperParagraph_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvgs_PaperParagraph_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvgs_PaperParagraph_Cond), vgs_PaperParagraph_ConstructorName, strThisFuncName);
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
export function vgs_PaperParagraph_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_PaperParagraph_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvgs_PaperParagraphEN._CurrTabName;
switch (clsvgs_PaperParagraphEN.CacheModeId)
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
export async function vgs_PaperParagraph__Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In )", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：_Cache");
const arrObjLst_Sel = await vgs_PaperParagraph_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvgs_PaperParagraphEN.con_ParagraphId, clsvgs_PaperParagraphEN.con_ParagraphStateName, "论文段落视图");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperParagraph_GetJSONStrByObj (pobjvgs_PaperParagraphEN: clsvgs_PaperParagraphEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PaperParagraphEN);
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
export function vgs_PaperParagraph_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PaperParagraphEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PaperParagraphObjLst = new Array<clsvgs_PaperParagraphEN>();
if (strJSON === "")
{
return arrvgs_PaperParagraphObjLst;
}
try
{
arrvgs_PaperParagraphObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PaperParagraphObjLst;
}
return arrvgs_PaperParagraphObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PaperParagraphObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PaperParagraph_GetObjLstByJSONObjLst (arrvgs_PaperParagraphObjLstS: Array<clsvgs_PaperParagraphEN>): Array<clsvgs_PaperParagraphEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PaperParagraphObjLst = new Array<clsvgs_PaperParagraphEN>();
for (const objInFor of arrvgs_PaperParagraphObjLstS) {
const obj1 = vgs_PaperParagraph_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PaperParagraphObjLst.push(obj1);
}
return arrvgs_PaperParagraphObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperParagraph_GetObjByJSONStr (strJSON: string): clsvgs_PaperParagraphEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
if (strJSON === "")
{
return pobjvgs_PaperParagraphEN;
}
try
{
pobjvgs_PaperParagraphEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PaperParagraphEN;
}
return pobjvgs_PaperParagraphEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PaperParagraph_GetCombineCondition(objvgs_PaperParagraph_Cond: clsvgs_PaperParagraphEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_ParagraphId) == true)
{
const strComparisonOp_ParagraphId:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_ParagraphId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_ParagraphId, objvgs_PaperParagraph_Cond.paragraphId, strComparisonOp_ParagraphId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_ParagraphStateName) == true)
{
const strComparisonOp_ParagraphStateName:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_ParagraphStateName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_ParagraphStateName, objvgs_PaperParagraph_Cond.paragraphStateName, strComparisonOp_ParagraphStateName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_ParagraphTypeName) == true)
{
const strComparisonOp_ParagraphTypeName:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_ParagraphTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_ParagraphTypeName, objvgs_PaperParagraph_Cond.paragraphTypeName, strComparisonOp_ParagraphTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_PaperId, objvgs_PaperParagraph_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_SectionId, objvgs_PaperParagraph_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_ParagraphStateId) == true)
{
const strComparisonOp_ParagraphStateId:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_ParagraphStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_ParagraphStateId, objvgs_PaperParagraph_Cond.paragraphStateId, strComparisonOp_ParagraphStateId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_ParagraphTypeId) == true)
{
const strComparisonOp_ParagraphTypeId:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_ParagraphTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_ParagraphTypeId, objvgs_PaperParagraph_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_VoteCount) == true)
{
const strComparisonOp_VoteCount:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_VoteCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperParagraphEN.con_VoteCount, objvgs_PaperParagraph_Cond.voteCount, strComparisonOp_VoteCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_CommentCount) == true)
{
const strComparisonOp_CommentCount:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_CommentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperParagraphEN.con_CommentCount, objvgs_PaperParagraph_Cond.commentCount, strComparisonOp_CommentCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperParagraphEN.con_VersionCount, objvgs_PaperParagraph_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_CreateDate, objvgs_PaperParagraph_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_CreateUser) == true)
{
const strComparisonOp_CreateUser:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_CreateUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_CreateUser, objvgs_PaperParagraph_Cond.createUser, strComparisonOp_CreateUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_UpdDate, objvgs_PaperParagraph_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_UpdUser, objvgs_PaperParagraph_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN.con_Memo, objvgs_PaperParagraph_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperParagraphEN.con_OrderNum, objvgs_PaperParagraph_Cond.orderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strParagraphId: 段落Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vgs_PaperParagraph_GetUniCondStr_ParagraphId(objvgs_PaperParagraphEN: clsvgs_PaperParagraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.paragraphId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strParagraphId: 段落Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vgs_PaperParagraph_GetUniCondStr4Update_ParagraphId(objvgs_PaperParagraphEN: clsvgs_PaperParagraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ParagraphId <> '{0}'", objvgs_PaperParagraphEN.paragraphId);
 strWhereCond +=  Format(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.paragraphId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PaperParagraphENS:源对象
 * @param objvgs_PaperParagraphENT:目标对象
*/
export function vgs_PaperParagraph_CopyObjTo(objvgs_PaperParagraphENS: clsvgs_PaperParagraphEN , objvgs_PaperParagraphENT: clsvgs_PaperParagraphEN ): void 
{
objvgs_PaperParagraphENT.paragraphId = objvgs_PaperParagraphENS.paragraphId; //段落Id
objvgs_PaperParagraphENT.paragraphStateName = objvgs_PaperParagraphENS.paragraphStateName; //段落状态
objvgs_PaperParagraphENT.paragraphTypeName = objvgs_PaperParagraphENS.paragraphTypeName; //段落类型
objvgs_PaperParagraphENT.paperId = objvgs_PaperParagraphENS.paperId; //论文Id
objvgs_PaperParagraphENT.sectionId = objvgs_PaperParagraphENS.sectionId; //节Id
objvgs_PaperParagraphENT.paragraphStateId = objvgs_PaperParagraphENS.paragraphStateId; //段落状态Id
objvgs_PaperParagraphENT.paragraphTypeId = objvgs_PaperParagraphENS.paragraphTypeId; //段落类型Id
objvgs_PaperParagraphENT.paragraphContent = objvgs_PaperParagraphENS.paragraphContent; //段落内容
objvgs_PaperParagraphENT.voteCount = objvgs_PaperParagraphENS.voteCount; //点赞计数
objvgs_PaperParagraphENT.commentCount = objvgs_PaperParagraphENS.commentCount; //评论数
objvgs_PaperParagraphENT.versionCount = objvgs_PaperParagraphENS.versionCount; //版本统计
objvgs_PaperParagraphENT.createDate = objvgs_PaperParagraphENS.createDate; //建立日期
objvgs_PaperParagraphENT.createUser = objvgs_PaperParagraphENS.createUser; //建立用户
objvgs_PaperParagraphENT.updDate = objvgs_PaperParagraphENS.updDate; //修改日期
objvgs_PaperParagraphENT.updUser = objvgs_PaperParagraphENS.updUser; //修改人
objvgs_PaperParagraphENT.memo = objvgs_PaperParagraphENS.memo; //备注
objvgs_PaperParagraphENT.orderNum = objvgs_PaperParagraphENS.orderNum; //序号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PaperParagraphENS:源对象
 * @param objvgs_PaperParagraphENT:目标对象
*/
export function vgs_PaperParagraph_GetObjFromJsonObj(objvgs_PaperParagraphENS: clsvgs_PaperParagraphEN): clsvgs_PaperParagraphEN 
{
 const objvgs_PaperParagraphENT: clsvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN();
ObjectAssign(objvgs_PaperParagraphENT, objvgs_PaperParagraphENS);
 return objvgs_PaperParagraphENT;
}