
 /**
 * 类名:clsgs_ConfigTypeWApi
 * 表名:gs_ConfigType(01120692)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:50:51
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
 * 配置类型(gs_ConfigType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_ConfigTypeEN } from "../../L0_Entity/ParameterTable/clsgs_ConfigTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_ConfigType_Controller = "gs_ConfigTypeApi";
 export const gs_ConfigType_ConstructorName = "gs_ConfigType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strConfigTypeId:关键字
 * @returns 对象
 **/
export async function gs_ConfigType_GetObjByConfigTypeIdAsync(strConfigTypeId: string): Promise<clsgs_ConfigTypeEN|null>  
{
const strThisFuncName = "GetObjByConfigTypeIdAsync";

if (IsNullOrEmpty(strConfigTypeId) == true)
{
  const strMsg = Format("参数:[strConfigTypeId]不能为空！(In clsgs_ConfigTypeWApi.GetObjByConfigTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strConfigTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strConfigTypeId]的长度:[{0}]不正确！(clsgs_ConfigTypeWApi.GetObjByConfigTypeIdAsync)", strConfigTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByConfigTypeId";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strConfigTypeId": strConfigTypeId,
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
const objgs_ConfigType = gs_ConfigType_GetObjFromJsonObj(returnObj);
return objgs_ConfigType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param strConfigTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_ConfigType_GetObjByConfigTypeId_Cache(strConfigTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByConfigTypeId_Cache";

if (IsNullOrEmpty(strConfigTypeId) == true)
{
  const strMsg = Format("参数:[strConfigTypeId]不能为空！(In clsgs_ConfigTypeWApi.GetObjByConfigTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strConfigTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strConfigTypeId]的长度:[{0}]不正确！(clsgs_ConfigTypeWApi.GetObjByConfigTypeId_Cache)", strConfigTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
try
{
const arrgs_ConfigType_Sel: Array <clsgs_ConfigTypeEN> = arrgs_ConfigTypeObjLst_Cache.filter(x => 
 x.configTypeId == strConfigTypeId );
let objgs_ConfigType: clsgs_ConfigTypeEN;
if (arrgs_ConfigType_Sel.length > 0)
{
objgs_ConfigType = arrgs_ConfigType_Sel[0];
return objgs_ConfigType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_ConfigType_Const = await gs_ConfigType_GetObjByConfigTypeIdAsync(strConfigTypeId);
if (objgs_ConfigType_Const != null)
{
gs_ConfigType_ReFreshThisCache();
return objgs_ConfigType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConfigTypeId, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strConfigTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_ConfigType_GetObjByConfigTypeId_localStorage(strConfigTypeId: string) {
const strThisFuncName = "GetObjByConfigTypeId_localStorage";

if (IsNullOrEmpty(strConfigTypeId) == true)
{
  const strMsg = Format("参数:[strConfigTypeId]不能为空！(In clsgs_ConfigTypeWApi.GetObjByConfigTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strConfigTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strConfigTypeId]的长度:[{0}]不正确！(clsgs_ConfigTypeWApi.GetObjByConfigTypeId_localStorage)", strConfigTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_ConfigTypeEN._CurrTabName, strConfigTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_ConfigType_Cache: clsgs_ConfigTypeEN = JSON.parse(strTempObj);
return objgs_ConfigType_Cache;
}
try
{
const objgs_ConfigType = await gs_ConfigType_GetObjByConfigTypeIdAsync(strConfigTypeId);
if (objgs_ConfigType != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_ConfigType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_ConfigType;
}
return objgs_ConfigType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strConfigTypeId, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_ConfigType:所给的对象
 * @returns 对象
*/
export async function gs_ConfigType_UpdateObjInLst_Cache(objgs_ConfigType: clsgs_ConfigTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
const obj = arrgs_ConfigTypeObjLst_Cache.find(x => x.configTypeId == objgs_ConfigType.configTypeId);
if (obj != null)
{
objgs_ConfigType.configTypeId = obj.configTypeId;
ObjectAssign( obj, objgs_ConfigType);
}
else
{
arrgs_ConfigTypeObjLst_Cache.push(objgs_ConfigType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_ConfigTypeEN.con_ConfigTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_ConfigTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_ConfigTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strConfigTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_ConfigType = await gs_ConfigType_GetObjByConfigTypeId_Cache(strConfigTypeId );
if (objgs_ConfigType == null) return "";
if (objgs_ConfigType.GetFldValue(strOutFldName) == null) return "";
return objgs_ConfigType.GetFldValue(strOutFldName).toString();
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
export function gs_ConfigType_SortFun_Defa(a:clsgs_ConfigTypeEN , b:clsgs_ConfigTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.configTypeId.localeCompare(b.configTypeId);
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
export function gs_ConfigType_SortFun_Defa_2Fld(a:clsgs_ConfigTypeEN , b:clsgs_ConfigTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.configTypeName == b.configTypeName) return a.dataTable.localeCompare(b.dataTable);
else return a.configTypeName.localeCompare(b.configTypeName);
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
export function gs_ConfigType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_ConfigTypeEN.con_ConfigTypeId:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
return a.configTypeId.localeCompare(b.configTypeId);
}
case clsgs_ConfigTypeEN.con_ConfigTypeName:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (a.configTypeName == null) return -1;
if (b.configTypeName == null) return 1;
return a.configTypeName.localeCompare(b.configTypeName);
}
case clsgs_ConfigTypeEN.con_DataTable:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (a.dataTable == null) return -1;
if (b.dataTable == null) return 1;
return a.dataTable.localeCompare(b.dataTable);
}
case clsgs_ConfigTypeEN.con_DataTableId:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (a.dataTableId == null) return -1;
if (b.dataTableId == null) return 1;
return a.dataTableId.localeCompare(b.dataTableId);
}
case clsgs_ConfigTypeEN.con_Memo:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ConfigType]中不存在！(in ${ gs_ConfigType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_ConfigTypeEN.con_ConfigTypeId:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
return b.configTypeId.localeCompare(a.configTypeId);
}
case clsgs_ConfigTypeEN.con_ConfigTypeName:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (b.configTypeName == null) return -1;
if (a.configTypeName == null) return 1;
return b.configTypeName.localeCompare(a.configTypeName);
}
case clsgs_ConfigTypeEN.con_DataTable:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (b.dataTable == null) return -1;
if (a.dataTable == null) return 1;
return b.dataTable.localeCompare(a.dataTable);
}
case clsgs_ConfigTypeEN.con_DataTableId:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (b.dataTableId == null) return -1;
if (a.dataTableId == null) return 1;
return b.dataTableId.localeCompare(a.dataTableId);
}
case clsgs_ConfigTypeEN.con_Memo:
return (a: clsgs_ConfigTypeEN, b: clsgs_ConfigTypeEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ConfigType]中不存在！(in ${ gs_ConfigType_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ConfigType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_ConfigTypeEN.con_ConfigTypeId:
return (obj: clsgs_ConfigTypeEN) => {
return obj.configTypeId === value;
}
case clsgs_ConfigTypeEN.con_ConfigTypeName:
return (obj: clsgs_ConfigTypeEN) => {
return obj.configTypeName === value;
}
case clsgs_ConfigTypeEN.con_DataTable:
return (obj: clsgs_ConfigTypeEN) => {
return obj.dataTable === value;
}
case clsgs_ConfigTypeEN.con_DataTableId:
return (obj: clsgs_ConfigTypeEN) => {
return obj.dataTableId === value;
}
case clsgs_ConfigTypeEN.con_Memo:
return (obj: clsgs_ConfigTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_ConfigType]中不存在！(in ${ gs_ConfigType_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_ConfigType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_ConfigTypeEN.con_ConfigTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_ConfigType = await gs_ConfigType_GetObjLst_Cache();
if (arrgs_ConfigType == null) return [];
let arrgs_ConfigType_Sel = arrgs_ConfigType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_ConfigType_Sel.length == 0) return [];
return arrgs_ConfigType_Sel.map(x=>x.configTypeId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ConfigType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_ConfigTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const objgs_ConfigType = gs_ConfigType_GetObjFromJsonObj(returnObj);
return objgs_ConfigType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ConfigTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ConfigTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ConfigTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_ConfigTypeExObjLst_Cache: Array<clsgs_ConfigTypeEN> = CacheHelper.Get(strKey);
const arrgs_ConfigTypeObjLst_T = gs_ConfigType_GetObjLstByJSONObjLst(arrgs_ConfigTypeExObjLst_Cache);
return arrgs_ConfigTypeObjLst_T;
}
try
{
const arrgs_ConfigTypeExObjLst = await gs_ConfigType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_ConfigTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ConfigTypeExObjLst.length);
console.log(strInfo);
return arrgs_ConfigTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ConfigType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ConfigTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ConfigTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ConfigTypeEN.CacheAddiCondition);
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
const arrgs_ConfigTypeExObjLst_Cache: Array<clsgs_ConfigTypeEN> = JSON.parse(strTempObjLst);
const arrgs_ConfigTypeObjLst_T = gs_ConfigType_GetObjLstByJSONObjLst(arrgs_ConfigTypeExObjLst_Cache);
return arrgs_ConfigTypeObjLst_T;
}
try
{
const arrgs_ConfigTypeExObjLst = await gs_ConfigType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_ConfigTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ConfigTypeExObjLst.length);
console.log(strInfo);
return arrgs_ConfigTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ConfigType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ConfigTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_ConfigTypeObjLst_Cache: Array<clsgs_ConfigTypeEN> = JSON.parse(strTempObjLst);
return arrgs_ConfigTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_ConfigType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_ConfigTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ConfigType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_ConfigTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_ConfigTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_ConfigTypeEN.CacheAddiCondition);
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
const arrgs_ConfigTypeExObjLst_Cache: Array<clsgs_ConfigTypeEN> = JSON.parse(strTempObjLst);
const arrgs_ConfigTypeObjLst_T = gs_ConfigType_GetObjLstByJSONObjLst(arrgs_ConfigTypeExObjLst_Cache);
return arrgs_ConfigTypeObjLst_T;
}
try
{
const arrgs_ConfigTypeExObjLst = await gs_ConfigType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_ConfigTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ConfigTypeExObjLst.length);
console.log(strInfo);
return arrgs_ConfigTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ConfigType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_ConfigTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_ConfigTypeObjLst_Cache: Array<clsgs_ConfigTypeEN> = JSON.parse(strTempObjLst);
return arrgs_ConfigTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ConfigType_GetObjLst_Cache(): Promise<Array<clsgs_ConfigTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_ConfigTypeObjLst_Cache;
switch (clsgs_ConfigTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_ClientCache();
break;
default:
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_ClientCache();
break;
}
const arrgs_ConfigTypeObjLst = gs_ConfigType_GetObjLstByJSONObjLst(arrgs_ConfigTypeObjLst_Cache);
return arrgs_ConfigTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_ConfigType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_ConfigTypeObjLst_Cache;
switch (clsgs_ConfigTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_ConfigTypeObjLst_Cache = null;
break;
default:
arrgs_ConfigTypeObjLst_Cache = null;
break;
}
return arrgs_ConfigTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrConfigTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ConfigType_GetSubObjLst_Cache(objgs_ConfigType_Cond: clsgs_ConfigTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
let arrgs_ConfigType_Sel: Array < clsgs_ConfigTypeEN > = arrgs_ConfigTypeObjLst_Cache;
if (objgs_ConfigType_Cond.sf_FldComparisonOp == null || objgs_ConfigType_Cond.sf_FldComparisonOp == "") return arrgs_ConfigType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ConfigType_Cond.sf_FldComparisonOp);
//console.log("clsgs_ConfigTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ConfigType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ConfigType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ConfigType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_ConfigType_Cond), gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ConfigTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrConfigTypeId:关键字列表
 * @returns 对象列表
 **/
export async function gs_ConfigType_GetObjLstByConfigTypeIdLstAsync(arrConfigTypeId: Array<string>): Promise<Array<clsgs_ConfigTypeEN>>  
{
const strThisFuncName = "GetObjLstByConfigTypeIdLstAsync";
const strAction = "GetObjLstByConfigTypeIdLst";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConfigTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ConfigType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param arrstrConfigTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_ConfigType_GetObjLstByConfigTypeIdLst_Cache(arrConfigTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByConfigTypeIdLst_Cache";
try
{
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
const arrgs_ConfigType_Sel: Array <clsgs_ConfigTypeEN> = arrgs_ConfigTypeObjLst_Cache.filter(x => arrConfigTypeIdLst.indexOf(x.configTypeId)>-1);
return arrgs_ConfigType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrConfigTypeIdLst.join(","), gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_ConfigTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ConfigType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_ConfigTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ConfigType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ConfigTypeEN>();
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
if (arrgs_ConfigTypeObjLst_Cache.length == 0) return arrgs_ConfigTypeObjLst_Cache;
let arrgs_ConfigType_Sel = arrgs_ConfigTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_ConfigType_Cond = new clsgs_ConfigTypeEN();
ObjectAssign(objgs_ConfigType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_ConfigTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ConfigType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ConfigType_Sel.length == 0) return arrgs_ConfigType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.sort(gs_ConfigType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.sort(objPagerPara.sortFun);
}
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.slice(intStart, intEnd);     
return arrgs_ConfigType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_ConfigTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_ConfigType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_ConfigTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_ConfigTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_ConfigType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param strConfigTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_ConfigType_DelRecordAsync(strConfigTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strConfigTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param arrConfigTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_ConfigType_Delgs_ConfigTypesAsync(arrConfigTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_ConfigTypesAsync";
const strAction = "Delgs_ConfigTypes";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrConfigTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_Delgs_ConfigTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_ConfigTypesByCondAsync";
const strAction = "Delgs_ConfigTypesByCond";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ConfigType_AddNewRecordAsync(objgs_ConfigTypeEN: clsgs_ConfigTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_ConfigTypeEN);
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_ConfigType_AddNewRecordWithMaxIdAsync(objgs_ConfigTypeEN: clsgs_ConfigTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_ConfigType_AddNewRecordWithReturnKeyAsync(objgs_ConfigTypeEN: clsgs_ConfigTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_ConfigType_AddNewRecordWithReturnKey(objgs_ConfigTypeEN: clsgs_ConfigTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_ConfigTypeEN.configTypeId === null || objgs_ConfigTypeEN.configTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_ConfigType_UpdateRecordAsync(objgs_ConfigTypeEN: clsgs_ConfigTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_ConfigTypeEN.sfUpdFldSetStr === undefined || objgs_ConfigTypeEN.sfUpdFldSetStr === null || objgs_ConfigTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ConfigTypeEN.configTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_ConfigType_UpdateWithConditionAsync(objgs_ConfigTypeEN: clsgs_ConfigTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_ConfigTypeEN.sfUpdFldSetStr === undefined || objgs_ConfigTypeEN.sfUpdFldSetStr === null || objgs_ConfigTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ConfigTypeEN.configTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
objgs_ConfigTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_ConfigTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objstrConfigTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_ConfigType_IsExistRecord_Cache(objgs_ConfigType_Cond: clsgs_ConfigTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
if (arrgs_ConfigTypeObjLst_Cache == null) return false;
let arrgs_ConfigType_Sel: Array < clsgs_ConfigTypeEN > = arrgs_ConfigTypeObjLst_Cache;
if (objgs_ConfigType_Cond.sf_FldComparisonOp == null || objgs_ConfigType_Cond.sf_FldComparisonOp == "") return arrgs_ConfigType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ConfigType_Cond.sf_FldComparisonOp);
//console.log("clsgs_ConfigTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ConfigType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ConfigType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_ConfigType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_ConfigType_Cond), gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param strConfigTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_ConfigType_IsExist(strConfigTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ConfigTypeId": strConfigTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param strConfigTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_ConfigType_IsExist_Cache(strConfigTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
if (arrgs_ConfigTypeObjLst_Cache == null) return false;
try
{
const arrgs_ConfigType_Sel: Array <clsgs_ConfigTypeEN> = arrgs_ConfigTypeObjLst_Cache.filter(x => x.configTypeId == strConfigTypeId);
if (arrgs_ConfigType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strConfigTypeId, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strConfigTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_ConfigType_IsExistAsync(strConfigTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strConfigTypeId": strConfigTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
 * @param objgs_ConfigType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_ConfigType_GetRecCountByCond_Cache(objgs_ConfigType_Cond: clsgs_ConfigTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_ConfigTypeObjLst_Cache = await gs_ConfigType_GetObjLst_Cache();
if (arrgs_ConfigTypeObjLst_Cache == null) return 0;
let arrgs_ConfigType_Sel: Array < clsgs_ConfigTypeEN > = arrgs_ConfigTypeObjLst_Cache;
if (objgs_ConfigType_Cond.sf_FldComparisonOp == null || objgs_ConfigType_Cond.sf_FldComparisonOp == "") return arrgs_ConfigType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_ConfigType_Cond.sf_FldComparisonOp);
//console.log("clsgs_ConfigTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_ConfigType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_ConfigType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_ConfigType_Sel = arrgs_ConfigType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_ConfigType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_ConfigType_Cond), gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export async function gs_ConfigType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_ConfigType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_ConfigType_ConstructorName, strThisFuncName);
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
export function gs_ConfigType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_ConfigType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_ConfigTypeEN._CurrTabName;
switch (clsgs_ConfigTypeEN.CacheModeId)
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
export function gs_ConfigType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_ConfigTypeEN._CurrTabName;
switch (clsgs_ConfigTypeEN.CacheModeId)
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
export function gs_ConfigType_CheckPropertyNew(pobjgs_ConfigTypeEN: clsgs_ConfigTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeId) == false && GetStrLen(pobjgs_ConfigTypeEN.configTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[配置类型Id(configTypeId)]的长度不能超过2(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.configTypeId)(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeName) == false && GetStrLen(pobjgs_ConfigTypeEN.configTypeName) > 500)
{
 throw new Error("(errid:Watl000059)字段[配置类型名称(configTypeName)]的长度不能超过500(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.configTypeName)(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTable) == false && GetStrLen(pobjgs_ConfigTypeEN.dataTable) > 100)
{
 throw new Error("(errid:Watl000059)字段[数据表(dataTable)]的长度不能超过100(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.dataTable)(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTableId) == false && GetStrLen(pobjgs_ConfigTypeEN.dataTableId) > 50)
{
 throw new Error("(errid:Watl000059)字段[数据表Id(dataTableId)]的长度不能超过50(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.dataTableId)(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.memo) == false && GetStrLen(pobjgs_ConfigTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.memo)(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeId) == false && undefined !== pobjgs_ConfigTypeEN.configTypeId && tzDataType.isString(pobjgs_ConfigTypeEN.configTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[配置类型Id(configTypeId)]的值:[$(pobjgs_ConfigTypeEN.configTypeId)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeName) == false && undefined !== pobjgs_ConfigTypeEN.configTypeName && tzDataType.isString(pobjgs_ConfigTypeEN.configTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[配置类型名称(configTypeName)]的值:[$(pobjgs_ConfigTypeEN.configTypeName)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTable) == false && undefined !== pobjgs_ConfigTypeEN.dataTable && tzDataType.isString(pobjgs_ConfigTypeEN.dataTable) === false)
{
 throw new Error("(errid:Watl000060)字段[数据表(dataTable)]的值:[$(pobjgs_ConfigTypeEN.dataTable)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTableId) == false && undefined !== pobjgs_ConfigTypeEN.dataTableId && tzDataType.isString(pobjgs_ConfigTypeEN.dataTableId) === false)
{
 throw new Error("(errid:Watl000060)字段[数据表Id(dataTableId)]的值:[$(pobjgs_ConfigTypeEN.dataTableId)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.memo) == false && undefined !== pobjgs_ConfigTypeEN.memo && tzDataType.isString(pobjgs_ConfigTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ConfigTypeEN.memo)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_ConfigTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_ConfigType_CheckProperty4Update (pobjgs_ConfigTypeEN: clsgs_ConfigTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeId) == false && GetStrLen(pobjgs_ConfigTypeEN.configTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[配置类型Id(configTypeId)]的长度不能超过2(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.configTypeId)(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeName) == false && GetStrLen(pobjgs_ConfigTypeEN.configTypeName) > 500)
{
 throw new Error("(errid:Watl000062)字段[配置类型名称(configTypeName)]的长度不能超过500(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.configTypeName)(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTable) == false && GetStrLen(pobjgs_ConfigTypeEN.dataTable) > 100)
{
 throw new Error("(errid:Watl000062)字段[数据表(dataTable)]的长度不能超过100(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.dataTable)(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTableId) == false && GetStrLen(pobjgs_ConfigTypeEN.dataTableId) > 50)
{
 throw new Error("(errid:Watl000062)字段[数据表Id(dataTableId)]的长度不能超过50(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.dataTableId)(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.memo) == false && GetStrLen(pobjgs_ConfigTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 配置类型(gs_ConfigType))!值:$(pobjgs_ConfigTypeEN.memo)(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeId) == false && undefined !== pobjgs_ConfigTypeEN.configTypeId && tzDataType.isString(pobjgs_ConfigTypeEN.configTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[配置类型Id(configTypeId)]的值:[$(pobjgs_ConfigTypeEN.configTypeId)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeName) == false && undefined !== pobjgs_ConfigTypeEN.configTypeName && tzDataType.isString(pobjgs_ConfigTypeEN.configTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[配置类型名称(configTypeName)]的值:[$(pobjgs_ConfigTypeEN.configTypeName)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTable) == false && undefined !== pobjgs_ConfigTypeEN.dataTable && tzDataType.isString(pobjgs_ConfigTypeEN.dataTable) === false)
{
 throw new Error("(errid:Watl000063)字段[数据表(dataTable)]的值:[$(pobjgs_ConfigTypeEN.dataTable)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.dataTableId) == false && undefined !== pobjgs_ConfigTypeEN.dataTableId && tzDataType.isString(pobjgs_ConfigTypeEN.dataTableId) === false)
{
 throw new Error("(errid:Watl000063)字段[数据表Id(dataTableId)]的值:[$(pobjgs_ConfigTypeEN.dataTableId)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.memo) == false && undefined !== pobjgs_ConfigTypeEN.memo && tzDataType.isString(pobjgs_ConfigTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ConfigTypeEN.memo)], 非法，应该为字符型(In 配置类型(gs_ConfigType))!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_ConfigTypeEN.configTypeId) === true )
{
 throw new Error("(errid:Watl000064)字段[配置类型Id]不能为空(In 配置类型)!(clsgs_ConfigTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_ConfigTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ConfigType_GetJSONStrByObj (pobjgs_ConfigTypeEN: clsgs_ConfigTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_ConfigTypeEN.sfUpdFldSetStr = pobjgs_ConfigTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_ConfigTypeEN);
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
export function gs_ConfigType_GetObjLstByJSONStr (strJSON: string): Array<clsgs_ConfigTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_ConfigTypeObjLst = new Array<clsgs_ConfigTypeEN>();
if (strJSON === "")
{
return arrgs_ConfigTypeObjLst;
}
try
{
arrgs_ConfigTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_ConfigTypeObjLst;
}
return arrgs_ConfigTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_ConfigTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_ConfigType_GetObjLstByJSONObjLst (arrgs_ConfigTypeObjLstS: Array<clsgs_ConfigTypeEN>): Array<clsgs_ConfigTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_ConfigTypeObjLst = new Array<clsgs_ConfigTypeEN>();
for (const objInFor of arrgs_ConfigTypeObjLstS) {
const obj1 = gs_ConfigType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_ConfigTypeObjLst.push(obj1);
}
return arrgs_ConfigTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_ConfigType_GetObjByJSONStr (strJSON: string): clsgs_ConfigTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_ConfigTypeEN = new clsgs_ConfigTypeEN();
if (strJSON === "")
{
return pobjgs_ConfigTypeEN;
}
try
{
pobjgs_ConfigTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_ConfigTypeEN;
}
return pobjgs_ConfigTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_ConfigType_GetCombineCondition(objgs_ConfigType_Cond: clsgs_ConfigTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_ConfigType_Cond.dicFldComparisonOp, clsgs_ConfigTypeEN.con_ConfigTypeId) == true)
{
const strComparisonOp_ConfigTypeId:string = objgs_ConfigType_Cond.dicFldComparisonOp[clsgs_ConfigTypeEN.con_ConfigTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ConfigTypeEN.con_ConfigTypeId, objgs_ConfigType_Cond.configTypeId, strComparisonOp_ConfigTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ConfigType_Cond.dicFldComparisonOp, clsgs_ConfigTypeEN.con_ConfigTypeName) == true)
{
const strComparisonOp_ConfigTypeName:string = objgs_ConfigType_Cond.dicFldComparisonOp[clsgs_ConfigTypeEN.con_ConfigTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ConfigTypeEN.con_ConfigTypeName, objgs_ConfigType_Cond.configTypeName, strComparisonOp_ConfigTypeName);
}
if (Object.prototype.hasOwnProperty.call(objgs_ConfigType_Cond.dicFldComparisonOp, clsgs_ConfigTypeEN.con_DataTable) == true)
{
const strComparisonOp_DataTable:string = objgs_ConfigType_Cond.dicFldComparisonOp[clsgs_ConfigTypeEN.con_DataTable];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ConfigTypeEN.con_DataTable, objgs_ConfigType_Cond.dataTable, strComparisonOp_DataTable);
}
if (Object.prototype.hasOwnProperty.call(objgs_ConfigType_Cond.dicFldComparisonOp, clsgs_ConfigTypeEN.con_DataTableId) == true)
{
const strComparisonOp_DataTableId:string = objgs_ConfigType_Cond.dicFldComparisonOp[clsgs_ConfigTypeEN.con_DataTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ConfigTypeEN.con_DataTableId, objgs_ConfigType_Cond.dataTableId, strComparisonOp_DataTableId);
}
if (Object.prototype.hasOwnProperty.call(objgs_ConfigType_Cond.dicFldComparisonOp, clsgs_ConfigTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_ConfigType_Cond.dicFldComparisonOp[clsgs_ConfigTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_ConfigTypeEN.con_Memo, objgs_ConfigType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ConfigType(配置类型),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strConfigTypeId: 配置类型Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ConfigType_GetUniCondStr_ConfigTypeId(objgs_ConfigTypeEN: clsgs_ConfigTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ConfigTypeId = '{0}'", objgs_ConfigTypeEN.configTypeId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_ConfigType(配置类型),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strConfigTypeId: 配置类型Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_ConfigType_GetUniCondStr4Update_ConfigTypeId(objgs_ConfigTypeEN: clsgs_ConfigTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ConfigTypeId <> '{0}'", objgs_ConfigTypeEN.configTypeId);
 strWhereCond +=  Format(" and ConfigTypeId = '{0}'", objgs_ConfigTypeEN.configTypeId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_ConfigTypeENS:源对象
 * @param objgs_ConfigTypeENT:目标对象
*/
export function gs_ConfigType_CopyObjTo(objgs_ConfigTypeENS: clsgs_ConfigTypeEN , objgs_ConfigTypeENT: clsgs_ConfigTypeEN ): void 
{
objgs_ConfigTypeENT.configTypeId = objgs_ConfigTypeENS.configTypeId; //配置类型Id
objgs_ConfigTypeENT.configTypeName = objgs_ConfigTypeENS.configTypeName; //配置类型名称
objgs_ConfigTypeENT.dataTable = objgs_ConfigTypeENS.dataTable; //数据表
objgs_ConfigTypeENT.dataTableId = objgs_ConfigTypeENS.dataTableId; //数据表Id
objgs_ConfigTypeENT.memo = objgs_ConfigTypeENS.memo; //备注
objgs_ConfigTypeENT.sfUpdFldSetStr = objgs_ConfigTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_ConfigTypeENS:源对象
 * @param objgs_ConfigTypeENT:目标对象
*/
export function gs_ConfigType_GetObjFromJsonObj(objgs_ConfigTypeENS: clsgs_ConfigTypeEN): clsgs_ConfigTypeEN 
{
 const objgs_ConfigTypeENT: clsgs_ConfigTypeEN = new clsgs_ConfigTypeEN();
ObjectAssign(objgs_ConfigTypeENT, objgs_ConfigTypeENS);
 return objgs_ConfigTypeENT;
}