
 /**
 * 类名:clsTopicUserRoleWApi
 * 表名:TopicUserRole(01120590)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:49
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 主题用户角色(TopicUserRole)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsTopicUserRoleEN } from "../../L0_Entity/ParameterTable/clsTopicUserRoleEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const topicUserRole_Controller = "TopicUserRoleApi";
 export const topicUserRole_ConstructorName = "topicUserRole";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTopicUserRoleId:关键字
 * @returns 对象
 **/
export async function TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId: string): Promise<clsTopicUserRoleEN|null>  
{
const strThisFuncName = "GetObjByTopicUserRoleIdAsync";

if (IsNullOrEmpty(strTopicUserRoleId) == true)
{
  const strMsg = Format("参数:[strTopicUserRoleId]不能为空！(In clsTopicUserRoleWApi.GetObjByTopicUserRoleIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicUserRoleId.length != 4)
{
const strMsg = Format("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！(clsTopicUserRoleWApi.GetObjByTopicUserRoleIdAsync)", strTopicUserRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTopicUserRoleId";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTopicUserRoleId": strTopicUserRoleId,
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
const objTopicUserRole = TopicUserRole_GetObjFromJsonObj(returnObj);
return objTopicUserRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param strTopicUserRoleId:所给的关键字
 * @returns 对象
*/
export async function TopicUserRole_GetObjByTopicUserRoleId_Cache(strTopicUserRoleId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTopicUserRoleId_Cache";

if (IsNullOrEmpty(strTopicUserRoleId) == true)
{
  const strMsg = Format("参数:[strTopicUserRoleId]不能为空！(In clsTopicUserRoleWApi.GetObjByTopicUserRoleId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicUserRoleId.length != 4)
{
const strMsg = Format("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！(clsTopicUserRoleWApi.GetObjByTopicUserRoleId_Cache)", strTopicUserRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
try
{
const arrTopicUserRole_Sel: Array <clsTopicUserRoleEN> = arrTopicUserRoleObjLst_Cache.filter(x => 
 x.topicUserRoleId == strTopicUserRoleId );
let objTopicUserRole: clsTopicUserRoleEN;
if (arrTopicUserRole_Sel.length > 0)
{
objTopicUserRole = arrTopicUserRole_Sel[0];
return objTopicUserRole;
}
else
{
if (bolTryAsyncOnce == true)
{
const objTopicUserRole_Const = await TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId);
if (objTopicUserRole_Const != null)
{
TopicUserRole_ReFreshThisCache();
return objTopicUserRole_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicUserRoleId, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTopicUserRoleId:所给的关键字
 * @returns 对象
*/
export async function TopicUserRole_GetObjByTopicUserRoleId_localStorage(strTopicUserRoleId: string) {
const strThisFuncName = "GetObjByTopicUserRoleId_localStorage";

if (IsNullOrEmpty(strTopicUserRoleId) == true)
{
  const strMsg = Format("参数:[strTopicUserRoleId]不能为空！(In clsTopicUserRoleWApi.GetObjByTopicUserRoleId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicUserRoleId.length != 4)
{
const strMsg = Format("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！(clsTopicUserRoleWApi.GetObjByTopicUserRoleId_localStorage)", strTopicUserRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsTopicUserRoleEN._CurrTabName, strTopicUserRoleId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objTopicUserRole_Cache: clsTopicUserRoleEN = JSON.parse(strTempObj);
return objTopicUserRole_Cache;
}
try
{
const objTopicUserRole = await TopicUserRole_GetObjByTopicUserRoleIdAsync(strTopicUserRoleId);
if (objTopicUserRole != null)
{
localStorage.setItem(strKey, JSON.stringify(objTopicUserRole));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objTopicUserRole;
}
return objTopicUserRole;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicUserRoleId, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objTopicUserRole:所给的对象
 * @returns 对象
*/
export async function TopicUserRole_UpdateObjInLst_Cache(objTopicUserRole: clsTopicUserRoleEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
const obj = arrTopicUserRoleObjLst_Cache.find(x => x.topicUserRoleId == objTopicUserRole.topicUserRoleId);
if (obj != null)
{
objTopicUserRole.topicUserRoleId = obj.topicUserRoleId;
ObjectAssign( obj, objTopicUserRole);
}
else
{
arrTopicUserRoleObjLst_Cache.push(objTopicUserRole);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strTopicUserRoleId:所给的关键字
 * @returns 对象
*/
export async function TopicUserRole_GetNameByTopicUserRoleId_Cache(strTopicUserRoleId: string) {
const strThisFuncName = "GetNameByTopicUserRoleId_Cache";

if (IsNullOrEmpty(strTopicUserRoleId) == true)
{
  const strMsg = Format("参数:[strTopicUserRoleId]不能为空！(In clsTopicUserRoleWApi.GetNameByTopicUserRoleId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicUserRoleId.length != 4)
{
const strMsg = Format("缓存分类变量:[strTopicUserRoleId]的长度:[{0}]不正确！(clsTopicUserRoleWApi.GetNameByTopicUserRoleId_Cache)", strTopicUserRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRoleObjLst_Cache == null) return "";
try
{
const arrTopicUserRole_Sel: Array <clsTopicUserRoleEN> = arrTopicUserRoleObjLst_Cache.filter(x => 
 x.topicUserRoleId == strTopicUserRoleId );
let objTopicUserRole: clsTopicUserRoleEN;
if (arrTopicUserRole_Sel.length > 0)
{
objTopicUserRole = arrTopicUserRole_Sel[0];
return objTopicUserRole.topicUserRoleName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strTopicUserRoleId);
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
export async function TopicUserRole_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsTopicUserRoleEN.con_TopicUserRoleId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsTopicUserRoleEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsTopicUserRoleEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTopicUserRoleId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objTopicUserRole = await TopicUserRole_GetObjByTopicUserRoleId_Cache(strTopicUserRoleId );
if (objTopicUserRole == null) return "";
if (objTopicUserRole.GetFldValue(strOutFldName) == null) return "";
return objTopicUserRole.GetFldValue(strOutFldName).toString();
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
export function TopicUserRole_SortFun_Defa(a:clsTopicUserRoleEN , b:clsTopicUserRoleEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
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
export function TopicUserRole_SortFun_Defa_2Fld(a:clsTopicUserRoleEN , b:clsTopicUserRoleEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicUserRoleName == b.topicUserRoleName) return a.topicUserRoleENName.localeCompare(b.topicUserRoleENName);
else return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
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
export function TopicUserRole_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsTopicUserRoleEN.con_TopicUserRoleId:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return a.topicUserRoleId.localeCompare(b.topicUserRoleId);
}
case clsTopicUserRoleEN.con_TopicUserRoleName:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return a.topicUserRoleName.localeCompare(b.topicUserRoleName);
}
case clsTopicUserRoleEN.con_TopicUserRoleENName:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (a.topicUserRoleENName == null) return -1;
if (b.topicUserRoleENName == null) return 1;
return a.topicUserRoleENName.localeCompare(b.topicUserRoleENName);
}
case clsTopicUserRoleEN.con_UpdUserId:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsTopicUserRoleEN.con_UpdDate:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsTopicUserRoleEN.con_Memo:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${ topicUserRole_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsTopicUserRoleEN.con_TopicUserRoleId:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return b.topicUserRoleId.localeCompare(a.topicUserRoleId);
}
case clsTopicUserRoleEN.con_TopicUserRoleName:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return b.topicUserRoleName.localeCompare(a.topicUserRoleName);
}
case clsTopicUserRoleEN.con_TopicUserRoleENName:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (b.topicUserRoleENName == null) return -1;
if (a.topicUserRoleENName == null) return 1;
return b.topicUserRoleENName.localeCompare(a.topicUserRoleENName);
}
case clsTopicUserRoleEN.con_UpdUserId:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsTopicUserRoleEN.con_UpdDate:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsTopicUserRoleEN.con_Memo:
return (a: clsTopicUserRoleEN, b: clsTopicUserRoleEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${ topicUserRole_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicUserRole_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsTopicUserRoleEN.con_TopicUserRoleId:
return (obj: clsTopicUserRoleEN) => {
return obj.topicUserRoleId === value;
}
case clsTopicUserRoleEN.con_TopicUserRoleName:
return (obj: clsTopicUserRoleEN) => {
return obj.topicUserRoleName === value;
}
case clsTopicUserRoleEN.con_TopicUserRoleENName:
return (obj: clsTopicUserRoleEN) => {
return obj.topicUserRoleENName === value;
}
case clsTopicUserRoleEN.con_UpdUserId:
return (obj: clsTopicUserRoleEN) => {
return obj.updUserId === value;
}
case clsTopicUserRoleEN.con_UpdDate:
return (obj: clsTopicUserRoleEN) => {
return obj.updDate === value;
}
case clsTopicUserRoleEN.con_Memo:
return (obj: clsTopicUserRoleEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TopicUserRole]中不存在！(in ${ topicUserRole_ConstructorName}.${ strThisFuncName})`;
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
export async function TopicUserRole_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsTopicUserRoleEN.con_TopicUserRoleId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrTopicUserRole = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRole == null) return [];
let arrTopicUserRole_Sel = arrTopicUserRole;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrTopicUserRole_Sel.length == 0) return [];
return arrTopicUserRole_Sel.map(x=>x.topicUserRoleId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function TopicUserRole_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetFirstObjAsync(strWhereCond: string): Promise<clsTopicUserRoleEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const objTopicUserRole = TopicUserRole_GetObjFromJsonObj(returnObj);
return objTopicUserRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTopicUserRoleEN._CurrTabName;
if (IsNullOrEmpty(clsTopicUserRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTopicUserRoleEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrTopicUserRoleExObjLst_Cache: Array<clsTopicUserRoleEN> = CacheHelper.Get(strKey);
const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
return arrTopicUserRoleObjLst_T;
}
try
{
const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrTopicUserRoleExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
console.log(strInfo);
return arrTopicUserRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TopicUserRole_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTopicUserRoleEN._CurrTabName;
if (IsNullOrEmpty(clsTopicUserRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTopicUserRoleEN.CacheAddiCondition);
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
const arrTopicUserRoleExObjLst_Cache: Array<clsTopicUserRoleEN> = JSON.parse(strTempObjLst);
const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
return arrTopicUserRoleObjLst_T;
}
try
{
const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrTopicUserRoleExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
console.log(strInfo);
return arrTopicUserRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TopicUserRole_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsTopicUserRoleEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrTopicUserRoleObjLst_Cache: Array<clsTopicUserRoleEN> = JSON.parse(strTempObjLst);
return arrTopicUserRoleObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function TopicUserRole_GetObjLstAsync(strWhereCond: string): Promise<Array<clsTopicUserRoleEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicUserRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTopicUserRoleEN._CurrTabName;
if (IsNullOrEmpty(clsTopicUserRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTopicUserRoleEN.CacheAddiCondition);
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
const arrTopicUserRoleExObjLst_Cache: Array<clsTopicUserRoleEN> = JSON.parse(strTempObjLst);
const arrTopicUserRoleObjLst_T = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleExObjLst_Cache);
return arrTopicUserRoleObjLst_T;
}
try
{
const arrTopicUserRoleExObjLst = await TopicUserRole_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrTopicUserRoleExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTopicUserRoleExObjLst.length);
console.log(strInfo);
return arrTopicUserRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TopicUserRole_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsTopicUserRoleEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrTopicUserRoleObjLst_Cache: Array<clsTopicUserRoleEN> = JSON.parse(strTempObjLst);
return arrTopicUserRoleObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TopicUserRole_GetObjLst_Cache(): Promise<Array<clsTopicUserRoleEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrTopicUserRoleObjLst_Cache;
switch (clsTopicUserRoleEN.CacheModeId)
{
case "04"://sessionStorage
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_ClientCache();
break;
default:
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_ClientCache();
break;
}
const arrTopicUserRoleObjLst = TopicUserRole_GetObjLstByJSONObjLst(arrTopicUserRoleObjLst_Cache);
return arrTopicUserRoleObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TopicUserRole_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrTopicUserRoleObjLst_Cache;
switch (clsTopicUserRoleEN.CacheModeId)
{
case "04"://sessionStorage
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrTopicUserRoleObjLst_Cache = null;
break;
default:
arrTopicUserRoleObjLst_Cache = null;
break;
}
return arrTopicUserRoleObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTopicUserRoleId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function TopicUserRole_GetSubObjLst_Cache(objTopicUserRole_Cond: clsTopicUserRoleEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
let arrTopicUserRole_Sel: Array < clsTopicUserRoleEN > = arrTopicUserRoleObjLst_Cache;
if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "") return arrTopicUserRole_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
//console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTopicUserRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrTopicUserRole_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objTopicUserRole_Cond), topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsTopicUserRoleEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTopicUserRoleId:关键字列表
 * @returns 对象列表
 **/
export async function TopicUserRole_GetObjLstByTopicUserRoleIdLstAsync(arrTopicUserRoleId: Array<string>): Promise<Array<clsTopicUserRoleEN>>  
{
const strThisFuncName = "GetObjLstByTopicUserRoleIdLstAsync";
const strAction = "GetObjLstByTopicUserRoleIdLst";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicUserRoleId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicUserRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param arrstrTopicUserRoleIdLst:关键字列表
 * @returns 对象列表
*/
export async function TopicUserRole_GetObjLstByTopicUserRoleIdLst_Cache(arrTopicUserRoleIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByTopicUserRoleIdLst_Cache";
try
{
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
const arrTopicUserRole_Sel: Array <clsTopicUserRoleEN> = arrTopicUserRoleObjLst_Cache.filter(x => arrTopicUserRoleIdLst.indexOf(x.topicUserRoleId)>-1);
return arrTopicUserRole_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicUserRoleIdLst.join(","), topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsTopicUserRoleEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicUserRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsTopicUserRoleEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicUserRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsTopicUserRoleEN>();
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRoleObjLst_Cache.length == 0) return arrTopicUserRoleObjLst_Cache;
let arrTopicUserRole_Sel = arrTopicUserRoleObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objTopicUserRole_Cond = new clsTopicUserRoleEN();
ObjectAssign(objTopicUserRole_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsTopicUserRoleWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrTopicUserRole_Sel.length == 0) return arrTopicUserRole_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrTopicUserRole_Sel = arrTopicUserRole_Sel.sort(TopicUserRole_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrTopicUserRole_Sel = arrTopicUserRole_Sel.sort(objPagerPara.sortFun);
}
arrTopicUserRole_Sel = arrTopicUserRole_Sel.slice(intStart, intEnd);     
return arrTopicUserRole_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsTopicUserRoleEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function TopicUserRole_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsTopicUserRoleEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsTopicUserRoleEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", topicUserRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TopicUserRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param strTopicUserRoleId:关键字
 * @returns 获取删除的结果
 **/
export async function TopicUserRole_DelRecordAsync(strTopicUserRoleId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strTopicUserRoleId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param arrTopicUserRoleId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function TopicUserRole_DelTopicUserRolesAsync(arrTopicUserRoleId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelTopicUserRolesAsync";
const strAction = "DelTopicUserRoles";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicUserRoleId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_DelTopicUserRolesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelTopicUserRolesByCondAsync";
const strAction = "DelTopicUserRolesByCond";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TopicUserRole_AddNewRecordAsync(objTopicUserRoleEN: clsTopicUserRoleEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objTopicUserRoleEN);
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TopicUserRole_AddNewRecordWithMaxIdAsync(objTopicUserRoleEN: clsTopicUserRoleEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function TopicUserRole_AddNewRecordWithReturnKeyAsync(objTopicUserRoleEN: clsTopicUserRoleEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function TopicUserRole_AddNewRecordWithReturnKey(objTopicUserRoleEN: clsTopicUserRoleEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objTopicUserRoleEN.topicUserRoleId === null || objTopicUserRoleEN.topicUserRoleId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function TopicUserRole_UpdateRecordAsync(objTopicUserRoleEN: clsTopicUserRoleEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objTopicUserRoleEN.sfUpdFldSetStr === undefined || objTopicUserRoleEN.sfUpdFldSetStr === null || objTopicUserRoleEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicUserRoleEN.topicUserRoleId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRoleEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function TopicUserRole_UpdateWithConditionAsync(objTopicUserRoleEN: clsTopicUserRoleEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objTopicUserRoleEN.sfUpdFldSetStr === undefined || objTopicUserRoleEN.sfUpdFldSetStr === null || objTopicUserRoleEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTopicUserRoleEN.topicUserRoleId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
objTopicUserRoleEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objTopicUserRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objstrTopicUserRoleId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function TopicUserRole_IsExistRecord_Cache(objTopicUserRole_Cond: clsTopicUserRoleEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRoleObjLst_Cache == null) return false;
let arrTopicUserRole_Sel: Array < clsTopicUserRoleEN > = arrTopicUserRoleObjLst_Cache;
if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "") return arrTopicUserRole_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
//console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTopicUserRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrTopicUserRole_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objTopicUserRole_Cond), topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param strTopicUserRoleId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function TopicUserRole_IsExist(strTopicUserRoleId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TopicUserRoleId": strTopicUserRoleId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param strTopicUserRoleId:所给的关键字
 * @returns 对象
*/
export async function TopicUserRole_IsExist_Cache(strTopicUserRoleId:string) {
const strThisFuncName = "IsExist_Cache";
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRoleObjLst_Cache == null) return false;
try
{
const arrTopicUserRole_Sel: Array <clsTopicUserRoleEN> = arrTopicUserRoleObjLst_Cache.filter(x => x.topicUserRoleId == strTopicUserRoleId);
if (arrTopicUserRole_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicUserRoleId, topicUserRole_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTopicUserRoleId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function TopicUserRole_IsExistAsync(strTopicUserRoleId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTopicUserRoleId": strTopicUserRoleId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
 * @param objTopicUserRole_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function TopicUserRole_GetRecCountByCond_Cache(objTopicUserRole_Cond: clsTopicUserRoleEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrTopicUserRoleObjLst_Cache = await TopicUserRole_GetObjLst_Cache();
if (arrTopicUserRoleObjLst_Cache == null) return 0;
let arrTopicUserRole_Sel: Array < clsTopicUserRoleEN > = arrTopicUserRoleObjLst_Cache;
if (objTopicUserRole_Cond.sf_FldComparisonOp == null || objTopicUserRole_Cond.sf_FldComparisonOp == "") return arrTopicUserRole_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTopicUserRole_Cond.sf_FldComparisonOp);
//console.log("clsTopicUserRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTopicUserRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTopicUserRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTopicUserRole_Sel = arrTopicUserRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrTopicUserRole_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objTopicUserRole_Cond), topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export async function TopicUserRole_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(topicUserRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, topicUserRole_ConstructorName, strThisFuncName);
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
export function TopicUserRole_GetWebApiUrl(strController: string, strAction: string): string {
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
export function TopicUserRole_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsTopicUserRoleEN._CurrTabName;
switch (clsTopicUserRoleEN.CacheModeId)
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
export function TopicUserRole_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsTopicUserRoleEN._CurrTabName;
switch (clsTopicUserRoleEN.CacheModeId)
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
export async function TopicUserRole__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await TopicUserRole_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsTopicUserRoleEN.con_TopicUserRoleId, clsTopicUserRoleEN.con_TopicUserRoleName, "主题用户角色");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TopicUserRole_CheckPropertyNew(pobjTopicUserRoleEN: clsTopicUserRoleEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleName) === true )
{
 throw new Error("(errid:Watl000058)字段[主题用户角色]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updUserId) === true )
{
 throw new Error("(errid:Watl000058)字段[修改用户Id]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleId) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleId) > 4)
{
 throw new Error("(errid:Watl000059)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleId)(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleName) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleName) > 100)
{
 throw new Error("(errid:Watl000059)字段[主题用户角色(topicUserRoleName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleName)(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleENName) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleENName) > 100)
{
 throw new Error("(errid:Watl000059)字段[主题用户角色英文名(topicUserRoleENName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleENName)(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updUserId) == false && GetStrLen(pobjTopicUserRoleEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updUserId)(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updDate) == false && GetStrLen(pobjTopicUserRoleEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updDate)(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.memo) == false && GetStrLen(pobjTopicUserRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.memo)(clsTopicUserRoleBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleId) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleId && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleId) === false)
{
 throw new Error("(errid:Watl000060)字段[主键Id(topicUserRoleId)]的值:[$(pobjTopicUserRoleEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleName && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleName) === false)
{
 throw new Error("(errid:Watl000060)字段[主题用户角色(topicUserRoleName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleENName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleENName && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleENName) === false)
{
 throw new Error("(errid:Watl000060)字段[主题用户角色英文名(topicUserRoleENName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleENName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updUserId) == false && undefined !== pobjTopicUserRoleEN.updUserId && tzDataType.isString(pobjTopicUserRoleEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjTopicUserRoleEN.updUserId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updDate) == false && undefined !== pobjTopicUserRoleEN.updDate && tzDataType.isString(pobjTopicUserRoleEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjTopicUserRoleEN.updDate)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.memo) == false && undefined !== pobjTopicUserRoleEN.memo && tzDataType.isString(pobjTopicUserRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTopicUserRoleEN.memo)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTopicUserRoleEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TopicUserRole_CheckProperty4Update (pobjTopicUserRoleEN: clsTopicUserRoleEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleId) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleId) > 4)
{
 throw new Error("(errid:Watl000062)字段[主键Id(topicUserRoleId)]的长度不能超过4(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleId)(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleName) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleName) > 100)
{
 throw new Error("(errid:Watl000062)字段[主题用户角色(topicUserRoleName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleName)(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleENName) == false && GetStrLen(pobjTopicUserRoleEN.topicUserRoleENName) > 100)
{
 throw new Error("(errid:Watl000062)字段[主题用户角色英文名(topicUserRoleENName)]的长度不能超过100(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.topicUserRoleENName)(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updUserId) == false && GetStrLen(pobjTopicUserRoleEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updUserId)(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updDate) == false && GetStrLen(pobjTopicUserRoleEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.updDate)(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.memo) == false && GetStrLen(pobjTopicUserRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题用户角色(TopicUserRole))!值:$(pobjTopicUserRoleEN.memo)(clsTopicUserRoleBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleId) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleId && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleId) === false)
{
 throw new Error("(errid:Watl000063)字段[主键Id(topicUserRoleId)]的值:[$(pobjTopicUserRoleEN.topicUserRoleId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleName && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleName) === false)
{
 throw new Error("(errid:Watl000063)字段[主题用户角色(topicUserRoleName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleENName) == false && undefined !== pobjTopicUserRoleEN.topicUserRoleENName && tzDataType.isString(pobjTopicUserRoleEN.topicUserRoleENName) === false)
{
 throw new Error("(errid:Watl000063)字段[主题用户角色英文名(topicUserRoleENName)]的值:[$(pobjTopicUserRoleEN.topicUserRoleENName)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updUserId) == false && undefined !== pobjTopicUserRoleEN.updUserId && tzDataType.isString(pobjTopicUserRoleEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjTopicUserRoleEN.updUserId)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.updDate) == false && undefined !== pobjTopicUserRoleEN.updDate && tzDataType.isString(pobjTopicUserRoleEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjTopicUserRoleEN.updDate)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTopicUserRoleEN.memo) == false && undefined !== pobjTopicUserRoleEN.memo && tzDataType.isString(pobjTopicUserRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTopicUserRoleEN.memo)], 非法，应该为字符型(In 主题用户角色(TopicUserRole))!(clsTopicUserRoleBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjTopicUserRoleEN.topicUserRoleId) === true )
{
 throw new Error("(errid:Watl000064)字段[主键Id]不能为空(In 主题用户角色)!(clsTopicUserRoleBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjTopicUserRoleEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicUserRole_GetJSONStrByObj (pobjTopicUserRoleEN: clsTopicUserRoleEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjTopicUserRoleEN.sfUpdFldSetStr = pobjTopicUserRoleEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjTopicUserRoleEN);
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
export function TopicUserRole_GetObjLstByJSONStr (strJSON: string): Array<clsTopicUserRoleEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrTopicUserRoleObjLst = new Array<clsTopicUserRoleEN>();
if (strJSON === "")
{
return arrTopicUserRoleObjLst;
}
try
{
arrTopicUserRoleObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTopicUserRoleObjLst;
}
return arrTopicUserRoleObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrTopicUserRoleObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function TopicUserRole_GetObjLstByJSONObjLst (arrTopicUserRoleObjLstS: Array<clsTopicUserRoleEN>): Array<clsTopicUserRoleEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrTopicUserRoleObjLst = new Array<clsTopicUserRoleEN>();
for (const objInFor of arrTopicUserRoleObjLstS) {
const obj1 = TopicUserRole_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrTopicUserRoleObjLst.push(obj1);
}
return arrTopicUserRoleObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TopicUserRole_GetObjByJSONStr (strJSON: string): clsTopicUserRoleEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjTopicUserRoleEN = new clsTopicUserRoleEN();
if (strJSON === "")
{
return pobjTopicUserRoleEN;
}
try
{
pobjTopicUserRoleEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTopicUserRoleEN;
}
return pobjTopicUserRoleEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function TopicUserRole_GetCombineCondition(objTopicUserRole_Cond: clsTopicUserRoleEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_TopicUserRoleId) == true)
{
const strComparisonOp_TopicUserRoleId:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_TopicUserRoleId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_TopicUserRoleId, objTopicUserRole_Cond.topicUserRoleId, strComparisonOp_TopicUserRoleId);
}
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_TopicUserRoleName) == true)
{
const strComparisonOp_TopicUserRoleName:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_TopicUserRoleName];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_TopicUserRoleName, objTopicUserRole_Cond.topicUserRoleName, strComparisonOp_TopicUserRoleName);
}
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_TopicUserRoleENName) == true)
{
const strComparisonOp_TopicUserRoleENName:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_TopicUserRoleENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_TopicUserRoleENName, objTopicUserRole_Cond.topicUserRoleENName, strComparisonOp_TopicUserRoleENName);
}
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_UpdUserId, objTopicUserRole_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_UpdDate, objTopicUserRole_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objTopicUserRole_Cond.dicFldComparisonOp, clsTopicUserRoleEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objTopicUserRole_Cond.dicFldComparisonOp[clsTopicUserRoleEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTopicUserRoleEN.con_Memo, objTopicUserRole_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicUserRole(主题用户角色),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicUserRoleId: 主键Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicUserRole_GetUniCondStr_TopicUserRoleId(objTopicUserRoleEN: clsTopicUserRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicUserRoleId = '{0}'", objTopicUserRoleEN.topicUserRoleId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TopicUserRole(主题用户角色),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicUserRoleId: 主键Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TopicUserRole_GetUniCondStr4Update_TopicUserRoleId(objTopicUserRoleEN: clsTopicUserRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TopicUserRoleId <> '{0}'", objTopicUserRoleEN.topicUserRoleId);
 strWhereCond +=  Format(" and TopicUserRoleId = '{0}'", objTopicUserRoleEN.topicUserRoleId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objTopicUserRoleENS:源对象
 * @param objTopicUserRoleENT:目标对象
*/
export function TopicUserRole_CopyObjTo(objTopicUserRoleENS: clsTopicUserRoleEN , objTopicUserRoleENT: clsTopicUserRoleEN ): void 
{
objTopicUserRoleENT.topicUserRoleId = objTopicUserRoleENS.topicUserRoleId; //主键Id
objTopicUserRoleENT.topicUserRoleName = objTopicUserRoleENS.topicUserRoleName; //主题用户角色
objTopicUserRoleENT.topicUserRoleENName = objTopicUserRoleENS.topicUserRoleENName; //主题用户角色英文名
objTopicUserRoleENT.updUserId = objTopicUserRoleENS.updUserId; //修改用户Id
objTopicUserRoleENT.updDate = objTopicUserRoleENS.updDate; //修改日期
objTopicUserRoleENT.memo = objTopicUserRoleENS.memo; //备注
objTopicUserRoleENT.sfUpdFldSetStr = objTopicUserRoleENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objTopicUserRoleENS:源对象
 * @param objTopicUserRoleENT:目标对象
*/
export function TopicUserRole_GetObjFromJsonObj(objTopicUserRoleENS: clsTopicUserRoleEN): clsTopicUserRoleEN 
{
 const objTopicUserRoleENT: clsTopicUserRoleEN = new clsTopicUserRoleEN();
ObjectAssign(objTopicUserRoleENT, objTopicUserRoleENS);
 return objTopicUserRoleENT;
}