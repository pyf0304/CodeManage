
 /**
 * 类名:clsCurrEduClsStuWApi
 * 表名:CurrEduClsStu(01120125)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:09
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
 * 教学班与学生关系(CurrEduClsStu)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsCurrEduClsStuEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsStuEN.js";
import { vCurrEduClsStu_ReFreshThisCache } from "../../L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const currEduClsStu_Controller = "CurrEduClsStuApi";
 export const currEduClsStu_ConstructorName = "currEduClsStu";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngid_EduClsStu:关键字
 * @returns 对象
 **/
export async function CurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu: number): Promise<clsCurrEduClsStuEN>  
{
const strThisFuncName = "GetObjByid_EduClsStuAsync";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStuAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByid_EduClsStu";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngid_EduClsStu": lngid_EduClsStu,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduClsStu = CurrEduClsStu_GetObjFromJsonObj(returnObj);
return objCurrEduClsStu;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_EduClsStu_Cache";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrCurrEduClsStu_Sel: Array <clsCurrEduClsStuEN> = arrCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
let objCurrEduClsStu: clsCurrEduClsStuEN;
if (arrCurrEduClsStu_Sel.length > 0)
{
objCurrEduClsStu = arrCurrEduClsStu_Sel[0];
return objCurrEduClsStu;
}
else
{
if (bolTryAsyncOnce == true)
{
objCurrEduClsStu = await CurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
if (objCurrEduClsStu != null)
{
CurrEduClsStu_ReFreshThisCache(strid_CurrEduCls);
return objCurrEduClsStu;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsStu_GetObjByid_EduClsStu_localStorage(lngid_EduClsStu: number) {
const strThisFuncName = "GetObjByid_EduClsStu_localStorage";

if (lngid_EduClsStu == 0)
{
  const strMsg = Format("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, lngid_EduClsStu);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objCurrEduClsStu_Cache: clsCurrEduClsStuEN = JSON.parse(strTempObj);
return objCurrEduClsStu_Cache;
}
try
{
const objCurrEduClsStu = await CurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
if (objCurrEduClsStu != null)
{
localStorage.setItem(strKey, JSON.stringify(objCurrEduClsStu));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objCurrEduClsStu;
}
return objCurrEduClsStu;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objCurrEduClsStu:所给的对象
 * @returns 对象
*/
export async function CurrEduClsStu_UpdateObjInLst_Cache(objCurrEduClsStu: clsCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrCurrEduClsStuObjLst_Cache.find(x => x.id_CurrEduCls == objCurrEduClsStu.id_CurrEduCls && x.id_Stu == objCurrEduClsStu.id_Stu);
if (obj != null)
{
objCurrEduClsStu.id_EduClsStu = obj.id_EduClsStu;
ObjectAssign( obj, objCurrEduClsStu);
}
else
{
arrCurrEduClsStuObjLst_Cache.push(objCurrEduClsStu);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
export async function CurrEduClsStu_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsCurrEduClsStuEN.con_id_EduClsStu)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsCurrEduClsStuEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsCurrEduClsStuEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngid_EduClsStu = Number(strInValue);
if (lngid_EduClsStu == 0)
{
return "";
}
const objCurrEduClsStu = await CurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu , strid_CurrEduCls_C);
if (objCurrEduClsStu == null) return "";
return objCurrEduClsStu.GetFldValue(strOutFldName).toString();
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
export function CurrEduClsStu_SortFun_Defa(a:clsCurrEduClsStuEN , b:clsCurrEduClsStuEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_EduClsStu-b.id_EduClsStu;
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
export function CurrEduClsStu_SortFun_Defa_2Fld(a:clsCurrEduClsStuEN , b:clsCurrEduClsStuEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.id_Stu.localeCompare(b.id_Stu);
else return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
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
export function CurrEduClsStu_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsCurrEduClsStuEN.con_id_EduClsStu:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.id_EduClsStu-b.id_EduClsStu;
}
case clsCurrEduClsStuEN.con_id_CurrEduCls:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsCurrEduClsStuEN.con_id_Stu:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.id_Stu.localeCompare(b.id_Stu);
}
case clsCurrEduClsStuEN.con_EduClsStuStateID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.eduClsStuStateID.localeCompare(b.eduClsStuStateID);
}
case clsCurrEduClsStuEN.con_GetScoreTimes:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.getScoreTimes-b.getScoreTimes;
}
case clsCurrEduClsStuEN.con_Score:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.score-b.score;
}
case clsCurrEduClsStuEN.con_TotalScores:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.totalScores-b.totalScores;
}
case clsCurrEduClsStuEN.con_Ranking:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.ranking-b.ranking;
}
case clsCurrEduClsStuEN.con_Percentile:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.percentile-b.percentile;
}
case clsCurrEduClsStuEN.con_Ranking2:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.ranking2-b.ranking2;
}
case clsCurrEduClsStuEN.con_Percentile2:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.percentile2-b.percentile2;
}
case clsCurrEduClsStuEN.con_Ranking3:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.ranking3-b.ranking3;
}
case clsCurrEduClsStuEN.con_Percentile3:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.percentile3-b.percentile3;
}
case clsCurrEduClsStuEN.con_Confirmed:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (a.confirmed == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_SchoolTerm:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsCurrEduClsStuEN.con_SchoolYear:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsCurrEduClsStuEN.con_ExportDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.exportDate.localeCompare(b.exportDate);
}
case clsCurrEduClsStuEN.con_SignInDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.signInDate.localeCompare(b.signInDate);
}
case clsCurrEduClsStuEN.con_SignInStateID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.signInStateID.localeCompare(b.signInStateID);
}
case clsCurrEduClsStuEN.con_SignInUser:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.signInUser.localeCompare(b.signInUser);
}
case clsCurrEduClsStuEN.con_IsOpByTeacher:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (a.isOpByTeacher == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_IsSynScore:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (a.isSynScore == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_ModifyDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsCurrEduClsStuEN.con_ModifyUserID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsCurrEduClsStuEN.con_Memo:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsStu]中不存在！(in ${ currEduClsStu_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsCurrEduClsStuEN.con_id_EduClsStu:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.id_EduClsStu-a.id_EduClsStu;
}
case clsCurrEduClsStuEN.con_id_CurrEduCls:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsCurrEduClsStuEN.con_id_Stu:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.id_Stu.localeCompare(a.id_Stu);
}
case clsCurrEduClsStuEN.con_EduClsStuStateID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.eduClsStuStateID.localeCompare(a.eduClsStuStateID);
}
case clsCurrEduClsStuEN.con_GetScoreTimes:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.getScoreTimes-a.getScoreTimes;
}
case clsCurrEduClsStuEN.con_Score:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.score-a.score;
}
case clsCurrEduClsStuEN.con_TotalScores:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.totalScores-a.totalScores;
}
case clsCurrEduClsStuEN.con_Ranking:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.ranking-a.ranking;
}
case clsCurrEduClsStuEN.con_Percentile:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.percentile-a.percentile;
}
case clsCurrEduClsStuEN.con_Ranking2:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.ranking2-a.ranking2;
}
case clsCurrEduClsStuEN.con_Percentile2:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.percentile2-a.percentile2;
}
case clsCurrEduClsStuEN.con_Ranking3:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.ranking3-a.ranking3;
}
case clsCurrEduClsStuEN.con_Percentile3:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.percentile3-a.percentile3;
}
case clsCurrEduClsStuEN.con_Confirmed:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (b.confirmed == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_SchoolTerm:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsCurrEduClsStuEN.con_SchoolYear:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsCurrEduClsStuEN.con_ExportDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.exportDate.localeCompare(a.exportDate);
}
case clsCurrEduClsStuEN.con_SignInDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.signInDate.localeCompare(a.signInDate);
}
case clsCurrEduClsStuEN.con_SignInStateID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.signInStateID.localeCompare(a.signInStateID);
}
case clsCurrEduClsStuEN.con_SignInUser:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.signInUser.localeCompare(a.signInUser);
}
case clsCurrEduClsStuEN.con_IsOpByTeacher:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (b.isOpByTeacher == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_IsSynScore:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
if (b.isSynScore == true) return 1;
else return -1
}
case clsCurrEduClsStuEN.con_ModifyDate:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsCurrEduClsStuEN.con_ModifyUserID:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsCurrEduClsStuEN.con_Memo:
return (a: clsCurrEduClsStuEN, b: clsCurrEduClsStuEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsStu]中不存在！(in ${ currEduClsStu_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduClsStu_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsCurrEduClsStuEN.con_id_EduClsStu:
return (obj: clsCurrEduClsStuEN) => {
return obj.id_EduClsStu === value;
}
case clsCurrEduClsStuEN.con_id_CurrEduCls:
return (obj: clsCurrEduClsStuEN) => {
return obj.id_CurrEduCls === value;
}
case clsCurrEduClsStuEN.con_id_Stu:
return (obj: clsCurrEduClsStuEN) => {
return obj.id_Stu === value;
}
case clsCurrEduClsStuEN.con_EduClsStuStateID:
return (obj: clsCurrEduClsStuEN) => {
return obj.eduClsStuStateID === value;
}
case clsCurrEduClsStuEN.con_GetScoreTimes:
return (obj: clsCurrEduClsStuEN) => {
return obj.getScoreTimes === value;
}
case clsCurrEduClsStuEN.con_Score:
return (obj: clsCurrEduClsStuEN) => {
return obj.score === value;
}
case clsCurrEduClsStuEN.con_TotalScores:
return (obj: clsCurrEduClsStuEN) => {
return obj.totalScores === value;
}
case clsCurrEduClsStuEN.con_Ranking:
return (obj: clsCurrEduClsStuEN) => {
return obj.ranking === value;
}
case clsCurrEduClsStuEN.con_Percentile:
return (obj: clsCurrEduClsStuEN) => {
return obj.percentile === value;
}
case clsCurrEduClsStuEN.con_Ranking2:
return (obj: clsCurrEduClsStuEN) => {
return obj.ranking2 === value;
}
case clsCurrEduClsStuEN.con_Percentile2:
return (obj: clsCurrEduClsStuEN) => {
return obj.percentile2 === value;
}
case clsCurrEduClsStuEN.con_Ranking3:
return (obj: clsCurrEduClsStuEN) => {
return obj.ranking3 === value;
}
case clsCurrEduClsStuEN.con_Percentile3:
return (obj: clsCurrEduClsStuEN) => {
return obj.percentile3 === value;
}
case clsCurrEduClsStuEN.con_Confirmed:
return (obj: clsCurrEduClsStuEN) => {
return obj.confirmed === value;
}
case clsCurrEduClsStuEN.con_SchoolTerm:
return (obj: clsCurrEduClsStuEN) => {
return obj.schoolTerm === value;
}
case clsCurrEduClsStuEN.con_SchoolYear:
return (obj: clsCurrEduClsStuEN) => {
return obj.schoolYear === value;
}
case clsCurrEduClsStuEN.con_ExportDate:
return (obj: clsCurrEduClsStuEN) => {
return obj.exportDate === value;
}
case clsCurrEduClsStuEN.con_SignInDate:
return (obj: clsCurrEduClsStuEN) => {
return obj.signInDate === value;
}
case clsCurrEduClsStuEN.con_SignInStateID:
return (obj: clsCurrEduClsStuEN) => {
return obj.signInStateID === value;
}
case clsCurrEduClsStuEN.con_SignInUser:
return (obj: clsCurrEduClsStuEN) => {
return obj.signInUser === value;
}
case clsCurrEduClsStuEN.con_IsOpByTeacher:
return (obj: clsCurrEduClsStuEN) => {
return obj.isOpByTeacher === value;
}
case clsCurrEduClsStuEN.con_IsSynScore:
return (obj: clsCurrEduClsStuEN) => {
return obj.isSynScore === value;
}
case clsCurrEduClsStuEN.con_ModifyDate:
return (obj: clsCurrEduClsStuEN) => {
return obj.modifyDate === value;
}
case clsCurrEduClsStuEN.con_ModifyUserID:
return (obj: clsCurrEduClsStuEN) => {
return obj.modifyUserID === value;
}
case clsCurrEduClsStuEN.con_Memo:
return (obj: clsCurrEduClsStuEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsStu]中不存在！(in ${ currEduClsStu_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduClsStu_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetFirstObjAsync(strWhereCond: string): Promise<clsCurrEduClsStuEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduClsStu = CurrEduClsStu_GetObjFromJsonObj(returnObj);
return objCurrEduClsStu;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsStuEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrCurrEduClsStuExObjLst_Cache: Array<clsCurrEduClsStuEN> = CacheHelper.Get(strKey);
const arrCurrEduClsStuObjLst_T = CurrEduClsStu_GetObjLstByJSONObjLst(arrCurrEduClsStuExObjLst_Cache);
return arrCurrEduClsStuObjLst_T;
}
try
{
const arrCurrEduClsStuExObjLst = await CurrEduClsStu_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrCurrEduClsStuExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsStuEN.CacheAddiCondition);
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
const arrCurrEduClsStuExObjLst_Cache: Array<clsCurrEduClsStuEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsStuObjLst_T = CurrEduClsStu_GetObjLstByJSONObjLst(arrCurrEduClsStuExObjLst_Cache);
return arrCurrEduClsStuObjLst_T;
}
try
{
const arrCurrEduClsStuExObjLst = await CurrEduClsStu_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsStuExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrCurrEduClsStuObjLst_Cache: Array<clsCurrEduClsStuEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsStuObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function CurrEduClsStu_GetObjLstAsync(strWhereCond: string): Promise<Array<clsCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsStuEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsStuEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsStuEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsStuEN.CacheAddiCondition);
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
const arrCurrEduClsStuExObjLst_Cache: Array<clsCurrEduClsStuEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsStuObjLst_T = CurrEduClsStu_GetObjLstByJSONObjLst(arrCurrEduClsStuExObjLst_Cache);
return arrCurrEduClsStuObjLst_T;
}
try
{
const arrCurrEduClsStuExObjLst = await CurrEduClsStu_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrCurrEduClsStuExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsStuExObjLst.length);
console.log(strInfo);
return arrCurrEduClsStuExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrCurrEduClsStuObjLst_Cache: Array<clsCurrEduClsStuEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsStuObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsCurrEduClsStuEN>>
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
let arrCurrEduClsStuObjLst_Cache;
switch (clsCurrEduClsStuEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrCurrEduClsStuObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(arrCurrEduClsStuObjLst_Cache);
return arrCurrEduClsStuObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsStu_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrCurrEduClsStuObjLst_Cache;
switch (clsCurrEduClsStuEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrCurrEduClsStuObjLst_Cache = null;
break;
default:
arrCurrEduClsStuObjLst_Cache = null;
break;
}
return arrCurrEduClsStuObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngid_EduClsStu_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CurrEduClsStu_GetSubObjLst_Cache(objCurrEduClsStu_Cond: clsCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
let arrCurrEduClsStu_Sel: Array < clsCurrEduClsStuEN > = arrCurrEduClsStuObjLst_Cache;
if (objCurrEduClsStu_Cond.sf_FldComparisonOp == null || objCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrCurrEduClsStu_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduClsStu_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduClsStu_Cond), currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsStuEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_EduClsStu:关键字列表
 * @returns 对象列表
 **/
export async function CurrEduClsStu_GetObjLstByid_EduClsStuLstAsync(arrid_EduClsStu: Array<string>): Promise<Array<clsCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByid_EduClsStuLstAsync";
const strAction = "GetObjLstByid_EduClsStuLst";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_EduClsStu);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param arrlngid_EduClsStuLst:关键字列表
 * @returns 对象列表
*/
export async function CurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache(arrid_EduClsStuLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByid_EduClsStuLst_Cache";
try
{
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
const arrCurrEduClsStu_Sel: Array <clsCurrEduClsStuEN> = arrCurrEduClsStuObjLst_Cache.filter(x => arrid_EduClsStuLst.indexOf(x.id_EduClsStu)>-1);
return arrCurrEduClsStu_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsStuLst.join(","), currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsStuEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function CurrEduClsStu_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsCurrEduClsStuEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsStuObjLst_Cache.length == 0) return arrCurrEduClsStuObjLst_Cache;
let arrCurrEduClsStu_Sel = arrCurrEduClsStuObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objCurrEduClsStu_Cond = new clsCurrEduClsStuEN();
ObjectAssign(objCurrEduClsStu_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsCurrEduClsStuWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduClsStu_Sel.length == 0) return arrCurrEduClsStu_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(CurrEduClsStu_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
}
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.slice(intStart, intEnd);     
return arrCurrEduClsStu_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsStuEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function CurrEduClsStu_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsStuEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsStu_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:关键字
 * @returns 获取删除的结果
 **/
export async function CurrEduClsStu_DelRecordAsync(lngid_EduClsStu: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngid_EduClsStu);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngid_EduClsStu, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param arrid_EduClsStu:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function CurrEduClsStu_DelCurrEduClsStusAsync(arrid_EduClsStu: Array<string>): Promise<number> 
{
const strThisFuncName = "DelCurrEduClsStusAsync";
const strAction = "DelCurrEduClsStus";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_EduClsStu);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_DelCurrEduClsStusByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelCurrEduClsStusByCondAsync";
const strAction = "DelCurrEduClsStusByCond";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsStuEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsStu_AddNewRecordAsync(objCurrEduClsStuEN: clsCurrEduClsStuEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objCurrEduClsStuEN);
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsStuEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objCurrEduClsStuEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function CurrEduClsStu_AddNewRecordWithReturnKeyAsync(objCurrEduClsStuEN: clsCurrEduClsStuEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsStuEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsStuEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function CurrEduClsStu_AddNewRecordWithReturnKey(objCurrEduClsStuEN: clsCurrEduClsStuEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objCurrEduClsStuEN.id_EduClsStu === null || objCurrEduClsStuEN.id_EduClsStu === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsStuEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsStuEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function CurrEduClsStu_UpdateRecordAsync(objCurrEduClsStuEN: clsCurrEduClsStuEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objCurrEduClsStuEN.sf_UpdFldSetStr === undefined || objCurrEduClsStuEN.sf_UpdFldSetStr === null || objCurrEduClsStuEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsStuEN.id_EduClsStu);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsStuEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsStuEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function CurrEduClsStu_UpdateWithConditionAsync(objCurrEduClsStuEN: clsCurrEduClsStuEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objCurrEduClsStuEN.sf_UpdFldSetStr === undefined || objCurrEduClsStuEN.sf_UpdFldSetStr === null || objCurrEduClsStuEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsStuEN.id_EduClsStu);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
objCurrEduClsStuEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objCurrEduClsStuEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objlngid_EduClsStu_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CurrEduClsStu_IsExistRecord_Cache(objCurrEduClsStu_Cond: clsCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsStuObjLst_Cache == null) return false;
let arrCurrEduClsStu_Sel: Array < clsCurrEduClsStuEN > = arrCurrEduClsStuObjLst_Cache;
if (objCurrEduClsStu_Cond.sf_FldComparisonOp == null || objCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrCurrEduClsStu_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduClsStu_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objCurrEduClsStu_Cond), currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function CurrEduClsStu_IsExist(lngid_EduClsStu: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_EduClsStu": lngid_EduClsStu,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsStu:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsStu_IsExist_Cache(lngid_EduClsStu:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsStuObjLst_Cache == null) return false;
try
{
const arrCurrEduClsStu_Sel: Array <clsCurrEduClsStuEN> = arrCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
if (arrCurrEduClsStu_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsStu, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngid_EduClsStu:关键字
 * @returns 是否存在?存在返回True
 **/
export async function CurrEduClsStu_IsExistAsync(lngid_EduClsStu: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngid_EduClsStu": lngid_EduClsStu }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsStu_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function CurrEduClsStu_GetRecCountByCond_Cache(objCurrEduClsStu_Cond: clsCurrEduClsStuEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrCurrEduClsStuObjLst_Cache = await CurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsStuObjLst_Cache == null) return 0;
let arrCurrEduClsStu_Sel: Array < clsCurrEduClsStuEN > = arrCurrEduClsStuObjLst_Cache;
if (objCurrEduClsStu_Cond.sf_FldComparisonOp == null || objCurrEduClsStu_Cond.sf_FldComparisonOp == "") return arrCurrEduClsStu_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsStu_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsStu_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsStu_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsStu_Sel = arrCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduClsStu_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduClsStu_Cond), currEduClsStu_ConstructorName, strThisFuncName);
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
export async function CurrEduClsStu_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(currEduClsStu_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsStu_ConstructorName, strThisFuncName);
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
export function CurrEduClsStu_GetWebApiUrl(strController: string, strAction: string): string {
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
export function CurrEduClsStu_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsStuWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
switch (clsCurrEduClsStuEN.CacheModeId)
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
vCurrEduClsStu_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function CurrEduClsStu_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
switch (clsCurrEduClsStuEN.CacheModeId)
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
export function CurrEduClsStu_CheckPropertyNew(pobjCurrEduClsStuEN: clsCurrEduClsStuEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsStuEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.id_CurrEduCls)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && GetStrLen(pobjCurrEduClsStuEN.id_Stu) > 8)
{
 throw new Error("(errid:Watl000059)字段[学生流水号(id_Stu)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.id_Stu)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.eduClsStuStateID) == false && GetStrLen(pobjCurrEduClsStuEN.eduClsStuStateID) > 2)
{
 throw new Error("(errid:Watl000059)字段[教学班学生状态编号(eduClsStuStateID)]的长度不能超过2(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.eduClsStuStateID)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsStuEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.schoolTerm)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolYear) == false && GetStrLen(pobjCurrEduClsStuEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.schoolYear)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.exportDate) == false && GetStrLen(pobjCurrEduClsStuEN.exportDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[导出日期(exportDate)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.exportDate)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInDate) == false && GetStrLen(pobjCurrEduClsStuEN.signInDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[签入时间(signInDate)]的长度不能超过20(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInDate)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInStateID) == false && GetStrLen(pobjCurrEduClsStuEN.signInStateID) > 2)
{
 throw new Error("(errid:Watl000059)字段[签入状态表流水号(signInStateID)]的长度不能超过2(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInStateID)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInUser) == false && GetStrLen(pobjCurrEduClsStuEN.signInUser) > 18)
{
 throw new Error("(errid:Watl000059)字段[签入人(signInUser)]的长度不能超过18(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInUser)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyDate) == false && GetStrLen(pobjCurrEduClsStuEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.modifyDate)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyUserID) == false && GetStrLen(pobjCurrEduClsStuEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.modifyUserID)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.memo) == false && GetStrLen(pobjCurrEduClsStuEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.memo)(clsCurrEduClsStuBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjCurrEduClsStuEN.id_EduClsStu && undefined !== pobjCurrEduClsStuEN.id_EduClsStu && tzDataType.isNumber(pobjCurrEduClsStuEN.id_EduClsStu) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班学生流水号(id_EduClsStu)]的值:[$(pobjCurrEduClsStuEN.id_EduClsStu)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsStuEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsStuEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsStuEN.id_CurrEduCls)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && undefined !== pobjCurrEduClsStuEN.id_Stu && tzDataType.isString(pobjCurrEduClsStuEN.id_Stu) === false)
{
 throw new Error("(errid:Watl000060)字段[学生流水号(id_Stu)]的值:[$(pobjCurrEduClsStuEN.id_Stu)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.eduClsStuStateID) == false && undefined !== pobjCurrEduClsStuEN.eduClsStuStateID && tzDataType.isString(pobjCurrEduClsStuEN.eduClsStuStateID) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班学生状态编号(eduClsStuStateID)]的值:[$(pobjCurrEduClsStuEN.eduClsStuStateID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.getScoreTimes && undefined !== pobjCurrEduClsStuEN.getScoreTimes && tzDataType.isNumber(pobjCurrEduClsStuEN.getScoreTimes) === false)
{
 throw new Error("(errid:Watl000060)字段[获得成绩次数(getScoreTimes)]的值:[$(pobjCurrEduClsStuEN.getScoreTimes)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.score && undefined !== pobjCurrEduClsStuEN.score && tzDataType.isNumber(pobjCurrEduClsStuEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[得分(score)]的值:[$(pobjCurrEduClsStuEN.score)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.totalScores && undefined !== pobjCurrEduClsStuEN.totalScores && tzDataType.isNumber(pobjCurrEduClsStuEN.totalScores) === false)
{
 throw new Error("(errid:Watl000060)字段[总分值(totalScores)]的值:[$(pobjCurrEduClsStuEN.totalScores)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.ranking && undefined !== pobjCurrEduClsStuEN.ranking && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking) === false)
{
 throw new Error("(errid:Watl000060)字段[名次(ranking)]的值:[$(pobjCurrEduClsStuEN.ranking)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.percentile && undefined !== pobjCurrEduClsStuEN.percentile && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile) === false)
{
 throw new Error("(errid:Watl000060)字段[百分位(percentile)]的值:[$(pobjCurrEduClsStuEN.percentile)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.ranking2 && undefined !== pobjCurrEduClsStuEN.ranking2 && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking2) === false)
{
 throw new Error("(errid:Watl000060)字段[Ranking2(ranking2)]的值:[$(pobjCurrEduClsStuEN.ranking2)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.percentile2 && undefined !== pobjCurrEduClsStuEN.percentile2 && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile2) === false)
{
 throw new Error("(errid:Watl000060)字段[Percentile2(percentile2)]的值:[$(pobjCurrEduClsStuEN.percentile2)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.ranking3 && undefined !== pobjCurrEduClsStuEN.ranking3 && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking3) === false)
{
 throw new Error("(errid:Watl000060)字段[Ranking3(ranking3)]的值:[$(pobjCurrEduClsStuEN.ranking3)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.percentile3 && undefined !== pobjCurrEduClsStuEN.percentile3 && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile3) === false)
{
 throw new Error("(errid:Watl000060)字段[Percentile3(percentile3)]的值:[$(pobjCurrEduClsStuEN.percentile3)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.confirmed && undefined !== pobjCurrEduClsStuEN.confirmed && tzDataType.isBoolean(pobjCurrEduClsStuEN.confirmed) === false)
{
 throw new Error("(errid:Watl000060)字段[是否确认(confirmed)]的值:[$(pobjCurrEduClsStuEN.confirmed)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolTerm) == false && undefined !== pobjCurrEduClsStuEN.schoolTerm && tzDataType.isString(pobjCurrEduClsStuEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsStuEN.schoolTerm)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolYear) == false && undefined !== pobjCurrEduClsStuEN.schoolYear && tzDataType.isString(pobjCurrEduClsStuEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsStuEN.schoolYear)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.exportDate) == false && undefined !== pobjCurrEduClsStuEN.exportDate && tzDataType.isString(pobjCurrEduClsStuEN.exportDate) === false)
{
 throw new Error("(errid:Watl000060)字段[导出日期(exportDate)]的值:[$(pobjCurrEduClsStuEN.exportDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInDate) == false && undefined !== pobjCurrEduClsStuEN.signInDate && tzDataType.isString(pobjCurrEduClsStuEN.signInDate) === false)
{
 throw new Error("(errid:Watl000060)字段[签入时间(signInDate)]的值:[$(pobjCurrEduClsStuEN.signInDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInStateID) == false && undefined !== pobjCurrEduClsStuEN.signInStateID && tzDataType.isString(pobjCurrEduClsStuEN.signInStateID) === false)
{
 throw new Error("(errid:Watl000060)字段[签入状态表流水号(signInStateID)]的值:[$(pobjCurrEduClsStuEN.signInStateID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInUser) == false && undefined !== pobjCurrEduClsStuEN.signInUser && tzDataType.isString(pobjCurrEduClsStuEN.signInUser) === false)
{
 throw new Error("(errid:Watl000060)字段[签入人(signInUser)]的值:[$(pobjCurrEduClsStuEN.signInUser)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.isOpByTeacher && undefined !== pobjCurrEduClsStuEN.isOpByTeacher && tzDataType.isBoolean(pobjCurrEduClsStuEN.isOpByTeacher) === false)
{
 throw new Error("(errid:Watl000060)字段[是否教师操作(isOpByTeacher)]的值:[$(pobjCurrEduClsStuEN.isOpByTeacher)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsStuEN.isSynScore && undefined !== pobjCurrEduClsStuEN.isSynScore && tzDataType.isBoolean(pobjCurrEduClsStuEN.isSynScore) === false)
{
 throw new Error("(errid:Watl000060)字段[是否同步成绩(isSynScore)]的值:[$(pobjCurrEduClsStuEN.isSynScore)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyDate) == false && undefined !== pobjCurrEduClsStuEN.modifyDate && tzDataType.isString(pobjCurrEduClsStuEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsStuEN.modifyDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyUserID) == false && undefined !== pobjCurrEduClsStuEN.modifyUserID && tzDataType.isString(pobjCurrEduClsStuEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsStuEN.modifyUserID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.memo) == false && undefined !== pobjCurrEduClsStuEN.memo && tzDataType.isString(pobjCurrEduClsStuEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCurrEduClsStuEN.memo)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsStuEN.id_CurrEduCls) !=  8)
{
 throw ("(errid:Watl000061)字段[教学班流水号]作为外键字段,长度应该为8(In 教学班与学生关系)!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && GetStrLen(pobjCurrEduClsStuEN.id_Stu) !=  8)
{
 throw ("(errid:Watl000061)字段[学生流水号]作为外键字段,长度应该为8(In 教学班与学生关系)!(clsCurrEduClsStuBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCurrEduClsStuEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CurrEduClsStu_CheckProperty4Update (pobjCurrEduClsStuEN: clsCurrEduClsStuEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsStuEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.id_CurrEduCls)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && GetStrLen(pobjCurrEduClsStuEN.id_Stu) > 8)
{
 throw new Error("(errid:Watl000062)字段[学生流水号(id_Stu)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.id_Stu)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.eduClsStuStateID) == false && GetStrLen(pobjCurrEduClsStuEN.eduClsStuStateID) > 2)
{
 throw new Error("(errid:Watl000062)字段[教学班学生状态编号(eduClsStuStateID)]的长度不能超过2(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.eduClsStuStateID)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsStuEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.schoolTerm)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolYear) == false && GetStrLen(pobjCurrEduClsStuEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.schoolYear)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.exportDate) == false && GetStrLen(pobjCurrEduClsStuEN.exportDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[导出日期(exportDate)]的长度不能超过8(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.exportDate)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInDate) == false && GetStrLen(pobjCurrEduClsStuEN.signInDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[签入时间(signInDate)]的长度不能超过20(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInDate)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInStateID) == false && GetStrLen(pobjCurrEduClsStuEN.signInStateID) > 2)
{
 throw new Error("(errid:Watl000062)字段[签入状态表流水号(signInStateID)]的长度不能超过2(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInStateID)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInUser) == false && GetStrLen(pobjCurrEduClsStuEN.signInUser) > 18)
{
 throw new Error("(errid:Watl000062)字段[签入人(signInUser)]的长度不能超过18(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.signInUser)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyDate) == false && GetStrLen(pobjCurrEduClsStuEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.modifyDate)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyUserID) == false && GetStrLen(pobjCurrEduClsStuEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.modifyUserID)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.memo) == false && GetStrLen(pobjCurrEduClsStuEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教学班与学生关系(CurrEduClsStu))!值:$(pobjCurrEduClsStuEN.memo)(clsCurrEduClsStuBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjCurrEduClsStuEN.id_EduClsStu && undefined !== pobjCurrEduClsStuEN.id_EduClsStu && tzDataType.isNumber(pobjCurrEduClsStuEN.id_EduClsStu) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班学生流水号(id_EduClsStu)]的值:[$(pobjCurrEduClsStuEN.id_EduClsStu)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsStuEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsStuEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsStuEN.id_CurrEduCls)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && undefined !== pobjCurrEduClsStuEN.id_Stu && tzDataType.isString(pobjCurrEduClsStuEN.id_Stu) === false)
{
 throw new Error("(errid:Watl000063)字段[学生流水号(id_Stu)]的值:[$(pobjCurrEduClsStuEN.id_Stu)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.eduClsStuStateID) == false && undefined !== pobjCurrEduClsStuEN.eduClsStuStateID && tzDataType.isString(pobjCurrEduClsStuEN.eduClsStuStateID) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班学生状态编号(eduClsStuStateID)]的值:[$(pobjCurrEduClsStuEN.eduClsStuStateID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.getScoreTimes && undefined !== pobjCurrEduClsStuEN.getScoreTimes && tzDataType.isNumber(pobjCurrEduClsStuEN.getScoreTimes) === false)
{
 throw new Error("(errid:Watl000063)字段[获得成绩次数(getScoreTimes)]的值:[$(pobjCurrEduClsStuEN.getScoreTimes)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.score && undefined !== pobjCurrEduClsStuEN.score && tzDataType.isNumber(pobjCurrEduClsStuEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[得分(score)]的值:[$(pobjCurrEduClsStuEN.score)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.totalScores && undefined !== pobjCurrEduClsStuEN.totalScores && tzDataType.isNumber(pobjCurrEduClsStuEN.totalScores) === false)
{
 throw new Error("(errid:Watl000063)字段[总分值(totalScores)]的值:[$(pobjCurrEduClsStuEN.totalScores)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.ranking && undefined !== pobjCurrEduClsStuEN.ranking && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking) === false)
{
 throw new Error("(errid:Watl000063)字段[名次(ranking)]的值:[$(pobjCurrEduClsStuEN.ranking)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.percentile && undefined !== pobjCurrEduClsStuEN.percentile && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile) === false)
{
 throw new Error("(errid:Watl000063)字段[百分位(percentile)]的值:[$(pobjCurrEduClsStuEN.percentile)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.ranking2 && undefined !== pobjCurrEduClsStuEN.ranking2 && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking2) === false)
{
 throw new Error("(errid:Watl000063)字段[Ranking2(ranking2)]的值:[$(pobjCurrEduClsStuEN.ranking2)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.percentile2 && undefined !== pobjCurrEduClsStuEN.percentile2 && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile2) === false)
{
 throw new Error("(errid:Watl000063)字段[Percentile2(percentile2)]的值:[$(pobjCurrEduClsStuEN.percentile2)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.ranking3 && undefined !== pobjCurrEduClsStuEN.ranking3 && tzDataType.isNumber(pobjCurrEduClsStuEN.ranking3) === false)
{
 throw new Error("(errid:Watl000063)字段[Ranking3(ranking3)]的值:[$(pobjCurrEduClsStuEN.ranking3)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.percentile3 && undefined !== pobjCurrEduClsStuEN.percentile3 && tzDataType.isNumber(pobjCurrEduClsStuEN.percentile3) === false)
{
 throw new Error("(errid:Watl000063)字段[Percentile3(percentile3)]的值:[$(pobjCurrEduClsStuEN.percentile3)], 非法，应该为数值型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.confirmed && undefined !== pobjCurrEduClsStuEN.confirmed && tzDataType.isBoolean(pobjCurrEduClsStuEN.confirmed) === false)
{
 throw new Error("(errid:Watl000063)字段[是否确认(confirmed)]的值:[$(pobjCurrEduClsStuEN.confirmed)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolTerm) == false && undefined !== pobjCurrEduClsStuEN.schoolTerm && tzDataType.isString(pobjCurrEduClsStuEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsStuEN.schoolTerm)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.schoolYear) == false && undefined !== pobjCurrEduClsStuEN.schoolYear && tzDataType.isString(pobjCurrEduClsStuEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsStuEN.schoolYear)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.exportDate) == false && undefined !== pobjCurrEduClsStuEN.exportDate && tzDataType.isString(pobjCurrEduClsStuEN.exportDate) === false)
{
 throw new Error("(errid:Watl000063)字段[导出日期(exportDate)]的值:[$(pobjCurrEduClsStuEN.exportDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInDate) == false && undefined !== pobjCurrEduClsStuEN.signInDate && tzDataType.isString(pobjCurrEduClsStuEN.signInDate) === false)
{
 throw new Error("(errid:Watl000063)字段[签入时间(signInDate)]的值:[$(pobjCurrEduClsStuEN.signInDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInStateID) == false && undefined !== pobjCurrEduClsStuEN.signInStateID && tzDataType.isString(pobjCurrEduClsStuEN.signInStateID) === false)
{
 throw new Error("(errid:Watl000063)字段[签入状态表流水号(signInStateID)]的值:[$(pobjCurrEduClsStuEN.signInStateID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.signInUser) == false && undefined !== pobjCurrEduClsStuEN.signInUser && tzDataType.isString(pobjCurrEduClsStuEN.signInUser) === false)
{
 throw new Error("(errid:Watl000063)字段[签入人(signInUser)]的值:[$(pobjCurrEduClsStuEN.signInUser)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.isOpByTeacher && undefined !== pobjCurrEduClsStuEN.isOpByTeacher && tzDataType.isBoolean(pobjCurrEduClsStuEN.isOpByTeacher) === false)
{
 throw new Error("(errid:Watl000063)字段[是否教师操作(isOpByTeacher)]的值:[$(pobjCurrEduClsStuEN.isOpByTeacher)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsStuEN.isSynScore && undefined !== pobjCurrEduClsStuEN.isSynScore && tzDataType.isBoolean(pobjCurrEduClsStuEN.isSynScore) === false)
{
 throw new Error("(errid:Watl000063)字段[是否同步成绩(isSynScore)]的值:[$(pobjCurrEduClsStuEN.isSynScore)], 非法，应该为布尔型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyDate) == false && undefined !== pobjCurrEduClsStuEN.modifyDate && tzDataType.isString(pobjCurrEduClsStuEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjCurrEduClsStuEN.modifyDate)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.modifyUserID) == false && undefined !== pobjCurrEduClsStuEN.modifyUserID && tzDataType.isString(pobjCurrEduClsStuEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjCurrEduClsStuEN.modifyUserID)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.memo) == false && undefined !== pobjCurrEduClsStuEN.memo && tzDataType.isString(pobjCurrEduClsStuEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCurrEduClsStuEN.memo)], 非法，应该为字符型(In 教学班与学生关系(CurrEduClsStu))!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCurrEduClsStuEN.id_EduClsStu 
 || pobjCurrEduClsStuEN.id_EduClsStu != null && pobjCurrEduClsStuEN.id_EduClsStu.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[教学班学生流水号]不能为空(In 教学班与学生关系)!(clsCurrEduClsStuBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsStuEN.id_CurrEduCls) !=  8)
{
 throw ("(errid:Watl000065)字段[教学班流水号]作为外键字段,长度应该为8(In 教学班与学生关系)!(clsCurrEduClsStuBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsStuEN.id_Stu) == false && GetStrLen(pobjCurrEduClsStuEN.id_Stu) !=  8)
{
 throw ("(errid:Watl000065)字段[学生流水号]作为外键字段,长度应该为8(In 教学班与学生关系)!(clsCurrEduClsStuBL:CheckPropertyNew)");
}

 pobjCurrEduClsStuEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduClsStu_GetJSONStrByObj (pobjCurrEduClsStuEN: clsCurrEduClsStuEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjCurrEduClsStuEN.sf_UpdFldSetStr = pobjCurrEduClsStuEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjCurrEduClsStuEN);
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
export function CurrEduClsStu_GetObjLstByJSONStr (strJSON: string): Array<clsCurrEduClsStuEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrCurrEduClsStuObjLst = new Array<clsCurrEduClsStuEN>();
if (strJSON === "")
{
return arrCurrEduClsStuObjLst;
}
try
{
arrCurrEduClsStuObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCurrEduClsStuObjLst;
}
return arrCurrEduClsStuObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrCurrEduClsStuObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function CurrEduClsStu_GetObjLstByJSONObjLst (arrCurrEduClsStuObjLstS: Array<clsCurrEduClsStuEN>): Array<clsCurrEduClsStuEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrCurrEduClsStuObjLst = new Array<clsCurrEduClsStuEN>();
for (const objInFor of arrCurrEduClsStuObjLstS) {
const obj1 = CurrEduClsStu_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrCurrEduClsStuObjLst.push(obj1);
}
return arrCurrEduClsStuObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduClsStu_GetObjByJSONStr (strJSON: string): clsCurrEduClsStuEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjCurrEduClsStuEN = new clsCurrEduClsStuEN();
if (strJSON === "")
{
return pobjCurrEduClsStuEN;
}
try
{
pobjCurrEduClsStuEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCurrEduClsStuEN;
}
return pobjCurrEduClsStuEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function CurrEduClsStu_GetCombineCondition(objCurrEduClsStu_Cond: clsCurrEduClsStuEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_id_EduClsStu) == true)
{
const strComparisonOp_id_EduClsStu:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_id_EduClsStu];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_id_EduClsStu, objCurrEduClsStu_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_id_CurrEduCls, objCurrEduClsStu_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_id_Stu) == true)
{
const strComparisonOp_id_Stu:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_id_Stu];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_id_Stu, objCurrEduClsStu_Cond.id_Stu, strComparisonOp_id_Stu);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_EduClsStuStateID) == true)
{
const strComparisonOp_EduClsStuStateID:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_EduClsStuStateID];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_EduClsStuStateID, objCurrEduClsStu_Cond.eduClsStuStateID, strComparisonOp_EduClsStuStateID);
}
//数据类型number(tinyint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Score) == true)
{
const strComparisonOp_Score:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Score, objCurrEduClsStu_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_TotalScores) == true)
{
const strComparisonOp_TotalScores:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_TotalScores];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_TotalScores, objCurrEduClsStu_Cond.totalScores, strComparisonOp_TotalScores);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Ranking) == true)
{
const strComparisonOp_Ranking:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Ranking];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Ranking, objCurrEduClsStu_Cond.ranking, strComparisonOp_Ranking);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Percentile) == true)
{
const strComparisonOp_Percentile:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Percentile];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Percentile, objCurrEduClsStu_Cond.percentile, strComparisonOp_Percentile);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Ranking2) == true)
{
const strComparisonOp_Ranking2:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Ranking2];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Ranking2, objCurrEduClsStu_Cond.ranking2, strComparisonOp_Ranking2);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Percentile2) == true)
{
const strComparisonOp_Percentile2:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Percentile2];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Percentile2, objCurrEduClsStu_Cond.percentile2, strComparisonOp_Percentile2);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Ranking3) == true)
{
const strComparisonOp_Ranking3:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Ranking3];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Ranking3, objCurrEduClsStu_Cond.ranking3, strComparisonOp_Ranking3);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Percentile3) == true)
{
const strComparisonOp_Percentile3:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Percentile3];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsStuEN.con_Percentile3, objCurrEduClsStu_Cond.percentile3, strComparisonOp_Percentile3);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Confirmed) == true)
{
if (objCurrEduClsStu_Cond.confirmed == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsStuEN.con_Confirmed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsStuEN.con_Confirmed);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_SchoolTerm, objCurrEduClsStu_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_SchoolYear, objCurrEduClsStu_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_ExportDate) == true)
{
const strComparisonOp_ExportDate:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_ExportDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_ExportDate, objCurrEduClsStu_Cond.exportDate, strComparisonOp_ExportDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_SignInDate) == true)
{
const strComparisonOp_SignInDate:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_SignInDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_SignInDate, objCurrEduClsStu_Cond.signInDate, strComparisonOp_SignInDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_SignInStateID) == true)
{
const strComparisonOp_SignInStateID:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_SignInStateID];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_SignInStateID, objCurrEduClsStu_Cond.signInStateID, strComparisonOp_SignInStateID);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_SignInUser) == true)
{
const strComparisonOp_SignInUser:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_SignInUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_SignInUser, objCurrEduClsStu_Cond.signInUser, strComparisonOp_SignInUser);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_IsOpByTeacher) == true)
{
if (objCurrEduClsStu_Cond.isOpByTeacher == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsStuEN.con_IsOpByTeacher);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsStuEN.con_IsOpByTeacher);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_IsSynScore) == true)
{
if (objCurrEduClsStu_Cond.isSynScore == true)
{
strWhereCond += Format(" And {0} = '1'", clsCurrEduClsStuEN.con_IsSynScore);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsCurrEduClsStuEN.con_IsSynScore);
}
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_ModifyDate, objCurrEduClsStu_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_ModifyUserID, objCurrEduClsStu_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsStu_Cond.dicFldComparisonOp, clsCurrEduClsStuEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objCurrEduClsStu_Cond.dicFldComparisonOp[clsCurrEduClsStuEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsStuEN.con_Memo, objCurrEduClsStu_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduClsStu(教学班与学生关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @param strid_Stu: 学生流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduClsStu_GetUniCondStr_id_CurrEduCls_id_Stu(objCurrEduClsStuEN: clsCurrEduClsStuEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objCurrEduClsStuEN.id_CurrEduCls);
 strWhereCond +=  Format(" and id_Stu = '{0}'", objCurrEduClsStuEN.id_Stu);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduClsStu(教学班与学生关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @param strid_Stu: 学生流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduClsStu_GetUniCondStr4Update_id_CurrEduCls_id_Stu(objCurrEduClsStuEN: clsCurrEduClsStuEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_EduClsStu <> '{0}'", objCurrEduClsStuEN.id_EduClsStu);
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objCurrEduClsStuEN.id_CurrEduCls);
 strWhereCond +=  Format(" and id_Stu = '{0}'", objCurrEduClsStuEN.id_Stu);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objCurrEduClsStuENS:源对象
 * @param objCurrEduClsStuENT:目标对象
*/
export function CurrEduClsStu_CopyObjTo(objCurrEduClsStuENS: clsCurrEduClsStuEN , objCurrEduClsStuENT: clsCurrEduClsStuEN ): void 
{
objCurrEduClsStuENT.id_EduClsStu = objCurrEduClsStuENS.id_EduClsStu; //教学班学生流水号
objCurrEduClsStuENT.id_CurrEduCls = objCurrEduClsStuENS.id_CurrEduCls; //教学班流水号
objCurrEduClsStuENT.id_Stu = objCurrEduClsStuENS.id_Stu; //学生流水号
objCurrEduClsStuENT.eduClsStuStateID = objCurrEduClsStuENS.eduClsStuStateID; //教学班学生状态编号
objCurrEduClsStuENT.getScoreTimes = objCurrEduClsStuENS.getScoreTimes; //获得成绩次数
objCurrEduClsStuENT.score = objCurrEduClsStuENS.score; //得分
objCurrEduClsStuENT.totalScores = objCurrEduClsStuENS.totalScores; //总分值
objCurrEduClsStuENT.ranking = objCurrEduClsStuENS.ranking; //名次
objCurrEduClsStuENT.percentile = objCurrEduClsStuENS.percentile; //百分位
objCurrEduClsStuENT.ranking2 = objCurrEduClsStuENS.ranking2; //Ranking2
objCurrEduClsStuENT.percentile2 = objCurrEduClsStuENS.percentile2; //Percentile2
objCurrEduClsStuENT.ranking3 = objCurrEduClsStuENS.ranking3; //Ranking3
objCurrEduClsStuENT.percentile3 = objCurrEduClsStuENS.percentile3; //Percentile3
objCurrEduClsStuENT.confirmed = objCurrEduClsStuENS.confirmed; //是否确认
objCurrEduClsStuENT.schoolTerm = objCurrEduClsStuENS.schoolTerm; //学期
objCurrEduClsStuENT.schoolYear = objCurrEduClsStuENS.schoolYear; //学年
objCurrEduClsStuENT.exportDate = objCurrEduClsStuENS.exportDate; //导出日期
objCurrEduClsStuENT.signInDate = objCurrEduClsStuENS.signInDate; //签入时间
objCurrEduClsStuENT.signInStateID = objCurrEduClsStuENS.signInStateID; //签入状态表流水号
objCurrEduClsStuENT.signInUser = objCurrEduClsStuENS.signInUser; //签入人
objCurrEduClsStuENT.isOpByTeacher = objCurrEduClsStuENS.isOpByTeacher; //是否教师操作
objCurrEduClsStuENT.isSynScore = objCurrEduClsStuENS.isSynScore; //是否同步成绩
objCurrEduClsStuENT.modifyDate = objCurrEduClsStuENS.modifyDate; //修改日期
objCurrEduClsStuENT.modifyUserID = objCurrEduClsStuENS.modifyUserID; //修改人
objCurrEduClsStuENT.memo = objCurrEduClsStuENS.memo; //备注
objCurrEduClsStuENT.sf_UpdFldSetStr = objCurrEduClsStuENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objCurrEduClsStuENS:源对象
 * @param objCurrEduClsStuENT:目标对象
*/
export function CurrEduClsStu_GetObjFromJsonObj(objCurrEduClsStuENS: clsCurrEduClsStuEN): clsCurrEduClsStuEN 
{
 const objCurrEduClsStuENT: clsCurrEduClsStuEN = new clsCurrEduClsStuEN();
ObjectAssign(objCurrEduClsStuENT, objCurrEduClsStuENS);
 return objCurrEduClsStuENT;
}