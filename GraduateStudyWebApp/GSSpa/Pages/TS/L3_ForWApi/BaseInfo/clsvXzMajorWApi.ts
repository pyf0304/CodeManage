
 /**
 * 类名:clsvXzMajorWApi
 * 表名:vXzMajor(01120066)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:25
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v专业(vXzMajor)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvXzMajorEN } from "../../L0_Entity/BaseInfo/clsvXzMajorEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vXzMajor_Controller = "vXzMajorApi";
 export const vXzMajor_ConstructorName = "vXzMajor";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_XzMajor:关键字
 * @returns 对象
 **/
export async function vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor: string): Promise<clsvXzMajorEN>  
{
const strThisFuncName = "GetObjByid_XzMajorAsync";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajorAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_XzMajor";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_XzMajor": strid_XzMajor,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzMajor = vXzMajor_GetObjFromJsonObj(returnObj);
return objvXzMajor;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function vXzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_XzMajor_Cache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
try
{
const arrvXzMajor_Sel: Array <clsvXzMajorEN> = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
let objvXzMajor: clsvXzMajorEN;
if (arrvXzMajor_Sel.length > 0)
{
objvXzMajor = arrvXzMajor_Sel[0];
return objvXzMajor;
}
else
{
if (bolTryAsyncOnce == true)
{
objvXzMajor = await vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
if (objvXzMajor != null)
{
vXzMajor_ReFreshThisCache();
return objvXzMajor;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function vXzMajor_GetObjByid_XzMajor_localStorage(strid_XzMajor: string) {
const strThisFuncName = "GetObjByid_XzMajor_localStorage";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetObjByid_XzMajor_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvXzMajorEN._CurrTabName, strid_XzMajor);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvXzMajor_Cache: clsvXzMajorEN = JSON.parse(strTempObj);
return objvXzMajor_Cache;
}
try
{
const objvXzMajor = await vXzMajor_GetObjByid_XzMajorAsync(strid_XzMajor);
if (objvXzMajor != null)
{
localStorage.setItem(strKey, JSON.stringify(objvXzMajor));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvXzMajor;
}
return objvXzMajor;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_XzMajor, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function vXzMajor_GetNameByid_XzMajor_Cache(strid_XzMajor: string) {
const strThisFuncName = "GetNameByid_XzMajor_Cache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In GetNameByid_XzMajor_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
if (arrvXzMajorObjLst_Cache == null) return "";
try
{
const arrvXzMajor_Sel: Array <clsvXzMajorEN> = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
let objvXzMajor: clsvXzMajorEN;
if (arrvXzMajor_Sel.length > 0)
{
objvXzMajor = arrvXzMajor_Sel[0];
return objvXzMajor.majorName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_XzMajor);
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
 * @returns 返回一个输出字段值
*/
export async function vXzMajor_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvXzMajorEN.con_id_XzMajor)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvXzMajorEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvXzMajorEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_XzMajor = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvXzMajor = await vXzMajor_GetObjByid_XzMajor_Cache(strid_XzMajor );
if (objvXzMajor == null) return "";
return objvXzMajor.GetFldValue(strOutFldName).toString();
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
export function vXzMajor_SortFun_Defa(a:clsvXzMajorEN , b:clsvXzMajorEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_XzMajor.localeCompare(b.id_XzMajor);
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
export function vXzMajor_SortFun_Defa_2Fld(a:clsvXzMajorEN , b:clsvXzMajorEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.majorID == b.majorID) return a.majorName.localeCompare(b.majorName);
else return a.majorID.localeCompare(b.majorID);
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
export function vXzMajor_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvXzMajorEN.con_id_XzMajor:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvXzMajorEN.con_MajorID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvXzMajorEN.con_MajorName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvXzMajorEN.con_MajorEnglishName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorEnglishName.localeCompare(b.majorEnglishName);
}
case clsvXzMajorEN.con_MajorExplain:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorExplain.localeCompare(b.majorExplain);
}
case clsvXzMajorEN.con_MajorNationalID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorNationalID.localeCompare(b.majorNationalID);
}
case clsvXzMajorEN.con_id_XzCollege:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvXzMajorEN.con_CollegeID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvXzMajorEN.con_CollegeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvXzMajorEN.con_CollegeNameA:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvXzMajorEN.con_id_MajorType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.id_MajorType.localeCompare(b.id_MajorType);
}
case clsvXzMajorEN.con_MajorTypeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorTypeName.localeCompare(b.majorTypeName);
}
case clsvXzMajorEN.con_id_DegreeType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.id_DegreeType.localeCompare(b.id_DegreeType);
}
case clsvXzMajorEN.con_XwTypeDesc:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.xwTypeDesc.localeCompare(b.xwTypeDesc);
}
case clsvXzMajorEN.con_IsMainMajor:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (a.isMainMajor == true) return 1;
else return -1
}
case clsvXzMajorEN.con_MajorDirection:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.majorDirection.localeCompare(b.majorDirection);
}
case clsvXzMajorEN.con_IsVisible:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsvXzMajorEN.con_IsNormal:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (a.isNormal == true) return 1;
else return -1
}
case clsvXzMajorEN.con_ModifyDate:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvXzMajorEN.con_ModifyUserID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvXzMajorEN.con_Memo:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvXzMajorEN.con_IsVisible4XzClg:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (a.isVisible4XzClg == true) return 1;
else return -1
}
case clsvXzMajorEN.con_TypeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.typeName.localeCompare(b.typeName);
}
case clsvXzMajorEN.con_id_XzMajorShoolType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return a.id_XzMajorShoolType.localeCompare(b.id_XzMajorShoolType);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${ vXzMajor_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvXzMajorEN.con_id_XzMajor:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvXzMajorEN.con_MajorID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvXzMajorEN.con_MajorName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvXzMajorEN.con_MajorEnglishName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorEnglishName.localeCompare(a.majorEnglishName);
}
case clsvXzMajorEN.con_MajorExplain:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorExplain.localeCompare(a.majorExplain);
}
case clsvXzMajorEN.con_MajorNationalID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorNationalID.localeCompare(a.majorNationalID);
}
case clsvXzMajorEN.con_id_XzCollege:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvXzMajorEN.con_CollegeID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvXzMajorEN.con_CollegeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvXzMajorEN.con_CollegeNameA:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvXzMajorEN.con_id_MajorType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.id_MajorType.localeCompare(a.id_MajorType);
}
case clsvXzMajorEN.con_MajorTypeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorTypeName.localeCompare(a.majorTypeName);
}
case clsvXzMajorEN.con_id_DegreeType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.id_DegreeType.localeCompare(a.id_DegreeType);
}
case clsvXzMajorEN.con_XwTypeDesc:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.xwTypeDesc.localeCompare(a.xwTypeDesc);
}
case clsvXzMajorEN.con_IsMainMajor:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (b.isMainMajor == true) return 1;
else return -1
}
case clsvXzMajorEN.con_MajorDirection:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.majorDirection.localeCompare(a.majorDirection);
}
case clsvXzMajorEN.con_IsVisible:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsvXzMajorEN.con_IsNormal:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (b.isNormal == true) return 1;
else return -1
}
case clsvXzMajorEN.con_ModifyDate:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvXzMajorEN.con_ModifyUserID:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvXzMajorEN.con_Memo:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvXzMajorEN.con_IsVisible4XzClg:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
if (b.isVisible4XzClg == true) return 1;
else return -1
}
case clsvXzMajorEN.con_TypeName:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.typeName.localeCompare(a.typeName);
}
case clsvXzMajorEN.con_id_XzMajorShoolType:
return (a: clsvXzMajorEN, b: clsvXzMajorEN) => {
return b.id_XzMajorShoolType.localeCompare(a.id_XzMajorShoolType);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${ vXzMajor_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzMajor_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvXzMajorEN.con_id_XzMajor:
return (obj: clsvXzMajorEN) => {
return obj.id_XzMajor === value;
}
case clsvXzMajorEN.con_MajorID:
return (obj: clsvXzMajorEN) => {
return obj.majorID === value;
}
case clsvXzMajorEN.con_MajorName:
return (obj: clsvXzMajorEN) => {
return obj.majorName === value;
}
case clsvXzMajorEN.con_MajorEnglishName:
return (obj: clsvXzMajorEN) => {
return obj.majorEnglishName === value;
}
case clsvXzMajorEN.con_MajorExplain:
return (obj: clsvXzMajorEN) => {
return obj.majorExplain === value;
}
case clsvXzMajorEN.con_MajorNationalID:
return (obj: clsvXzMajorEN) => {
return obj.majorNationalID === value;
}
case clsvXzMajorEN.con_id_XzCollege:
return (obj: clsvXzMajorEN) => {
return obj.id_XzCollege === value;
}
case clsvXzMajorEN.con_CollegeID:
return (obj: clsvXzMajorEN) => {
return obj.collegeID === value;
}
case clsvXzMajorEN.con_CollegeName:
return (obj: clsvXzMajorEN) => {
return obj.collegeName === value;
}
case clsvXzMajorEN.con_CollegeNameA:
return (obj: clsvXzMajorEN) => {
return obj.collegeNameA === value;
}
case clsvXzMajorEN.con_id_MajorType:
return (obj: clsvXzMajorEN) => {
return obj.id_MajorType === value;
}
case clsvXzMajorEN.con_MajorTypeName:
return (obj: clsvXzMajorEN) => {
return obj.majorTypeName === value;
}
case clsvXzMajorEN.con_id_DegreeType:
return (obj: clsvXzMajorEN) => {
return obj.id_DegreeType === value;
}
case clsvXzMajorEN.con_XwTypeDesc:
return (obj: clsvXzMajorEN) => {
return obj.xwTypeDesc === value;
}
case clsvXzMajorEN.con_IsMainMajor:
return (obj: clsvXzMajorEN) => {
return obj.isMainMajor === value;
}
case clsvXzMajorEN.con_MajorDirection:
return (obj: clsvXzMajorEN) => {
return obj.majorDirection === value;
}
case clsvXzMajorEN.con_IsVisible:
return (obj: clsvXzMajorEN) => {
return obj.isVisible === value;
}
case clsvXzMajorEN.con_IsNormal:
return (obj: clsvXzMajorEN) => {
return obj.isNormal === value;
}
case clsvXzMajorEN.con_ModifyDate:
return (obj: clsvXzMajorEN) => {
return obj.modifyDate === value;
}
case clsvXzMajorEN.con_ModifyUserID:
return (obj: clsvXzMajorEN) => {
return obj.modifyUserID === value;
}
case clsvXzMajorEN.con_Memo:
return (obj: clsvXzMajorEN) => {
return obj.memo === value;
}
case clsvXzMajorEN.con_IsVisible4XzClg:
return (obj: clsvXzMajorEN) => {
return obj.isVisible4XzClg === value;
}
case clsvXzMajorEN.con_TypeName:
return (obj: clsvXzMajorEN) => {
return obj.typeName === value;
}
case clsvXzMajorEN.con_id_XzMajorShoolType:
return (obj: clsvXzMajorEN) => {
return obj.id_XzMajorShoolType === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajor]中不存在！(in ${ vXzMajor_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzMajor_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetFirstObjAsync(strWhereCond: string): Promise<clsvXzMajorEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzMajor = vXzMajor_GetObjFromJsonObj(returnObj);
return objvXzMajor;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorEN._CurrTabName;
clsvXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvXzMajorExObjLst_Cache: Array<clsvXzMajorEN> = CacheHelper.Get(strKey);
const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
return arrvXzMajorObjLst_T;
}
try
{
const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvXzMajorExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
console.log(strInfo);
return arrvXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajor_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorEN._CurrTabName;
clsvXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorEN.CacheAddiCondition);
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
const arrvXzMajorExObjLst_Cache: Array<clsvXzMajorEN> = JSON.parse(strTempObjLst);
const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
return arrvXzMajorObjLst_T;
}
try
{
const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvXzMajorExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
console.log(strInfo);
return arrvXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajor_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvXzMajorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvXzMajorObjLst_Cache: Array<clsvXzMajorEN> = JSON.parse(strTempObjLst);
return arrvXzMajorObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vXzMajor_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvXzMajorEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorEN._CurrTabName;
clsvXzMajorEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorEN.CacheAddiCondition);
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
const arrvXzMajorExObjLst_Cache: Array<clsvXzMajorEN> = JSON.parse(strTempObjLst);
const arrvXzMajorObjLst_T = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorExObjLst_Cache);
return arrvXzMajorObjLst_T;
}
try
{
const arrvXzMajorExObjLst = await vXzMajor_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvXzMajorExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorExObjLst.length);
console.log(strInfo);
return arrvXzMajorExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajor_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvXzMajorEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvXzMajorObjLst_Cache: Array<clsvXzMajorEN> = JSON.parse(strTempObjLst);
return arrvXzMajorObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajor_GetObjLst_Cache(): Promise<Array<clsvXzMajorEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvXzMajorObjLst_Cache;
switch (clsvXzMajorEN.CacheModeId)
{
case "04"://sessionStorage
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_ClientCache();
break;
default:
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_ClientCache();
break;
}
const arrvXzMajorObjLst = vXzMajor_GetObjLstByJSONObjLst(arrvXzMajorObjLst_Cache);
return arrvXzMajorObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajor_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvXzMajorObjLst_Cache;
switch (clsvXzMajorEN.CacheModeId)
{
case "04"://sessionStorage
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvXzMajorObjLst_Cache = null;
break;
default:
arrvXzMajorObjLst_Cache = null;
break;
}
return arrvXzMajorObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_XzMajor_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vXzMajor_GetSubObjLst_Cache(objvXzMajor_Cond: clsvXzMajorEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
let arrvXzMajor_Sel: Array < clsvXzMajorEN > = arrvXzMajorObjLst_Cache;
if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "") return arrvXzMajor_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvXzMajor_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvXzMajor_Cond), vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_XzMajor:关键字列表
 * @returns 对象列表
 **/
export async function vXzMajor_GetObjLstByid_XzMajorLstAsync(arrid_XzMajor: Array<string>): Promise<Array<clsvXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByid_XzMajorLstAsync";
const strAction = "GetObjLstByid_XzMajorLst";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_XzMajor);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param arrstrid_XzMajorLst:关键字列表
 * @returns 对象列表
*/
export async function vXzMajor_GetObjLstByid_XzMajorLst_Cache(arrid_XzMajorLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_XzMajorLst_Cache";
try
{
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
const arrvXzMajor_Sel: Array <clsvXzMajorEN> = arrvXzMajorObjLst_Cache.filter(x => arrid_XzMajorLst.indexOf(x.id_XzMajor)>-1);
return arrvXzMajor_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_XzMajorLst.join(","), vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vXzMajor_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvXzMajorEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
if (arrvXzMajorObjLst_Cache.length == 0) return arrvXzMajorObjLst_Cache;
let arrvXzMajor_Sel = arrvXzMajorObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvXzMajor_Cond = new clsvXzMajorEN();
ObjectAssign(objvXzMajor_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvXzMajorWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvXzMajor_Sel.length == 0) return arrvXzMajor_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvXzMajor_Sel = arrvXzMajor_Sel.sort(vXzMajor_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvXzMajor_Sel = arrvXzMajor_Sel.sort(objPagerPara.sortFun);
}
arrvXzMajor_Sel = arrvXzMajor_Sel.slice(intStart, intEnd);     
return arrvXzMajor_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vXzMajor_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvXzMajorEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajor_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajor_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param objstrid_XzMajor_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vXzMajor_IsExistRecord_Cache(objvXzMajor_Cond: clsvXzMajorEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
if (arrvXzMajorObjLst_Cache == null) return false;
let arrvXzMajor_Sel: Array < clsvXzMajorEN > = arrvXzMajorObjLst_Cache;
if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "") return arrvXzMajor_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvXzMajor_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvXzMajor_Cond), vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vXzMajor_IsExist(strid_XzMajor: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_XzMajor": strid_XzMajor,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param strid_XzMajor:所给的关键字
 * @returns 对象
*/
export async function vXzMajor_IsExist_Cache(strid_XzMajor:string) {
const strThisFuncName = "IsExist_Cache";
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
if (arrvXzMajorObjLst_Cache == null) return false;
try
{
const arrvXzMajor_Sel: Array <clsvXzMajorEN> = arrvXzMajorObjLst_Cache.filter(x => x.id_XzMajor == strid_XzMajor);
if (arrvXzMajor_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_XzMajor, vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_XzMajor:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vXzMajor_IsExistAsync(strid_XzMajor: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_XzMajor": strid_XzMajor }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
export async function vXzMajor_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vXzMajor_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajor_ConstructorName, strThisFuncName);
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
 * @param objvXzMajor_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vXzMajor_GetRecCountByCond_Cache(objvXzMajor_Cond: clsvXzMajorEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvXzMajorObjLst_Cache = await vXzMajor_GetObjLst_Cache();
if (arrvXzMajorObjLst_Cache == null) return 0;
let arrvXzMajor_Sel: Array < clsvXzMajorEN > = arrvXzMajorObjLst_Cache;
if (objvXzMajor_Cond.sf_FldComparisonOp == null || objvXzMajor_Cond.sf_FldComparisonOp == "") return arrvXzMajor_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajor_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajor_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajor_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajor_Sel = arrvXzMajor_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvXzMajor_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvXzMajor_Cond), vXzMajor_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

/**
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vXzMajor_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function vXzMajor_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvXzMajorEN._CurrTabName;
switch (clsvXzMajorEN.CacheModeId)
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
export async function vXzMajor__Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "_Cache";

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
const arrObjLst_Sel = await vXzMajor_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvXzMajorEN.con_id_XzMajor, clsvXzMajorEN.con_MajorName, "v专业");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzMajor_GetJSONStrByObj (pobjvXzMajorEN: clsvXzMajorEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvXzMajorEN);
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
export function vXzMajor_GetObjLstByJSONStr (strJSON: string): Array<clsvXzMajorEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvXzMajorObjLst = new Array<clsvXzMajorEN>();
if (strJSON === "")
{
return arrvXzMajorObjLst;
}
try
{
arrvXzMajorObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvXzMajorObjLst;
}
return arrvXzMajorObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvXzMajorObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vXzMajor_GetObjLstByJSONObjLst (arrvXzMajorObjLstS: Array<clsvXzMajorEN>): Array<clsvXzMajorEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvXzMajorObjLst = new Array<clsvXzMajorEN>();
for (const objInFor of arrvXzMajorObjLstS) {
const obj1 = vXzMajor_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvXzMajorObjLst.push(obj1);
}
return arrvXzMajorObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzMajor_GetObjByJSONStr (strJSON: string): clsvXzMajorEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvXzMajorEN = new clsvXzMajorEN();
if (strJSON === "")
{
return pobjvXzMajorEN;
}
try
{
pobjvXzMajorEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvXzMajorEN;
}
return pobjvXzMajorEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vXzMajor_GetCombineCondition(objvXzMajor_Cond: clsvXzMajorEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_id_XzMajor, objvXzMajor_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorID, objvXzMajor_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorName, objvXzMajor_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorEnglishName) == true)
{
const strComparisonOp_MajorEnglishName:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorEnglishName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorEnglishName, objvXzMajor_Cond.majorEnglishName, strComparisonOp_MajorEnglishName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorExplain) == true)
{
const strComparisonOp_MajorExplain:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorExplain];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorExplain, objvXzMajor_Cond.majorExplain, strComparisonOp_MajorExplain);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorNationalID) == true)
{
const strComparisonOp_MajorNationalID:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorNationalID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorNationalID, objvXzMajor_Cond.majorNationalID, strComparisonOp_MajorNationalID);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_id_XzCollege, objvXzMajor_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_CollegeID, objvXzMajor_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_CollegeName, objvXzMajor_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_CollegeNameA, objvXzMajor_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_id_MajorType) == true)
{
const strComparisonOp_id_MajorType:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_id_MajorType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_id_MajorType, objvXzMajor_Cond.id_MajorType, strComparisonOp_id_MajorType);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorTypeName) == true)
{
const strComparisonOp_MajorTypeName:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorTypeName, objvXzMajor_Cond.majorTypeName, strComparisonOp_MajorTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_id_DegreeType) == true)
{
const strComparisonOp_id_DegreeType:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_id_DegreeType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_id_DegreeType, objvXzMajor_Cond.id_DegreeType, strComparisonOp_id_DegreeType);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_XwTypeDesc) == true)
{
const strComparisonOp_XwTypeDesc:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_XwTypeDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_XwTypeDesc, objvXzMajor_Cond.xwTypeDesc, strComparisonOp_XwTypeDesc);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_IsMainMajor) == true)
{
if (objvXzMajor_Cond.isMainMajor == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzMajorEN.con_IsMainMajor);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzMajorEN.con_IsMainMajor);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_MajorDirection) == true)
{
const strComparisonOp_MajorDirection:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_MajorDirection];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_MajorDirection, objvXzMajor_Cond.majorDirection, strComparisonOp_MajorDirection);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_IsVisible) == true)
{
if (objvXzMajor_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzMajorEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzMajorEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_IsNormal) == true)
{
if (objvXzMajor_Cond.isNormal == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzMajorEN.con_IsNormal);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzMajorEN.con_IsNormal);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_ModifyDate, objvXzMajor_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_ModifyUserID, objvXzMajor_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_Memo, objvXzMajor_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_IsVisible4XzClg) == true)
{
if (objvXzMajor_Cond.isVisible4XzClg == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzMajorEN.con_IsVisible4XzClg);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzMajorEN.con_IsVisible4XzClg);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_TypeName) == true)
{
const strComparisonOp_TypeName:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_TypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_TypeName, objvXzMajor_Cond.typeName, strComparisonOp_TypeName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajor_Cond.dicFldComparisonOp, clsvXzMajorEN.con_id_XzMajorShoolType) == true)
{
const strComparisonOp_id_XzMajorShoolType:string = objvXzMajor_Cond.dicFldComparisonOp[clsvXzMajorEN.con_id_XzMajorShoolType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorEN.con_id_XzMajorShoolType, objvXzMajor_Cond.id_XzMajorShoolType, strComparisonOp_id_XzMajorShoolType);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvXzMajorENS:源对象
 * @param objvXzMajorENT:目标对象
*/
export function vXzMajor_CopyObjTo(objvXzMajorENS: clsvXzMajorEN , objvXzMajorENT: clsvXzMajorEN ): void 
{
objvXzMajorENT.id_XzMajor = objvXzMajorENS.id_XzMajor; //专业流水号
objvXzMajorENT.majorID = objvXzMajorENS.majorID; //专业ID
objvXzMajorENT.majorName = objvXzMajorENS.majorName; //专业名称
objvXzMajorENT.majorEnglishName = objvXzMajorENS.majorEnglishName; //专业英文名称
objvXzMajorENT.majorExplain = objvXzMajorENS.majorExplain; //专业说明
objvXzMajorENT.majorNationalID = objvXzMajorENS.majorNationalID; //专业国家代码
objvXzMajorENT.id_XzCollege = objvXzMajorENS.id_XzCollege; //学院流水号
objvXzMajorENT.collegeID = objvXzMajorENS.collegeID; //学院ID
objvXzMajorENT.collegeName = objvXzMajorENS.collegeName; //学院名称
objvXzMajorENT.collegeNameA = objvXzMajorENS.collegeNameA; //学院名称简写
objvXzMajorENT.id_MajorType = objvXzMajorENS.id_MajorType; //专业类型(文理工)流水号
objvXzMajorENT.majorTypeName = objvXzMajorENS.majorTypeName; //专业类型名称
objvXzMajorENT.id_DegreeType = objvXzMajorENS.id_DegreeType; //学位类型流水号
objvXzMajorENT.xwTypeDesc = objvXzMajorENS.xwTypeDesc; //学位类型名称
objvXzMajorENT.isMainMajor = objvXzMajorENS.isMainMajor; //是否重要专业
objvXzMajorENT.majorDirection = objvXzMajorENS.majorDirection; //专业方向
objvXzMajorENT.isVisible = objvXzMajorENS.isVisible; //是否显示
objvXzMajorENT.isNormal = objvXzMajorENS.isNormal; //IsNormal
objvXzMajorENT.modifyDate = objvXzMajorENS.modifyDate; //修改日期
objvXzMajorENT.modifyUserID = objvXzMajorENS.modifyUserID; //修改人
objvXzMajorENT.memo = objvXzMajorENS.memo; //备注
objvXzMajorENT.isVisible4XzClg = objvXzMajorENS.isVisible4XzClg; //IsVisible4XzClg
objvXzMajorENT.typeName = objvXzMajorENS.typeName; //类型名称
objvXzMajorENT.id_XzMajorShoolType = objvXzMajorENS.id_XzMajorShoolType; //专业学校类型流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvXzMajorENS:源对象
 * @param objvXzMajorENT:目标对象
*/
export function vXzMajor_GetObjFromJsonObj(objvXzMajorENS: clsvXzMajorEN): clsvXzMajorEN 
{
 const objvXzMajorENT: clsvXzMajorEN = new clsvXzMajorEN();
ObjectAssign(objvXzMajorENT, objvXzMajorENS);
 return objvXzMajorENT;
}