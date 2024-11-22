
 /**
 * 类名:clsvSysScoreWeightWApi
 * 表名:vSysScoreWeight(01120630)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 17:11:44
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
 * v系统分数权重表(vSysScoreWeight)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvSysScoreWeightEN } from "../../L0_Entity/GraduateEduTools/clsvSysScoreWeightEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSysScoreWeight_Controller = "vSysScoreWeightApi";
 export const vSysScoreWeight_ConstructorName = "vSysScoreWeight";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strScoreWeightId:关键字
 * @returns 对象
 **/
export async function vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId: string): Promise<clsvSysScoreWeightEN>  
{
const strThisFuncName = "GetObjByScoreWeightIdAsync";

if (IsNullOrEmpty(strScoreWeightId) == true)
{
  const strMsg = Format("参数:[strScoreWeightId]不能为空！(In GetObjByScoreWeightIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreWeightId.length != 1)
{
const strMsg = Format("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！", strScoreWeightId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByScoreWeightId";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strScoreWeightId": strScoreWeightId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysScoreWeight = vSysScoreWeight_GetObjFromJsonObj(returnObj);
return objvSysScoreWeight;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreWeight_GetObjByScoreWeightId_Cache(strScoreWeightId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByScoreWeightId_Cache";

if (IsNullOrEmpty(strScoreWeightId) == true)
{
  const strMsg = Format("参数:[strScoreWeightId]不能为空！(In GetObjByScoreWeightId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreWeightId.length != 1)
{
const strMsg = Format("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！", strScoreWeightId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
try
{
const arrvSysScoreWeight_Sel: Array <clsvSysScoreWeightEN> = arrvSysScoreWeightObjLst_Cache.filter(x => x.scoreWeightId == strScoreWeightId);
let objvSysScoreWeight: clsvSysScoreWeightEN;
if (arrvSysScoreWeight_Sel.length > 0)
{
objvSysScoreWeight = arrvSysScoreWeight_Sel[0];
return objvSysScoreWeight;
}
else
{
if (bolTryAsyncOnce == true)
{
objvSysScoreWeight = await vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
if (objvSysScoreWeight != null)
{
vSysScoreWeight_ReFreshThisCache();
return objvSysScoreWeight;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreWeightId, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strScoreWeightId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreWeight_GetObjByScoreWeightId_localStorage(strScoreWeightId: string) {
const strThisFuncName = "GetObjByScoreWeightId_localStorage";

if (IsNullOrEmpty(strScoreWeightId) == true)
{
  const strMsg = Format("参数:[strScoreWeightId]不能为空！(In GetObjByScoreWeightId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreWeightId.length != 1)
{
const strMsg = Format("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！", strScoreWeightId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvSysScoreWeightEN._CurrTabName, strScoreWeightId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvSysScoreWeight_Cache: clsvSysScoreWeightEN = JSON.parse(strTempObj);
return objvSysScoreWeight_Cache;
}
try
{
const objvSysScoreWeight = await vSysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId);
if (objvSysScoreWeight != null)
{
localStorage.setItem(strKey, JSON.stringify(objvSysScoreWeight));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvSysScoreWeight;
}
return objvSysScoreWeight;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreWeightId, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function vSysScoreWeight_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvSysScoreWeightEN.con_ScoreWeightId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvSysScoreWeightEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvSysScoreWeightEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strScoreWeightId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvSysScoreWeight = await vSysScoreWeight_GetObjByScoreWeightId_Cache(strScoreWeightId );
if (objvSysScoreWeight == null) return "";
return objvSysScoreWeight.GetFldValue(strOutFldName).toString();
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
export function vSysScoreWeight_SortFun_Defa(a:clsvSysScoreWeightEN , b:clsvSysScoreWeightEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.scoreWeightId.localeCompare(b.scoreWeightId);
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
export function vSysScoreWeight_SortFun_Defa_2Fld(a:clsvSysScoreWeightEN , b:clsvSysScoreWeightEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.scoreWeightValue == b.scoreWeightValue) return a.updDate.localeCompare(b.updDate);
else return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
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
export function vSysScoreWeight_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSysScoreWeightEN.con_ScoreWeightId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.scoreWeightId.localeCompare(b.scoreWeightId);
}
case clsvSysScoreWeightEN.con_ScoreWeightValue:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
}
case clsvSysScoreWeightEN.con_IsPublic:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsvSysScoreWeightEN.con_UpdDate:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvSysScoreWeightEN.con_UpdUser:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvSysScoreWeightEN.con_Memo:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvSysScoreWeightEN.con_ScoreTypeId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.scoreTypeId.localeCompare(b.scoreTypeId);
}
case clsvSysScoreWeightEN.con_ScoreTypeName:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.scoreTypeName.localeCompare(b.scoreTypeName);
}
case clsvSysScoreWeightEN.con_OnlyId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.onlyId.localeCompare(b.onlyId);
}
case clsvSysScoreWeightEN.con_id_CurrEduCls:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvSysScoreWeightEN.con_CurrEduClsId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.currEduClsId.localeCompare(b.currEduClsId);
}
case clsvSysScoreWeightEN.con_EduClsName:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return a.eduClsName.localeCompare(b.eduClsName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${ vSysScoreWeight_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSysScoreWeightEN.con_ScoreWeightId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.scoreWeightId.localeCompare(a.scoreWeightId);
}
case clsvSysScoreWeightEN.con_ScoreWeightValue:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.scoreWeightValue.localeCompare(a.scoreWeightValue);
}
case clsvSysScoreWeightEN.con_IsPublic:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsvSysScoreWeightEN.con_UpdDate:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvSysScoreWeightEN.con_UpdUser:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvSysScoreWeightEN.con_Memo:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvSysScoreWeightEN.con_ScoreTypeId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.scoreTypeId.localeCompare(a.scoreTypeId);
}
case clsvSysScoreWeightEN.con_ScoreTypeName:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.scoreTypeName.localeCompare(a.scoreTypeName);
}
case clsvSysScoreWeightEN.con_OnlyId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.onlyId.localeCompare(a.onlyId);
}
case clsvSysScoreWeightEN.con_id_CurrEduCls:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvSysScoreWeightEN.con_CurrEduClsId:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.currEduClsId.localeCompare(a.currEduClsId);
}
case clsvSysScoreWeightEN.con_EduClsName:
return (a: clsvSysScoreWeightEN, b: clsvSysScoreWeightEN) => {
return b.eduClsName.localeCompare(a.eduClsName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${ vSysScoreWeight_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysScoreWeight_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSysScoreWeightEN.con_ScoreWeightId:
return (obj: clsvSysScoreWeightEN) => {
return obj.scoreWeightId === value;
}
case clsvSysScoreWeightEN.con_ScoreWeightValue:
return (obj: clsvSysScoreWeightEN) => {
return obj.scoreWeightValue === value;
}
case clsvSysScoreWeightEN.con_IsPublic:
return (obj: clsvSysScoreWeightEN) => {
return obj.isPublic === value;
}
case clsvSysScoreWeightEN.con_UpdDate:
return (obj: clsvSysScoreWeightEN) => {
return obj.updDate === value;
}
case clsvSysScoreWeightEN.con_UpdUser:
return (obj: clsvSysScoreWeightEN) => {
return obj.updUser === value;
}
case clsvSysScoreWeightEN.con_Memo:
return (obj: clsvSysScoreWeightEN) => {
return obj.memo === value;
}
case clsvSysScoreWeightEN.con_ScoreTypeId:
return (obj: clsvSysScoreWeightEN) => {
return obj.scoreTypeId === value;
}
case clsvSysScoreWeightEN.con_ScoreTypeName:
return (obj: clsvSysScoreWeightEN) => {
return obj.scoreTypeName === value;
}
case clsvSysScoreWeightEN.con_OnlyId:
return (obj: clsvSysScoreWeightEN) => {
return obj.onlyId === value;
}
case clsvSysScoreWeightEN.con_id_CurrEduCls:
return (obj: clsvSysScoreWeightEN) => {
return obj.id_CurrEduCls === value;
}
case clsvSysScoreWeightEN.con_CurrEduClsId:
return (obj: clsvSysScoreWeightEN) => {
return obj.currEduClsId === value;
}
case clsvSysScoreWeightEN.con_EduClsName:
return (obj: clsvSysScoreWeightEN) => {
return obj.eduClsName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSysScoreWeight]中不存在！(in ${ vSysScoreWeight_ConstructorName}.${ strThisFuncName})`;
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
export async function vSysScoreWeight_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetFirstObjAsync(strWhereCond: string): Promise<clsvSysScoreWeightEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSysScoreWeight = vSysScoreWeight_GetObjFromJsonObj(returnObj);
return objvSysScoreWeight;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSysScoreWeightEN._CurrTabName;
clsvSysScoreWeightEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreWeightEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreWeightEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreWeightEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvSysScoreWeightExObjLst_Cache: Array<clsvSysScoreWeightEN> = CacheHelper.Get(strKey);
const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
return arrvSysScoreWeightObjLst_T;
}
try
{
const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvSysScoreWeightExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
console.log(strInfo);
return arrvSysScoreWeightExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreWeight_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSysScoreWeightEN._CurrTabName;
clsvSysScoreWeightEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreWeightEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreWeightEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreWeightEN.CacheAddiCondition);
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
const arrvSysScoreWeightExObjLst_Cache: Array<clsvSysScoreWeightEN> = JSON.parse(strTempObjLst);
const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
return arrvSysScoreWeightObjLst_T;
}
try
{
const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvSysScoreWeightExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
console.log(strInfo);
return arrvSysScoreWeightExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreWeight_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvSysScoreWeightEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvSysScoreWeightObjLst_Cache: Array<clsvSysScoreWeightEN> = JSON.parse(strTempObjLst);
return arrvSysScoreWeightObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vSysScoreWeight_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSysScoreWeightEN._CurrTabName;
clsvSysScoreWeightEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSysScoreWeightEN._CurrTabName);
if (IsNullOrEmpty(clsvSysScoreWeightEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSysScoreWeightEN.CacheAddiCondition);
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
const arrvSysScoreWeightExObjLst_Cache: Array<clsvSysScoreWeightEN> = JSON.parse(strTempObjLst);
const arrvSysScoreWeightObjLst_T = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightExObjLst_Cache);
return arrvSysScoreWeightObjLst_T;
}
try
{
const arrvSysScoreWeightExObjLst = await vSysScoreWeight_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvSysScoreWeightExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreWeightExObjLst.length);
console.log(strInfo);
return arrvSysScoreWeightExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreWeight_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvSysScoreWeightEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvSysScoreWeightObjLst_Cache: Array<clsvSysScoreWeightEN> = JSON.parse(strTempObjLst);
return arrvSysScoreWeightObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreWeight_GetObjLst_Cache(): Promise<Array<clsvSysScoreWeightEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvSysScoreWeightObjLst_Cache;
switch (clsvSysScoreWeightEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_ClientCache();
break;
default:
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_ClientCache();
break;
}
const arrvSysScoreWeightObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(arrvSysScoreWeightObjLst_Cache);
return arrvSysScoreWeightObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSysScoreWeight_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvSysScoreWeightObjLst_Cache;
switch (clsvSysScoreWeightEN.CacheModeId)
{
case "04"://sessionStorage
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvSysScoreWeightObjLst_Cache = null;
break;
default:
arrvSysScoreWeightObjLst_Cache = null;
break;
}
return arrvSysScoreWeightObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrScoreWeightId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysScoreWeight_GetSubObjLst_Cache(objvSysScoreWeight_Cond: clsvSysScoreWeightEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
let arrvSysScoreWeight_Sel: Array < clsvSysScoreWeightEN > = arrvSysScoreWeightObjLst_Cache;
if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "") return arrvSysScoreWeight_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreWeight_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysScoreWeight_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvSysScoreWeight_Cond), vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreWeightEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrScoreWeightId:关键字列表
 * @returns 对象列表
 **/
export async function vSysScoreWeight_GetObjLstByScoreWeightIdLstAsync(arrScoreWeightId: Array<string>): Promise<Array<clsvSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByScoreWeightIdLstAsync";
const strAction = "GetObjLstByScoreWeightIdLst";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrScoreWeightId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param arrstrScoreWeightIdLst:关键字列表
 * @returns 对象列表
*/
export async function vSysScoreWeight_GetObjLstByScoreWeightIdLst_Cache(arrScoreWeightIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByScoreWeightIdLst_Cache";
try
{
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
const arrvSysScoreWeight_Sel: Array <clsvSysScoreWeightEN> = arrvSysScoreWeightObjLst_Cache.filter(x => arrScoreWeightIdLst.indexOf(x.scoreWeightId)>-1);
return arrvSysScoreWeight_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrScoreWeightIdLst.join(","), vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreWeightEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vSysScoreWeight_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSysScoreWeightEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
if (arrvSysScoreWeightObjLst_Cache.length == 0) return arrvSysScoreWeightObjLst_Cache;
let arrvSysScoreWeight_Sel = arrvSysScoreWeightObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvSysScoreWeight_Cond = new clsvSysScoreWeightEN();
ObjectAssign(objvSysScoreWeight_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvSysScoreWeightWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysScoreWeight_Sel.length == 0) return arrvSysScoreWeight_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.sort(vSysScoreWeight_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.sort(objPagerPara.sortFun);
}
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.slice(intStart, intEnd);     
return arrvSysScoreWeight_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSysScoreWeightEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vSysScoreWeight_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objstrScoreWeightId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSysScoreWeight_IsExistRecord_Cache(objvSysScoreWeight_Cond: clsvSysScoreWeightEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
if (arrvSysScoreWeightObjLst_Cache == null) return false;
let arrvSysScoreWeight_Sel: Array < clsvSysScoreWeightEN > = arrvSysScoreWeightObjLst_Cache;
if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "") return arrvSysScoreWeight_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreWeight_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSysScoreWeight_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvSysScoreWeight_Cond), vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vSysScoreWeight_IsExist(strScoreWeightId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ScoreWeightId": strScoreWeightId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:所给的关键字
 * @returns 对象
*/
export async function vSysScoreWeight_IsExist_Cache(strScoreWeightId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
if (arrvSysScoreWeightObjLst_Cache == null) return false;
try
{
const arrvSysScoreWeight_Sel: Array <clsvSysScoreWeightEN> = arrvSysScoreWeightObjLst_Cache.filter(x => x.scoreWeightId == strScoreWeightId);
if (arrvSysScoreWeight_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strScoreWeightId, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strScoreWeightId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vSysScoreWeight_IsExistAsync(strScoreWeightId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strScoreWeightId": strScoreWeightId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
export async function vSysScoreWeight_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objvSysScoreWeight_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vSysScoreWeight_GetRecCountByCond_Cache(objvSysScoreWeight_Cond: clsvSysScoreWeightEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvSysScoreWeightObjLst_Cache = await vSysScoreWeight_GetObjLst_Cache();
if (arrvSysScoreWeightObjLst_Cache == null) return 0;
let arrvSysScoreWeight_Sel: Array < clsvSysScoreWeightEN > = arrvSysScoreWeightObjLst_Cache;
if (objvSysScoreWeight_Cond.sf_FldComparisonOp == null || objvSysScoreWeight_Cond.sf_FldComparisonOp == "") return arrvSysScoreWeight_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSysScoreWeight_Cond.sf_FldComparisonOp);
//console.log("clsvSysScoreWeightWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSysScoreWeight_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSysScoreWeight_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSysScoreWeight_Sel = arrvSysScoreWeight_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSysScoreWeight_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvSysScoreWeight_Cond), vSysScoreWeight_ConstructorName, strThisFuncName);
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
export function vSysScoreWeight_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSysScoreWeight_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvSysScoreWeightEN._CurrTabName;
switch (clsvSysScoreWeightEN.CacheModeId)
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
export function vSysScoreWeight_GetJSONStrByObj (pobjvSysScoreWeightEN: clsvSysScoreWeightEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSysScoreWeightEN);
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
export function vSysScoreWeight_GetObjLstByJSONStr (strJSON: string): Array<clsvSysScoreWeightEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSysScoreWeightObjLst = new Array<clsvSysScoreWeightEN>();
if (strJSON === "")
{
return arrvSysScoreWeightObjLst;
}
try
{
arrvSysScoreWeightObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSysScoreWeightObjLst;
}
return arrvSysScoreWeightObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSysScoreWeightObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSysScoreWeight_GetObjLstByJSONObjLst (arrvSysScoreWeightObjLstS: Array<clsvSysScoreWeightEN>): Array<clsvSysScoreWeightEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSysScoreWeightObjLst = new Array<clsvSysScoreWeightEN>();
for (const objInFor of arrvSysScoreWeightObjLstS) {
const obj1 = vSysScoreWeight_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSysScoreWeightObjLst.push(obj1);
}
return arrvSysScoreWeightObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSysScoreWeight_GetObjByJSONStr (strJSON: string): clsvSysScoreWeightEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSysScoreWeightEN = new clsvSysScoreWeightEN();
if (strJSON === "")
{
return pobjvSysScoreWeightEN;
}
try
{
pobjvSysScoreWeightEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSysScoreWeightEN;
}
return pobjvSysScoreWeightEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSysScoreWeight_GetCombineCondition(objvSysScoreWeight_Cond: clsvSysScoreWeightEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_ScoreWeightId) == true)
{
const strComparisonOp_ScoreWeightId:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_ScoreWeightId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_ScoreWeightId, objvSysScoreWeight_Cond.scoreWeightId, strComparisonOp_ScoreWeightId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_ScoreWeightValue) == true)
{
const strComparisonOp_ScoreWeightValue:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_ScoreWeightValue];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_ScoreWeightValue, objvSysScoreWeight_Cond.scoreWeightValue, strComparisonOp_ScoreWeightValue);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_IsPublic) == true)
{
if (objvSysScoreWeight_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsvSysScoreWeightEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvSysScoreWeightEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_UpdDate, objvSysScoreWeight_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_UpdUser, objvSysScoreWeight_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_Memo, objvSysScoreWeight_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_ScoreTypeId) == true)
{
const strComparisonOp_ScoreTypeId:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_ScoreTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_ScoreTypeId, objvSysScoreWeight_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_ScoreTypeName) == true)
{
const strComparisonOp_ScoreTypeName:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_ScoreTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_ScoreTypeName, objvSysScoreWeight_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_OnlyId) == true)
{
const strComparisonOp_OnlyId:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_OnlyId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_OnlyId, objvSysScoreWeight_Cond.onlyId, strComparisonOp_OnlyId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_id_CurrEduCls, objvSysScoreWeight_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_CurrEduClsId) == true)
{
const strComparisonOp_CurrEduClsId:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_CurrEduClsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_CurrEduClsId, objvSysScoreWeight_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
}
if (Object.prototype.hasOwnProperty.call(objvSysScoreWeight_Cond.dicFldComparisonOp, clsvSysScoreWeightEN.con_EduClsName) == true)
{
const strComparisonOp_EduClsName:string = objvSysScoreWeight_Cond.dicFldComparisonOp[clsvSysScoreWeightEN.con_EduClsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSysScoreWeightEN.con_EduClsName, objvSysScoreWeight_Cond.eduClsName, strComparisonOp_EduClsName);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSysScoreWeightENS:源对象
 * @param objvSysScoreWeightENT:目标对象
*/
export function vSysScoreWeight_CopyObjTo(objvSysScoreWeightENS: clsvSysScoreWeightEN , objvSysScoreWeightENT: clsvSysScoreWeightEN ): void 
{
objvSysScoreWeightENT.scoreWeightId = objvSysScoreWeightENS.scoreWeightId; //分数权重Id
objvSysScoreWeightENT.scoreWeightValue = objvSysScoreWeightENS.scoreWeightValue; //分数权重值
objvSysScoreWeightENT.isPublic = objvSysScoreWeightENS.isPublic; //是否公开
objvSysScoreWeightENT.updDate = objvSysScoreWeightENS.updDate; //修改日期
objvSysScoreWeightENT.updUser = objvSysScoreWeightENS.updUser; //修改人
objvSysScoreWeightENT.memo = objvSysScoreWeightENS.memo; //备注
objvSysScoreWeightENT.scoreTypeId = objvSysScoreWeightENS.scoreTypeId; //分数类型Id
objvSysScoreWeightENT.scoreTypeName = objvSysScoreWeightENS.scoreTypeName; //分数类型名称
objvSysScoreWeightENT.onlyId = objvSysScoreWeightENS.onlyId; //OnlyId
objvSysScoreWeightENT.id_CurrEduCls = objvSysScoreWeightENS.id_CurrEduCls; //教学班流水号
objvSysScoreWeightENT.currEduClsId = objvSysScoreWeightENS.currEduClsId; //教学班Id
objvSysScoreWeightENT.eduClsName = objvSysScoreWeightENS.eduClsName; //教学班名
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSysScoreWeightENS:源对象
 * @param objvSysScoreWeightENT:目标对象
*/
export function vSysScoreWeight_GetObjFromJsonObj(objvSysScoreWeightENS: clsvSysScoreWeightEN): clsvSysScoreWeightEN 
{
 const objvSysScoreWeightENT: clsvSysScoreWeightEN = new clsvSysScoreWeightEN();
ObjectAssign(objvSysScoreWeightENT, objvSysScoreWeightENS);
 return objvSysScoreWeightENT;
}