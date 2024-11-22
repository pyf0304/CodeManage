
 /**
 * 类名:clsvSysCommentWApi
 * 表名:vSysComment(01120624)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:55
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
 * v系统评论表(vSysComment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvSysCommentEN } from "../../L0_Entity/GraduateEduTools/clsvSysCommentEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysComment_Controller = "vSysCommentApi";
 export const vSysComment_ConstructorName = "vSysComment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCommentId:关键字
 * @returns 对象
 **/
export async function vSysComment_GetObjByCommentIdAsync(strCommentId: string): Promise<clsvSysCommentEN|null>  
{
const strThisFuncName = "GetObjByCommentIdAsync";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsvSysCommentWApi.GetObjByCommentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsvSysCommentWApi.GetObjByCommentIdAsync)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCommentId";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCommentId": strCommentId,
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
const objvSysComment = vSysComment_GetObjFromJsonObj(returnObj);
return objvSysComment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param strCommentId:所给的关键字
 * @returns 对象
*/
export async function vSysComment_GetObjByCommentId_Cache(strCommentId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCommentId_Cache";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsvSysCommentWApi.GetObjByCommentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsvSysCommentWApi.GetObjByCommentId_Cache)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvSysComment_Sel: Array <clsvSysCommentEN> = arrvSysCommentObjLst_Cache.filter(x => 
 x.commentId == strCommentId );
let objvSysComment: clsvSysCommentEN;
if (arrvSysComment_Sel.length > 0)
{
objvSysComment = arrvSysComment_Sel[0];
return objvSysComment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvSysComment_Const = await vSysComment_GetObjByCommentIdAsync(strCommentId);
if (objvSysComment_Const != null)
{
vSysComment_ReFreshThisCache(strid_CurrEduCls);
return objvSysComment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strCommentId:所给的关键字
 * @returns 对象
*/
export async function vSysComment_GetObjByCommentId_localStorage(strCommentId: string) {
const strThisFuncName = "GetObjByCommentId_localStorage";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsvSysCommentWApi.GetObjByCommentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsvSysCommentWApi.GetObjByCommentId_localStorage)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strCommentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvSysComment_Cache: clsvSysCommentEN = JSON.parse(strTempObj);
return objvSysComment_Cache;
}
try
{
const objvSysComment = await vSysComment_GetObjByCommentIdAsync(strCommentId);
if (objvSysComment != null)
{
localStorage.setItem(strKey, JSON.stringify(objvSysComment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvSysComment;
}
return objvSysComment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, vSysComment_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vSysComment_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysCommentWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysCommentWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvSysCommentEN.con_CommentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvSysCommentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvSysCommentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCommentId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvSysComment = await vSysComment_GetObjByCommentId_Cache(strCommentId , strid_CurrEduCls_C);
if (objvSysComment == null) return "";
if (objvSysComment.GetFldValue(strOutFldName) == null) return "";
return objvSysComment.GetFldValue(strOutFldName).toString();
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
export function vSysComment_SortFun_Defa(a:clsvSysCommentEN , b:clsvSysCommentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.commentId.localeCompare(b.commentId);
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
export function vSysComment_SortFun_Defa_2Fld(a:clsvSysCommentEN , b:clsvSysCommentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.comment == b.comment) return a.score - b.score;
else return a.comment.localeCompare(b.comment);
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
export function vSysComment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysCommentEN.con_CommentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.commentId.localeCompare(b.commentId);
}
case clsvSysCommentEN.con_Comment:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.comment == null) return -1;
if (b.comment == null) return 1;
return a.comment.localeCompare(b.comment);
}
case clsvSysCommentEN.con_Score:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.score-b.score;
}
case clsvSysCommentEN.con_CommentTypeId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.commentTypeId.localeCompare(b.commentTypeId);
}
case clsvSysCommentEN.con_ScoreType:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.scoreType == null) return -1;
if (b.scoreType == null) return 1;
return a.scoreType.localeCompare(b.scoreType);
}
case clsvSysCommentEN.con_ParentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.parentId.localeCompare(b.parentId);
}
case clsvSysCommentEN.con_TableKey:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsvSysCommentEN.con_UpdUser:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvSysCommentEN.con_UpdDate:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvSysCommentEN.con_Memo:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvSysCommentEN.con_CommentTypeName:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.commentTypeName == null) return -1;
if (b.commentTypeName == null) return 1;
return a.commentTypeName.localeCompare(b.commentTypeName);
}
case clsvSysCommentEN.con_CommentTable:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.commentTable == null) return -1;
if (b.commentTable == null) return 1;
return a.commentTable.localeCompare(b.commentTable);
}
case clsvSysCommentEN.con_CommentTableId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.commentTableId == null) return -1;
if (b.commentTableId == null) return 1;
return a.commentTableId.localeCompare(b.commentTableId);
}
case clsvSysCommentEN.con_OkCount:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.okCount-b.okCount;
}
case clsvSysCommentEN.con_PubParentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.pubParentId == null) return -1;
if (b.pubParentId == null) return 1;
return a.pubParentId.localeCompare(b.pubParentId);
}
case clsvSysCommentEN.con_id_CurrEduCls:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvSysCommentEN.con_UserId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${ vSysComment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysCommentEN.con_CommentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.commentId.localeCompare(a.commentId);
}
case clsvSysCommentEN.con_Comment:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.comment == null) return -1;
if (a.comment == null) return 1;
return b.comment.localeCompare(a.comment);
}
case clsvSysCommentEN.con_Score:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.score-a.score;
}
case clsvSysCommentEN.con_CommentTypeId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.commentTypeId.localeCompare(a.commentTypeId);
}
case clsvSysCommentEN.con_ScoreType:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.scoreType == null) return -1;
if (a.scoreType == null) return 1;
return b.scoreType.localeCompare(a.scoreType);
}
case clsvSysCommentEN.con_ParentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.parentId.localeCompare(a.parentId);
}
case clsvSysCommentEN.con_TableKey:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsvSysCommentEN.con_UpdUser:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvSysCommentEN.con_UpdDate:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvSysCommentEN.con_Memo:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvSysCommentEN.con_CommentTypeName:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.commentTypeName == null) return -1;
if (a.commentTypeName == null) return 1;
return b.commentTypeName.localeCompare(a.commentTypeName);
}
case clsvSysCommentEN.con_CommentTable:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.commentTable == null) return -1;
if (a.commentTable == null) return 1;
return b.commentTable.localeCompare(a.commentTable);
}
case clsvSysCommentEN.con_CommentTableId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.commentTableId == null) return -1;
if (a.commentTableId == null) return 1;
return b.commentTableId.localeCompare(a.commentTableId);
}
case clsvSysCommentEN.con_OkCount:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.okCount-a.okCount;
}
case clsvSysCommentEN.con_PubParentId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.pubParentId == null) return -1;
if (a.pubParentId == null) return 1;
return b.pubParentId.localeCompare(a.pubParentId);
}
case clsvSysCommentEN.con_id_CurrEduCls:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvSysCommentEN.con_UserId:
return (a: clsvSysCommentEN, b: clsvSysCommentEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${ vSysComment_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysComment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysCommentEN.con_CommentId:
return (obj: clsvSysCommentEN) => {
return obj.commentId === value;
}
case clsvSysCommentEN.con_Comment:
return (obj: clsvSysCommentEN) => {
return obj.comment === value;
}
case clsvSysCommentEN.con_Score:
return (obj: clsvSysCommentEN) => {
return obj.score === value;
}
case clsvSysCommentEN.con_CommentTypeId:
return (obj: clsvSysCommentEN) => {
return obj.commentTypeId === value;
}
case clsvSysCommentEN.con_ScoreType:
return (obj: clsvSysCommentEN) => {
return obj.scoreType === value;
}
case clsvSysCommentEN.con_ParentId:
return (obj: clsvSysCommentEN) => {
return obj.parentId === value;
}
case clsvSysCommentEN.con_TableKey:
return (obj: clsvSysCommentEN) => {
return obj.tableKey === value;
}
case clsvSysCommentEN.con_UpdUser:
return (obj: clsvSysCommentEN) => {
return obj.updUser === value;
}
case clsvSysCommentEN.con_UpdDate:
return (obj: clsvSysCommentEN) => {
return obj.updDate === value;
}
case clsvSysCommentEN.con_Memo:
return (obj: clsvSysCommentEN) => {
return obj.memo === value;
}
case clsvSysCommentEN.con_CommentTypeName:
return (obj: clsvSysCommentEN) => {
return obj.commentTypeName === value;
}
case clsvSysCommentEN.con_CommentTable:
return (obj: clsvSysCommentEN) => {
return obj.commentTable === value;
}
case clsvSysCommentEN.con_CommentTableId:
return (obj: clsvSysCommentEN) => {
return obj.commentTableId === value;
}
case clsvSysCommentEN.con_OkCount:
return (obj: clsvSysCommentEN) => {
return obj.okCount === value;
}
case clsvSysCommentEN.con_PubParentId:
return (obj: clsvSysCommentEN) => {
return obj.pubParentId === value;
}
case clsvSysCommentEN.con_id_CurrEduCls:
return (obj: clsvSysCommentEN) => {
return obj.id_CurrEduCls === value;
}
case clsvSysCommentEN.con_UserId:
return (obj: clsvSysCommentEN) => {
return obj.userId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${ vSysComment_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysComment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysCommentWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysCommentWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvSysCommentEN.con_CommentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvSysComment = await vSysComment_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvSysComment == null) return [];
let arrvSysComment_Sel = arrvSysComment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvSysComment_Sel.length == 0) return [];
return arrvSysComment_Sel.map(x=>x.commentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vSysComment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysCommentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const objvSysComment = vSysComment_GetObjFromJsonObj(returnObj);
return objvSysComment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysCommentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvSysCommentExObjLst_Cache: Array<clsvSysCommentEN> = CacheHelper.Get(strKey);
const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
return arrvSysCommentObjLst_T;
}
try
{
const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvSysCommentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
console.log(strInfo);
return arrvSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysComment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysCommentEN.CacheAddiCondition);
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
const arrvSysCommentExObjLst_Cache: Array<clsvSysCommentEN> = JSON.parse(strTempObjLst);
const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
return arrvSysCommentObjLst_T;
}
try
{
const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvSysCommentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
console.log(strInfo);
return arrvSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvSysCommentObjLst_Cache: Array<clsvSysCommentEN> = JSON.parse(strTempObjLst);
return arrvSysCommentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vSysComment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysCommentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysCommentEN.CacheAddiCondition);
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
const arrvSysCommentExObjLst_Cache: Array<clsvSysCommentEN> = JSON.parse(strTempObjLst);
const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
return arrvSysCommentObjLst_T;
}
try
{
const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvSysCommentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
console.log(strInfo);
return arrvSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvSysCommentObjLst_Cache: Array<clsvSysCommentEN> = JSON.parse(strTempObjLst);
return arrvSysCommentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysComment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvSysCommentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvSysCommentWApi.vSysComment_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvSysCommentWApi.vSysComment_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvSysCommentObjLst_Cache;
switch (clsvSysCommentEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvSysCommentObjLst = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentObjLst_Cache);
return arrvSysCommentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysComment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvSysCommentObjLst_Cache;
switch (clsvSysCommentEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysCommentObjLst_Cache = null;
break;
default:
arrvSysCommentObjLst_Cache = null;
break;
}
return arrvSysCommentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCommentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysComment_GetSubObjLst_Cache(objvSysComment_Cond: clsvSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
let arrvSysComment_Sel: Array < clsvSysCommentEN > = arrvSysCommentObjLst_Cache;
if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "") return arrvSysComment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
//console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysComment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvSysComment_Cond), vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysCommentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCommentId:关键字列表
 * @returns 对象列表
 **/
export async function vSysComment_GetObjLstByCommentIdLstAsync(arrCommentId: Array<string>): Promise<Array<clsvSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByCommentIdLstAsync";
const strAction = "GetObjLstByCommentIdLst";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCommentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param arrstrCommentIdLst:关键字列表
 * @returns 对象列表
*/
export async function vSysComment_GetObjLstByCommentIdLst_Cache(arrCommentIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByCommentIdLst_Cache";
try
{
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
const arrvSysComment_Sel: Array <clsvSysCommentEN> = arrvSysCommentObjLst_Cache.filter(x => arrCommentIdLst.indexOf(x.commentId)>-1);
return arrvSysComment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCommentIdLst.join(","), vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysCommentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvSysCommentEN>();
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysCommentObjLst_Cache.length == 0) return arrvSysCommentObjLst_Cache;
let arrvSysComment_Sel = arrvSysCommentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvSysComment_Cond = new clsvSysCommentEN();
ObjectAssign(objvSysComment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvSysCommentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysComment_Sel.length == 0) return arrvSysComment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvSysComment_Sel = arrvSysComment_Sel.sort(vSysComment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvSysComment_Sel = arrvSysComment_Sel.sort(objPagerPara.sortFun);
}
arrvSysComment_Sel = arrvSysComment_Sel.slice(intStart, intEnd);     
return arrvSysComment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysCommentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vSysComment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvSysCommentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param objstrCommentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysComment_IsExistRecord_Cache(objvSysComment_Cond: clsvSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysCommentObjLst_Cache == null) return false;
let arrvSysComment_Sel: Array < clsvSysCommentEN > = arrvSysCommentObjLst_Cache;
if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "") return arrvSysComment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
//console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysComment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvSysComment_Cond), vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param strCommentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vSysComment_IsExist(strCommentId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CommentId": strCommentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param strCommentId:所给的关键字
 * @returns 对象
*/
export async function vSysComment_IsExist_Cache(strCommentId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysCommentObjLst_Cache == null) return false;
try
{
const arrvSysComment_Sel: Array <clsvSysCommentEN> = arrvSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
if (arrvSysComment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCommentId, vSysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strCommentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vSysComment_IsExistAsync(strCommentId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCommentId": strCommentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
export async function vSysComment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysComment_ConstructorName, strThisFuncName);
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
 * @param objvSysComment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vSysComment_GetRecCountByCond_Cache(objvSysComment_Cond: clsvSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysCommentObjLst_Cache == null) return 0;
let arrvSysComment_Sel: Array < clsvSysCommentEN > = arrvSysCommentObjLst_Cache;
if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "") return arrvSysComment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
//console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysComment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvSysComment_Cond), vSysComment_ConstructorName, strThisFuncName);
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
export function vSysComment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSysComment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
switch (clsvSysCommentEN.CacheModeId)
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
export function vSysComment_GetJSONStrByObj (pobjvSysCommentEN: clsvSysCommentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysCommentEN);
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
export function vSysComment_GetObjLstByJSONStr (strJSON: string): Array<clsvSysCommentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysCommentObjLst = new Array<clsvSysCommentEN>();
if (strJSON === "")
{
return arrvSysCommentObjLst;
}
try
{
arrvSysCommentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysCommentObjLst;
}
return arrvSysCommentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysCommentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysComment_GetObjLstByJSONObjLst (arrvSysCommentObjLstS: Array<clsvSysCommentEN>): Array<clsvSysCommentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysCommentObjLst = new Array<clsvSysCommentEN>();
for (const objInFor of arrvSysCommentObjLstS) {
const obj1 = vSysComment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysCommentObjLst.push(obj1);
}
return arrvSysCommentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysComment_GetObjByJSONStr (strJSON: string): clsvSysCommentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysCommentEN = new clsvSysCommentEN();
if (strJSON === "")
{
return pobjvSysCommentEN;
}
try
{
pobjvSysCommentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysCommentEN;
}
return pobjvSysCommentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysComment_GetCombineCondition(objvSysComment_Cond: clsvSysCommentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_CommentId) == true)
{
const strComparisonOp_CommentId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_CommentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_CommentId, objvSysComment_Cond.commentId, strComparisonOp_CommentId);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_Comment) == true)
{
const strComparisonOp_Comment:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_Comment];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_Comment, objvSysComment_Cond.comment, strComparisonOp_Comment);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCommentEN.con_Score, objvSysComment_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_CommentTypeId) == true)
{
const strComparisonOp_CommentTypeId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_CommentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_CommentTypeId, objvSysComment_Cond.commentTypeId, strComparisonOp_CommentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_ScoreType) == true)
{
const strComparisonOp_ScoreType:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_ScoreType, objvSysComment_Cond.scoreType, strComparisonOp_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_ParentId, objvSysComment_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_TableKey, objvSysComment_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_UpdUser, objvSysComment_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_UpdDate, objvSysComment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_Memo, objvSysComment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_CommentTypeName) == true)
{
const strComparisonOp_CommentTypeName:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_CommentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_CommentTypeName, objvSysComment_Cond.commentTypeName, strComparisonOp_CommentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_CommentTable) == true)
{
const strComparisonOp_CommentTable:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_CommentTable];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_CommentTable, objvSysComment_Cond.commentTable, strComparisonOp_CommentTable);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_CommentTableId) == true)
{
const strComparisonOp_CommentTableId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_CommentTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_CommentTableId, objvSysComment_Cond.commentTableId, strComparisonOp_CommentTableId);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvSysCommentEN.con_OkCount, objvSysComment_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_PubParentId) == true)
{
const strComparisonOp_PubParentId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_PubParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_PubParentId, objvSysComment_Cond.pubParentId, strComparisonOp_PubParentId);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_id_CurrEduCls, objvSysComment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysCommentEN.con_UserId, objvSysComment_Cond.userId, strComparisonOp_UserId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysCommentENS:源对象
 * @param objvSysCommentENT:目标对象
*/
export function vSysComment_CopyObjTo(objvSysCommentENS: clsvSysCommentEN , objvSysCommentENT: clsvSysCommentEN ): void 
{
objvSysCommentENT.commentId = objvSysCommentENS.commentId; //评论Id
objvSysCommentENT.comment = objvSysCommentENS.comment; //评论
objvSysCommentENT.score = objvSysCommentENS.score; //评分
objvSysCommentENT.commentTypeId = objvSysCommentENS.commentTypeId; //评论类型Id
objvSysCommentENT.scoreType = objvSysCommentENS.scoreType; //评分类型
objvSysCommentENT.parentId = objvSysCommentENS.parentId; //父Id
objvSysCommentENT.tableKey = objvSysCommentENS.tableKey; //表主键
objvSysCommentENT.updUser = objvSysCommentENS.updUser; //修改人
objvSysCommentENT.updDate = objvSysCommentENS.updDate; //修改日期
objvSysCommentENT.memo = objvSysCommentENS.memo; //备注
objvSysCommentENT.commentTypeName = objvSysCommentENS.commentTypeName; //评论类型名
objvSysCommentENT.commentTable = objvSysCommentENS.commentTable; //评论表
objvSysCommentENT.commentTableId = objvSysCommentENS.commentTableId; //评论表Id
objvSysCommentENT.okCount = objvSysCommentENS.okCount; //点赞统计
objvSysCommentENT.pubParentId = objvSysCommentENS.pubParentId; //公共父Id
objvSysCommentENT.id_CurrEduCls = objvSysCommentENS.id_CurrEduCls; //教学班流水号
objvSysCommentENT.userId = objvSysCommentENS.userId; //用户ID
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysCommentENS:源对象
 * @param objvSysCommentENT:目标对象
*/
export function vSysComment_GetObjFromJsonObj(objvSysCommentENS: clsvSysCommentEN): clsvSysCommentEN 
{
 const objvSysCommentENT: clsvSysCommentEN = new clsvSysCommentEN();
ObjectAssign(objvSysCommentENT, objvSysCommentENS);
 return objvSysCommentENT;
}