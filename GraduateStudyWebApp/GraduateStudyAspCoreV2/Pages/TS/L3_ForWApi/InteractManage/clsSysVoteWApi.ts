
 /**
 * 类名:clsSysVoteWApi
 * 表名:SysVote(01120639)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:44:35
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 系统点赞表(SysVote)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsSysVoteEN } from "../../L0_Entity/InteractManage/clsSysVoteEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysVote_Controller = "SysVoteApi";
 export const sysVote_ConstructorName = "sysVote";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngVoteId:关键字
 * @returns 对象
 **/
export async function SysVote_GetObjByVoteIdAsync(lngVoteId: number): Promise<clsSysVoteEN|null>  
{
const strThisFuncName = "GetObjByVoteIdAsync";

if (lngVoteId == 0)
{
  const strMsg = Format("参数:[lngVoteId]不能为空！(In clsSysVoteWApi.GetObjByVoteIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByVoteId";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngVoteId": lngVoteId,
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
const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
return objSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:所给的关键字
 * @returns 对象
*/
export async function SysVote_GetObjByVoteId_Cache(lngVoteId:number,strUpdUser:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByVoteId_Cache";

if (lngVoteId == 0)
{
  const strMsg = Format("参数:[lngVoteId]不能为空！(In clsSysVoteWApi.GetObjByVoteId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
try
{
const arrSysVote_Sel: Array <clsSysVoteEN> = arrSysVoteObjLst_Cache.filter(x => 
 x.voteId == lngVoteId );
let objSysVote: clsSysVoteEN;
if (arrSysVote_Sel.length > 0)
{
objSysVote = arrSysVote_Sel[0];
return objSysVote;
}
else
{
if (bolTryAsyncOnce == true)
{
const objSysVote_Const = await SysVote_GetObjByVoteIdAsync(lngVoteId);
if (objSysVote_Const != null)
{
SysVote_ReFreshThisCache(strUpdUser);
return objSysVote_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngVoteId, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngVoteId:所给的关键字
 * @returns 对象
*/
export async function SysVote_GetObjByVoteId_localStorage(lngVoteId: number) {
const strThisFuncName = "GetObjByVoteId_localStorage";

if (lngVoteId == 0)
{
  const strMsg = Format("参数:[lngVoteId]不能为空！(In clsSysVoteWApi.GetObjByVoteId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, lngVoteId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysVote_Cache: clsSysVoteEN = JSON.parse(strTempObj);
return objSysVote_Cache;
}
try
{
const objSysVote = await SysVote_GetObjByVoteIdAsync(lngVoteId);
if (objSysVote != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysVote));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysVote;
}
return objSysVote;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngVoteId, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysVote:所给的对象
 * @returns 对象
*/
export async function SysVote_UpdateObjInLst_Cache(objSysVote: clsSysVoteEN,strUpdUser: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
const obj = arrSysVoteObjLst_Cache.find(x => x.voteId == objSysVote.voteId);
if (obj != null)
{
objSysVote.voteId = obj.voteId;
ObjectAssign( obj, objSysVote);
}
else
{
arrSysVoteObjLst_Cache.push(objSysVote);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysVote_ConstructorName, strThisFuncName);
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
 @param strUpdUser:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function SysVote_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strUpdUser_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strUpdUser_C) == true)
{
  const strMsg = Format("参数:[strUpdUser_C]不能为空！(In clsSysVoteWApi.func)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName != clsSysVoteEN.con_VoteId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysVoteEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsSysVoteEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngVoteId = Number(strInValue);
if (lngVoteId == 0)
{
return "";
}
const objSysVote = await SysVote_GetObjByVoteId_Cache(lngVoteId , strUpdUser_C);
if (objSysVote == null) return "";
if (objSysVote.GetFldValue(strOutFldName) == null) return "";
return objSysVote.GetFldValue(strOutFldName).toString();
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
export function SysVote_SortFun_Defa(a:clsSysVoteEN , b:clsSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.voteId-b.voteId;
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
export function SysVote_SortFun_Defa_2Fld(a:clsSysVoteEN , b:clsSysVoteEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.tableKey == b.tableKey) return a.pubParentId.localeCompare(b.pubParentId);
else return a.tableKey.localeCompare(b.tableKey);
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
export function SysVote_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return a.voteId-b.voteId;
}
case clsSysVoteEN.con_TableKey:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.tableKey == null) return -1;
if (b.tableKey == null) return 1;
return a.tableKey.localeCompare(b.tableKey);
}
case clsSysVoteEN.con_PubParentId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.pubParentId == null) return -1;
if (b.pubParentId == null) return 1;
return a.pubParentId.localeCompare(b.pubParentId);
}
case clsSysVoteEN.con_VoteTypeId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.voteTypeId == null) return -1;
if (b.voteTypeId == null) return 1;
return a.voteTypeId.localeCompare(b.voteTypeId);
}
case clsSysVoteEN.con_LikedUserId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.likedUserId == null) return -1;
if (b.likedUserId == null) return 1;
return a.likedUserId.localeCompare(b.likedUserId);
}
case clsSysVoteEN.con_UpdUser:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsSysVoteEN.con_UpdDate:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsSysVoteEN.con_Memo:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsSysVoteEN.con_id_CurrEduCls:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
return b.voteId-a.voteId;
}
case clsSysVoteEN.con_TableKey:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.tableKey == null) return -1;
if (a.tableKey == null) return 1;
return b.tableKey.localeCompare(a.tableKey);
}
case clsSysVoteEN.con_PubParentId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.pubParentId == null) return -1;
if (a.pubParentId == null) return 1;
return b.pubParentId.localeCompare(a.pubParentId);
}
case clsSysVoteEN.con_VoteTypeId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.voteTypeId == null) return -1;
if (a.voteTypeId == null) return 1;
return b.voteTypeId.localeCompare(a.voteTypeId);
}
case clsSysVoteEN.con_LikedUserId:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.likedUserId == null) return -1;
if (a.likedUserId == null) return 1;
return b.likedUserId.localeCompare(a.likedUserId);
}
case clsSysVoteEN.con_UpdUser:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsSysVoteEN.con_UpdDate:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsSysVoteEN.con_Memo:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsSysVoteEN.con_id_CurrEduCls:
return (a: clsSysVoteEN, b: clsSysVoteEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
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
export async function SysVote_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysVoteEN.con_VoteId:
return (obj: clsSysVoteEN) => {
return obj.voteId === value;
}
case clsSysVoteEN.con_TableKey:
return (obj: clsSysVoteEN) => {
return obj.tableKey === value;
}
case clsSysVoteEN.con_PubParentId:
return (obj: clsSysVoteEN) => {
return obj.pubParentId === value;
}
case clsSysVoteEN.con_VoteTypeId:
return (obj: clsSysVoteEN) => {
return obj.voteTypeId === value;
}
case clsSysVoteEN.con_LikedUserId:
return (obj: clsSysVoteEN) => {
return obj.likedUserId === value;
}
case clsSysVoteEN.con_UpdUser:
return (obj: clsSysVoteEN) => {
return obj.updUser === value;
}
case clsSysVoteEN.con_UpdDate:
return (obj: clsSysVoteEN) => {
return obj.updDate === value;
}
case clsSysVoteEN.con_Memo:
return (obj: clsSysVoteEN) => {
return obj.memo === value;
}
case clsSysVoteEN.con_id_CurrEduCls:
return (obj: clsSysVoteEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysVote]中不存在！(in ${ sysVote_ConstructorName}.${ strThisFuncName})`;
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
 @param strUpdUser:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function SysVote_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strUpdUser_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strUpdUser_C) == true)
{
  const strMsg = Format("参数:[strUpdUser_C]不能为空！(In clsSysVoteWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName == clsSysVoteEN.con_VoteId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrSysVote = await SysVote_GetObjLst_Cache(strUpdUser_C);
if (arrSysVote == null) return [];
let arrSysVote_Sel = arrSysVote;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrSysVote_Sel = arrSysVote_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrSysVote_Sel.length == 0) return [];
return arrSysVote_Sel.map(x=>x.voteId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysVote_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetFirstObjAsync(strWhereCond: string): Promise<clsSysVoteEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const objSysVote = SysVote_GetObjFromJsonObj(returnObj);
return objSysVote;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLst_ClientCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysVoteEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysVoteEN.WhereFormat, strUpdUser);
}
else
{
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
}
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
if (IsNullOrEmpty(clsSysVoteEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysVoteEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysVoteExObjLst_Cache: Array<clsSysVoteEN> = CacheHelper.Get(strKey);
const arrSysVoteObjLst_T = SysVote_GetObjLstByJSONObjLst(arrSysVoteExObjLst_Cache);
return arrSysVoteObjLst_T;
}
try
{
const arrSysVoteExObjLst = await SysVote_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysVoteExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysVoteExObjLst.length);
console.log(strInfo);
return arrSysVoteExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysVote_GetObjLst_localStorage(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysVoteEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysVoteEN.WhereFormat, strUpdUser);
}
else
{
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
}
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
if (IsNullOrEmpty(clsSysVoteEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysVoteEN.CacheAddiCondition);
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
const arrSysVoteExObjLst_Cache: Array<clsSysVoteEN> = JSON.parse(strTempObjLst);
const arrSysVoteObjLst_T = SysVote_GetObjLstByJSONObjLst(arrSysVoteExObjLst_Cache);
return arrSysVoteObjLst_T;
}
try
{
const arrSysVoteExObjLst = await SysVote_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysVoteExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysVoteExObjLst.length);
console.log(strInfo);
return arrSysVoteExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysVote_GetObjLst_localStorage_PureCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysVoteObjLst_Cache: Array<clsSysVoteEN> = JSON.parse(strTempObjLst);
return arrSysVoteObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysVote_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLst_sessionStorage(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsSysVoteEN.WhereFormat) == false)
{
strWhereCond = Format(clsSysVoteEN.WhereFormat, strUpdUser);
}
else
{
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
}
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
if (IsNullOrEmpty(clsSysVoteEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysVoteEN.CacheAddiCondition);
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
const arrSysVoteExObjLst_Cache: Array<clsSysVoteEN> = JSON.parse(strTempObjLst);
const arrSysVoteObjLst_T = SysVote_GetObjLstByJSONObjLst(arrSysVoteExObjLst_Cache);
return arrSysVoteObjLst_T;
}
try
{
const arrSysVoteExObjLst = await SysVote_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysVoteExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysVoteExObjLst.length);
console.log(strInfo);
return arrSysVoteExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysVote_GetObjLst_sessionStorage_PureCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysVoteObjLst_Cache: Array<clsSysVoteEN> = JSON.parse(strTempObjLst);
return arrSysVoteObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysVote_GetObjLst_Cache(strUpdUser: string): Promise<Array<clsSysVoteEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strUpdUser) == true)
{
const strMsg = Format("缓存分类变量:[UpdUser]不能为空！(in clsSysVoteWApi.SysVote_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
let arrSysVoteObjLst_Cache;
switch (clsSysVoteEN.CacheModeId)
{
case "04"://sessionStorage
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_sessionStorage(strUpdUser);
break;
case "03"://localStorage
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_localStorage(strUpdUser);
break;
case "02"://ClientCache
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_ClientCache(strUpdUser);
break;
default:
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_ClientCache(strUpdUser);
break;
}
const arrSysVoteObjLst = SysVote_GetObjLstByJSONObjLst(arrSysVoteObjLst_Cache);
return arrSysVoteObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysVote_GetObjLst_PureCache(strUpdUser: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysVoteObjLst_Cache;
switch (clsSysVoteEN.CacheModeId)
{
case "04"://sessionStorage
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_sessionStorage_PureCache(strUpdUser);
break;
case "03"://localStorage
arrSysVoteObjLst_Cache = await SysVote_GetObjLst_localStorage_PureCache(strUpdUser);
break;
case "02"://ClientCache
arrSysVoteObjLst_Cache = null;
break;
default:
arrSysVoteObjLst_Cache = null;
break;
}
return arrSysVoteObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngVoteId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysVote_GetSubObjLst_Cache(objSysVote_Cond: clsSysVoteEN,strUpdUser: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
let arrSysVote_Sel: Array < clsSysVoteEN > = arrSysVoteObjLst_Cache;
if (objSysVote_Cond.sf_FldComparisonOp == null || objSysVote_Cond.sf_FldComparisonOp == "") return arrSysVote_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysVote_Cond.sf_FldComparisonOp);
//console.log("clsSysVoteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysVote_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysVote_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysVote_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysVote_Cond), sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysVoteEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrVoteId:关键字列表
 * @returns 对象列表
 **/
export async function SysVote_GetObjLstByVoteIdLstAsync(arrVoteId: Array<string>): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByVoteIdLstAsync";
const strAction = "GetObjLstByVoteIdLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrVoteId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param arrlngVoteIdLst:关键字列表
 * @returns 对象列表
*/
export async function SysVote_GetObjLstByVoteIdLst_Cache(arrVoteIdLst: Array<number>,strUpdUser: string) {
const strThisFuncName = "GetObjLstByVoteIdLst_Cache";
try
{
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
const arrSysVote_Sel: Array <clsSysVoteEN> = arrSysVoteObjLst_Cache.filter(x => arrVoteIdLst.indexOf(x.voteId)>-1);
return arrSysVote_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrVoteIdLst.join(","), sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strUpdUser: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsSysVoteEN>();
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
if (arrSysVoteObjLst_Cache.length == 0) return arrSysVoteObjLst_Cache;
let arrSysVote_Sel = arrSysVoteObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysVote_Cond = new clsSysVoteEN();
ObjectAssign(objSysVote_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysVoteWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysVote_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysVote_Sel = arrSysVote_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysVote_Sel.length == 0) return arrSysVote_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysVote_Sel = arrSysVote_Sel.sort(SysVote_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysVote_Sel = arrSysVote_Sel.sort(objPagerPara.sortFun);
}
arrSysVote_Sel = arrSysVote_Sel.slice(intStart, intEnd);     
return arrSysVote_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysVoteEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysVote_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysVoteEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSysVoteEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysVote_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysVote_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:关键字
 * @returns 获取删除的结果
 **/
export async function SysVote_DelRecordAsync(lngVoteId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysVote_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngVoteId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param arrVoteId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysVote_DelSysVotesAsync(arrVoteId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysVotesAsync";
const strAction = "DelSysVotes";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrVoteId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_DelSysVotesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysVotesByCondAsync";
const strAction = "DelSysVotesByCond";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysVote_AddNewRecordAsync(objSysVoteEN: clsSysVoteEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysVoteEN);
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysVote_AddNewRecordWithReturnKeyAsync(objSysVoteEN: clsSysVoteEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysVote_AddNewRecordWithReturnKey(objSysVoteEN: clsSysVoteEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysVoteEN.voteId === null || objSysVoteEN.voteId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysVote_UpdateRecordAsync(objSysVoteEN: clsSysVoteEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysVoteEN.sfUpdFldSetStr === undefined || objSysVoteEN.sfUpdFldSetStr === null || objSysVoteEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVoteEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysVote_UpdateWithConditionAsync(objSysVoteEN: clsSysVoteEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysVoteEN.sfUpdFldSetStr === undefined || objSysVoteEN.sfUpdFldSetStr === null || objSysVoteEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysVoteEN.voteId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
objSysVoteEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysVoteEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objlngVoteId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysVote_IsExistRecord_Cache(objSysVote_Cond: clsSysVoteEN,strUpdUser: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
if (arrSysVoteObjLst_Cache == null) return false;
let arrSysVote_Sel: Array < clsSysVoteEN > = arrSysVoteObjLst_Cache;
if (objSysVote_Cond.sf_FldComparisonOp == null || objSysVote_Cond.sf_FldComparisonOp == "") return arrSysVote_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysVote_Cond.sf_FldComparisonOp);
//console.log("clsSysVoteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysVote_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysVote_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysVote_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysVote_Cond), sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysVote_IsExist(lngVoteId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"VoteId": lngVoteId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param lngVoteId:所给的关键字
 * @returns 对象
*/
export async function SysVote_IsExist_Cache(lngVoteId:number,strUpdUser:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
if (arrSysVoteObjLst_Cache == null) return false;
try
{
const arrSysVote_Sel: Array <clsSysVoteEN> = arrSysVoteObjLst_Cache.filter(x => x.voteId == lngVoteId);
if (arrSysVote_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngVoteId, sysVote_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngVoteId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysVote_IsExistAsync(lngVoteId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngVoteId": lngVoteId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
 * @param objSysVote_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysVote_GetRecCountByCond_Cache(objSysVote_Cond: clsSysVoteEN,strUpdUser: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysVoteObjLst_Cache = await SysVote_GetObjLst_Cache(strUpdUser);
if (arrSysVoteObjLst_Cache == null) return 0;
let arrSysVote_Sel: Array < clsSysVoteEN > = arrSysVoteObjLst_Cache;
if (objSysVote_Cond.sf_FldComparisonOp == null || objSysVote_Cond.sf_FldComparisonOp == "") return arrSysVote_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysVote_Cond.sf_FldComparisonOp);
//console.log("clsSysVoteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysVote_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysVote_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysVote_Sel = arrSysVote_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysVote_Sel = arrSysVote_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysVote_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysVote_Cond), sysVote_ConstructorName, strThisFuncName);
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
export async function SysVote_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysVote_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysVote_ConstructorName, strThisFuncName);
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
export function SysVote_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysVote_ReFreshCache(strUpdUser: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strUpdUser) == true)
{
  const strMsg = Format("参数:[strUpdUser]不能为空！(In clsSysVoteWApi.clsSysVoteWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
switch (clsSysVoteEN.CacheModeId)
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
export function SysVote_ReFreshThisCache(strUpdUser: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsSysVoteEN._CurrTabName, strUpdUser);
switch (clsSysVoteEN.CacheModeId)
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
export function SysVote_CheckPropertyNew(pobjSysVoteEN: clsSysVoteEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && GetStrLen(pobjSysVoteEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && GetStrLen(pobjSysVoteEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000059)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && GetStrLen(pobjSysVoteEN.voteTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.likedUserId) == false && GetStrLen(pobjSysVoteEN.likedUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[被点赞用户Id(likedUserId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.likedUserId)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && GetStrLen(pobjSysVoteEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && GetStrLen(pobjSysVoteEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && GetStrLen(pobjSysVoteEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && GetStrLen(pobjSysVoteEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && tzDataType.isNumber(pobjSysVoteEN.voteId) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && tzDataType.isString(pobjSysVoteEN.tableKey) === false)
{
 throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && tzDataType.isString(pobjSysVoteEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000060)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && tzDataType.isString(pobjSysVoteEN.voteTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.likedUserId) == false && undefined !== pobjSysVoteEN.likedUserId && tzDataType.isString(pobjSysVoteEN.likedUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[被点赞用户Id(likedUserId)]的值:[$(pobjSysVoteEN.likedUserId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && tzDataType.isString(pobjSysVoteEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && tzDataType.isString(pobjSysVoteEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && tzDataType.isString(pobjSysVoteEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysVoteEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysVote_CheckProperty4Update (pobjSysVoteEN: clsSysVoteEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && GetStrLen(pobjSysVoteEN.tableKey) > 20)
{
 throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.tableKey)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && GetStrLen(pobjSysVoteEN.pubParentId) > 20)
{
 throw new Error("(errid:Watl000062)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.pubParentId)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && GetStrLen(pobjSysVoteEN.voteTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[点赞类型Id(voteTypeId)]的长度不能超过2(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.voteTypeId)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.likedUserId) == false && GetStrLen(pobjSysVoteEN.likedUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[被点赞用户Id(likedUserId)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.likedUserId)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && GetStrLen(pobjSysVoteEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updUser)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && GetStrLen(pobjSysVoteEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.updDate)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && GetStrLen(pobjSysVoteEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.memo)(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && GetStrLen(pobjSysVoteEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统点赞表(SysVote))!值:$(pobjSysVoteEN.id_CurrEduCls)(clsSysVoteBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjSysVoteEN.voteId && undefined !== pobjSysVoteEN.voteId && tzDataType.isNumber(pobjSysVoteEN.voteId) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞Id(voteId)]的值:[$(pobjSysVoteEN.voteId)], 非法，应该为数值型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.tableKey) == false && undefined !== pobjSysVoteEN.tableKey && tzDataType.isString(pobjSysVoteEN.tableKey) === false)
{
 throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysVoteEN.tableKey)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.pubParentId) == false && undefined !== pobjSysVoteEN.pubParentId && tzDataType.isString(pobjSysVoteEN.pubParentId) === false)
{
 throw new Error("(errid:Watl000063)字段[公共父Id(pubParentId)]的值:[$(pobjSysVoteEN.pubParentId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.voteTypeId) == false && undefined !== pobjSysVoteEN.voteTypeId && tzDataType.isString(pobjSysVoteEN.voteTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞类型Id(voteTypeId)]的值:[$(pobjSysVoteEN.voteTypeId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.likedUserId) == false && undefined !== pobjSysVoteEN.likedUserId && tzDataType.isString(pobjSysVoteEN.likedUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[被点赞用户Id(likedUserId)]的值:[$(pobjSysVoteEN.likedUserId)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updUser) == false && undefined !== pobjSysVoteEN.updUser && tzDataType.isString(pobjSysVoteEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysVoteEN.updUser)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.updDate) == false && undefined !== pobjSysVoteEN.updDate && tzDataType.isString(pobjSysVoteEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysVoteEN.updDate)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.memo) == false && undefined !== pobjSysVoteEN.memo && tzDataType.isString(pobjSysVoteEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysVoteEN.memo)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysVoteEN.id_CurrEduCls) == false && undefined !== pobjSysVoteEN.id_CurrEduCls && tzDataType.isString(pobjSysVoteEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysVoteEN.id_CurrEduCls)], 非法，应该为字符型(In 系统点赞表(SysVote))!(clsSysVoteBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSysVoteEN.voteId 
 || pobjSysVoteEN.voteId != null && pobjSysVoteEN.voteId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[点赞Id]不能为空(In 系统点赞表)!(clsSysVoteBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysVoteEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysVote_GetJSONStrByObj (pobjSysVoteEN: clsSysVoteEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysVoteEN.sfUpdFldSetStr = pobjSysVoteEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysVoteEN);
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
export function SysVote_GetObjLstByJSONStr (strJSON: string): Array<clsSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysVoteObjLst = new Array<clsSysVoteEN>();
if (strJSON === "")
{
return arrSysVoteObjLst;
}
try
{
arrSysVoteObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysVoteObjLst;
}
return arrSysVoteObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysVoteObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysVote_GetObjLstByJSONObjLst (arrSysVoteObjLstS: Array<clsSysVoteEN>): Array<clsSysVoteEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysVoteObjLst = new Array<clsSysVoteEN>();
for (const objInFor of arrSysVoteObjLstS) {
const obj1 = SysVote_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysVoteObjLst.push(obj1);
}
return arrSysVoteObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysVote_GetObjByJSONStr (strJSON: string): clsSysVoteEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysVoteEN = new clsSysVoteEN();
if (strJSON === "")
{
return pobjSysVoteEN;
}
try
{
pobjSysVoteEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysVoteEN;
}
return pobjSysVoteEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysVote_GetCombineCondition(objSysVote_Cond: clsSysVoteEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_VoteId) == true)
{
const strComparisonOp_VoteId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_VoteId];
strWhereCond += Format(" And {0} {2} {1}", clsSysVoteEN.con_VoteId, objSysVote_Cond.voteId, strComparisonOp_VoteId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_TableKey) == true)
{
const strComparisonOp_TableKey:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_TableKey];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_TableKey, objSysVote_Cond.tableKey, strComparisonOp_TableKey);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_PubParentId) == true)
{
const strComparisonOp_PubParentId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_PubParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_PubParentId, objSysVote_Cond.pubParentId, strComparisonOp_PubParentId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_VoteTypeId) == true)
{
const strComparisonOp_VoteTypeId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_VoteTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_VoteTypeId, objSysVote_Cond.voteTypeId, strComparisonOp_VoteTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_LikedUserId) == true)
{
const strComparisonOp_LikedUserId:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_LikedUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_LikedUserId, objSysVote_Cond.likedUserId, strComparisonOp_LikedUserId);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_UpdUser, objSysVote_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_UpdDate, objSysVote_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_Memo, objSysVote_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysVote_Cond.dicFldComparisonOp, clsSysVoteEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysVote_Cond.dicFldComparisonOp[clsSysVoteEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysVoteEN.con_id_CurrEduCls, objSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngVoteId: 点赞Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysVote_GetUniCondStr_VoteId(objSysVoteEN: clsSysVoteEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and VoteId = '{0}'", objSysVoteEN.voteId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysVote(系统点赞表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngVoteId: 点赞Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysVote_GetUniCondStr4Update_VoteId(objSysVoteEN: clsSysVoteEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and VoteId <> '{0}'", objSysVoteEN.voteId);
 strWhereCond +=  Format(" and VoteId = '{0}'", objSysVoteEN.voteId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysVoteENS:源对象
 * @param objSysVoteENT:目标对象
*/
export function SysVote_CopyObjTo(objSysVoteENS: clsSysVoteEN , objSysVoteENT: clsSysVoteEN ): void 
{
objSysVoteENT.voteId = objSysVoteENS.voteId; //点赞Id
objSysVoteENT.tableKey = objSysVoteENS.tableKey; //表主键
objSysVoteENT.pubParentId = objSysVoteENS.pubParentId; //公共父Id
objSysVoteENT.voteTypeId = objSysVoteENS.voteTypeId; //点赞类型Id
objSysVoteENT.likedUserId = objSysVoteENS.likedUserId; //被点赞用户Id
objSysVoteENT.updUser = objSysVoteENS.updUser; //修改人
objSysVoteENT.updDate = objSysVoteENS.updDate; //修改日期
objSysVoteENT.memo = objSysVoteENS.memo; //备注
objSysVoteENT.id_CurrEduCls = objSysVoteENS.id_CurrEduCls; //教学班流水号
objSysVoteENT.sfUpdFldSetStr = objSysVoteENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysVoteENS:源对象
 * @param objSysVoteENT:目标对象
*/
export function SysVote_GetObjFromJsonObj(objSysVoteENS: clsSysVoteEN): clsSysVoteEN 
{
 const objSysVoteENT: clsSysVoteEN = new clsSysVoteEN();
ObjectAssign(objSysVoteENT, objSysVoteENS);
 return objSysVoteENT;
}