
 /**
 * 类名:clsgs_TdRelaTypeWApi
 * 表名:gs_TdRelaType(01120703)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:48:40
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
 * 总数据关系类型表(gs_TdRelaType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsgs_TdRelaTypeEN } from "../../L0_Entity/GraduateEduTools/clsgs_TdRelaTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TdRelaType_Controller = "gs_TdRelaTypeApi";
 export const gs_TdRelaType_ConstructorName = "gs_TdRelaType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTdRelaTypeId:关键字
 * @returns 对象
 **/
export async function gs_TdRelaType_GetObjByTdRelaTypeIdAsync(strTdRelaTypeId: string): Promise<clsgs_TdRelaTypeEN|null>  
{
const strThisFuncName = "GetObjByTdRelaTypeIdAsync";

if (IsNullOrEmpty(strTdRelaTypeId) == true)
{
  const strMsg = Format("参数:[strTdRelaTypeId]不能为空！(In clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTdRelaTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strTdRelaTypeId]的长度:[{0}]不正确！(clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeIdAsync)", strTdRelaTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTdRelaTypeId";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTdRelaTypeId": strTdRelaTypeId,
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
const objgs_TdRelaType = gs_TdRelaType_GetObjFromJsonObj(returnObj);
return objgs_TdRelaType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param strTdRelaTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_TdRelaType_GetObjByTdRelaTypeId_Cache(strTdRelaTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTdRelaTypeId_Cache";

if (IsNullOrEmpty(strTdRelaTypeId) == true)
{
  const strMsg = Format("参数:[strTdRelaTypeId]不能为空！(In clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTdRelaTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strTdRelaTypeId]的长度:[{0}]不正确！(clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeId_Cache)", strTdRelaTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
try
{
const arrgs_TdRelaType_Sel: Array <clsgs_TdRelaTypeEN> = arrgs_TdRelaTypeObjLst_Cache.filter(x => 
 x.tdRelaTypeId == strTdRelaTypeId );
let objgs_TdRelaType: clsgs_TdRelaTypeEN;
if (arrgs_TdRelaType_Sel.length > 0)
{
objgs_TdRelaType = arrgs_TdRelaType_Sel[0];
return objgs_TdRelaType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objgs_TdRelaType_Const = await gs_TdRelaType_GetObjByTdRelaTypeIdAsync(strTdRelaTypeId);
if (objgs_TdRelaType_Const != null)
{
gs_TdRelaType_ReFreshThisCache();
return objgs_TdRelaType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTdRelaTypeId, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTdRelaTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_TdRelaType_GetObjByTdRelaTypeId_localStorage(strTdRelaTypeId: string) {
const strThisFuncName = "GetObjByTdRelaTypeId_localStorage";

if (IsNullOrEmpty(strTdRelaTypeId) == true)
{
  const strMsg = Format("参数:[strTdRelaTypeId]不能为空！(In clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTdRelaTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strTdRelaTypeId]的长度:[{0}]不正确！(clsgs_TdRelaTypeWApi.GetObjByTdRelaTypeId_localStorage)", strTdRelaTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TdRelaTypeEN._CurrTabName, strTdRelaTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TdRelaType_Cache: clsgs_TdRelaTypeEN = JSON.parse(strTempObj);
return objgs_TdRelaType_Cache;
}
try
{
const objgs_TdRelaType = await gs_TdRelaType_GetObjByTdRelaTypeIdAsync(strTdRelaTypeId);
if (objgs_TdRelaType != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TdRelaType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TdRelaType;
}
return objgs_TdRelaType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTdRelaTypeId, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TdRelaType:所给的对象
 * @returns 对象
*/
export async function gs_TdRelaType_UpdateObjInLst_Cache(objgs_TdRelaType: clsgs_TdRelaTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
const obj = arrgs_TdRelaTypeObjLst_Cache.find(x => x.tdRelaTypeId == objgs_TdRelaType.tdRelaTypeId);
if (obj != null)
{
objgs_TdRelaType.tdRelaTypeId = obj.tdRelaTypeId;
ObjectAssign( obj, objgs_TdRelaType);
}
else
{
arrgs_TdRelaTypeObjLst_Cache.push(objgs_TdRelaType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strTdRelaTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_TdRelaType_GetNameByTdRelaTypeId_Cache(strTdRelaTypeId: string) {
const strThisFuncName = "GetNameByTdRelaTypeId_Cache";

if (IsNullOrEmpty(strTdRelaTypeId) == true)
{
  const strMsg = Format("参数:[strTdRelaTypeId]不能为空！(In clsgs_TdRelaTypeWApi.GetNameByTdRelaTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTdRelaTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strTdRelaTypeId]的长度:[{0}]不正确！(clsgs_TdRelaTypeWApi.GetNameByTdRelaTypeId_Cache)", strTdRelaTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaTypeObjLst_Cache == null) return "";
try
{
const arrgs_TdRelaType_Sel: Array <clsgs_TdRelaTypeEN> = arrgs_TdRelaTypeObjLst_Cache.filter(x => 
 x.tdRelaTypeId == strTdRelaTypeId );
let objgs_TdRelaType: clsgs_TdRelaTypeEN;
if (arrgs_TdRelaType_Sel.length > 0)
{
objgs_TdRelaType = arrgs_TdRelaType_Sel[0];
return objgs_TdRelaType.tdRelaTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strTdRelaTypeId);
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
export async function gs_TdRelaType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_TdRelaTypeEN.con_TdRelaTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TdRelaTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsgs_TdRelaTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTdRelaTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_TdRelaType = await gs_TdRelaType_GetObjByTdRelaTypeId_Cache(strTdRelaTypeId );
if (objgs_TdRelaType == null) return "";
if (objgs_TdRelaType.GetFldValue(strOutFldName) == null) return "";
return objgs_TdRelaType.GetFldValue(strOutFldName).toString();
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
export function gs_TdRelaType_SortFun_Defa(a:clsgs_TdRelaTypeEN , b:clsgs_TdRelaTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.tdRelaTypeId.localeCompare(b.tdRelaTypeId);
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
export function gs_TdRelaType_SortFun_Defa_2Fld(a:clsgs_TdRelaTypeEN , b:clsgs_TdRelaTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.tdRelaTypeName == b.tdRelaTypeName) return a.memo.localeCompare(b.memo);
else return a.tdRelaTypeName.localeCompare(b.tdRelaTypeName);
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
export function gs_TdRelaType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TdRelaTypeEN.con_TdRelaTypeId:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
return a.tdRelaTypeId.localeCompare(b.tdRelaTypeId);
}
case clsgs_TdRelaTypeEN.con_TdRelaTypeName:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
if (a.tdRelaTypeName == null) return -1;
if (b.tdRelaTypeName == null) return 1;
return a.tdRelaTypeName.localeCompare(b.tdRelaTypeName);
}
case clsgs_TdRelaTypeEN.con_Memo:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TdRelaType]中不存在！(in ${ gs_TdRelaType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TdRelaTypeEN.con_TdRelaTypeId:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
return b.tdRelaTypeId.localeCompare(a.tdRelaTypeId);
}
case clsgs_TdRelaTypeEN.con_TdRelaTypeName:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
if (b.tdRelaTypeName == null) return -1;
if (a.tdRelaTypeName == null) return 1;
return b.tdRelaTypeName.localeCompare(a.tdRelaTypeName);
}
case clsgs_TdRelaTypeEN.con_Memo:
return (a: clsgs_TdRelaTypeEN, b: clsgs_TdRelaTypeEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TdRelaType]中不存在！(in ${ gs_TdRelaType_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TdRelaType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TdRelaTypeEN.con_TdRelaTypeId:
return (obj: clsgs_TdRelaTypeEN) => {
return obj.tdRelaTypeId === value;
}
case clsgs_TdRelaTypeEN.con_TdRelaTypeName:
return (obj: clsgs_TdRelaTypeEN) => {
return obj.tdRelaTypeName === value;
}
case clsgs_TdRelaTypeEN.con_Memo:
return (obj: clsgs_TdRelaTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TdRelaType]中不存在！(in ${ gs_TdRelaType_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TdRelaType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsgs_TdRelaTypeEN.con_TdRelaTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrgs_TdRelaType = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaType == null) return [];
let arrgs_TdRelaType_Sel = arrgs_TdRelaType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrgs_TdRelaType_Sel.length == 0) return [];
return arrgs_TdRelaType_Sel.map(x=>x.tdRelaTypeId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TdRelaType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TdRelaTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const objgs_TdRelaType = gs_TdRelaType_GetObjFromJsonObj(returnObj);
return objgs_TdRelaType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_TdRelaTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TdRelaTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TdRelaTypeExObjLst_Cache: Array<clsgs_TdRelaTypeEN> = CacheHelper.Get(strKey);
const arrgs_TdRelaTypeObjLst_T = gs_TdRelaType_GetObjLstByJSONObjLst(arrgs_TdRelaTypeExObjLst_Cache);
return arrgs_TdRelaTypeObjLst_T;
}
try
{
const arrgs_TdRelaTypeExObjLst = await gs_TdRelaType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TdRelaTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TdRelaTypeExObjLst.length);
console.log(strInfo);
return arrgs_TdRelaTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TdRelaType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_TdRelaTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TdRelaTypeEN.CacheAddiCondition);
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
const arrgs_TdRelaTypeExObjLst_Cache: Array<clsgs_TdRelaTypeEN> = JSON.parse(strTempObjLst);
const arrgs_TdRelaTypeObjLst_T = gs_TdRelaType_GetObjLstByJSONObjLst(arrgs_TdRelaTypeExObjLst_Cache);
return arrgs_TdRelaTypeObjLst_T;
}
try
{
const arrgs_TdRelaTypeExObjLst = await gs_TdRelaType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TdRelaTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TdRelaTypeExObjLst.length);
console.log(strInfo);
return arrgs_TdRelaTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TdRelaType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TdRelaTypeObjLst_Cache: Array<clsgs_TdRelaTypeEN> = JSON.parse(strTempObjLst);
return arrgs_TdRelaTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TdRelaType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TdRelaTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
if (IsNullOrEmpty(clsgs_TdRelaTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TdRelaTypeEN.CacheAddiCondition);
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
const arrgs_TdRelaTypeExObjLst_Cache: Array<clsgs_TdRelaTypeEN> = JSON.parse(strTempObjLst);
const arrgs_TdRelaTypeObjLst_T = gs_TdRelaType_GetObjLstByJSONObjLst(arrgs_TdRelaTypeExObjLst_Cache);
return arrgs_TdRelaTypeObjLst_T;
}
try
{
const arrgs_TdRelaTypeExObjLst = await gs_TdRelaType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TdRelaTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TdRelaTypeExObjLst.length);
console.log(strInfo);
return arrgs_TdRelaTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TdRelaType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TdRelaTypeObjLst_Cache: Array<clsgs_TdRelaTypeEN> = JSON.parse(strTempObjLst);
return arrgs_TdRelaTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TdRelaType_GetObjLst_Cache(): Promise<Array<clsgs_TdRelaTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_TdRelaTypeObjLst_Cache;
switch (clsgs_TdRelaTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_ClientCache();
break;
default:
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_ClientCache();
break;
}
const arrgs_TdRelaTypeObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(arrgs_TdRelaTypeObjLst_Cache);
return arrgs_TdRelaTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TdRelaType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TdRelaTypeObjLst_Cache;
switch (clsgs_TdRelaTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_TdRelaTypeObjLst_Cache = null;
break;
default:
arrgs_TdRelaTypeObjLst_Cache = null;
break;
}
return arrgs_TdRelaTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTdRelaTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TdRelaType_GetSubObjLst_Cache(objgs_TdRelaType_Cond: clsgs_TdRelaTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
let arrgs_TdRelaType_Sel: Array < clsgs_TdRelaTypeEN > = arrgs_TdRelaTypeObjLst_Cache;
if (objgs_TdRelaType_Cond.sf_FldComparisonOp == null || objgs_TdRelaType_Cond.sf_FldComparisonOp == "") return arrgs_TdRelaType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TdRelaType_Cond.sf_FldComparisonOp);
//console.log("clsgs_TdRelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TdRelaType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TdRelaType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TdRelaType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TdRelaType_Cond), gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TdRelaTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTdRelaTypeId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TdRelaType_GetObjLstByTdRelaTypeIdLstAsync(arrTdRelaTypeId: Array<string>): Promise<Array<clsgs_TdRelaTypeEN>>  
{
const strThisFuncName = "GetObjLstByTdRelaTypeIdLstAsync";
const strAction = "GetObjLstByTdRelaTypeIdLst";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTdRelaTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param arrstrTdRelaTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_TdRelaType_GetObjLstByTdRelaTypeIdLst_Cache(arrTdRelaTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByTdRelaTypeIdLst_Cache";
try
{
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
const arrgs_TdRelaType_Sel: Array <clsgs_TdRelaTypeEN> = arrgs_TdRelaTypeObjLst_Cache.filter(x => arrTdRelaTypeIdLst.indexOf(x.tdRelaTypeId)>-1);
return arrgs_TdRelaType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTdRelaTypeIdLst.join(","), gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TdRelaTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TdRelaTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_TdRelaTypeEN>();
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaTypeObjLst_Cache.length == 0) return arrgs_TdRelaTypeObjLst_Cache;
let arrgs_TdRelaType_Sel = arrgs_TdRelaTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TdRelaType_Cond = new clsgs_TdRelaTypeEN();
ObjectAssign(objgs_TdRelaType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TdRelaTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TdRelaType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TdRelaType_Sel.length == 0) return arrgs_TdRelaType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.sort(gs_TdRelaType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.sort(objPagerPara.sortFun);
}
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.slice(intStart, intEnd);     
return arrgs_TdRelaType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TdRelaTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TdRelaType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TdRelaTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_TdRelaTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TdRelaType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param strTdRelaTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TdRelaType_DelRecordAsync(strTdRelaTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strTdRelaTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param arrTdRelaTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TdRelaType_Delgs_TdRelaTypesAsync(arrTdRelaTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TdRelaTypesAsync";
const strAction = "Delgs_TdRelaTypes";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTdRelaTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_Delgs_TdRelaTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TdRelaTypesByCondAsync";
const strAction = "Delgs_TdRelaTypesByCond";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TdRelaType_AddNewRecordAsync(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TdRelaTypeEN);
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TdRelaType_AddNewRecordWithMaxIdAsync(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TdRelaType_AddNewRecordWithReturnKeyAsync(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TdRelaType_AddNewRecordWithReturnKey(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TdRelaTypeEN.tdRelaTypeId === null || objgs_TdRelaTypeEN.tdRelaTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TdRelaType_UpdateRecordAsync(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TdRelaTypeEN.sfUpdFldSetStr === undefined || objgs_TdRelaTypeEN.sfUpdFldSetStr === null || objgs_TdRelaTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TdRelaTypeEN.tdRelaTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TdRelaType_UpdateWithConditionAsync(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TdRelaTypeEN.sfUpdFldSetStr === undefined || objgs_TdRelaTypeEN.sfUpdFldSetStr === null || objgs_TdRelaTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TdRelaTypeEN.tdRelaTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
objgs_TdRelaTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TdRelaTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objstrTdRelaTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TdRelaType_IsExistRecord_Cache(objgs_TdRelaType_Cond: clsgs_TdRelaTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaTypeObjLst_Cache == null) return false;
let arrgs_TdRelaType_Sel: Array < clsgs_TdRelaTypeEN > = arrgs_TdRelaTypeObjLst_Cache;
if (objgs_TdRelaType_Cond.sf_FldComparisonOp == null || objgs_TdRelaType_Cond.sf_FldComparisonOp == "") return arrgs_TdRelaType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TdRelaType_Cond.sf_FldComparisonOp);
//console.log("clsgs_TdRelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TdRelaType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TdRelaType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TdRelaType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TdRelaType_Cond), gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param strTdRelaTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TdRelaType_IsExist(strTdRelaTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TdRelaTypeId": strTdRelaTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param strTdRelaTypeId:所给的关键字
 * @returns 对象
*/
export async function gs_TdRelaType_IsExist_Cache(strTdRelaTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaTypeObjLst_Cache == null) return false;
try
{
const arrgs_TdRelaType_Sel: Array <clsgs_TdRelaTypeEN> = arrgs_TdRelaTypeObjLst_Cache.filter(x => x.tdRelaTypeId == strTdRelaTypeId);
if (arrgs_TdRelaType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTdRelaTypeId, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTdRelaTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TdRelaType_IsExistAsync(strTdRelaTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTdRelaTypeId": strTdRelaTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
 * @param objgs_TdRelaType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TdRelaType_GetRecCountByCond_Cache(objgs_TdRelaType_Cond: clsgs_TdRelaTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TdRelaTypeObjLst_Cache = await gs_TdRelaType_GetObjLst_Cache();
if (arrgs_TdRelaTypeObjLst_Cache == null) return 0;
let arrgs_TdRelaType_Sel: Array < clsgs_TdRelaTypeEN > = arrgs_TdRelaTypeObjLst_Cache;
if (objgs_TdRelaType_Cond.sf_FldComparisonOp == null || objgs_TdRelaType_Cond.sf_FldComparisonOp == "") return arrgs_TdRelaType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TdRelaType_Cond.sf_FldComparisonOp);
//console.log("clsgs_TdRelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TdRelaType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TdRelaType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TdRelaType_Sel = arrgs_TdRelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TdRelaType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TdRelaType_Cond), gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export async function gs_TdRelaType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TdRelaType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TdRelaType_ConstructorName, strThisFuncName);
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
export function gs_TdRelaType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TdRelaType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
switch (clsgs_TdRelaTypeEN.CacheModeId)
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
export function gs_TdRelaType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_TdRelaTypeEN._CurrTabName;
switch (clsgs_TdRelaTypeEN.CacheModeId)
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
export async function gs_TdRelaType_BindDdl_TDRelaTypeIdInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_TDRelaTypeIdInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_TDRelaTypeIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_TDRelaTypeIdInDiv_Cache");
const arrObjLst_Sel = await gs_TdRelaType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsgs_TdRelaTypeEN.con_TdRelaTypeId, clsgs_TdRelaTypeEN.con_TdRelaTypeName, "总数据关系类型表");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TdRelaType_CheckPropertyNew(pobjgs_TdRelaTypeEN: clsgs_TdRelaTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeId) == false && GetStrLen(pobjgs_TdRelaTypeEN.tdRelaTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.tdRelaTypeId)(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeName) == false && GetStrLen(pobjgs_TdRelaTypeEN.tdRelaTypeName) > 500)
{
 throw new Error("(errid:Watl000059)字段[总数据类型名称(tdRelaTypeName)]的长度不能超过500(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.tdRelaTypeName)(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.memo) == false && GetStrLen(pobjgs_TdRelaTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.memo)(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeId) == false && undefined !== pobjgs_TdRelaTypeEN.tdRelaTypeId && tzDataType.isString(pobjgs_TdRelaTypeEN.tdRelaTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TdRelaTypeEN.tdRelaTypeId)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeName) == false && undefined !== pobjgs_TdRelaTypeEN.tdRelaTypeName && tzDataType.isString(pobjgs_TdRelaTypeEN.tdRelaTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[总数据类型名称(tdRelaTypeName)]的值:[$(pobjgs_TdRelaTypeEN.tdRelaTypeName)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.memo) == false && undefined !== pobjgs_TdRelaTypeEN.memo && tzDataType.isString(pobjgs_TdRelaTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TdRelaTypeEN.memo)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TdRelaTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TdRelaType_CheckProperty4Update (pobjgs_TdRelaTypeEN: clsgs_TdRelaTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeId) == false && GetStrLen(pobjgs_TdRelaTypeEN.tdRelaTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.tdRelaTypeId)(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeName) == false && GetStrLen(pobjgs_TdRelaTypeEN.tdRelaTypeName) > 500)
{
 throw new Error("(errid:Watl000062)字段[总数据类型名称(tdRelaTypeName)]的长度不能超过500(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.tdRelaTypeName)(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.memo) == false && GetStrLen(pobjgs_TdRelaTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 总数据关系类型表(gs_TdRelaType))!值:$(pobjgs_TdRelaTypeEN.memo)(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeId) == false && undefined !== pobjgs_TdRelaTypeEN.tdRelaTypeId && tzDataType.isString(pobjgs_TdRelaTypeEN.tdRelaTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TdRelaTypeEN.tdRelaTypeId)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeName) == false && undefined !== pobjgs_TdRelaTypeEN.tdRelaTypeName && tzDataType.isString(pobjgs_TdRelaTypeEN.tdRelaTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[总数据类型名称(tdRelaTypeName)]的值:[$(pobjgs_TdRelaTypeEN.tdRelaTypeName)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.memo) == false && undefined !== pobjgs_TdRelaTypeEN.memo && tzDataType.isString(pobjgs_TdRelaTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TdRelaTypeEN.memo)], 非法，应该为字符型(In 总数据关系类型表(gs_TdRelaType))!(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TdRelaTypeEN.tdRelaTypeId) === true )
{
 throw new Error("(errid:Watl000064)字段[总数据关系类型Id]不能为空(In 总数据关系类型表)!(clsgs_TdRelaTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TdRelaTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TdRelaType_GetJSONStrByObj (pobjgs_TdRelaTypeEN: clsgs_TdRelaTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TdRelaTypeEN.sfUpdFldSetStr = pobjgs_TdRelaTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TdRelaTypeEN);
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
export function gs_TdRelaType_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TdRelaTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TdRelaTypeObjLst = new Array<clsgs_TdRelaTypeEN>();
if (strJSON === "")
{
return arrgs_TdRelaTypeObjLst;
}
try
{
arrgs_TdRelaTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TdRelaTypeObjLst;
}
return arrgs_TdRelaTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TdRelaTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TdRelaType_GetObjLstByJSONObjLst (arrgs_TdRelaTypeObjLstS: Array<clsgs_TdRelaTypeEN>): Array<clsgs_TdRelaTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TdRelaTypeObjLst = new Array<clsgs_TdRelaTypeEN>();
for (const objInFor of arrgs_TdRelaTypeObjLstS) {
const obj1 = gs_TdRelaType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TdRelaTypeObjLst.push(obj1);
}
return arrgs_TdRelaTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TdRelaType_GetObjByJSONStr (strJSON: string): clsgs_TdRelaTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TdRelaTypeEN = new clsgs_TdRelaTypeEN();
if (strJSON === "")
{
return pobjgs_TdRelaTypeEN;
}
try
{
pobjgs_TdRelaTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TdRelaTypeEN;
}
return pobjgs_TdRelaTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TdRelaType_GetCombineCondition(objgs_TdRelaType_Cond: clsgs_TdRelaTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TdRelaType_Cond.dicFldComparisonOp, clsgs_TdRelaTypeEN.con_TdRelaTypeId) == true)
{
const strComparisonOp_TdRelaTypeId:string = objgs_TdRelaType_Cond.dicFldComparisonOp[clsgs_TdRelaTypeEN.con_TdRelaTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TdRelaTypeEN.con_TdRelaTypeId, objgs_TdRelaType_Cond.tdRelaTypeId, strComparisonOp_TdRelaTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TdRelaType_Cond.dicFldComparisonOp, clsgs_TdRelaTypeEN.con_TdRelaTypeName) == true)
{
const strComparisonOp_TdRelaTypeName:string = objgs_TdRelaType_Cond.dicFldComparisonOp[clsgs_TdRelaTypeEN.con_TdRelaTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TdRelaTypeEN.con_TdRelaTypeName, objgs_TdRelaType_Cond.tdRelaTypeName, strComparisonOp_TdRelaTypeName);
}
if (Object.prototype.hasOwnProperty.call(objgs_TdRelaType_Cond.dicFldComparisonOp, clsgs_TdRelaTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TdRelaType_Cond.dicFldComparisonOp[clsgs_TdRelaTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TdRelaTypeEN.con_Memo, objgs_TdRelaType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TdRelaType(总数据关系类型表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTdRelaTypeId: 总数据关系类型Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TdRelaType_GetUniCondStr_TDRelaTypeId(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TdRelaTypeId = '{0}'", objgs_TdRelaTypeEN.tdRelaTypeId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TdRelaType(总数据关系类型表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTdRelaTypeId: 总数据关系类型Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TdRelaType_GetUniCondStr4Update_TDRelaTypeId(objgs_TdRelaTypeEN: clsgs_TdRelaTypeEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TdRelaTypeId <> '{0}'", objgs_TdRelaTypeEN.tdRelaTypeId);
 strWhereCond +=  Format(" and TdRelaTypeId = '{0}'", objgs_TdRelaTypeEN.tdRelaTypeId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TdRelaTypeENS:源对象
 * @param objgs_TdRelaTypeENT:目标对象
*/
export function gs_TdRelaType_CopyObjTo(objgs_TdRelaTypeENS: clsgs_TdRelaTypeEN , objgs_TdRelaTypeENT: clsgs_TdRelaTypeEN ): void 
{
objgs_TdRelaTypeENT.tdRelaTypeId = objgs_TdRelaTypeENS.tdRelaTypeId; //总数据关系类型Id
objgs_TdRelaTypeENT.tdRelaTypeName = objgs_TdRelaTypeENS.tdRelaTypeName; //总数据类型名称
objgs_TdRelaTypeENT.memo = objgs_TdRelaTypeENS.memo; //备注
objgs_TdRelaTypeENT.sfUpdFldSetStr = objgs_TdRelaTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TdRelaTypeENS:源对象
 * @param objgs_TdRelaTypeENT:目标对象
*/
export function gs_TdRelaType_GetObjFromJsonObj(objgs_TdRelaTypeENS: clsgs_TdRelaTypeEN): clsgs_TdRelaTypeEN 
{
 const objgs_TdRelaTypeENT: clsgs_TdRelaTypeEN = new clsgs_TdRelaTypeEN();
ObjectAssign(objgs_TdRelaTypeENT, objgs_TdRelaTypeENS);
 return objgs_TdRelaTypeENT;
}