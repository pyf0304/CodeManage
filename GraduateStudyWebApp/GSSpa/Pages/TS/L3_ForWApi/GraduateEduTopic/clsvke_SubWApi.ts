
 /**
 * 类名:clsvke_SubWApi
 * 表名:vke_Sub(01120659)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:55
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 知识经济子类视图(vke_Sub)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvke_SubEN } from "../../L0_Entity/GraduateEduTopic/clsvke_SubEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vke_Sub_Controller = "vke_SubApi";
 export const vke_Sub_ConstructorName = "vke_Sub";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strke_SubId:关键字
 * @returns 对象
 **/
export async function vke_Sub_GetObjByke_SubIdAsync(strke_SubId: string): Promise<clsvke_SubEN>  
{
const strThisFuncName = "GetObjByke_SubIdAsync";

if (IsNullOrEmpty(strke_SubId) == true)
{
  const strMsg = Format("参数:[strke_SubId]不能为空！(In GetObjByke_SubIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strke_SubId.length != 4)
{
const strMsg = Format("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！", strke_SubId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByke_SubId";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strke_SubId": strke_SubId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvke_Sub = vke_Sub_GetObjFromJsonObj(returnObj);
return objvke_Sub;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param strke_SubId:所给的关键字
 * @returns 对象
*/
export async function vke_Sub_GetObjByke_SubId_Cache(strke_SubId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByke_SubId_Cache";

if (IsNullOrEmpty(strke_SubId) == true)
{
  const strMsg = Format("参数:[strke_SubId]不能为空！(In GetObjByke_SubId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strke_SubId.length != 4)
{
const strMsg = Format("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！", strke_SubId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
try
{
const arrvke_Sub_Sel: Array <clsvke_SubEN> = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
let objvke_Sub: clsvke_SubEN;
if (arrvke_Sub_Sel.length > 0)
{
objvke_Sub = arrvke_Sub_Sel[0];
return objvke_Sub;
}
else
{
if (bolTryAsyncOnce == true)
{
objvke_Sub = await vke_Sub_GetObjByke_SubIdAsync(strke_SubId);
if (objvke_Sub != null)
{
vke_Sub_ReFreshThisCache();
return objvke_Sub;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strke_SubId:所给的关键字
 * @returns 对象
*/
export async function vke_Sub_GetObjByke_SubId_localStorage(strke_SubId: string) {
const strThisFuncName = "GetObjByke_SubId_localStorage";

if (IsNullOrEmpty(strke_SubId) == true)
{
  const strMsg = Format("参数:[strke_SubId]不能为空！(In GetObjByke_SubId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strke_SubId.length != 4)
{
const strMsg = Format("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！", strke_SubId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvke_SubEN._CurrTabName, strke_SubId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvke_Sub_Cache: clsvke_SubEN = JSON.parse(strTempObj);
return objvke_Sub_Cache;
}
try
{
const objvke_Sub = await vke_Sub_GetObjByke_SubIdAsync(strke_SubId);
if (objvke_Sub != null)
{
localStorage.setItem(strKey, JSON.stringify(objvke_Sub));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvke_Sub;
}
return objvke_Sub;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strke_SubId:所给的关键字
 * @returns 对象
*/
export async function vke_Sub_GetNameByke_SubId_Cache(strke_SubId: string) {
const strThisFuncName = "GetNameByke_SubId_Cache";

if (IsNullOrEmpty(strke_SubId) == true)
{
  const strMsg = Format("参数:[strke_SubId]不能为空！(In GetNameByke_SubId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strke_SubId.length != 4)
{
const strMsg = Format("缓存分类变量:[strke_SubId]的长度:[{0}]不正确！", strke_SubId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
if (arrvke_SubObjLst_Cache == null) return "";
try
{
const arrvke_Sub_Sel: Array <clsvke_SubEN> = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
let objvke_Sub: clsvke_SubEN;
if (arrvke_Sub_Sel.length > 0)
{
objvke_Sub = arrvke_Sub_Sel[0];
return objvke_Sub.ke_SuperName_cn;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strke_SubId);
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
export async function vke_Sub_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvke_SubEN.con_ke_SubId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvke_SubEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvke_SubEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strke_SubId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvke_Sub = await vke_Sub_GetObjByke_SubId_Cache(strke_SubId );
if (objvke_Sub == null) return "";
return objvke_Sub.GetFldValue(strOutFldName).toString();
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
export function vke_Sub_SortFun_Defa(a:clsvke_SubEN , b:clsvke_SubEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.ke_SubId.localeCompare(b.ke_SubId);
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
export function vke_Sub_SortFun_Defa_2Fld(a:clsvke_SubEN , b:clsvke_SubEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.ke_SuperId == b.ke_SuperId) return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
else return a.ke_SuperId.localeCompare(b.ke_SuperId);
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
export function vke_Sub_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvke_SubEN.con_ke_SubId:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SubId.localeCompare(b.ke_SubId);
}
case clsvke_SubEN.con_ke_SuperId:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SuperId.localeCompare(b.ke_SuperId);
}
case clsvke_SubEN.con_ke_SuperName_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SuperName_cn.localeCompare(b.ke_SuperName_cn);
}
case clsvke_SubEN.con_ke_SuperName_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SuperName_en.localeCompare(b.ke_SuperName_en);
}
case clsvke_SubEN.con_ke_SubName_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SubName_cn.localeCompare(b.ke_SubName_cn);
}
case clsvke_SubEN.con_ke_SubName_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SubName_en.localeCompare(b.ke_SubName_en);
}
case clsvke_SubEN.con_ke_SuperDescribe_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SuperDescribe_cn.localeCompare(b.ke_SuperDescribe_cn);
}
case clsvke_SubEN.con_ke_SubDescribe_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SubDescribe_cn.localeCompare(b.ke_SubDescribe_cn);
}
case clsvke_SubEN.con_ke_SuperDescribe_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SuperDescribe_en.localeCompare(b.ke_SuperDescribe_en);
}
case clsvke_SubEN.con_ke_SubDescribe_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.ke_SubDescribe_en.localeCompare(b.ke_SubDescribe_en);
}
case clsvke_SubEN.con_UpdDate:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvke_SubEN.con_UpdUser:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvke_SubEN.con_Memo:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvke_SubEN.con_Link:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return a.link.localeCompare(b.link);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${ vke_Sub_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvke_SubEN.con_ke_SubId:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SubId.localeCompare(a.ke_SubId);
}
case clsvke_SubEN.con_ke_SuperId:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SuperId.localeCompare(a.ke_SuperId);
}
case clsvke_SubEN.con_ke_SuperName_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SuperName_cn.localeCompare(a.ke_SuperName_cn);
}
case clsvke_SubEN.con_ke_SuperName_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SuperName_en.localeCompare(a.ke_SuperName_en);
}
case clsvke_SubEN.con_ke_SubName_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SubName_cn.localeCompare(a.ke_SubName_cn);
}
case clsvke_SubEN.con_ke_SubName_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SubName_en.localeCompare(a.ke_SubName_en);
}
case clsvke_SubEN.con_ke_SuperDescribe_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SuperDescribe_cn.localeCompare(a.ke_SuperDescribe_cn);
}
case clsvke_SubEN.con_ke_SubDescribe_cn:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SubDescribe_cn.localeCompare(a.ke_SubDescribe_cn);
}
case clsvke_SubEN.con_ke_SuperDescribe_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SuperDescribe_en.localeCompare(a.ke_SuperDescribe_en);
}
case clsvke_SubEN.con_ke_SubDescribe_en:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.ke_SubDescribe_en.localeCompare(a.ke_SubDescribe_en);
}
case clsvke_SubEN.con_UpdDate:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvke_SubEN.con_UpdUser:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvke_SubEN.con_Memo:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvke_SubEN.con_Link:
return (a: clsvke_SubEN, b: clsvke_SubEN) => {
return b.link.localeCompare(a.link);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${ vke_Sub_ConstructorName}.${ strThisFuncName})`;
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
export async function vke_Sub_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvke_SubEN.con_ke_SubId:
return (obj: clsvke_SubEN) => {
return obj.ke_SubId === value;
}
case clsvke_SubEN.con_ke_SuperId:
return (obj: clsvke_SubEN) => {
return obj.ke_SuperId === value;
}
case clsvke_SubEN.con_ke_SuperName_cn:
return (obj: clsvke_SubEN) => {
return obj.ke_SuperName_cn === value;
}
case clsvke_SubEN.con_ke_SuperName_en:
return (obj: clsvke_SubEN) => {
return obj.ke_SuperName_en === value;
}
case clsvke_SubEN.con_ke_SubName_cn:
return (obj: clsvke_SubEN) => {
return obj.ke_SubName_cn === value;
}
case clsvke_SubEN.con_ke_SubName_en:
return (obj: clsvke_SubEN) => {
return obj.ke_SubName_en === value;
}
case clsvke_SubEN.con_ke_SuperDescribe_cn:
return (obj: clsvke_SubEN) => {
return obj.ke_SuperDescribe_cn === value;
}
case clsvke_SubEN.con_ke_SubDescribe_cn:
return (obj: clsvke_SubEN) => {
return obj.ke_SubDescribe_cn === value;
}
case clsvke_SubEN.con_ke_SuperDescribe_en:
return (obj: clsvke_SubEN) => {
return obj.ke_SuperDescribe_en === value;
}
case clsvke_SubEN.con_ke_SubDescribe_en:
return (obj: clsvke_SubEN) => {
return obj.ke_SubDescribe_en === value;
}
case clsvke_SubEN.con_UpdDate:
return (obj: clsvke_SubEN) => {
return obj.updDate === value;
}
case clsvke_SubEN.con_UpdUser:
return (obj: clsvke_SubEN) => {
return obj.updUser === value;
}
case clsvke_SubEN.con_Memo:
return (obj: clsvke_SubEN) => {
return obj.memo === value;
}
case clsvke_SubEN.con_Link:
return (obj: clsvke_SubEN) => {
return obj.link === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vke_Sub]中不存在！(in ${ vke_Sub_ConstructorName}.${ strThisFuncName})`;
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
export async function vke_Sub_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetFirstObjAsync(strWhereCond: string): Promise<clsvke_SubEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvke_Sub = vke_Sub_GetObjFromJsonObj(returnObj);
return objvke_Sub;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvke_SubEN._CurrTabName;
clsvke_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvke_SubEN._CurrTabName);
if (IsNullOrEmpty(clsvke_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvke_SubEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvke_SubExObjLst_Cache: Array<clsvke_SubEN> = CacheHelper.Get(strKey);
const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
return arrvke_SubObjLst_T;
}
try
{
const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvke_SubExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
console.log(strInfo);
return arrvke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vke_Sub_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvke_SubEN._CurrTabName;
clsvke_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvke_SubEN._CurrTabName);
if (IsNullOrEmpty(clsvke_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvke_SubEN.CacheAddiCondition);
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
const arrvke_SubExObjLst_Cache: Array<clsvke_SubEN> = JSON.parse(strTempObjLst);
const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
return arrvke_SubObjLst_T;
}
try
{
const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvke_SubExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
console.log(strInfo);
return arrvke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vke_Sub_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvke_SubEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvke_SubObjLst_Cache: Array<clsvke_SubEN> = JSON.parse(strTempObjLst);
return arrvke_SubObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vke_Sub_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvke_SubEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvke_SubEN._CurrTabName;
clsvke_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvke_SubEN._CurrTabName);
if (IsNullOrEmpty(clsvke_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvke_SubEN.CacheAddiCondition);
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
const arrvke_SubExObjLst_Cache: Array<clsvke_SubEN> = JSON.parse(strTempObjLst);
const arrvke_SubObjLst_T = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubExObjLst_Cache);
return arrvke_SubObjLst_T;
}
try
{
const arrvke_SubExObjLst = await vke_Sub_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvke_SubExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvke_SubExObjLst.length);
console.log(strInfo);
return arrvke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vke_Sub_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvke_SubEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvke_SubObjLst_Cache: Array<clsvke_SubEN> = JSON.parse(strTempObjLst);
return arrvke_SubObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vke_Sub_GetObjLst_Cache(): Promise<Array<clsvke_SubEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvke_SubObjLst_Cache;
switch (clsvke_SubEN.CacheModeId)
{
case "04"://sessionStorage
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_ClientCache();
break;
default:
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_ClientCache();
break;
}
const arrvke_SubObjLst = vke_Sub_GetObjLstByJSONObjLst(arrvke_SubObjLst_Cache);
return arrvke_SubObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vke_Sub_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvke_SubObjLst_Cache;
switch (clsvke_SubEN.CacheModeId)
{
case "04"://sessionStorage
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvke_SubObjLst_Cache = null;
break;
default:
arrvke_SubObjLst_Cache = null;
break;
}
return arrvke_SubObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrke_SubId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vke_Sub_GetSubObjLst_Cache(objvke_Sub_Cond: clsvke_SubEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
let arrvke_Sub_Sel: Array < clsvke_SubEN > = arrvke_SubObjLst_Cache;
if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "") return arrvke_Sub_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
//console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvke_Sub_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvke_Sub_Cond), vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvke_SubEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrke_SubId:关键字列表
 * @returns 对象列表
 **/
export async function vke_Sub_GetObjLstByke_SubIdLstAsync(arrke_SubId: Array<string>): Promise<Array<clsvke_SubEN>>  
{
const strThisFuncName = "GetObjLstByke_SubIdLstAsync";
const strAction = "GetObjLstByke_SubIdLst";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrke_SubId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param arrstrke_SubIdLst:关键字列表
 * @returns 对象列表
*/
export async function vke_Sub_GetObjLstByke_SubIdLst_Cache(arrke_SubIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByke_SubIdLst_Cache";
try
{
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
const arrvke_Sub_Sel: Array <clsvke_SubEN> = arrvke_SubObjLst_Cache.filter(x => arrke_SubIdLst.indexOf(x.ke_SubId)>-1);
return arrvke_Sub_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrke_SubIdLst.join(","), vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvke_SubEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vke_Sub_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvke_SubEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvke_SubEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
if (arrvke_SubObjLst_Cache.length == 0) return arrvke_SubObjLst_Cache;
let arrvke_Sub_Sel = arrvke_SubObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvke_Sub_Cond = new clsvke_SubEN();
ObjectAssign(objvke_Sub_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvke_SubWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvke_Sub_Sel.length == 0) return arrvke_Sub_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvke_Sub_Sel = arrvke_Sub_Sel.sort(vke_Sub_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvke_Sub_Sel = arrvke_Sub_Sel.sort(objPagerPara.sortFun);
}
arrvke_Sub_Sel = arrvke_Sub_Sel.slice(intStart, intEnd);     
return arrvke_Sub_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvke_SubEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vke_Sub_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvke_SubEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param objstrke_SubId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vke_Sub_IsExistRecord_Cache(objvke_Sub_Cond: clsvke_SubEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
if (arrvke_SubObjLst_Cache == null) return false;
let arrvke_Sub_Sel: Array < clsvke_SubEN > = arrvke_SubObjLst_Cache;
if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "") return arrvke_Sub_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
//console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvke_Sub_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvke_Sub_Cond), vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param strke_SubId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vke_Sub_IsExist(strke_SubId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ke_SubId": strke_SubId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param strke_SubId:所给的关键字
 * @returns 对象
*/
export async function vke_Sub_IsExist_Cache(strke_SubId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
if (arrvke_SubObjLst_Cache == null) return false;
try
{
const arrvke_Sub_Sel: Array <clsvke_SubEN> = arrvke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
if (arrvke_Sub_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strke_SubId, vke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strke_SubId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vke_Sub_IsExistAsync(strke_SubId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strke_SubId": strke_SubId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
export async function vke_Sub_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vke_Sub_ConstructorName, strThisFuncName);
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
 * @param objvke_Sub_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vke_Sub_GetRecCountByCond_Cache(objvke_Sub_Cond: clsvke_SubEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvke_SubObjLst_Cache = await vke_Sub_GetObjLst_Cache();
if (arrvke_SubObjLst_Cache == null) return 0;
let arrvke_Sub_Sel: Array < clsvke_SubEN > = arrvke_SubObjLst_Cache;
if (objvke_Sub_Cond.sf_FldComparisonOp == null || objvke_Sub_Cond.sf_FldComparisonOp == "") return arrvke_Sub_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvke_Sub_Cond.sf_FldComparisonOp);
//console.log("clsvke_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvke_Sub_Sel = arrvke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvke_Sub_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvke_Sub_Cond), vke_Sub_ConstructorName, strThisFuncName);
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
export function vke_Sub_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vke_Sub_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvke_SubEN._CurrTabName;
switch (clsvke_SubEN.CacheModeId)
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
export async function vke_Sub__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await vke_Sub_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvke_SubEN.con_ke_SuperId, clsvke_SubEN.con_ke_SuperName_cn, "知识经济子类视图");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vke_Sub_GetJSONStrByObj (pobjvke_SubEN: clsvke_SubEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvke_SubEN);
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
export function vke_Sub_GetObjLstByJSONStr (strJSON: string): Array<clsvke_SubEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvke_SubObjLst = new Array<clsvke_SubEN>();
if (strJSON === "")
{
return arrvke_SubObjLst;
}
try
{
arrvke_SubObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvke_SubObjLst;
}
return arrvke_SubObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvke_SubObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vke_Sub_GetObjLstByJSONObjLst (arrvke_SubObjLstS: Array<clsvke_SubEN>): Array<clsvke_SubEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvke_SubObjLst = new Array<clsvke_SubEN>();
for (const objInFor of arrvke_SubObjLstS) {
const obj1 = vke_Sub_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvke_SubObjLst.push(obj1);
}
return arrvke_SubObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vke_Sub_GetObjByJSONStr (strJSON: string): clsvke_SubEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvke_SubEN = new clsvke_SubEN();
if (strJSON === "")
{
return pobjvke_SubEN;
}
try
{
pobjvke_SubEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvke_SubEN;
}
return pobjvke_SubEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vke_Sub_GetCombineCondition(objvke_Sub_Cond: clsvke_SubEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SubId) == true)
{
const strComparisonOp_ke_SubId:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SubId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SubId, objvke_Sub_Cond.ke_SubId, strComparisonOp_ke_SubId);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SuperId) == true)
{
const strComparisonOp_ke_SuperId:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SuperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SuperId, objvke_Sub_Cond.ke_SuperId, strComparisonOp_ke_SuperId);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SuperName_cn) == true)
{
const strComparisonOp_ke_SuperName_cn:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SuperName_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SuperName_cn, objvke_Sub_Cond.ke_SuperName_cn, strComparisonOp_ke_SuperName_cn);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SuperName_en) == true)
{
const strComparisonOp_ke_SuperName_en:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SuperName_en];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SuperName_en, objvke_Sub_Cond.ke_SuperName_en, strComparisonOp_ke_SuperName_en);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SubName_cn) == true)
{
const strComparisonOp_ke_SubName_cn:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SubName_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SubName_cn, objvke_Sub_Cond.ke_SubName_cn, strComparisonOp_ke_SubName_cn);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SubName_en) == true)
{
const strComparisonOp_ke_SubName_en:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SubName_en];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SubName_en, objvke_Sub_Cond.ke_SubName_en, strComparisonOp_ke_SubName_en);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SuperDescribe_cn) == true)
{
const strComparisonOp_ke_SuperDescribe_cn:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SuperDescribe_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SuperDescribe_cn, objvke_Sub_Cond.ke_SuperDescribe_cn, strComparisonOp_ke_SuperDescribe_cn);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SubDescribe_cn) == true)
{
const strComparisonOp_ke_SubDescribe_cn:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SubDescribe_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SubDescribe_cn, objvke_Sub_Cond.ke_SubDescribe_cn, strComparisonOp_ke_SubDescribe_cn);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SuperDescribe_en) == true)
{
const strComparisonOp_ke_SuperDescribe_en:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SuperDescribe_en];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SuperDescribe_en, objvke_Sub_Cond.ke_SuperDescribe_en, strComparisonOp_ke_SuperDescribe_en);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_ke_SubDescribe_en) == true)
{
const strComparisonOp_ke_SubDescribe_en:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_ke_SubDescribe_en];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_ke_SubDescribe_en, objvke_Sub_Cond.ke_SubDescribe_en, strComparisonOp_ke_SubDescribe_en);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_UpdDate, objvke_Sub_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_UpdUser, objvke_Sub_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_Memo, objvke_Sub_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvke_Sub_Cond.dicFldComparisonOp, clsvke_SubEN.con_Link) == true)
{
const strComparisonOp_Link:string = objvke_Sub_Cond.dicFldComparisonOp[clsvke_SubEN.con_Link];
strWhereCond += Format(" And {0} {2} '{1}'", clsvke_SubEN.con_Link, objvke_Sub_Cond.link, strComparisonOp_Link);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvke_SubENS:源对象
 * @param objvke_SubENT:目标对象
*/
export function vke_Sub_CopyObjTo(objvke_SubENS: clsvke_SubEN , objvke_SubENT: clsvke_SubEN ): void 
{
objvke_SubENT.ke_SubId = objvke_SubENS.ke_SubId; //知识子类Id
objvke_SubENT.ke_SuperId = objvke_SubENS.ke_SuperId; //知识分类Id
objvke_SubENT.ke_SuperName_cn = objvke_SubENS.ke_SuperName_cn; //知识分类名
objvke_SubENT.ke_SuperName_en = objvke_SubENS.ke_SuperName_en; //知识分类英文名
objvke_SubENT.ke_SubName_cn = objvke_SubENS.ke_SubName_cn; //知识子类名
objvke_SubENT.ke_SubName_en = objvke_SubENS.ke_SubName_en; //知识子类英文名
objvke_SubENT.ke_SuperDescribe_cn = objvke_SubENS.ke_SuperDescribe_cn; //知识分类描述
objvke_SubENT.ke_SubDescribe_cn = objvke_SubENS.ke_SubDescribe_cn; //知识子类描述
objvke_SubENT.ke_SuperDescribe_en = objvke_SubENS.ke_SuperDescribe_en; //知识分类英文描述
objvke_SubENT.ke_SubDescribe_en = objvke_SubENS.ke_SubDescribe_en; //知识子类英文描述
objvke_SubENT.updDate = objvke_SubENS.updDate; //修改日期
objvke_SubENT.updUser = objvke_SubENS.updUser; //修改人
objvke_SubENT.memo = objvke_SubENS.memo; //备注
objvke_SubENT.link = objvke_SubENS.link; //相应链接
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvke_SubENS:源对象
 * @param objvke_SubENT:目标对象
*/
export function vke_Sub_GetObjFromJsonObj(objvke_SubENS: clsvke_SubEN): clsvke_SubEN 
{
 const objvke_SubENT: clsvke_SubEN = new clsvke_SubEN();
ObjectAssign(objvke_SubENT, objvke_SubENS);
 return objvke_SubENT;
}