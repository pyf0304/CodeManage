
 /**
 * 类名:clsXzGradeBaseWApi
 * 表名:XzGradeBase(01120129)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:38
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 年级(XzGradeBase)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsXzGradeBaseEN } from "../../L0_Entity/SysPara/clsXzGradeBaseEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const xzGradeBase_Controller = "XzGradeBaseApi";
 export const xzGradeBase_ConstructorName = "xzGradeBase";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_GradeBase:关键字
 * @returns 对象
 **/
export async function XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase: string): Promise<clsXzGradeBaseEN|null>  
{
const strThisFuncName = "GetObjByid_GradeBaseAsync";

if (IsNullOrEmpty(strid_GradeBase) == true)
{
  const strMsg = Format("参数:[strid_GradeBase]不能为空！(In clsXzGradeBaseWApi.GetObjByid_GradeBaseAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_GradeBase.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！(clsXzGradeBaseWApi.GetObjByid_GradeBaseAsync)", strid_GradeBase.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_GradeBase";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_GradeBase": strid_GradeBase,
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
const objXzGradeBase = XzGradeBase_GetObjFromJsonObj(returnObj);
return objXzGradeBase;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:所给的关键字
 * @returns 对象
*/
export async function XzGradeBase_GetObjByid_GradeBase_Cache(strid_GradeBase: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_GradeBase_Cache";

if (IsNullOrEmpty(strid_GradeBase) == true)
{
  const strMsg = Format("参数:[strid_GradeBase]不能为空！(In clsXzGradeBaseWApi.GetObjByid_GradeBase_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_GradeBase.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！(clsXzGradeBaseWApi.GetObjByid_GradeBase_Cache)", strid_GradeBase.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
try
{
const arrXzGradeBase_Sel: Array <clsXzGradeBaseEN> = arrXzGradeBaseObjLst_Cache.filter(x => 
 x.id_GradeBase == strid_GradeBase );
let objXzGradeBase: clsXzGradeBaseEN;
if (arrXzGradeBase_Sel.length > 0)
{
objXzGradeBase = arrXzGradeBase_Sel[0];
return objXzGradeBase;
}
else
{
if (bolTryAsyncOnce == true)
{
const objXzGradeBase_Const = await XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase);
if (objXzGradeBase_Const != null)
{
XzGradeBase_ReFreshThisCache();
return objXzGradeBase_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_GradeBase, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_GradeBase:所给的关键字
 * @returns 对象
*/
export async function XzGradeBase_GetObjByid_GradeBase_localStorage(strid_GradeBase: string) {
const strThisFuncName = "GetObjByid_GradeBase_localStorage";

if (IsNullOrEmpty(strid_GradeBase) == true)
{
  const strMsg = Format("参数:[strid_GradeBase]不能为空！(In clsXzGradeBaseWApi.GetObjByid_GradeBase_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_GradeBase.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！(clsXzGradeBaseWApi.GetObjByid_GradeBase_localStorage)", strid_GradeBase.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsXzGradeBaseEN._CurrTabName, strid_GradeBase);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objXzGradeBase_Cache: clsXzGradeBaseEN = JSON.parse(strTempObj);
return objXzGradeBase_Cache;
}
try
{
const objXzGradeBase = await XzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase);
if (objXzGradeBase != null)
{
localStorage.setItem(strKey, JSON.stringify(objXzGradeBase));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objXzGradeBase;
}
return objXzGradeBase;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_GradeBase, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objXzGradeBase:所给的对象
 * @returns 对象
*/
export async function XzGradeBase_UpdateObjInLst_Cache(objXzGradeBase: clsXzGradeBaseEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
const obj = arrXzGradeBaseObjLst_Cache.find(x => 
x.id_GradeBase == objXzGradeBase.id_GradeBase);
if (obj != null)
{
objXzGradeBase.id_GradeBase = obj.id_GradeBase;
ObjectAssign( obj, objXzGradeBase);
}
else
{
arrXzGradeBaseObjLst_Cache.push(objXzGradeBase);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_GradeBase:所给的关键字
 * @returns 对象
*/
export async function XzGradeBase_GetNameByid_GradeBase_Cache(strid_GradeBase: string) {
const strThisFuncName = "GetNameByid_GradeBase_Cache";

if (IsNullOrEmpty(strid_GradeBase) == true)
{
  const strMsg = Format("参数:[strid_GradeBase]不能为空！(In clsXzGradeBaseWApi.GetNameByid_GradeBase_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_GradeBase.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！(clsXzGradeBaseWApi.GetNameByid_GradeBase_Cache)", strid_GradeBase.length);
console.error(strMsg);
throw (strMsg);
}
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBaseObjLst_Cache == null) return "";
try
{
const arrXzGradeBase_Sel: Array <clsXzGradeBaseEN> = arrXzGradeBaseObjLst_Cache.filter(x => 
 x.id_GradeBase == strid_GradeBase );
let objXzGradeBase: clsXzGradeBaseEN;
if (arrXzGradeBase_Sel.length > 0)
{
objXzGradeBase = arrXzGradeBase_Sel[0];
return objXzGradeBase.gradeBaseName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_GradeBase);
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
export async function XzGradeBase_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsXzGradeBaseEN.con_id_GradeBase)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsXzGradeBaseEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsXzGradeBaseEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_GradeBase = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objXzGradeBase = await XzGradeBase_GetObjByid_GradeBase_Cache(strid_GradeBase );
if (objXzGradeBase == null) return "";
if (objXzGradeBase.GetFldValue(strOutFldName) == null) return "";
return objXzGradeBase.GetFldValue(strOutFldName).toString();
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
export function XzGradeBase_SortFun_Defa(a:clsXzGradeBaseEN , b:clsXzGradeBaseEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_GradeBase.localeCompare(b.id_GradeBase);
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
export function XzGradeBase_SortFun_Defa_2Fld(a:clsXzGradeBaseEN , b:clsXzGradeBaseEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.gradeBaseID == b.gradeBaseID) return a.gradeBaseName.localeCompare(b.gradeBaseName);
else return a.gradeBaseID.localeCompare(b.gradeBaseID);
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
export function XzGradeBase_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsXzGradeBaseEN.con_id_GradeBase:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsXzGradeBaseEN.con_GradeBaseID:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.gradeBaseID.localeCompare(b.gradeBaseID);
}
case clsXzGradeBaseEN.con_GradeBaseName:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsXzGradeBaseEN.con_GradeBaseNameA:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.gradeBaseNameA == null) return -1;
if (b.gradeBaseNameA == null) return 1;
return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
}
case clsXzGradeBaseEN.con_SchoolYear:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsXzGradeBaseEN.con_SchoolTerm:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsXzGradeBaseEN.con_EnterSchoolDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.enterSchoolDate == null) return -1;
if (b.enterSchoolDate == null) return 1;
return a.enterSchoolDate.localeCompare(b.enterSchoolDate);
}
case clsXzGradeBaseEN.con_CurrentTermSeq:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.currentTermSeq-b.currentTermSeq;
}
case clsXzGradeBaseEN.con_ExecPlanTermIndex:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.execPlanTermIndex-b.execPlanTermIndex;
}
case clsXzGradeBaseEN.con_SetEPTermIndexDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.setEPTermIndexDate == null) return -1;
if (b.setEPTermIndexDate == null) return 1;
return a.setEPTermIndexDate.localeCompare(b.setEPTermIndexDate);
}
case clsXzGradeBaseEN.con_IsOffed:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.isOffed == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_GradeIndex:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return a.gradeIndex-b.gradeIndex;
}
case clsXzGradeBaseEN.con_BeginYearMonth:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.beginYearMonth == null) return -1;
if (b.beginYearMonth == null) return 1;
return a.beginYearMonth.localeCompare(b.beginYearMonth);
}
case clsXzGradeBaseEN.con_EndYearMonth:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.endYearMonth == null) return -1;
if (b.endYearMonth == null) return 1;
return a.endYearMonth.localeCompare(b.endYearMonth);
}
case clsXzGradeBaseEN.con_AllowUpBaseInfo:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.allowUpBaseInfo == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_Prefix:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.prefix == null) return -1;
if (b.prefix == null) return 1;
return a.prefix.localeCompare(b.prefix);
}
case clsXzGradeBaseEN.con_PointCalcVersionId:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.pointCalcVersionId == null) return -1;
if (b.pointCalcVersionId == null) return 1;
return a.pointCalcVersionId.localeCompare(b.pointCalcVersionId);
}
case clsXzGradeBaseEN.con_ModifyUserID:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.modifyUserID == null) return -1;
if (b.modifyUserID == null) return 1;
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsXzGradeBaseEN.con_ModifyDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.modifyDate == null) return -1;
if (b.modifyDate == null) return 1;
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsXzGradeBaseEN.con_id_StudyLevel:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.id_StudyLevel == null) return -1;
if (b.id_StudyLevel == null) return 1;
return a.id_StudyLevel.localeCompare(b.id_StudyLevel);
}
case clsXzGradeBaseEN.con_IsVisible:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_Memo:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${ xzGradeBase_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsXzGradeBaseEN.con_id_GradeBase:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsXzGradeBaseEN.con_GradeBaseID:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.gradeBaseID.localeCompare(a.gradeBaseID);
}
case clsXzGradeBaseEN.con_GradeBaseName:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsXzGradeBaseEN.con_GradeBaseNameA:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.gradeBaseNameA == null) return -1;
if (a.gradeBaseNameA == null) return 1;
return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
}
case clsXzGradeBaseEN.con_SchoolYear:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsXzGradeBaseEN.con_SchoolTerm:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsXzGradeBaseEN.con_EnterSchoolDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.enterSchoolDate == null) return -1;
if (a.enterSchoolDate == null) return 1;
return b.enterSchoolDate.localeCompare(a.enterSchoolDate);
}
case clsXzGradeBaseEN.con_CurrentTermSeq:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.currentTermSeq-a.currentTermSeq;
}
case clsXzGradeBaseEN.con_ExecPlanTermIndex:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.execPlanTermIndex-a.execPlanTermIndex;
}
case clsXzGradeBaseEN.con_SetEPTermIndexDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.setEPTermIndexDate == null) return -1;
if (a.setEPTermIndexDate == null) return 1;
return b.setEPTermIndexDate.localeCompare(a.setEPTermIndexDate);
}
case clsXzGradeBaseEN.con_IsOffed:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.isOffed == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_GradeIndex:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
return b.gradeIndex-a.gradeIndex;
}
case clsXzGradeBaseEN.con_BeginYearMonth:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.beginYearMonth == null) return -1;
if (a.beginYearMonth == null) return 1;
return b.beginYearMonth.localeCompare(a.beginYearMonth);
}
case clsXzGradeBaseEN.con_EndYearMonth:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.endYearMonth == null) return -1;
if (a.endYearMonth == null) return 1;
return b.endYearMonth.localeCompare(a.endYearMonth);
}
case clsXzGradeBaseEN.con_AllowUpBaseInfo:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.allowUpBaseInfo == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_Prefix:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.prefix == null) return -1;
if (a.prefix == null) return 1;
return b.prefix.localeCompare(a.prefix);
}
case clsXzGradeBaseEN.con_PointCalcVersionId:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.pointCalcVersionId == null) return -1;
if (a.pointCalcVersionId == null) return 1;
return b.pointCalcVersionId.localeCompare(a.pointCalcVersionId);
}
case clsXzGradeBaseEN.con_ModifyUserID:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.modifyUserID == null) return -1;
if (a.modifyUserID == null) return 1;
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsXzGradeBaseEN.con_ModifyDate:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.modifyDate == null) return -1;
if (a.modifyDate == null) return 1;
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsXzGradeBaseEN.con_id_StudyLevel:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.id_StudyLevel == null) return -1;
if (a.id_StudyLevel == null) return 1;
return b.id_StudyLevel.localeCompare(a.id_StudyLevel);
}
case clsXzGradeBaseEN.con_IsVisible:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsXzGradeBaseEN.con_Memo:
return (a: clsXzGradeBaseEN, b: clsXzGradeBaseEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${ xzGradeBase_ConstructorName}.${ strThisFuncName})`;
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
export async function XzGradeBase_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsXzGradeBaseEN.con_id_GradeBase:
return (obj: clsXzGradeBaseEN) => {
return obj.id_GradeBase === value;
}
case clsXzGradeBaseEN.con_GradeBaseID:
return (obj: clsXzGradeBaseEN) => {
return obj.gradeBaseID === value;
}
case clsXzGradeBaseEN.con_GradeBaseName:
return (obj: clsXzGradeBaseEN) => {
return obj.gradeBaseName === value;
}
case clsXzGradeBaseEN.con_GradeBaseNameA:
return (obj: clsXzGradeBaseEN) => {
return obj.gradeBaseNameA === value;
}
case clsXzGradeBaseEN.con_SchoolYear:
return (obj: clsXzGradeBaseEN) => {
return obj.schoolYear === value;
}
case clsXzGradeBaseEN.con_SchoolTerm:
return (obj: clsXzGradeBaseEN) => {
return obj.schoolTerm === value;
}
case clsXzGradeBaseEN.con_EnterSchoolDate:
return (obj: clsXzGradeBaseEN) => {
return obj.enterSchoolDate === value;
}
case clsXzGradeBaseEN.con_CurrentTermSeq:
return (obj: clsXzGradeBaseEN) => {
return obj.currentTermSeq === value;
}
case clsXzGradeBaseEN.con_ExecPlanTermIndex:
return (obj: clsXzGradeBaseEN) => {
return obj.execPlanTermIndex === value;
}
case clsXzGradeBaseEN.con_SetEPTermIndexDate:
return (obj: clsXzGradeBaseEN) => {
return obj.setEPTermIndexDate === value;
}
case clsXzGradeBaseEN.con_IsOffed:
return (obj: clsXzGradeBaseEN) => {
return obj.isOffed === value;
}
case clsXzGradeBaseEN.con_GradeIndex:
return (obj: clsXzGradeBaseEN) => {
return obj.gradeIndex === value;
}
case clsXzGradeBaseEN.con_BeginYearMonth:
return (obj: clsXzGradeBaseEN) => {
return obj.beginYearMonth === value;
}
case clsXzGradeBaseEN.con_EndYearMonth:
return (obj: clsXzGradeBaseEN) => {
return obj.endYearMonth === value;
}
case clsXzGradeBaseEN.con_AllowUpBaseInfo:
return (obj: clsXzGradeBaseEN) => {
return obj.allowUpBaseInfo === value;
}
case clsXzGradeBaseEN.con_Prefix:
return (obj: clsXzGradeBaseEN) => {
return obj.prefix === value;
}
case clsXzGradeBaseEN.con_PointCalcVersionId:
return (obj: clsXzGradeBaseEN) => {
return obj.pointCalcVersionId === value;
}
case clsXzGradeBaseEN.con_ModifyUserID:
return (obj: clsXzGradeBaseEN) => {
return obj.modifyUserID === value;
}
case clsXzGradeBaseEN.con_ModifyDate:
return (obj: clsXzGradeBaseEN) => {
return obj.modifyDate === value;
}
case clsXzGradeBaseEN.con_id_StudyLevel:
return (obj: clsXzGradeBaseEN) => {
return obj.id_StudyLevel === value;
}
case clsXzGradeBaseEN.con_IsVisible:
return (obj: clsXzGradeBaseEN) => {
return obj.isVisible === value;
}
case clsXzGradeBaseEN.con_Memo:
return (obj: clsXzGradeBaseEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[XzGradeBase]中不存在！(in ${ xzGradeBase_ConstructorName}.${ strThisFuncName})`;
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
export async function XzGradeBase_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsXzGradeBaseEN.con_id_GradeBase)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrXzGradeBase = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBase == null) return [];
let arrXzGradeBase_Sel = arrXzGradeBase;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrXzGradeBase_Sel.length == 0) return [];
return arrXzGradeBase_Sel.map(x=>x.id_GradeBase);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function XzGradeBase_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetFirstObjAsync(strWhereCond: string): Promise<clsXzGradeBaseEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const objXzGradeBase = XzGradeBase_GetObjFromJsonObj(returnObj);
return objXzGradeBase;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzGradeBaseEN._CurrTabName;
if (IsNullOrEmpty(clsXzGradeBaseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzGradeBaseEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrXzGradeBaseExObjLst_Cache: Array<clsXzGradeBaseEN> = CacheHelper.Get(strKey);
const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
return arrXzGradeBaseObjLst_T;
}
try
{
const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrXzGradeBaseExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
console.log(strInfo);
return arrXzGradeBaseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzGradeBase_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzGradeBaseEN._CurrTabName;
if (IsNullOrEmpty(clsXzGradeBaseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzGradeBaseEN.CacheAddiCondition);
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
const arrXzGradeBaseExObjLst_Cache: Array<clsXzGradeBaseEN> = JSON.parse(strTempObjLst);
const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
return arrXzGradeBaseObjLst_T;
}
try
{
const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrXzGradeBaseExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
console.log(strInfo);
return arrXzGradeBaseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzGradeBase_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzGradeBaseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrXzGradeBaseObjLst_Cache: Array<clsXzGradeBaseEN> = JSON.parse(strTempObjLst);
return arrXzGradeBaseObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function XzGradeBase_GetObjLstAsync(strWhereCond: string): Promise<Array<clsXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsXzGradeBaseEN._CurrTabName;
if (IsNullOrEmpty(clsXzGradeBaseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsXzGradeBaseEN.CacheAddiCondition);
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
const arrXzGradeBaseExObjLst_Cache: Array<clsXzGradeBaseEN> = JSON.parse(strTempObjLst);
const arrXzGradeBaseObjLst_T = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseExObjLst_Cache);
return arrXzGradeBaseObjLst_T;
}
try
{
const arrXzGradeBaseExObjLst = await XzGradeBase_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrXzGradeBaseExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzGradeBaseExObjLst.length);
console.log(strInfo);
return arrXzGradeBaseExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzGradeBase_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsXzGradeBaseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrXzGradeBaseObjLst_Cache: Array<clsXzGradeBaseEN> = JSON.parse(strTempObjLst);
return arrXzGradeBaseObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzGradeBase_GetObjLst_Cache(): Promise<Array<clsXzGradeBaseEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrXzGradeBaseObjLst_Cache;
switch (clsXzGradeBaseEN.CacheModeId)
{
case "04"://sessionStorage
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_ClientCache();
break;
default:
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_ClientCache();
break;
}
const arrXzGradeBaseObjLst = XzGradeBase_GetObjLstByJSONObjLst(arrXzGradeBaseObjLst_Cache);
return arrXzGradeBaseObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function XzGradeBase_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrXzGradeBaseObjLst_Cache;
switch (clsXzGradeBaseEN.CacheModeId)
{
case "04"://sessionStorage
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrXzGradeBaseObjLst_Cache = null;
break;
default:
arrXzGradeBaseObjLst_Cache = null;
break;
}
return arrXzGradeBaseObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_GradeBase_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzGradeBase_GetSubObjLst_Cache(objXzGradeBase_Cond: clsXzGradeBaseEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
let arrXzGradeBase_Sel: Array < clsXzGradeBaseEN > = arrXzGradeBaseObjLst_Cache;
if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "") return arrXzGradeBase_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
//console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzGradeBase_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzGradeBase_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objXzGradeBase_Cond), xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzGradeBaseEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_GradeBase:关键字列表
 * @returns 对象列表
 **/
export async function XzGradeBase_GetObjLstByid_GradeBaseLstAsync(arrid_GradeBase: Array<string>): Promise<Array<clsXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByid_GradeBaseLstAsync";
const strAction = "GetObjLstByid_GradeBaseLst";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_GradeBase);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param arrstrid_GradeBaseLst:关键字列表
 * @returns 对象列表
*/
export async function XzGradeBase_GetObjLstByid_GradeBaseLst_Cache(arrid_GradeBaseLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_GradeBaseLst_Cache";
try
{
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
const arrXzGradeBase_Sel: Array <clsXzGradeBaseEN> = arrXzGradeBaseObjLst_Cache.filter(x => arrid_GradeBaseLst.indexOf(x.id_GradeBase)>-1);
return arrXzGradeBase_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_GradeBaseLst.join(","), xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsXzGradeBaseEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsXzGradeBaseEN>();
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBaseObjLst_Cache.length == 0) return arrXzGradeBaseObjLst_Cache;
let arrXzGradeBase_Sel = arrXzGradeBaseObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objXzGradeBase_Cond = new clsXzGradeBaseEN();
ObjectAssign(objXzGradeBase_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsXzGradeBaseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzGradeBase_Sel.length == 0) return arrXzGradeBase_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrXzGradeBase_Sel = arrXzGradeBase_Sel.sort(XzGradeBase_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrXzGradeBase_Sel = arrXzGradeBase_Sel.sort(objPagerPara.sortFun);
}
arrXzGradeBase_Sel = arrXzGradeBase_Sel.slice(intStart, intEnd);     
return arrXzGradeBase_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsXzGradeBaseEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function XzGradeBase_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsXzGradeBaseEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", xzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = XzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:关键字
 * @returns 获取删除的结果
 **/
export async function XzGradeBase_DelRecordAsync(strid_GradeBase: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_GradeBase);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param arrid_GradeBase:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function XzGradeBase_DelXzGradeBasesAsync(arrid_GradeBase: Array<string>): Promise<number> 
{
const strThisFuncName = "DelXzGradeBasesAsync";
const strAction = "DelXzGradeBases";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_GradeBase);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_DelXzGradeBasesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelXzGradeBasesByCondAsync";
const strAction = "DelXzGradeBasesByCond";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzGradeBase_AddNewRecordAsync(objXzGradeBaseEN: clsXzGradeBaseEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objXzGradeBaseEN.id_GradeBase === null || objXzGradeBaseEN.id_GradeBase === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objXzGradeBaseEN);
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function XzGradeBase_AddNewRecordWithMaxIdAsync(objXzGradeBaseEN: clsXzGradeBaseEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function XzGradeBase_AddNewRecordWithReturnKeyAsync(objXzGradeBaseEN: clsXzGradeBaseEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function XzGradeBase_AddNewRecordWithReturnKey(objXzGradeBaseEN: clsXzGradeBaseEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objXzGradeBaseEN.id_GradeBase === null || objXzGradeBaseEN.id_GradeBase === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function XzGradeBase_UpdateRecordAsync(objXzGradeBaseEN: clsXzGradeBaseEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objXzGradeBaseEN.sfUpdFldSetStr === undefined || objXzGradeBaseEN.sfUpdFldSetStr === null || objXzGradeBaseEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzGradeBaseEN.id_GradeBase);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBaseEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function XzGradeBase_UpdateWithConditionAsync(objXzGradeBaseEN: clsXzGradeBaseEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objXzGradeBaseEN.sfUpdFldSetStr === undefined || objXzGradeBaseEN.sfUpdFldSetStr === null || objXzGradeBaseEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzGradeBaseEN.id_GradeBase);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
objXzGradeBaseEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objXzGradeBaseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objstrid_GradeBase_Cond:条件对象
 * @returns 对象列表子集
*/
export async function XzGradeBase_IsExistRecord_Cache(objXzGradeBase_Cond: clsXzGradeBaseEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBaseObjLst_Cache == null) return false;
let arrXzGradeBase_Sel: Array < clsXzGradeBaseEN > = arrXzGradeBaseObjLst_Cache;
if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "") return arrXzGradeBase_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
//console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzGradeBase_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrXzGradeBase_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objXzGradeBase_Cond), xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function XzGradeBase_IsExist(strid_GradeBase: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_GradeBase": strid_GradeBase,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:所给的关键字
 * @returns 对象
*/
export async function XzGradeBase_IsExist_Cache(strid_GradeBase:string) {
const strThisFuncName = "IsExist_Cache";
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBaseObjLst_Cache == null) return false;
try
{
const arrXzGradeBase_Sel: Array <clsXzGradeBaseEN> = arrXzGradeBaseObjLst_Cache.filter(x => x.id_GradeBase == strid_GradeBase);
if (arrXzGradeBase_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_GradeBase, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_GradeBase:关键字
 * @returns 是否存在?存在返回True
 **/
export async function XzGradeBase_IsExistAsync(strid_GradeBase: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_GradeBase": strid_GradeBase }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
 * @param objXzGradeBase_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function XzGradeBase_GetRecCountByCond_Cache(objXzGradeBase_Cond: clsXzGradeBaseEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrXzGradeBaseObjLst_Cache = await XzGradeBase_GetObjLst_Cache();
if (arrXzGradeBaseObjLst_Cache == null) return 0;
let arrXzGradeBase_Sel: Array < clsXzGradeBaseEN > = arrXzGradeBaseObjLst_Cache;
if (objXzGradeBase_Cond.sf_FldComparisonOp == null || objXzGradeBase_Cond.sf_FldComparisonOp == "") return arrXzGradeBase_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objXzGradeBase_Cond.sf_FldComparisonOp);
//console.log("clsXzGradeBaseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objXzGradeBase_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objXzGradeBase_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrXzGradeBase_Sel = arrXzGradeBase_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrXzGradeBase_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objXzGradeBase_Cond), xzGradeBase_ConstructorName, strThisFuncName);
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
export async function XzGradeBase_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(xzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, xzGradeBase_ConstructorName, strThisFuncName);
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
export function XzGradeBase_GetWebApiUrl(strController: string, strAction: string): string {
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
export function XzGradeBase_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsXzGradeBaseEN._CurrTabName;
switch (clsXzGradeBaseEN.CacheModeId)
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
export function XzGradeBase_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsXzGradeBaseEN._CurrTabName;
switch (clsXzGradeBaseEN.CacheModeId)
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
export async function XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_GradeBaseInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_GradeBaseInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_GradeBaseInDiv_Cache");
const arrObjLst_Sel = await XzGradeBase_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN.con_GradeBaseName, "年级");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzGradeBase_CheckPropertyNew(pobjXzGradeBaseEN: clsXzGradeBaseEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseID) === true )
{
 throw new Error("(errid:Watl000058)字段[年级代号]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseName) === true )
{
 throw new Error("(errid:Watl000058)字段[年级名称]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolYear) === true 
 || pobjXzGradeBaseEN.schoolYear.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[学年]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolTerm) === true 
 || pobjXzGradeBaseEN.schoolTerm.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[学期]不能为空(In 年级)!(clsXzGradeBaseBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_GradeBase) == false && GetStrLen(pobjXzGradeBaseEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_GradeBase)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseID) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseID) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级代号(gradeBaseID)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseID)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseName) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseName) > 50)
{
 throw new Error("(errid:Watl000059)字段[年级名称(gradeBaseName)]的长度不能超过50(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseName)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseNameA) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseNameA) > 10)
{
 throw new Error("(errid:Watl000059)字段[年级名称缩写(gradeBaseNameA)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseNameA)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolYear) == false && GetStrLen(pobjXzGradeBaseEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolYear)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolTerm) == false && GetStrLen(pobjXzGradeBaseEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolTerm)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.enterSchoolDate) == false && GetStrLen(pobjXzGradeBaseEN.enterSchoolDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[进校日期(enterSchoolDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.enterSchoolDate)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.setEPTermIndexDate) == false && GetStrLen(pobjXzGradeBaseEN.setEPTermIndexDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[设定执行计划学期日期(setEPTermIndexDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.setEPTermIndexDate)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.beginYearMonth) == false && GetStrLen(pobjXzGradeBaseEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.beginYearMonth)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.endYearMonth) == false && GetStrLen(pobjXzGradeBaseEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.endYearMonth)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.prefix) == false && GetStrLen(pobjXzGradeBaseEN.prefix) > 3)
{
 throw new Error("(errid:Watl000059)字段[前缀(prefix)]的长度不能超过3(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.prefix)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.pointCalcVersionId) == false && GetStrLen(pobjXzGradeBaseEN.pointCalcVersionId) > 2)
{
 throw new Error("(errid:Watl000059)字段[绩点计算版本Id(pointCalcVersionId)]的长度不能超过2(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.pointCalcVersionId)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyUserID) == false && GetStrLen(pobjXzGradeBaseEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyUserID)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyDate) == false && GetStrLen(pobjXzGradeBaseEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyDate)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_StudyLevel) == false && GetStrLen(pobjXzGradeBaseEN.id_StudyLevel) > 4)
{
 throw new Error("(errid:Watl000059)字段[id_StudyLevel(id_StudyLevel)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_StudyLevel)(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.memo) == false && GetStrLen(pobjXzGradeBaseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.memo)(clsXzGradeBaseBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_GradeBase) == false && undefined !== pobjXzGradeBaseEN.id_GradeBase && tzDataType.isString(pobjXzGradeBaseEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzGradeBaseEN.id_GradeBase)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseID) == false && undefined !== pobjXzGradeBaseEN.gradeBaseID && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseID) === false)
{
 throw new Error("(errid:Watl000060)字段[年级代号(gradeBaseID)]的值:[$(pobjXzGradeBaseEN.gradeBaseID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseName) == false && undefined !== pobjXzGradeBaseEN.gradeBaseName && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseName) === false)
{
 throw new Error("(errid:Watl000060)字段[年级名称(gradeBaseName)]的值:[$(pobjXzGradeBaseEN.gradeBaseName)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseNameA) == false && undefined !== pobjXzGradeBaseEN.gradeBaseNameA && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseNameA) === false)
{
 throw new Error("(errid:Watl000060)字段[年级名称缩写(gradeBaseNameA)]的值:[$(pobjXzGradeBaseEN.gradeBaseNameA)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolYear) == false && undefined !== pobjXzGradeBaseEN.schoolYear && tzDataType.isString(pobjXzGradeBaseEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjXzGradeBaseEN.schoolYear)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolTerm) == false && undefined !== pobjXzGradeBaseEN.schoolTerm && tzDataType.isString(pobjXzGradeBaseEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjXzGradeBaseEN.schoolTerm)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.enterSchoolDate) == false && undefined !== pobjXzGradeBaseEN.enterSchoolDate && tzDataType.isString(pobjXzGradeBaseEN.enterSchoolDate) === false)
{
 throw new Error("(errid:Watl000060)字段[进校日期(enterSchoolDate)]的值:[$(pobjXzGradeBaseEN.enterSchoolDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.currentTermSeq && undefined !== pobjXzGradeBaseEN.currentTermSeq && tzDataType.isNumber(pobjXzGradeBaseEN.currentTermSeq) === false)
{
 throw new Error("(errid:Watl000060)字段[当前学期(currentTermSeq)]的值:[$(pobjXzGradeBaseEN.currentTermSeq)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.execPlanTermIndex && undefined !== pobjXzGradeBaseEN.execPlanTermIndex && tzDataType.isNumber(pobjXzGradeBaseEN.execPlanTermIndex) === false)
{
 throw new Error("(errid:Watl000060)字段[生成执行计划学期(execPlanTermIndex)]的值:[$(pobjXzGradeBaseEN.execPlanTermIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.setEPTermIndexDate) == false && undefined !== pobjXzGradeBaseEN.setEPTermIndexDate && tzDataType.isString(pobjXzGradeBaseEN.setEPTermIndexDate) === false)
{
 throw new Error("(errid:Watl000060)字段[设定执行计划学期日期(setEPTermIndexDate)]的值:[$(pobjXzGradeBaseEN.setEPTermIndexDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.isOffed && undefined !== pobjXzGradeBaseEN.isOffed && tzDataType.isBoolean(pobjXzGradeBaseEN.isOffed) === false)
{
 throw new Error("(errid:Watl000060)字段[是否毕业(isOffed)]的值:[$(pobjXzGradeBaseEN.isOffed)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.gradeIndex && undefined !== pobjXzGradeBaseEN.gradeIndex && tzDataType.isNumber(pobjXzGradeBaseEN.gradeIndex) === false)
{
 throw new Error("(errid:Watl000060)字段[年级序号(gradeIndex)]的值:[$(pobjXzGradeBaseEN.gradeIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.beginYearMonth) == false && undefined !== pobjXzGradeBaseEN.beginYearMonth && tzDataType.isString(pobjXzGradeBaseEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjXzGradeBaseEN.beginYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.endYearMonth) == false && undefined !== pobjXzGradeBaseEN.endYearMonth && tzDataType.isString(pobjXzGradeBaseEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjXzGradeBaseEN.endYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.allowUpBaseInfo && undefined !== pobjXzGradeBaseEN.allowUpBaseInfo && tzDataType.isBoolean(pobjXzGradeBaseEN.allowUpBaseInfo) === false)
{
 throw new Error("(errid:Watl000060)字段[允许修改基本信息(allowUpBaseInfo)]的值:[$(pobjXzGradeBaseEN.allowUpBaseInfo)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.prefix) == false && undefined !== pobjXzGradeBaseEN.prefix && tzDataType.isString(pobjXzGradeBaseEN.prefix) === false)
{
 throw new Error("(errid:Watl000060)字段[前缀(prefix)]的值:[$(pobjXzGradeBaseEN.prefix)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.pointCalcVersionId) == false && undefined !== pobjXzGradeBaseEN.pointCalcVersionId && tzDataType.isString(pobjXzGradeBaseEN.pointCalcVersionId) === false)
{
 throw new Error("(errid:Watl000060)字段[绩点计算版本Id(pointCalcVersionId)]的值:[$(pobjXzGradeBaseEN.pointCalcVersionId)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyUserID) == false && undefined !== pobjXzGradeBaseEN.modifyUserID && tzDataType.isString(pobjXzGradeBaseEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzGradeBaseEN.modifyUserID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyDate) == false && undefined !== pobjXzGradeBaseEN.modifyDate && tzDataType.isString(pobjXzGradeBaseEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzGradeBaseEN.modifyDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_StudyLevel) == false && undefined !== pobjXzGradeBaseEN.id_StudyLevel && tzDataType.isString(pobjXzGradeBaseEN.id_StudyLevel) === false)
{
 throw new Error("(errid:Watl000060)字段[id_StudyLevel(id_StudyLevel)]的值:[$(pobjXzGradeBaseEN.id_StudyLevel)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (null != pobjXzGradeBaseEN.isVisible && undefined !== pobjXzGradeBaseEN.isVisible && tzDataType.isBoolean(pobjXzGradeBaseEN.isVisible) === false)
{
 throw new Error("(errid:Watl000060)字段[是否显示(isVisible)]的值:[$(pobjXzGradeBaseEN.isVisible)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.memo) == false && undefined !== pobjXzGradeBaseEN.memo && tzDataType.isString(pobjXzGradeBaseEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzGradeBaseEN.memo)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjXzGradeBaseEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function XzGradeBase_CheckProperty4Update (pobjXzGradeBaseEN: clsXzGradeBaseEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_GradeBase) == false && GetStrLen(pobjXzGradeBaseEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_GradeBase)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseID) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseID) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级代号(gradeBaseID)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseID)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseName) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseName) > 50)
{
 throw new Error("(errid:Watl000062)字段[年级名称(gradeBaseName)]的长度不能超过50(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseName)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseNameA) == false && GetStrLen(pobjXzGradeBaseEN.gradeBaseNameA) > 10)
{
 throw new Error("(errid:Watl000062)字段[年级名称缩写(gradeBaseNameA)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.gradeBaseNameA)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolYear) == false && GetStrLen(pobjXzGradeBaseEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolYear)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolTerm) == false && GetStrLen(pobjXzGradeBaseEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.schoolTerm)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.enterSchoolDate) == false && GetStrLen(pobjXzGradeBaseEN.enterSchoolDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[进校日期(enterSchoolDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.enterSchoolDate)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.setEPTermIndexDate) == false && GetStrLen(pobjXzGradeBaseEN.setEPTermIndexDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[设定执行计划学期日期(setEPTermIndexDate)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.setEPTermIndexDate)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.beginYearMonth) == false && GetStrLen(pobjXzGradeBaseEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.beginYearMonth)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.endYearMonth) == false && GetStrLen(pobjXzGradeBaseEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.endYearMonth)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.prefix) == false && GetStrLen(pobjXzGradeBaseEN.prefix) > 3)
{
 throw new Error("(errid:Watl000062)字段[前缀(prefix)]的长度不能超过3(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.prefix)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.pointCalcVersionId) == false && GetStrLen(pobjXzGradeBaseEN.pointCalcVersionId) > 2)
{
 throw new Error("(errid:Watl000062)字段[绩点计算版本Id(pointCalcVersionId)]的长度不能超过2(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.pointCalcVersionId)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyUserID) == false && GetStrLen(pobjXzGradeBaseEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyUserID)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyDate) == false && GetStrLen(pobjXzGradeBaseEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.modifyDate)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_StudyLevel) == false && GetStrLen(pobjXzGradeBaseEN.id_StudyLevel) > 4)
{
 throw new Error("(errid:Watl000062)字段[id_StudyLevel(id_StudyLevel)]的长度不能超过4(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.id_StudyLevel)(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.memo) == false && GetStrLen(pobjXzGradeBaseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 年级(XzGradeBase))!值:$(pobjXzGradeBaseEN.memo)(clsXzGradeBaseBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_GradeBase) == false && undefined !== pobjXzGradeBaseEN.id_GradeBase && tzDataType.isString(pobjXzGradeBaseEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjXzGradeBaseEN.id_GradeBase)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseID) == false && undefined !== pobjXzGradeBaseEN.gradeBaseID && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseID) === false)
{
 throw new Error("(errid:Watl000063)字段[年级代号(gradeBaseID)]的值:[$(pobjXzGradeBaseEN.gradeBaseID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseName) == false && undefined !== pobjXzGradeBaseEN.gradeBaseName && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseName) === false)
{
 throw new Error("(errid:Watl000063)字段[年级名称(gradeBaseName)]的值:[$(pobjXzGradeBaseEN.gradeBaseName)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.gradeBaseNameA) == false && undefined !== pobjXzGradeBaseEN.gradeBaseNameA && tzDataType.isString(pobjXzGradeBaseEN.gradeBaseNameA) === false)
{
 throw new Error("(errid:Watl000063)字段[年级名称缩写(gradeBaseNameA)]的值:[$(pobjXzGradeBaseEN.gradeBaseNameA)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolYear) == false && undefined !== pobjXzGradeBaseEN.schoolYear && tzDataType.isString(pobjXzGradeBaseEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjXzGradeBaseEN.schoolYear)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.schoolTerm) == false && undefined !== pobjXzGradeBaseEN.schoolTerm && tzDataType.isString(pobjXzGradeBaseEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjXzGradeBaseEN.schoolTerm)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.enterSchoolDate) == false && undefined !== pobjXzGradeBaseEN.enterSchoolDate && tzDataType.isString(pobjXzGradeBaseEN.enterSchoolDate) === false)
{
 throw new Error("(errid:Watl000063)字段[进校日期(enterSchoolDate)]的值:[$(pobjXzGradeBaseEN.enterSchoolDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.currentTermSeq && undefined !== pobjXzGradeBaseEN.currentTermSeq && tzDataType.isNumber(pobjXzGradeBaseEN.currentTermSeq) === false)
{
 throw new Error("(errid:Watl000063)字段[当前学期(currentTermSeq)]的值:[$(pobjXzGradeBaseEN.currentTermSeq)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.execPlanTermIndex && undefined !== pobjXzGradeBaseEN.execPlanTermIndex && tzDataType.isNumber(pobjXzGradeBaseEN.execPlanTermIndex) === false)
{
 throw new Error("(errid:Watl000063)字段[生成执行计划学期(execPlanTermIndex)]的值:[$(pobjXzGradeBaseEN.execPlanTermIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.setEPTermIndexDate) == false && undefined !== pobjXzGradeBaseEN.setEPTermIndexDate && tzDataType.isString(pobjXzGradeBaseEN.setEPTermIndexDate) === false)
{
 throw new Error("(errid:Watl000063)字段[设定执行计划学期日期(setEPTermIndexDate)]的值:[$(pobjXzGradeBaseEN.setEPTermIndexDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.isOffed && undefined !== pobjXzGradeBaseEN.isOffed && tzDataType.isBoolean(pobjXzGradeBaseEN.isOffed) === false)
{
 throw new Error("(errid:Watl000063)字段[是否毕业(isOffed)]的值:[$(pobjXzGradeBaseEN.isOffed)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.gradeIndex && undefined !== pobjXzGradeBaseEN.gradeIndex && tzDataType.isNumber(pobjXzGradeBaseEN.gradeIndex) === false)
{
 throw new Error("(errid:Watl000063)字段[年级序号(gradeIndex)]的值:[$(pobjXzGradeBaseEN.gradeIndex)], 非法，应该为数值型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.beginYearMonth) == false && undefined !== pobjXzGradeBaseEN.beginYearMonth && tzDataType.isString(pobjXzGradeBaseEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjXzGradeBaseEN.beginYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.endYearMonth) == false && undefined !== pobjXzGradeBaseEN.endYearMonth && tzDataType.isString(pobjXzGradeBaseEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjXzGradeBaseEN.endYearMonth)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.allowUpBaseInfo && undefined !== pobjXzGradeBaseEN.allowUpBaseInfo && tzDataType.isBoolean(pobjXzGradeBaseEN.allowUpBaseInfo) === false)
{
 throw new Error("(errid:Watl000063)字段[允许修改基本信息(allowUpBaseInfo)]的值:[$(pobjXzGradeBaseEN.allowUpBaseInfo)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.prefix) == false && undefined !== pobjXzGradeBaseEN.prefix && tzDataType.isString(pobjXzGradeBaseEN.prefix) === false)
{
 throw new Error("(errid:Watl000063)字段[前缀(prefix)]的值:[$(pobjXzGradeBaseEN.prefix)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.pointCalcVersionId) == false && undefined !== pobjXzGradeBaseEN.pointCalcVersionId && tzDataType.isString(pobjXzGradeBaseEN.pointCalcVersionId) === false)
{
 throw new Error("(errid:Watl000063)字段[绩点计算版本Id(pointCalcVersionId)]的值:[$(pobjXzGradeBaseEN.pointCalcVersionId)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyUserID) == false && undefined !== pobjXzGradeBaseEN.modifyUserID && tzDataType.isString(pobjXzGradeBaseEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzGradeBaseEN.modifyUserID)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.modifyDate) == false && undefined !== pobjXzGradeBaseEN.modifyDate && tzDataType.isString(pobjXzGradeBaseEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzGradeBaseEN.modifyDate)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_StudyLevel) == false && undefined !== pobjXzGradeBaseEN.id_StudyLevel && tzDataType.isString(pobjXzGradeBaseEN.id_StudyLevel) === false)
{
 throw new Error("(errid:Watl000063)字段[id_StudyLevel(id_StudyLevel)]的值:[$(pobjXzGradeBaseEN.id_StudyLevel)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (null != pobjXzGradeBaseEN.isVisible && undefined !== pobjXzGradeBaseEN.isVisible && tzDataType.isBoolean(pobjXzGradeBaseEN.isVisible) === false)
{
 throw new Error("(errid:Watl000063)字段[是否显示(isVisible)]的值:[$(pobjXzGradeBaseEN.isVisible)], 非法，应该为布尔型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjXzGradeBaseEN.memo) == false && undefined !== pobjXzGradeBaseEN.memo && tzDataType.isString(pobjXzGradeBaseEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzGradeBaseEN.memo)], 非法，应该为字符型(In 年级(XzGradeBase))!(clsXzGradeBaseBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjXzGradeBaseEN.id_GradeBase) === true 
 || pobjXzGradeBaseEN.id_GradeBase.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[年级流水号]不能为空(In 年级)!(clsXzGradeBaseBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjXzGradeBaseEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzGradeBase_GetJSONStrByObj (pobjXzGradeBaseEN: clsXzGradeBaseEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjXzGradeBaseEN.sfUpdFldSetStr = pobjXzGradeBaseEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjXzGradeBaseEN);
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
export function XzGradeBase_GetObjLstByJSONStr (strJSON: string): Array<clsXzGradeBaseEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrXzGradeBaseObjLst = new Array<clsXzGradeBaseEN>();
if (strJSON === "")
{
return arrXzGradeBaseObjLst;
}
try
{
arrXzGradeBaseObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrXzGradeBaseObjLst;
}
return arrXzGradeBaseObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrXzGradeBaseObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function XzGradeBase_GetObjLstByJSONObjLst (arrXzGradeBaseObjLstS: Array<clsXzGradeBaseEN>): Array<clsXzGradeBaseEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrXzGradeBaseObjLst = new Array<clsXzGradeBaseEN>();
for (const objInFor of arrXzGradeBaseObjLstS) {
const obj1 = XzGradeBase_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrXzGradeBaseObjLst.push(obj1);
}
return arrXzGradeBaseObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function XzGradeBase_GetObjByJSONStr (strJSON: string): clsXzGradeBaseEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjXzGradeBaseEN = new clsXzGradeBaseEN();
if (strJSON === "")
{
return pobjXzGradeBaseEN;
}
try
{
pobjXzGradeBaseEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjXzGradeBaseEN;
}
return pobjXzGradeBaseEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function XzGradeBase_GetCombineCondition(objXzGradeBase_Cond: clsXzGradeBaseEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_id_GradeBase, objXzGradeBase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_GradeBaseID) == true)
{
const strComparisonOp_GradeBaseID:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_GradeBaseID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_GradeBaseID, objXzGradeBase_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_GradeBaseName, objXzGradeBase_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_GradeBaseNameA) == true)
{
const strComparisonOp_GradeBaseNameA:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_GradeBaseNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_GradeBaseNameA, objXzGradeBase_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_SchoolYear, objXzGradeBase_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_SchoolTerm, objXzGradeBase_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_EnterSchoolDate) == true)
{
const strComparisonOp_EnterSchoolDate:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_EnterSchoolDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_EnterSchoolDate, objXzGradeBase_Cond.enterSchoolDate, strComparisonOp_EnterSchoolDate);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_CurrentTermSeq) == true)
{
const strComparisonOp_CurrentTermSeq:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_CurrentTermSeq];
strWhereCond += Format(" And {0} {2} {1}", clsXzGradeBaseEN.con_CurrentTermSeq, objXzGradeBase_Cond.currentTermSeq, strComparisonOp_CurrentTermSeq);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_SetEPTermIndexDate) == true)
{
const strComparisonOp_SetEPTermIndexDate:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_SetEPTermIndexDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_SetEPTermIndexDate, objXzGradeBase_Cond.setEPTermIndexDate, strComparisonOp_SetEPTermIndexDate);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_IsOffed) == true)
{
if (objXzGradeBase_Cond.isOffed == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzGradeBaseEN.con_IsOffed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzGradeBaseEN.con_IsOffed);
}
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_GradeIndex) == true)
{
const strComparisonOp_GradeIndex:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_GradeIndex];
strWhereCond += Format(" And {0} {2} {1}", clsXzGradeBaseEN.con_GradeIndex, objXzGradeBase_Cond.gradeIndex, strComparisonOp_GradeIndex);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_BeginYearMonth) == true)
{
const strComparisonOp_BeginYearMonth:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_BeginYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_BeginYearMonth, objXzGradeBase_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_EndYearMonth) == true)
{
const strComparisonOp_EndYearMonth:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_EndYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_EndYearMonth, objXzGradeBase_Cond.endYearMonth, strComparisonOp_EndYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_AllowUpBaseInfo) == true)
{
if (objXzGradeBase_Cond.allowUpBaseInfo == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzGradeBaseEN.con_AllowUpBaseInfo);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzGradeBaseEN.con_AllowUpBaseInfo);
}
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_Prefix) == true)
{
const strComparisonOp_Prefix:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_Prefix];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_Prefix, objXzGradeBase_Cond.prefix, strComparisonOp_Prefix);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_PointCalcVersionId) == true)
{
const strComparisonOp_PointCalcVersionId:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_PointCalcVersionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_PointCalcVersionId, objXzGradeBase_Cond.pointCalcVersionId, strComparisonOp_PointCalcVersionId);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_ModifyUserID, objXzGradeBase_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_ModifyDate, objXzGradeBase_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_id_StudyLevel) == true)
{
const strComparisonOp_id_StudyLevel:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_id_StudyLevel];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_id_StudyLevel, objXzGradeBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_IsVisible) == true)
{
if (objXzGradeBase_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsXzGradeBaseEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsXzGradeBaseEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objXzGradeBase_Cond.dicFldComparisonOp, clsXzGradeBaseEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objXzGradeBase_Cond.dicFldComparisonOp[clsXzGradeBaseEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsXzGradeBaseEN.con_Memo, objXzGradeBase_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objXzGradeBaseENS:源对象
 * @param objXzGradeBaseENT:目标对象
*/
export function XzGradeBase_CopyObjTo(objXzGradeBaseENS: clsXzGradeBaseEN , objXzGradeBaseENT: clsXzGradeBaseEN ): void 
{
objXzGradeBaseENT.id_GradeBase = objXzGradeBaseENS.id_GradeBase; //年级流水号
objXzGradeBaseENT.gradeBaseID = objXzGradeBaseENS.gradeBaseID; //年级代号
objXzGradeBaseENT.gradeBaseName = objXzGradeBaseENS.gradeBaseName; //年级名称
objXzGradeBaseENT.gradeBaseNameA = objXzGradeBaseENS.gradeBaseNameA; //年级名称缩写
objXzGradeBaseENT.schoolYear = objXzGradeBaseENS.schoolYear; //学年
objXzGradeBaseENT.schoolTerm = objXzGradeBaseENS.schoolTerm; //学期
objXzGradeBaseENT.enterSchoolDate = objXzGradeBaseENS.enterSchoolDate; //进校日期
objXzGradeBaseENT.currentTermSeq = objXzGradeBaseENS.currentTermSeq; //当前学期
objXzGradeBaseENT.execPlanTermIndex = objXzGradeBaseENS.execPlanTermIndex; //生成执行计划学期
objXzGradeBaseENT.setEPTermIndexDate = objXzGradeBaseENS.setEPTermIndexDate; //设定执行计划学期日期
objXzGradeBaseENT.isOffed = objXzGradeBaseENS.isOffed; //是否毕业
objXzGradeBaseENT.gradeIndex = objXzGradeBaseENS.gradeIndex; //年级序号
objXzGradeBaseENT.beginYearMonth = objXzGradeBaseENS.beginYearMonth; //开始年月
objXzGradeBaseENT.endYearMonth = objXzGradeBaseENS.endYearMonth; //结束年月
objXzGradeBaseENT.allowUpBaseInfo = objXzGradeBaseENS.allowUpBaseInfo; //允许修改基本信息
objXzGradeBaseENT.prefix = objXzGradeBaseENS.prefix; //前缀
objXzGradeBaseENT.pointCalcVersionId = objXzGradeBaseENS.pointCalcVersionId; //绩点计算版本Id
objXzGradeBaseENT.modifyUserID = objXzGradeBaseENS.modifyUserID; //修改人
objXzGradeBaseENT.modifyDate = objXzGradeBaseENS.modifyDate; //修改日期
objXzGradeBaseENT.id_StudyLevel = objXzGradeBaseENS.id_StudyLevel; //id_StudyLevel
objXzGradeBaseENT.isVisible = objXzGradeBaseENS.isVisible; //是否显示
objXzGradeBaseENT.memo = objXzGradeBaseENS.memo; //备注
objXzGradeBaseENT.sfUpdFldSetStr = objXzGradeBaseENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objXzGradeBaseENS:源对象
 * @param objXzGradeBaseENT:目标对象
*/
export function XzGradeBase_GetObjFromJsonObj(objXzGradeBaseENS: clsXzGradeBaseEN): clsXzGradeBaseEN 
{
 const objXzGradeBaseENT: clsXzGradeBaseEN = new clsXzGradeBaseEN();
ObjectAssign(objXzGradeBaseENT, objXzGradeBaseENS);
 return objXzGradeBaseENT;
}