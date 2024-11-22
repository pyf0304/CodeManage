
 /**
 * 类名:clsgs_TotalDataRelaWApi
 * 表名:gs_TotalDataRela(01120700)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:10
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
 * 各观点总数据关系表(gs_TotalDataRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TotalDataRelaEN } from "../../L0_Entity/GraduateEduTools/clsgs_TotalDataRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TotalDataRela_Controller = "gs_TotalDataRelaApi";
 export const gs_TotalDataRela_ConstructorName = "gs_TotalDataRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function gs_TotalDataRela_GetObjBymIdAsync(lngmId: number): Promise<clsgs_TotalDataRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TotalDataRela = gs_TotalDataRela_GetObjFromJsonObj(returnObj);
return objgs_TotalDataRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrgs_TotalDataRela_Sel: Array <clsgs_TotalDataRelaEN> = arrgs_TotalDataRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objgs_TotalDataRela: clsgs_TotalDataRelaEN;
if (arrgs_TotalDataRela_Sel.length > 0)
{
objgs_TotalDataRela = arrgs_TotalDataRela_Sel[0];
return objgs_TotalDataRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymIdAsync(lngmId);
if (objgs_TotalDataRela != null)
{
gs_TotalDataRela_ReFreshThisCache(strid_CurrEduCls);
return objgs_TotalDataRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TotalDataRela_Cache: clsgs_TotalDataRelaEN = JSON.parse(strTempObj);
return objgs_TotalDataRela_Cache;
}
try
{
const objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymIdAsync(lngmId);
if (objgs_TotalDataRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TotalDataRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TotalDataRela;
}
return objgs_TotalDataRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TotalDataRela:所给的对象
 * @returns 对象
*/
export async function gs_TotalDataRela_UpdateObjInLst_Cache(objgs_TotalDataRela: clsgs_TotalDataRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrgs_TotalDataRelaObjLst_Cache.find(x => x.mId == objgs_TotalDataRela.mId);
if (obj != null)
{
objgs_TotalDataRela.mId = obj.mId;
ObjectAssign( obj, objgs_TotalDataRela);
}
else
{
arrgs_TotalDataRelaObjLst_Cache.push(objgs_TotalDataRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsgs_TotalDataRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TotalDataRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TotalDataRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objgs_TotalDataRela = await gs_TotalDataRela_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objgs_TotalDataRela == null) return "";
return objgs_TotalDataRela.GetFldValue(strOutFldName).toString();
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
export function gs_TotalDataRela_SortFun_Defa(a:clsgs_TotalDataRelaEN , b:clsgs_TotalDataRelaEN): number 
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
export function gs_TotalDataRela_SortFun_Defa_2Fld(a:clsgs_TotalDataRelaEN , b:clsgs_TotalDataRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_CurrEduCls == b.id_CurrEduCls) return a.updDate.localeCompare(b.updDate);
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
export function gs_TotalDataRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TotalDataRelaEN.con_mId:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.mId-b.mId;
}
case clsgs_TotalDataRelaEN.con_id_CurrEduCls:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_TotalDataRelaEN.con_UpdDate:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TotalDataRelaEN.con_UpdUser:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TotalDataRelaEN.con_Memo:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_TotalDataRelaEN.con_TDRelaTypeId:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.tdRelaTypeId.localeCompare(b.tdRelaTypeId);
}
case clsgs_TotalDataRelaEN.con_TotalDataId1:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.totalDataId1.localeCompare(b.totalDataId1);
}
case clsgs_TotalDataRelaEN.con_TotalDataId2:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return a.totalDataId2.localeCompare(b.totalDataId2);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${ gs_TotalDataRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TotalDataRelaEN.con_mId:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.mId-a.mId;
}
case clsgs_TotalDataRelaEN.con_id_CurrEduCls:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_TotalDataRelaEN.con_UpdDate:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TotalDataRelaEN.con_UpdUser:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TotalDataRelaEN.con_Memo:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_TotalDataRelaEN.con_TDRelaTypeId:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.tdRelaTypeId.localeCompare(a.tdRelaTypeId);
}
case clsgs_TotalDataRelaEN.con_TotalDataId1:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.totalDataId1.localeCompare(a.totalDataId1);
}
case clsgs_TotalDataRelaEN.con_TotalDataId2:
return (a: clsgs_TotalDataRelaEN, b: clsgs_TotalDataRelaEN) => {
return b.totalDataId2.localeCompare(a.totalDataId2);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${ gs_TotalDataRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TotalDataRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TotalDataRelaEN.con_mId:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.mId === value;
}
case clsgs_TotalDataRelaEN.con_id_CurrEduCls:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_TotalDataRelaEN.con_UpdDate:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.updDate === value;
}
case clsgs_TotalDataRelaEN.con_UpdUser:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.updUser === value;
}
case clsgs_TotalDataRelaEN.con_Memo:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.memo === value;
}
case clsgs_TotalDataRelaEN.con_TDRelaTypeId:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.tdRelaTypeId === value;
}
case clsgs_TotalDataRelaEN.con_TotalDataId1:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.totalDataId1 === value;
}
case clsgs_TotalDataRelaEN.con_TotalDataId2:
return (obj: clsgs_TotalDataRelaEN) => {
return obj.totalDataId2 === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataRela]中不存在！(in ${ gs_TotalDataRela_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TotalDataRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TotalDataRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TotalDataRela = gs_TotalDataRela_GetObjFromJsonObj(returnObj);
return objgs_TotalDataRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
clsgs_TotalDataRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TotalDataRelaEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TotalDataRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TotalDataRelaExObjLst_Cache: Array<clsgs_TotalDataRelaEN> = CacheHelper.Get(strKey);
const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
return arrgs_TotalDataRelaObjLst_T;
}
try
{
const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TotalDataRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataRela_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
clsgs_TotalDataRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TotalDataRelaEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TotalDataRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataRelaEN.CacheAddiCondition);
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
const arrgs_TotalDataRelaExObjLst_Cache: Array<clsgs_TotalDataRelaEN> = JSON.parse(strTempObjLst);
const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
return arrgs_TotalDataRelaObjLst_T;
}
try
{
const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TotalDataRelaObjLst_Cache: Array<clsgs_TotalDataRelaEN> = JSON.parse(strTempObjLst);
return arrgs_TotalDataRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TotalDataRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TotalDataRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
clsgs_TotalDataRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TotalDataRelaEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TotalDataRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TotalDataRelaEN.CacheAddiCondition);
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
const arrgs_TotalDataRelaExObjLst_Cache: Array<clsgs_TotalDataRelaEN> = JSON.parse(strTempObjLst);
const arrgs_TotalDataRelaObjLst_T = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaExObjLst_Cache);
return arrgs_TotalDataRelaObjLst_T;
}
try
{
const arrgs_TotalDataRelaExObjLst = await gs_TotalDataRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataRelaExObjLst.length);
console.log(strInfo);
return arrgs_TotalDataRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TotalDataRelaObjLst_Cache: Array<clsgs_TotalDataRelaEN> = JSON.parse(strTempObjLst);
return arrgs_TotalDataRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsgs_TotalDataRelaEN>>
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
let arrgs_TotalDataRelaObjLst_Cache;
switch (clsgs_TotalDataRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrgs_TotalDataRelaObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(arrgs_TotalDataRelaObjLst_Cache);
return arrgs_TotalDataRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TotalDataRela_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TotalDataRelaObjLst_Cache;
switch (clsgs_TotalDataRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrgs_TotalDataRelaObjLst_Cache = null;
break;
default:
arrgs_TotalDataRelaObjLst_Cache = null;
break;
}
return arrgs_TotalDataRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TotalDataRela_GetSubObjLst_Cache(objgs_TotalDataRela_Cond: clsgs_TotalDataRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
let arrgs_TotalDataRela_Sel: Array < clsgs_TotalDataRelaEN > = arrgs_TotalDataRelaObjLst_Cache;
if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TotalDataRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TotalDataRela_Cond), gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TotalDataRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TotalDataRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsgs_TotalDataRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
const arrgs_TotalDataRela_Sel: Array <clsgs_TotalDataRelaEN> = arrgs_TotalDataRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrgs_TotalDataRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TotalDataRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_TotalDataRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TotalDataRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TotalDataRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataRelaObjLst_Cache.length == 0) return arrgs_TotalDataRelaObjLst_Cache;
let arrgs_TotalDataRela_Sel = arrgs_TotalDataRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TotalDataRela_Cond = new clsgs_TotalDataRelaEN();
ObjectAssign(objgs_TotalDataRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TotalDataRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TotalDataRela_Sel.length == 0) return arrgs_TotalDataRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.sort(gs_TotalDataRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.sort(objPagerPara.sortFun);
}
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.slice(intStart, intEnd);     
return arrgs_TotalDataRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TotalDataRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TotalDataRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TotalDataRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TotalDataRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TotalDataRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngmId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TotalDataRela_Delgs_TotalDataRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TotalDataRelasAsync";
const strAction = "Delgs_TotalDataRelas";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_Delgs_TotalDataRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TotalDataRelasByCondAsync";
const strAction = "Delgs_TotalDataRelasByCond";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TotalDataRela_AddNewRecordAsync(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TotalDataRelaEN);
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TotalDataRela_AddNewRecordWithReturnKeyAsync(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TotalDataRela_AddNewRecordWithReturnKey(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TotalDataRelaEN.mId === null || objgs_TotalDataRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TotalDataRela_UpdateRecordAsync(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TotalDataRelaEN.sf_UpdFldSetStr === undefined || objgs_TotalDataRelaEN.sf_UpdFldSetStr === null || objgs_TotalDataRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TotalDataRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TotalDataRela_UpdateWithConditionAsync(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TotalDataRelaEN.sf_UpdFldSetStr === undefined || objgs_TotalDataRelaEN.sf_UpdFldSetStr === null || objgs_TotalDataRelaEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
objgs_TotalDataRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TotalDataRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_IsExistRecord_Cache(objgs_TotalDataRela_Cond: clsgs_TotalDataRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataRelaObjLst_Cache == null) return false;
let arrgs_TotalDataRela_Sel: Array < clsgs_TotalDataRelaEN > = arrgs_TotalDataRelaObjLst_Cache;
if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TotalDataRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TotalDataRela_Cond), gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataRelaObjLst_Cache == null) return false;
try
{
const arrgs_TotalDataRela_Sel: Array <clsgs_TotalDataRelaEN> = arrgs_TotalDataRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrgs_TotalDataRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
 * @param objgs_TotalDataRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TotalDataRela_GetRecCountByCond_Cache(objgs_TotalDataRela_Cond: clsgs_TotalDataRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TotalDataRelaObjLst_Cache = await gs_TotalDataRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrgs_TotalDataRelaObjLst_Cache == null) return 0;
let arrgs_TotalDataRela_Sel: Array < clsgs_TotalDataRelaEN > = arrgs_TotalDataRelaObjLst_Cache;
if (objgs_TotalDataRela_Cond.sf_FldComparisonOp == null || objgs_TotalDataRela_Cond.sf_FldComparisonOp == "") return arrgs_TotalDataRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TotalDataRela_Cond.sf_FldComparisonOp);
//console.log("clsgs_TotalDataRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TotalDataRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TotalDataRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TotalDataRela_Sel = arrgs_TotalDataRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TotalDataRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TotalDataRela_Cond), gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export async function gs_TotalDataRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TotalDataRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TotalDataRela_ConstructorName, strThisFuncName);
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
export function gs_TotalDataRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TotalDataRela_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsgs_TotalDataRelaWApi.ReFreshCache)");
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
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TotalDataRelaEN.CacheModeId)
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
export function gs_TotalDataRela_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsgs_TotalDataRelaEN._CurrTabName, strid_CurrEduCls);
switch (clsgs_TotalDataRelaEN.CacheModeId)
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
export function gs_TotalDataRela_CheckPropertyNew(pobjgs_TotalDataRelaEN: clsgs_TotalDataRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.id_CurrEduCls) === true 
 || pobjgs_TotalDataRelaEN.id_CurrEduCls.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId1) === true )
{
 throw new Error("(errid:Watl000058)字段[TotalDataId1]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId2) === true )
{
 throw new Error("(errid:Watl000058)字段[TotalDataId2]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TotalDataRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.id_CurrEduCls)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updDate) == false && GetStrLen(pobjgs_TotalDataRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updDate)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updUser) == false && GetStrLen(pobjgs_TotalDataRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updUser)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.memo) == false && GetStrLen(pobjgs_TotalDataRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.memo)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && GetStrLen(pobjgs_TotalDataRelaEN.tdRelaTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.tdRelaTypeId)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId1) == false && GetStrLen(pobjgs_TotalDataRelaEN.totalDataId1) > 12)
{
 throw new Error("(errid:Watl000059)字段[TotalDataId1(totalDataId1)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId1)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId2) == false && GetStrLen(pobjgs_TotalDataRelaEN.totalDataId2) > 12)
{
 throw new Error("(errid:Watl000059)字段[TotalDataId2(totalDataId2)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId2)(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TotalDataRelaEN.mId && undefined !== pobjgs_TotalDataRelaEN.mId && tzDataType.isNumber(pobjgs_TotalDataRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjgs_TotalDataRelaEN.mId)], 非法，应该为数值型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataRelaEN.id_CurrEduCls && tzDataType.isString(pobjgs_TotalDataRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updDate) == false && undefined !== pobjgs_TotalDataRelaEN.updDate && tzDataType.isString(pobjgs_TotalDataRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataRelaEN.updDate)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updUser) == false && undefined !== pobjgs_TotalDataRelaEN.updUser && tzDataType.isString(pobjgs_TotalDataRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataRelaEN.updUser)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.memo) == false && undefined !== pobjgs_TotalDataRelaEN.memo && tzDataType.isString(pobjgs_TotalDataRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TotalDataRelaEN.memo)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && undefined !== pobjgs_TotalDataRelaEN.tdRelaTypeId && tzDataType.isString(pobjgs_TotalDataRelaEN.tdRelaTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TotalDataRelaEN.tdRelaTypeId)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId1) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId1 && tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId1) === false)
{
 throw new Error("(errid:Watl000060)字段[TotalDataId1(totalDataId1)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId1)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId2) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId2 && tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId2) === false)
{
 throw new Error("(errid:Watl000060)字段[TotalDataId2(totalDataId2)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId2)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TotalDataRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TotalDataRela_CheckProperty4Update (pobjgs_TotalDataRelaEN: clsgs_TotalDataRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TotalDataRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.id_CurrEduCls)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updDate) == false && GetStrLen(pobjgs_TotalDataRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updDate)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updUser) == false && GetStrLen(pobjgs_TotalDataRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.updUser)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.memo) == false && GetStrLen(pobjgs_TotalDataRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.memo)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && GetStrLen(pobjgs_TotalDataRelaEN.tdRelaTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[总数据关系类型Id(tdRelaTypeId)]的长度不能超过2(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.tdRelaTypeId)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId1) == false && GetStrLen(pobjgs_TotalDataRelaEN.totalDataId1) > 12)
{
 throw new Error("(errid:Watl000062)字段[TotalDataId1(totalDataId1)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId1)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId2) == false && GetStrLen(pobjgs_TotalDataRelaEN.totalDataId2) > 12)
{
 throw new Error("(errid:Watl000062)字段[TotalDataId2(totalDataId2)]的长度不能超过12(In 各观点总数据关系表(gs_TotalDataRela))!值:$(pobjgs_TotalDataRelaEN.totalDataId2)(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_TotalDataRelaEN.mId && undefined !== pobjgs_TotalDataRelaEN.mId && tzDataType.isNumber(pobjgs_TotalDataRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjgs_TotalDataRelaEN.mId)], 非法，应该为数值型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.id_CurrEduCls) == false && undefined !== pobjgs_TotalDataRelaEN.id_CurrEduCls && tzDataType.isString(pobjgs_TotalDataRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TotalDataRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updDate) == false && undefined !== pobjgs_TotalDataRelaEN.updDate && tzDataType.isString(pobjgs_TotalDataRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TotalDataRelaEN.updDate)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.updUser) == false && undefined !== pobjgs_TotalDataRelaEN.updUser && tzDataType.isString(pobjgs_TotalDataRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TotalDataRelaEN.updUser)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.memo) == false && undefined !== pobjgs_TotalDataRelaEN.memo && tzDataType.isString(pobjgs_TotalDataRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TotalDataRelaEN.memo)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.tdRelaTypeId) == false && undefined !== pobjgs_TotalDataRelaEN.tdRelaTypeId && tzDataType.isString(pobjgs_TotalDataRelaEN.tdRelaTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[总数据关系类型Id(tdRelaTypeId)]的值:[$(pobjgs_TotalDataRelaEN.tdRelaTypeId)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId1) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId1 && tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId1) === false)
{
 throw new Error("(errid:Watl000063)字段[TotalDataId1(totalDataId1)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId1)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TotalDataRelaEN.totalDataId2) == false && undefined !== pobjgs_TotalDataRelaEN.totalDataId2 && tzDataType.isString(pobjgs_TotalDataRelaEN.totalDataId2) === false)
{
 throw new Error("(errid:Watl000063)字段[TotalDataId2(totalDataId2)]的值:[$(pobjgs_TotalDataRelaEN.totalDataId2)], 非法，应该为字符型(In 各观点总数据关系表(gs_TotalDataRela))!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_TotalDataRelaEN.mId 
 || pobjgs_TotalDataRelaEN.mId != null && pobjgs_TotalDataRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 各观点总数据关系表)!(clsgs_TotalDataRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TotalDataRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TotalDataRela_GetJSONStrByObj (pobjgs_TotalDataRelaEN: clsgs_TotalDataRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TotalDataRelaEN.sf_UpdFldSetStr = pobjgs_TotalDataRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TotalDataRelaEN);
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
export function gs_TotalDataRela_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TotalDataRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TotalDataRelaObjLst = new Array<clsgs_TotalDataRelaEN>();
if (strJSON === "")
{
return arrgs_TotalDataRelaObjLst;
}
try
{
arrgs_TotalDataRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TotalDataRelaObjLst;
}
return arrgs_TotalDataRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TotalDataRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TotalDataRela_GetObjLstByJSONObjLst (arrgs_TotalDataRelaObjLstS: Array<clsgs_TotalDataRelaEN>): Array<clsgs_TotalDataRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TotalDataRelaObjLst = new Array<clsgs_TotalDataRelaEN>();
for (const objInFor of arrgs_TotalDataRelaObjLstS) {
const obj1 = gs_TotalDataRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TotalDataRelaObjLst.push(obj1);
}
return arrgs_TotalDataRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TotalDataRela_GetObjByJSONStr (strJSON: string): clsgs_TotalDataRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TotalDataRelaEN = new clsgs_TotalDataRelaEN();
if (strJSON === "")
{
return pobjgs_TotalDataRelaEN;
}
try
{
pobjgs_TotalDataRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TotalDataRelaEN;
}
return pobjgs_TotalDataRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TotalDataRela_GetCombineCondition(objgs_TotalDataRela_Cond: clsgs_TotalDataRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TotalDataRelaEN.con_mId, objgs_TotalDataRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_id_CurrEduCls, objgs_TotalDataRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_UpdDate, objgs_TotalDataRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_UpdUser, objgs_TotalDataRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_Memo, objgs_TotalDataRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_TDRelaTypeId) == true)
{
const strComparisonOp_TDRelaTypeId:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_TDRelaTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_TDRelaTypeId, objgs_TotalDataRela_Cond.tdRelaTypeId, strComparisonOp_TDRelaTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_TotalDataId1) == true)
{
const strComparisonOp_TotalDataId1:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_TotalDataId1];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_TotalDataId1, objgs_TotalDataRela_Cond.totalDataId1, strComparisonOp_TotalDataId1);
}
if (Object.prototype.hasOwnProperty.call(objgs_TotalDataRela_Cond.dicFldComparisonOp, clsgs_TotalDataRelaEN.con_TotalDataId2) == true)
{
const strComparisonOp_TotalDataId2:string = objgs_TotalDataRela_Cond.dicFldComparisonOp[clsgs_TotalDataRelaEN.con_TotalDataId2];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TotalDataRelaEN.con_TotalDataId2, objgs_TotalDataRela_Cond.totalDataId2, strComparisonOp_TotalDataId2);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TotalDataRela(各观点总数据关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TotalDataRela_GetUniCondStr_mId(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TotalDataRelaEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TotalDataRela(各观点总数据关系表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TotalDataRela_GetUniCondStr4Update_mId(objgs_TotalDataRelaEN: clsgs_TotalDataRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objgs_TotalDataRelaEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objgs_TotalDataRelaEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TotalDataRelaENS:源对象
 * @param objgs_TotalDataRelaENT:目标对象
*/
export function gs_TotalDataRela_CopyObjTo(objgs_TotalDataRelaENS: clsgs_TotalDataRelaEN , objgs_TotalDataRelaENT: clsgs_TotalDataRelaEN ): void 
{
objgs_TotalDataRelaENT.mId = objgs_TotalDataRelaENS.mId; //mId
objgs_TotalDataRelaENT.id_CurrEduCls = objgs_TotalDataRelaENS.id_CurrEduCls; //教学班流水号
objgs_TotalDataRelaENT.updDate = objgs_TotalDataRelaENS.updDate; //修改日期
objgs_TotalDataRelaENT.updUser = objgs_TotalDataRelaENS.updUser; //修改人
objgs_TotalDataRelaENT.memo = objgs_TotalDataRelaENS.memo; //备注
objgs_TotalDataRelaENT.tdRelaTypeId = objgs_TotalDataRelaENS.tdRelaTypeId; //总数据关系类型Id
objgs_TotalDataRelaENT.totalDataId1 = objgs_TotalDataRelaENS.totalDataId1; //TotalDataId1
objgs_TotalDataRelaENT.totalDataId2 = objgs_TotalDataRelaENS.totalDataId2; //TotalDataId2
objgs_TotalDataRelaENT.sf_UpdFldSetStr = objgs_TotalDataRelaENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TotalDataRelaENS:源对象
 * @param objgs_TotalDataRelaENT:目标对象
*/
export function gs_TotalDataRela_GetObjFromJsonObj(objgs_TotalDataRelaENS: clsgs_TotalDataRelaEN): clsgs_TotalDataRelaEN 
{
 const objgs_TotalDataRelaENT: clsgs_TotalDataRelaEN = new clsgs_TotalDataRelaEN();
ObjectAssign(objgs_TotalDataRelaENT, objgs_TotalDataRelaENS);
 return objgs_TotalDataRelaENT;
}