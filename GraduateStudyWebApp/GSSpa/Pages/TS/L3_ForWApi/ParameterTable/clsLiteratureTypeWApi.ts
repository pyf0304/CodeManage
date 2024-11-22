
 /**
 * 类名:clsLiteratureTypeWApi
 * 表名:LiteratureType(01120557)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:26
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 文献类型(LiteratureType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsLiteratureTypeEN } from "../../L0_Entity/ParameterTable/clsLiteratureTypeEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const literatureType_Controller = "LiteratureTypeApi";
 export const literatureType_ConstructorName = "literatureType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strLiteratureTypeId:关键字
 * @returns 对象
 **/
export async function LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId: string): Promise<clsLiteratureTypeEN>  
{
const strThisFuncName = "GetObjByLiteratureTypeIdAsync";

if (IsNullOrEmpty(strLiteratureTypeId) == true)
{
  const strMsg = Format("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strLiteratureTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByLiteratureTypeId";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strLiteratureTypeId": strLiteratureTypeId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objLiteratureType = LiteratureType_GetObjFromJsonObj(returnObj);
return objLiteratureType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param strLiteratureTypeId:所给的关键字
 * @returns 对象
*/
export async function LiteratureType_GetObjByLiteratureTypeId_Cache(strLiteratureTypeId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByLiteratureTypeId_Cache";

if (IsNullOrEmpty(strLiteratureTypeId) == true)
{
  const strMsg = Format("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strLiteratureTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
try
{
const arrLiteratureType_Sel: Array <clsLiteratureTypeEN> = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
let objLiteratureType: clsLiteratureTypeEN;
if (arrLiteratureType_Sel.length > 0)
{
objLiteratureType = arrLiteratureType_Sel[0];
return objLiteratureType;
}
else
{
if (bolTryAsyncOnce == true)
{
objLiteratureType = await LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId);
if (objLiteratureType != null)
{
LiteratureType_ReFreshThisCache();
return objLiteratureType;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLiteratureTypeId, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strLiteratureTypeId:所给的关键字
 * @returns 对象
*/
export async function LiteratureType_GetObjByLiteratureTypeId_localStorage(strLiteratureTypeId: string) {
const strThisFuncName = "GetObjByLiteratureTypeId_localStorage";

if (IsNullOrEmpty(strLiteratureTypeId) == true)
{
  const strMsg = Format("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strLiteratureTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsLiteratureTypeEN._CurrTabName, strLiteratureTypeId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objLiteratureType_Cache: clsLiteratureTypeEN = JSON.parse(strTempObj);
return objLiteratureType_Cache;
}
try
{
const objLiteratureType = await LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId);
if (objLiteratureType != null)
{
localStorage.setItem(strKey, JSON.stringify(objLiteratureType));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objLiteratureType;
}
return objLiteratureType;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLiteratureTypeId, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objLiteratureType:所给的对象
 * @returns 对象
*/
export async function LiteratureType_UpdateObjInLst_Cache(objLiteratureType: clsLiteratureTypeEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
const obj = arrLiteratureTypeObjLst_Cache.find(x => 
x.literatureTypeId == objLiteratureType.literatureTypeId);
if (obj != null)
{
objLiteratureType.literatureTypeId = obj.literatureTypeId;
ObjectAssign( obj, objLiteratureType);
}
else
{
arrLiteratureTypeObjLst_Cache.push(objLiteratureType);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strLiteratureTypeId:所给的关键字
 * @returns 对象
*/
export async function LiteratureType_GetNameByLiteratureTypeId_Cache(strLiteratureTypeId: string) {
const strThisFuncName = "GetNameByLiteratureTypeId_Cache";

if (IsNullOrEmpty(strLiteratureTypeId) == true)
{
  const strMsg = Format("参数:[strLiteratureTypeId]不能为空！(In GetNameByLiteratureTypeId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strLiteratureTypeId.length != 2)
{
const strMsg = Format("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
console.error(strMsg);
throw (strMsg);
}
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
if (arrLiteratureTypeObjLst_Cache == null) return "";
try
{
const arrLiteratureType_Sel: Array <clsLiteratureTypeEN> = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
let objLiteratureType: clsLiteratureTypeEN;
if (arrLiteratureType_Sel.length > 0)
{
objLiteratureType = arrLiteratureType_Sel[0];
return objLiteratureType.literatureTypeName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strLiteratureTypeId);
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
export async function LiteratureType_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsLiteratureTypeEN.con_LiteratureTypeId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsLiteratureTypeEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsLiteratureTypeEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strLiteratureTypeId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objLiteratureType = await LiteratureType_GetObjByLiteratureTypeId_Cache(strLiteratureTypeId );
if (objLiteratureType == null) return "";
return objLiteratureType.GetFldValue(strOutFldName).toString();
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
export function LiteratureType_SortFun_Defa(a:clsLiteratureTypeEN , b:clsLiteratureTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.literatureTypeId.localeCompare(b.literatureTypeId);
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
export function LiteratureType_SortFun_Defa_2Fld(a:clsLiteratureTypeEN , b:clsLiteratureTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.literatureTypeName == b.literatureTypeName) return a.updUserId.localeCompare(b.updUserId);
else return a.literatureTypeName.localeCompare(b.literatureTypeName);
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
export function LiteratureType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsLiteratureTypeEN.con_LiteratureTypeId:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsLiteratureTypeEN.con_LiteratureTypeName:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return a.literatureTypeName.localeCompare(b.literatureTypeName);
}
case clsLiteratureTypeEN.con_UpdUserId:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsLiteratureTypeEN.con_UpdDate:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return a.updDate.localeCompare(b.updDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${ literatureType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsLiteratureTypeEN.con_LiteratureTypeId:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsLiteratureTypeEN.con_LiteratureTypeName:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return b.literatureTypeName.localeCompare(a.literatureTypeName);
}
case clsLiteratureTypeEN.con_UpdUserId:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsLiteratureTypeEN.con_UpdDate:
return (a: clsLiteratureTypeEN, b: clsLiteratureTypeEN) => {
return b.updDate.localeCompare(a.updDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${ literatureType_ConstructorName}.${ strThisFuncName})`;
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
export async function LiteratureType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsLiteratureTypeEN.con_LiteratureTypeId:
return (obj: clsLiteratureTypeEN) => {
return obj.literatureTypeId === value;
}
case clsLiteratureTypeEN.con_LiteratureTypeName:
return (obj: clsLiteratureTypeEN) => {
return obj.literatureTypeName === value;
}
case clsLiteratureTypeEN.con_UpdUserId:
return (obj: clsLiteratureTypeEN) => {
return obj.updUserId === value;
}
case clsLiteratureTypeEN.con_UpdDate:
return (obj: clsLiteratureTypeEN) => {
return obj.updDate === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${ literatureType_ConstructorName}.${ strThisFuncName})`;
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
export async function LiteratureType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetFirstObjAsync(strWhereCond: string): Promise<clsLiteratureTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objLiteratureType = LiteratureType_GetObjFromJsonObj(returnObj);
return objLiteratureType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLiteratureTypeEN._CurrTabName;
clsLiteratureTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsLiteratureTypeEN._CurrTabName);
if (IsNullOrEmpty(clsLiteratureTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLiteratureTypeEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrLiteratureTypeExObjLst_Cache: Array<clsLiteratureTypeEN> = CacheHelper.Get(strKey);
const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
return arrLiteratureTypeObjLst_T;
}
try
{
const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrLiteratureTypeExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
console.log(strInfo);
return arrLiteratureTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LiteratureType_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLiteratureTypeEN._CurrTabName;
clsLiteratureTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsLiteratureTypeEN._CurrTabName);
if (IsNullOrEmpty(clsLiteratureTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLiteratureTypeEN.CacheAddiCondition);
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
const arrLiteratureTypeExObjLst_Cache: Array<clsLiteratureTypeEN> = JSON.parse(strTempObjLst);
const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
return arrLiteratureTypeObjLst_T;
}
try
{
const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrLiteratureTypeExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
console.log(strInfo);
return arrLiteratureTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LiteratureType_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsLiteratureTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrLiteratureTypeObjLst_Cache: Array<clsLiteratureTypeEN> = JSON.parse(strTempObjLst);
return arrLiteratureTypeObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function LiteratureType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsLiteratureTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsLiteratureTypeEN._CurrTabName;
clsLiteratureTypeEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsLiteratureTypeEN._CurrTabName);
if (IsNullOrEmpty(clsLiteratureTypeEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsLiteratureTypeEN.CacheAddiCondition);
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
const arrLiteratureTypeExObjLst_Cache: Array<clsLiteratureTypeEN> = JSON.parse(strTempObjLst);
const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
return arrLiteratureTypeObjLst_T;
}
try
{
const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrLiteratureTypeExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
console.log(strInfo);
return arrLiteratureTypeExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LiteratureType_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsLiteratureTypeEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrLiteratureTypeObjLst_Cache: Array<clsLiteratureTypeEN> = JSON.parse(strTempObjLst);
return arrLiteratureTypeObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LiteratureType_GetObjLst_Cache(): Promise<Array<clsLiteratureTypeEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrLiteratureTypeObjLst_Cache;
switch (clsLiteratureTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_ClientCache();
break;
default:
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_ClientCache();
break;
}
const arrLiteratureTypeObjLst = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeObjLst_Cache);
return arrLiteratureTypeObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function LiteratureType_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrLiteratureTypeObjLst_Cache;
switch (clsLiteratureTypeEN.CacheModeId)
{
case "04"://sessionStorage
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrLiteratureTypeObjLst_Cache = null;
break;
default:
arrLiteratureTypeObjLst_Cache = null;
break;
}
return arrLiteratureTypeObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrLiteratureTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond: clsLiteratureTypeEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
let arrLiteratureType_Sel: Array < clsLiteratureTypeEN > = arrLiteratureTypeObjLst_Cache;
if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "") return arrLiteratureType_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
//console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLiteratureType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLiteratureType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrLiteratureType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objLiteratureType_Cond), literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsLiteratureTypeEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrLiteratureTypeId:关键字列表
 * @returns 对象列表
 **/
export async function LiteratureType_GetObjLstByLiteratureTypeIdLstAsync(arrLiteratureTypeId: Array<string>): Promise<Array<clsLiteratureTypeEN>>  
{
const strThisFuncName = "GetObjLstByLiteratureTypeIdLstAsync";
const strAction = "GetObjLstByLiteratureTypeIdLst";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrLiteratureTypeId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param arrstrLiteratureTypeIdLst:关键字列表
 * @returns 对象列表
*/
export async function LiteratureType_GetObjLstByLiteratureTypeIdLst_Cache(arrLiteratureTypeIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByLiteratureTypeIdLst_Cache";
try
{
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
const arrLiteratureType_Sel: Array <clsLiteratureTypeEN> = arrLiteratureTypeObjLst_Cache.filter(x => arrLiteratureTypeIdLst.indexOf(x.literatureTypeId)>-1);
return arrLiteratureType_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLiteratureTypeIdLst.join(","), literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsLiteratureTypeEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function LiteratureType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsLiteratureTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsLiteratureTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
if (arrLiteratureTypeObjLst_Cache.length == 0) return arrLiteratureTypeObjLst_Cache;
let arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objLiteratureType_Cond = new clsLiteratureTypeEN();
ObjectAssign(objLiteratureType_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsLiteratureTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLiteratureType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrLiteratureType_Sel.length == 0) return arrLiteratureType_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrLiteratureType_Sel = arrLiteratureType_Sel.sort(LiteratureType_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrLiteratureType_Sel = arrLiteratureType_Sel.sort(objPagerPara.sortFun);
}
arrLiteratureType_Sel = arrLiteratureType_Sel.slice(intStart, intEnd);     
return arrLiteratureType_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsLiteratureTypeEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function LiteratureType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsLiteratureTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", literatureType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param strLiteratureTypeId:关键字
 * @returns 获取删除的结果
 **/
export async function LiteratureType_DelRecordAsync(strLiteratureTypeId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(literatureType_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strLiteratureTypeId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strLiteratureTypeId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param arrLiteratureTypeId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function LiteratureType_DelLiteratureTypesAsync(arrLiteratureTypeId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelLiteratureTypesAsync";
const strAction = "DelLiteratureTypes";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrLiteratureTypeId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_DelLiteratureTypesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelLiteratureTypesByCondAsync";
const strAction = "DelLiteratureTypesByCond";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function LiteratureType_AddNewRecordAsync(objLiteratureTypeEN: clsLiteratureTypeEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objLiteratureTypeEN.literatureTypeId === null || objLiteratureTypeEN.literatureTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objLiteratureTypeEN);
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function LiteratureType_AddNewRecordWithMaxIdAsync(objLiteratureTypeEN: clsLiteratureTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function LiteratureType_AddNewRecordWithReturnKeyAsync(objLiteratureTypeEN: clsLiteratureTypeEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function LiteratureType_AddNewRecordWithReturnKey(objLiteratureTypeEN: clsLiteratureTypeEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objLiteratureTypeEN.literatureTypeId === null || objLiteratureTypeEN.literatureTypeId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function LiteratureType_UpdateRecordAsync(objLiteratureTypeEN: clsLiteratureTypeEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objLiteratureTypeEN.sf_UpdFldSetStr === undefined || objLiteratureTypeEN.sf_UpdFldSetStr === null || objLiteratureTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLiteratureTypeEN.literatureTypeId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureTypeEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function LiteratureType_UpdateWithConditionAsync(objLiteratureTypeEN: clsLiteratureTypeEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objLiteratureTypeEN.sf_UpdFldSetStr === undefined || objLiteratureTypeEN.sf_UpdFldSetStr === null || objLiteratureTypeEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLiteratureTypeEN.literatureTypeId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
objLiteratureTypeEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objLiteratureTypeEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objstrLiteratureTypeId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function LiteratureType_IsExistRecord_Cache(objLiteratureType_Cond: clsLiteratureTypeEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
if (arrLiteratureTypeObjLst_Cache == null) return false;
let arrLiteratureType_Sel: Array < clsLiteratureTypeEN > = arrLiteratureTypeObjLst_Cache;
if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "") return arrLiteratureType_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
//console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLiteratureType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLiteratureType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrLiteratureType_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objLiteratureType_Cond), literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param strLiteratureTypeId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function LiteratureType_IsExist(strLiteratureTypeId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"LiteratureTypeId": strLiteratureTypeId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param strLiteratureTypeId:所给的关键字
 * @returns 对象
*/
export async function LiteratureType_IsExist_Cache(strLiteratureTypeId:string) {
const strThisFuncName = "IsExist_Cache";
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
if (arrLiteratureTypeObjLst_Cache == null) return false;
try
{
const arrLiteratureType_Sel: Array <clsLiteratureTypeEN> = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
if (arrLiteratureType_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strLiteratureTypeId, literatureType_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strLiteratureTypeId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function LiteratureType_IsExistAsync(strLiteratureTypeId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strLiteratureTypeId": strLiteratureTypeId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
 * @param objLiteratureType_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function LiteratureType_GetRecCountByCond_Cache(objLiteratureType_Cond: clsLiteratureTypeEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
if (arrLiteratureTypeObjLst_Cache == null) return 0;
let arrLiteratureType_Sel: Array < clsLiteratureTypeEN > = arrLiteratureTypeObjLst_Cache;
if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "") return arrLiteratureType_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
//console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objLiteratureType_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objLiteratureType_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrLiteratureType_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objLiteratureType_Cond), literatureType_ConstructorName, strThisFuncName);
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
export async function LiteratureType_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(literatureType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, literatureType_ConstructorName, strThisFuncName);
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
export function LiteratureType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function LiteratureType_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsLiteratureTypeEN._CurrTabName;
switch (clsLiteratureTypeEN.CacheModeId)
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
export function LiteratureType_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsLiteratureTypeEN._CurrTabName;
switch (clsLiteratureTypeEN.CacheModeId)
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
export async function LiteratureType__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await LiteratureType_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function LiteratureType_CheckPropertyNew(pobjLiteratureTypeEN: clsLiteratureTypeEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeId) == false && GetStrLen(pobjLiteratureTypeEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeId)(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeName) == false && GetStrLen(pobjLiteratureTypeEN.literatureTypeName) > 100)
{
 throw new Error("(errid:Watl000059)字段[作文类型名(literatureTypeName)]的长度不能超过100(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeName)(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updUserId) == false && GetStrLen(pobjLiteratureTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updUserId)(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updDate) == false && GetStrLen(pobjLiteratureTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updDate)(clsLiteratureTypeBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeId) == false && undefined !== pobjLiteratureTypeEN.literatureTypeId && tzDataType.isString(pobjLiteratureTypeEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjLiteratureTypeEN.literatureTypeId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeName) == false && undefined !== pobjLiteratureTypeEN.literatureTypeName && tzDataType.isString(pobjLiteratureTypeEN.literatureTypeName) === false)
{
 throw new Error("(errid:Watl000060)字段[作文类型名(literatureTypeName)]的值:[$(pobjLiteratureTypeEN.literatureTypeName)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updUserId) == false && undefined !== pobjLiteratureTypeEN.updUserId && tzDataType.isString(pobjLiteratureTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjLiteratureTypeEN.updUserId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updDate) == false && undefined !== pobjLiteratureTypeEN.updDate && tzDataType.isString(pobjLiteratureTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjLiteratureTypeEN.updDate)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjLiteratureTypeEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function LiteratureType_CheckProperty4Update (pobjLiteratureTypeEN: clsLiteratureTypeEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeId) == false && GetStrLen(pobjLiteratureTypeEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeId)(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeName) == false && GetStrLen(pobjLiteratureTypeEN.literatureTypeName) > 100)
{
 throw new Error("(errid:Watl000062)字段[作文类型名(literatureTypeName)]的长度不能超过100(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeName)(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updUserId) == false && GetStrLen(pobjLiteratureTypeEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updUserId)(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updDate) == false && GetStrLen(pobjLiteratureTypeEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updDate)(clsLiteratureTypeBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeId) == false && undefined !== pobjLiteratureTypeEN.literatureTypeId && tzDataType.isString(pobjLiteratureTypeEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjLiteratureTypeEN.literatureTypeId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeName) == false && undefined !== pobjLiteratureTypeEN.literatureTypeName && tzDataType.isString(pobjLiteratureTypeEN.literatureTypeName) === false)
{
 throw new Error("(errid:Watl000063)字段[作文类型名(literatureTypeName)]的值:[$(pobjLiteratureTypeEN.literatureTypeName)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updUserId) == false && undefined !== pobjLiteratureTypeEN.updUserId && tzDataType.isString(pobjLiteratureTypeEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjLiteratureTypeEN.updUserId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjLiteratureTypeEN.updDate) == false && undefined !== pobjLiteratureTypeEN.updDate && tzDataType.isString(pobjLiteratureTypeEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjLiteratureTypeEN.updDate)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjLiteratureTypeEN.literatureTypeId) === true )
{
 throw new Error("(errid:Watl000064)字段[作文类型Id]不能为空(In 文献类型)!(clsLiteratureTypeBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjLiteratureTypeEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function LiteratureType_GetJSONStrByObj (pobjLiteratureTypeEN: clsLiteratureTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjLiteratureTypeEN.sf_UpdFldSetStr = pobjLiteratureTypeEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjLiteratureTypeEN);
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
export function LiteratureType_GetObjLstByJSONStr (strJSON: string): Array<clsLiteratureTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrLiteratureTypeObjLst = new Array<clsLiteratureTypeEN>();
if (strJSON === "")
{
return arrLiteratureTypeObjLst;
}
try
{
arrLiteratureTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrLiteratureTypeObjLst;
}
return arrLiteratureTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrLiteratureTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function LiteratureType_GetObjLstByJSONObjLst (arrLiteratureTypeObjLstS: Array<clsLiteratureTypeEN>): Array<clsLiteratureTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrLiteratureTypeObjLst = new Array<clsLiteratureTypeEN>();
for (const objInFor of arrLiteratureTypeObjLstS) {
const obj1 = LiteratureType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrLiteratureTypeObjLst.push(obj1);
}
return arrLiteratureTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function LiteratureType_GetObjByJSONStr (strJSON: string): clsLiteratureTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjLiteratureTypeEN = new clsLiteratureTypeEN();
if (strJSON === "")
{
return pobjLiteratureTypeEN;
}
try
{
pobjLiteratureTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjLiteratureTypeEN;
}
return pobjLiteratureTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function LiteratureType_GetCombineCondition(objLiteratureType_Cond: clsLiteratureTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsLiteratureTypeEN.con_LiteratureTypeId, objLiteratureType_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN.con_LiteratureTypeName) == true)
{
const strComparisonOp_LiteratureTypeName:string = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN.con_LiteratureTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsLiteratureTypeEN.con_LiteratureTypeName, objLiteratureType_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
}
if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsLiteratureTypeEN.con_UpdUserId, objLiteratureType_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsLiteratureTypeEN.con_UpdDate, objLiteratureType_Cond.updDate, strComparisonOp_UpdDate);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objLiteratureTypeENS:源对象
 * @param objLiteratureTypeENT:目标对象
*/
export function LiteratureType_CopyObjTo(objLiteratureTypeENS: clsLiteratureTypeEN , objLiteratureTypeENT: clsLiteratureTypeEN ): void 
{
objLiteratureTypeENT.literatureTypeId = objLiteratureTypeENS.literatureTypeId; //作文类型Id
objLiteratureTypeENT.literatureTypeName = objLiteratureTypeENS.literatureTypeName; //作文类型名
objLiteratureTypeENT.updUserId = objLiteratureTypeENS.updUserId; //修改用户Id
objLiteratureTypeENT.updDate = objLiteratureTypeENS.updDate; //修改日期
objLiteratureTypeENT.sf_UpdFldSetStr = objLiteratureTypeENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objLiteratureTypeENS:源对象
 * @param objLiteratureTypeENT:目标对象
*/
export function LiteratureType_GetObjFromJsonObj(objLiteratureTypeENS: clsLiteratureTypeEN): clsLiteratureTypeEN 
{
 const objLiteratureTypeENT: clsLiteratureTypeEN = new clsLiteratureTypeEN();
ObjectAssign(objLiteratureTypeENT, objLiteratureTypeENS);
 return objLiteratureTypeENT;
}