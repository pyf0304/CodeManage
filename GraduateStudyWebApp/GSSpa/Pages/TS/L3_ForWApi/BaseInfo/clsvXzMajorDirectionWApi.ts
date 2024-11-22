
 /**
 * 类名:clsvXzMajorDirectionWApi
 * 表名:vXzMajorDirection(01120553)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:26
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
 * v专业方向(vXzMajorDirection)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvXzMajorDirectionEN } from "../../L0_Entity/BaseInfo/clsvXzMajorDirectionEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vXzMajorDirection_Controller = "vXzMajorDirectionApi";
 export const vXzMajorDirection_ConstructorName = "vXzMajorDirection";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strMajorDirectionId:关键字
 * @returns 对象
 **/
export async function vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId: string): Promise<clsvXzMajorDirectionEN>  
{
const strThisFuncName = "GetObjByMajorDirectionIdAsync";

if (IsNullOrEmpty(strMajorDirectionId) == true)
{
  const strMsg = Format("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strMajorDirectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByMajorDirectionId";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strMajorDirectionId": strMajorDirectionId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzMajorDirection = vXzMajorDirection_GetObjFromJsonObj(returnObj);
return objvXzMajorDirection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param strMajorDirectionId:所给的关键字
 * @returns 对象
*/
export async function vXzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByMajorDirectionId_Cache";

if (IsNullOrEmpty(strMajorDirectionId) == true)
{
  const strMsg = Format("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strMajorDirectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
try
{
const arrvXzMajorDirection_Sel: Array <clsvXzMajorDirectionEN> = arrvXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
let objvXzMajorDirection: clsvXzMajorDirectionEN;
if (arrvXzMajorDirection_Sel.length > 0)
{
objvXzMajorDirection = arrvXzMajorDirection_Sel[0];
return objvXzMajorDirection;
}
else
{
if (bolTryAsyncOnce == true)
{
objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
if (objvXzMajorDirection != null)
{
vXzMajorDirection_ReFreshThisCache();
return objvXzMajorDirection;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strMajorDirectionId:所给的关键字
 * @returns 对象
*/
export async function vXzMajorDirection_GetObjByMajorDirectionId_localStorage(strMajorDirectionId: string) {
const strThisFuncName = "GetObjByMajorDirectionId_localStorage";

if (IsNullOrEmpty(strMajorDirectionId) == true)
{
  const strMsg = Format("参数:[strMajorDirectionId]不能为空！(In GetObjByMajorDirectionId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strMajorDirectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strMajorDirectionId]的长度:[{0}]不正确！", strMajorDirectionId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvXzMajorDirectionEN._CurrTabName, strMajorDirectionId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvXzMajorDirection_Cache: clsvXzMajorDirectionEN = JSON.parse(strTempObj);
return objvXzMajorDirection_Cache;
}
try
{
const objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionIdAsync(strMajorDirectionId);
if (objvXzMajorDirection != null)
{
localStorage.setItem(strKey, JSON.stringify(objvXzMajorDirection));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvXzMajorDirection;
}
return objvXzMajorDirection;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strMajorDirectionId, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvXzMajorDirectionEN.con_MajorDirectionId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvXzMajorDirectionEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvXzMajorDirectionEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strMajorDirectionId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvXzMajorDirection = await vXzMajorDirection_GetObjByMajorDirectionId_Cache(strMajorDirectionId );
if (objvXzMajorDirection == null) return "";
return objvXzMajorDirection.GetFldValue(strOutFldName).toString();
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
export function vXzMajorDirection_SortFun_Defa(a:clsvXzMajorDirectionEN , b:clsvXzMajorDirectionEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.majorDirectionId.localeCompare(b.majorDirectionId);
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
export function vXzMajorDirection_SortFun_Defa_2Fld(a:clsvXzMajorDirectionEN , b:clsvXzMajorDirectionEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.id_XzMajor == b.id_XzMajor) return a.majorID.localeCompare(b.majorID);
else return a.id_XzMajor.localeCompare(b.id_XzMajor);
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
export function vXzMajorDirection_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvXzMajorDirectionEN.con_MajorDirectionId:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorDirectionId.localeCompare(b.majorDirectionId);
}
case clsvXzMajorDirectionEN.con_id_XzMajor:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvXzMajorDirectionEN.con_MajorID:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvXzMajorDirectionEN.con_MajorName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorDirectionName.localeCompare(b.majorDirectionName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionENName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorDirectionENName.localeCompare(b.majorDirectionENName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionExplain:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.majorDirectionExplain.localeCompare(b.majorDirectionExplain);
}
case clsvXzMajorDirectionEN.con_IsVisible:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsvXzMajorDirectionEN.con_UpdDate:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvXzMajorDirectionEN.con_UpdUser:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvXzMajorDirectionEN.con_Memo:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${ vXzMajorDirection_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvXzMajorDirectionEN.con_MajorDirectionId:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorDirectionId.localeCompare(a.majorDirectionId);
}
case clsvXzMajorDirectionEN.con_id_XzMajor:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvXzMajorDirectionEN.con_MajorID:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvXzMajorDirectionEN.con_MajorName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorDirectionName.localeCompare(a.majorDirectionName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionENName:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorDirectionENName.localeCompare(a.majorDirectionENName);
}
case clsvXzMajorDirectionEN.con_MajorDirectionExplain:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.majorDirectionExplain.localeCompare(a.majorDirectionExplain);
}
case clsvXzMajorDirectionEN.con_IsVisible:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsvXzMajorDirectionEN.con_UpdDate:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvXzMajorDirectionEN.con_UpdUser:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvXzMajorDirectionEN.con_Memo:
return (a: clsvXzMajorDirectionEN, b: clsvXzMajorDirectionEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${ vXzMajorDirection_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzMajorDirection_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvXzMajorDirectionEN.con_MajorDirectionId:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorDirectionId === value;
}
case clsvXzMajorDirectionEN.con_id_XzMajor:
return (obj: clsvXzMajorDirectionEN) => {
return obj.id_XzMajor === value;
}
case clsvXzMajorDirectionEN.con_MajorID:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorID === value;
}
case clsvXzMajorDirectionEN.con_MajorName:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorName === value;
}
case clsvXzMajorDirectionEN.con_MajorDirectionName:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorDirectionName === value;
}
case clsvXzMajorDirectionEN.con_MajorDirectionENName:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorDirectionENName === value;
}
case clsvXzMajorDirectionEN.con_MajorDirectionExplain:
return (obj: clsvXzMajorDirectionEN) => {
return obj.majorDirectionExplain === value;
}
case clsvXzMajorDirectionEN.con_IsVisible:
return (obj: clsvXzMajorDirectionEN) => {
return obj.isVisible === value;
}
case clsvXzMajorDirectionEN.con_UpdDate:
return (obj: clsvXzMajorDirectionEN) => {
return obj.updDate === value;
}
case clsvXzMajorDirectionEN.con_UpdUser:
return (obj: clsvXzMajorDirectionEN) => {
return obj.updUser === value;
}
case clsvXzMajorDirectionEN.con_Memo:
return (obj: clsvXzMajorDirectionEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzMajorDirection]中不存在！(in ${ vXzMajorDirection_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzMajorDirection_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetFirstObjAsync(strWhereCond: string): Promise<clsvXzMajorDirectionEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzMajorDirection = vXzMajorDirection_GetObjFromJsonObj(returnObj);
return objvXzMajorDirection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorDirectionEN._CurrTabName;
clsvXzMajorDirectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorDirectionEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorDirectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorDirectionEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvXzMajorDirectionExObjLst_Cache: Array<clsvXzMajorDirectionEN> = CacheHelper.Get(strKey);
const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
return arrvXzMajorDirectionObjLst_T;
}
try
{
const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvXzMajorDirectionExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
console.log(strInfo);
return arrvXzMajorDirectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajorDirection_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorDirectionEN._CurrTabName;
clsvXzMajorDirectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorDirectionEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorDirectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorDirectionEN.CacheAddiCondition);
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
const arrvXzMajorDirectionExObjLst_Cache: Array<clsvXzMajorDirectionEN> = JSON.parse(strTempObjLst);
const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
return arrvXzMajorDirectionObjLst_T;
}
try
{
const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvXzMajorDirectionExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
console.log(strInfo);
return arrvXzMajorDirectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajorDirection_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvXzMajorDirectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvXzMajorDirectionObjLst_Cache: Array<clsvXzMajorDirectionEN> = JSON.parse(strTempObjLst);
return arrvXzMajorDirectionObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vXzMajorDirection_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvXzMajorDirectionEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvXzMajorDirectionEN._CurrTabName;
clsvXzMajorDirectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvXzMajorDirectionEN._CurrTabName);
if (IsNullOrEmpty(clsvXzMajorDirectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvXzMajorDirectionEN.CacheAddiCondition);
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
const arrvXzMajorDirectionExObjLst_Cache: Array<clsvXzMajorDirectionEN> = JSON.parse(strTempObjLst);
const arrvXzMajorDirectionObjLst_T = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionExObjLst_Cache);
return arrvXzMajorDirectionObjLst_T;
}
try
{
const arrvXzMajorDirectionExObjLst = await vXzMajorDirection_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvXzMajorDirectionExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvXzMajorDirectionExObjLst.length);
console.log(strInfo);
return arrvXzMajorDirectionExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajorDirection_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvXzMajorDirectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvXzMajorDirectionObjLst_Cache: Array<clsvXzMajorDirectionEN> = JSON.parse(strTempObjLst);
return arrvXzMajorDirectionObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajorDirection_GetObjLst_Cache(): Promise<Array<clsvXzMajorDirectionEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvXzMajorDirectionObjLst_Cache;
switch (clsvXzMajorDirectionEN.CacheModeId)
{
case "04"://sessionStorage
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_ClientCache();
break;
default:
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_ClientCache();
break;
}
const arrvXzMajorDirectionObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(arrvXzMajorDirectionObjLst_Cache);
return arrvXzMajorDirectionObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vXzMajorDirection_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvXzMajorDirectionObjLst_Cache;
switch (clsvXzMajorDirectionEN.CacheModeId)
{
case "04"://sessionStorage
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvXzMajorDirectionObjLst_Cache = null;
break;
default:
arrvXzMajorDirectionObjLst_Cache = null;
break;
}
return arrvXzMajorDirectionObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrMajorDirectionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vXzMajorDirection_GetSubObjLst_Cache(objvXzMajorDirection_Cond: clsvXzMajorDirectionEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
let arrvXzMajorDirection_Sel: Array < clsvXzMajorDirectionEN > = arrvXzMajorDirectionObjLst_Cache;
if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "") return arrvXzMajorDirection_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajorDirection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvXzMajorDirection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvXzMajorDirection_Cond), vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorDirectionEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrMajorDirectionId:关键字列表
 * @returns 对象列表
 **/
export async function vXzMajorDirection_GetObjLstByMajorDirectionIdLstAsync(arrMajorDirectionId: Array<string>): Promise<Array<clsvXzMajorDirectionEN>>  
{
const strThisFuncName = "GetObjLstByMajorDirectionIdLstAsync";
const strAction = "GetObjLstByMajorDirectionIdLst";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrMajorDirectionId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param arrstrMajorDirectionIdLst:关键字列表
 * @returns 对象列表
*/
export async function vXzMajorDirection_GetObjLstByMajorDirectionIdLst_Cache(arrMajorDirectionIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByMajorDirectionIdLst_Cache";
try
{
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
const arrvXzMajorDirection_Sel: Array <clsvXzMajorDirectionEN> = arrvXzMajorDirectionObjLst_Cache.filter(x => arrMajorDirectionIdLst.indexOf(x.majorDirectionId)>-1);
return arrvXzMajorDirection_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrMajorDirectionIdLst.join(","), vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorDirectionEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vXzMajorDirection_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvXzMajorDirectionEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvXzMajorDirectionEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
if (arrvXzMajorDirectionObjLst_Cache.length == 0) return arrvXzMajorDirectionObjLst_Cache;
let arrvXzMajorDirection_Sel = arrvXzMajorDirectionObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvXzMajorDirection_Cond = new clsvXzMajorDirectionEN();
ObjectAssign(objvXzMajorDirection_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvXzMajorDirectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvXzMajorDirection_Sel.length == 0) return arrvXzMajorDirection_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.sort(vXzMajorDirection_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.sort(objPagerPara.sortFun);
}
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.slice(intStart, intEnd);     
return arrvXzMajorDirection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvXzMajorDirectionEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vXzMajorDirection_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvXzMajorDirectionEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzMajorDirection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param objstrMajorDirectionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vXzMajorDirection_IsExistRecord_Cache(objvXzMajorDirection_Cond: clsvXzMajorDirectionEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
if (arrvXzMajorDirectionObjLst_Cache == null) return false;
let arrvXzMajorDirection_Sel: Array < clsvXzMajorDirectionEN > = arrvXzMajorDirectionObjLst_Cache;
if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "") return arrvXzMajorDirection_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajorDirection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvXzMajorDirection_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvXzMajorDirection_Cond), vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param strMajorDirectionId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vXzMajorDirection_IsExist(strMajorDirectionId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"MajorDirectionId": strMajorDirectionId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param strMajorDirectionId:所给的关键字
 * @returns 对象
*/
export async function vXzMajorDirection_IsExist_Cache(strMajorDirectionId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
if (arrvXzMajorDirectionObjLst_Cache == null) return false;
try
{
const arrvXzMajorDirection_Sel: Array <clsvXzMajorDirectionEN> = arrvXzMajorDirectionObjLst_Cache.filter(x => x.majorDirectionId == strMajorDirectionId);
if (arrvXzMajorDirection_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strMajorDirectionId, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strMajorDirectionId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vXzMajorDirection_IsExistAsync(strMajorDirectionId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strMajorDirectionId": strMajorDirectionId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
export async function vXzMajorDirection_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vXzMajorDirection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzMajorDirection_ConstructorName, strThisFuncName);
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
 * @param objvXzMajorDirection_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vXzMajorDirection_GetRecCountByCond_Cache(objvXzMajorDirection_Cond: clsvXzMajorDirectionEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvXzMajorDirectionObjLst_Cache = await vXzMajorDirection_GetObjLst_Cache();
if (arrvXzMajorDirectionObjLst_Cache == null) return 0;
let arrvXzMajorDirection_Sel: Array < clsvXzMajorDirectionEN > = arrvXzMajorDirectionObjLst_Cache;
if (objvXzMajorDirection_Cond.sf_FldComparisonOp == null || objvXzMajorDirection_Cond.sf_FldComparisonOp == "") return arrvXzMajorDirection_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvXzMajorDirection_Cond.sf_FldComparisonOp);
//console.log("clsvXzMajorDirectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvXzMajorDirection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvXzMajorDirection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvXzMajorDirection_Sel = arrvXzMajorDirection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvXzMajorDirection_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvXzMajorDirection_Cond), vXzMajorDirection_ConstructorName, strThisFuncName);
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
export function vXzMajorDirection_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vXzMajorDirection_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvXzMajorDirectionEN._CurrTabName;
switch (clsvXzMajorDirectionEN.CacheModeId)
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
export function vXzMajorDirection_GetJSONStrByObj (pobjvXzMajorDirectionEN: clsvXzMajorDirectionEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvXzMajorDirectionEN);
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
export function vXzMajorDirection_GetObjLstByJSONStr (strJSON: string): Array<clsvXzMajorDirectionEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvXzMajorDirectionObjLst = new Array<clsvXzMajorDirectionEN>();
if (strJSON === "")
{
return arrvXzMajorDirectionObjLst;
}
try
{
arrvXzMajorDirectionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvXzMajorDirectionObjLst;
}
return arrvXzMajorDirectionObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvXzMajorDirectionObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vXzMajorDirection_GetObjLstByJSONObjLst (arrvXzMajorDirectionObjLstS: Array<clsvXzMajorDirectionEN>): Array<clsvXzMajorDirectionEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvXzMajorDirectionObjLst = new Array<clsvXzMajorDirectionEN>();
for (const objInFor of arrvXzMajorDirectionObjLstS) {
const obj1 = vXzMajorDirection_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvXzMajorDirectionObjLst.push(obj1);
}
return arrvXzMajorDirectionObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzMajorDirection_GetObjByJSONStr (strJSON: string): clsvXzMajorDirectionEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
if (strJSON === "")
{
return pobjvXzMajorDirectionEN;
}
try
{
pobjvXzMajorDirectionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvXzMajorDirectionEN;
}
return pobjvXzMajorDirectionEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vXzMajorDirection_GetCombineCondition(objvXzMajorDirection_Cond: clsvXzMajorDirectionEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorDirectionId) == true)
{
const strComparisonOp_MajorDirectionId:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorDirectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorDirectionId, objvXzMajorDirection_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_id_XzMajor, objvXzMajorDirection_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorID, objvXzMajorDirection_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorName, objvXzMajorDirection_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorDirectionName) == true)
{
const strComparisonOp_MajorDirectionName:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorDirectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorDirectionName, objvXzMajorDirection_Cond.majorDirectionName, strComparisonOp_MajorDirectionName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorDirectionENName) == true)
{
const strComparisonOp_MajorDirectionENName:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorDirectionENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorDirectionENName, objvXzMajorDirection_Cond.majorDirectionENName, strComparisonOp_MajorDirectionENName);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_MajorDirectionExplain) == true)
{
const strComparisonOp_MajorDirectionExplain:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_MajorDirectionExplain];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_MajorDirectionExplain, objvXzMajorDirection_Cond.majorDirectionExplain, strComparisonOp_MajorDirectionExplain);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_IsVisible) == true)
{
if (objvXzMajorDirection_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzMajorDirectionEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzMajorDirectionEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_UpdDate, objvXzMajorDirection_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_UpdUser, objvXzMajorDirection_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvXzMajorDirection_Cond.dicFldComparisonOp, clsvXzMajorDirectionEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvXzMajorDirection_Cond.dicFldComparisonOp[clsvXzMajorDirectionEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzMajorDirectionEN.con_Memo, objvXzMajorDirection_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvXzMajorDirectionENS:源对象
 * @param objvXzMajorDirectionENT:目标对象
*/
export function vXzMajorDirection_CopyObjTo(objvXzMajorDirectionENS: clsvXzMajorDirectionEN , objvXzMajorDirectionENT: clsvXzMajorDirectionEN ): void 
{
objvXzMajorDirectionENT.majorDirectionId = objvXzMajorDirectionENS.majorDirectionId; //研究方向Id
objvXzMajorDirectionENT.id_XzMajor = objvXzMajorDirectionENS.id_XzMajor; //专业流水号
objvXzMajorDirectionENT.majorID = objvXzMajorDirectionENS.majorID; //专业ID
objvXzMajorDirectionENT.majorName = objvXzMajorDirectionENS.majorName; //专业名称
objvXzMajorDirectionENT.majorDirectionName = objvXzMajorDirectionENS.majorDirectionName; //研究方向名
objvXzMajorDirectionENT.majorDirectionENName = objvXzMajorDirectionENS.majorDirectionENName; //研究方向英文名
objvXzMajorDirectionENT.majorDirectionExplain = objvXzMajorDirectionENS.majorDirectionExplain; //专业方向说明
objvXzMajorDirectionENT.isVisible = objvXzMajorDirectionENS.isVisible; //是否显示
objvXzMajorDirectionENT.updDate = objvXzMajorDirectionENS.updDate; //修改日期
objvXzMajorDirectionENT.updUser = objvXzMajorDirectionENS.updUser; //修改人
objvXzMajorDirectionENT.memo = objvXzMajorDirectionENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvXzMajorDirectionENS:源对象
 * @param objvXzMajorDirectionENT:目标对象
*/
export function vXzMajorDirection_GetObjFromJsonObj(objvXzMajorDirectionENS: clsvXzMajorDirectionEN): clsvXzMajorDirectionEN 
{
 const objvXzMajorDirectionENT: clsvXzMajorDirectionEN = new clsvXzMajorDirectionEN();
ObjectAssign(objvXzMajorDirectionENT, objvXzMajorDirectionENS);
 return objvXzMajorDirectionENT;
}