
 /**
 * 类名:clsRsStuTypeWApi
 * 表名:RsStuType(01120162)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:50:35
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:成长档案(EPortfolio)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 学生类别(RsStuType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsRsStuTypeEN } from "../../L0_Entity/EPortfolio/clsRsStuTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const rsStuType_Controller = "RsStuTypeApi";
 export const rsStuType_ConstructorName = "rsStuType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_StuType:关键字
 * @returns 对象
 **/
export async function RsStuType_GetObjByid_StuTypeAsync(strid_StuType: string): Promise<clsRsStuTypeEN|null>  
{
const strThisFuncName = "GetObjByid_StuTypeAsync";

if (IsNullOrEmpty(strid_StuType) == true)
{
  const strMsg = Format("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuTypeAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StuType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuTypeAsync)", strid_StuType.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_StuType";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_StuType": strid_StuType,
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
const objRsStuType = RsStuType_GetObjFromJsonObj(returnObj);
return objRsStuType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param strid_StuType:所给的关键字
 * @returns 对象
*/
export async function RsStuType_GetObjByid_StuType_Cache(strid_StuType: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_StuType_Cache";

if (IsNullOrEmpty(strid_StuType) == true)
{
  const strMsg = Format("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuType_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StuType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuType_Cache)", strid_StuType.length);
console.error(strMsg);
throw (strMsg);
}
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
try
{
const arrRsStuType_Sel: Array <clsRsStuTypeEN> = arrRsStuTypeObjLst_Cache.filter(x => 
 x.id_StuType == strid_StuType );
let objRsStuType: clsRsStuTypeEN;
if (arrRsStuType_Sel.length > 0)
{
objRsStuType = arrRsStuType_Sel[0];
return objRsStuType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objRsStuType_Const = await RsStuType_GetObjByid_StuTypeAsync(strid_StuType);
if (objRsStuType_Const != null)
{
RsStuType_ReFreshThisCache();
return objRsStuType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StuType, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_StuType:所给的关键字
 * @returns 对象
*/
export async function RsStuType_GetObjByid_StuType_localStorage(strid_StuType: string) {
const strThisFuncName = "GetObjByid_StuType_localStorage";

if (IsNullOrEmpty(strid_StuType) == true)
{
  const strMsg = Format("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuType_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StuType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuType_localStorage)", strid_StuType.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsRsStuTypeEN._CurrTabName, strid_StuType);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objRsStuType_Cache: clsRsStuTypeEN = JSON.parse(strTempObj);
return objRsStuType_Cache;
}
try
{
const objRsStuType = await RsStuType_GetObjByid_StuTypeAsync(strid_StuType);
if (objRsStuType != null)
{
localStorage.setItem(strKey, JSON.stringify(objRsStuType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objRsStuType;
}
return objRsStuType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StuType, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objRsStuType:所给的对象
 * @returns 对象
*/
export async function RsStuType_UpdateObjInLst_Cache(objRsStuType: clsRsStuTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
const obj = arrRsStuTypeObjLst_Cache.find(x => 
x.id_StuType == objRsStuType.id_StuType);
if (obj != null)
{
objRsStuType.id_StuType = obj.id_StuType;
ObjectAssign( obj, objRsStuType);
}
else
{
arrRsStuTypeObjLst_Cache.push(objRsStuType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_StuType:所给的关键字
 * @returns 对象
*/
export async function RsStuType_GetNameByid_StuType_Cache(strid_StuType: string) {
const strThisFuncName = "GetNameByid_StuType_Cache";

if (IsNullOrEmpty(strid_StuType) == true)
{
  const strMsg = Format("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetNameByid_StuType_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StuType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetNameByid_StuType_Cache)", strid_StuType.length);
console.error(strMsg);
throw (strMsg);
}
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
if (arrRsStuTypeObjLst_Cache == null) return "";
try
{
const arrRsStuType_Sel: Array <clsRsStuTypeEN> = arrRsStuTypeObjLst_Cache.filter(x => 
 x.id_StuType == strid_StuType );
let objRsStuType: clsRsStuTypeEN;
if (arrRsStuType_Sel.length > 0)
{
objRsStuType = arrRsStuType_Sel[0];
return objRsStuType.stuTypeDesc;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_StuType);
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
export async function RsStuType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsRsStuTypeEN.con_id_StuType)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsRsStuTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsRsStuTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_StuType = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objRsStuType = await RsStuType_GetObjByid_StuType_Cache(strid_StuType );
if (objRsStuType == null) return "";
if (objRsStuType.GetFldValue(strOutFldName) == null) return "";
return objRsStuType.GetFldValue(strOutFldName).toString();
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
export function RsStuType_SortFun_Defa(a:clsRsStuTypeEN , b:clsRsStuTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_StuType.localeCompare(b.id_StuType);
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
export function RsStuType_SortFun_Defa_2Fld(a:clsRsStuTypeEN , b:clsRsStuTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.stuTypeID == b.stuTypeID) return a.stuTypeDesc.localeCompare(b.stuTypeDesc);
else return a.stuTypeID.localeCompare(b.stuTypeID);
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
export function RsStuType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsRsStuTypeEN.con_id_StuType:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return a.id_StuType.localeCompare(b.id_StuType);
}
case clsRsStuTypeEN.con_StuTypeID:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return a.stuTypeID.localeCompare(b.stuTypeID);
}
case clsRsStuTypeEN.con_StuTypeDesc:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return a.stuTypeDesc.localeCompare(b.stuTypeDesc);
}
case clsRsStuTypeEN.con_ModifyDate:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (a.modifyDate == null) return -1;
if (b.modifyDate == null) return 1;
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsRsStuTypeEN.con_ModifyUserID:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (a.modifyUserID == null) return -1;
if (b.modifyUserID == null) return 1;
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsRsStuTypeEN.con_SpecUniLenDesc:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (a.specUniLenDesc == null) return -1;
if (b.specUniLenDesc == null) return 1;
return a.specUniLenDesc.localeCompare(b.specUniLenDesc);
}
case clsRsStuTypeEN.con_Memo:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${ rsStuType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsRsStuTypeEN.con_id_StuType:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return b.id_StuType.localeCompare(a.id_StuType);
}
case clsRsStuTypeEN.con_StuTypeID:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return b.stuTypeID.localeCompare(a.stuTypeID);
}
case clsRsStuTypeEN.con_StuTypeDesc:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
return b.stuTypeDesc.localeCompare(a.stuTypeDesc);
}
case clsRsStuTypeEN.con_ModifyDate:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (b.modifyDate == null) return -1;
if (a.modifyDate == null) return 1;
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsRsStuTypeEN.con_ModifyUserID:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (b.modifyUserID == null) return -1;
if (a.modifyUserID == null) return 1;
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsRsStuTypeEN.con_SpecUniLenDesc:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (b.specUniLenDesc == null) return -1;
if (a.specUniLenDesc == null) return 1;
return b.specUniLenDesc.localeCompare(a.specUniLenDesc);
}
case clsRsStuTypeEN.con_Memo:
return (a: clsRsStuTypeEN, b: clsRsStuTypeEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${ rsStuType_ConstructorName}.${ strThisFuncName})`;
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
export async function RsStuType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsRsStuTypeEN.con_id_StuType:
return (obj: clsRsStuTypeEN) => {
return obj.id_StuType === value;
}
case clsRsStuTypeEN.con_StuTypeID:
return (obj: clsRsStuTypeEN) => {
return obj.stuTypeID === value;
}
case clsRsStuTypeEN.con_StuTypeDesc:
return (obj: clsRsStuTypeEN) => {
return obj.stuTypeDesc === value;
}
case clsRsStuTypeEN.con_ModifyDate:
return (obj: clsRsStuTypeEN) => {
return obj.modifyDate === value;
}
case clsRsStuTypeEN.con_ModifyUserID:
return (obj: clsRsStuTypeEN) => {
return obj.modifyUserID === value;
}
case clsRsStuTypeEN.con_SpecUniLenDesc:
return (obj: clsRsStuTypeEN) => {
return obj.specUniLenDesc === value;
}
case clsRsStuTypeEN.con_Memo:
return (obj: clsRsStuTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${ rsStuType_ConstructorName}.${ strThisFuncName})`;
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
export async function RsStuType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsRsStuTypeEN.con_id_StuType)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrRsStuType = await RsStuType_GetObjLst_Cache();
if (arrRsStuType == null) return [];
let arrRsStuType_Sel = arrRsStuType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrRsStuType_Sel.length == 0) return [];
return arrRsStuType_Sel.map(x=>x.id_StuType);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function RsStuType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetFirstObjAsync(strWhereCond: string): Promise<clsRsStuTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const objRsStuType = RsStuType_GetObjFromJsonObj(returnObj);
return objRsStuType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRsStuTypeEN._CurrTabName;
if (IsNullOrEmpty(clsRsStuTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRsStuTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrRsStuTypeExObjLst_Cache: Array<clsRsStuTypeEN> = CacheHelper.Get(strKey);
const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
return arrRsStuTypeObjLst_T;
}
try
{
const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrRsStuTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
console.log(strInfo);
return arrRsStuTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RsStuType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRsStuTypeEN._CurrTabName;
if (IsNullOrEmpty(clsRsStuTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRsStuTypeEN.CacheAddiCondition);
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
const arrRsStuTypeExObjLst_Cache: Array<clsRsStuTypeEN> = JSON.parse(strTempObjLst);
const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
return arrRsStuTypeObjLst_T;
}
try
{
const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrRsStuTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
console.log(strInfo);
return arrRsStuTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RsStuType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRsStuTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrRsStuTypeObjLst_Cache: Array<clsRsStuTypeEN> = JSON.parse(strTempObjLst);
return arrRsStuTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function RsStuType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsRsStuTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rsStuType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsRsStuTypeEN._CurrTabName;
if (IsNullOrEmpty(clsRsStuTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsRsStuTypeEN.CacheAddiCondition);
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
const arrRsStuTypeExObjLst_Cache: Array<clsRsStuTypeEN> = JSON.parse(strTempObjLst);
const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
return arrRsStuTypeObjLst_T;
}
try
{
const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrRsStuTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
console.log(strInfo);
return arrRsStuTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RsStuType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsRsStuTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrRsStuTypeObjLst_Cache: Array<clsRsStuTypeEN> = JSON.parse(strTempObjLst);
return arrRsStuTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RsStuType_GetObjLst_Cache(): Promise<Array<clsRsStuTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrRsStuTypeObjLst_Cache;
switch (clsRsStuTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_ClientCache();
break;
default:
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_ClientCache();
break;
}
const arrRsStuTypeObjLst = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeObjLst_Cache);
return arrRsStuTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function RsStuType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrRsStuTypeObjLst_Cache;
switch (clsRsStuTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrRsStuTypeObjLst_Cache = null;
break;
default:
arrRsStuTypeObjLst_Cache = null;
break;
}
return arrRsStuTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_StuType_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RsStuType_GetSubObjLst_Cache(objRsStuType_Cond: clsRsStuTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
let arrRsStuType_Sel: Array < clsRsStuTypeEN > = arrRsStuTypeObjLst_Cache;
if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "") return arrRsStuType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
//console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRsStuType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRsStuType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRsStuType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objRsStuType_Cond), rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRsStuTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_StuType:关键字列表
 * @returns 对象列表
 **/
export async function RsStuType_GetObjLstByid_StuTypeLstAsync(arrid_StuType: Array<string>): Promise<Array<clsRsStuTypeEN>>  
{
const strThisFuncName = "GetObjLstByid_StuTypeLstAsync";
const strAction = "GetObjLstByid_StuTypeLst";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_StuType);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rsStuType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param arrstrid_StuTypeLst:关键字列表
 * @returns 对象列表
*/
export async function RsStuType_GetObjLstByid_StuTypeLst_Cache(arrid_StuTypeLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_StuTypeLst_Cache";
try
{
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
const arrRsStuType_Sel: Array <clsRsStuTypeEN> = arrRsStuTypeObjLst_Cache.filter(x => arrid_StuTypeLst.indexOf(x.id_StuType)>-1);
return arrRsStuType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_StuTypeLst.join(","), rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsRsStuTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rsStuType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsRsStuTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rsStuType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsRsStuTypeEN>();
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
if (arrRsStuTypeObjLst_Cache.length == 0) return arrRsStuTypeObjLst_Cache;
let arrRsStuType_Sel = arrRsStuTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objRsStuType_Cond = new clsRsStuTypeEN();
ObjectAssign(objRsStuType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsRsStuTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRsStuType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRsStuType_Sel.length == 0) return arrRsStuType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrRsStuType_Sel = arrRsStuType_Sel.sort(RsStuType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrRsStuType_Sel = arrRsStuType_Sel.sort(objPagerPara.sortFun);
}
arrRsStuType_Sel = arrRsStuType_Sel.slice(intStart, intEnd);     
return arrRsStuType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsRsStuTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function RsStuType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsRsStuTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsRsStuTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", rsStuType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param strid_StuType:关键字
 * @returns 获取删除的结果
 **/
export async function RsStuType_DelRecordAsync(strid_StuType: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_StuType);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param arrid_StuType:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function RsStuType_DelRsStuTypesAsync(arrid_StuType: Array<string>): Promise<number> 
{
const strThisFuncName = "DelRsStuTypesAsync";
const strAction = "DelRsStuTypes";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_StuType);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_DelRsStuTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelRsStuTypesByCondAsync";
const strAction = "DelRsStuTypesByCond";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RsStuType_AddNewRecordAsync(objRsStuTypeEN: clsRsStuTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objRsStuTypeEN.id_StuType === null || objRsStuTypeEN.id_StuType === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objRsStuTypeEN);
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function RsStuType_AddNewRecordWithMaxIdAsync(objRsStuTypeEN: clsRsStuTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function RsStuType_AddNewRecordWithReturnKeyAsync(objRsStuTypeEN: clsRsStuTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function RsStuType_AddNewRecordWithReturnKey(objRsStuTypeEN: clsRsStuTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objRsStuTypeEN.id_StuType === null || objRsStuTypeEN.id_StuType === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function RsStuType_UpdateRecordAsync(objRsStuTypeEN: clsRsStuTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objRsStuTypeEN.sfUpdFldSetStr === undefined || objRsStuTypeEN.sfUpdFldSetStr === null || objRsStuTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRsStuTypeEN.id_StuType);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function RsStuType_UpdateWithConditionAsync(objRsStuTypeEN: clsRsStuTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objRsStuTypeEN.sfUpdFldSetStr === undefined || objRsStuTypeEN.sfUpdFldSetStr === null || objRsStuTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRsStuTypeEN.id_StuType);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
objRsStuTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objRsStuTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objstrid_StuType_Cond:条件对象
 * @returns 对象列表子集
*/
export async function RsStuType_IsExistRecord_Cache(objRsStuType_Cond: clsRsStuTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
if (arrRsStuTypeObjLst_Cache == null) return false;
let arrRsStuType_Sel: Array < clsRsStuTypeEN > = arrRsStuTypeObjLst_Cache;
if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "") return arrRsStuType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
//console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRsStuType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRsStuType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrRsStuType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objRsStuType_Cond), rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param strid_StuType:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function RsStuType_IsExist(strid_StuType: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_StuType": strid_StuType,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param strid_StuType:所给的关键字
 * @returns 对象
*/
export async function RsStuType_IsExist_Cache(strid_StuType:string) {
const strThisFuncName = "IsExist_Cache";
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
if (arrRsStuTypeObjLst_Cache == null) return false;
try
{
const arrRsStuType_Sel: Array <clsRsStuTypeEN> = arrRsStuTypeObjLst_Cache.filter(x => x.id_StuType == strid_StuType);
if (arrRsStuType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_StuType, rsStuType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_StuType:关键字
 * @returns 是否存在?存在返回True
 **/
export async function RsStuType_IsExistAsync(strid_StuType: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_StuType": strid_StuType }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
 * @param objRsStuType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function RsStuType_GetRecCountByCond_Cache(objRsStuType_Cond: clsRsStuTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
if (arrRsStuTypeObjLst_Cache == null) return 0;
let arrRsStuType_Sel: Array < clsRsStuTypeEN > = arrRsStuTypeObjLst_Cache;
if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "") return arrRsStuType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
//console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objRsStuType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objRsStuType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrRsStuType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objRsStuType_Cond), rsStuType_ConstructorName, strThisFuncName);
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
export async function RsStuType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(rsStuType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, rsStuType_ConstructorName, strThisFuncName);
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
export function RsStuType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function RsStuType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsRsStuTypeEN._CurrTabName;
switch (clsRsStuTypeEN.CacheModeId)
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
export function RsStuType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsRsStuTypeEN._CurrTabName;
switch (clsRsStuTypeEN.CacheModeId)
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
export async function RsStuType_BindDdl_id_StuTypeInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_StuTypeInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_StuTypeInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_StuTypeInDiv_Cache");
const arrObjLst_Sel = await RsStuType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsRsStuTypeEN.con_id_StuType, clsRsStuTypeEN.con_StuTypeDesc, "学生类别");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RsStuType_CheckPropertyNew(pobjRsStuTypeEN: clsRsStuTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeID) === true )
{
 throw new Error("(errid:Watl000058)字段[学生类别ID]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeDesc) === true )
{
 throw new Error("(errid:Watl000058)字段[学生类别名称]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRsStuTypeEN.id_StuType) == false && GetStrLen(pobjRsStuTypeEN.id_StuType) > 4)
{
 throw new Error("(errid:Watl000059)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.id_StuType)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeID) == false && GetStrLen(pobjRsStuTypeEN.stuTypeID) > 4)
{
 throw new Error("(errid:Watl000059)字段[学生类别ID(stuTypeID)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeID)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeDesc) == false && GetStrLen(pobjRsStuTypeEN.stuTypeDesc) > 50)
{
 throw new Error("(errid:Watl000059)字段[学生类别名称(stuTypeDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeDesc)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyDate) == false && GetStrLen(pobjRsStuTypeEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyDate)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyUserID) == false && GetStrLen(pobjRsStuTypeEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyUserID)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.specUniLenDesc) == false && GetStrLen(pobjRsStuTypeEN.specUniLenDesc) > 50)
{
 throw new Error("(errid:Watl000059)字段[SpecUniLenDesc(specUniLenDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.specUniLenDesc)(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.memo) == false && GetStrLen(pobjRsStuTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.memo)(clsRsStuTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjRsStuTypeEN.id_StuType) == false && undefined !== pobjRsStuTypeEN.id_StuType && tzDataType.isString(pobjRsStuTypeEN.id_StuType) === false)
{
 throw new Error("(errid:Watl000060)字段[学生类别流水号(id_StuType)]的值:[$(pobjRsStuTypeEN.id_StuType)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeID) == false && undefined !== pobjRsStuTypeEN.stuTypeID && tzDataType.isString(pobjRsStuTypeEN.stuTypeID) === false)
{
 throw new Error("(errid:Watl000060)字段[学生类别ID(stuTypeID)]的值:[$(pobjRsStuTypeEN.stuTypeID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeDesc) == false && undefined !== pobjRsStuTypeEN.stuTypeDesc && tzDataType.isString(pobjRsStuTypeEN.stuTypeDesc) === false)
{
 throw new Error("(errid:Watl000060)字段[学生类别名称(stuTypeDesc)]的值:[$(pobjRsStuTypeEN.stuTypeDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyDate) == false && undefined !== pobjRsStuTypeEN.modifyDate && tzDataType.isString(pobjRsStuTypeEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjRsStuTypeEN.modifyDate)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyUserID) == false && undefined !== pobjRsStuTypeEN.modifyUserID && tzDataType.isString(pobjRsStuTypeEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjRsStuTypeEN.modifyUserID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.specUniLenDesc) == false && undefined !== pobjRsStuTypeEN.specUniLenDesc && tzDataType.isString(pobjRsStuTypeEN.specUniLenDesc) === false)
{
 throw new Error("(errid:Watl000060)字段[SpecUniLenDesc(specUniLenDesc)]的值:[$(pobjRsStuTypeEN.specUniLenDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.memo) == false && undefined !== pobjRsStuTypeEN.memo && tzDataType.isString(pobjRsStuTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRsStuTypeEN.memo)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjRsStuTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function RsStuType_CheckProperty4Update (pobjRsStuTypeEN: clsRsStuTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjRsStuTypeEN.id_StuType) == false && GetStrLen(pobjRsStuTypeEN.id_StuType) > 4)
{
 throw new Error("(errid:Watl000062)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.id_StuType)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeID) == false && GetStrLen(pobjRsStuTypeEN.stuTypeID) > 4)
{
 throw new Error("(errid:Watl000062)字段[学生类别ID(stuTypeID)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeID)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeDesc) == false && GetStrLen(pobjRsStuTypeEN.stuTypeDesc) > 50)
{
 throw new Error("(errid:Watl000062)字段[学生类别名称(stuTypeDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeDesc)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyDate) == false && GetStrLen(pobjRsStuTypeEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyDate)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyUserID) == false && GetStrLen(pobjRsStuTypeEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyUserID)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.specUniLenDesc) == false && GetStrLen(pobjRsStuTypeEN.specUniLenDesc) > 50)
{
 throw new Error("(errid:Watl000062)字段[SpecUniLenDesc(specUniLenDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.specUniLenDesc)(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.memo) == false && GetStrLen(pobjRsStuTypeEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.memo)(clsRsStuTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjRsStuTypeEN.id_StuType) == false && undefined !== pobjRsStuTypeEN.id_StuType && tzDataType.isString(pobjRsStuTypeEN.id_StuType) === false)
{
 throw new Error("(errid:Watl000063)字段[学生类别流水号(id_StuType)]的值:[$(pobjRsStuTypeEN.id_StuType)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeID) == false && undefined !== pobjRsStuTypeEN.stuTypeID && tzDataType.isString(pobjRsStuTypeEN.stuTypeID) === false)
{
 throw new Error("(errid:Watl000063)字段[学生类别ID(stuTypeID)]的值:[$(pobjRsStuTypeEN.stuTypeID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.stuTypeDesc) == false && undefined !== pobjRsStuTypeEN.stuTypeDesc && tzDataType.isString(pobjRsStuTypeEN.stuTypeDesc) === false)
{
 throw new Error("(errid:Watl000063)字段[学生类别名称(stuTypeDesc)]的值:[$(pobjRsStuTypeEN.stuTypeDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyDate) == false && undefined !== pobjRsStuTypeEN.modifyDate && tzDataType.isString(pobjRsStuTypeEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjRsStuTypeEN.modifyDate)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.modifyUserID) == false && undefined !== pobjRsStuTypeEN.modifyUserID && tzDataType.isString(pobjRsStuTypeEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjRsStuTypeEN.modifyUserID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.specUniLenDesc) == false && undefined !== pobjRsStuTypeEN.specUniLenDesc && tzDataType.isString(pobjRsStuTypeEN.specUniLenDesc) === false)
{
 throw new Error("(errid:Watl000063)字段[SpecUniLenDesc(specUniLenDesc)]的值:[$(pobjRsStuTypeEN.specUniLenDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjRsStuTypeEN.memo) == false && undefined !== pobjRsStuTypeEN.memo && tzDataType.isString(pobjRsStuTypeEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRsStuTypeEN.memo)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjRsStuTypeEN.id_StuType) === true 
 || pobjRsStuTypeEN.id_StuType.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[学生类别流水号]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjRsStuTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RsStuType_GetJSONStrByObj (pobjRsStuTypeEN: clsRsStuTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjRsStuTypeEN.sfUpdFldSetStr = pobjRsStuTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjRsStuTypeEN);
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
export function RsStuType_GetObjLstByJSONStr (strJSON: string): Array<clsRsStuTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrRsStuTypeObjLst = new Array<clsRsStuTypeEN>();
if (strJSON === "")
{
return arrRsStuTypeObjLst;
}
try
{
arrRsStuTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrRsStuTypeObjLst;
}
return arrRsStuTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrRsStuTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function RsStuType_GetObjLstByJSONObjLst (arrRsStuTypeObjLstS: Array<clsRsStuTypeEN>): Array<clsRsStuTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrRsStuTypeObjLst = new Array<clsRsStuTypeEN>();
for (const objInFor of arrRsStuTypeObjLstS) {
const obj1 = RsStuType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrRsStuTypeObjLst.push(obj1);
}
return arrRsStuTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function RsStuType_GetObjByJSONStr (strJSON: string): clsRsStuTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjRsStuTypeEN = new clsRsStuTypeEN();
if (strJSON === "")
{
return pobjRsStuTypeEN;
}
try
{
pobjRsStuTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjRsStuTypeEN;
}
return pobjRsStuTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function RsStuType_GetCombineCondition(objRsStuType_Cond: clsRsStuTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_id_StuType) == true)
{
const strComparisonOp_id_StuType:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_id_StuType];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_id_StuType, objRsStuType_Cond.id_StuType, strComparisonOp_id_StuType);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_StuTypeID) == true)
{
const strComparisonOp_StuTypeID:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_StuTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_StuTypeID, objRsStuType_Cond.stuTypeID, strComparisonOp_StuTypeID);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_StuTypeDesc) == true)
{
const strComparisonOp_StuTypeDesc:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_StuTypeDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_StuTypeDesc, objRsStuType_Cond.stuTypeDesc, strComparisonOp_StuTypeDesc);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_ModifyDate, objRsStuType_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_ModifyUserID, objRsStuType_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_SpecUniLenDesc) == true)
{
const strComparisonOp_SpecUniLenDesc:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_SpecUniLenDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_SpecUniLenDesc, objRsStuType_Cond.specUniLenDesc, strComparisonOp_SpecUniLenDesc);
}
if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsRsStuTypeEN.con_Memo, objRsStuType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objRsStuTypeENS:源对象
 * @param objRsStuTypeENT:目标对象
*/
export function RsStuType_CopyObjTo(objRsStuTypeENS: clsRsStuTypeEN , objRsStuTypeENT: clsRsStuTypeEN ): void 
{
objRsStuTypeENT.id_StuType = objRsStuTypeENS.id_StuType; //学生类别流水号
objRsStuTypeENT.stuTypeID = objRsStuTypeENS.stuTypeID; //学生类别ID
objRsStuTypeENT.stuTypeDesc = objRsStuTypeENS.stuTypeDesc; //学生类别名称
objRsStuTypeENT.modifyDate = objRsStuTypeENS.modifyDate; //修改日期
objRsStuTypeENT.modifyUserID = objRsStuTypeENS.modifyUserID; //修改人
objRsStuTypeENT.specUniLenDesc = objRsStuTypeENS.specUniLenDesc; //SpecUniLenDesc
objRsStuTypeENT.memo = objRsStuTypeENS.memo; //备注
objRsStuTypeENT.sfUpdFldSetStr = objRsStuTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objRsStuTypeENS:源对象
 * @param objRsStuTypeENT:目标对象
*/
export function RsStuType_GetObjFromJsonObj(objRsStuTypeENS: clsRsStuTypeEN): clsRsStuTypeEN 
{
 const objRsStuTypeENT: clsRsStuTypeEN = new clsRsStuTypeEN();
ObjectAssign(objRsStuTypeENT, objRsStuTypeENS);
 return objRsStuTypeENT;
}