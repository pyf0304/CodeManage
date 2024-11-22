
 /**
 * 类名:clsSysCommentWApi
 * 表名:SysComment(01120622)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:46:52
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
 * 系统评论表(SysComment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsSysCommentEN } from "../../L0_Entity/GraduateEduTools/clsSysCommentEN.js";
import { vSysComment_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysComment_Controller = "SysCommentApi";
 export const sysComment_ConstructorName = "sysComment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCommentId:关键字
 * @returns 对象
 **/
export async function SysComment_GetObjByCommentIdAsync(strCommentId: string): Promise<clsSysCommentEN|null>  
{
const strThisFuncName = "GetObjByCommentIdAsync";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentIdAsync)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCommentId";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const objSysComment = SysComment_GetObjFromJsonObj(returnObj);
return objSysComment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjByCommentId_Cache(strCommentId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByCommentId_Cache";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentId_Cache)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrSysComment_Sel: Array <clsSysCommentEN> = arrSysCommentObjLst_Cache.filter(x => 
 x.commentId == strCommentId );
let objSysComment: clsSysCommentEN;
if (arrSysComment_Sel.length > 0)
{
objSysComment = arrSysComment_Sel[0];
return objSysComment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objSysComment_Const = await SysComment_GetObjByCommentIdAsync(strCommentId);
if (objSysComment_Const != null)
{
SysComment_ReFreshThisCache(strid_CurrEduCls);
return objSysComment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjByCommentId_localStorage(strCommentId: string) {
const strThisFuncName = "GetObjByCommentId_localStorage";

if (IsNullOrEmpty(strCommentId) == true)
{
  const strMsg = Format("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strCommentId.length != 10)
{
const strMsg = Format("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentId_localStorage)", strCommentId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strCommentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysComment_Cache: clsSysCommentEN = JSON.parse(strTempObj);
return objSysComment_Cache;
}
try
{
const objSysComment = await SysComment_GetObjByCommentIdAsync(strCommentId);
if (objSysComment != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysComment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysComment;
}
return objSysComment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysComment:所给的对象
 * @returns 对象
*/
export async function SysComment_UpdateObjInLst_Cache(objSysComment: clsSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrSysCommentObjLst_Cache.find(x => x.commentId == objSysComment.commentId);
if (obj != null)
{
objSysComment.commentId = obj.commentId;
ObjectAssign( obj, objSysComment);
}
else
{
arrSysCommentObjLst_Cache.push(objSysComment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsSysCommentWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysCommentWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsSysCommentEN.con_CommentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysCommentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsSysCommentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strCommentId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSysComment = await SysComment_GetObjByCommentId_Cache(strCommentId , strid_CurrEduCls_C);
if (objSysComment == null) return "";
if (objSysComment.GetFldValue(strOutFldName) == null) return "";
return objSysComment.GetFldValue(strOutFldName).toString();
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
export function SysComment_SortFun_Defa(a:clsSysCommentEN , b:clsSysCommentEN): number 
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
export function SysComment_SortFun_Defa_2Fld(a:clsSysCommentEN , b:clsSysCommentEN): number 
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
export function SysComment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysCommentEN.con_CommentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.commentId.localeCompare(b.commentId);
}
case clsSysCommentEN.con_Comment:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.comment == null) return -1;
if (b.comment == null) return 1;
return a.comment.localeCompare(b.comment);
}
case clsSysCommentEN.con_Score:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.score-b.score;
}
case clsSysCommentEN.con_CommentTypeId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.commentTypeId.localeCompare(b.commentTypeId);
}
case clsSysCommentEN.con_ScoreType:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.scoreType == null) return -1;
if (b.scoreType == null) return 1;
return a.scoreType.localeCompare(b.scoreType);
}
case clsSysCommentEN.con_ParentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.parentId.localeCompare(b.parentId);
}
case clsSysCommentEN.con_TableKey:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsSysCommentEN.con_OkCount:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.okCount-b.okCount;
}
case clsSysCommentEN.con_PubParentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.pubParentId == null) return -1;
if (b.pubParentId == null) return 1;
return a.pubParentId.localeCompare(b.pubParentId);
}
case clsSysCommentEN.con_id_CurrEduCls:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysCommentEN.con_UserId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.userId == null) return -1;
if (b.userId == null) return 1;
return a.userId.localeCompare(b.userId);
}
case clsSysCommentEN.con_Month:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.month-b.month;
}
case clsSysCommentEN.con_Week:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return a.week-b.week;
}
case clsSysCommentEN.con_WeekTimeRange:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.weekTimeRange == null) return -1;
if (b.weekTimeRange == null) return 1;
return a.weekTimeRange.localeCompare(b.weekTimeRange);
}
case clsSysCommentEN.con_UpdUser:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsSysCommentEN.con_UpdDate:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsSysCommentEN.con_Memo:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${ sysComment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysCommentEN.con_CommentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.commentId.localeCompare(a.commentId);
}
case clsSysCommentEN.con_Comment:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.comment == null) return -1;
if (a.comment == null) return 1;
return b.comment.localeCompare(a.comment);
}
case clsSysCommentEN.con_Score:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.score-a.score;
}
case clsSysCommentEN.con_CommentTypeId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.commentTypeId.localeCompare(a.commentTypeId);
}
case clsSysCommentEN.con_ScoreType:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.scoreType == null) return -1;
if (a.scoreType == null) return 1;
return b.scoreType.localeCompare(a.scoreType);
}
case clsSysCommentEN.con_ParentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.parentId.localeCompare(a.parentId);
}
case clsSysCommentEN.con_TableKey:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsSysCommentEN.con_OkCount:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.okCount-a.okCount;
}
case clsSysCommentEN.con_PubParentId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.pubParentId == null) return -1;
if (a.pubParentId == null) return 1;
return b.pubParentId.localeCompare(a.pubParentId);
}
case clsSysCommentEN.con_id_CurrEduCls:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysCommentEN.con_UserId:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.userId == null) return -1;
if (a.userId == null) return 1;
return b.userId.localeCompare(a.userId);
}
case clsSysCommentEN.con_Month:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.month-a.month;
}
case clsSysCommentEN.con_Week:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
return b.week-a.week;
}
case clsSysCommentEN.con_WeekTimeRange:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.weekTimeRange == null) return -1;
if (a.weekTimeRange == null) return 1;
return b.weekTimeRange.localeCompare(a.weekTimeRange);
}
case clsSysCommentEN.con_UpdUser:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsSysCommentEN.con_UpdDate:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsSysCommentEN.con_Memo:
return (a: clsSysCommentEN, b: clsSysCommentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${ sysComment_ConstructorName}.${ strThisFuncName})`;
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
export async function SysComment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysCommentEN.con_CommentId:
return (obj: clsSysCommentEN) => {
return obj.commentId === value;
}
case clsSysCommentEN.con_Comment:
return (obj: clsSysCommentEN) => {
return obj.comment === value;
}
case clsSysCommentEN.con_Score:
return (obj: clsSysCommentEN) => {
return obj.score === value;
}
case clsSysCommentEN.con_CommentTypeId:
return (obj: clsSysCommentEN) => {
return obj.commentTypeId === value;
}
case clsSysCommentEN.con_ScoreType:
return (obj: clsSysCommentEN) => {
return obj.scoreType === value;
}
case clsSysCommentEN.con_ParentId:
return (obj: clsSysCommentEN) => {
return obj.parentId === value;
}
case clsSysCommentEN.con_TableKey:
return (obj: clsSysCommentEN) => {
return obj.tableKey === value;
}
case clsSysCommentEN.con_OkCount:
return (obj: clsSysCommentEN) => {
return obj.okCount === value;
}
case clsSysCommentEN.con_PubParentId:
return (obj: clsSysCommentEN) => {
return obj.pubParentId === value;
}
case clsSysCommentEN.con_id_CurrEduCls:
return (obj: clsSysCommentEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysCommentEN.con_UserId:
return (obj: clsSysCommentEN) => {
return obj.userId === value;
}
case clsSysCommentEN.con_Month:
return (obj: clsSysCommentEN) => {
return obj.month === value;
}
case clsSysCommentEN.con_Week:
return (obj: clsSysCommentEN) => {
return obj.week === value;
}
case clsSysCommentEN.con_WeekTimeRange:
return (obj: clsSysCommentEN) => {
return obj.weekTimeRange === value;
}
case clsSysCommentEN.con_UpdUser:
return (obj: clsSysCommentEN) => {
return obj.updUser === value;
}
case clsSysCommentEN.con_UpdDate:
return (obj: clsSysCommentEN) => {
return obj.updDate === value;
}
case clsSysCommentEN.con_Memo:
return (obj: clsSysCommentEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${ sysComment_ConstructorName}.${ strThisFuncName})`;
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
export async function SysComment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsSysCommentWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysCommentWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsSysCommentEN.con_CommentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrSysComment = await SysComment_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrSysComment == null) return [];
let arrSysComment_Sel = arrSysComment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrSysComment_Sel.length == 0) return [];
return arrSysComment_Sel.map(x=>x.commentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysComment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetFirstObjAsync(strWhereCond: string): Promise<clsSysCommentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const objSysComment = SysComment_GetObjFromJsonObj(returnObj);
return objSysComment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysCommentExObjLst_Cache: Array<clsSysCommentEN> = CacheHelper.Get(strKey);
const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
return arrSysCommentObjLst_T;
}
try
{
const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysCommentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
console.log(strInfo);
return arrSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysComment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentEN.CacheAddiCondition);
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
const arrSysCommentExObjLst_Cache: Array<clsSysCommentEN> = JSON.parse(strTempObjLst);
const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
return arrSysCommentObjLst_T;
}
try
{
const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysCommentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
console.log(strInfo);
return arrSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysCommentObjLst_Cache: Array<clsSysCommentEN> = JSON.parse(strTempObjLst);
return arrSysCommentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysComment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysCommentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysCommentEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysCommentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsSysCommentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysCommentEN.CacheAddiCondition);
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
const arrSysCommentExObjLst_Cache: Array<clsSysCommentEN> = JSON.parse(strTempObjLst);
const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
return arrSysCommentObjLst_T;
}
try
{
const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysCommentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
console.log(strInfo);
return arrSysCommentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysCommentObjLst_Cache: Array<clsSysCommentEN> = JSON.parse(strTempObjLst);
return arrSysCommentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysComment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsSysCommentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsSysCommentWApi.SysComment_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsSysCommentWApi.SysComment_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrSysCommentObjLst_Cache;
switch (clsSysCommentEN.CacheModeId)
{
case "04"://sessionStorage
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrSysCommentObjLst = SysComment_GetObjLstByJSONObjLst(arrSysCommentObjLst_Cache);
return arrSysCommentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysComment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysCommentObjLst_Cache;
switch (clsSysCommentEN.CacheModeId)
{
case "04"://sessionStorage
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysCommentObjLst_Cache = await SysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysCommentObjLst_Cache = null;
break;
default:
arrSysCommentObjLst_Cache = null;
break;
}
return arrSysCommentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrCommentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysComment_GetSubObjLst_Cache(objSysComment_Cond: clsSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
let arrSysComment_Sel: Array < clsSysCommentEN > = arrSysCommentObjLst_Cache;
if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "") return arrSysComment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysComment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysComment_Cond), sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysCommentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrCommentId:关键字列表
 * @returns 对象列表
 **/
export async function SysComment_GetObjLstByCommentIdLstAsync(arrCommentId: Array<string>): Promise<Array<clsSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByCommentIdLstAsync";
const strAction = "GetObjLstByCommentIdLst";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCommentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLstByCommentIdLst_Cache(arrCommentIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByCommentIdLst_Cache";
try
{
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
const arrSysComment_Sel: Array <clsSysCommentEN> = arrSysCommentObjLst_Cache.filter(x => arrCommentIdLst.indexOf(x.commentId)>-1);
return arrSysComment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCommentIdLst.join(","), sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysCommentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsSysCommentEN>();
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysCommentObjLst_Cache.length == 0) return arrSysCommentObjLst_Cache;
let arrSysComment_Sel = arrSysCommentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysComment_Cond = new clsSysCommentEN();
ObjectAssign(objSysComment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysCommentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysComment_Sel.length == 0) return arrSysComment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysComment_Sel = arrSysComment_Sel.sort(SysComment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysComment_Sel = arrSysComment_Sel.sort(objPagerPara.sortFun);
}
arrSysComment_Sel = arrSysComment_Sel.slice(intStart, intEnd);     
return arrSysComment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysComment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysCommentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysComment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysCommentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSysCommentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysComment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param strCommentId:关键字
 * @returns 获取删除的结果
 **/
export async function SysComment_DelRecordAsync(strCommentId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysComment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strCommentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param arrCommentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysComment_DelSysCommentsAsync(arrCommentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysCommentsAsync";
const strAction = "DelSysComments";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCommentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_DelSysCommentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysCommentsByCondAsync";
const strAction = "DelSysCommentsByCond";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysComment_AddNewRecordAsync(objSysCommentEN: clsSysCommentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysCommentEN);
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN: clsSysCommentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysComment_AddNewRecordWithReturnKeyAsync(objSysCommentEN: clsSysCommentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysComment_AddNewRecordWithReturnKey(objSysCommentEN: clsSysCommentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysCommentEN.commentId === null || objSysCommentEN.commentId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysComment_UpdateRecordAsync(objSysCommentEN: clsSysCommentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysCommentEN.sfUpdFldSetStr === undefined || objSysCommentEN.sfUpdFldSetStr === null || objSysCommentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentEN.commentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysCommentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysComment_UpdateWithConditionAsync(objSysCommentEN: clsSysCommentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysCommentEN.sfUpdFldSetStr === undefined || objSysCommentEN.sfUpdFldSetStr === null || objSysCommentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentEN.commentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
objSysCommentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysCommentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_IsExistRecord_Cache(objSysComment_Cond: clsSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysCommentObjLst_Cache == null) return false;
let arrSysComment_Sel: Array < clsSysCommentEN > = arrSysCommentObjLst_Cache;
if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "") return arrSysComment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysComment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysComment_Cond), sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_IsExist(strCommentId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_IsExist_Cache(strCommentId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysCommentObjLst_Cache == null) return false;
try
{
const arrSysComment_Sel: Array <clsSysCommentEN> = arrSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
if (arrSysComment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCommentId, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_IsExistAsync(strCommentId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
 * @param objSysComment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysComment_GetRecCountByCond_Cache(objSysComment_Cond: clsSysCommentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysCommentObjLst_Cache == null) return 0;
let arrSysComment_Sel: Array < clsSysCommentEN > = arrSysCommentObjLst_Cache;
if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "") return arrSysComment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
//console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysComment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysComment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysComment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysComment_Cond), sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export async function SysComment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysComment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysComment_ConstructorName, strThisFuncName);
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
export function SysComment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysComment_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsSysCommentWApi.clsSysCommentWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsSysCommentWApi.clsSysCommentWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
switch (clsSysCommentEN.CacheModeId)
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
vSysComment_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function SysComment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsSysCommentEN._CurrTabName, strid_CurrEduCls);
switch (clsSysCommentEN.CacheModeId)
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
export function SysComment_CheckPropertyNew(pobjSysCommentEN: clsSysCommentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysCommentEN.commentTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[评论类型Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.parentId) === true )
{
 throw new Error("(errid:Watl000058)字段[父Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysCommentEN.commentId) == false && GetStrLen(pobjSysCommentEN.commentId) > 10)
{
 throw new Error("(errid:Watl000059)字段[评论Id(commentId)]的长度不能超过10(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentId)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.comment) == false && GetStrLen(pobjSysCommentEN.comment) > 2000)
{
 throw new Error("(errid:Watl000059)字段[评论(comment)]的长度不能超过2000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.comment)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.commentTypeId) == false && GetStrLen(pobjSysCommentEN.commentTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentTypeId)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.scoreType) == false && GetStrLen(pobjSysCommentEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.scoreType)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.parentId) == false && GetStrLen(pobjSysCommentEN.parentId) > 20)
{
 throw new Error("(errid:Watl000059)字段[父Id(parentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.parentId)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.tableKey) == false && GetStrLen(pobjSysCommentEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.tableKey)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.pubParentId) == false && GetStrLen(pobjSysCommentEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000059)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.pubParentId)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.id_CurrEduCls) == false && GetStrLen(pobjSysCommentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.id_CurrEduCls)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.userId) == false && GetStrLen(pobjSysCommentEN.userId) > 18)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.userId)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.weekTimeRange) == false && GetStrLen(pobjSysCommentEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000059)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.weekTimeRange)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updUser) == false && GetStrLen(pobjSysCommentEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updUser)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updDate) == false && GetStrLen(pobjSysCommentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updDate)(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.memo) == false && GetStrLen(pobjSysCommentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.memo)(clsSysCommentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysCommentEN.commentId) == false && undefined !== pobjSysCommentEN.commentId && tzDataType.isString(pobjSysCommentEN.commentId) === false)
{
 throw new Error("(errid:Watl000060)字段[评论Id(commentId)]的值:[$(pobjSysCommentEN.commentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.comment) == false && undefined !== pobjSysCommentEN.comment && tzDataType.isString(pobjSysCommentEN.comment) === false)
{
 throw new Error("(errid:Watl000060)字段[评论(comment)]的值:[$(pobjSysCommentEN.comment)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (null != pobjSysCommentEN.score && undefined !== pobjSysCommentEN.score && tzDataType.isNumber(pobjSysCommentEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysCommentEN.score)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.commentTypeId) == false && undefined !== pobjSysCommentEN.commentTypeId && tzDataType.isString(pobjSysCommentEN.commentTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentEN.commentTypeId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.scoreType) == false && undefined !== pobjSysCommentEN.scoreType && tzDataType.isString(pobjSysCommentEN.scoreType) === false)
{
 throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjSysCommentEN.scoreType)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.parentId) == false && undefined !== pobjSysCommentEN.parentId && tzDataType.isString(pobjSysCommentEN.parentId) === false)
{
 throw new Error("(errid:Watl000060)字段[父Id(parentId)]的值:[$(pobjSysCommentEN.parentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.tableKey) == false && undefined !== pobjSysCommentEN.tableKey && tzDataType.isString(pobjSysCommentEN.tableKey) === false)
{
 throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysCommentEN.tableKey)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (null != pobjSysCommentEN.okCount && undefined !== pobjSysCommentEN.okCount && tzDataType.isNumber(pobjSysCommentEN.okCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysCommentEN.okCount)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.pubParentId) == false && undefined !== pobjSysCommentEN.pubParentId && tzDataType.isString(pobjSysCommentEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000060)字段[公共父Id(pubParentId)]的值:[$(pobjSysCommentEN.pubParentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.id_CurrEduCls) == false && undefined !== pobjSysCommentEN.id_CurrEduCls && tzDataType.isString(pobjSysCommentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysCommentEN.id_CurrEduCls)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.userId) == false && undefined !== pobjSysCommentEN.userId && tzDataType.isString(pobjSysCommentEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjSysCommentEN.userId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (null != pobjSysCommentEN.month && undefined !== pobjSysCommentEN.month && tzDataType.isNumber(pobjSysCommentEN.month) === false)
{
 throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjSysCommentEN.month)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (null != pobjSysCommentEN.week && undefined !== pobjSysCommentEN.week && tzDataType.isNumber(pobjSysCommentEN.week) === false)
{
 throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjSysCommentEN.week)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.weekTimeRange) == false && undefined !== pobjSysCommentEN.weekTimeRange && tzDataType.isString(pobjSysCommentEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000060)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjSysCommentEN.weekTimeRange)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updUser) == false && undefined !== pobjSysCommentEN.updUser && tzDataType.isString(pobjSysCommentEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysCommentEN.updUser)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updDate) == false && undefined !== pobjSysCommentEN.updDate && tzDataType.isString(pobjSysCommentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysCommentEN.updDate)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysCommentEN.memo) == false && undefined !== pobjSysCommentEN.memo && tzDataType.isString(pobjSysCommentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysCommentEN.memo)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysCommentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysComment_CheckProperty4Update (pobjSysCommentEN: clsSysCommentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysCommentEN.commentId) == false && GetStrLen(pobjSysCommentEN.commentId) > 10)
{
 throw new Error("(errid:Watl000062)字段[评论Id(commentId)]的长度不能超过10(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentId)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.comment) == false && GetStrLen(pobjSysCommentEN.comment) > 2000)
{
 throw new Error("(errid:Watl000062)字段[评论(comment)]的长度不能超过2000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.comment)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.commentTypeId) == false && GetStrLen(pobjSysCommentEN.commentTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentTypeId)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.scoreType) == false && GetStrLen(pobjSysCommentEN.scoreType) > 1)
{
 throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.scoreType)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.parentId) == false && GetStrLen(pobjSysCommentEN.parentId) > 20)
{
 throw new Error("(errid:Watl000062)字段[父Id(parentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.parentId)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.tableKey) == false && GetStrLen(pobjSysCommentEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.tableKey)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.pubParentId) == false && GetStrLen(pobjSysCommentEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000062)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.pubParentId)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.id_CurrEduCls) == false && GetStrLen(pobjSysCommentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.id_CurrEduCls)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.userId) == false && GetStrLen(pobjSysCommentEN.userId) > 18)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.userId)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.weekTimeRange) == false && GetStrLen(pobjSysCommentEN.weekTimeRange) > 100)
{
 throw new Error("(errid:Watl000062)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.weekTimeRange)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updUser) == false && GetStrLen(pobjSysCommentEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updUser)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updDate) == false && GetStrLen(pobjSysCommentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updDate)(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.memo) == false && GetStrLen(pobjSysCommentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.memo)(clsSysCommentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysCommentEN.commentId) == false && undefined !== pobjSysCommentEN.commentId && tzDataType.isString(pobjSysCommentEN.commentId) === false)
{
 throw new Error("(errid:Watl000063)字段[评论Id(commentId)]的值:[$(pobjSysCommentEN.commentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.comment) == false && undefined !== pobjSysCommentEN.comment && tzDataType.isString(pobjSysCommentEN.comment) === false)
{
 throw new Error("(errid:Watl000063)字段[评论(comment)]的值:[$(pobjSysCommentEN.comment)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (null != pobjSysCommentEN.score && undefined !== pobjSysCommentEN.score && tzDataType.isNumber(pobjSysCommentEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysCommentEN.score)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.commentTypeId) == false && undefined !== pobjSysCommentEN.commentTypeId && tzDataType.isString(pobjSysCommentEN.commentTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentEN.commentTypeId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.scoreType) == false && undefined !== pobjSysCommentEN.scoreType && tzDataType.isString(pobjSysCommentEN.scoreType) === false)
{
 throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjSysCommentEN.scoreType)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.parentId) == false && undefined !== pobjSysCommentEN.parentId && tzDataType.isString(pobjSysCommentEN.parentId) === false)
{
 throw new Error("(errid:Watl000063)字段[父Id(parentId)]的值:[$(pobjSysCommentEN.parentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.tableKey) == false && undefined !== pobjSysCommentEN.tableKey && tzDataType.isString(pobjSysCommentEN.tableKey) === false)
{
 throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysCommentEN.tableKey)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (null != pobjSysCommentEN.okCount && undefined !== pobjSysCommentEN.okCount && tzDataType.isNumber(pobjSysCommentEN.okCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysCommentEN.okCount)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.pubParentId) == false && undefined !== pobjSysCommentEN.pubParentId && tzDataType.isString(pobjSysCommentEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000063)字段[公共父Id(pubParentId)]的值:[$(pobjSysCommentEN.pubParentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.id_CurrEduCls) == false && undefined !== pobjSysCommentEN.id_CurrEduCls && tzDataType.isString(pobjSysCommentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysCommentEN.id_CurrEduCls)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.userId) == false && undefined !== pobjSysCommentEN.userId && tzDataType.isString(pobjSysCommentEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjSysCommentEN.userId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (null != pobjSysCommentEN.month && undefined !== pobjSysCommentEN.month && tzDataType.isNumber(pobjSysCommentEN.month) === false)
{
 throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjSysCommentEN.month)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (null != pobjSysCommentEN.week && undefined !== pobjSysCommentEN.week && tzDataType.isNumber(pobjSysCommentEN.week) === false)
{
 throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjSysCommentEN.week)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.weekTimeRange) == false && undefined !== pobjSysCommentEN.weekTimeRange && tzDataType.isString(pobjSysCommentEN.weekTimeRange) === false)
{
 throw new Error("(errid:Watl000063)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjSysCommentEN.weekTimeRange)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updUser) == false && undefined !== pobjSysCommentEN.updUser && tzDataType.isString(pobjSysCommentEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysCommentEN.updUser)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.updDate) == false && undefined !== pobjSysCommentEN.updDate && tzDataType.isString(pobjSysCommentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysCommentEN.updDate)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysCommentEN.memo) == false && undefined !== pobjSysCommentEN.memo && tzDataType.isString(pobjSysCommentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysCommentEN.memo)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysCommentEN.commentId) === true )
{
 throw new Error("(errid:Watl000064)字段[评论Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysCommentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysComment_GetJSONStrByObj (pobjSysCommentEN: clsSysCommentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysCommentEN.sfUpdFldSetStr = pobjSysCommentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysCommentEN);
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
export function SysComment_GetObjLstByJSONStr (strJSON: string): Array<clsSysCommentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysCommentObjLst = new Array<clsSysCommentEN>();
if (strJSON === "")
{
return arrSysCommentObjLst;
}
try
{
arrSysCommentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysCommentObjLst;
}
return arrSysCommentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysCommentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysComment_GetObjLstByJSONObjLst (arrSysCommentObjLstS: Array<clsSysCommentEN>): Array<clsSysCommentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysCommentObjLst = new Array<clsSysCommentEN>();
for (const objInFor of arrSysCommentObjLstS) {
const obj1 = SysComment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysCommentObjLst.push(obj1);
}
return arrSysCommentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysComment_GetObjByJSONStr (strJSON: string): clsSysCommentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysCommentEN = new clsSysCommentEN();
if (strJSON === "")
{
return pobjSysCommentEN;
}
try
{
pobjSysCommentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysCommentEN;
}
return pobjSysCommentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysComment_GetCombineCondition(objSysComment_Cond: clsSysCommentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_CommentId) == true)
{
const strComparisonOp_CommentId:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_CommentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_CommentId, objSysComment_Cond.commentId, strComparisonOp_CommentId);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_Comment) == true)
{
const strComparisonOp_Comment:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_Comment];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_Comment, objSysComment_Cond.comment, strComparisonOp_Comment);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_Score) == true)
{
const strComparisonOp_Score:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsSysCommentEN.con_Score, objSysComment_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_CommentTypeId) == true)
{
const strComparisonOp_CommentTypeId:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_CommentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_CommentTypeId, objSysComment_Cond.commentTypeId, strComparisonOp_CommentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_ScoreType) == true)
{
const strComparisonOp_ScoreType:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_ScoreType];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_ScoreType, objSysComment_Cond.scoreType, strComparisonOp_ScoreType);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_ParentId, objSysComment_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_TableKey, objSysComment_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsSysCommentEN.con_OkCount, objSysComment_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_PubParentId) == true)
{
const strComparisonOp_PubParentId:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_PubParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_PubParentId, objSysComment_Cond.pubParentId, strComparisonOp_PubParentId);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_id_CurrEduCls, objSysComment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_UserId, objSysComment_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_Month) == true)
{
const strComparisonOp_Month:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_Month];
strWhereCond += Format(" And {0} {2} {1}", clsSysCommentEN.con_Month, objSysComment_Cond.month, strComparisonOp_Month);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_Week) == true)
{
const strComparisonOp_Week:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_Week];
strWhereCond += Format(" And {0} {2} {1}", clsSysCommentEN.con_Week, objSysComment_Cond.week, strComparisonOp_Week);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_WeekTimeRange) == true)
{
const strComparisonOp_WeekTimeRange:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_WeekTimeRange];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_WeekTimeRange, objSysComment_Cond.weekTimeRange, strComparisonOp_WeekTimeRange);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_UpdUser, objSysComment_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_UpdDate, objSysComment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysCommentEN.con_Memo, objSysComment_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysComment(系统评论表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strCommentId: 评论Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysComment_GetUniCondStr_CommentId(objSysCommentEN: clsSysCommentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and CommentId = '{0}'", objSysCommentEN.commentId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysComment(系统评论表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strCommentId: 评论Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysComment_GetUniCondStr4Update_CommentId(objSysCommentEN: clsSysCommentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and CommentId <> '{0}'", objSysCommentEN.commentId);
 strWhereCond +=  Format(" and CommentId = '{0}'", objSysCommentEN.commentId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysCommentENS:源对象
 * @param objSysCommentENT:目标对象
*/
export function SysComment_CopyObjTo(objSysCommentENS: clsSysCommentEN , objSysCommentENT: clsSysCommentEN ): void 
{
objSysCommentENT.commentId = objSysCommentENS.commentId; //评论Id
objSysCommentENT.comment = objSysCommentENS.comment; //评论
objSysCommentENT.score = objSysCommentENS.score; //评分
objSysCommentENT.commentTypeId = objSysCommentENS.commentTypeId; //评论类型Id
objSysCommentENT.scoreType = objSysCommentENS.scoreType; //评分类型
objSysCommentENT.parentId = objSysCommentENS.parentId; //父Id
objSysCommentENT.tableKey = objSysCommentENS.tableKey; //表主键
objSysCommentENT.okCount = objSysCommentENS.okCount; //点赞统计
objSysCommentENT.pubParentId = objSysCommentENS.pubParentId; //公共父Id
objSysCommentENT.id_CurrEduCls = objSysCommentENS.id_CurrEduCls; //教学班流水号
objSysCommentENT.userId = objSysCommentENS.userId; //用户ID
objSysCommentENT.month = objSysCommentENS.month; //月
objSysCommentENT.week = objSysCommentENS.week; //周
objSysCommentENT.weekTimeRange = objSysCommentENS.weekTimeRange; //WeekTimeRange
objSysCommentENT.updUser = objSysCommentENS.updUser; //修改人
objSysCommentENT.updDate = objSysCommentENS.updDate; //修改日期
objSysCommentENT.memo = objSysCommentENS.memo; //备注
objSysCommentENT.sfUpdFldSetStr = objSysCommentENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysCommentENS:源对象
 * @param objSysCommentENT:目标对象
*/
export function SysComment_GetObjFromJsonObj(objSysCommentENS: clsSysCommentEN): clsSysCommentEN 
{
 const objSysCommentENT: clsSysCommentEN = new clsSysCommentEN();
ObjectAssign(objSysCommentENT, objSysCommentENS);
 return objSysCommentENT;
}