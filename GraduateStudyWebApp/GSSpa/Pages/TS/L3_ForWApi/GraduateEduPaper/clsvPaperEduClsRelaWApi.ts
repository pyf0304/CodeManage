
 /**
 * 类名:clsvPaperEduClsRelaWApi
 * 表名:vPaperEduClsRela(01120932)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:44
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * vPaperEduClsRela(vPaperEduClsRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvPaperEduClsRelaEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperEduClsRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperEduClsRela_Controller = "vPaperEduClsRelaApi";
 export const vPaperEduClsRela_ConstructorName = "vPaperEduClsRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vPaperEduClsRela_GetObjBymIdAsync(lngmId: number): Promise<clsvPaperEduClsRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperEduClsRela = vPaperEduClsRela_GetObjFromJsonObj(returnObj);
return objvPaperEduClsRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvPaperEduClsRela_Sel: Array <clsvPaperEduClsRelaEN> = arrvPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objvPaperEduClsRela: clsvPaperEduClsRelaEN;
if (arrvPaperEduClsRela_Sel.length > 0)
{
objvPaperEduClsRela = arrvPaperEduClsRela_Sel[0];
return objvPaperEduClsRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymIdAsync(lngmId);
if (objvPaperEduClsRela != null)
{
vPaperEduClsRela_ReFreshThisCache(strid_CurrEduCls);
return objvPaperEduClsRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvPaperEduClsRela_Cache: clsvPaperEduClsRelaEN = JSON.parse(strTempObj);
return objvPaperEduClsRela_Cache;
}
try
{
const objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymIdAsync(lngmId);
if (objvPaperEduClsRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objvPaperEduClsRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvPaperEduClsRela;
}
return objvPaperEduClsRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsvPaperEduClsRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvPaperEduClsRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvPaperEduClsRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvPaperEduClsRela = await vPaperEduClsRela_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objvPaperEduClsRela == null) return "";
return objvPaperEduClsRela.GetFldValue(strOutFldName).toString();
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
export function vPaperEduClsRela_SortFun_Defa(a:clsvPaperEduClsRelaEN , b:clsvPaperEduClsRelaEN): number 
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
export function vPaperEduClsRela_SortFun_Defa_2Fld(a:clsvPaperEduClsRelaEN , b:clsvPaperEduClsRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.paperTitle.localeCompare(b.paperTitle);
else return a.paperId.localeCompare(b.paperId);
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
export function vPaperEduClsRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperEduClsRelaEN.con_mId:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.mId-b.mId;
}
case clsvPaperEduClsRelaEN.con_PaperId:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperEduClsRelaEN.con_PaperTitle:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperEduClsRelaEN.con_Author:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.author.localeCompare(b.author);
}
case clsvPaperEduClsRelaEN.con_id_CurrEduCls:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvPaperEduClsRelaEN.con_UpdUser:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvPaperEduClsRelaEN.con_UpdDate:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperEduClsRelaEN.con_Memo:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${ vPaperEduClsRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperEduClsRelaEN.con_mId:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.mId-a.mId;
}
case clsvPaperEduClsRelaEN.con_PaperId:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperEduClsRelaEN.con_PaperTitle:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperEduClsRelaEN.con_Author:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.author.localeCompare(a.author);
}
case clsvPaperEduClsRelaEN.con_id_CurrEduCls:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvPaperEduClsRelaEN.con_UpdUser:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvPaperEduClsRelaEN.con_UpdDate:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperEduClsRelaEN.con_Memo:
return (a: clsvPaperEduClsRelaEN, b: clsvPaperEduClsRelaEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${ vPaperEduClsRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperEduClsRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperEduClsRelaEN.con_mId:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.mId === value;
}
case clsvPaperEduClsRelaEN.con_PaperId:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.paperId === value;
}
case clsvPaperEduClsRelaEN.con_PaperTitle:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.paperTitle === value;
}
case clsvPaperEduClsRelaEN.con_Author:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.author === value;
}
case clsvPaperEduClsRelaEN.con_id_CurrEduCls:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsvPaperEduClsRelaEN.con_UpdUser:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.updUser === value;
}
case clsvPaperEduClsRelaEN.con_UpdDate:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.updDate === value;
}
case clsvPaperEduClsRelaEN.con_Memo:
return (obj: clsvPaperEduClsRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperEduClsRela]中不存在！(in ${ vPaperEduClsRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaperEduClsRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperEduClsRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaperEduClsRela = vPaperEduClsRela_GetObjFromJsonObj(returnObj);
return objvPaperEduClsRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
clsvPaperEduClsRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEduClsRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEduClsRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvPaperEduClsRelaExObjLst_Cache: Array<clsvPaperEduClsRelaEN> = CacheHelper.Get(strKey);
const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
return arrvPaperEduClsRelaObjLst_T;
}
try
{
const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvPaperEduClsRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrvPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
clsvPaperEduClsRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEduClsRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEduClsRelaEN.CacheAddiCondition);
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
const arrvPaperEduClsRelaExObjLst_Cache: Array<clsvPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
return arrvPaperEduClsRelaObjLst_T;
}
try
{
const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvPaperEduClsRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrvPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvPaperEduClsRelaObjLst_Cache: Array<clsvPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
return arrvPaperEduClsRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vPaperEduClsRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
clsvPaperEduClsRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEduClsRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEduClsRelaEN.CacheAddiCondition);
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
const arrvPaperEduClsRelaExObjLst_Cache: Array<clsvPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
const arrvPaperEduClsRelaObjLst_T = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaExObjLst_Cache);
return arrvPaperEduClsRelaObjLst_T;
}
try
{
const arrvPaperEduClsRelaExObjLst = await vPaperEduClsRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvPaperEduClsRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrvPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvPaperEduClsRelaObjLst_Cache: Array<clsvPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
return arrvPaperEduClsRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvPaperEduClsRelaEN>>
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
let arrvPaperEduClsRelaObjLst_Cache;
switch (clsvPaperEduClsRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvPaperEduClsRelaObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(arrvPaperEduClsRelaObjLst_Cache);
return arrvPaperEduClsRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperEduClsRela_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvPaperEduClsRelaObjLst_Cache;
switch (clsvPaperEduClsRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvPaperEduClsRelaObjLst_Cache = null;
break;
default:
arrvPaperEduClsRelaObjLst_Cache = null;
break;
}
return arrvPaperEduClsRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperEduClsRela_GetSubObjLst_Cache(objvPaperEduClsRela_Cond: clsvPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
let arrvPaperEduClsRela_Sel: Array < clsvPaperEduClsRelaEN > = arrvPaperEduClsRelaObjLst_Cache;
if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrvPaperEduClsRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperEduClsRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvPaperEduClsRela_Cond), vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEduClsRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperEduClsRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
const arrvPaperEduClsRela_Sel: Array <clsvPaperEduClsRelaEN> = arrvPaperEduClsRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvPaperEduClsRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEduClsRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vPaperEduClsRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperEduClsRelaObjLst_Cache.length == 0) return arrvPaperEduClsRelaObjLst_Cache;
let arrvPaperEduClsRela_Sel = arrvPaperEduClsRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaperEduClsRela_Cond = new clsvPaperEduClsRelaEN();
ObjectAssign(objvPaperEduClsRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperEduClsRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperEduClsRela_Sel.length == 0) return arrvPaperEduClsRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.sort(vPaperEduClsRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
}
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.slice(intStart, intEnd);     
return arrvPaperEduClsRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEduClsRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vPaperEduClsRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_IsExistRecord_Cache(objvPaperEduClsRela_Cond: clsvPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperEduClsRelaObjLst_Cache == null) return false;
let arrvPaperEduClsRela_Sel: Array < clsvPaperEduClsRelaEN > = arrvPaperEduClsRelaObjLst_Cache;
if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrvPaperEduClsRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperEduClsRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvPaperEduClsRela_Cond), vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperEduClsRelaObjLst_Cache == null) return false;
try
{
const arrvPaperEduClsRela_Sel: Array <clsvPaperEduClsRelaEN> = arrvPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvPaperEduClsRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export async function vPaperEduClsRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objvPaperEduClsRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaperEduClsRela_GetRecCountByCond_Cache(objvPaperEduClsRela_Cond: clsvPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvPaperEduClsRelaObjLst_Cache = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrvPaperEduClsRelaObjLst_Cache == null) return 0;
let arrvPaperEduClsRela_Sel: Array < clsvPaperEduClsRelaEN > = arrvPaperEduClsRelaObjLst_Cache;
if (objvPaperEduClsRela_Cond.sf_FldComparisonOp == null || objvPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrvPaperEduClsRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsvPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperEduClsRela_Sel = arrvPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperEduClsRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvPaperEduClsRela_Cond), vPaperEduClsRela_ConstructorName, strThisFuncName);
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
export function vPaperEduClsRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperEduClsRela_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
switch (clsvPaperEduClsRelaEN.CacheModeId)
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
 * @param strid_CurrEduCls:教学班流水号
*/
export async function vPaperEduClsRela_BindDdl_PaperIdInDiv_Cache(strDivName: string, strDdlName: string , strid_CurrEduCls: string)
{
const strThisFuncName = "BindDdl_PaperIdInDiv_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In BindDdl_PaperIdInDiv)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_PaperIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_PaperIdInDiv_Cache");
let arrObjLst_Sel = await vPaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjLst_Sel == null) return;
arrObjLst_Sel = arrObjLst_Sel.filter(x=>x.id_CurrEduCls == strid_CurrEduCls);
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvPaperEduClsRelaEN.con_PaperId, clsvPaperEduClsRelaEN.con_PaperTitle, "vPaperEduClsRela");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperEduClsRela_GetJSONStrByObj (pobjvPaperEduClsRelaEN: clsvPaperEduClsRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperEduClsRelaEN);
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
export function vPaperEduClsRela_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperEduClsRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperEduClsRelaObjLst = new Array<clsvPaperEduClsRelaEN>();
if (strJSON === "")
{
return arrvPaperEduClsRelaObjLst;
}
try
{
arrvPaperEduClsRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperEduClsRelaObjLst;
}
return arrvPaperEduClsRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperEduClsRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperEduClsRela_GetObjLstByJSONObjLst (arrvPaperEduClsRelaObjLstS: Array<clsvPaperEduClsRelaEN>): Array<clsvPaperEduClsRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperEduClsRelaObjLst = new Array<clsvPaperEduClsRelaEN>();
for (const objInFor of arrvPaperEduClsRelaObjLstS) {
const obj1 = vPaperEduClsRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperEduClsRelaObjLst.push(obj1);
}
return arrvPaperEduClsRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperEduClsRela_GetObjByJSONStr (strJSON: string): clsvPaperEduClsRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
if (strJSON === "")
{
return pobjvPaperEduClsRelaEN;
}
try
{
pobjvPaperEduClsRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperEduClsRelaEN;
}
return pobjvPaperEduClsRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperEduClsRela_GetCombineCondition(objvPaperEduClsRela_Cond: clsvPaperEduClsRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEduClsRelaEN.con_mId, objvPaperEduClsRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_PaperId, objvPaperEduClsRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_PaperTitle, objvPaperEduClsRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_Author, objvPaperEduClsRela_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_id_CurrEduCls, objvPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_UpdUser, objvPaperEduClsRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_UpdDate, objvPaperEduClsRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperEduClsRela_Cond.dicFldComparisonOp, clsvPaperEduClsRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperEduClsRela_Cond.dicFldComparisonOp[clsvPaperEduClsRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEduClsRelaEN.con_Memo, objvPaperEduClsRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperEduClsRelaENS:源对象
 * @param objvPaperEduClsRelaENT:目标对象
*/
export function vPaperEduClsRela_CopyObjTo(objvPaperEduClsRelaENS: clsvPaperEduClsRelaEN , objvPaperEduClsRelaENT: clsvPaperEduClsRelaEN ): void 
{
objvPaperEduClsRelaENT.mId = objvPaperEduClsRelaENS.mId; //mId
objvPaperEduClsRelaENT.paperId = objvPaperEduClsRelaENS.paperId; //论文Id
objvPaperEduClsRelaENT.paperTitle = objvPaperEduClsRelaENS.paperTitle; //论文标题
objvPaperEduClsRelaENT.author = objvPaperEduClsRelaENS.author; //作者
objvPaperEduClsRelaENT.id_CurrEduCls = objvPaperEduClsRelaENS.id_CurrEduCls; //教学班流水号
objvPaperEduClsRelaENT.updUser = objvPaperEduClsRelaENS.updUser; //修改人
objvPaperEduClsRelaENT.updDate = objvPaperEduClsRelaENS.updDate; //修改日期
objvPaperEduClsRelaENT.memo = objvPaperEduClsRelaENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperEduClsRelaENS:源对象
 * @param objvPaperEduClsRelaENT:目标对象
*/
export function vPaperEduClsRela_GetObjFromJsonObj(objvPaperEduClsRelaENS: clsvPaperEduClsRelaEN): clsvPaperEduClsRelaEN 
{
 const objvPaperEduClsRelaENT: clsvPaperEduClsRelaEN = new clsvPaperEduClsRelaEN();
ObjectAssign(objvPaperEduClsRelaENT, objvPaperEduClsRelaENS);
 return objvPaperEduClsRelaENT;
}