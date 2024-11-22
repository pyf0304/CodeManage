
 /**
 * 类名:clsSysScoreTypeWApi
 * 表名:SysScoreType(01120631)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:50:58
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
 * 评分类型表(SysScoreType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsSysScoreTypeEN } from "../../L0_Entity/ParameterTable/clsSysScoreTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysScoreType_Controller = "SysScoreTypeApi";
 export const sysScoreType_ConstructorName = "sysScoreType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strScoreTypeId:关键字
 * @returns 对象
 **/
export async function SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId: string): Promise<clsSysScoreTypeEN|null>  
{
const strThisFuncName = "GetObjByScoreTypeIdAsync";

if (IsNullOrEmpty(strScoreTypeId) == true)
{
  const strMsg = Format("参数:[strScoreTypeId]不能为空！(In clsSysScoreTypeWApi.GetObjByScoreTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！(clsSysScoreTypeWApi.GetObjByScoreTypeIdAsync)", strScoreTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByScoreTypeId";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strScoreTypeId": strScoreTypeId,
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
const objSysScoreType = SysScoreType_GetObjFromJsonObj(returnObj);
return objSysScoreType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param strScoreTypeId:所给的关键字
 * @returns 对象
*/
export async function SysScoreType_GetObjByScoreTypeId_Cache(strScoreTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByScoreTypeId_Cache";

if (IsNullOrEmpty(strScoreTypeId) == true)
{
  const strMsg = Format("参数:[strScoreTypeId]不能为空！(In clsSysScoreTypeWApi.GetObjByScoreTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！(clsSysScoreTypeWApi.GetObjByScoreTypeId_Cache)", strScoreTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
try
{
const arrSysScoreType_Sel: Array <clsSysScoreTypeEN> = arrSysScoreTypeObjLst_Cache.filter(x => 
 x.scoreTypeId == strScoreTypeId );
let objSysScoreType: clsSysScoreTypeEN;
if (arrSysScoreType_Sel.length > 0)
{
objSysScoreType = arrSysScoreType_Sel[0];
return objSysScoreType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objSysScoreType_Const = await SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId);
if (objSysScoreType_Const != null)
{
SysScoreType_ReFreshThisCache();
return objSysScoreType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreTypeId, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strScoreTypeId:所给的关键字
 * @returns 对象
*/
export async function SysScoreType_GetObjByScoreTypeId_localStorage(strScoreTypeId: string) {
const strThisFuncName = "GetObjByScoreTypeId_localStorage";

if (IsNullOrEmpty(strScoreTypeId) == true)
{
  const strMsg = Format("参数:[strScoreTypeId]不能为空！(In clsSysScoreTypeWApi.GetObjByScoreTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！(clsSysScoreTypeWApi.GetObjByScoreTypeId_localStorage)", strScoreTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysScoreTypeEN._CurrTabName, strScoreTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysScoreType_Cache: clsSysScoreTypeEN = JSON.parse(strTempObj);
return objSysScoreType_Cache;
}
try
{
const objSysScoreType = await SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId);
if (objSysScoreType != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysScoreType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysScoreType;
}
return objSysScoreType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreTypeId, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysScoreType:所给的对象
 * @returns 对象
*/
export async function SysScoreType_UpdateObjInLst_Cache(objSysScoreType: clsSysScoreTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
const obj = arrSysScoreTypeObjLst_Cache.find(x => 
x.scoreTypeId == objSysScoreType.scoreTypeId);
if (obj != null)
{
objSysScoreType.scoreTypeId = obj.scoreTypeId;
ObjectAssign( obj, objSysScoreType);
}
else
{
arrSysScoreTypeObjLst_Cache.push(objSysScoreType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strScoreTypeId:所给的关键字
 * @returns 对象
*/
export async function SysScoreType_GetNameByScoreTypeId_Cache(strScoreTypeId: string) {
const strThisFuncName = "GetNameByScoreTypeId_Cache";

if (IsNullOrEmpty(strScoreTypeId) == true)
{
  const strMsg = Format("参数:[strScoreTypeId]不能为空！(In clsSysScoreTypeWApi.GetNameByScoreTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreTypeId.length != 4)
{
const strMsg = Format("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！(clsSysScoreTypeWApi.GetNameByScoreTypeId_Cache)", strScoreTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreTypeObjLst_Cache == null) return "";
try
{
const arrSysScoreType_Sel: Array <clsSysScoreTypeEN> = arrSysScoreTypeObjLst_Cache.filter(x => 
 x.scoreTypeId == strScoreTypeId );
let objSysScoreType: clsSysScoreTypeEN;
if (arrSysScoreType_Sel.length > 0)
{
objSysScoreType = arrSysScoreType_Sel[0];
return objSysScoreType.scoreTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strScoreTypeId);
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
export async function SysScoreType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsSysScoreTypeEN.con_ScoreTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysScoreTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsSysScoreTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strScoreTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSysScoreType = await SysScoreType_GetObjByScoreTypeId_Cache(strScoreTypeId );
if (objSysScoreType == null) return "";
if (objSysScoreType.GetFldValue(strOutFldName) == null) return "";
return objSysScoreType.GetFldValue(strOutFldName).toString();
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
export function SysScoreType_SortFun_Defa(a:clsSysScoreTypeEN , b:clsSysScoreTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.scoreTypeId.localeCompare(b.scoreTypeId);
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
export function SysScoreType_SortFun_Defa_2Fld(a:clsSysScoreTypeEN , b:clsSysScoreTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.scoreTypeName == b.scoreTypeName) return a.onlyId.localeCompare(b.onlyId);
else return a.scoreTypeName.localeCompare(b.scoreTypeName);
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
export function SysScoreType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysScoreTypeEN.con_ScoreTypeId:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
return a.scoreTypeId.localeCompare(b.scoreTypeId);
}
case clsSysScoreTypeEN.con_ScoreTypeName:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (a.scoreTypeName == null) return -1;
if (b.scoreTypeName == null) return 1;
return a.scoreTypeName.localeCompare(b.scoreTypeName);
}
case clsSysScoreTypeEN.con_OnlyId:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (a.onlyId == null) return -1;
if (b.onlyId == null) return 1;
return a.onlyId.localeCompare(b.onlyId);
}
case clsSysScoreTypeEN.con_UpdUser:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsSysScoreTypeEN.con_UpdDate:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsSysScoreTypeEN.con_Memo:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${ sysScoreType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysScoreTypeEN.con_ScoreTypeId:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
return b.scoreTypeId.localeCompare(a.scoreTypeId);
}
case clsSysScoreTypeEN.con_ScoreTypeName:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (b.scoreTypeName == null) return -1;
if (a.scoreTypeName == null) return 1;
return b.scoreTypeName.localeCompare(a.scoreTypeName);
}
case clsSysScoreTypeEN.con_OnlyId:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (b.onlyId == null) return -1;
if (a.onlyId == null) return 1;
return b.onlyId.localeCompare(a.onlyId);
}
case clsSysScoreTypeEN.con_UpdUser:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsSysScoreTypeEN.con_UpdDate:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsSysScoreTypeEN.con_Memo:
return (a: clsSysScoreTypeEN, b: clsSysScoreTypeEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${ sysScoreType_ConstructorName}.${ strThisFuncName})`;
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
export async function SysScoreType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysScoreTypeEN.con_ScoreTypeId:
return (obj: clsSysScoreTypeEN) => {
return obj.scoreTypeId === value;
}
case clsSysScoreTypeEN.con_ScoreTypeName:
return (obj: clsSysScoreTypeEN) => {
return obj.scoreTypeName === value;
}
case clsSysScoreTypeEN.con_OnlyId:
return (obj: clsSysScoreTypeEN) => {
return obj.onlyId === value;
}
case clsSysScoreTypeEN.con_UpdUser:
return (obj: clsSysScoreTypeEN) => {
return obj.updUser === value;
}
case clsSysScoreTypeEN.con_UpdDate:
return (obj: clsSysScoreTypeEN) => {
return obj.updDate === value;
}
case clsSysScoreTypeEN.con_Memo:
return (obj: clsSysScoreTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${ sysScoreType_ConstructorName}.${ strThisFuncName})`;
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
export async function SysScoreType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsSysScoreTypeEN.con_ScoreTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrSysScoreType = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreType == null) return [];
let arrSysScoreType_Sel = arrSysScoreType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrSysScoreType_Sel.length == 0) return [];
return arrSysScoreType_Sel.map(x=>x.scoreTypeId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysScoreType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetFirstObjAsync(strWhereCond: string): Promise<clsSysScoreTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const objSysScoreType = SysScoreType_GetObjFromJsonObj(returnObj);
return objSysScoreType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysScoreTypeEN._CurrTabName;
if (IsNullOrEmpty(clsSysScoreTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysScoreTypeExObjLst_Cache: Array<clsSysScoreTypeEN> = CacheHelper.Get(strKey);
const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
return arrSysScoreTypeObjLst_T;
}
try
{
const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysScoreTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
console.log(strInfo);
return arrSysScoreTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysScoreTypeEN._CurrTabName;
if (IsNullOrEmpty(clsSysScoreTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreTypeEN.CacheAddiCondition);
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
const arrSysScoreTypeExObjLst_Cache: Array<clsSysScoreTypeEN> = JSON.parse(strTempObjLst);
const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
return arrSysScoreTypeObjLst_T;
}
try
{
const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysScoreTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
console.log(strInfo);
return arrSysScoreTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSysScoreTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysScoreTypeObjLst_Cache: Array<clsSysScoreTypeEN> = JSON.parse(strTempObjLst);
return arrSysScoreTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysScoreType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysScoreTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSysScoreTypeEN._CurrTabName;
if (IsNullOrEmpty(clsSysScoreTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysScoreTypeEN.CacheAddiCondition);
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
const arrSysScoreTypeExObjLst_Cache: Array<clsSysScoreTypeEN> = JSON.parse(strTempObjLst);
const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
return arrSysScoreTypeObjLst_T;
}
try
{
const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysScoreTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
console.log(strInfo);
return arrSysScoreTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSysScoreTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysScoreTypeObjLst_Cache: Array<clsSysScoreTypeEN> = JSON.parse(strTempObjLst);
return arrSysScoreTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreType_GetObjLst_Cache(): Promise<Array<clsSysScoreTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrSysScoreTypeObjLst_Cache;
switch (clsSysScoreTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_ClientCache();
break;
default:
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_ClientCache();
break;
}
const arrSysScoreTypeObjLst = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeObjLst_Cache);
return arrSysScoreTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysScoreType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysScoreTypeObjLst_Cache;
switch (clsSysScoreTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrSysScoreTypeObjLst_Cache = null;
break;
default:
arrSysScoreTypeObjLst_Cache = null;
break;
}
return arrSysScoreTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrScoreTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysScoreType_GetSubObjLst_Cache(objSysScoreType_Cond: clsSysScoreTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
let arrSysScoreType_Sel: Array < clsSysScoreTypeEN > = arrSysScoreTypeObjLst_Cache;
if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "") return arrSysScoreType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysScoreType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysScoreType_Cond), sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysScoreTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrScoreTypeId:关键字列表
 * @returns 对象列表
 **/
export async function SysScoreType_GetObjLstByScoreTypeIdLstAsync(arrScoreTypeId: Array<string>): Promise<Array<clsSysScoreTypeEN>>  
{
const strThisFuncName = "GetObjLstByScoreTypeIdLstAsync";
const strAction = "GetObjLstByScoreTypeIdLst";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrScoreTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param arrstrScoreTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function SysScoreType_GetObjLstByScoreTypeIdLst_Cache(arrScoreTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByScoreTypeIdLst_Cache";
try
{
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
const arrSysScoreType_Sel: Array <clsSysScoreTypeEN> = arrSysScoreTypeObjLst_Cache.filter(x => arrScoreTypeIdLst.indexOf(x.scoreTypeId)>-1);
return arrSysScoreType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrScoreTypeIdLst.join(","), sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysScoreTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysScoreTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsSysScoreTypeEN>();
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreTypeObjLst_Cache.length == 0) return arrSysScoreTypeObjLst_Cache;
let arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysScoreType_Cond = new clsSysScoreTypeEN();
ObjectAssign(objSysScoreType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysScoreTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysScoreType_Sel.length == 0) return arrSysScoreType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysScoreType_Sel = arrSysScoreType_Sel.sort(SysScoreType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysScoreType_Sel = arrSysScoreType_Sel.sort(objPagerPara.sortFun);
}
arrSysScoreType_Sel = arrSysScoreType_Sel.slice(intStart, intEnd);     
return arrSysScoreType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysScoreTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysScoreType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysScoreTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSysScoreTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param strScoreTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function SysScoreType_DelRecordAsync(strScoreTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strScoreTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param arrScoreTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysScoreType_DelSysScoreTypesAsync(arrScoreTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysScoreTypesAsync";
const strAction = "DelSysScoreTypes";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrScoreTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_DelSysScoreTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysScoreTypesByCondAsync";
const strAction = "DelSysScoreTypesByCond";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysScoreType_AddNewRecordAsync(objSysScoreTypeEN: clsSysScoreTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSysScoreTypeEN.scoreTypeId === null || objSysScoreTypeEN.scoreTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSysScoreTypeEN);
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysScoreType_AddNewRecordWithMaxIdAsync(objSysScoreTypeEN: clsSysScoreTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysScoreType_AddNewRecordWithReturnKeyAsync(objSysScoreTypeEN: clsSysScoreTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysScoreType_AddNewRecordWithReturnKey(objSysScoreTypeEN: clsSysScoreTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysScoreTypeEN.scoreTypeId === null || objSysScoreTypeEN.scoreTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysScoreType_UpdateRecordAsync(objSysScoreTypeEN: clsSysScoreTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysScoreTypeEN.sfUpdFldSetStr === undefined || objSysScoreTypeEN.sfUpdFldSetStr === null || objSysScoreTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreTypeEN.scoreTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysScoreType_UpdateWithConditionAsync(objSysScoreTypeEN: clsSysScoreTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysScoreTypeEN.sfUpdFldSetStr === undefined || objSysScoreTypeEN.sfUpdFldSetStr === null || objSysScoreTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreTypeEN.scoreTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
objSysScoreTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysScoreTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objstrScoreTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysScoreType_IsExistRecord_Cache(objSysScoreType_Cond: clsSysScoreTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreTypeObjLst_Cache == null) return false;
let arrSysScoreType_Sel: Array < clsSysScoreTypeEN > = arrSysScoreTypeObjLst_Cache;
if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "") return arrSysScoreType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysScoreType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysScoreType_Cond), sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param strScoreTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysScoreType_IsExist(strScoreTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ScoreTypeId": strScoreTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param strScoreTypeId:所给的关键字
 * @returns 对象
*/
export async function SysScoreType_IsExist_Cache(strScoreTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreTypeObjLst_Cache == null) return false;
try
{
const arrSysScoreType_Sel: Array <clsSysScoreTypeEN> = arrSysScoreTypeObjLst_Cache.filter(x => x.scoreTypeId == strScoreTypeId);
if (arrSysScoreType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strScoreTypeId, sysScoreType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strScoreTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysScoreType_IsExistAsync(strScoreTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strScoreTypeId": strScoreTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
 * @param objSysScoreType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysScoreType_GetRecCountByCond_Cache(objSysScoreType_Cond: clsSysScoreTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
if (arrSysScoreTypeObjLst_Cache == null) return 0;
let arrSysScoreType_Sel: Array < clsSysScoreTypeEN > = arrSysScoreTypeObjLst_Cache;
if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "") return arrSysScoreType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
//console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysScoreType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysScoreType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysScoreType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysScoreType_Cond), sysScoreType_ConstructorName, strThisFuncName);
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
export async function SysScoreType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysScoreType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreType_ConstructorName, strThisFuncName);
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
export function SysScoreType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysScoreType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsSysScoreTypeEN._CurrTabName;
switch (clsSysScoreTypeEN.CacheModeId)
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
export function SysScoreType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsSysScoreTypeEN._CurrTabName;
switch (clsSysScoreTypeEN.CacheModeId)
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
export async function SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_ScoreTypeIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_ScoreTypeIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_ScoreTypeIdInDiv_Cache");
const arrObjLst_Sel = await SysScoreType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsSysScoreTypeEN.con_ScoreTypeId, clsSysScoreTypeEN.con_ScoreTypeName, "评分类型表");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysScoreType_CheckPropertyNew(pobjSysScoreTypeEN: clsSysScoreTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeId) == false && GetStrLen(pobjSysScoreTypeEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeId)(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeName) == false && GetStrLen(pobjSysScoreTypeEN.scoreTypeName) > 10)
{
 throw new Error("(errid:Watl000059)字段[分数类型名称(scoreTypeName)]的长度不能超过10(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeName)(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.onlyId) == false && GetStrLen(pobjSysScoreTypeEN.onlyId) > 20)
{
 throw new Error("(errid:Watl000059)字段[OnlyId(onlyId)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.onlyId)(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updUser) == false && GetStrLen(pobjSysScoreTypeEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updUser)(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updDate) == false && GetStrLen(pobjSysScoreTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updDate)(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.memo) == false && GetStrLen(pobjSysScoreTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.memo)(clsSysScoreTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeId) == false && undefined !== pobjSysScoreTypeEN.scoreTypeId && tzDataType.isString(pobjSysScoreTypeEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreTypeEN.scoreTypeId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeName) == false && undefined !== pobjSysScoreTypeEN.scoreTypeName && tzDataType.isString(pobjSysScoreTypeEN.scoreTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[分数类型名称(scoreTypeName)]的值:[$(pobjSysScoreTypeEN.scoreTypeName)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.onlyId) == false && undefined !== pobjSysScoreTypeEN.onlyId && tzDataType.isString(pobjSysScoreTypeEN.onlyId) === false)
{
 throw new Error("(errid:Watl000060)字段[OnlyId(onlyId)]的值:[$(pobjSysScoreTypeEN.onlyId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updUser) == false && undefined !== pobjSysScoreTypeEN.updUser && tzDataType.isString(pobjSysScoreTypeEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysScoreTypeEN.updUser)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updDate) == false && undefined !== pobjSysScoreTypeEN.updDate && tzDataType.isString(pobjSysScoreTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysScoreTypeEN.updDate)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.memo) == false && undefined !== pobjSysScoreTypeEN.memo && tzDataType.isString(pobjSysScoreTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysScoreTypeEN.memo)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysScoreTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysScoreType_CheckProperty4Update (pobjSysScoreTypeEN: clsSysScoreTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeId) == false && GetStrLen(pobjSysScoreTypeEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeId)(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeName) == false && GetStrLen(pobjSysScoreTypeEN.scoreTypeName) > 10)
{
 throw new Error("(errid:Watl000062)字段[分数类型名称(scoreTypeName)]的长度不能超过10(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeName)(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.onlyId) == false && GetStrLen(pobjSysScoreTypeEN.onlyId) > 20)
{
 throw new Error("(errid:Watl000062)字段[OnlyId(onlyId)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.onlyId)(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updUser) == false && GetStrLen(pobjSysScoreTypeEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updUser)(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updDate) == false && GetStrLen(pobjSysScoreTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updDate)(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.memo) == false && GetStrLen(pobjSysScoreTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.memo)(clsSysScoreTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeId) == false && undefined !== pobjSysScoreTypeEN.scoreTypeId && tzDataType.isString(pobjSysScoreTypeEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreTypeEN.scoreTypeId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeName) == false && undefined !== pobjSysScoreTypeEN.scoreTypeName && tzDataType.isString(pobjSysScoreTypeEN.scoreTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[分数类型名称(scoreTypeName)]的值:[$(pobjSysScoreTypeEN.scoreTypeName)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.onlyId) == false && undefined !== pobjSysScoreTypeEN.onlyId && tzDataType.isString(pobjSysScoreTypeEN.onlyId) === false)
{
 throw new Error("(errid:Watl000063)字段[OnlyId(onlyId)]的值:[$(pobjSysScoreTypeEN.onlyId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updUser) == false && undefined !== pobjSysScoreTypeEN.updUser && tzDataType.isString(pobjSysScoreTypeEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysScoreTypeEN.updUser)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.updDate) == false && undefined !== pobjSysScoreTypeEN.updDate && tzDataType.isString(pobjSysScoreTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysScoreTypeEN.updDate)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreTypeEN.memo) == false && undefined !== pobjSysScoreTypeEN.memo && tzDataType.isString(pobjSysScoreTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysScoreTypeEN.memo)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysScoreTypeEN.scoreTypeId) === true 
 || pobjSysScoreTypeEN.scoreTypeId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[分数类型Id]不能为空(In 评分类型表)!(clsSysScoreTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysScoreTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreType_GetJSONStrByObj (pobjSysScoreTypeEN: clsSysScoreTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysScoreTypeEN.sfUpdFldSetStr = pobjSysScoreTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysScoreTypeEN);
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
export function SysScoreType_GetObjLstByJSONStr (strJSON: string): Array<clsSysScoreTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysScoreTypeObjLst = new Array<clsSysScoreTypeEN>();
if (strJSON === "")
{
return arrSysScoreTypeObjLst;
}
try
{
arrSysScoreTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysScoreTypeObjLst;
}
return arrSysScoreTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysScoreTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysScoreType_GetObjLstByJSONObjLst (arrSysScoreTypeObjLstS: Array<clsSysScoreTypeEN>): Array<clsSysScoreTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysScoreTypeObjLst = new Array<clsSysScoreTypeEN>();
for (const objInFor of arrSysScoreTypeObjLstS) {
const obj1 = SysScoreType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysScoreTypeObjLst.push(obj1);
}
return arrSysScoreTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreType_GetObjByJSONStr (strJSON: string): clsSysScoreTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysScoreTypeEN = new clsSysScoreTypeEN();
if (strJSON === "")
{
return pobjSysScoreTypeEN;
}
try
{
pobjSysScoreTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysScoreTypeEN;
}
return pobjSysScoreTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysScoreType_GetCombineCondition(objSysScoreType_Cond: clsSysScoreTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_ScoreTypeId) == true)
{
const strComparisonOp_ScoreTypeId:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_ScoreTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_ScoreTypeId, objSysScoreType_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_ScoreTypeName) == true)
{
const strComparisonOp_ScoreTypeName:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_ScoreTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_ScoreTypeName, objSysScoreType_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_OnlyId) == true)
{
const strComparisonOp_OnlyId:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_OnlyId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_OnlyId, objSysScoreType_Cond.onlyId, strComparisonOp_OnlyId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_UpdUser, objSysScoreType_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_UpdDate, objSysScoreType_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreTypeEN.con_Memo, objSysScoreType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysScoreTypeENS:源对象
 * @param objSysScoreTypeENT:目标对象
*/
export function SysScoreType_CopyObjTo(objSysScoreTypeENS: clsSysScoreTypeEN , objSysScoreTypeENT: clsSysScoreTypeEN ): void 
{
objSysScoreTypeENT.scoreTypeId = objSysScoreTypeENS.scoreTypeId; //分数类型Id
objSysScoreTypeENT.scoreTypeName = objSysScoreTypeENS.scoreTypeName; //分数类型名称
objSysScoreTypeENT.onlyId = objSysScoreTypeENS.onlyId; //OnlyId
objSysScoreTypeENT.updUser = objSysScoreTypeENS.updUser; //修改人
objSysScoreTypeENT.updDate = objSysScoreTypeENS.updDate; //修改日期
objSysScoreTypeENT.memo = objSysScoreTypeENS.memo; //备注
objSysScoreTypeENT.sfUpdFldSetStr = objSysScoreTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysScoreTypeENS:源对象
 * @param objSysScoreTypeENT:目标对象
*/
export function SysScoreType_GetObjFromJsonObj(objSysScoreTypeENS: clsSysScoreTypeEN): clsSysScoreTypeEN 
{
 const objSysScoreTypeENT: clsSysScoreTypeEN = new clsSysScoreTypeEN();
ObjectAssign(objSysScoreTypeENT, objSysScoreTypeENS);
 return objSysScoreTypeENT;
}