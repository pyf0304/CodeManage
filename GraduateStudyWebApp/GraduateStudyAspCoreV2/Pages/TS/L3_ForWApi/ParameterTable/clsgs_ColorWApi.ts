﻿
 /**
 * 类名:clsgs_ColorWApi
 * 表名:gs_Color(01120751)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:55
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
 * 颜色表(gs_Color)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_ColorEN } from "../../L0_Entity/ParameterTable/clsgs_ColorEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_Color_Controller = "gs_ColorApi";
 export const gs_Color_ConstructorName = "gs_Color";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strColorId:关键字
 * @returns 对象
 **/
export async function gs_Color_GetObjByColorIdAsync(strColorId: string): Promise<clsgs_ColorEN|null>  
{
const strThisFuncName = "GetObjByColorIdAsync";

if (IsNullOrEmpty(strColorId) == true)
{
  const strMsg = Format("参数:[strColorId]不能为空！(In clsgs_ColorWApi.GetObjByColorIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strColorId.length != 2)
{
const strMsg = Format("缓存分类变量:[strColorId]的长度:[{0}]不正确！(clsgs_ColorWApi.GetObjByColorIdAsync)", strColorId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByColorId";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strColorId": strColorId,
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
const objgs_Color = gs_Color_GetObjFromJsonObj(returnObj);
return objgs_Color;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param strColorId:所给的关键字
 * @returns 对象
*/
export async function gs_Color_GetObjByColorId_Cache(strColorId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByColorId_Cache";

if (IsNullOrEmpty(strColorId) == true)
{
  const strMsg = Format("参数:[strColorId]不能为空！(In clsgs_ColorWApi.GetObjByColorId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strColorId.length != 2)
{
const strMsg = Format("缓存分类变量:[strColorId]的长度:[{0}]不正确！(clsgs_ColorWApi.GetObjByColorId_Cache)", strColorId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
try
{
const arrgs_Color_Sel: Array <clsgs_ColorEN> = arrgs_ColorObjLst_Cache.filter(x => 
 x.colorId == strColorId );
let objgs_Color: clsgs_ColorEN;
if (arrgs_Color_Sel.length > 0)
{
objgs_Color = arrgs_Color_Sel[0];
return objgs_Color;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_Color_Const = await gs_Color_GetObjByColorIdAsync(strColorId);
if (objgs_Color_Const != null)
{
gs_Color_ReFreshThisCache();
return objgs_Color_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strColorId, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strColorId:所给的关键字
 * @returns 对象
*/
export async function gs_Color_GetObjByColorId_localStorage(strColorId: string) {
const strThisFuncName = "GetObjByColorId_localStorage";

if (IsNullOrEmpty(strColorId) == true)
{
  const strMsg = Format("参数:[strColorId]不能为空！(In clsgs_ColorWApi.GetObjByColorId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strColorId.length != 2)
{
const strMsg = Format("缓存分类变量:[strColorId]的长度:[{0}]不正确！(clsgs_ColorWApi.GetObjByColorId_localStorage)", strColorId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_ColorEN._CurrTabName, strColorId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_Color_Cache: clsgs_ColorEN = JSON.parse(strTempObj);
return objgs_Color_Cache;
}
try
{
const objgs_Color = await gs_Color_GetObjByColorIdAsync(strColorId);
if (objgs_Color != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_Color));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_Color;
}
return objgs_Color;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strColorId, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_Color:所给的对象
 * @returns 对象
*/
export async function gs_Color_UpdateObjInLst_Cache(objgs_Color: clsgs_ColorEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
const obj = arrgs_ColorObjLst_Cache.find(x => x.colorId == objgs_Color.colorId);
if (obj != null)
{
objgs_Color.colorId = obj.colorId;
ObjectAssign( obj, objgs_Color);
}
else
{
arrgs_ColorObjLst_Cache.push(objgs_Color);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_ColorEN.con_ColorId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_ColorEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_ColorEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strColorId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_Color = await gs_Color_GetObjByColorId_Cache(strColorId );
if (objgs_Color == null) return "";
if (objgs_Color.GetFldValue(strOutFldName) == null) return "";
return objgs_Color.GetFldValue(strOutFldName).toString();
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
export function gs_Color_SortFun_Defa(a:clsgs_ColorEN , b:clsgs_ColorEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.colorId.localeCompare(b.colorId);
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
export function gs_Color_SortFun_Defa_2Fld(a:clsgs_ColorEN , b:clsgs_ColorEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userNo == b.userNo) return a.colorCode.localeCompare(b.colorCode);
else return a.userNo - b.userNo;
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
export function gs_Color_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ColorEN.con_ColorId:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
return a.colorId.localeCompare(b.colorId);
}
case clsgs_ColorEN.con_UserNo:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
return a.userNo-b.userNo;
}
case clsgs_ColorEN.con_ColorCode:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
if (a.colorCode == null) return -1;
if (b.colorCode == null) return 1;
return a.colorCode.localeCompare(b.colorCode);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${ gs_Color_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ColorEN.con_ColorId:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
return b.colorId.localeCompare(a.colorId);
}
case clsgs_ColorEN.con_UserNo:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
return b.userNo-a.userNo;
}
case clsgs_ColorEN.con_ColorCode:
return (a: clsgs_ColorEN, b: clsgs_ColorEN) => {
if (b.colorCode == null) return -1;
if (a.colorCode == null) return 1;
return b.colorCode.localeCompare(a.colorCode);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${ gs_Color_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_Color_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ColorEN.con_ColorId:
return (obj: clsgs_ColorEN) => {
return obj.colorId === value;
}
case clsgs_ColorEN.con_UserNo:
return (obj: clsgs_ColorEN) => {
return obj.userNo === value;
}
case clsgs_ColorEN.con_ColorCode:
return (obj: clsgs_ColorEN) => {
return obj.colorCode === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Color]中不存在！(in ${ gs_Color_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_Color_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_ColorEN.con_ColorId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_Color = await gs_Color_GetObjLst_Cache();
if (arrgs_Color == null) return [];
let arrgs_Color_Sel = arrgs_Color;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_Color_Sel.length == 0) return [];
return arrgs_Color_Sel.map(x=>x.colorId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_Color_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ColorEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const objgs_Color = gs_Color_GetObjFromJsonObj(returnObj);
return objgs_Color;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ColorEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ColorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ColorEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_ColorExObjLst_Cache: Array<clsgs_ColorEN> = CacheHelper.Get(strKey);
const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
return arrgs_ColorObjLst_T;
}
try
{
const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_ColorExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
console.log(strInfo);
return arrgs_ColorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Color_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ColorEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ColorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ColorEN.CacheAddiCondition);
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
const arrgs_ColorExObjLst_Cache: Array<clsgs_ColorEN> = JSON.parse(strTempObjLst);
const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
return arrgs_ColorObjLst_T;
}
try
{
const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_ColorExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
console.log(strInfo);
return arrgs_ColorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Color_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ColorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ColorObjLst_Cache: Array<clsgs_ColorEN> = JSON.parse(strTempObjLst);
return arrgs_ColorObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_Color_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ColorEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Color_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ColorEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ColorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ColorEN.CacheAddiCondition);
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
const arrgs_ColorExObjLst_Cache: Array<clsgs_ColorEN> = JSON.parse(strTempObjLst);
const arrgs_ColorObjLst_T = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorExObjLst_Cache);
return arrgs_ColorObjLst_T;
}
try
{
const arrgs_ColorExObjLst = await gs_Color_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_ColorExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ColorExObjLst.length);
console.log(strInfo);
return arrgs_ColorExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Color_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ColorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ColorObjLst_Cache: Array<clsgs_ColorEN> = JSON.parse(strTempObjLst);
return arrgs_ColorObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Color_GetObjLst_Cache(): Promise<Array<clsgs_ColorEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_ColorObjLst_Cache;
switch (clsgs_ColorEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_ClientCache();
break;
default:
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_ClientCache();
break;
}
const arrgs_ColorObjLst = gs_Color_GetObjLstByJSONObjLst(arrgs_ColorObjLst_Cache);
return arrgs_ColorObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Color_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_ColorObjLst_Cache;
switch (clsgs_ColorEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_ColorObjLst_Cache = null;
break;
default:
arrgs_ColorObjLst_Cache = null;
break;
}
return arrgs_ColorObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrColorId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_Color_GetSubObjLst_Cache(objgs_Color_Cond: clsgs_ColorEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
let arrgs_Color_Sel: Array < clsgs_ColorEN > = arrgs_ColorObjLst_Cache;
if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "") return arrgs_Color_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
//console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Color_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Color_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_Color_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_Color_Cond), gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ColorEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrColorId:关键字列表
 * @returns 对象列表
 **/
export async function gs_Color_GetObjLstByColorIdLstAsync(arrColorId: Array<string>): Promise<Array<clsgs_ColorEN>>  
{
const strThisFuncName = "GetObjLstByColorIdLstAsync";
const strAction = "GetObjLstByColorIdLst";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrColorId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Color_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param arrstrColorIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_Color_GetObjLstByColorIdLst_Cache(arrColorIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByColorIdLst_Cache";
try
{
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
const arrgs_Color_Sel: Array <clsgs_ColorEN> = arrgs_ColorObjLst_Cache.filter(x => arrColorIdLst.indexOf(x.colorId)>-1);
return arrgs_Color_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrColorIdLst.join(","), gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ColorEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Color_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ColorEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Color_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ColorEN>();
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
if (arrgs_ColorObjLst_Cache.length == 0) return arrgs_ColorObjLst_Cache;
let arrgs_Color_Sel = arrgs_ColorObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_Color_Cond = new clsgs_ColorEN();
ObjectAssign(objgs_Color_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_ColorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Color_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_Color_Sel.length == 0) return arrgs_Color_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_Color_Sel = arrgs_Color_Sel.sort(gs_Color_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_Color_Sel = arrgs_Color_Sel.sort(objPagerPara.sortFun);
}
arrgs_Color_Sel = arrgs_Color_Sel.slice(intStart, intEnd);     
return arrgs_Color_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ColorEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_Color_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ColorEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ColorEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Color_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Color_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param strColorId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_Color_DelRecordAsync(strColorId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strColorId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param arrColorId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_Color_Delgs_ColorsAsync(arrColorId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ColorsAsync";
const strAction = "Delgs_Colors";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrColorId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_Delgs_ColorsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ColorsByCondAsync";
const strAction = "Delgs_ColorsByCond";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Color_AddNewRecordAsync(objgs_ColorEN: clsgs_ColorEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ColorEN);
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Color_AddNewRecordWithMaxIdAsync(objgs_ColorEN: clsgs_ColorEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_Color_AddNewRecordWithReturnKeyAsync(objgs_ColorEN: clsgs_ColorEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_Color_AddNewRecordWithReturnKey(objgs_ColorEN: clsgs_ColorEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ColorEN.colorId === null || objgs_ColorEN.colorId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_Color_UpdateRecordAsync(objgs_ColorEN: clsgs_ColorEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ColorEN.sfUpdFldSetStr === undefined || objgs_ColorEN.sfUpdFldSetStr === null || objgs_ColorEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ColorEN.colorId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_ColorEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_Color_UpdateWithConditionAsync(objgs_ColorEN: clsgs_ColorEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ColorEN.sfUpdFldSetStr === undefined || objgs_ColorEN.sfUpdFldSetStr === null || objgs_ColorEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ColorEN.colorId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
objgs_ColorEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ColorEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objstrColorId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_Color_IsExistRecord_Cache(objgs_Color_Cond: clsgs_ColorEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
if (arrgs_ColorObjLst_Cache == null) return false;
let arrgs_Color_Sel: Array < clsgs_ColorEN > = arrgs_ColorObjLst_Cache;
if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "") return arrgs_Color_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
//console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Color_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Color_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_Color_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_Color_Cond), gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param strColorId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_Color_IsExist(strColorId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ColorId": strColorId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param strColorId:所给的关键字
 * @returns 对象
*/
export async function gs_Color_IsExist_Cache(strColorId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
if (arrgs_ColorObjLst_Cache == null) return false;
try
{
const arrgs_Color_Sel: Array <clsgs_ColorEN> = arrgs_ColorObjLst_Cache.filter(x => x.colorId == strColorId);
if (arrgs_Color_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strColorId, gs_Color_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strColorId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_Color_IsExistAsync(strColorId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strColorId": strColorId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
 * @param objgs_Color_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_Color_GetRecCountByCond_Cache(objgs_Color_Cond: clsgs_ColorEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_ColorObjLst_Cache = await gs_Color_GetObjLst_Cache();
if (arrgs_ColorObjLst_Cache == null) return 0;
let arrgs_Color_Sel: Array < clsgs_ColorEN > = arrgs_ColorObjLst_Cache;
if (objgs_Color_Cond.sf_FldComparisonOp == null || objgs_Color_Cond.sf_FldComparisonOp == "") return arrgs_Color_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Color_Cond.sf_FldComparisonOp);
//console.log("clsgs_ColorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Color_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Color_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Color_Sel = arrgs_Color_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_Color_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_Color_Cond), gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export async function gs_Color_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_Color_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Color_ConstructorName, strThisFuncName);
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
export function gs_Color_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_Color_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_ColorEN._CurrTabName;
switch (clsgs_ColorEN.CacheModeId)
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
export function gs_Color_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_ColorEN._CurrTabName;
switch (clsgs_ColorEN.CacheModeId)
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
export function gs_Color_CheckPropertyNew(pobjgs_ColorEN: clsgs_ColorEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ColorEN.colorId) == false && GetStrLen(pobjgs_ColorEN.colorId) > 2)
{
 throw new Error("(errid:Watl000059)字段[颜色Id(colorId)]的长度不能超过2(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorId)(clsgs_ColorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ColorEN.colorCode) == false && GetStrLen(pobjgs_ColorEN.colorCode) > 200)
{
 throw new Error("(errid:Watl000059)字段[颜色码(colorCode)]的长度不能超过200(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorCode)(clsgs_ColorBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ColorEN.colorId) == false && undefined !== pobjgs_ColorEN.colorId && tzDataType.isString(pobjgs_ColorEN.colorId) === false)
{
 throw new Error("(errid:Watl000060)字段[颜色Id(colorId)]的值:[$(pobjgs_ColorEN.colorId)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
}
if (null != pobjgs_ColorEN.userNo && undefined !== pobjgs_ColorEN.userNo && tzDataType.isNumber(pobjgs_ColorEN.userNo) === false)
{
 throw new Error("(errid:Watl000060)字段[用户号(userNo)]的值:[$(pobjgs_ColorEN.userNo)], 非法，应该为数值型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ColorEN.colorCode) == false && undefined !== pobjgs_ColorEN.colorCode && tzDataType.isString(pobjgs_ColorEN.colorCode) === false)
{
 throw new Error("(errid:Watl000060)字段[颜色码(colorCode)]的值:[$(pobjgs_ColorEN.colorCode)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ColorEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_Color_CheckProperty4Update (pobjgs_ColorEN: clsgs_ColorEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ColorEN.colorId) == false && GetStrLen(pobjgs_ColorEN.colorId) > 2)
{
 throw new Error("(errid:Watl000062)字段[颜色Id(colorId)]的长度不能超过2(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorId)(clsgs_ColorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ColorEN.colorCode) == false && GetStrLen(pobjgs_ColorEN.colorCode) > 200)
{
 throw new Error("(errid:Watl000062)字段[颜色码(colorCode)]的长度不能超过200(In 颜色表(gs_Color))!值:$(pobjgs_ColorEN.colorCode)(clsgs_ColorBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ColorEN.colorId) == false && undefined !== pobjgs_ColorEN.colorId && tzDataType.isString(pobjgs_ColorEN.colorId) === false)
{
 throw new Error("(errid:Watl000063)字段[颜色Id(colorId)]的值:[$(pobjgs_ColorEN.colorId)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
}
if (null != pobjgs_ColorEN.userNo && undefined !== pobjgs_ColorEN.userNo && tzDataType.isNumber(pobjgs_ColorEN.userNo) === false)
{
 throw new Error("(errid:Watl000063)字段[用户号(userNo)]的值:[$(pobjgs_ColorEN.userNo)], 非法，应该为数值型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ColorEN.colorCode) == false && undefined !== pobjgs_ColorEN.colorCode && tzDataType.isString(pobjgs_ColorEN.colorCode) === false)
{
 throw new Error("(errid:Watl000063)字段[颜色码(colorCode)]的值:[$(pobjgs_ColorEN.colorCode)], 非法，应该为字符型(In 颜色表(gs_Color))!(clsgs_ColorBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_ColorEN.colorId) === true )
{
 throw new Error("(errid:Watl000064)字段[颜色Id]不能为空(In 颜色表)!(clsgs_ColorBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ColorEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_Color_GetJSONStrByObj (pobjgs_ColorEN: clsgs_ColorEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ColorEN.sfUpdFldSetStr = pobjgs_ColorEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ColorEN);
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
export function gs_Color_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ColorEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ColorObjLst = new Array<clsgs_ColorEN>();
if (strJSON === "")
{
return arrgs_ColorObjLst;
}
try
{
arrgs_ColorObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ColorObjLst;
}
return arrgs_ColorObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ColorObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_Color_GetObjLstByJSONObjLst (arrgs_ColorObjLstS: Array<clsgs_ColorEN>): Array<clsgs_ColorEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ColorObjLst = new Array<clsgs_ColorEN>();
for (const objInFor of arrgs_ColorObjLstS) {
const obj1 = gs_Color_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ColorObjLst.push(obj1);
}
return arrgs_ColorObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_Color_GetObjByJSONStr (strJSON: string): clsgs_ColorEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ColorEN = new clsgs_ColorEN();
if (strJSON === "")
{
return pobjgs_ColorEN;
}
try
{
pobjgs_ColorEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ColorEN;
}
return pobjgs_ColorEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_Color_GetCombineCondition(objgs_Color_Cond: clsgs_ColorEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN.con_ColorId) == true)
{
const strComparisonOp_ColorId:string = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN.con_ColorId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ColorEN.con_ColorId, objgs_Color_Cond.colorId, strComparisonOp_ColorId);
}
if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN.con_UserNo) == true)
{
const strComparisonOp_UserNo:string = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN.con_UserNo];
strWhereCond += Format(" And {0} {2} {1}", clsgs_ColorEN.con_UserNo, objgs_Color_Cond.userNo, strComparisonOp_UserNo);
}
if (Object.prototype.hasOwnProperty.call(objgs_Color_Cond.dicFldComparisonOp, clsgs_ColorEN.con_ColorCode) == true)
{
const strComparisonOp_ColorCode:string = objgs_Color_Cond.dicFldComparisonOp[clsgs_ColorEN.con_ColorCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ColorEN.con_ColorCode, objgs_Color_Cond.colorCode, strComparisonOp_ColorCode);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_Color(颜色表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strColorId: 颜色Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_Color_GetUniCondStr_ColorId(objgs_ColorEN: clsgs_ColorEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ColorId = '{0}'", objgs_ColorEN.colorId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_Color(颜色表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strColorId: 颜色Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_Color_GetUniCondStr4Update_ColorId(objgs_ColorEN: clsgs_ColorEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ColorId <> '{0}'", objgs_ColorEN.colorId);
 strWhereCond +=  Format(" and ColorId = '{0}'", objgs_ColorEN.colorId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ColorENS:源对象
 * @param objgs_ColorENT:目标对象
*/
export function gs_Color_CopyObjTo(objgs_ColorENS: clsgs_ColorEN , objgs_ColorENT: clsgs_ColorEN ): void 
{
objgs_ColorENT.colorId = objgs_ColorENS.colorId; //颜色Id
objgs_ColorENT.userNo = objgs_ColorENS.userNo; //用户号
objgs_ColorENT.colorCode = objgs_ColorENS.colorCode; //颜色码
objgs_ColorENT.sfUpdFldSetStr = objgs_ColorENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ColorENS:源对象
 * @param objgs_ColorENT:目标对象
*/
export function gs_Color_GetObjFromJsonObj(objgs_ColorENS: clsgs_ColorEN): clsgs_ColorEN 
{
 const objgs_ColorENT: clsgs_ColorEN = new clsgs_ColorEN();
ObjectAssign(objgs_ColorENT, objgs_ColorENS);
 return objgs_ColorENT;
}