
 /**
 * 类名:clsvSysScoreSummaryWApi
 * 表名:vSysScoreSummary(01120627)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:59
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
 * v分数汇总视图(vSysScoreSummary)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvSysScoreSummaryEN } from "../../L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysScoreSummary_Controller = "vSysScoreSummaryApi";
 export const vSysScoreSummary_ConstructorName = "vSysScoreSummary";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vSysScoreSummary_GetObjBymIdAsync(lngmId: number): Promise<clsvSysScoreSummaryEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysScoreSummary = vSysScoreSummary_GetObjFromJsonObj(returnObj);
return objvSysScoreSummary;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreSummary_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvSysScoreSummary_Sel: Array <clsvSysScoreSummaryEN> = arrvSysScoreSummaryObjLst_Cache.filter(x => x.mId == lngmId);
let objvSysScoreSummary: clsvSysScoreSummaryEN;
if (arrvSysScoreSummary_Sel.length > 0)
{
objvSysScoreSummary = arrvSysScoreSummary_Sel[0];
return objvSysScoreSummary;
}
else
{
if (bolTryAsyncOnce == true)
{
objvSysScoreSummary = await vSysScoreSummary_GetObjBymIdAsync(lngmId);
if (objvSysScoreSummary != null)
{
vSysScoreSummary_ReFreshThisCache(strid_CurrEduCls);
return objvSysScoreSummary;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreSummary_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvSysScoreSummary_Cache: clsvSysScoreSummaryEN = JSON.parse(strTempObj);
return objvSysScoreSummary_Cache;
}
try
{
const objvSysScoreSummary = await vSysScoreSummary_GetObjBymIdAsync(lngmId);
if (objvSysScoreSummary != null)
{
localStorage.setItem(strKey, JSON.stringify(objvSysScoreSummary));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvSysScoreSummary;
}
return objvSysScoreSummary;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vSysScoreSummary_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvSysScoreSummaryEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvSysScoreSummaryEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvSysScoreSummaryEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvSysScoreSummary = await vSysScoreSummary_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objvSysScoreSummary == null) return "";
return objvSysScoreSummary.GetFldValue(strOutFldName).toString();
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
export function vSysScoreSummary_SortFun_Defa(a:clsvSysScoreSummaryEN , b:clsvSysScoreSummaryEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vSysScoreSummary_SortFun_Defa_2Fld(a:clsvSysScoreSummaryEN , b:clsvSysScoreSummaryEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userId == b.userId) return a.schoolYear.localeCompare(b.schoolYear);
else return a.userId.localeCompare(b.userId);
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
export function vSysScoreSummary_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysScoreSummaryEN.con_mId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.mId-b.mId;
}
case clsvSysScoreSummaryEN.con_UserId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvSysScoreSummaryEN.con_SchoolYear:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsvSysScoreSummaryEN.con_UpdDate:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvSysScoreSummaryEN.con_Memo:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvSysScoreSummaryEN.con_UserName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvSysScoreSummaryEN.con_id_XzCollege:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvSysScoreSummaryEN.con_CollegeName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvSysScoreSummaryEN.con_id_XzMajor:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvSysScoreSummaryEN.con_MajorName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvSysScoreSummaryEN.con_id_GradeBase:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsvSysScoreSummaryEN.con_GradeBaseName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsvSysScoreSummaryEN.con_OnlyId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.onlyId.localeCompare(b.onlyId);
}
case clsvSysScoreSummaryEN.con_ScoreTypeId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.scoreTypeId.localeCompare(b.scoreTypeId);
}
case clsvSysScoreSummaryEN.con_ScoreTypeName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.scoreTypeName.localeCompare(b.scoreTypeName);
}
case clsvSysScoreSummaryEN.con_UpdUser:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvSysScoreSummaryEN.con_score:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.score-b.score;
}
case clsvSysScoreSummaryEN.con_id_CurrEduCls:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvSysScoreSummaryEN.con_EduClsName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return a.eduClsName.localeCompare(b.eduClsName);
}
case clsvSysScoreSummaryEN.con_IsSubmit:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${ vSysScoreSummary_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysScoreSummaryEN.con_mId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.mId-a.mId;
}
case clsvSysScoreSummaryEN.con_UserId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvSysScoreSummaryEN.con_SchoolYear:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsvSysScoreSummaryEN.con_UpdDate:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvSysScoreSummaryEN.con_Memo:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvSysScoreSummaryEN.con_UserName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvSysScoreSummaryEN.con_id_XzCollege:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvSysScoreSummaryEN.con_CollegeName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvSysScoreSummaryEN.con_id_XzMajor:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvSysScoreSummaryEN.con_MajorName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvSysScoreSummaryEN.con_id_GradeBase:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsvSysScoreSummaryEN.con_GradeBaseName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsvSysScoreSummaryEN.con_OnlyId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.onlyId.localeCompare(a.onlyId);
}
case clsvSysScoreSummaryEN.con_ScoreTypeId:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.scoreTypeId.localeCompare(a.scoreTypeId);
}
case clsvSysScoreSummaryEN.con_ScoreTypeName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.scoreTypeName.localeCompare(a.scoreTypeName);
}
case clsvSysScoreSummaryEN.con_UpdUser:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvSysScoreSummaryEN.con_score:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.score-a.score;
}
case clsvSysScoreSummaryEN.con_id_CurrEduCls:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvSysScoreSummaryEN.con_EduClsName:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
return b.eduClsName.localeCompare(a.eduClsName);
}
case clsvSysScoreSummaryEN.con_IsSubmit:
return (a: clsvSysScoreSummaryEN, b: clsvSysScoreSummaryEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${ vSysScoreSummary_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysScoreSummary_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysScoreSummaryEN.con_mId:
return (obj: clsvSysScoreSummaryEN) => {
return obj.mId === value;
}
case clsvSysScoreSummaryEN.con_UserId:
return (obj: clsvSysScoreSummaryEN) => {
return obj.userId === value;
}
case clsvSysScoreSummaryEN.con_SchoolYear:
return (obj: clsvSysScoreSummaryEN) => {
return obj.schoolYear === value;
}
case clsvSysScoreSummaryEN.con_UpdDate:
return (obj: clsvSysScoreSummaryEN) => {
return obj.updDate === value;
}
case clsvSysScoreSummaryEN.con_Memo:
return (obj: clsvSysScoreSummaryEN) => {
return obj.memo === value;
}
case clsvSysScoreSummaryEN.con_UserName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.userName === value;
}
case clsvSysScoreSummaryEN.con_id_XzCollege:
return (obj: clsvSysScoreSummaryEN) => {
return obj.id_XzCollege === value;
}
case clsvSysScoreSummaryEN.con_CollegeName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.collegeName === value;
}
case clsvSysScoreSummaryEN.con_id_XzMajor:
return (obj: clsvSysScoreSummaryEN) => {
return obj.id_XzMajor === value;
}
case clsvSysScoreSummaryEN.con_MajorName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.majorName === value;
}
case clsvSysScoreSummaryEN.con_id_GradeBase:
return (obj: clsvSysScoreSummaryEN) => {
return obj.id_GradeBase === value;
}
case clsvSysScoreSummaryEN.con_GradeBaseName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.gradeBaseName === value;
}
case clsvSysScoreSummaryEN.con_OnlyId:
return (obj: clsvSysScoreSummaryEN) => {
return obj.onlyId === value;
}
case clsvSysScoreSummaryEN.con_ScoreTypeId:
return (obj: clsvSysScoreSummaryEN) => {
return obj.scoreTypeId === value;
}
case clsvSysScoreSummaryEN.con_ScoreTypeName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.scoreTypeName === value;
}
case clsvSysScoreSummaryEN.con_UpdUser:
return (obj: clsvSysScoreSummaryEN) => {
return obj.updUser === value;
}
case clsvSysScoreSummaryEN.con_score:
return (obj: clsvSysScoreSummaryEN) => {
return obj.score === value;
}
case clsvSysScoreSummaryEN.con_id_CurrEduCls:
return (obj: clsvSysScoreSummaryEN) => {
return obj.id_CurrEduCls === value;
}
case clsvSysScoreSummaryEN.con_EduClsName:
return (obj: clsvSysScoreSummaryEN) => {
return obj.eduClsName === value;
}
case clsvSysScoreSummaryEN.con_IsSubmit:
return (obj: clsvSysScoreSummaryEN) => {
return obj.isSubmit === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${ vSysScoreSummary_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysScoreSummary_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysScoreSummaryEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysScoreSummary = vSysScoreSummary_GetObjFromJsonObj(returnObj);
return objvSysScoreSummary;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
clsvSysScoreSummaryEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreSummaryEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreSummaryEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvSysScoreSummaryExObjLst_Cache: Array<clsvSysScoreSummaryEN> = CacheHelper.Get(strKey);
const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
return arrvSysScoreSummaryObjLst_T;
}
try
{
const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvSysScoreSummaryExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrvSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
clsvSysScoreSummaryEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreSummaryEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreSummaryEN.CacheAddiCondition);
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
const arrvSysScoreSummaryExObjLst_Cache: Array<clsvSysScoreSummaryEN> = JSON.parse(strTempObjLst);
const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
return arrvSysScoreSummaryObjLst_T;
}
try
{
const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvSysScoreSummaryExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrvSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvSysScoreSummaryObjLst_Cache: Array<clsvSysScoreSummaryEN> = JSON.parse(strTempObjLst);
return arrvSysScoreSummaryObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vSysScoreSummary_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
clsvSysScoreSummaryEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreSummaryEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreSummaryEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreSummaryEN.CacheAddiCondition);
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
const arrvSysScoreSummaryExObjLst_Cache: Array<clsvSysScoreSummaryEN> = JSON.parse(strTempObjLst);
const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
return arrvSysScoreSummaryObjLst_T;
}
try
{
const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvSysScoreSummaryExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
console.log(strInfo);
return arrvSysScoreSummaryExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvSysScoreSummaryObjLst_Cache: Array<clsvSysScoreSummaryEN> = JSON.parse(strTempObjLst);
return arrvSysScoreSummaryObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvSysScoreSummaryEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvSysScoreSummaryObjLst_Cache;
switch (clsvSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvSysScoreSummaryObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryObjLst_Cache);
return arrvSysScoreSummaryObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreSummary_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvSysScoreSummaryObjLst_Cache;
switch (clsvSysScoreSummaryEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvSysScoreSummaryObjLst_Cache = null;
break;
default:
arrvSysScoreSummaryObjLst_Cache = null;
break;
}
return arrvSysScoreSummaryObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysScoreSummary_GetSubObjLst_Cache(objvSysScoreSummary_Cond: clsvSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
let arrvSysScoreSummary_Sel: Array < clsvSysScoreSummaryEN > = arrvSysScoreSummaryObjLst_Cache;
if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrvSysScoreSummary_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysScoreSummary_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvSysScoreSummary_Cond), vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreSummaryEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vSysScoreSummary_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function vSysScoreSummary_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
const arrvSysScoreSummary_Sel: Array <clsvSysScoreSummaryEN> = arrvSysScoreSummaryObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvSysScoreSummary_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreSummaryEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vSysScoreSummary_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysScoreSummaryEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysScoreSummaryObjLst_Cache.length == 0) return arrvSysScoreSummaryObjLst_Cache;
let arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvSysScoreSummary_Cond = new clsvSysScoreSummaryEN();
ObjectAssign(objvSysScoreSummary_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvSysScoreSummaryWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysScoreSummary_Sel.length == 0) return arrvSysScoreSummary_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.sort(vSysScoreSummary_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.sort(objPagerPara.sortFun);
}
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.slice(intStart, intEnd);     
return arrvSysScoreSummary_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreSummaryEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vSysScoreSummary_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysScoreSummaryEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysScoreSummary_IsExistRecord_Cache(objvSysScoreSummary_Cond: clsvSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysScoreSummaryObjLst_Cache == null) return false;
let arrvSysScoreSummary_Sel: Array < clsvSysScoreSummaryEN > = arrvSysScoreSummaryObjLst_Cache;
if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrvSysScoreSummary_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysScoreSummary_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvSysScoreSummary_Cond), vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vSysScoreSummary_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreSummary_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysScoreSummaryObjLst_Cache == null) return false;
try
{
const arrvSysScoreSummary_Sel: Array <clsvSysScoreSummaryEN> = arrvSysScoreSummaryObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvSysScoreSummary_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vSysScoreSummary_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
export async function vSysScoreSummary_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysScoreSummary_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreSummary_ConstructorName, strThisFuncName);
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
 * @param objvSysScoreSummary_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vSysScoreSummary_GetRecCountByCond_Cache(objvSysScoreSummary_Cond: clsvSysScoreSummaryEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
if (arrvSysScoreSummaryObjLst_Cache == null) return 0;
let arrvSysScoreSummary_Sel: Array < clsvSysScoreSummaryEN > = arrvSysScoreSummaryObjLst_Cache;
if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "") return arrvSysScoreSummary_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreSummary_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysScoreSummary_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvSysScoreSummary_Cond), vSysScoreSummary_ConstructorName, strThisFuncName);
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
export function vSysScoreSummary_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSysScoreSummary_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
switch (clsvSysScoreSummaryEN.CacheModeId)
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
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysScoreSummary_GetJSONStrByObj (pobjvSysScoreSummaryEN: clsvSysScoreSummaryEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysScoreSummaryEN);
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
export function vSysScoreSummary_GetObjLstByJSONStr (strJSON: string): Array<clsvSysScoreSummaryEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysScoreSummaryObjLst = new Array<clsvSysScoreSummaryEN>();
if (strJSON === "")
{
return arrvSysScoreSummaryObjLst;
}
try
{
arrvSysScoreSummaryObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysScoreSummaryObjLst;
}
return arrvSysScoreSummaryObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysScoreSummaryObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysScoreSummary_GetObjLstByJSONObjLst (arrvSysScoreSummaryObjLstS: Array<clsvSysScoreSummaryEN>): Array<clsvSysScoreSummaryEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysScoreSummaryObjLst = new Array<clsvSysScoreSummaryEN>();
for (const objInFor of arrvSysScoreSummaryObjLstS) {
const obj1 = vSysScoreSummary_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysScoreSummaryObjLst.push(obj1);
}
return arrvSysScoreSummaryObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysScoreSummary_GetObjByJSONStr (strJSON: string): clsvSysScoreSummaryEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
if (strJSON === "")
{
return pobjvSysScoreSummaryEN;
}
try
{
pobjvSysScoreSummaryEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysScoreSummaryEN;
}
return pobjvSysScoreSummaryEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysScoreSummary_GetCombineCondition(objvSysScoreSummary_Cond: clsvSysScoreSummaryEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvSysScoreSummaryEN.con_mId, objvSysScoreSummary_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_UserId, objvSysScoreSummary_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_SchoolYear, objvSysScoreSummary_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_UpdDate, objvSysScoreSummary_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_Memo, objvSysScoreSummary_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_UserName, objvSysScoreSummary_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_id_XzCollege, objvSysScoreSummary_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_CollegeName, objvSysScoreSummary_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_id_XzMajor, objvSysScoreSummary_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_MajorName, objvSysScoreSummary_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_id_GradeBase, objvSysScoreSummary_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_GradeBaseName, objvSysScoreSummary_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_OnlyId) == true)
{
const strComparisonOp_OnlyId:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_OnlyId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_OnlyId, objvSysScoreSummary_Cond.onlyId, strComparisonOp_OnlyId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_ScoreTypeId) == true)
{
const strComparisonOp_ScoreTypeId:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_ScoreTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_ScoreTypeId, objvSysScoreSummary_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_ScoreTypeName) == true)
{
const strComparisonOp_ScoreTypeName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_ScoreTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_ScoreTypeName, objvSysScoreSummary_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_UpdUser, objvSysScoreSummary_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_score) == true)
{
const strComparisonOp_score:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvSysScoreSummaryEN.con_score, objvSysScoreSummary_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_id_CurrEduCls, objvSysScoreSummary_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_EduClsName) == true)
{
const strComparisonOp_EduClsName:string = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN.con_EduClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreSummaryEN.con_EduClsName, objvSysScoreSummary_Cond.eduClsName, strComparisonOp_EduClsName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN.con_IsSubmit) == true)
{
if (objvSysScoreSummary_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvSysScoreSummaryEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvSysScoreSummaryEN.con_IsSubmit);
}
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysScoreSummaryENS:源对象
 * @param objvSysScoreSummaryENT:目标对象
*/
export function vSysScoreSummary_CopyObjTo(objvSysScoreSummaryENS: clsvSysScoreSummaryEN , objvSysScoreSummaryENT: clsvSysScoreSummaryEN ): void 
{
objvSysScoreSummaryENT.mId = objvSysScoreSummaryENS.mId; //mId
objvSysScoreSummaryENT.userId = objvSysScoreSummaryENS.userId; //用户ID
objvSysScoreSummaryENT.schoolYear = objvSysScoreSummaryENS.schoolYear; //学年
objvSysScoreSummaryENT.updDate = objvSysScoreSummaryENS.updDate; //修改日期
objvSysScoreSummaryENT.memo = objvSysScoreSummaryENS.memo; //备注
objvSysScoreSummaryENT.userName = objvSysScoreSummaryENS.userName; //用户名
objvSysScoreSummaryENT.id_XzCollege = objvSysScoreSummaryENS.id_XzCollege; //学院流水号
objvSysScoreSummaryENT.collegeName = objvSysScoreSummaryENS.collegeName; //学院名称
objvSysScoreSummaryENT.id_XzMajor = objvSysScoreSummaryENS.id_XzMajor; //专业流水号
objvSysScoreSummaryENT.majorName = objvSysScoreSummaryENS.majorName; //专业名称
objvSysScoreSummaryENT.id_GradeBase = objvSysScoreSummaryENS.id_GradeBase; //年级流水号
objvSysScoreSummaryENT.gradeBaseName = objvSysScoreSummaryENS.gradeBaseName; //年级名称
objvSysScoreSummaryENT.onlyId = objvSysScoreSummaryENS.onlyId; //OnlyId
objvSysScoreSummaryENT.scoreTypeId = objvSysScoreSummaryENS.scoreTypeId; //分数类型Id
objvSysScoreSummaryENT.scoreTypeName = objvSysScoreSummaryENS.scoreTypeName; //分数类型名称
objvSysScoreSummaryENT.updUser = objvSysScoreSummaryENS.updUser; //修改人
objvSysScoreSummaryENT.score = objvSysScoreSummaryENS.score; //评分
objvSysScoreSummaryENT.id_CurrEduCls = objvSysScoreSummaryENS.id_CurrEduCls; //教学班流水号
objvSysScoreSummaryENT.eduClsName = objvSysScoreSummaryENS.eduClsName; //教学班名
objvSysScoreSummaryENT.isSubmit = objvSysScoreSummaryENS.isSubmit; //是否提交
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysScoreSummaryENS:源对象
 * @param objvSysScoreSummaryENT:目标对象
*/
export function vSysScoreSummary_GetObjFromJsonObj(objvSysScoreSummaryENS: clsvSysScoreSummaryEN): clsvSysScoreSummaryEN 
{
 const objvSysScoreSummaryENT: clsvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
ObjectAssign(objvSysScoreSummaryENT, objvSysScoreSummaryENS);
 return objvSysScoreSummaryENT;
}