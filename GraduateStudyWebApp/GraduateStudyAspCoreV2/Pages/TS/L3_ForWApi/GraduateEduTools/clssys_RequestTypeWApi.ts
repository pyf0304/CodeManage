
 /**
 * 类名:clssys_RequestTypeWApi
 * 表名:sys_RequestType(01120727)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:37
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
 * 请求类型表(sys_RequestType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clssys_RequestTypeEN } from "../../L0_Entity/GraduateEduTools/clssys_RequestTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sys_RequestType_Controller = "sys_RequestTypeApi";
 export const sys_RequestType_ConstructorName = "sys_RequestType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strRequestTypeId:关键字
 * @returns 对象
 **/
export async function sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId: string): Promise<clssys_RequestTypeEN|null>  
{
const strThisFuncName = "GetObjByRequestTypeIdAsync";

if (IsNullOrEmpty(strRequestTypeId) == true)
{
  const strMsg = Format("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strRequestTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeIdAsync)", strRequestTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByRequestTypeId";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strRequestTypeId": strRequestTypeId,
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
const objsys_RequestType = sys_RequestType_GetObjFromJsonObj(returnObj);
return objsys_RequestType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param strRequestTypeId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestType_GetObjByRequestTypeId_Cache(strRequestTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByRequestTypeId_Cache";

if (IsNullOrEmpty(strRequestTypeId) == true)
{
  const strMsg = Format("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strRequestTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeId_Cache)", strRequestTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
try
{
const arrsys_RequestType_Sel: Array <clssys_RequestTypeEN> = arrsys_RequestTypeObjLst_Cache.filter(x => 
 x.requestTypeId == strRequestTypeId );
let objsys_RequestType: clssys_RequestTypeEN;
if (arrsys_RequestType_Sel.length > 0)
{
objsys_RequestType = arrsys_RequestType_Sel[0];
return objsys_RequestType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objsys_RequestType_Const = await sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId);
if (objsys_RequestType_Const != null)
{
sys_RequestType_ReFreshThisCache();
return objsys_RequestType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRequestTypeId, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strRequestTypeId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestType_GetObjByRequestTypeId_localStorage(strRequestTypeId: string) {
const strThisFuncName = "GetObjByRequestTypeId_localStorage";

if (IsNullOrEmpty(strRequestTypeId) == true)
{
  const strMsg = Format("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strRequestTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeId_localStorage)", strRequestTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clssys_RequestTypeEN._CurrTabName, strRequestTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objsys_RequestType_Cache: clssys_RequestTypeEN = JSON.parse(strTempObj);
return objsys_RequestType_Cache;
}
try
{
const objsys_RequestType = await sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId);
if (objsys_RequestType != null)
{
localStorage.setItem(strKey, JSON.stringify(objsys_RequestType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objsys_RequestType;
}
return objsys_RequestType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRequestTypeId, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objsys_RequestType:所给的对象
 * @returns 对象
*/
export async function sys_RequestType_UpdateObjInLst_Cache(objsys_RequestType: clssys_RequestTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
const obj = arrsys_RequestTypeObjLst_Cache.find(x => x.requestTableId == objsys_RequestType.requestTableId && x.requestTypeId == objsys_RequestType.requestTypeId);
if (obj != null)
{
objsys_RequestType.requestTypeId = obj.requestTypeId;
ObjectAssign( obj, objsys_RequestType);
}
else
{
arrsys_RequestTypeObjLst_Cache.push(objsys_RequestType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clssys_RequestTypeEN.con_RequestTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clssys_RequestTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clssys_RequestTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strRequestTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objsys_RequestType = await sys_RequestType_GetObjByRequestTypeId_Cache(strRequestTypeId );
if (objsys_RequestType == null) return "";
if (objsys_RequestType.GetFldValue(strOutFldName) == null) return "";
return objsys_RequestType.GetFldValue(strOutFldName).toString();
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
export function sys_RequestType_SortFun_Defa(a:clssys_RequestTypeEN , b:clssys_RequestTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.requestTypeId.localeCompare(b.requestTypeId);
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
export function sys_RequestType_SortFun_Defa_2Fld(a:clssys_RequestTypeEN , b:clssys_RequestTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.requestTypeName == b.requestTypeName) return a.requestTable.localeCompare(b.requestTable);
else return a.requestTypeName.localeCompare(b.requestTypeName);
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
export function sys_RequestType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clssys_RequestTypeEN.con_RequestTypeId:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
return a.requestTypeId.localeCompare(b.requestTypeId);
}
case clssys_RequestTypeEN.con_RequestTypeName:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (a.requestTypeName == null) return -1;
if (b.requestTypeName == null) return 1;
return a.requestTypeName.localeCompare(b.requestTypeName);
}
case clssys_RequestTypeEN.con_RequestTable:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (a.requestTable == null) return -1;
if (b.requestTable == null) return 1;
return a.requestTable.localeCompare(b.requestTable);
}
case clssys_RequestTypeEN.con_RequestTableId:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (a.requestTableId == null) return -1;
if (b.requestTableId == null) return 1;
return a.requestTableId.localeCompare(b.requestTableId);
}
case clssys_RequestTypeEN.con_Memo:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${ sys_RequestType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clssys_RequestTypeEN.con_RequestTypeId:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
return b.requestTypeId.localeCompare(a.requestTypeId);
}
case clssys_RequestTypeEN.con_RequestTypeName:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (b.requestTypeName == null) return -1;
if (a.requestTypeName == null) return 1;
return b.requestTypeName.localeCompare(a.requestTypeName);
}
case clssys_RequestTypeEN.con_RequestTable:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (b.requestTable == null) return -1;
if (a.requestTable == null) return 1;
return b.requestTable.localeCompare(a.requestTable);
}
case clssys_RequestTypeEN.con_RequestTableId:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (b.requestTableId == null) return -1;
if (a.requestTableId == null) return 1;
return b.requestTableId.localeCompare(a.requestTableId);
}
case clssys_RequestTypeEN.con_Memo:
return (a: clssys_RequestTypeEN, b: clssys_RequestTypeEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${ sys_RequestType_ConstructorName}.${ strThisFuncName})`;
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
export async function sys_RequestType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clssys_RequestTypeEN.con_RequestTypeId:
return (obj: clssys_RequestTypeEN) => {
return obj.requestTypeId === value;
}
case clssys_RequestTypeEN.con_RequestTypeName:
return (obj: clssys_RequestTypeEN) => {
return obj.requestTypeName === value;
}
case clssys_RequestTypeEN.con_RequestTable:
return (obj: clssys_RequestTypeEN) => {
return obj.requestTable === value;
}
case clssys_RequestTypeEN.con_RequestTableId:
return (obj: clssys_RequestTypeEN) => {
return obj.requestTableId === value;
}
case clssys_RequestTypeEN.con_Memo:
return (obj: clssys_RequestTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${ sys_RequestType_ConstructorName}.${ strThisFuncName})`;
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
export async function sys_RequestType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clssys_RequestTypeEN.con_RequestTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrsys_RequestType = await sys_RequestType_GetObjLst_Cache();
if (arrsys_RequestType == null) return [];
let arrsys_RequestType_Sel = arrsys_RequestType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrsys_RequestType_Sel.length == 0) return [];
return arrsys_RequestType_Sel.map(x=>x.requestTypeId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function sys_RequestType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetFirstObjAsync(strWhereCond: string): Promise<clssys_RequestTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const objsys_RequestType = sys_RequestType_GetObjFromJsonObj(returnObj);
return objsys_RequestType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestTypeEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrsys_RequestTypeExObjLst_Cache: Array<clssys_RequestTypeEN> = CacheHelper.Get(strKey);
const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
return arrsys_RequestTypeObjLst_T;
}
try
{
const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrsys_RequestTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
console.log(strInfo);
return arrsys_RequestTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestTypeEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestTypeEN.CacheAddiCondition);
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
const arrsys_RequestTypeExObjLst_Cache: Array<clssys_RequestTypeEN> = JSON.parse(strTempObjLst);
const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
return arrsys_RequestTypeObjLst_T;
}
try
{
const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrsys_RequestTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
console.log(strInfo);
return arrsys_RequestTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clssys_RequestTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrsys_RequestTypeObjLst_Cache: Array<clssys_RequestTypeEN> = JSON.parse(strTempObjLst);
return arrsys_RequestTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function sys_RequestType_GetObjLstAsync(strWhereCond: string): Promise<Array<clssys_RequestTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clssys_RequestTypeEN._CurrTabName;
if (IsNullOrEmpty(clssys_RequestTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clssys_RequestTypeEN.CacheAddiCondition);
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
const arrsys_RequestTypeExObjLst_Cache: Array<clssys_RequestTypeEN> = JSON.parse(strTempObjLst);
const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
return arrsys_RequestTypeObjLst_T;
}
try
{
const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrsys_RequestTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
console.log(strInfo);
return arrsys_RequestTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clssys_RequestTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrsys_RequestTypeObjLst_Cache: Array<clssys_RequestTypeEN> = JSON.parse(strTempObjLst);
return arrsys_RequestTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestType_GetObjLst_Cache(): Promise<Array<clssys_RequestTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrsys_RequestTypeObjLst_Cache;
switch (clssys_RequestTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_ClientCache();
break;
default:
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_ClientCache();
break;
}
const arrsys_RequestTypeObjLst = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeObjLst_Cache);
return arrsys_RequestTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function sys_RequestType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrsys_RequestTypeObjLst_Cache;
switch (clssys_RequestTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrsys_RequestTypeObjLst_Cache = null;
break;
default:
arrsys_RequestTypeObjLst_Cache = null;
break;
}
return arrsys_RequestTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrRequestTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function sys_RequestType_GetSubObjLst_Cache(objsys_RequestType_Cond: clssys_RequestTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
let arrsys_RequestType_Sel: Array < clssys_RequestTypeEN > = arrsys_RequestTypeObjLst_Cache;
if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "") return arrsys_RequestType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrsys_RequestType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objsys_RequestType_Cond), sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clssys_RequestTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrRequestTypeId:关键字列表
 * @returns 对象列表
 **/
export async function sys_RequestType_GetObjLstByRequestTypeIdLstAsync(arrRequestTypeId: Array<string>): Promise<Array<clssys_RequestTypeEN>>  
{
const strThisFuncName = "GetObjLstByRequestTypeIdLstAsync";
const strAction = "GetObjLstByRequestTypeIdLst";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrRequestTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param arrstrRequestTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function sys_RequestType_GetObjLstByRequestTypeIdLst_Cache(arrRequestTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByRequestTypeIdLst_Cache";
try
{
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
const arrsys_RequestType_Sel: Array <clssys_RequestTypeEN> = arrsys_RequestTypeObjLst_Cache.filter(x => arrRequestTypeIdLst.indexOf(x.requestTypeId)>-1);
return arrsys_RequestType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrRequestTypeIdLst.join(","), sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clssys_RequestTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clssys_RequestTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clssys_RequestTypeEN>();
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
if (arrsys_RequestTypeObjLst_Cache.length == 0) return arrsys_RequestTypeObjLst_Cache;
let arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objsys_RequestType_Cond = new clssys_RequestTypeEN();
ObjectAssign(objsys_RequestType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clssys_RequestTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrsys_RequestType_Sel.length == 0) return arrsys_RequestType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrsys_RequestType_Sel = arrsys_RequestType_Sel.sort(sys_RequestType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrsys_RequestType_Sel = arrsys_RequestType_Sel.sort(objPagerPara.sortFun);
}
arrsys_RequestType_Sel = arrsys_RequestType_Sel.slice(intStart, intEnd);     
return arrsys_RequestType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clssys_RequestTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function sys_RequestType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clssys_RequestTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clssys_RequestTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sys_RequestType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param strRequestTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function sys_RequestType_DelRecordAsync(strRequestTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strRequestTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param arrRequestTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function sys_RequestType_Delsys_RequestTypesAsync(arrRequestTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delsys_RequestTypesAsync";
const strAction = "Delsys_RequestTypes";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrRequestTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_Delsys_RequestTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delsys_RequestTypesByCondAsync";
const strAction = "Delsys_RequestTypesByCond";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function sys_RequestType_AddNewRecordAsync(objsys_RequestTypeEN: clssys_RequestTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objsys_RequestTypeEN);
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function sys_RequestType_AddNewRecordWithMaxIdAsync(objsys_RequestTypeEN: clssys_RequestTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function sys_RequestType_AddNewRecordWithReturnKeyAsync(objsys_RequestTypeEN: clssys_RequestTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function sys_RequestType_AddNewRecordWithReturnKey(objsys_RequestTypeEN: clssys_RequestTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objsys_RequestTypeEN.requestTypeId === null || objsys_RequestTypeEN.requestTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function sys_RequestType_UpdateRecordAsync(objsys_RequestTypeEN: clssys_RequestTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objsys_RequestTypeEN.sfUpdFldSetStr === undefined || objsys_RequestTypeEN.sfUpdFldSetStr === null || objsys_RequestTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestTypeEN.requestTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function sys_RequestType_UpdateWithConditionAsync(objsys_RequestTypeEN: clssys_RequestTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objsys_RequestTypeEN.sfUpdFldSetStr === undefined || objsys_RequestTypeEN.sfUpdFldSetStr === null || objsys_RequestTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestTypeEN.requestTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
objsys_RequestTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objsys_RequestTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objstrRequestTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function sys_RequestType_IsExistRecord_Cache(objsys_RequestType_Cond: clssys_RequestTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
if (arrsys_RequestTypeObjLst_Cache == null) return false;
let arrsys_RequestType_Sel: Array < clssys_RequestTypeEN > = arrsys_RequestTypeObjLst_Cache;
if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "") return arrsys_RequestType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrsys_RequestType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objsys_RequestType_Cond), sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param strRequestTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function sys_RequestType_IsExist(strRequestTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"RequestTypeId": strRequestTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param strRequestTypeId:所给的关键字
 * @returns 对象
*/
export async function sys_RequestType_IsExist_Cache(strRequestTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
if (arrsys_RequestTypeObjLst_Cache == null) return false;
try
{
const arrsys_RequestType_Sel: Array <clssys_RequestTypeEN> = arrsys_RequestTypeObjLst_Cache.filter(x => x.requestTypeId == strRequestTypeId);
if (arrsys_RequestType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strRequestTypeId, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strRequestTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function sys_RequestType_IsExistAsync(strRequestTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strRequestTypeId": strRequestTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
 * @param objsys_RequestType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function sys_RequestType_GetRecCountByCond_Cache(objsys_RequestType_Cond: clssys_RequestTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
if (arrsys_RequestTypeObjLst_Cache == null) return 0;
let arrsys_RequestType_Sel: Array < clssys_RequestTypeEN > = arrsys_RequestTypeObjLst_Cache;
if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "") return arrsys_RequestType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
//console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objsys_RequestType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrsys_RequestType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objsys_RequestType_Cond), sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export async function sys_RequestType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sys_RequestType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sys_RequestType_ConstructorName, strThisFuncName);
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
export function sys_RequestType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function sys_RequestType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clssys_RequestTypeEN._CurrTabName;
switch (clssys_RequestTypeEN.CacheModeId)
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
export function sys_RequestType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clssys_RequestTypeEN._CurrTabName;
switch (clssys_RequestTypeEN.CacheModeId)
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
export function sys_RequestType_CheckPropertyNew(pobjsys_RequestTypeEN: clssys_RequestTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeId) == false && GetStrLen(pobjsys_RequestTypeEN.requestTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[RequestTypeId(requestTypeId)]的长度不能超过2(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeId)(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeName) == false && GetStrLen(pobjsys_RequestTypeEN.requestTypeName) > 50)
{
 throw new Error("(errid:Watl000059)字段[RequestTypeName(requestTypeName)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeName)(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTable) == false && GetStrLen(pobjsys_RequestTypeEN.requestTable) > 50)
{
 throw new Error("(errid:Watl000059)字段[RequestTable(requestTable)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTable)(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTableId) == false && GetStrLen(pobjsys_RequestTypeEN.requestTableId) > 50)
{
 throw new Error("(errid:Watl000059)字段[RequestTableId(requestTableId)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTableId)(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.memo) == false && GetStrLen(pobjsys_RequestTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.memo)(clssys_RequestTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeId) == false && undefined !== pobjsys_RequestTypeEN.requestTypeId && tzDataType.isString(pobjsys_RequestTypeEN.requestTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestTypeId(requestTypeId)]的值:[$(pobjsys_RequestTypeEN.requestTypeId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeName) == false && undefined !== pobjsys_RequestTypeEN.requestTypeName && tzDataType.isString(pobjsys_RequestTypeEN.requestTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestTypeName(requestTypeName)]的值:[$(pobjsys_RequestTypeEN.requestTypeName)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTable) == false && undefined !== pobjsys_RequestTypeEN.requestTable && tzDataType.isString(pobjsys_RequestTypeEN.requestTable) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestTable(requestTable)]的值:[$(pobjsys_RequestTypeEN.requestTable)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTableId) == false && undefined !== pobjsys_RequestTypeEN.requestTableId && tzDataType.isString(pobjsys_RequestTypeEN.requestTableId) === false)
{
 throw new Error("(errid:Watl000060)字段[RequestTableId(requestTableId)]的值:[$(pobjsys_RequestTypeEN.requestTableId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.memo) == false && undefined !== pobjsys_RequestTypeEN.memo && tzDataType.isString(pobjsys_RequestTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjsys_RequestTypeEN.memo)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjsys_RequestTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function sys_RequestType_CheckProperty4Update (pobjsys_RequestTypeEN: clssys_RequestTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeId) == false && GetStrLen(pobjsys_RequestTypeEN.requestTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[RequestTypeId(requestTypeId)]的长度不能超过2(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeId)(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeName) == false && GetStrLen(pobjsys_RequestTypeEN.requestTypeName) > 50)
{
 throw new Error("(errid:Watl000062)字段[RequestTypeName(requestTypeName)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeName)(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTable) == false && GetStrLen(pobjsys_RequestTypeEN.requestTable) > 50)
{
 throw new Error("(errid:Watl000062)字段[RequestTable(requestTable)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTable)(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTableId) == false && GetStrLen(pobjsys_RequestTypeEN.requestTableId) > 50)
{
 throw new Error("(errid:Watl000062)字段[RequestTableId(requestTableId)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTableId)(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.memo) == false && GetStrLen(pobjsys_RequestTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.memo)(clssys_RequestTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeId) == false && undefined !== pobjsys_RequestTypeEN.requestTypeId && tzDataType.isString(pobjsys_RequestTypeEN.requestTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestTypeId(requestTypeId)]的值:[$(pobjsys_RequestTypeEN.requestTypeId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeName) == false && undefined !== pobjsys_RequestTypeEN.requestTypeName && tzDataType.isString(pobjsys_RequestTypeEN.requestTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestTypeName(requestTypeName)]的值:[$(pobjsys_RequestTypeEN.requestTypeName)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTable) == false && undefined !== pobjsys_RequestTypeEN.requestTable && tzDataType.isString(pobjsys_RequestTypeEN.requestTable) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestTable(requestTable)]的值:[$(pobjsys_RequestTypeEN.requestTable)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTableId) == false && undefined !== pobjsys_RequestTypeEN.requestTableId && tzDataType.isString(pobjsys_RequestTypeEN.requestTableId) === false)
{
 throw new Error("(errid:Watl000063)字段[RequestTableId(requestTableId)]的值:[$(pobjsys_RequestTypeEN.requestTableId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjsys_RequestTypeEN.memo) == false && undefined !== pobjsys_RequestTypeEN.memo && tzDataType.isString(pobjsys_RequestTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjsys_RequestTypeEN.memo)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjsys_RequestTypeEN.requestTypeId) === true )
{
 throw new Error("(errid:Watl000064)字段[RequestTypeId]不能为空(In 请求类型表)!(clssys_RequestTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjsys_RequestTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function sys_RequestType_GetJSONStrByObj (pobjsys_RequestTypeEN: clssys_RequestTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjsys_RequestTypeEN.sfUpdFldSetStr = pobjsys_RequestTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjsys_RequestTypeEN);
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
export function sys_RequestType_GetObjLstByJSONStr (strJSON: string): Array<clssys_RequestTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrsys_RequestTypeObjLst = new Array<clssys_RequestTypeEN>();
if (strJSON === "")
{
return arrsys_RequestTypeObjLst;
}
try
{
arrsys_RequestTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrsys_RequestTypeObjLst;
}
return arrsys_RequestTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrsys_RequestTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function sys_RequestType_GetObjLstByJSONObjLst (arrsys_RequestTypeObjLstS: Array<clssys_RequestTypeEN>): Array<clssys_RequestTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrsys_RequestTypeObjLst = new Array<clssys_RequestTypeEN>();
for (const objInFor of arrsys_RequestTypeObjLstS) {
const obj1 = sys_RequestType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrsys_RequestTypeObjLst.push(obj1);
}
return arrsys_RequestTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function sys_RequestType_GetObjByJSONStr (strJSON: string): clssys_RequestTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjsys_RequestTypeEN = new clssys_RequestTypeEN();
if (strJSON === "")
{
return pobjsys_RequestTypeEN;
}
try
{
pobjsys_RequestTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjsys_RequestTypeEN;
}
return pobjsys_RequestTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function sys_RequestType_GetCombineCondition(objsys_RequestType_Cond: clssys_RequestTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN.con_RequestTypeId) == true)
{
const strComparisonOp_RequestTypeId:string = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN.con_RequestTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestTypeEN.con_RequestTypeId, objsys_RequestType_Cond.requestTypeId, strComparisonOp_RequestTypeId);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN.con_RequestTypeName) == true)
{
const strComparisonOp_RequestTypeName:string = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN.con_RequestTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestTypeEN.con_RequestTypeName, objsys_RequestType_Cond.requestTypeName, strComparisonOp_RequestTypeName);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN.con_RequestTable) == true)
{
const strComparisonOp_RequestTable:string = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN.con_RequestTable];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestTypeEN.con_RequestTable, objsys_RequestType_Cond.requestTable, strComparisonOp_RequestTable);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN.con_RequestTableId) == true)
{
const strComparisonOp_RequestTableId:string = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN.con_RequestTableId];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestTypeEN.con_RequestTableId, objsys_RequestType_Cond.requestTableId, strComparisonOp_RequestTableId);
}
if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clssys_RequestTypeEN.con_Memo, objsys_RequestType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--sys_RequestType(请求类型表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strRequestTableId: RequestTableId(要求唯一的字段)
 * @param strRequestTypeId: RequestTypeId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function sys_RequestType_GetUniCondStr_RequestTableId_RequestTypeId(objsys_RequestTypeEN: clssys_RequestTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and RequestTableId = '{0}'", objsys_RequestTypeEN.requestTableId);
 strWhereCond +=  Format(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.requestTypeId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--sys_RequestType(请求类型表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strRequestTableId: RequestTableId(要求唯一的字段)
 * @param strRequestTypeId: RequestTypeId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function sys_RequestType_GetUniCondStr4Update_RequestTableId_RequestTypeId(objsys_RequestTypeEN: clssys_RequestTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and RequestTypeId <> '{0}'", objsys_RequestTypeEN.requestTypeId);
 strWhereCond +=  Format(" and RequestTableId = '{0}'", objsys_RequestTypeEN.requestTableId);
 strWhereCond +=  Format(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.requestTypeId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objsys_RequestTypeENS:源对象
 * @param objsys_RequestTypeENT:目标对象
*/
export function sys_RequestType_CopyObjTo(objsys_RequestTypeENS: clssys_RequestTypeEN , objsys_RequestTypeENT: clssys_RequestTypeEN ): void 
{
objsys_RequestTypeENT.requestTypeId = objsys_RequestTypeENS.requestTypeId; //RequestTypeId
objsys_RequestTypeENT.requestTypeName = objsys_RequestTypeENS.requestTypeName; //RequestTypeName
objsys_RequestTypeENT.requestTable = objsys_RequestTypeENS.requestTable; //RequestTable
objsys_RequestTypeENT.requestTableId = objsys_RequestTypeENS.requestTableId; //RequestTableId
objsys_RequestTypeENT.memo = objsys_RequestTypeENS.memo; //备注
objsys_RequestTypeENT.sfUpdFldSetStr = objsys_RequestTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objsys_RequestTypeENS:源对象
 * @param objsys_RequestTypeENT:目标对象
*/
export function sys_RequestType_GetObjFromJsonObj(objsys_RequestTypeENS: clssys_RequestTypeEN): clssys_RequestTypeEN 
{
 const objsys_RequestTypeENT: clssys_RequestTypeEN = new clssys_RequestTypeEN();
ObjectAssign(objsys_RequestTypeENT, objsys_RequestTypeENS);
 return objsys_RequestTypeENT;
}