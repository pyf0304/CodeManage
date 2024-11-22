
 /**
 * 类名:clsgs_PaperParagraphWApi
 * 表名:gs_PaperParagraph(01120744)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:44
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
 * 论文段落表(gs_PaperParagraph)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_PaperParagraphEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { vgs_PaperParagraph_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperParagraph_Controller = "gs_PaperParagraphApi";
 export const gs_PaperParagraph_ConstructorName = "gs_PaperParagraph";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strParagraphId:关键字
 * @returns 对象
 **/
export async function gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId: string): Promise<clsgs_PaperParagraphEN|null>  
{
const strThisFuncName = "GetObjByParagraphIdAsync";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In clsgs_PaperParagraphWApi.GetObjByParagraphIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！(clsgs_PaperParagraphWApi.GetObjByParagraphIdAsync)", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByParagraphId";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objgs_PaperParagraph = gs_PaperParagraph_GetObjFromJsonObj(returnObj);
return objgs_PaperParagraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByParagraphId_Cache";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In clsgs_PaperParagraphWApi.GetObjByParagraphId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！(clsgs_PaperParagraphWApi.GetObjByParagraphId_Cache)", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
try
{
const arrgs_PaperParagraph_Sel: Array <clsgs_PaperParagraphEN> = arrgs_PaperParagraphObjLst_Cache.filter(x => 
 x.paragraphId == strParagraphId );
let objgs_PaperParagraph: clsgs_PaperParagraphEN;
if (arrgs_PaperParagraph_Sel.length > 0)
{
objgs_PaperParagraph = arrgs_PaperParagraph_Sel[0];
return objgs_PaperParagraph;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_PaperParagraph_Const = await gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
if (objgs_PaperParagraph_Const != null)
{
gs_PaperParagraph_ReFreshThisCache();
return objgs_PaperParagraph_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjByParagraphId_localStorage(strParagraphId: string) {
const strThisFuncName = "GetObjByParagraphId_localStorage";

if (IsNullOrEmpty(strParagraphId) == true)
{
  const strMsg = Format("参数:[strParagraphId]不能为空！(In clsgs_PaperParagraphWApi.GetObjByParagraphId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strParagraphId.length != 10)
{
const strMsg = Format("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！(clsgs_PaperParagraphWApi.GetObjByParagraphId_localStorage)", strParagraphId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_PaperParagraphEN._CurrTabName, strParagraphId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_PaperParagraph_Cache: clsgs_PaperParagraphEN = JSON.parse(strTempObj);
return objgs_PaperParagraph_Cache;
}
try
{
const objgs_PaperParagraph = await gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
if (objgs_PaperParagraph != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperParagraph));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_PaperParagraph;
}
return objgs_PaperParagraph;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_PaperParagraph:所给的对象
 * @returns 对象
*/
export async function gs_PaperParagraph_UpdateObjInLst_Cache(objgs_PaperParagraph: clsgs_PaperParagraphEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
const obj = arrgs_PaperParagraphObjLst_Cache.find(x => x.paragraphId == objgs_PaperParagraph.paragraphId);
if (obj != null)
{
objgs_PaperParagraph.paragraphId = obj.paragraphId;
ObjectAssign( obj, objgs_PaperParagraph);
}
else
{
arrgs_PaperParagraphObjLst_Cache.push(objgs_PaperParagraph);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_PaperParagraphEN.con_ParagraphId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_PaperParagraphEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_PaperParagraphEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strParagraphId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_PaperParagraph = await gs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId );
if (objgs_PaperParagraph == null) return "";
if (objgs_PaperParagraph.GetFldValue(strOutFldName) == null) return "";
return objgs_PaperParagraph.GetFldValue(strOutFldName).toString();
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
export function gs_PaperParagraph_SortFun_Defa(a:clsgs_PaperParagraphEN , b:clsgs_PaperParagraphEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paragraphId.localeCompare(b.paragraphId);
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
export function gs_PaperParagraph_SortFun_Defa_2Fld(a:clsgs_PaperParagraphEN , b:clsgs_PaperParagraphEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.sectionId.localeCompare(b.sectionId);
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
export function gs_PaperParagraph_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperParagraphEN.con_ParagraphId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.paragraphId.localeCompare(b.paragraphId);
}
case clsgs_PaperParagraphEN.con_PaperId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PaperParagraphEN.con_SectionId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsgs_PaperParagraphEN.con_ParagraphStateId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.paragraphStateId.localeCompare(b.paragraphStateId);
}
case clsgs_PaperParagraphEN.con_ParagraphTypeId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
}
case clsgs_PaperParagraphEN.con_ParagraphContent:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.paragraphContent == null) return -1;
if (b.paragraphContent == null) return 1;
return a.paragraphContent.localeCompare(b.paragraphContent);
}
case clsgs_PaperParagraphEN.con_VoteCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.voteCount-b.voteCount;
}
case clsgs_PaperParagraphEN.con_CommentCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.commentCount-b.commentCount;
}
case clsgs_PaperParagraphEN.con_VersionCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.versionCount-b.versionCount;
}
case clsgs_PaperParagraphEN.con_CreateDate:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.createDate == null) return -1;
if (b.createDate == null) return 1;
return a.createDate.localeCompare(b.createDate);
}
case clsgs_PaperParagraphEN.con_CreateUser:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.createUser == null) return -1;
if (b.createUser == null) return 1;
return a.createUser.localeCompare(b.createUser);
}
case clsgs_PaperParagraphEN.con_UpdDate:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperParagraphEN.con_UpdUser:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperParagraphEN.con_Memo:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsgs_PaperParagraphEN.con_OrderNum:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return a.orderNum-b.orderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${ gs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperParagraphEN.con_ParagraphId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.paragraphId.localeCompare(a.paragraphId);
}
case clsgs_PaperParagraphEN.con_PaperId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PaperParagraphEN.con_SectionId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsgs_PaperParagraphEN.con_ParagraphStateId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.paragraphStateId.localeCompare(a.paragraphStateId);
}
case clsgs_PaperParagraphEN.con_ParagraphTypeId:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
}
case clsgs_PaperParagraphEN.con_ParagraphContent:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.paragraphContent == null) return -1;
if (a.paragraphContent == null) return 1;
return b.paragraphContent.localeCompare(a.paragraphContent);
}
case clsgs_PaperParagraphEN.con_VoteCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.voteCount-a.voteCount;
}
case clsgs_PaperParagraphEN.con_CommentCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.commentCount-a.commentCount;
}
case clsgs_PaperParagraphEN.con_VersionCount:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.versionCount-a.versionCount;
}
case clsgs_PaperParagraphEN.con_CreateDate:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.createDate == null) return -1;
if (a.createDate == null) return 1;
return b.createDate.localeCompare(a.createDate);
}
case clsgs_PaperParagraphEN.con_CreateUser:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.createUser == null) return -1;
if (a.createUser == null) return 1;
return b.createUser.localeCompare(a.createUser);
}
case clsgs_PaperParagraphEN.con_UpdDate:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperParagraphEN.con_UpdUser:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperParagraphEN.con_Memo:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsgs_PaperParagraphEN.con_OrderNum:
return (a: clsgs_PaperParagraphEN, b: clsgs_PaperParagraphEN) => {
return b.orderNum-a.orderNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${ gs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperParagraph_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperParagraphEN.con_ParagraphId:
return (obj: clsgs_PaperParagraphEN) => {
return obj.paragraphId === value;
}
case clsgs_PaperParagraphEN.con_PaperId:
return (obj: clsgs_PaperParagraphEN) => {
return obj.paperId === value;
}
case clsgs_PaperParagraphEN.con_SectionId:
return (obj: clsgs_PaperParagraphEN) => {
return obj.sectionId === value;
}
case clsgs_PaperParagraphEN.con_ParagraphStateId:
return (obj: clsgs_PaperParagraphEN) => {
return obj.paragraphStateId === value;
}
case clsgs_PaperParagraphEN.con_ParagraphTypeId:
return (obj: clsgs_PaperParagraphEN) => {
return obj.paragraphTypeId === value;
}
case clsgs_PaperParagraphEN.con_ParagraphContent:
return (obj: clsgs_PaperParagraphEN) => {
return obj.paragraphContent === value;
}
case clsgs_PaperParagraphEN.con_VoteCount:
return (obj: clsgs_PaperParagraphEN) => {
return obj.voteCount === value;
}
case clsgs_PaperParagraphEN.con_CommentCount:
return (obj: clsgs_PaperParagraphEN) => {
return obj.commentCount === value;
}
case clsgs_PaperParagraphEN.con_VersionCount:
return (obj: clsgs_PaperParagraphEN) => {
return obj.versionCount === value;
}
case clsgs_PaperParagraphEN.con_CreateDate:
return (obj: clsgs_PaperParagraphEN) => {
return obj.createDate === value;
}
case clsgs_PaperParagraphEN.con_CreateUser:
return (obj: clsgs_PaperParagraphEN) => {
return obj.createUser === value;
}
case clsgs_PaperParagraphEN.con_UpdDate:
return (obj: clsgs_PaperParagraphEN) => {
return obj.updDate === value;
}
case clsgs_PaperParagraphEN.con_UpdUser:
return (obj: clsgs_PaperParagraphEN) => {
return obj.updUser === value;
}
case clsgs_PaperParagraphEN.con_Memo:
return (obj: clsgs_PaperParagraphEN) => {
return obj.memo === value;
}
case clsgs_PaperParagraphEN.con_OrderNum:
return (obj: clsgs_PaperParagraphEN) => {
return obj.orderNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${ gs_PaperParagraph_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperParagraph_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_PaperParagraphEN.con_ParagraphId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_PaperParagraph = await gs_PaperParagraph_GetObjLst_Cache();
if (arrgs_PaperParagraph == null) return [];
let arrgs_PaperParagraph_Sel = arrgs_PaperParagraph;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_PaperParagraph_Sel.length == 0) return [];
return arrgs_PaperParagraph_Sel.map(x=>x.paragraphId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperParagraph_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperParagraphEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const objgs_PaperParagraph = gs_PaperParagraph_GetObjFromJsonObj(returnObj);
return objgs_PaperParagraph;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperParagraphEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperParagraphEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_PaperParagraphExObjLst_Cache: Array<clsgs_PaperParagraphEN> = CacheHelper.Get(strKey);
const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
return arrgs_PaperParagraphObjLst_T;
}
try
{
const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_PaperParagraphExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperParagraph_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperParagraphEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperParagraphEN.CacheAddiCondition);
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
const arrgs_PaperParagraphExObjLst_Cache: Array<clsgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
return arrgs_PaperParagraphObjLst_T;
}
try
{
const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperParagraphExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperParagraph_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperParagraphEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_PaperParagraphObjLst_Cache: Array<clsgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
return arrgs_PaperParagraphObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperParagraph_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_PaperParagraphEN._CurrTabName;
if (IsNullOrEmpty(clsgs_PaperParagraphEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperParagraphEN.CacheAddiCondition);
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
const arrgs_PaperParagraphExObjLst_Cache: Array<clsgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
return arrgs_PaperParagraphObjLst_T;
}
try
{
const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperParagraphExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
console.log(strInfo);
return arrgs_PaperParagraphExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperParagraph_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_PaperParagraphEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_PaperParagraphObjLst_Cache: Array<clsgs_PaperParagraphEN> = JSON.parse(strTempObjLst);
return arrgs_PaperParagraphObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperParagraph_GetObjLst_Cache(): Promise<Array<clsgs_PaperParagraphEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_PaperParagraphObjLst_Cache;
switch (clsgs_PaperParagraphEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_ClientCache();
break;
default:
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_ClientCache();
break;
}
const arrgs_PaperParagraphObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphObjLst_Cache);
return arrgs_PaperParagraphObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperParagraph_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_PaperParagraphObjLst_Cache;
switch (clsgs_PaperParagraphEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_PaperParagraphObjLst_Cache = null;
break;
default:
arrgs_PaperParagraphObjLst_Cache = null;
break;
}
return arrgs_PaperParagraphObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrParagraphId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperParagraph_GetSubObjLst_Cache(objgs_PaperParagraph_Cond: clsgs_PaperParagraphEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
let arrgs_PaperParagraph_Sel: Array < clsgs_PaperParagraphEN > = arrgs_PaperParagraphObjLst_Cache;
if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrgs_PaperParagraph_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperParagraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperParagraph_Cond), gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperParagraphEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrParagraphId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperParagraph_GetObjLstByParagraphIdLstAsync(arrParagraphId: Array<string>): Promise<Array<clsgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByParagraphIdLstAsync";
const strAction = "GetObjLstByParagraphIdLst";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrParagraphId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLstByParagraphIdLst_Cache(arrParagraphIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByParagraphIdLst_Cache";
try
{
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
const arrgs_PaperParagraph_Sel: Array <clsgs_PaperParagraphEN> = arrgs_PaperParagraphObjLst_Cache.filter(x => arrParagraphIdLst.indexOf(x.paragraphId)>-1);
return arrgs_PaperParagraph_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrParagraphIdLst.join(","), gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PaperParagraphEN>();
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
if (arrgs_PaperParagraphObjLst_Cache.length == 0) return arrgs_PaperParagraphObjLst_Cache;
let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_PaperParagraph_Cond = new clsgs_PaperParagraphEN();
ObjectAssign(objgs_PaperParagraph_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperParagraph_Sel.length == 0) return arrgs_PaperParagraph_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraph_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
}
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);     
return arrgs_PaperParagraph_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperParagraphEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperParagraphEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PaperParagraphEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param strParagraphId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperParagraph_DelRecordAsync(strParagraphId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strParagraphId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param arrParagraphId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperParagraph_Delgs_PaperParagraphsAsync(arrParagraphId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperParagraphsAsync";
const strAction = "Delgs_PaperParagraphs";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrParagraphId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_Delgs_PaperParagraphsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperParagraphsByCondAsync";
const strAction = "Delgs_PaperParagraphsByCond";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_AddNewRecordAsync(objgs_PaperParagraphEN: clsgs_PaperParagraphEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_AddNewRecordWithMaxIdAsync(objgs_PaperParagraphEN: clsgs_PaperParagraphEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperParagraph_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperParagraph_AddNewRecordWithReturnKeyAsync(objgs_PaperParagraphEN: clsgs_PaperParagraphEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperParagraph_AddNewRecordWithReturnKey(objgs_PaperParagraphEN: clsgs_PaperParagraphEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperParagraphEN.paragraphId === null || objgs_PaperParagraphEN.paragraphId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperParagraph_UpdateRecordAsync(objgs_PaperParagraphEN: clsgs_PaperParagraphEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperParagraphEN.sfUpdFldSetStr === undefined || objgs_PaperParagraphEN.sfUpdFldSetStr === null || objgs_PaperParagraphEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphEN.paragraphId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraphEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperParagraph_UpdateWithConditionAsync(objgs_PaperParagraphEN: clsgs_PaperParagraphEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperParagraphEN.sfUpdFldSetStr === undefined || objgs_PaperParagraphEN.sfUpdFldSetStr === null || objgs_PaperParagraphEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphEN.paragraphId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
objgs_PaperParagraphEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperParagraphEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_IsExistRecord_Cache(objgs_PaperParagraph_Cond: clsgs_PaperParagraphEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
if (arrgs_PaperParagraphObjLst_Cache == null) return false;
let arrgs_PaperParagraph_Sel: Array < clsgs_PaperParagraphEN > = arrgs_PaperParagraphObjLst_Cache;
if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrgs_PaperParagraph_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperParagraph_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_PaperParagraph_Cond), gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_IsExist(strParagraphId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_IsExist_Cache(strParagraphId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
if (arrgs_PaperParagraphObjLst_Cache == null) return false;
try
{
const arrgs_PaperParagraph_Sel: Array <clsgs_PaperParagraphEN> = arrgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
if (arrgs_PaperParagraph_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strParagraphId, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_IsExistAsync(strParagraphId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperParagraph_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_PaperParagraph_GetRecCountByCond_Cache(objgs_PaperParagraph_Cond: clsgs_PaperParagraphEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
if (arrgs_PaperParagraphObjLst_Cache == null) return 0;
let arrgs_PaperParagraph_Sel: Array < clsgs_PaperParagraphEN > = arrgs_PaperParagraphObjLst_Cache;
if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "") return arrgs_PaperParagraph_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperParagraph_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperParagraph_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperParagraph_Cond), gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export async function gs_PaperParagraph_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperParagraph_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperParagraph_ConstructorName, strThisFuncName);
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
export function gs_PaperParagraph_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperParagraph_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_PaperParagraphEN._CurrTabName;
switch (clsgs_PaperParagraphEN.CacheModeId)
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
vgs_PaperParagraph_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function gs_PaperParagraph_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_PaperParagraphEN._CurrTabName;
switch (clsgs_PaperParagraphEN.CacheModeId)
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
export function gs_PaperParagraph_CheckPropertyNew(pobjgs_PaperParagraphEN: clsgs_PaperParagraphEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paperId) === true 
 || pobjgs_PaperParagraphEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.sectionId) === true )
{
 throw new Error("(errid:Watl000058)字段[节Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphStateId) === true )
{
 throw new Error("(errid:Watl000058)字段[段落状态Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[段落类型Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphId) > 10)
{
 throw new Error("(errid:Watl000059)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paperId) == false && GetStrLen(pobjgs_PaperParagraphEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paperId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.sectionId) == false && GetStrLen(pobjgs_PaperParagraphEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.sectionId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphStateId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphStateId) > 2)
{
 throw new Error("(errid:Watl000059)字段[段落状态Id(paragraphStateId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphStateId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphTypeId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphTypeId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createDate) == false && GetStrLen(pobjgs_PaperParagraphEN.createDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createDate)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createUser) == false && GetStrLen(pobjgs_PaperParagraphEN.createUser) > 50)
{
 throw new Error("(errid:Watl000059)字段[建立用户(createUser)]的长度不能超过50(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createUser)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updDate) == false && GetStrLen(pobjgs_PaperParagraphEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updDate)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updUser) == false && GetStrLen(pobjgs_PaperParagraphEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updUser)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.memo) == false && GetStrLen(pobjgs_PaperParagraphEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.memo)(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphEN.paragraphId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paperId) == false && undefined !== pobjgs_PaperParagraphEN.paperId && tzDataType.isString(pobjgs_PaperParagraphEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphEN.paperId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.sectionId) == false && undefined !== pobjgs_PaperParagraphEN.sectionId && tzDataType.isString(pobjgs_PaperParagraphEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphEN.sectionId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphStateId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphStateId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphStateId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落状态Id(paragraphStateId)]的值:[$(pobjgs_PaperParagraphEN.paragraphStateId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphTypeId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphEN.paragraphContent && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphContent) === false)
{
 throw new Error("(errid:Watl000060)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphEN.paragraphContent)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperParagraphEN.voteCount && undefined !== pobjgs_PaperParagraphEN.voteCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.voteCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperParagraphEN.voteCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperParagraphEN.commentCount && undefined !== pobjgs_PaperParagraphEN.commentCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.commentCount) === false)
{
 throw new Error("(errid:Watl000060)字段[评论数(commentCount)]的值:[$(pobjgs_PaperParagraphEN.commentCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperParagraphEN.versionCount && undefined !== pobjgs_PaperParagraphEN.versionCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.versionCount) === false)
{
 throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperParagraphEN.versionCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createDate) == false && undefined !== pobjgs_PaperParagraphEN.createDate && tzDataType.isString(pobjgs_PaperParagraphEN.createDate) === false)
{
 throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjgs_PaperParagraphEN.createDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createUser) == false && undefined !== pobjgs_PaperParagraphEN.createUser && tzDataType.isString(pobjgs_PaperParagraphEN.createUser) === false)
{
 throw new Error("(errid:Watl000060)字段[建立用户(createUser)]的值:[$(pobjgs_PaperParagraphEN.createUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updDate) == false && undefined !== pobjgs_PaperParagraphEN.updDate && tzDataType.isString(pobjgs_PaperParagraphEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphEN.updDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updUser) == false && undefined !== pobjgs_PaperParagraphEN.updUser && tzDataType.isString(pobjgs_PaperParagraphEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphEN.updUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.memo) == false && undefined !== pobjgs_PaperParagraphEN.memo && tzDataType.isString(pobjgs_PaperParagraphEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphEN.memo)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperParagraphEN.orderNum && undefined !== pobjgs_PaperParagraphEN.orderNum && tzDataType.isNumber(pobjgs_PaperParagraphEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_PaperParagraphEN.orderNum)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperParagraphEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperParagraph_CheckProperty4Update (pobjgs_PaperParagraphEN: clsgs_PaperParagraphEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphId) > 10)
{
 throw new Error("(errid:Watl000062)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paperId) == false && GetStrLen(pobjgs_PaperParagraphEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paperId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.sectionId) == false && GetStrLen(pobjgs_PaperParagraphEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.sectionId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphStateId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphStateId) > 2)
{
 throw new Error("(errid:Watl000062)字段[段落状态Id(paragraphStateId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphStateId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphTypeId) == false && GetStrLen(pobjgs_PaperParagraphEN.paragraphTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphTypeId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createDate) == false && GetStrLen(pobjgs_PaperParagraphEN.createDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createDate)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createUser) == false && GetStrLen(pobjgs_PaperParagraphEN.createUser) > 50)
{
 throw new Error("(errid:Watl000062)字段[建立用户(createUser)]的长度不能超过50(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createUser)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updDate) == false && GetStrLen(pobjgs_PaperParagraphEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updDate)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updUser) == false && GetStrLen(pobjgs_PaperParagraphEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updUser)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.memo) == false && GetStrLen(pobjgs_PaperParagraphEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.memo)(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphEN.paragraphId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paperId) == false && undefined !== pobjgs_PaperParagraphEN.paperId && tzDataType.isString(pobjgs_PaperParagraphEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphEN.paperId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.sectionId) == false && undefined !== pobjgs_PaperParagraphEN.sectionId && tzDataType.isString(pobjgs_PaperParagraphEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphEN.sectionId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphStateId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphStateId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphStateId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落状态Id(paragraphStateId)]的值:[$(pobjgs_PaperParagraphEN.paragraphStateId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphTypeId && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphEN.paragraphContent && tzDataType.isString(pobjgs_PaperParagraphEN.paragraphContent) === false)
{
 throw new Error("(errid:Watl000063)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphEN.paragraphContent)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperParagraphEN.voteCount && undefined !== pobjgs_PaperParagraphEN.voteCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.voteCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperParagraphEN.voteCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperParagraphEN.commentCount && undefined !== pobjgs_PaperParagraphEN.commentCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.commentCount) === false)
{
 throw new Error("(errid:Watl000063)字段[评论数(commentCount)]的值:[$(pobjgs_PaperParagraphEN.commentCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperParagraphEN.versionCount && undefined !== pobjgs_PaperParagraphEN.versionCount && tzDataType.isNumber(pobjgs_PaperParagraphEN.versionCount) === false)
{
 throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperParagraphEN.versionCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createDate) == false && undefined !== pobjgs_PaperParagraphEN.createDate && tzDataType.isString(pobjgs_PaperParagraphEN.createDate) === false)
{
 throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjgs_PaperParagraphEN.createDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.createUser) == false && undefined !== pobjgs_PaperParagraphEN.createUser && tzDataType.isString(pobjgs_PaperParagraphEN.createUser) === false)
{
 throw new Error("(errid:Watl000063)字段[建立用户(createUser)]的值:[$(pobjgs_PaperParagraphEN.createUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updDate) == false && undefined !== pobjgs_PaperParagraphEN.updDate && tzDataType.isString(pobjgs_PaperParagraphEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphEN.updDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.updUser) == false && undefined !== pobjgs_PaperParagraphEN.updUser && tzDataType.isString(pobjgs_PaperParagraphEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphEN.updUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.memo) == false && undefined !== pobjgs_PaperParagraphEN.memo && tzDataType.isString(pobjgs_PaperParagraphEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphEN.memo)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperParagraphEN.orderNum && undefined !== pobjgs_PaperParagraphEN.orderNum && tzDataType.isNumber(pobjgs_PaperParagraphEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_PaperParagraphEN.orderNum)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_PaperParagraphEN.paragraphId) === true )
{
 throw new Error("(errid:Watl000064)字段[段落Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperParagraphEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperParagraph_GetJSONStrByObj (pobjgs_PaperParagraphEN: clsgs_PaperParagraphEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperParagraphEN.sfUpdFldSetStr = pobjgs_PaperParagraphEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperParagraphEN);
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
export function gs_PaperParagraph_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperParagraphEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperParagraphObjLst = new Array<clsgs_PaperParagraphEN>();
if (strJSON === "")
{
return arrgs_PaperParagraphObjLst;
}
try
{
arrgs_PaperParagraphObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperParagraphObjLst;
}
return arrgs_PaperParagraphObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperParagraphObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperParagraph_GetObjLstByJSONObjLst (arrgs_PaperParagraphObjLstS: Array<clsgs_PaperParagraphEN>): Array<clsgs_PaperParagraphEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperParagraphObjLst = new Array<clsgs_PaperParagraphEN>();
for (const objInFor of arrgs_PaperParagraphObjLstS) {
const obj1 = gs_PaperParagraph_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperParagraphObjLst.push(obj1);
}
return arrgs_PaperParagraphObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperParagraph_GetObjByJSONStr (strJSON: string): clsgs_PaperParagraphEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperParagraphEN = new clsgs_PaperParagraphEN();
if (strJSON === "")
{
return pobjgs_PaperParagraphEN;
}
try
{
pobjgs_PaperParagraphEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperParagraphEN;
}
return pobjgs_PaperParagraphEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperParagraph_GetCombineCondition(objgs_PaperParagraph_Cond: clsgs_PaperParagraphEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_ParagraphId) == true)
{
const strComparisonOp_ParagraphId:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_ParagraphId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_ParagraphId, objgs_PaperParagraph_Cond.paragraphId, strComparisonOp_ParagraphId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_PaperId, objgs_PaperParagraph_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_SectionId, objgs_PaperParagraph_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_ParagraphStateId) == true)
{
const strComparisonOp_ParagraphStateId:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_ParagraphStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_ParagraphStateId, objgs_PaperParagraph_Cond.paragraphStateId, strComparisonOp_ParagraphStateId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_ParagraphTypeId) == true)
{
const strComparisonOp_ParagraphTypeId:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_ParagraphTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_ParagraphTypeId, objgs_PaperParagraph_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_VoteCount) == true)
{
const strComparisonOp_VoteCount:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_VoteCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperParagraphEN.con_VoteCount, objgs_PaperParagraph_Cond.voteCount, strComparisonOp_VoteCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_CommentCount) == true)
{
const strComparisonOp_CommentCount:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_CommentCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperParagraphEN.con_CommentCount, objgs_PaperParagraph_Cond.commentCount, strComparisonOp_CommentCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperParagraphEN.con_VersionCount, objgs_PaperParagraph_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_CreateDate, objgs_PaperParagraph_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_CreateUser) == true)
{
const strComparisonOp_CreateUser:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_CreateUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_CreateUser, objgs_PaperParagraph_Cond.createUser, strComparisonOp_CreateUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_UpdDate, objgs_PaperParagraph_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_UpdUser, objgs_PaperParagraph_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperParagraphEN.con_Memo, objgs_PaperParagraph_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperParagraphEN.con_OrderNum, objgs_PaperParagraph_Cond.orderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperParagraph(论文段落表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strParagraphId: 段落Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperParagraph_GetUniCondStr_ParagraphId(objgs_PaperParagraphEN: clsgs_PaperParagraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ParagraphId = '{0}'", objgs_PaperParagraphEN.paragraphId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperParagraph(论文段落表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strParagraphId: 段落Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperParagraph_GetUniCondStr4Update_ParagraphId(objgs_PaperParagraphEN: clsgs_PaperParagraphEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ParagraphId <> '{0}'", objgs_PaperParagraphEN.paragraphId);
 strWhereCond +=  Format(" and ParagraphId = '{0}'", objgs_PaperParagraphEN.paragraphId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperParagraphENS:源对象
 * @param objgs_PaperParagraphENT:目标对象
*/
export function gs_PaperParagraph_CopyObjTo(objgs_PaperParagraphENS: clsgs_PaperParagraphEN , objgs_PaperParagraphENT: clsgs_PaperParagraphEN ): void 
{
objgs_PaperParagraphENT.paragraphId = objgs_PaperParagraphENS.paragraphId; //段落Id
objgs_PaperParagraphENT.paperId = objgs_PaperParagraphENS.paperId; //论文Id
objgs_PaperParagraphENT.sectionId = objgs_PaperParagraphENS.sectionId; //节Id
objgs_PaperParagraphENT.paragraphStateId = objgs_PaperParagraphENS.paragraphStateId; //段落状态Id
objgs_PaperParagraphENT.paragraphTypeId = objgs_PaperParagraphENS.paragraphTypeId; //段落类型Id
objgs_PaperParagraphENT.paragraphContent = objgs_PaperParagraphENS.paragraphContent; //段落内容
objgs_PaperParagraphENT.voteCount = objgs_PaperParagraphENS.voteCount; //点赞计数
objgs_PaperParagraphENT.commentCount = objgs_PaperParagraphENS.commentCount; //评论数
objgs_PaperParagraphENT.versionCount = objgs_PaperParagraphENS.versionCount; //版本统计
objgs_PaperParagraphENT.createDate = objgs_PaperParagraphENS.createDate; //建立日期
objgs_PaperParagraphENT.createUser = objgs_PaperParagraphENS.createUser; //建立用户
objgs_PaperParagraphENT.updDate = objgs_PaperParagraphENS.updDate; //修改日期
objgs_PaperParagraphENT.updUser = objgs_PaperParagraphENS.updUser; //修改人
objgs_PaperParagraphENT.memo = objgs_PaperParagraphENS.memo; //备注
objgs_PaperParagraphENT.orderNum = objgs_PaperParagraphENS.orderNum; //序号
objgs_PaperParagraphENT.sfUpdFldSetStr = objgs_PaperParagraphENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperParagraphENS:源对象
 * @param objgs_PaperParagraphENT:目标对象
*/
export function gs_PaperParagraph_GetObjFromJsonObj(objgs_PaperParagraphENS: clsgs_PaperParagraphEN): clsgs_PaperParagraphEN 
{
 const objgs_PaperParagraphENT: clsgs_PaperParagraphEN = new clsgs_PaperParagraphEN();
ObjectAssign(objgs_PaperParagraphENT, objgs_PaperParagraphENS);
 return objgs_PaperParagraphENT;
}