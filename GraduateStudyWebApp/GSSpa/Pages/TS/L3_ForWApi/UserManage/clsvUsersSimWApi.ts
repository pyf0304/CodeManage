
 /**
 * 类名:clsvUsersSimWApi
 * 表名:vUsersSim(01120699)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:23
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * vUsersSim(vUsersSim)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvUsersSimEN } from "../../L0_Entity/UserManage/clsvUsersSimEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vUsersSim_Controller = "vUsersSimApi";
 export const vUsersSim_ConstructorName = "vUsersSim";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strUserId:关键字
 * @returns 对象
 **/
export async function vUsersSim_GetObjByUserIdAsync(strUserId: string): Promise<clsvUsersSimEN>  
{
const strThisFuncName = "GetObjByUserIdAsync";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByUserId";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strUserId": strUserId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvUsersSim = vUsersSim_GetObjFromJsonObj(returnObj);
return objvUsersSim;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function vUsersSim_GetObjByUserId_Cache(strUserId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
try
{
const arrvUsersSim_Sel: Array <clsvUsersSimEN> = arrvUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
let objvUsersSim: clsvUsersSimEN;
if (arrvUsersSim_Sel.length > 0)
{
objvUsersSim = arrvUsersSim_Sel[0];
return objvUsersSim;
}
else
{
if (bolTryAsyncOnce == true)
{
objvUsersSim = await vUsersSim_GetObjByUserIdAsync(strUserId);
if (objvUsersSim != null)
{
vUsersSim_ReFreshThisCache();
return objvUsersSim;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function vUsersSim_GetObjByUserId_localStorage(strUserId: string) {
const strThisFuncName = "GetObjByUserId_localStorage";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvUsersSimEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvUsersSim_Cache: clsvUsersSimEN = JSON.parse(strTempObj);
return objvUsersSim_Cache;
}
try
{
const objvUsersSim = await vUsersSim_GetObjByUserIdAsync(strUserId);
if (objvUsersSim != null)
{
localStorage.setItem(strKey, JSON.stringify(objvUsersSim));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvUsersSim;
}
return objvUsersSim;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function vUsersSim_GetNameByUserId_Cache(strUserId: string) {
const strThisFuncName = "GetNameByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetNameByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
if (arrvUsersSimObjLst_Cache == null) return "";
try
{
const arrvUsersSim_Sel: Array <clsvUsersSimEN> = arrvUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
let objvUsersSim: clsvUsersSimEN;
if (arrvUsersSim_Sel.length > 0)
{
objvUsersSim = arrvUsersSim_Sel[0];
return objvUsersSim.userName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strUserId);
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
export async function vUsersSim_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvUsersSimEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvUsersSimEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvUsersSimEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strUserId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvUsersSim = await vUsersSim_GetObjByUserId_Cache(strUserId );
if (objvUsersSim == null) return "";
return objvUsersSim.GetFldValue(strOutFldName).toString();
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
export function vUsersSim_SortFun_Defa(a:clsvUsersSimEN , b:clsvUsersSimEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.userId.localeCompare(b.userId);
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
export function vUsersSim_SortFun_Defa_2Fld(a:clsvUsersSimEN , b:clsvUsersSimEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userName == b.userName) return a.collegeName.localeCompare(b.collegeName);
else return a.userName.localeCompare(b.userName);
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
export function vUsersSim_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvUsersSimEN.con_UserId:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvUsersSimEN.con_UserName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvUsersSimEN.con_IsGSuser:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
if (a.isGSuser == true) return 1;
else return -1
}
case clsvUsersSimEN.con_CollegeName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvUsersSimEN.con_id_XzCollege:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvUsersSimEN.con_id_XzMajor:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvUsersSimEN.con_MajorName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvUsersSimEN.con_HeadPic:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return a.headPic.localeCompare(b.headPic);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsersSim]中不存在！(in ${ vUsersSim_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvUsersSimEN.con_UserId:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvUsersSimEN.con_UserName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvUsersSimEN.con_IsGSuser:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
if (b.isGSuser == true) return 1;
else return -1
}
case clsvUsersSimEN.con_CollegeName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvUsersSimEN.con_id_XzCollege:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvUsersSimEN.con_id_XzMajor:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvUsersSimEN.con_MajorName:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvUsersSimEN.con_HeadPic:
return (a: clsvUsersSimEN, b: clsvUsersSimEN) => {
return b.headPic.localeCompare(a.headPic);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsersSim]中不存在！(in ${ vUsersSim_ConstructorName}.${ strThisFuncName})`;
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
export async function vUsersSim_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvUsersSimEN.con_UserId:
return (obj: clsvUsersSimEN) => {
return obj.userId === value;
}
case clsvUsersSimEN.con_UserName:
return (obj: clsvUsersSimEN) => {
return obj.userName === value;
}
case clsvUsersSimEN.con_IsGSuser:
return (obj: clsvUsersSimEN) => {
return obj.isGSuser === value;
}
case clsvUsersSimEN.con_CollegeName:
return (obj: clsvUsersSimEN) => {
return obj.collegeName === value;
}
case clsvUsersSimEN.con_id_XzCollege:
return (obj: clsvUsersSimEN) => {
return obj.id_XzCollege === value;
}
case clsvUsersSimEN.con_id_XzMajor:
return (obj: clsvUsersSimEN) => {
return obj.id_XzMajor === value;
}
case clsvUsersSimEN.con_MajorName:
return (obj: clsvUsersSimEN) => {
return obj.majorName === value;
}
case clsvUsersSimEN.con_HeadPic:
return (obj: clsvUsersSimEN) => {
return obj.headPic === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsersSim]中不存在！(in ${ vUsersSim_ConstructorName}.${ strThisFuncName})`;
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
export async function vUsersSim_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetFirstObjAsync(strWhereCond: string): Promise<clsvUsersSimEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvUsersSim = vUsersSim_GetObjFromJsonObj(returnObj);
return objvUsersSim;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersSimEN._CurrTabName;
clsvUsersSimEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersSimEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersSimEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvUsersSimExObjLst_Cache: Array<clsvUsersSimEN> = CacheHelper.Get(strKey);
const arrvUsersSimObjLst_T = vUsersSim_GetObjLstByJSONObjLst(arrvUsersSimExObjLst_Cache);
return arrvUsersSimObjLst_T;
}
try
{
const arrvUsersSimExObjLst = await vUsersSim_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvUsersSimExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersSimExObjLst.length);
console.log(strInfo);
return arrvUsersSimExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsersSim_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersSimEN._CurrTabName;
clsvUsersSimEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersSimEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersSimEN.CacheAddiCondition);
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
const arrvUsersSimExObjLst_Cache: Array<clsvUsersSimEN> = JSON.parse(strTempObjLst);
const arrvUsersSimObjLst_T = vUsersSim_GetObjLstByJSONObjLst(arrvUsersSimExObjLst_Cache);
return arrvUsersSimObjLst_T;
}
try
{
const arrvUsersSimExObjLst = await vUsersSim_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvUsersSimExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersSimExObjLst.length);
console.log(strInfo);
return arrvUsersSimExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsersSim_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvUsersSimEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvUsersSimObjLst_Cache: Array<clsvUsersSimEN> = JSON.parse(strTempObjLst);
return arrvUsersSimObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vUsersSim_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvUsersSimEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersSimEN._CurrTabName;
clsvUsersSimEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersSimEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersSimEN.CacheAddiCondition);
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
const arrvUsersSimExObjLst_Cache: Array<clsvUsersSimEN> = JSON.parse(strTempObjLst);
const arrvUsersSimObjLst_T = vUsersSim_GetObjLstByJSONObjLst(arrvUsersSimExObjLst_Cache);
return arrvUsersSimObjLst_T;
}
try
{
const arrvUsersSimExObjLst = await vUsersSim_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvUsersSimExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersSimExObjLst.length);
console.log(strInfo);
return arrvUsersSimExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsersSim_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvUsersSimEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvUsersSimObjLst_Cache: Array<clsvUsersSimEN> = JSON.parse(strTempObjLst);
return arrvUsersSimObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsersSim_GetObjLst_Cache(): Promise<Array<clsvUsersSimEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvUsersSimObjLst_Cache;
switch (clsvUsersSimEN.CacheModeId)
{
case "04"://sessionStorage
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_ClientCache();
break;
default:
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_ClientCache();
break;
}
const arrvUsersSimObjLst = vUsersSim_GetObjLstByJSONObjLst(arrvUsersSimObjLst_Cache);
return arrvUsersSimObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsersSim_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvUsersSimObjLst_Cache;
switch (clsvUsersSimEN.CacheModeId)
{
case "04"://sessionStorage
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvUsersSimObjLst_Cache = null;
break;
default:
arrvUsersSimObjLst_Cache = null;
break;
}
return arrvUsersSimObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vUsersSim_GetSubObjLst_Cache(objvUsersSim_Cond: clsvUsersSimEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
let arrvUsersSim_Sel: Array < clsvUsersSimEN > = arrvUsersSimObjLst_Cache;
if (objvUsersSim_Cond.sf_FldComparisonOp == null || objvUsersSim_Cond.sf_FldComparisonOp == "") return arrvUsersSim_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsersSim_Cond.sf_FldComparisonOp);
//console.log("clsvUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsersSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsersSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvUsersSim_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvUsersSim_Cond), vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersSimEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrUserId:关键字列表
 * @returns 对象列表
 **/
export async function vUsersSim_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsvUsersSimEN>>  
{
const strThisFuncName = "GetObjLstByUserIdLstAsync";
const strAction = "GetObjLstByUserIdLst";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param arrstrUserIdLst:关键字列表
 * @returns 对象列表
*/
export async function vUsersSim_GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByUserIdLst_Cache";
try
{
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
const arrvUsersSim_Sel: Array <clsvUsersSimEN> = arrvUsersSimObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId)>-1);
return arrvUsersSim_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersSimEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vUsersSim_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvUsersSimEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvUsersSimEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
if (arrvUsersSimObjLst_Cache.length == 0) return arrvUsersSimObjLst_Cache;
let arrvUsersSim_Sel = arrvUsersSimObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvUsersSim_Cond = new clsvUsersSimEN();
ObjectAssign(objvUsersSim_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvUsersSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsersSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvUsersSim_Sel.length == 0) return arrvUsersSim_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvUsersSim_Sel = arrvUsersSim_Sel.sort(vUsersSim_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvUsersSim_Sel = arrvUsersSim_Sel.sort(objPagerPara.sortFun);
}
arrvUsersSim_Sel = arrvUsersSim_Sel.slice(intStart, intEnd);     
return arrvUsersSim_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersSimEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vUsersSim_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvUsersSimEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsersSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsersSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vUsersSim_IsExistRecord_Cache(objvUsersSim_Cond: clsvUsersSimEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
if (arrvUsersSimObjLst_Cache == null) return false;
let arrvUsersSim_Sel: Array < clsvUsersSimEN > = arrvUsersSimObjLst_Cache;
if (objvUsersSim_Cond.sf_FldComparisonOp == null || objvUsersSim_Cond.sf_FldComparisonOp == "") return arrvUsersSim_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsersSim_Cond.sf_FldComparisonOp);
//console.log("clsvUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsersSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsersSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvUsersSim_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvUsersSim_Cond), vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param strUserId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vUsersSim_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"UserId": strUserId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function vUsersSim_IsExist_Cache(strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
if (arrvUsersSimObjLst_Cache == null) return false;
try
{
const arrvUsersSim_Sel: Array <clsvUsersSimEN> = arrvUsersSimObjLst_Cache.filter(x => x.userId == strUserId);
if (arrvUsersSim_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, vUsersSim_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strUserId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vUsersSim_IsExistAsync(strUserId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strUserId": strUserId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
export async function vUsersSim_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vUsersSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsersSim_ConstructorName, strThisFuncName);
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
 * @param objvUsersSim_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vUsersSim_GetRecCountByCond_Cache(objvUsersSim_Cond: clsvUsersSimEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvUsersSimObjLst_Cache = await vUsersSim_GetObjLst_Cache();
if (arrvUsersSimObjLst_Cache == null) return 0;
let arrvUsersSim_Sel: Array < clsvUsersSimEN > = arrvUsersSimObjLst_Cache;
if (objvUsersSim_Cond.sf_FldComparisonOp == null || objvUsersSim_Cond.sf_FldComparisonOp == "") return arrvUsersSim_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsersSim_Cond.sf_FldComparisonOp);
//console.log("clsvUsersSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsersSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsersSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsersSim_Sel = arrvUsersSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvUsersSim_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvUsersSim_Cond), vUsersSim_ConstructorName, strThisFuncName);
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
export function vUsersSim_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vUsersSim_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvUsersSimEN._CurrTabName;
switch (clsvUsersSimEN.CacheModeId)
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
export async function vUsersSim__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await vUsersSim_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvUsersSimEN.con_UserId, clsvUsersSimEN.con_UserName, "vUsersSim");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vUsersSim_GetJSONStrByObj (pobjvUsersSimEN: clsvUsersSimEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvUsersSimEN);
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
export function vUsersSim_GetObjLstByJSONStr (strJSON: string): Array<clsvUsersSimEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvUsersSimObjLst = new Array<clsvUsersSimEN>();
if (strJSON === "")
{
return arrvUsersSimObjLst;
}
try
{
arrvUsersSimObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvUsersSimObjLst;
}
return arrvUsersSimObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvUsersSimObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vUsersSim_GetObjLstByJSONObjLst (arrvUsersSimObjLstS: Array<clsvUsersSimEN>): Array<clsvUsersSimEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvUsersSimObjLst = new Array<clsvUsersSimEN>();
for (const objInFor of arrvUsersSimObjLstS) {
const obj1 = vUsersSim_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvUsersSimObjLst.push(obj1);
}
return arrvUsersSimObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vUsersSim_GetObjByJSONStr (strJSON: string): clsvUsersSimEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvUsersSimEN = new clsvUsersSimEN();
if (strJSON === "")
{
return pobjvUsersSimEN;
}
try
{
pobjvUsersSimEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvUsersSimEN;
}
return pobjvUsersSimEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vUsersSim_GetCombineCondition(objvUsersSim_Cond: clsvUsersSimEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_UserId, objvUsersSim_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_UserName, objvUsersSim_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_IsGSuser) == true)
{
if (objvUsersSim_Cond.isGSuser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersSimEN.con_IsGSuser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersSimEN.con_IsGSuser);
}
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_CollegeName, objvUsersSim_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_id_XzCollege, objvUsersSim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_id_XzMajor, objvUsersSim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_MajorName, objvUsersSim_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvUsersSim_Cond.dicFldComparisonOp, clsvUsersSimEN.con_HeadPic) == true)
{
const strComparisonOp_HeadPic:string = objvUsersSim_Cond.dicFldComparisonOp[clsvUsersSimEN.con_HeadPic];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersSimEN.con_HeadPic, objvUsersSim_Cond.headPic, strComparisonOp_HeadPic);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvUsersSimENS:源对象
 * @param objvUsersSimENT:目标对象
*/
export function vUsersSim_CopyObjTo(objvUsersSimENS: clsvUsersSimEN , objvUsersSimENT: clsvUsersSimEN ): void 
{
objvUsersSimENT.userId = objvUsersSimENS.userId; //用户ID
objvUsersSimENT.userName = objvUsersSimENS.userName; //用户名
objvUsersSimENT.isGSuser = objvUsersSimENS.isGSuser; //是否GS用户
objvUsersSimENT.collegeName = objvUsersSimENS.collegeName; //学院名称
objvUsersSimENT.id_XzCollege = objvUsersSimENS.id_XzCollege; //学院流水号
objvUsersSimENT.id_XzMajor = objvUsersSimENS.id_XzMajor; //专业流水号
objvUsersSimENT.majorName = objvUsersSimENS.majorName; //专业名称
objvUsersSimENT.headPic = objvUsersSimENS.headPic; //头像
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvUsersSimENS:源对象
 * @param objvUsersSimENT:目标对象
*/
export function vUsersSim_GetObjFromJsonObj(objvUsersSimENS: clsvUsersSimEN): clsvUsersSimEN 
{
 const objvUsersSimENT: clsvUsersSimEN = new clsvUsersSimEN();
ObjectAssign(objvUsersSimENT, objvUsersSimENS);
 return objvUsersSimENT;
}