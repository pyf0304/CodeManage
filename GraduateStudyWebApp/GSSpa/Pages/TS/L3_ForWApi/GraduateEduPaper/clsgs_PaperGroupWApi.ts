
 /**
 * 类名:clsgs_PaperGroupWApi
 * 表名:gs_PaperGroup(01120749)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:42
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
 * 论文分组(gs_PaperGroup)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_PaperGroupEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperGroup_Controller = "gs_PaperGroupApi";
 export const gs_PaperGroup_ConstructorName = "gs_PaperGroup";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPaperGroupId:关键字
 * @returns 对象
 **/
export async function gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId: string): Promise<clsgs_PaperGroupEN>  
{
const strThisFuncName = "GetObjByPaperGroupIdAsync";

if (IsNullOrEmpty(strPaperGroupId) == true)
{
  const strMsg = Format("参数:[strPaperGroupId]不能为空！(In GetObjByPaperGroupIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperGroupId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperGroupId]的长度:[{0}]不正确！", strPaperGroupId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPaperGroupId";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strPaperGroupId": strPaperGroupId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperGroup = gs_PaperGroup_GetObjFromJsonObj(returnObj);
return objgs_PaperGroup;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param strPaperGroupId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperGroup_GetObjByPaperGroupId_Cache(strPaperGroupId:string,strUpdUser:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperGroupId_Cache";

if (IsNullOrEmpty(strPaperGroupId) == true)
{
  const strMsg = Format("参数:[strPaperGroupId]不能为空！(In GetObjByPaperGroupId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperGroupId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperGroupId]的长度:[{0}]不正确！", strPaperGroupId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
try
{
const arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.paperGroupId == strPaperGroupId);
let objgs_PaperGroup: clsgs_PaperGroupEN;
if (arrgs_PaperGroup_Sel.length > 0)
{
objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
return objgs_PaperGroup;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_PaperGroup = await gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId);
if (objgs_PaperGroup != null)
{
gs_PaperGroup_ReFreshThisCache(strUpdUser);
return objgs_PaperGroup;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperGroupId, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strPaperGroupId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperGroup_GetObjByPaperGroupId_localStorage(strPaperGroupId: string) {
const strThisFuncName = "GetObjByPaperGroupId_localStorage";

if (IsNullOrEmpty(strPaperGroupId) == true)
{
  const strMsg = Format("参数:[strPaperGroupId]不能为空！(In GetObjByPaperGroupId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperGroupId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperGroupId]的长度:[{0}]不正确！", strPaperGroupId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strPaperGroupId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_PaperGroup_Cache: clsgs_PaperGroupEN = JSON.parse(strTempObj);
return objgs_PaperGroup_Cache;
}
try
{
const objgs_PaperGroup = await gs_PaperGroup_GetObjByPaperGroupIdAsync(strPaperGroupId);
if (objgs_PaperGroup != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_PaperGroup));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_PaperGroup;
}
return objgs_PaperGroup;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperGroupId, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_PaperGroup:所给的对象
 * @returns 对象
*/
export async function gs_PaperGroup_UpdateObjInLst_Cache(objgs_PaperGroup: clsgs_PaperGroupEN,strUpdUser: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
const obj = arrgs_PaperGroupObjLst_Cache.find(x => x.paperGroupName == objgs_PaperGroup.paperGroupName && x.updUser == objgs_PaperGroup.updUser);
if (obj != null)
{
objgs_PaperGroup.paperGroupId = obj.paperGroupId;
ObjectAssign( obj, objgs_PaperGroup);
}
else
{
arrgs_PaperGroupObjLst_Cache.push(objgs_PaperGroup);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strPaperGroupId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperGroup_GetNameByPaperGroupId_Cache(strPaperGroupId: string,strUpdUser: string) {
const strThisFuncName = "GetNameByPaperGroupId_Cache";

if (IsNullOrEmpty(strPaperGroupId) == true)
{
  const strMsg = Format("参数:[strPaperGroupId]不能为空！(In GetNameByPaperGroupId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperGroupId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperGroupId]的长度:[{0}]不正确！", strPaperGroupId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrgs_PaperGroupObjLst_Cache == null) return "";
try
{
const arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.paperGroupId == strPaperGroupId);
let objgs_PaperGroup: clsgs_PaperGroupEN;
if (arrgs_PaperGroup_Sel.length > 0)
{
objgs_PaperGroup = arrgs_PaperGroup_Sel[0];
return objgs_PaperGroup.paperGroupName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPaperGroupId);
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
 @param strUpdUser:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function gs_PaperGroup_func(strInFldName:string , strOutFldName:string , strInValue:string , strUpdUser_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strUpdUser_C) == true)
{
  const strMsg = Format("参数:[strUpdUser_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}

if (strInFldName != clsgs_PaperGroupEN.con_PaperGroupId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_PaperGroupEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_PaperGroupEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPaperGroupId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_PaperGroup = await gs_PaperGroup_GetObjByPaperGroupId_Cache(strPaperGroupId , strUpdUser_C);
if (objgs_PaperGroup == null) return "";
return objgs_PaperGroup.GetFldValue(strOutFldName).toString();
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
export function gs_PaperGroup_SortFun_Defa(a:clsgs_PaperGroupEN , b:clsgs_PaperGroupEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperGroupId.localeCompare(b.paperGroupId);
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
export function gs_PaperGroup_SortFun_Defa_2Fld(a:clsgs_PaperGroupEN , b:clsgs_PaperGroupEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperGroupName == b.paperGroupName) return a.updUser.localeCompare(b.updUser);
else return a.paperGroupName.localeCompare(b.paperGroupName);
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
export function gs_PaperGroup_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperGroupEN.con_PaperGroupId:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.paperGroupId.localeCompare(b.paperGroupId);
}
case clsgs_PaperGroupEN.con_PaperGroupName:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.paperGroupName.localeCompare(b.paperGroupName);
}
case clsgs_PaperGroupEN.con_UpdUser:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperGroupEN.con_OrderNum:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.orderNum-b.orderNum;
}
case clsgs_PaperGroupEN.con_UpdDate:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperGroupEN.con_Meno:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return a.meno.localeCompare(b.meno);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperGroup]中不存在！(in ${ gs_PaperGroup_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperGroupEN.con_PaperGroupId:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.paperGroupId.localeCompare(a.paperGroupId);
}
case clsgs_PaperGroupEN.con_PaperGroupName:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.paperGroupName.localeCompare(a.paperGroupName);
}
case clsgs_PaperGroupEN.con_UpdUser:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperGroupEN.con_OrderNum:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.orderNum-a.orderNum;
}
case clsgs_PaperGroupEN.con_UpdDate:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperGroupEN.con_Meno:
return (a: clsgs_PaperGroupEN, b: clsgs_PaperGroupEN) => {
return b.meno.localeCompare(a.meno);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperGroup]中不存在！(in ${ gs_PaperGroup_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperGroup_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperGroupEN.con_PaperGroupId:
return (obj: clsgs_PaperGroupEN) => {
return obj.paperGroupId === value;
}
case clsgs_PaperGroupEN.con_PaperGroupName:
return (obj: clsgs_PaperGroupEN) => {
return obj.paperGroupName === value;
}
case clsgs_PaperGroupEN.con_UpdUser:
return (obj: clsgs_PaperGroupEN) => {
return obj.updUser === value;
}
case clsgs_PaperGroupEN.con_OrderNum:
return (obj: clsgs_PaperGroupEN) => {
return obj.orderNum === value;
}
case clsgs_PaperGroupEN.con_UpdDate:
return (obj: clsgs_PaperGroupEN) => {
return obj.updDate === value;
}
case clsgs_PaperGroupEN.con_Meno:
return (obj: clsgs_PaperGroupEN) => {
return obj.meno === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperGroup]中不存在！(in ${ gs_PaperGroup_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperGroup_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperGroupEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperGroup = gs_PaperGroup_GetObjFromJsonObj(returnObj);
return objgs_PaperGroup;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetObjLst_ClientCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
clsgs_PaperGroupEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperGroupEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperGroupEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperGroupEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_PaperGroupExObjLst_Cache: Array<clsgs_PaperGroupEN> = CacheHelper.Get(strKey);
const arrgs_PaperGroupObjLst_T = gs_PaperGroup_GetObjLstByJSONObjLst(arrgs_PaperGroupExObjLst_Cache);
return arrgs_PaperGroupObjLst_T;
}
try
{
const arrgs_PaperGroupExObjLst = await gs_PaperGroup_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_PaperGroupExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperGroupExObjLst.length);
console.log(strInfo);
return arrgs_PaperGroupExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperGroup_GetObjLst_localStorage(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
clsgs_PaperGroupEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperGroupEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperGroupEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperGroupEN.CacheAddiCondition);
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
const arrgs_PaperGroupExObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
const arrgs_PaperGroupObjLst_T = gs_PaperGroup_GetObjLstByJSONObjLst(arrgs_PaperGroupExObjLst_Cache);
return arrgs_PaperGroupObjLst_T;
}
try
{
const arrgs_PaperGroupExObjLst = await gs_PaperGroup_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperGroupExObjLst.length);
console.log(strInfo);
return arrgs_PaperGroupExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperGroup_GetObjLst_localStorage_PureCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
return arrgs_PaperGroupObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperGroup_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperGroupEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetObjLst_sessionStorage(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
clsgs_PaperGroupEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_PaperGroupEN._CurrTabName);
if (IsNullOrEmpty(clsgs_PaperGroupEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_PaperGroupEN.CacheAddiCondition);
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
const arrgs_PaperGroupExObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
const arrgs_PaperGroupObjLst_T = gs_PaperGroup_GetObjLstByJSONObjLst(arrgs_PaperGroupExObjLst_Cache);
return arrgs_PaperGroupObjLst_T;
}
try
{
const arrgs_PaperGroupExObjLst = await gs_PaperGroup_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperGroupExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperGroupExObjLst.length);
console.log(strInfo);
return arrgs_PaperGroupExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperGroup_GetObjLst_sessionStorage_PureCache(strUpdUser: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("UpdUser='{0}'", strUpdUser);
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_PaperGroupObjLst_Cache: Array<clsgs_PaperGroupEN> = JSON.parse(strTempObjLst);
return arrgs_PaperGroupObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperGroup_GetObjLst_Cache(strUpdUser: string): Promise<Array<clsgs_PaperGroupEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strUpdUser) == true)
{
const strMsg = Format("缓存分类变量:[UpdUser]不能为空！");
console.error(strMsg);
throw (strMsg);
}
let arrgs_PaperGroupObjLst_Cache;
switch (clsgs_PaperGroupEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_sessionStorage(strUpdUser);
break;
case "03"://localStorage
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_localStorage(strUpdUser);
break;
case "02"://ClientCache
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_ClientCache(strUpdUser);
break;
default:
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_ClientCache(strUpdUser);
break;
}
const arrgs_PaperGroupObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(arrgs_PaperGroupObjLst_Cache);
return arrgs_PaperGroupObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_PaperGroup_GetObjLst_PureCache(strUpdUser: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_PaperGroupObjLst_Cache;
switch (clsgs_PaperGroupEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_sessionStorage_PureCache(strUpdUser);
break;
case "03"://localStorage
arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_localStorage_PureCache(strUpdUser);
break;
case "02"://ClientCache
arrgs_PaperGroupObjLst_Cache = null;
break;
default:
arrgs_PaperGroupObjLst_Cache = null;
break;
}
return arrgs_PaperGroupObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPaperGroupId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperGroup_GetSubObjLst_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN,strUpdUser: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
let arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache;
if (objgs_PaperGroup_Cond.sf_FldComparisonOp == null || objgs_PaperGroup_Cond.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperGroup_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperGroup_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperGroup_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperGroup_Cond), gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperGroupId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperGroup_GetObjLstByPaperGroupIdLstAsync(arrPaperGroupId: Array<string>): Promise<Array<clsgs_PaperGroupEN>>  
{
const strThisFuncName = "GetObjLstByPaperGroupIdLstAsync";
const strAction = "GetObjLstByPaperGroupIdLst";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperGroupId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param arrstrPaperGroupIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_PaperGroup_GetObjLstByPaperGroupIdLst_Cache(arrPaperGroupIdLst: Array<string>,strUpdUser: string) {
const strThisFuncName = "GetObjLstByPaperGroupIdLst_Cache";
try
{
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
const arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => arrPaperGroupIdLst.indexOf(x.paperGroupId)>-1);
return arrgs_PaperGroup_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperGroupIdLst.join(","), gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperGroup_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperGroupEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperGroupEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strUpdUser: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrgs_PaperGroupObjLst_Cache.length == 0) return arrgs_PaperGroupObjLst_Cache;
let arrgs_PaperGroup_Sel = arrgs_PaperGroupObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_PaperGroup_Cond = new clsgs_PaperGroupEN();
ObjectAssign(objgs_PaperGroup_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_PaperGroupWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperGroup_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperGroup_Sel.length == 0) return arrgs_PaperGroup_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(gs_PaperGroup_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.sort(objPagerPara.sortFun);
}
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.slice(intStart, intEnd);     
return arrgs_PaperGroup_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_PaperGroupEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_PaperGroup_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperGroupEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperGroup_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param strPaperGroupId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperGroup_DelRecordAsync(strPaperGroupId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strPaperGroupId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strPaperGroupId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param arrPaperGroupId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperGroup_Delgs_PaperGroupsAsync(arrPaperGroupId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperGroupsAsync";
const strAction = "Delgs_PaperGroups";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperGroupId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_Delgs_PaperGroupsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperGroupsByCondAsync";
const strAction = "Delgs_PaperGroupsByCond";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_AddNewRecordAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperGroupEN);
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_AddNewRecordWithMaxIdAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperGroupEN);
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperGroupEN);
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_PaperGroupEN);
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperGroup_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objgs_PaperGroupEN);
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperGroup_AddNewRecordWithReturnKeyAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperGroup_AddNewRecordWithReturnKey(objgs_PaperGroupEN: clsgs_PaperGroupEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperGroupEN.paperGroupId === null || objgs_PaperGroupEN.paperGroupId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperGroup_UpdateRecordAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperGroupEN.sf_UpdFldSetStr === undefined || objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperGroupEN.paperGroupId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroupEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperGroup_UpdateWithConditionAsync(objgs_PaperGroupEN: clsgs_PaperGroupEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperGroupEN.sf_UpdFldSetStr === undefined || objgs_PaperGroupEN.sf_UpdFldSetStr === null || objgs_PaperGroupEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperGroupEN.paperGroupId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
objgs_PaperGroupEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperGroupEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objstrPaperGroupId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_PaperGroup_IsExistRecord_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN,strUpdUser: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrgs_PaperGroupObjLst_Cache == null) return false;
let arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache;
if (objgs_PaperGroup_Cond.sf_FldComparisonOp == null || objgs_PaperGroup_Cond.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperGroup_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperGroup_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_PaperGroup_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_PaperGroup_Cond), gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param strPaperGroupId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_PaperGroup_IsExist(strPaperGroupId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperGroupId": strPaperGroupId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param strPaperGroupId:所给的关键字
 * @returns 对象
*/
export async function gs_PaperGroup_IsExist_Cache(strPaperGroupId:string,strUpdUser:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrgs_PaperGroupObjLst_Cache == null) return false;
try
{
const arrgs_PaperGroup_Sel: Array <clsgs_PaperGroupEN> = arrgs_PaperGroupObjLst_Cache.filter(x => x.paperGroupId == strPaperGroupId);
if (arrgs_PaperGroup_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperGroupId, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strPaperGroupId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_PaperGroup_IsExistAsync(strPaperGroupId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPaperGroupId": strPaperGroupId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperGroup_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_PaperGroup_GetRecCountByCond_Cache(objgs_PaperGroup_Cond: clsgs_PaperGroupEN,strUpdUser: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_PaperGroupObjLst_Cache = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrgs_PaperGroupObjLst_Cache == null) return 0;
let arrgs_PaperGroup_Sel: Array < clsgs_PaperGroupEN > = arrgs_PaperGroupObjLst_Cache;
if (objgs_PaperGroup_Cond.sf_FldComparisonOp == null || objgs_PaperGroup_Cond.sf_FldComparisonOp == "") return arrgs_PaperGroup_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_PaperGroup_Cond.sf_FldComparisonOp);
//console.log("clsgs_PaperGroupWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_PaperGroup_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_PaperGroup_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_PaperGroup_Sel = arrgs_PaperGroup_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_PaperGroup_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_PaperGroup_Cond), gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export async function gs_PaperGroup_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperGroup_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperGroup_ConstructorName, strThisFuncName);
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
export function gs_PaperGroup_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperGroup_ReFreshCache(strUpdUser: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strUpdUser) == true)
{
  const strMsg = Format("参数:[strUpdUser]不能为空！(In clsgs_PaperGroupWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
switch (clsgs_PaperGroupEN.CacheModeId)
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
export function gs_PaperGroup_ReFreshThisCache(strUpdUser: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName, strUpdUser);
switch (clsgs_PaperGroupEN.CacheModeId)
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
export async function gs_PaperGroup__Cache(strDivName: string, strDdlName: string , strUpdUser: string)
{
const strThisFuncName = "_Cache";

if (IsNullOrEmpty(strUpdUser) == true)
{
  const strMsg = Format("参数:[strUpdUser]不能为空！(In )");
console.error(strMsg);
 throw (strMsg);
}

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
const arrObjLst_Sel = await gs_PaperGroup_GetObjLst_Cache(strUpdUser);
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsgs_PaperGroupEN.con_PaperGroupId, clsgs_PaperGroupEN.con_PaperGroupName, "论文分组");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperGroup_CheckPropertyNew(pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文分组)!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupId) == false && GetStrLen(pobjgs_PaperGroupEN.paperGroupId) > 8)
{
 throw new Error("(errid:Watl000059)字段[组Id(paperGroupId)]的长度不能超过8(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.paperGroupId)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupName) == false && GetStrLen(pobjgs_PaperGroupEN.paperGroupName) > 50)
{
 throw new Error("(errid:Watl000059)字段[组名(paperGroupName)]的长度不能超过50(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.paperGroupName)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updUser) == false && GetStrLen(pobjgs_PaperGroupEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.updUser)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updDate) == false && GetStrLen(pobjgs_PaperGroupEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.updDate)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.meno) == false && GetStrLen(pobjgs_PaperGroupEN.meno) > 2000)
{
 throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.meno)(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupId) == false && undefined !== pobjgs_PaperGroupEN.paperGroupId && tzDataType.isString(pobjgs_PaperGroupEN.paperGroupId) === false)
{
 throw new Error("(errid:Watl000060)字段[组Id(paperGroupId)]的值:[$(pobjgs_PaperGroupEN.paperGroupId)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupName) == false && undefined !== pobjgs_PaperGroupEN.paperGroupName && tzDataType.isString(pobjgs_PaperGroupEN.paperGroupName) === false)
{
 throw new Error("(errid:Watl000060)字段[组名(paperGroupName)]的值:[$(pobjgs_PaperGroupEN.paperGroupName)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updUser) == false && undefined !== pobjgs_PaperGroupEN.updUser && tzDataType.isString(pobjgs_PaperGroupEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperGroupEN.updUser)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperGroupEN.orderNum && undefined !== pobjgs_PaperGroupEN.orderNum && tzDataType.isNumber(pobjgs_PaperGroupEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_PaperGroupEN.orderNum)], 非法，应该为数值型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updDate) == false && undefined !== pobjgs_PaperGroupEN.updDate && tzDataType.isString(pobjgs_PaperGroupEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperGroupEN.updDate)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.meno) == false && undefined !== pobjgs_PaperGroupEN.meno && tzDataType.isString(pobjgs_PaperGroupEN.meno) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjgs_PaperGroupEN.meno)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperGroupEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperGroup_CheckProperty4Update (pobjgs_PaperGroupEN: clsgs_PaperGroupEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupId) == false && GetStrLen(pobjgs_PaperGroupEN.paperGroupId) > 8)
{
 throw new Error("(errid:Watl000062)字段[组Id(paperGroupId)]的长度不能超过8(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.paperGroupId)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupName) == false && GetStrLen(pobjgs_PaperGroupEN.paperGroupName) > 50)
{
 throw new Error("(errid:Watl000062)字段[组名(paperGroupName)]的长度不能超过50(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.paperGroupName)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updUser) == false && GetStrLen(pobjgs_PaperGroupEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.updUser)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updDate) == false && GetStrLen(pobjgs_PaperGroupEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.updDate)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.meno) == false && GetStrLen(pobjgs_PaperGroupEN.meno) > 2000)
{
 throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 论文分组(gs_PaperGroup))!值:$(pobjgs_PaperGroupEN.meno)(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupId) == false && undefined !== pobjgs_PaperGroupEN.paperGroupId && tzDataType.isString(pobjgs_PaperGroupEN.paperGroupId) === false)
{
 throw new Error("(errid:Watl000063)字段[组Id(paperGroupId)]的值:[$(pobjgs_PaperGroupEN.paperGroupId)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupName) == false && undefined !== pobjgs_PaperGroupEN.paperGroupName && tzDataType.isString(pobjgs_PaperGroupEN.paperGroupName) === false)
{
 throw new Error("(errid:Watl000063)字段[组名(paperGroupName)]的值:[$(pobjgs_PaperGroupEN.paperGroupName)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updUser) == false && undefined !== pobjgs_PaperGroupEN.updUser && tzDataType.isString(pobjgs_PaperGroupEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperGroupEN.updUser)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperGroupEN.orderNum && undefined !== pobjgs_PaperGroupEN.orderNum && tzDataType.isNumber(pobjgs_PaperGroupEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_PaperGroupEN.orderNum)], 非法，应该为数值型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.updDate) == false && undefined !== pobjgs_PaperGroupEN.updDate && tzDataType.isString(pobjgs_PaperGroupEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperGroupEN.updDate)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperGroupEN.meno) == false && undefined !== pobjgs_PaperGroupEN.meno && tzDataType.isString(pobjgs_PaperGroupEN.meno) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjgs_PaperGroupEN.meno)], 非法，应该为字符型(In 论文分组(gs_PaperGroup))!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_PaperGroupEN.paperGroupId) === true 
 || pobjgs_PaperGroupEN.paperGroupId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[组Id]不能为空(In 论文分组)!(clsgs_PaperGroupBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperGroupEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperGroup_GetJSONStrByObj (pobjgs_PaperGroupEN: clsgs_PaperGroupEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperGroupEN.sf_UpdFldSetStr = pobjgs_PaperGroupEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperGroupEN);
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
export function gs_PaperGroup_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperGroupEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperGroupObjLst = new Array<clsgs_PaperGroupEN>();
if (strJSON === "")
{
return arrgs_PaperGroupObjLst;
}
try
{
arrgs_PaperGroupObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperGroupObjLst;
}
return arrgs_PaperGroupObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperGroupObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperGroup_GetObjLstByJSONObjLst (arrgs_PaperGroupObjLstS: Array<clsgs_PaperGroupEN>): Array<clsgs_PaperGroupEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperGroupObjLst = new Array<clsgs_PaperGroupEN>();
for (const objInFor of arrgs_PaperGroupObjLstS) {
const obj1 = gs_PaperGroup_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperGroupObjLst.push(obj1);
}
return arrgs_PaperGroupObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperGroup_GetObjByJSONStr (strJSON: string): clsgs_PaperGroupEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperGroupEN = new clsgs_PaperGroupEN();
if (strJSON === "")
{
return pobjgs_PaperGroupEN;
}
try
{
pobjgs_PaperGroupEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperGroupEN;
}
return pobjgs_PaperGroupEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperGroup_GetCombineCondition(objgs_PaperGroup_Cond: clsgs_PaperGroupEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_PaperGroupId) == true)
{
const strComparisonOp_PaperGroupId:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_PaperGroupId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_PaperGroupId, objgs_PaperGroup_Cond.paperGroupId, strComparisonOp_PaperGroupId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_PaperGroupName) == true)
{
const strComparisonOp_PaperGroupName:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_PaperGroupName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_PaperGroupName, objgs_PaperGroup_Cond.paperGroupName, strComparisonOp_PaperGroupName);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_UpdUser, objgs_PaperGroup_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperGroupEN.con_OrderNum, objgs_PaperGroup_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_UpdDate, objgs_PaperGroup_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperGroup_Cond.dicFldComparisonOp, clsgs_PaperGroupEN.con_Meno) == true)
{
const strComparisonOp_Meno:string = objgs_PaperGroup_Cond.dicFldComparisonOp[clsgs_PaperGroupEN.con_Meno];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperGroupEN.con_Meno, objgs_PaperGroup_Cond.meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperGroup(论文分组),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperGroupName: 组名(要求唯一的字段)
 * @param strUpdUser: 修改人(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperGroup_GetUniCondStr_PaperGroupName_UpdUser(objgs_PaperGroupEN: clsgs_PaperGroupEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.paperGroupName);
 strWhereCond +=  Format(" and UpdUser = '{0}'", objgs_PaperGroupEN.updUser);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperGroup(论文分组),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperGroupName: 组名(要求唯一的字段)
 * @param strUpdUser: 修改人(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperGroup_GetUniCondStr4Update_PaperGroupName_UpdUser(objgs_PaperGroupEN: clsgs_PaperGroupEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperGroupId <> '{0}'", objgs_PaperGroupEN.paperGroupId);
 strWhereCond +=  Format(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.paperGroupName);
 strWhereCond +=  Format(" and UpdUser = '{0}'", objgs_PaperGroupEN.updUser);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperGroupENS:源对象
 * @param objgs_PaperGroupENT:目标对象
*/
export function gs_PaperGroup_CopyObjTo(objgs_PaperGroupENS: clsgs_PaperGroupEN , objgs_PaperGroupENT: clsgs_PaperGroupEN ): void 
{
objgs_PaperGroupENT.paperGroupId = objgs_PaperGroupENS.paperGroupId; //组Id
objgs_PaperGroupENT.paperGroupName = objgs_PaperGroupENS.paperGroupName; //组名
objgs_PaperGroupENT.updUser = objgs_PaperGroupENS.updUser; //修改人
objgs_PaperGroupENT.orderNum = objgs_PaperGroupENS.orderNum; //序号
objgs_PaperGroupENT.updDate = objgs_PaperGroupENS.updDate; //修改日期
objgs_PaperGroupENT.meno = objgs_PaperGroupENS.meno; //备注
objgs_PaperGroupENT.sf_UpdFldSetStr = objgs_PaperGroupENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperGroupENS:源对象
 * @param objgs_PaperGroupENT:目标对象
*/
export function gs_PaperGroup_GetObjFromJsonObj(objgs_PaperGroupENS: clsgs_PaperGroupEN): clsgs_PaperGroupEN 
{
 const objgs_PaperGroupENT: clsgs_PaperGroupEN = new clsgs_PaperGroupEN();
ObjectAssign(objgs_PaperGroupENT, objgs_PaperGroupENS);
 return objgs_PaperGroupENT;
}