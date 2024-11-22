
 /**
 * 类名:clsXzAdminClsWApi
 * 表名:XzAdminCls(01120194)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:37
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 行政班(XzAdminCls)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsXzAdminClsEN } from "../../L0_Entity/PeopleManage/clsXzAdminClsEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const xzAdminCls_Controller = "XzAdminClsApi";
 export const xzAdminCls_ConstructorName = "xzAdminCls";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_AdminCls:关键字
 * @returns 对象
 **/
export async function XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls: string): Promise<clsXzAdminClsEN|null>  
{
const strThisFuncName = "GetObjByid_AdminClsAsync";

if (IsNullOrEmpty(strid_AdminCls) == true)
{
  const strMsg = Format("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminClsAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_AdminCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminClsAsync)", strid_AdminCls.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_AdminCls";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_AdminCls": strid_AdminCls,
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
const objXzAdminCls = XzAdminCls_GetObjFromJsonObj(returnObj);
return objXzAdminCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param strid_AdminCls:所给的关键字
 * @returns 对象
*/
export async function XzAdminCls_GetObjByid_AdminCls_Cache(strid_AdminCls: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_AdminCls_Cache";

if (IsNullOrEmpty(strid_AdminCls) == true)
{
  const strMsg = Format("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminCls_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_AdminCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminCls_Cache)", strid_AdminCls.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
try
{
const arrXzAdminCls_Sel: Array <clsXzAdminClsEN> = arrXzAdminClsObjLst_Cache.filter(x => 
 x.id_AdminCls == strid_AdminCls );
let objXzAdminCls: clsXzAdminClsEN;
if (arrXzAdminCls_Sel.length > 0)
{
objXzAdminCls = arrXzAdminCls_Sel[0];
return objXzAdminCls;
}
else
{
if (bolTryAsyncOnce == true)
{
const objXzAdminCls_Const = await XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls);
if (objXzAdminCls_Const != null)
{
XzAdminCls_ReFreshThisCache();
return objXzAdminCls_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminCls, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_AdminCls:所给的关键字
 * @returns 对象
*/
export async function XzAdminCls_GetObjByid_AdminCls_localStorage(strid_AdminCls: string) {
const strThisFuncName = "GetObjByid_AdminCls_localStorage";

if (IsNullOrEmpty(strid_AdminCls) == true)
{
  const strMsg = Format("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetObjByid_AdminCls_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_AdminCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetObjByid_AdminCls_localStorage)", strid_AdminCls.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsXzAdminClsEN._CurrTabName, strid_AdminCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objXzAdminCls_Cache: clsXzAdminClsEN = JSON.parse(strTempObj);
return objXzAdminCls_Cache;
}
try
{
const objXzAdminCls = await XzAdminCls_GetObjByid_AdminClsAsync(strid_AdminCls);
if (objXzAdminCls != null)
{
localStorage.setItem(strKey, JSON.stringify(objXzAdminCls));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objXzAdminCls;
}
return objXzAdminCls;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminCls, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objXzAdminCls:所给的对象
 * @returns 对象
*/
export async function XzAdminCls_UpdateObjInLst_Cache(objXzAdminCls: clsXzAdminClsEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
const obj = arrXzAdminClsObjLst_Cache.find(x => x.adminClsName == objXzAdminCls.adminClsName);
if (obj != null)
{
objXzAdminCls.id_AdminCls = obj.id_AdminCls;
ObjectAssign( obj, objXzAdminCls);
}
else
{
arrXzAdminClsObjLst_Cache.push(objXzAdminCls);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_AdminCls:所给的关键字
 * @returns 对象
*/
export async function XzAdminCls_GetNameByid_AdminCls_Cache(strid_AdminCls: string) {
const strThisFuncName = "GetNameByid_AdminCls_Cache";

if (IsNullOrEmpty(strid_AdminCls) == true)
{
  const strMsg = Format("参数:[strid_AdminCls]不能为空！(In clsXzAdminClsWApi.GetNameByid_AdminCls_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_AdminCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_AdminCls]的长度:[{0}]不正确！(clsXzAdminClsWApi.GetNameByid_AdminCls_Cache)", strid_AdminCls.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminClsObjLst_Cache == null) return "";
try
{
const arrXzAdminCls_Sel: Array <clsXzAdminClsEN> = arrXzAdminClsObjLst_Cache.filter(x => 
 x.id_AdminCls == strid_AdminCls );
let objXzAdminCls: clsXzAdminClsEN;
if (arrXzAdminCls_Sel.length > 0)
{
objXzAdminCls = arrXzAdminCls_Sel[0];
return objXzAdminCls.adminClsName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_AdminCls);
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
export async function XzAdminCls_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsXzAdminClsEN.con_id_AdminCls)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsXzAdminClsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsXzAdminClsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_AdminCls = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objXzAdminCls = await XzAdminCls_GetObjByid_AdminCls_Cache(strid_AdminCls );
if (objXzAdminCls == null) return "";
if (objXzAdminCls.GetFldValue(strOutFldName) == null) return "";
return objXzAdminCls.GetFldValue(strOutFldName).toString();
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
export function XzAdminCls_SortFun_Defa(a:clsXzAdminClsEN , b:clsXzAdminClsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_AdminCls.localeCompare(b.id_AdminCls);
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
export function XzAdminCls_SortFun_Defa_2Fld(a:clsXzAdminClsEN , b:clsXzAdminClsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.adminClsName == b.adminClsName) return a.id_XzMajor.localeCompare(b.id_XzMajor);
else return a.adminClsName.localeCompare(b.adminClsName);
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
export function XzAdminCls_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsXzAdminClsEN.con_id_AdminCls:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.id_AdminCls.localeCompare(b.id_AdminCls);
}
case clsXzAdminClsEN.con_AdminClsName:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.adminClsName == null) return -1;
if (b.adminClsName == null) return 1;
return a.adminClsName.localeCompare(b.adminClsName);
}
case clsXzAdminClsEN.con_id_XzMajor:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsXzAdminClsEN.con_id_XzCollege:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsXzAdminClsEN.con_id_UniZone:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.id_UniZone == null) return -1;
if (b.id_UniZone == null) return 1;
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsXzAdminClsEN.con_CurrentStuQty:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.currentStuQty-b.currentStuQty;
}
case clsXzAdminClsEN.con_id_GradeBase:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsXzAdminClsEN.con_AdminClsId:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.adminClsId == null) return -1;
if (b.adminClsId == null) return 1;
return a.adminClsId.localeCompare(b.adminClsId);
}
case clsXzAdminClsEN.con_id_AdminClsType:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.id_AdminClsType == null) return -1;
if (b.id_AdminClsType == null) return 1;
return a.id_AdminClsType.localeCompare(b.id_AdminClsType);
}
case clsXzAdminClsEN.con_AdminClsIndex:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return a.adminClsIndex-b.adminClsIndex;
}
case clsXzAdminClsEN.con_Memo:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsXzAdminClsEN.con_ModifyUserID:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.modifyUserID == null) return -1;
if (b.modifyUserID == null) return 1;
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsXzAdminClsEN.con_ModifyDate:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (a.modifyDate == null) return -1;
if (b.modifyDate == null) return 1;
return a.modifyDate.localeCompare(b.modifyDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${ xzAdminCls_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsXzAdminClsEN.con_id_AdminCls:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.id_AdminCls.localeCompare(a.id_AdminCls);
}
case clsXzAdminClsEN.con_AdminClsName:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.adminClsName == null) return -1;
if (a.adminClsName == null) return 1;
return b.adminClsName.localeCompare(a.adminClsName);
}
case clsXzAdminClsEN.con_id_XzMajor:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsXzAdminClsEN.con_id_XzCollege:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsXzAdminClsEN.con_id_UniZone:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.id_UniZone == null) return -1;
if (a.id_UniZone == null) return 1;
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsXzAdminClsEN.con_CurrentStuQty:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.currentStuQty-a.currentStuQty;
}
case clsXzAdminClsEN.con_id_GradeBase:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsXzAdminClsEN.con_AdminClsId:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.adminClsId == null) return -1;
if (a.adminClsId == null) return 1;
return b.adminClsId.localeCompare(a.adminClsId);
}
case clsXzAdminClsEN.con_id_AdminClsType:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.id_AdminClsType == null) return -1;
if (a.id_AdminClsType == null) return 1;
return b.id_AdminClsType.localeCompare(a.id_AdminClsType);
}
case clsXzAdminClsEN.con_AdminClsIndex:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
return b.adminClsIndex-a.adminClsIndex;
}
case clsXzAdminClsEN.con_Memo:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsXzAdminClsEN.con_ModifyUserID:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.modifyUserID == null) return -1;
if (a.modifyUserID == null) return 1;
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsXzAdminClsEN.con_ModifyDate:
return (a: clsXzAdminClsEN, b: clsXzAdminClsEN) => {
if (b.modifyDate == null) return -1;
if (a.modifyDate == null) return 1;
return b.modifyDate.localeCompare(a.modifyDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${ xzAdminCls_ConstructorName}.${ strThisFuncName})`;
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
export async function XzAdminCls_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsXzAdminClsEN.con_id_AdminCls:
return (obj: clsXzAdminClsEN) => {
return obj.id_AdminCls === value;
}
case clsXzAdminClsEN.con_AdminClsName:
return (obj: clsXzAdminClsEN) => {
return obj.adminClsName === value;
}
case clsXzAdminClsEN.con_id_XzMajor:
return (obj: clsXzAdminClsEN) => {
return obj.id_XzMajor === value;
}
case clsXzAdminClsEN.con_id_XzCollege:
return (obj: clsXzAdminClsEN) => {
return obj.id_XzCollege === value;
}
case clsXzAdminClsEN.con_id_UniZone:
return (obj: clsXzAdminClsEN) => {
return obj.id_UniZone === value;
}
case clsXzAdminClsEN.con_CurrentStuQty:
return (obj: clsXzAdminClsEN) => {
return obj.currentStuQty === value;
}
case clsXzAdminClsEN.con_id_GradeBase:
return (obj: clsXzAdminClsEN) => {
return obj.id_GradeBase === value;
}
case clsXzAdminClsEN.con_AdminClsId:
return (obj: clsXzAdminClsEN) => {
return obj.adminClsId === value;
}
case clsXzAdminClsEN.con_id_AdminClsType:
return (obj: clsXzAdminClsEN) => {
return obj.id_AdminClsType === value;
}
case clsXzAdminClsEN.con_AdminClsIndex:
return (obj: clsXzAdminClsEN) => {
return obj.adminClsIndex === value;
}
case clsXzAdminClsEN.con_Memo:
return (obj: clsXzAdminClsEN) => {
return obj.memo === value;
}
case clsXzAdminClsEN.con_ModifyUserID:
return (obj: clsXzAdminClsEN) => {
return obj.modifyUserID === value;
}
case clsXzAdminClsEN.con_ModifyDate:
return (obj: clsXzAdminClsEN) => {
return obj.modifyDate === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzAdminCls]中不存在！(in ${ xzAdminCls_ConstructorName}.${ strThisFuncName})`;
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
export async function XzAdminCls_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsXzAdminClsEN.con_id_AdminCls)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrXzAdminCls = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminCls == null) return [];
let arrXzAdminCls_Sel = arrXzAdminCls;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrXzAdminCls_Sel.length == 0) return [];
return arrXzAdminCls_Sel.map(x=>x.id_AdminCls);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function XzAdminCls_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetFirstObjAsync(strWhereCond: string): Promise<clsXzAdminClsEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const objXzAdminCls = XzAdminCls_GetObjFromJsonObj(returnObj);
return objXzAdminCls;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzAdminClsEN._CurrTabName;
if (IsNullOrEmpty(clsXzAdminClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzAdminClsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrXzAdminClsExObjLst_Cache: Array<clsXzAdminClsEN> = CacheHelper.Get(strKey);
const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
return arrXzAdminClsObjLst_T;
}
try
{
const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrXzAdminClsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
console.log(strInfo);
return arrXzAdminClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzAdminCls_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzAdminClsEN._CurrTabName;
if (IsNullOrEmpty(clsXzAdminClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzAdminClsEN.CacheAddiCondition);
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
const arrXzAdminClsExObjLst_Cache: Array<clsXzAdminClsEN> = JSON.parse(strTempObjLst);
const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
return arrXzAdminClsObjLst_T;
}
try
{
const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrXzAdminClsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
console.log(strInfo);
return arrXzAdminClsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzAdminCls_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzAdminClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrXzAdminClsObjLst_Cache: Array<clsXzAdminClsEN> = JSON.parse(strTempObjLst);
return arrXzAdminClsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function XzAdminCls_GetObjLstAsync(strWhereCond: string): Promise<Array<clsXzAdminClsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzAdminCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzAdminClsEN._CurrTabName;
if (IsNullOrEmpty(clsXzAdminClsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzAdminClsEN.CacheAddiCondition);
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
const arrXzAdminClsExObjLst_Cache: Array<clsXzAdminClsEN> = JSON.parse(strTempObjLst);
const arrXzAdminClsObjLst_T = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsExObjLst_Cache);
return arrXzAdminClsObjLst_T;
}
try
{
const arrXzAdminClsExObjLst = await XzAdminCls_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrXzAdminClsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsExObjLst.length);
console.log(strInfo);
return arrXzAdminClsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzAdminCls_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzAdminClsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrXzAdminClsObjLst_Cache: Array<clsXzAdminClsEN> = JSON.parse(strTempObjLst);
return arrXzAdminClsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzAdminCls_GetObjLst_Cache(): Promise<Array<clsXzAdminClsEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrXzAdminClsObjLst_Cache;
switch (clsXzAdminClsEN.CacheModeId)
{
case "04"://sessionStorage
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_ClientCache();
break;
default:
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_ClientCache();
break;
}
const arrXzAdminClsObjLst = XzAdminCls_GetObjLstByJSONObjLst(arrXzAdminClsObjLst_Cache);
return arrXzAdminClsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzAdminCls_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrXzAdminClsObjLst_Cache;
switch (clsXzAdminClsEN.CacheModeId)
{
case "04"://sessionStorage
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrXzAdminClsObjLst_Cache = null;
break;
default:
arrXzAdminClsObjLst_Cache = null;
break;
}
return arrXzAdminClsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_AdminCls_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzAdminCls_GetSubObjLst_Cache(objXzAdminCls_Cond: clsXzAdminClsEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
let arrXzAdminCls_Sel: Array < clsXzAdminClsEN > = arrXzAdminClsObjLst_Cache;
if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "") return arrXzAdminCls_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
//console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzAdminCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzAdminCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objXzAdminCls_Cond), xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzAdminClsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_AdminCls:关键字列表
 * @returns 对象列表
 **/
export async function XzAdminCls_GetObjLstByid_AdminClsLstAsync(arrid_AdminCls: Array<string>): Promise<Array<clsXzAdminClsEN>>  
{
const strThisFuncName = "GetObjLstByid_AdminClsLstAsync";
const strAction = "GetObjLstByid_AdminClsLst";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_AdminCls);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzAdminCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param arrstrid_AdminClsLst:关键字列表
 * @returns 对象列表
*/
export async function XzAdminCls_GetObjLstByid_AdminClsLst_Cache(arrid_AdminClsLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_AdminClsLst_Cache";
try
{
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
const arrXzAdminCls_Sel: Array <clsXzAdminClsEN> = arrXzAdminClsObjLst_Cache.filter(x => arrid_AdminClsLst.indexOf(x.id_AdminCls)>-1);
return arrXzAdminCls_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_AdminClsLst.join(","), xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsXzAdminClsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzAdminCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsXzAdminClsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzAdminCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsXzAdminClsEN>();
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminClsObjLst_Cache.length == 0) return arrXzAdminClsObjLst_Cache;
let arrXzAdminCls_Sel = arrXzAdminClsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objXzAdminCls_Cond = new clsXzAdminClsEN();
ObjectAssign(objXzAdminCls_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsXzAdminClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzAdminCls_Sel.length == 0) return arrXzAdminCls_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrXzAdminCls_Sel = arrXzAdminCls_Sel.sort(XzAdminCls_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrXzAdminCls_Sel = arrXzAdminCls_Sel.sort(objPagerPara.sortFun);
}
arrXzAdminCls_Sel = arrXzAdminCls_Sel.slice(intStart, intEnd);     
return arrXzAdminCls_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzAdminClsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function XzAdminCls_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsXzAdminClsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsXzAdminClsEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzAdminCls_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzAdminCls_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param strid_AdminCls:关键字
 * @returns 获取删除的结果
 **/
export async function XzAdminCls_DelRecordAsync(strid_AdminCls: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_AdminCls);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param arrid_AdminCls:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function XzAdminCls_DelXzAdminClssAsync(arrid_AdminCls: Array<string>): Promise<number> 
{
const strThisFuncName = "DelXzAdminClssAsync";
const strAction = "DelXzAdminClss";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_AdminCls);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_DelXzAdminClssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelXzAdminClssByCondAsync";
const strAction = "DelXzAdminClssByCond";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzAdminCls_AddNewRecordAsync(objXzAdminClsEN: clsXzAdminClsEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objXzAdminClsEN);
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzAdminCls_AddNewRecordWithMaxIdAsync(objXzAdminClsEN: clsXzAdminClsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function XzAdminCls_AddNewRecordWithReturnKeyAsync(objXzAdminClsEN: clsXzAdminClsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function XzAdminCls_AddNewRecordWithReturnKey(objXzAdminClsEN: clsXzAdminClsEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objXzAdminClsEN.id_AdminCls === null || objXzAdminClsEN.id_AdminCls === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function XzAdminCls_UpdateRecordAsync(objXzAdminClsEN: clsXzAdminClsEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objXzAdminClsEN.sfUpdFldSetStr === undefined || objXzAdminClsEN.sfUpdFldSetStr === null || objXzAdminClsEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsEN.id_AdminCls);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminClsEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function XzAdminCls_UpdateWithConditionAsync(objXzAdminClsEN: clsXzAdminClsEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objXzAdminClsEN.sfUpdFldSetStr === undefined || objXzAdminClsEN.sfUpdFldSetStr === null || objXzAdminClsEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsEN.id_AdminCls);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
objXzAdminClsEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objXzAdminClsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objstrid_AdminCls_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzAdminCls_IsExistRecord_Cache(objXzAdminCls_Cond: clsXzAdminClsEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminClsObjLst_Cache == null) return false;
let arrXzAdminCls_Sel: Array < clsXzAdminClsEN > = arrXzAdminClsObjLst_Cache;
if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "") return arrXzAdminCls_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
//console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzAdminCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzAdminCls_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objXzAdminCls_Cond), xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param strid_AdminCls:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function XzAdminCls_IsExist(strid_AdminCls: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_AdminCls": strid_AdminCls,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param strid_AdminCls:所给的关键字
 * @returns 对象
*/
export async function XzAdminCls_IsExist_Cache(strid_AdminCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminClsObjLst_Cache == null) return false;
try
{
const arrXzAdminCls_Sel: Array <clsXzAdminClsEN> = arrXzAdminClsObjLst_Cache.filter(x => x.id_AdminCls == strid_AdminCls);
if (arrXzAdminCls_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_AdminCls, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_AdminCls:关键字
 * @returns 是否存在?存在返回True
 **/
export async function XzAdminCls_IsExistAsync(strid_AdminCls: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_AdminCls": strid_AdminCls }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
 * @param objXzAdminCls_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function XzAdminCls_GetRecCountByCond_Cache(objXzAdminCls_Cond: clsXzAdminClsEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrXzAdminClsObjLst_Cache = await XzAdminCls_GetObjLst_Cache();
if (arrXzAdminClsObjLst_Cache == null) return 0;
let arrXzAdminCls_Sel: Array < clsXzAdminClsEN > = arrXzAdminClsObjLst_Cache;
if (objXzAdminCls_Cond.sf_FldComparisonOp == null || objXzAdminCls_Cond.sf_FldComparisonOp == "") return arrXzAdminCls_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzAdminCls_Cond.sf_FldComparisonOp);
//console.log("clsXzAdminClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzAdminCls_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzAdminCls_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzAdminCls_Sel = arrXzAdminCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzAdminCls_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objXzAdminCls_Cond), xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export async function XzAdminCls_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(xzAdminCls_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzAdminCls_ConstructorName, strThisFuncName);
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
export function XzAdminCls_GetWebApiUrl(strController: string, strAction: string): string {
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
export function XzAdminCls_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsXzAdminClsEN._CurrTabName;
switch (clsXzAdminClsEN.CacheModeId)
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
export function XzAdminCls_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsXzAdminClsEN._CurrTabName;
switch (clsXzAdminClsEN.CacheModeId)
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
export async function XzAdminCls_BindDdl_id_AdminClsInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_AdminClsInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_AdminClsInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_AdminClsInDiv_Cache");
const arrObjLst_Sel = await XzAdminCls_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsXzAdminClsEN.con_id_AdminCls, clsXzAdminClsEN.con_AdminClsName, "行政班");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzAdminCls_CheckPropertyNew(pobjXzAdminClsEN: clsXzAdminClsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzMajor) === true 
 || pobjXzAdminClsEN.id_XzMajor.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[专业流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzCollege) === true 
 || pobjXzAdminClsEN.id_XzCollege.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_GradeBase) === true 
 || pobjXzAdminClsEN.id_GradeBase.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[年级流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminCls) == false && GetStrLen(pobjXzAdminClsEN.id_AdminCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminCls)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsName) == false && GetStrLen(pobjXzAdminClsEN.adminClsName) > 100)
{
 throw new Error("(errid:Watl000059)字段[行政班名称(adminClsName)]的长度不能超过100(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsName)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzMajor) == false && GetStrLen(pobjXzAdminClsEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzMajor)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzCollege) == false && GetStrLen(pobjXzAdminClsEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzCollege)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_UniZone) == false && GetStrLen(pobjXzAdminClsEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_UniZone)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_GradeBase) == false && GetStrLen(pobjXzAdminClsEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_GradeBase)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsId) == false && GetStrLen(pobjXzAdminClsEN.adminClsId) > 8)
{
 throw new Error("(errid:Watl000059)字段[行政班代号(adminClsId)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsId)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminClsType) == false && GetStrLen(pobjXzAdminClsEN.id_AdminClsType) > 4)
{
 throw new Error("(errid:Watl000059)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminClsType)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.memo) == false && GetStrLen(pobjXzAdminClsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.memo)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyUserID) == false && GetStrLen(pobjXzAdminClsEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyUserID)(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyDate) == false && GetStrLen(pobjXzAdminClsEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyDate)(clsXzAdminClsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminCls) == false && undefined !== pobjXzAdminClsEN.id_AdminCls && tzDataType.isString(pobjXzAdminClsEN.id_AdminCls) === false)
{
 throw new Error("(errid:Watl000060)字段[行政班流水号(id_AdminCls)]的值:[$(pobjXzAdminClsEN.id_AdminCls)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsName) == false && undefined !== pobjXzAdminClsEN.adminClsName && tzDataType.isString(pobjXzAdminClsEN.adminClsName) === false)
{
 throw new Error("(errid:Watl000060)字段[行政班名称(adminClsName)]的值:[$(pobjXzAdminClsEN.adminClsName)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzMajor) == false && undefined !== pobjXzAdminClsEN.id_XzMajor && tzDataType.isString(pobjXzAdminClsEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzAdminClsEN.id_XzMajor)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzCollege) == false && undefined !== pobjXzAdminClsEN.id_XzCollege && tzDataType.isString(pobjXzAdminClsEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzAdminClsEN.id_XzCollege)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_UniZone) == false && undefined !== pobjXzAdminClsEN.id_UniZone && tzDataType.isString(pobjXzAdminClsEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjXzAdminClsEN.id_UniZone)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (null != pobjXzAdminClsEN.currentStuQty && undefined !== pobjXzAdminClsEN.currentStuQty && tzDataType.isNumber(pobjXzAdminClsEN.currentStuQty) === false)
{
 throw new Error("(errid:Watl000060)字段[当前学生数(currentStuQty)]的值:[$(pobjXzAdminClsEN.currentStuQty)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_GradeBase) == false && undefined !== pobjXzAdminClsEN.id_GradeBase && tzDataType.isString(pobjXzAdminClsEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzAdminClsEN.id_GradeBase)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsId) == false && undefined !== pobjXzAdminClsEN.adminClsId && tzDataType.isString(pobjXzAdminClsEN.adminClsId) === false)
{
 throw new Error("(errid:Watl000060)字段[行政班代号(adminClsId)]的值:[$(pobjXzAdminClsEN.adminClsId)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsEN.id_AdminClsType && tzDataType.isString(pobjXzAdminClsEN.id_AdminClsType) === false)
{
 throw new Error("(errid:Watl000060)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsEN.id_AdminClsType)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (null != pobjXzAdminClsEN.adminClsIndex && undefined !== pobjXzAdminClsEN.adminClsIndex && tzDataType.isNumber(pobjXzAdminClsEN.adminClsIndex) === false)
{
 throw new Error("(errid:Watl000060)字段[AdminClsIndex(adminClsIndex)]的值:[$(pobjXzAdminClsEN.adminClsIndex)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.memo) == false && undefined !== pobjXzAdminClsEN.memo && tzDataType.isString(pobjXzAdminClsEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzAdminClsEN.memo)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyUserID) == false && undefined !== pobjXzAdminClsEN.modifyUserID && tzDataType.isString(pobjXzAdminClsEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzAdminClsEN.modifyUserID)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyDate) == false && undefined !== pobjXzAdminClsEN.modifyDate && tzDataType.isString(pobjXzAdminClsEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzAdminClsEN.modifyDate)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjXzAdminClsEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzAdminCls_CheckProperty4Update (pobjXzAdminClsEN: clsXzAdminClsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminCls) == false && GetStrLen(pobjXzAdminClsEN.id_AdminCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminCls)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsName) == false && GetStrLen(pobjXzAdminClsEN.adminClsName) > 100)
{
 throw new Error("(errid:Watl000062)字段[行政班名称(adminClsName)]的长度不能超过100(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsName)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzMajor) == false && GetStrLen(pobjXzAdminClsEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzMajor)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzCollege) == false && GetStrLen(pobjXzAdminClsEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_XzCollege)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_UniZone) == false && GetStrLen(pobjXzAdminClsEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_UniZone)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_GradeBase) == false && GetStrLen(pobjXzAdminClsEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_GradeBase)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsId) == false && GetStrLen(pobjXzAdminClsEN.adminClsId) > 8)
{
 throw new Error("(errid:Watl000062)字段[行政班代号(adminClsId)]的长度不能超过8(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.adminClsId)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminClsType) == false && GetStrLen(pobjXzAdminClsEN.id_AdminClsType) > 4)
{
 throw new Error("(errid:Watl000062)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.id_AdminClsType)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.memo) == false && GetStrLen(pobjXzAdminClsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.memo)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyUserID) == false && GetStrLen(pobjXzAdminClsEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyUserID)(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyDate) == false && GetStrLen(pobjXzAdminClsEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 行政班(XzAdminCls))!值:$(pobjXzAdminClsEN.modifyDate)(clsXzAdminClsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminCls) == false && undefined !== pobjXzAdminClsEN.id_AdminCls && tzDataType.isString(pobjXzAdminClsEN.id_AdminCls) === false)
{
 throw new Error("(errid:Watl000063)字段[行政班流水号(id_AdminCls)]的值:[$(pobjXzAdminClsEN.id_AdminCls)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsName) == false && undefined !== pobjXzAdminClsEN.adminClsName && tzDataType.isString(pobjXzAdminClsEN.adminClsName) === false)
{
 throw new Error("(errid:Watl000063)字段[行政班名称(adminClsName)]的值:[$(pobjXzAdminClsEN.adminClsName)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzMajor) == false && undefined !== pobjXzAdminClsEN.id_XzMajor && tzDataType.isString(pobjXzAdminClsEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjXzAdminClsEN.id_XzMajor)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_XzCollege) == false && undefined !== pobjXzAdminClsEN.id_XzCollege && tzDataType.isString(pobjXzAdminClsEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjXzAdminClsEN.id_XzCollege)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_UniZone) == false && undefined !== pobjXzAdminClsEN.id_UniZone && tzDataType.isString(pobjXzAdminClsEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjXzAdminClsEN.id_UniZone)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (null != pobjXzAdminClsEN.currentStuQty && undefined !== pobjXzAdminClsEN.currentStuQty && tzDataType.isNumber(pobjXzAdminClsEN.currentStuQty) === false)
{
 throw new Error("(errid:Watl000063)字段[当前学生数(currentStuQty)]的值:[$(pobjXzAdminClsEN.currentStuQty)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_GradeBase) == false && undefined !== pobjXzAdminClsEN.id_GradeBase && tzDataType.isString(pobjXzAdminClsEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzAdminClsEN.id_GradeBase)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.adminClsId) == false && undefined !== pobjXzAdminClsEN.adminClsId && tzDataType.isString(pobjXzAdminClsEN.adminClsId) === false)
{
 throw new Error("(errid:Watl000063)字段[行政班代号(adminClsId)]的值:[$(pobjXzAdminClsEN.adminClsId)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsEN.id_AdminClsType && tzDataType.isString(pobjXzAdminClsEN.id_AdminClsType) === false)
{
 throw new Error("(errid:Watl000063)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsEN.id_AdminClsType)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (null != pobjXzAdminClsEN.adminClsIndex && undefined !== pobjXzAdminClsEN.adminClsIndex && tzDataType.isNumber(pobjXzAdminClsEN.adminClsIndex) === false)
{
 throw new Error("(errid:Watl000063)字段[AdminClsIndex(adminClsIndex)]的值:[$(pobjXzAdminClsEN.adminClsIndex)], 非法，应该为数值型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.memo) == false && undefined !== pobjXzAdminClsEN.memo && tzDataType.isString(pobjXzAdminClsEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzAdminClsEN.memo)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyUserID) == false && undefined !== pobjXzAdminClsEN.modifyUserID && tzDataType.isString(pobjXzAdminClsEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzAdminClsEN.modifyUserID)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzAdminClsEN.modifyDate) == false && undefined !== pobjXzAdminClsEN.modifyDate && tzDataType.isString(pobjXzAdminClsEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzAdminClsEN.modifyDate)], 非法，应该为字符型(In 行政班(XzAdminCls))!(clsXzAdminClsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjXzAdminClsEN.id_AdminCls) === true 
 || pobjXzAdminClsEN.id_AdminCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[行政班流水号]不能为空(In 行政班)!(clsXzAdminClsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjXzAdminClsEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzAdminCls_GetJSONStrByObj (pobjXzAdminClsEN: clsXzAdminClsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjXzAdminClsEN.sfUpdFldSetStr = pobjXzAdminClsEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjXzAdminClsEN);
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
export function XzAdminCls_GetObjLstByJSONStr (strJSON: string): Array<clsXzAdminClsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrXzAdminClsObjLst = new Array<clsXzAdminClsEN>();
if (strJSON === "")
{
return arrXzAdminClsObjLst;
}
try
{
arrXzAdminClsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrXzAdminClsObjLst;
}
return arrXzAdminClsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrXzAdminClsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function XzAdminCls_GetObjLstByJSONObjLst (arrXzAdminClsObjLstS: Array<clsXzAdminClsEN>): Array<clsXzAdminClsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrXzAdminClsObjLst = new Array<clsXzAdminClsEN>();
for (const objInFor of arrXzAdminClsObjLstS) {
const obj1 = XzAdminCls_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrXzAdminClsObjLst.push(obj1);
}
return arrXzAdminClsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzAdminCls_GetObjByJSONStr (strJSON: string): clsXzAdminClsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjXzAdminClsEN = new clsXzAdminClsEN();
if (strJSON === "")
{
return pobjXzAdminClsEN;
}
try
{
pobjXzAdminClsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjXzAdminClsEN;
}
return pobjXzAdminClsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function XzAdminCls_GetCombineCondition(objXzAdminCls_Cond: clsXzAdminClsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_AdminCls) == true)
{
const strComparisonOp_id_AdminCls:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_AdminCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_AdminCls, objXzAdminCls_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_AdminClsName) == true)
{
const strComparisonOp_AdminClsName:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_AdminClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_AdminClsName, objXzAdminCls_Cond.adminClsName, strComparisonOp_AdminClsName);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_XzMajor, objXzAdminCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_XzCollege, objXzAdminCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_UniZone, objXzAdminCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_CurrentStuQty) == true)
{
const strComparisonOp_CurrentStuQty:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_CurrentStuQty];
strWhereCond += Format(" And {0} {2} {1}", clsXzAdminClsEN.con_CurrentStuQty, objXzAdminCls_Cond.currentStuQty, strComparisonOp_CurrentStuQty);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_GradeBase, objXzAdminCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_AdminClsId) == true)
{
const strComparisonOp_AdminClsId:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_AdminClsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_AdminClsId, objXzAdminCls_Cond.adminClsId, strComparisonOp_AdminClsId);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_id_AdminClsType) == true)
{
const strComparisonOp_id_AdminClsType:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_id_AdminClsType];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_id_AdminClsType, objXzAdminCls_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_AdminClsIndex) == true)
{
const strComparisonOp_AdminClsIndex:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_AdminClsIndex];
strWhereCond += Format(" And {0} {2} {1}", clsXzAdminClsEN.con_AdminClsIndex, objXzAdminCls_Cond.adminClsIndex, strComparisonOp_AdminClsIndex);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_Memo, objXzAdminCls_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_ModifyUserID, objXzAdminCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objXzAdminCls_Cond.dicFldComparisonOp, clsXzAdminClsEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objXzAdminCls_Cond.dicFldComparisonOp[clsXzAdminClsEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzAdminClsEN.con_ModifyDate, objXzAdminCls_Cond.modifyDate, strComparisonOp_ModifyDate);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--XzAdminCls(行政班),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strAdminClsName: 行政班名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function XzAdminCls_GetUniCondStr_AdminClsName(objXzAdminClsEN: clsXzAdminClsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and AdminClsName = '{0}'", objXzAdminClsEN.adminClsName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--XzAdminCls(行政班),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strAdminClsName: 行政班名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function XzAdminCls_GetUniCondStr4Update_AdminClsName(objXzAdminClsEN: clsXzAdminClsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_AdminCls <> '{0}'", objXzAdminClsEN.id_AdminCls);
 strWhereCond +=  Format(" and AdminClsName = '{0}'", objXzAdminClsEN.adminClsName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objXzAdminClsENS:源对象
 * @param objXzAdminClsENT:目标对象
*/
export function XzAdminCls_CopyObjTo(objXzAdminClsENS: clsXzAdminClsEN , objXzAdminClsENT: clsXzAdminClsEN ): void 
{
objXzAdminClsENT.id_AdminCls = objXzAdminClsENS.id_AdminCls; //行政班流水号
objXzAdminClsENT.adminClsName = objXzAdminClsENS.adminClsName; //行政班名称
objXzAdminClsENT.id_XzMajor = objXzAdminClsENS.id_XzMajor; //专业流水号
objXzAdminClsENT.id_XzCollege = objXzAdminClsENS.id_XzCollege; //学院流水号
objXzAdminClsENT.id_UniZone = objXzAdminClsENS.id_UniZone; //校区流水号
objXzAdminClsENT.currentStuQty = objXzAdminClsENS.currentStuQty; //当前学生数
objXzAdminClsENT.id_GradeBase = objXzAdminClsENS.id_GradeBase; //年级流水号
objXzAdminClsENT.adminClsId = objXzAdminClsENS.adminClsId; //行政班代号
objXzAdminClsENT.id_AdminClsType = objXzAdminClsENS.id_AdminClsType; //行政班级类型流水号
objXzAdminClsENT.adminClsIndex = objXzAdminClsENS.adminClsIndex; //AdminClsIndex
objXzAdminClsENT.memo = objXzAdminClsENS.memo; //备注
objXzAdminClsENT.modifyUserID = objXzAdminClsENS.modifyUserID; //修改人
objXzAdminClsENT.modifyDate = objXzAdminClsENS.modifyDate; //修改日期
objXzAdminClsENT.sfUpdFldSetStr = objXzAdminClsENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objXzAdminClsENS:源对象
 * @param objXzAdminClsENT:目标对象
*/
export function XzAdminCls_GetObjFromJsonObj(objXzAdminClsENS: clsXzAdminClsEN): clsXzAdminClsEN 
{
 const objXzAdminClsENT: clsXzAdminClsEN = new clsXzAdminClsEN();
ObjectAssign(objXzAdminClsENT, objXzAdminClsENS);
 return objXzAdminClsENT;
}