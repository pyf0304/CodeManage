
 /**
 * 类名:clsPk2EduClsTeacherTypeWApi
 * 表名:Pk2EduClsTeacherType(01120133)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:51:40
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 教学班教师角色表2(Pk2EduClsTeacherType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPk2EduClsTeacherTypeEN } from "../../L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const pk2EduClsTeacherType_Controller = "Pk2EduClsTeacherTypeApi";
 export const pk2EduClsTeacherType_ConstructorName = "pk2EduClsTeacherType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_Pk2EduClsTeacherType:关键字
 * @returns 对象
 **/
export async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType: string): Promise<clsPk2EduClsTeacherTypeEN|null>  
{
const strThisFuncName = "GetObjByid_Pk2EduClsTeacherTypeAsync";

if (IsNullOrEmpty(strid_Pk2EduClsTeacherType) == true)
{
  const strMsg = Format("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherTypeAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Pk2EduClsTeacherType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherTypeAsync)", strid_Pk2EduClsTeacherType.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_Pk2EduClsTeacherType";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType,
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
const objPk2EduClsTeacherType = Pk2EduClsTeacherType_GetObjFromJsonObj(returnObj);
return objPk2EduClsTeacherType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param strid_Pk2EduClsTeacherType:所给的关键字
 * @returns 对象
*/
export async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_Pk2EduClsTeacherType_Cache";

if (IsNullOrEmpty(strid_Pk2EduClsTeacherType) == true)
{
  const strMsg = Format("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Pk2EduClsTeacherType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_Cache)", strid_Pk2EduClsTeacherType.length);
console.error(strMsg);
throw (strMsg);
}
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
try
{
const arrPk2EduClsTeacherType_Sel: Array <clsPk2EduClsTeacherTypeEN> = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => 
 x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType );
let objPk2EduClsTeacherType: clsPk2EduClsTeacherTypeEN;
if (arrPk2EduClsTeacherType_Sel.length > 0)
{
objPk2EduClsTeacherType = arrPk2EduClsTeacherType_Sel[0];
return objPk2EduClsTeacherType;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPk2EduClsTeacherType_Const = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType);
if (objPk2EduClsTeacherType_Const != null)
{
Pk2EduClsTeacherType_ReFreshThisCache();
return objPk2EduClsTeacherType_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Pk2EduClsTeacherType, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_Pk2EduClsTeacherType:所给的关键字
 * @returns 对象
*/
export async function Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_localStorage(strid_Pk2EduClsTeacherType: string) {
const strThisFuncName = "GetObjByid_Pk2EduClsTeacherType_localStorage";

if (IsNullOrEmpty(strid_Pk2EduClsTeacherType) == true)
{
  const strMsg = Format("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Pk2EduClsTeacherType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetObjByid_Pk2EduClsTeacherType_localStorage)", strid_Pk2EduClsTeacherType.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPk2EduClsTeacherTypeEN._CurrTabName, strid_Pk2EduClsTeacherType);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPk2EduClsTeacherType_Cache: clsPk2EduClsTeacherTypeEN = JSON.parse(strTempObj);
return objPk2EduClsTeacherType_Cache;
}
try
{
const objPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherTypeAsync(strid_Pk2EduClsTeacherType);
if (objPk2EduClsTeacherType != null)
{
localStorage.setItem(strKey, JSON.stringify(objPk2EduClsTeacherType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPk2EduClsTeacherType;
}
return objPk2EduClsTeacherType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Pk2EduClsTeacherType, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPk2EduClsTeacherType:所给的对象
 * @returns 对象
*/
export async function Pk2EduClsTeacherType_UpdateObjInLst_Cache(objPk2EduClsTeacherType: clsPk2EduClsTeacherTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
const obj = arrPk2EduClsTeacherTypeObjLst_Cache.find(x => 
x.id_Pk2EduClsTeacherType == objPk2EduClsTeacherType.id_Pk2EduClsTeacherType);
if (obj != null)
{
objPk2EduClsTeacherType.id_Pk2EduClsTeacherType = obj.id_Pk2EduClsTeacherType;
ObjectAssign( obj, objPk2EduClsTeacherType);
}
else
{
arrPk2EduClsTeacherTypeObjLst_Cache.push(objPk2EduClsTeacherType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_Pk2EduClsTeacherType:所给的关键字
 * @returns 对象
*/
export async function Pk2EduClsTeacherType_GetNameByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType: string) {
const strThisFuncName = "GetNameByid_Pk2EduClsTeacherType_Cache";

if (IsNullOrEmpty(strid_Pk2EduClsTeacherType) == true)
{
  const strMsg = Format("参数:[strid_Pk2EduClsTeacherType]不能为空！(In clsPk2EduClsTeacherTypeWApi.GetNameByid_Pk2EduClsTeacherType_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Pk2EduClsTeacherType.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_Pk2EduClsTeacherType]的长度:[{0}]不正确！(clsPk2EduClsTeacherTypeWApi.GetNameByid_Pk2EduClsTeacherType_Cache)", strid_Pk2EduClsTeacherType.length);
console.error(strMsg);
throw (strMsg);
}
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherTypeObjLst_Cache == null) return "";
try
{
const arrPk2EduClsTeacherType_Sel: Array <clsPk2EduClsTeacherTypeEN> = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => 
 x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType );
let objPk2EduClsTeacherType: clsPk2EduClsTeacherTypeEN;
if (arrPk2EduClsTeacherType_Sel.length > 0)
{
objPk2EduClsTeacherType = arrPk2EduClsTeacherType_Sel[0];
return objPk2EduClsTeacherType.eduClsTeacherTypeDesc;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_Pk2EduClsTeacherType);
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
export async function Pk2EduClsTeacherType_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPk2EduClsTeacherTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPk2EduClsTeacherTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_Pk2EduClsTeacherType = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjByid_Pk2EduClsTeacherType_Cache(strid_Pk2EduClsTeacherType );
if (objPk2EduClsTeacherType == null) return "";
if (objPk2EduClsTeacherType.GetFldValue(strOutFldName) == null) return "";
return objPk2EduClsTeacherType.GetFldValue(strOutFldName).toString();
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
export function Pk2EduClsTeacherType_SortFun_Defa(a:clsPk2EduClsTeacherTypeEN , b:clsPk2EduClsTeacherTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
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
export function Pk2EduClsTeacherType_SortFun_Defa_2Fld(a:clsPk2EduClsTeacherTypeEN , b:clsPk2EduClsTeacherTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.eduClsTeacherTypeID == b.eduClsTeacherTypeID) return a.eduClsTeacherTypeDesc.localeCompare(b.eduClsTeacherTypeDesc);
else return a.eduClsTeacherTypeID.localeCompare(b.eduClsTeacherTypeID);
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
export function Pk2EduClsTeacherType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
if (a.eduClsTeacherTypeID == null) return -1;
if (b.eduClsTeacherTypeID == null) return 1;
return a.eduClsTeacherTypeID.localeCompare(b.eduClsTeacherTypeID);
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
if (a.eduClsTeacherTypeDesc == null) return -1;
if (b.eduClsTeacherTypeDesc == null) return 1;
return a.eduClsTeacherTypeDesc.localeCompare(b.eduClsTeacherTypeDesc);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${ pk2EduClsTeacherType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
return b.id_Pk2EduClsTeacherType.localeCompare(a.id_Pk2EduClsTeacherType);
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
if (b.eduClsTeacherTypeID == null) return -1;
if (a.eduClsTeacherTypeID == null) return 1;
return b.eduClsTeacherTypeID.localeCompare(a.eduClsTeacherTypeID);
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
return (a: clsPk2EduClsTeacherTypeEN, b: clsPk2EduClsTeacherTypeEN) => {
if (b.eduClsTeacherTypeDesc == null) return -1;
if (a.eduClsTeacherTypeDesc == null) return 1;
return b.eduClsTeacherTypeDesc.localeCompare(a.eduClsTeacherTypeDesc);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${ pk2EduClsTeacherType_ConstructorName}.${ strThisFuncName})`;
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
export async function Pk2EduClsTeacherType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType:
return (obj: clsPk2EduClsTeacherTypeEN) => {
return obj.id_Pk2EduClsTeacherType === value;
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID:
return (obj: clsPk2EduClsTeacherTypeEN) => {
return obj.eduClsTeacherTypeID === value;
}
case clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc:
return (obj: clsPk2EduClsTeacherTypeEN) => {
return obj.eduClsTeacherTypeDesc === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Pk2EduClsTeacherType]中不存在！(in ${ pk2EduClsTeacherType_ConstructorName}.${ strThisFuncName})`;
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
export async function Pk2EduClsTeacherType_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrPk2EduClsTeacherType = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherType == null) return [];
let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPk2EduClsTeacherType_Sel.length == 0) return [];
return arrPk2EduClsTeacherType_Sel.map(x=>x.id_Pk2EduClsTeacherType);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function Pk2EduClsTeacherType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetFirstObjAsync(strWhereCond: string): Promise<clsPk2EduClsTeacherTypeEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const objPk2EduClsTeacherType = Pk2EduClsTeacherType_GetObjFromJsonObj(returnObj);
return objPk2EduClsTeacherType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
if (IsNullOrEmpty(clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPk2EduClsTeacherTypeExObjLst_Cache: Array<clsPk2EduClsTeacherTypeEN> = CacheHelper.Get(strKey);
const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
return arrPk2EduClsTeacherTypeObjLst_T;
}
try
{
const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPk2EduClsTeacherTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
console.log(strInfo);
return arrPk2EduClsTeacherTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
if (IsNullOrEmpty(clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
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
const arrPk2EduClsTeacherTypeExObjLst_Cache: Array<clsPk2EduClsTeacherTypeEN> = JSON.parse(strTempObjLst);
const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
return arrPk2EduClsTeacherTypeObjLst_T;
}
try
{
const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPk2EduClsTeacherTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
console.log(strInfo);
return arrPk2EduClsTeacherTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPk2EduClsTeacherTypeObjLst_Cache: Array<clsPk2EduClsTeacherTypeEN> = JSON.parse(strTempObjLst);
return arrPk2EduClsTeacherTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPk2EduClsTeacherTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
if (IsNullOrEmpty(clsPk2EduClsTeacherTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPk2EduClsTeacherTypeEN.CacheAddiCondition);
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
const arrPk2EduClsTeacherTypeExObjLst_Cache: Array<clsPk2EduClsTeacherTypeEN> = JSON.parse(strTempObjLst);
const arrPk2EduClsTeacherTypeObjLst_T = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeExObjLst_Cache);
return arrPk2EduClsTeacherTypeObjLst_T;
}
try
{
const arrPk2EduClsTeacherTypeExObjLst = await Pk2EduClsTeacherType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPk2EduClsTeacherTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPk2EduClsTeacherTypeExObjLst.length);
console.log(strInfo);
return arrPk2EduClsTeacherTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPk2EduClsTeacherTypeObjLst_Cache: Array<clsPk2EduClsTeacherTypeEN> = JSON.parse(strTempObjLst);
return arrPk2EduClsTeacherTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLst_Cache(): Promise<Array<clsPk2EduClsTeacherTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPk2EduClsTeacherTypeObjLst_Cache;
switch (clsPk2EduClsTeacherTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_ClientCache();
break;
default:
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_ClientCache();
break;
}
const arrPk2EduClsTeacherTypeObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(arrPk2EduClsTeacherTypeObjLst_Cache);
return arrPk2EduClsTeacherTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPk2EduClsTeacherTypeObjLst_Cache;
switch (clsPk2EduClsTeacherTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPk2EduClsTeacherTypeObjLst_Cache = null;
break;
default:
arrPk2EduClsTeacherTypeObjLst_Cache = null;
break;
}
return arrPk2EduClsTeacherTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_Pk2EduClsTeacherType_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Pk2EduClsTeacherType_GetSubObjLst_Cache(objPk2EduClsTeacherType_Cond: clsPk2EduClsTeacherTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
let arrPk2EduClsTeacherType_Sel: Array < clsPk2EduClsTeacherTypeEN > = arrPk2EduClsTeacherTypeObjLst_Cache;
if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "") return arrPk2EduClsTeacherType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
//console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPk2EduClsTeacherType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPk2EduClsTeacherType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPk2EduClsTeacherType_Cond), pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPk2EduClsTeacherTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_Pk2EduClsTeacherType:关键字列表
 * @returns 对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLstAsync(arrid_Pk2EduClsTeacherType: Array<string>): Promise<Array<clsPk2EduClsTeacherTypeEN>>  
{
const strThisFuncName = "GetObjLstByid_Pk2EduClsTeacherTypeLstAsync";
const strAction = "GetObjLstByid_Pk2EduClsTeacherTypeLst";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Pk2EduClsTeacherType);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param arrstrid_Pk2EduClsTeacherTypeLst:关键字列表
 * @returns 对象列表
*/
export async function Pk2EduClsTeacherType_GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache(arrid_Pk2EduClsTeacherTypeLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_Pk2EduClsTeacherTypeLst_Cache";
try
{
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
const arrPk2EduClsTeacherType_Sel: Array <clsPk2EduClsTeacherTypeEN> = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => arrid_Pk2EduClsTeacherTypeLst.indexOf(x.id_Pk2EduClsTeacherType)>-1);
return arrPk2EduClsTeacherType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_Pk2EduClsTeacherTypeLst.join(","), pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPk2EduClsTeacherTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPk2EduClsTeacherTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPk2EduClsTeacherTypeEN>();
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherTypeObjLst_Cache.length == 0) return arrPk2EduClsTeacherTypeObjLst_Cache;
let arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPk2EduClsTeacherType_Cond = new clsPk2EduClsTeacherTypeEN();
ObjectAssign(objPk2EduClsTeacherType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPk2EduClsTeacherTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPk2EduClsTeacherType_Sel.length == 0) return arrPk2EduClsTeacherType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.sort(Pk2EduClsTeacherType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.sort(objPagerPara.sortFun);
}
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.slice(intStart, intEnd);     
return arrPk2EduClsTeacherType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPk2EduClsTeacherTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function Pk2EduClsTeacherType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPk2EduClsTeacherTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPk2EduClsTeacherTypeEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Pk2EduClsTeacherType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param strid_Pk2EduClsTeacherType:关键字
 * @returns 获取删除的结果
 **/
export async function Pk2EduClsTeacherType_DelRecordAsync(strid_Pk2EduClsTeacherType: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_Pk2EduClsTeacherType);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param arrid_Pk2EduClsTeacherType:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesAsync(arrid_Pk2EduClsTeacherType: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPk2EduClsTeacherTypesAsync";
const strAction = "DelPk2EduClsTeacherTypes";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Pk2EduClsTeacherType);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_DelPk2EduClsTeacherTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPk2EduClsTeacherTypesByCondAsync";
const strAction = "DelPk2EduClsTeacherTypesByCond";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Pk2EduClsTeacherType_AddNewRecordAsync(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === null || objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objPk2EduClsTeacherTypeEN);
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Pk2EduClsTeacherType_AddNewRecordWithMaxIdAsync(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function Pk2EduClsTeacherType_AddNewRecordWithReturnKeyAsync(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function Pk2EduClsTeacherType_AddNewRecordWithReturnKey(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === null || objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function Pk2EduClsTeacherType_UpdateRecordAsync(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === undefined || objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === null || objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function Pk2EduClsTeacherType_UpdateWithConditionAsync(objPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === undefined || objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === null || objPk2EduClsTeacherTypeEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
objPk2EduClsTeacherTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPk2EduClsTeacherTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objstrid_Pk2EduClsTeacherType_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Pk2EduClsTeacherType_IsExistRecord_Cache(objPk2EduClsTeacherType_Cond: clsPk2EduClsTeacherTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherTypeObjLst_Cache == null) return false;
let arrPk2EduClsTeacherType_Sel: Array < clsPk2EduClsTeacherTypeEN > = arrPk2EduClsTeacherTypeObjLst_Cache;
if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "") return arrPk2EduClsTeacherType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
//console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPk2EduClsTeacherType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPk2EduClsTeacherType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPk2EduClsTeacherType_Cond), pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param strid_Pk2EduClsTeacherType:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function Pk2EduClsTeacherType_IsExist(strid_Pk2EduClsTeacherType: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param strid_Pk2EduClsTeacherType:所给的关键字
 * @returns 对象
*/
export async function Pk2EduClsTeacherType_IsExist_Cache(strid_Pk2EduClsTeacherType:string) {
const strThisFuncName = "IsExist_Cache";
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherTypeObjLst_Cache == null) return false;
try
{
const arrPk2EduClsTeacherType_Sel: Array <clsPk2EduClsTeacherTypeEN> = arrPk2EduClsTeacherTypeObjLst_Cache.filter(x => x.id_Pk2EduClsTeacherType == strid_Pk2EduClsTeacherType);
if (arrPk2EduClsTeacherType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Pk2EduClsTeacherType, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_Pk2EduClsTeacherType:关键字
 * @returns 是否存在?存在返回True
 **/
export async function Pk2EduClsTeacherType_IsExistAsync(strid_Pk2EduClsTeacherType: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_Pk2EduClsTeacherType": strid_Pk2EduClsTeacherType }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
 * @param objPk2EduClsTeacherType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function Pk2EduClsTeacherType_GetRecCountByCond_Cache(objPk2EduClsTeacherType_Cond: clsPk2EduClsTeacherTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPk2EduClsTeacherTypeObjLst_Cache = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrPk2EduClsTeacherTypeObjLst_Cache == null) return 0;
let arrPk2EduClsTeacherType_Sel: Array < clsPk2EduClsTeacherTypeEN > = arrPk2EduClsTeacherTypeObjLst_Cache;
if (objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == null || objPk2EduClsTeacherType_Cond.sf_FldComparisonOp == "") return arrPk2EduClsTeacherType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPk2EduClsTeacherType_Cond.sf_FldComparisonOp);
//console.log("clsPk2EduClsTeacherTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPk2EduClsTeacherType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPk2EduClsTeacherType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPk2EduClsTeacherType_Sel = arrPk2EduClsTeacherType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPk2EduClsTeacherType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPk2EduClsTeacherType_Cond), pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export async function Pk2EduClsTeacherType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(pk2EduClsTeacherType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, pk2EduClsTeacherType_ConstructorName, strThisFuncName);
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
export function Pk2EduClsTeacherType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function Pk2EduClsTeacherType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
switch (clsPk2EduClsTeacherTypeEN.CacheModeId)
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
export function Pk2EduClsTeacherType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPk2EduClsTeacherTypeEN._CurrTabName;
switch (clsPk2EduClsTeacherTypeEN.CacheModeId)
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
export async function Pk2EduClsTeacherType_BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_Pk2EduClsTeacherTypeInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_Pk2EduClsTeacherTypeInDiv_Cache");
const arrObjLst_Sel = await Pk2EduClsTeacherType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType, clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc, "教学班教师角色表2");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Pk2EduClsTeacherType_CheckPropertyNew(pobjPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Error("(errid:Watl000059)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) > 4)
{
 throw new Error("(errid:Watl000059)字段[教学班教学类型ID(eduClsTeacherTypeID)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) > 20)
{
 throw new Error("(errid:Watl000059)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的长度不能超过20(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班教学类型ID(eduClsTeacherTypeID)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPk2EduClsTeacherTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Pk2EduClsTeacherType_CheckProperty4Update (pobjPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Error("(errid:Watl000062)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) > 4)
{
 throw new Error("(errid:Watl000062)字段[教学班教学类型ID(eduClsTeacherTypeID)]的长度不能超过4(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && GetStrLen(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) > 20)
{
 throw new Error("(errid:Watl000062)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的长度不能超过20(In 教学班教师角色表2(Pk2EduClsTeacherType))!值:$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班教学类型ID(eduClsTeacherTypeID)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeID)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) == false && undefined !== pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc && tzDataType.isString(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班教师类型名(eduClsTeacherTypeDesc)]的值:[$(pobjPk2EduClsTeacherTypeEN.eduClsTeacherTypeDesc)], 非法，应该为字符型(In 教学班教师角色表2(Pk2EduClsTeacherType))!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType) === true 
 || pobjPk2EduClsTeacherTypeEN.id_Pk2EduClsTeacherType.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[教学班老师角色(主讲,辅导)流水号]不能为空(In 教学班教师角色表2)!(clsPk2EduClsTeacherTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPk2EduClsTeacherTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Pk2EduClsTeacherType_GetJSONStrByObj (pobjPk2EduClsTeacherTypeEN: clsPk2EduClsTeacherTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPk2EduClsTeacherTypeEN.sfUpdFldSetStr = pobjPk2EduClsTeacherTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPk2EduClsTeacherTypeEN);
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
export function Pk2EduClsTeacherType_GetObjLstByJSONStr (strJSON: string): Array<clsPk2EduClsTeacherTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPk2EduClsTeacherTypeObjLst = new Array<clsPk2EduClsTeacherTypeEN>();
if (strJSON === "")
{
return arrPk2EduClsTeacherTypeObjLst;
}
try
{
arrPk2EduClsTeacherTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPk2EduClsTeacherTypeObjLst;
}
return arrPk2EduClsTeacherTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPk2EduClsTeacherTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function Pk2EduClsTeacherType_GetObjLstByJSONObjLst (arrPk2EduClsTeacherTypeObjLstS: Array<clsPk2EduClsTeacherTypeEN>): Array<clsPk2EduClsTeacherTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPk2EduClsTeacherTypeObjLst = new Array<clsPk2EduClsTeacherTypeEN>();
for (const objInFor of arrPk2EduClsTeacherTypeObjLstS) {
const obj1 = Pk2EduClsTeacherType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPk2EduClsTeacherTypeObjLst.push(obj1);
}
return arrPk2EduClsTeacherTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Pk2EduClsTeacherType_GetObjByJSONStr (strJSON: string): clsPk2EduClsTeacherTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPk2EduClsTeacherTypeEN = new clsPk2EduClsTeacherTypeEN();
if (strJSON === "")
{
return pobjPk2EduClsTeacherTypeEN;
}
try
{
pobjPk2EduClsTeacherTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPk2EduClsTeacherTypeEN;
}
return pobjPk2EduClsTeacherTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function Pk2EduClsTeacherType_GetCombineCondition(objPk2EduClsTeacherType_Cond: clsPk2EduClsTeacherTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType) == true)
{
const strComparisonOp_id_Pk2EduClsTeacherType:string = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType];
strWhereCond += Format(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN.con_id_Pk2EduClsTeacherType, objPk2EduClsTeacherType_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID) == true)
{
const strComparisonOp_EduClsTeacherTypeID:string = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeID, objPk2EduClsTeacherType_Cond.eduClsTeacherTypeID, strComparisonOp_EduClsTeacherTypeID);
}
if (Object.prototype.hasOwnProperty.call(objPk2EduClsTeacherType_Cond.dicFldComparisonOp, clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc) == true)
{
const strComparisonOp_EduClsTeacherTypeDesc:string = objPk2EduClsTeacherType_Cond.dicFldComparisonOp[clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsPk2EduClsTeacherTypeEN.con_EduClsTeacherTypeDesc, objPk2EduClsTeacherType_Cond.eduClsTeacherTypeDesc, strComparisonOp_EduClsTeacherTypeDesc);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPk2EduClsTeacherTypeENS:源对象
 * @param objPk2EduClsTeacherTypeENT:目标对象
*/
export function Pk2EduClsTeacherType_CopyObjTo(objPk2EduClsTeacherTypeENS: clsPk2EduClsTeacherTypeEN , objPk2EduClsTeacherTypeENT: clsPk2EduClsTeacherTypeEN ): void 
{
objPk2EduClsTeacherTypeENT.id_Pk2EduClsTeacherType = objPk2EduClsTeacherTypeENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objPk2EduClsTeacherTypeENT.eduClsTeacherTypeID = objPk2EduClsTeacherTypeENS.eduClsTeacherTypeID; //教学班教学类型ID
objPk2EduClsTeacherTypeENT.eduClsTeacherTypeDesc = objPk2EduClsTeacherTypeENS.eduClsTeacherTypeDesc; //教学班教师类型名
objPk2EduClsTeacherTypeENT.sfUpdFldSetStr = objPk2EduClsTeacherTypeENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPk2EduClsTeacherTypeENS:源对象
 * @param objPk2EduClsTeacherTypeENT:目标对象
*/
export function Pk2EduClsTeacherType_GetObjFromJsonObj(objPk2EduClsTeacherTypeENS: clsPk2EduClsTeacherTypeEN): clsPk2EduClsTeacherTypeEN 
{
 const objPk2EduClsTeacherTypeENT: clsPk2EduClsTeacherTypeEN = new clsPk2EduClsTeacherTypeEN();
ObjectAssign(objPk2EduClsTeacherTypeENT, objPk2EduClsTeacherTypeENS);
 return objPk2EduClsTeacherTypeENT;
}