
 /**
 * 类名:clsCurrEduClsTeacherWApi
 * 表名:CurrEduClsTeacher(01120124)
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
 * 当前教学班教师(CurrEduClsTeacher)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsCurrEduClsTeacherEN } from "../../L0_Entity/DailyRunning/clsCurrEduClsTeacherEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { vCurrEduClsTeacher_ReFreshThisCache } from "../../L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const currEduClsTeacher_Controller = "CurrEduClsTeacherApi";
 export const currEduClsTeacher_ConstructorName = "currEduClsTeacher";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngid_EduClsTeacher:关键字
 * @returns 对象
 **/
export async function CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher: number): Promise<clsCurrEduClsTeacherEN>  
{
const strThisFuncName = "GetObjByid_EduClsTeacherAsync";

if (lngid_EduClsTeacher == 0)
{
  const strMsg = Format("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacherAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByid_EduClsTeacher";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngid_EduClsTeacher": lngid_EduClsTeacher,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduClsTeacher = CurrEduClsTeacher_GetObjFromJsonObj(returnObj);
return objCurrEduClsTeacher;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsTeacher:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_EduClsTeacher_Cache";

if (lngid_EduClsTeacher == 0)
{
  const strMsg = Format("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacher_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrCurrEduClsTeacher_Sel: Array <clsCurrEduClsTeacherEN> = arrCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
let objCurrEduClsTeacher: clsCurrEduClsTeacherEN;
if (arrCurrEduClsTeacher_Sel.length > 0)
{
objCurrEduClsTeacher = arrCurrEduClsTeacher_Sel[0];
return objCurrEduClsTeacher;
}
else
{
if (bolTryAsyncOnce == true)
{
objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
if (objCurrEduClsTeacher != null)
{
CurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls);
return objCurrEduClsTeacher;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngid_EduClsTeacher:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage(lngid_EduClsTeacher: number) {
const strThisFuncName = "GetObjByid_EduClsTeacher_localStorage";

if (lngid_EduClsTeacher == 0)
{
  const strMsg = Format("参数:[lngid_EduClsTeacher]不能为空！(In GetObjByid_EduClsTeacher_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, lngid_EduClsTeacher);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objCurrEduClsTeacher_Cache: clsCurrEduClsTeacherEN = JSON.parse(strTempObj);
return objCurrEduClsTeacher_Cache;
}
try
{
const objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
if (objCurrEduClsTeacher != null)
{
localStorage.setItem(strKey, JSON.stringify(objCurrEduClsTeacher));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objCurrEduClsTeacher;
}
return objCurrEduClsTeacher;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objCurrEduClsTeacher:所给的对象
 * @returns 对象
*/
export async function CurrEduClsTeacher_UpdateObjInLst_Cache(objCurrEduClsTeacher: clsCurrEduClsTeacherEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrCurrEduClsTeacherObjLst_Cache.find(x => x.id_CurrEduCls == objCurrEduClsTeacher.id_CurrEduCls && x.id_Teacher == objCurrEduClsTeacher.id_Teacher);
if (obj != null)
{
objCurrEduClsTeacher.id_EduClsTeacher = obj.id_EduClsTeacher;
ObjectAssign( obj, objCurrEduClsTeacher);
}
else
{
arrCurrEduClsTeacherObjLst_Cache.push(objCurrEduClsTeacher);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsCurrEduClsTeacherEN.con_id_EduClsTeacher)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsCurrEduClsTeacherEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsCurrEduClsTeacherEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngid_EduClsTeacher = Number(strInValue);
if (lngid_EduClsTeacher == 0)
{
return "";
}
const objCurrEduClsTeacher = await CurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher , strid_CurrEduCls_C);
if (objCurrEduClsTeacher == null) return "";
return objCurrEduClsTeacher.GetFldValue(strOutFldName).toString();
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
export function CurrEduClsTeacher_SortFun_Defa(a:clsCurrEduClsTeacherEN , b:clsCurrEduClsTeacherEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_EduClsTeacher-b.id_EduClsTeacher;
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
export function CurrEduClsTeacher_SortFun_Defa_2Fld(a:clsCurrEduClsTeacherEN , b:clsCurrEduClsTeacherEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.id_Teacher.localeCompare(b.id_Teacher);
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
export function CurrEduClsTeacher_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.id_EduClsTeacher-b.id_EduClsTeacher;
}
case clsCurrEduClsTeacherEN.con_id_CurrEduCls:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsCurrEduClsTeacherEN.con_id_Teacher:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.id_Teacher.localeCompare(b.id_Teacher);
}
case clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
}
case clsCurrEduClsTeacherEN.con_SchoolTerm:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsCurrEduClsTeacherEN.con_SchoolYear:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsCurrEduClsTeacherEN.con_OpenBeginDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.openBeginDate.localeCompare(b.openBeginDate);
}
case clsCurrEduClsTeacherEN.con_OpenEndDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.openEndDate.localeCompare(b.openEndDate);
}
case clsCurrEduClsTeacherEN.con_OrderNum:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.orderNum-b.orderNum;
}
case clsCurrEduClsTeacherEN.con_UpdDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsCurrEduClsTeacherEN.con_UpdUser:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsCurrEduClsTeacherEN.con_Memo:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${ currEduClsTeacher_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.id_EduClsTeacher-a.id_EduClsTeacher;
}
case clsCurrEduClsTeacherEN.con_id_CurrEduCls:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsCurrEduClsTeacherEN.con_id_Teacher:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.id_Teacher.localeCompare(a.id_Teacher);
}
case clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.id_Pk2EduClsTeacherType.localeCompare(a.id_Pk2EduClsTeacherType);
}
case clsCurrEduClsTeacherEN.con_SchoolTerm:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsCurrEduClsTeacherEN.con_SchoolYear:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsCurrEduClsTeacherEN.con_OpenBeginDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.openBeginDate.localeCompare(a.openBeginDate);
}
case clsCurrEduClsTeacherEN.con_OpenEndDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.openEndDate.localeCompare(a.openEndDate);
}
case clsCurrEduClsTeacherEN.con_OrderNum:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.orderNum-a.orderNum;
}
case clsCurrEduClsTeacherEN.con_UpdDate:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsCurrEduClsTeacherEN.con_UpdUser:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsCurrEduClsTeacherEN.con_Memo:
return (a: clsCurrEduClsTeacherEN, b: clsCurrEduClsTeacherEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${ currEduClsTeacher_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduClsTeacher_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.id_EduClsTeacher === value;
}
case clsCurrEduClsTeacherEN.con_id_CurrEduCls:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.id_CurrEduCls === value;
}
case clsCurrEduClsTeacherEN.con_id_Teacher:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.id_Teacher === value;
}
case clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.id_Pk2EduClsTeacherType === value;
}
case clsCurrEduClsTeacherEN.con_SchoolTerm:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.schoolTerm === value;
}
case clsCurrEduClsTeacherEN.con_SchoolYear:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.schoolYear === value;
}
case clsCurrEduClsTeacherEN.con_OpenBeginDate:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.openBeginDate === value;
}
case clsCurrEduClsTeacherEN.con_OpenEndDate:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.openEndDate === value;
}
case clsCurrEduClsTeacherEN.con_OrderNum:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.orderNum === value;
}
case clsCurrEduClsTeacherEN.con_UpdDate:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.updDate === value;
}
case clsCurrEduClsTeacherEN.con_UpdUser:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.updUser === value;
}
case clsCurrEduClsTeacherEN.con_Memo:
return (obj: clsCurrEduClsTeacherEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[CurrEduClsTeacher]中不存在！(in ${ currEduClsTeacher_ConstructorName}.${ strThisFuncName})`;
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
export async function CurrEduClsTeacher_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetFirstObjAsync(strWhereCond: string): Promise<clsCurrEduClsTeacherEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objCurrEduClsTeacher = CurrEduClsTeacher_GetObjFromJsonObj(returnObj);
return objCurrEduClsTeacher;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsTeacherEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsTeacherEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsTeacherEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsTeacherEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrCurrEduClsTeacherExObjLst_Cache: Array<clsCurrEduClsTeacherEN> = CacheHelper.Get(strKey);
const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
return arrCurrEduClsTeacherObjLst_T;
}
try
{
const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrCurrEduClsTeacherExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
console.log(strInfo);
return arrCurrEduClsTeacherExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsTeacherEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsTeacherEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsTeacherEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsTeacherEN.CacheAddiCondition);
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
const arrCurrEduClsTeacherExObjLst_Cache: Array<clsCurrEduClsTeacherEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
return arrCurrEduClsTeacherObjLst_T;
}
try
{
const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrCurrEduClsTeacherExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
console.log(strInfo);
return arrCurrEduClsTeacherExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrCurrEduClsTeacherObjLst_Cache: Array<clsCurrEduClsTeacherEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsTeacherObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function CurrEduClsTeacher_GetObjLstAsync(strWhereCond: string): Promise<Array<clsCurrEduClsTeacherEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
clsCurrEduClsTeacherEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsCurrEduClsTeacherEN._CurrTabName);
if (IsNullOrEmpty(clsCurrEduClsTeacherEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsCurrEduClsTeacherEN.CacheAddiCondition);
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
const arrCurrEduClsTeacherExObjLst_Cache: Array<clsCurrEduClsTeacherEN> = JSON.parse(strTempObjLst);
const arrCurrEduClsTeacherObjLst_T = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherExObjLst_Cache);
return arrCurrEduClsTeacherObjLst_T;
}
try
{
const arrCurrEduClsTeacherExObjLst = await CurrEduClsTeacher_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrCurrEduClsTeacherExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCurrEduClsTeacherExObjLst.length);
console.log(strInfo);
return arrCurrEduClsTeacherExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrCurrEduClsTeacherObjLst_Cache: Array<clsCurrEduClsTeacherEN> = JSON.parse(strTempObjLst);
return arrCurrEduClsTeacherObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsCurrEduClsTeacherEN>>
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
let arrCurrEduClsTeacherObjLst_Cache;
switch (clsCurrEduClsTeacherEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrCurrEduClsTeacherObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(arrCurrEduClsTeacherObjLst_Cache);
return arrCurrEduClsTeacherObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function CurrEduClsTeacher_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrCurrEduClsTeacherObjLst_Cache;
switch (clsCurrEduClsTeacherEN.CacheModeId)
{
case "04"://sessionStorage
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrCurrEduClsTeacherObjLst_Cache = null;
break;
default:
arrCurrEduClsTeacherObjLst_Cache = null;
break;
}
return arrCurrEduClsTeacherObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngid_EduClsTeacher_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CurrEduClsTeacher_GetSubObjLst_Cache(objCurrEduClsTeacher_Cond: clsCurrEduClsTeacherEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
let arrCurrEduClsTeacher_Sel: Array < clsCurrEduClsTeacherEN > = arrCurrEduClsTeacherObjLst_Cache;
if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "") return arrCurrEduClsTeacher_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsTeacher_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduClsTeacher_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduClsTeacher_Cond), currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsTeacherEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_EduClsTeacher:关键字列表
 * @returns 对象列表
 **/
export async function CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync(arrid_EduClsTeacher: Array<string>): Promise<Array<clsCurrEduClsTeacherEN>>  
{
const strThisFuncName = "GetObjLstByid_EduClsTeacherLstAsync";
const strAction = "GetObjLstByid_EduClsTeacherLst";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_EduClsTeacher);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param arrlngid_EduClsTeacherLst:关键字列表
 * @returns 对象列表
*/
export async function CurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache(arrid_EduClsTeacherLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByid_EduClsTeacherLst_Cache";
try
{
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
const arrCurrEduClsTeacher_Sel: Array <clsCurrEduClsTeacherEN> = arrCurrEduClsTeacherObjLst_Cache.filter(x => arrid_EduClsTeacherLst.indexOf(x.id_EduClsTeacher)>-1);
return arrCurrEduClsTeacher_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsTeacherLst.join(","), currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsTeacherEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function CurrEduClsTeacher_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsCurrEduClsTeacherEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsCurrEduClsTeacherEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsTeacherObjLst_Cache.length == 0) return arrCurrEduClsTeacherObjLst_Cache;
let arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacherObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objCurrEduClsTeacher_Cond = new clsCurrEduClsTeacherEN();
ObjectAssign(objCurrEduClsTeacher_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduClsTeacher_Sel.length == 0) return arrCurrEduClsTeacher_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(CurrEduClsTeacher_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
}
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.slice(intStart, intEnd);     
return arrCurrEduClsTeacher_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsCurrEduClsTeacherEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function CurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsCurrEduClsTeacherEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = CurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsTeacher:关键字
 * @returns 获取删除的结果
 **/
export async function CurrEduClsTeacher_DelRecordAsync(lngid_EduClsTeacher: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngid_EduClsTeacher);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngid_EduClsTeacher, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param arrid_EduClsTeacher:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function CurrEduClsTeacher_DelCurrEduClsTeachersAsync(arrid_EduClsTeacher: Array<string>): Promise<number> 
{
const strThisFuncName = "DelCurrEduClsTeachersAsync";
const strAction = "DelCurrEduClsTeachers";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_EduClsTeacher);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_DelCurrEduClsTeachersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelCurrEduClsTeachersByCondAsync";
const strAction = "DelCurrEduClsTeachersByCond";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_AddNewRecordAsync(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsTeacherEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function CurrEduClsTeacher_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objCurrEduClsTeacherEN);
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacherEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function CurrEduClsTeacher_AddNewRecordWithReturnKeyAsync(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsTeacherEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacherEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function CurrEduClsTeacher_AddNewRecordWithReturnKey(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objCurrEduClsTeacherEN.id_EduClsTeacher === null || objCurrEduClsTeacherEN.id_EduClsTeacher === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsTeacherEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacherEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function CurrEduClsTeacher_UpdateRecordAsync(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objCurrEduClsTeacherEN.sf_UpdFldSetStr === undefined || objCurrEduClsTeacherEN.sf_UpdFldSetStr === null || objCurrEduClsTeacherEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsTeacherEN.id_EduClsTeacher);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.post(strUrl, objCurrEduClsTeacherEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacherEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function CurrEduClsTeacher_UpdateWithConditionAsync(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objCurrEduClsTeacherEN.sf_UpdFldSetStr === undefined || objCurrEduClsTeacherEN.sf_UpdFldSetStr === null || objCurrEduClsTeacherEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCurrEduClsTeacherEN.id_EduClsTeacher);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
objCurrEduClsTeacherEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objCurrEduClsTeacherEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objlngid_EduClsTeacher_Cond:条件对象
 * @returns 对象列表子集
*/
export async function CurrEduClsTeacher_IsExistRecord_Cache(objCurrEduClsTeacher_Cond: clsCurrEduClsTeacherEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsTeacherObjLst_Cache == null) return false;
let arrCurrEduClsTeacher_Sel: Array < clsCurrEduClsTeacherEN > = arrCurrEduClsTeacherObjLst_Cache;
if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "") return arrCurrEduClsTeacher_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsTeacher_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrCurrEduClsTeacher_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objCurrEduClsTeacher_Cond), currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsTeacher:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function CurrEduClsTeacher_IsExist(lngid_EduClsTeacher: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_EduClsTeacher": lngid_EduClsTeacher,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param lngid_EduClsTeacher:所给的关键字
 * @returns 对象
*/
export async function CurrEduClsTeacher_IsExist_Cache(lngid_EduClsTeacher:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsTeacherObjLst_Cache == null) return false;
try
{
const arrCurrEduClsTeacher_Sel: Array <clsCurrEduClsTeacherEN> = arrCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
if (arrCurrEduClsTeacher_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsTeacher, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngid_EduClsTeacher:关键字
 * @returns 是否存在?存在返回True
 **/
export async function CurrEduClsTeacher_IsExistAsync(lngid_EduClsTeacher: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngid_EduClsTeacher": lngid_EduClsTeacher }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
 * @param objCurrEduClsTeacher_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function CurrEduClsTeacher_GetRecCountByCond_Cache(objCurrEduClsTeacher_Cond: clsCurrEduClsTeacherEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrCurrEduClsTeacherObjLst_Cache = await CurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
if (arrCurrEduClsTeacherObjLst_Cache == null) return 0;
let arrCurrEduClsTeacher_Sel: Array < clsCurrEduClsTeacherEN > = arrCurrEduClsTeacherObjLst_Cache;
if (objCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objCurrEduClsTeacher_Cond.sf_FldComparisonOp == "") return arrCurrEduClsTeacher_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objCurrEduClsTeacher_Cond.sf_FldComparisonOp);
//console.log("clsCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objCurrEduClsTeacher_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objCurrEduClsTeacher_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrCurrEduClsTeacher_Sel = arrCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrCurrEduClsTeacher_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objCurrEduClsTeacher_Cond), currEduClsTeacher_ConstructorName, strThisFuncName);
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
export async function CurrEduClsTeacher_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(currEduClsTeacher_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, currEduClsTeacher_ConstructorName, strThisFuncName);
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
export function CurrEduClsTeacher_GetWebApiUrl(strController: string, strAction: string): string {
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
export function CurrEduClsTeacher_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsCurrEduClsTeacherWApi.ReFreshCache)");
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
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
switch (clsCurrEduClsTeacherEN.CacheModeId)
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
vCurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function CurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
switch (clsCurrEduClsTeacherEN.CacheModeId)
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
export function CurrEduClsTeacher_CheckPropertyNew(pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_CurrEduCls)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Teacher) > 8)
{
 throw new Error("(errid:Watl000059)字段[教师流水号(id_Teacher)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Teacher)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Error("(errid:Watl000059)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsTeacherEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000059)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolTerm)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolYear) == false && GetStrLen(pobjCurrEduClsTeacherEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000059)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolYear)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openBeginDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.openBeginDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[开放开始日期(openBeginDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openBeginDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openEndDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.openEndDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[开放结束日期(openEndDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openEndDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updDate)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updUser) == false && GetStrLen(pobjCurrEduClsTeacherEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updUser)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.memo) == false && GetStrLen(pobjCurrEduClsTeacherEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.memo)(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjCurrEduClsTeacherEN.id_EduClsTeacher && undefined !== pobjCurrEduClsTeacherEN.id_EduClsTeacher && tzDataType.isNumber(pobjCurrEduClsTeacherEN.id_EduClsTeacher) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班老师流水号(id_EduClsTeacher)]的值:[$(pobjCurrEduClsTeacherEN.id_EduClsTeacher)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsTeacherEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsTeacherEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsTeacherEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && undefined !== pobjCurrEduClsTeacherEN.id_Teacher && tzDataType.isString(pobjCurrEduClsTeacherEN.id_Teacher) === false)
{
 throw new Error("(errid:Watl000060)字段[教师流水号(id_Teacher)]的值:[$(pobjCurrEduClsTeacherEN.id_Teacher)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType && tzDataType.isString(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolTerm) == false && undefined !== pobjCurrEduClsTeacherEN.schoolTerm && tzDataType.isString(pobjCurrEduClsTeacherEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000060)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsTeacherEN.schoolTerm)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolYear) == false && undefined !== pobjCurrEduClsTeacherEN.schoolYear && tzDataType.isString(pobjCurrEduClsTeacherEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000060)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsTeacherEN.schoolYear)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openBeginDate) == false && undefined !== pobjCurrEduClsTeacherEN.openBeginDate && tzDataType.isString(pobjCurrEduClsTeacherEN.openBeginDate) === false)
{
 throw new Error("(errid:Watl000060)字段[开放开始日期(openBeginDate)]的值:[$(pobjCurrEduClsTeacherEN.openBeginDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openEndDate) == false && undefined !== pobjCurrEduClsTeacherEN.openEndDate && tzDataType.isString(pobjCurrEduClsTeacherEN.openEndDate) === false)
{
 throw new Error("(errid:Watl000060)字段[开放结束日期(openEndDate)]的值:[$(pobjCurrEduClsTeacherEN.openEndDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (null != pobjCurrEduClsTeacherEN.orderNum && undefined !== pobjCurrEduClsTeacherEN.orderNum && tzDataType.isNumber(pobjCurrEduClsTeacherEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjCurrEduClsTeacherEN.orderNum)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updDate) == false && undefined !== pobjCurrEduClsTeacherEN.updDate && tzDataType.isString(pobjCurrEduClsTeacherEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjCurrEduClsTeacherEN.updDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updUser) == false && undefined !== pobjCurrEduClsTeacherEN.updUser && tzDataType.isString(pobjCurrEduClsTeacherEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjCurrEduClsTeacherEN.updUser)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.memo) == false && undefined !== pobjCurrEduClsTeacherEN.memo && tzDataType.isString(pobjCurrEduClsTeacherEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCurrEduClsTeacherEN.memo)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_CurrEduCls) !=  8)
{
 throw ("(errid:Watl000061)字段[教学班流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Teacher) !=  8)
{
 throw ("(errid:Watl000061)字段[教师流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) !=  4)
{
 throw ("(errid:Watl000061)字段[教学班老师角色(主讲,辅导)流水号]作为外键字段,长度应该为4(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjCurrEduClsTeacherEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function CurrEduClsTeacher_CheckProperty4Update (pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_CurrEduCls)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Teacher) > 8)
{
 throw new Error("(errid:Watl000062)字段[教师流水号(id_Teacher)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Teacher)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) > 4)
{
 throw new Error("(errid:Watl000062)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的长度不能超过4(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolTerm) == false && GetStrLen(pobjCurrEduClsTeacherEN.schoolTerm) > 1)
{
 throw new Error("(errid:Watl000062)字段[学期(schoolTerm)]的长度不能超过1(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolTerm)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolYear) == false && GetStrLen(pobjCurrEduClsTeacherEN.schoolYear) > 10)
{
 throw new Error("(errid:Watl000062)字段[学年(schoolYear)]的长度不能超过10(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.schoolYear)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openBeginDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.openBeginDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[开放开始日期(openBeginDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openBeginDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openEndDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.openEndDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[开放结束日期(openEndDate)]的长度不能超过8(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.openEndDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updDate) == false && GetStrLen(pobjCurrEduClsTeacherEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updDate)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updUser) == false && GetStrLen(pobjCurrEduClsTeacherEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.updUser)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.memo) == false && GetStrLen(pobjCurrEduClsTeacherEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 当前教学班教师(CurrEduClsTeacher))!值:$(pobjCurrEduClsTeacherEN.memo)(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjCurrEduClsTeacherEN.id_EduClsTeacher && undefined !== pobjCurrEduClsTeacherEN.id_EduClsTeacher && tzDataType.isNumber(pobjCurrEduClsTeacherEN.id_EduClsTeacher) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班老师流水号(id_EduClsTeacher)]的值:[$(pobjCurrEduClsTeacherEN.id_EduClsTeacher)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && undefined !== pobjCurrEduClsTeacherEN.id_CurrEduCls && tzDataType.isString(pobjCurrEduClsTeacherEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjCurrEduClsTeacherEN.id_CurrEduCls)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && undefined !== pobjCurrEduClsTeacherEN.id_Teacher && tzDataType.isString(pobjCurrEduClsTeacherEN.id_Teacher) === false)
{
 throw new Error("(errid:Watl000063)字段[教师流水号(id_Teacher)]的值:[$(pobjCurrEduClsTeacherEN.id_Teacher)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && undefined !== pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType && tzDataType.isString(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班老师角色(主讲,辅导)流水号(id_Pk2EduClsTeacherType)]的值:[$(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolTerm) == false && undefined !== pobjCurrEduClsTeacherEN.schoolTerm && tzDataType.isString(pobjCurrEduClsTeacherEN.schoolTerm) === false)
{
 throw new Error("(errid:Watl000063)字段[学期(schoolTerm)]的值:[$(pobjCurrEduClsTeacherEN.schoolTerm)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.schoolYear) == false && undefined !== pobjCurrEduClsTeacherEN.schoolYear && tzDataType.isString(pobjCurrEduClsTeacherEN.schoolYear) === false)
{
 throw new Error("(errid:Watl000063)字段[学年(schoolYear)]的值:[$(pobjCurrEduClsTeacherEN.schoolYear)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openBeginDate) == false && undefined !== pobjCurrEduClsTeacherEN.openBeginDate && tzDataType.isString(pobjCurrEduClsTeacherEN.openBeginDate) === false)
{
 throw new Error("(errid:Watl000063)字段[开放开始日期(openBeginDate)]的值:[$(pobjCurrEduClsTeacherEN.openBeginDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.openEndDate) == false && undefined !== pobjCurrEduClsTeacherEN.openEndDate && tzDataType.isString(pobjCurrEduClsTeacherEN.openEndDate) === false)
{
 throw new Error("(errid:Watl000063)字段[开放结束日期(openEndDate)]的值:[$(pobjCurrEduClsTeacherEN.openEndDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (null != pobjCurrEduClsTeacherEN.orderNum && undefined !== pobjCurrEduClsTeacherEN.orderNum && tzDataType.isNumber(pobjCurrEduClsTeacherEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjCurrEduClsTeacherEN.orderNum)], 非法，应该为数值型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updDate) == false && undefined !== pobjCurrEduClsTeacherEN.updDate && tzDataType.isString(pobjCurrEduClsTeacherEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjCurrEduClsTeacherEN.updDate)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.updUser) == false && undefined !== pobjCurrEduClsTeacherEN.updUser && tzDataType.isString(pobjCurrEduClsTeacherEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjCurrEduClsTeacherEN.updUser)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.memo) == false && undefined !== pobjCurrEduClsTeacherEN.memo && tzDataType.isString(pobjCurrEduClsTeacherEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCurrEduClsTeacherEN.memo)], 非法，应该为字符型(In 当前教学班教师(CurrEduClsTeacher))!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjCurrEduClsTeacherEN.id_EduClsTeacher 
 || pobjCurrEduClsTeacherEN.id_EduClsTeacher != null && pobjCurrEduClsTeacherEN.id_EduClsTeacher.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[教学班老师流水号]不能为空(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_CurrEduCls) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_CurrEduCls) !=  8)
{
 throw ("(errid:Watl000065)字段[教学班流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Teacher) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Teacher) !=  8)
{
 throw ("(errid:Watl000065)字段[教师流水号]作为外键字段,长度应该为8(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) == false && GetStrLen(pobjCurrEduClsTeacherEN.id_Pk2EduClsTeacherType) !=  4)
{
 throw ("(errid:Watl000065)字段[教学班老师角色(主讲,辅导)流水号]作为外键字段,长度应该为4(In 当前教学班教师)!(clsCurrEduClsTeacherBL:CheckPropertyNew)");
}

 pobjCurrEduClsTeacherEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduClsTeacher_GetJSONStrByObj (pobjCurrEduClsTeacherEN: clsCurrEduClsTeacherEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjCurrEduClsTeacherEN.sf_UpdFldSetStr = pobjCurrEduClsTeacherEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjCurrEduClsTeacherEN);
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
export function CurrEduClsTeacher_GetObjLstByJSONStr (strJSON: string): Array<clsCurrEduClsTeacherEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrCurrEduClsTeacherObjLst = new Array<clsCurrEduClsTeacherEN>();
if (strJSON === "")
{
return arrCurrEduClsTeacherObjLst;
}
try
{
arrCurrEduClsTeacherObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrCurrEduClsTeacherObjLst;
}
return arrCurrEduClsTeacherObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrCurrEduClsTeacherObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function CurrEduClsTeacher_GetObjLstByJSONObjLst (arrCurrEduClsTeacherObjLstS: Array<clsCurrEduClsTeacherEN>): Array<clsCurrEduClsTeacherEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrCurrEduClsTeacherObjLst = new Array<clsCurrEduClsTeacherEN>();
for (const objInFor of arrCurrEduClsTeacherObjLstS) {
const obj1 = CurrEduClsTeacher_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrCurrEduClsTeacherObjLst.push(obj1);
}
return arrCurrEduClsTeacherObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function CurrEduClsTeacher_GetObjByJSONStr (strJSON: string): clsCurrEduClsTeacherEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
if (strJSON === "")
{
return pobjCurrEduClsTeacherEN;
}
try
{
pobjCurrEduClsTeacherEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjCurrEduClsTeacherEN;
}
return pobjCurrEduClsTeacherEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function CurrEduClsTeacher_GetCombineCondition(objCurrEduClsTeacher_Cond: clsCurrEduClsTeacherEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_id_EduClsTeacher) == true)
{
const strComparisonOp_id_EduClsTeacher:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_id_EduClsTeacher];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsTeacherEN.con_id_EduClsTeacher, objCurrEduClsTeacher_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_id_CurrEduCls, objCurrEduClsTeacher_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_id_Teacher) == true)
{
const strComparisonOp_id_Teacher:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_id_Teacher];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_id_Teacher, objCurrEduClsTeacher_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType) == true)
{
const strComparisonOp_id_Pk2EduClsTeacherType:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType, objCurrEduClsTeacher_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_SchoolTerm, objCurrEduClsTeacher_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_SchoolYear, objCurrEduClsTeacher_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_OpenBeginDate) == true)
{
const strComparisonOp_OpenBeginDate:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_OpenBeginDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_OpenBeginDate, objCurrEduClsTeacher_Cond.openBeginDate, strComparisonOp_OpenBeginDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_OpenEndDate) == true)
{
const strComparisonOp_OpenEndDate:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_OpenEndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_OpenEndDate, objCurrEduClsTeacher_Cond.openEndDate, strComparisonOp_OpenEndDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsCurrEduClsTeacherEN.con_OrderNum, objCurrEduClsTeacher_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_UpdDate, objCurrEduClsTeacher_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_UpdUser, objCurrEduClsTeacher_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objCurrEduClsTeacher_Cond.dicFldComparisonOp, clsCurrEduClsTeacherEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objCurrEduClsTeacher_Cond.dicFldComparisonOp[clsCurrEduClsTeacherEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsCurrEduClsTeacherEN.con_Memo, objCurrEduClsTeacher_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @param strid_Teacher: 教师流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduClsTeacher_GetUniCondStr_id_CurrEduCls_id_Teacher(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
 strWhereCond +=  Format(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @param strid_Teacher: 教师流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function CurrEduClsTeacher_GetUniCondStr4Update_id_CurrEduCls_id_Teacher(objCurrEduClsTeacherEN: clsCurrEduClsTeacherEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_EduClsTeacher <> '{0}'", objCurrEduClsTeacherEN.id_EduClsTeacher);
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objCurrEduClsTeacherEN.id_CurrEduCls);
 strWhereCond +=  Format(" and id_Teacher = '{0}'", objCurrEduClsTeacherEN.id_Teacher);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objCurrEduClsTeacherENS:源对象
 * @param objCurrEduClsTeacherENT:目标对象
*/
export function CurrEduClsTeacher_CopyObjTo(objCurrEduClsTeacherENS: clsCurrEduClsTeacherEN , objCurrEduClsTeacherENT: clsCurrEduClsTeacherEN ): void 
{
objCurrEduClsTeacherENT.id_EduClsTeacher = objCurrEduClsTeacherENS.id_EduClsTeacher; //教学班老师流水号
objCurrEduClsTeacherENT.id_CurrEduCls = objCurrEduClsTeacherENS.id_CurrEduCls; //教学班流水号
objCurrEduClsTeacherENT.id_Teacher = objCurrEduClsTeacherENS.id_Teacher; //教师流水号
objCurrEduClsTeacherENT.id_Pk2EduClsTeacherType = objCurrEduClsTeacherENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherENT.schoolTerm = objCurrEduClsTeacherENS.schoolTerm; //学期
objCurrEduClsTeacherENT.schoolYear = objCurrEduClsTeacherENS.schoolYear; //学年
objCurrEduClsTeacherENT.openBeginDate = objCurrEduClsTeacherENS.openBeginDate; //开放开始日期
objCurrEduClsTeacherENT.openEndDate = objCurrEduClsTeacherENS.openEndDate; //开放结束日期
objCurrEduClsTeacherENT.orderNum = objCurrEduClsTeacherENS.orderNum; //序号
objCurrEduClsTeacherENT.updDate = objCurrEduClsTeacherENS.updDate; //修改日期
objCurrEduClsTeacherENT.updUser = objCurrEduClsTeacherENS.updUser; //修改人
objCurrEduClsTeacherENT.memo = objCurrEduClsTeacherENS.memo; //备注
objCurrEduClsTeacherENT.sf_UpdFldSetStr = objCurrEduClsTeacherENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objCurrEduClsTeacherENS:源对象
 * @param objCurrEduClsTeacherENT:目标对象
*/
export function CurrEduClsTeacher_GetObjFromJsonObj(objCurrEduClsTeacherENS: clsCurrEduClsTeacherEN): clsCurrEduClsTeacherEN 
{
 const objCurrEduClsTeacherENT: clsCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
ObjectAssign(objCurrEduClsTeacherENT, objCurrEduClsTeacherENS);
 return objCurrEduClsTeacherENT;
}