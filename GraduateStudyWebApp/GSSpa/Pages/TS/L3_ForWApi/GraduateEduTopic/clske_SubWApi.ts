
 /**
 * 类名:clske_SubWApi
 * 表名:ke_Sub(01120660)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:56
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
 * 知识经济子类(ke_Sub)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clske_SubEN } from "../../L0_Entity/GraduateEduTopic/clske_SubEN.js";
import { vke_Sub_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvke_SubWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const ke_Sub_Controller = "ke_SubApi";
 export const ke_Sub_ConstructorName = "ke_Sub";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strke_SubId:关键字
 * @returns 对象
 **/
export async function ke_Sub_GetObjByke_SubIdAsync(strke_SubId: string): Promise<clske_SubEN>  
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
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objke_Sub = ke_Sub_GetObjFromJsonObj(returnObj);
return objke_Sub;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjByke_SubId_Cache(strke_SubId: string, bolTryAsyncOnce: boolean = true) {
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
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
try
{
const arrke_Sub_Sel: Array <clske_SubEN> = arrke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
let objke_Sub: clske_SubEN;
if (arrke_Sub_Sel.length > 0)
{
objke_Sub = arrke_Sub_Sel[0];
return objke_Sub;
}
else
{
if (bolTryAsyncOnce == true)
{
objke_Sub = await ke_Sub_GetObjByke_SubIdAsync(strke_SubId);
if (objke_Sub != null)
{
ke_Sub_ReFreshThisCache();
return objke_Sub;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjByke_SubId_localStorage(strke_SubId: string) {
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
const strKey = Format("{0}_{1}", clske_SubEN._CurrTabName, strke_SubId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objke_Sub_Cache: clske_SubEN = JSON.parse(strTempObj);
return objke_Sub_Cache;
}
try
{
const objke_Sub = await ke_Sub_GetObjByke_SubIdAsync(strke_SubId);
if (objke_Sub != null)
{
localStorage.setItem(strKey, JSON.stringify(objke_Sub));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objke_Sub;
}
return objke_Sub;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strke_SubId, ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objke_Sub:所给的对象
 * @returns 对象
*/
export async function ke_Sub_UpdateObjInLst_Cache(objke_Sub: clske_SubEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
const obj = arrke_SubObjLst_Cache.find(x => 
x.ke_SubId == objke_Sub.ke_SubId);
if (obj != null)
{
objke_Sub.ke_SubId = obj.ke_SubId;
ObjectAssign( obj, objke_Sub);
}
else
{
arrke_SubObjLst_Cache.push(objke_Sub);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, ke_Sub_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function ke_Sub_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clske_SubEN.con_ke_SubId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clske_SubEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clske_SubEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strke_SubId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objke_Sub = await ke_Sub_GetObjByke_SubId_Cache(strke_SubId );
if (objke_Sub == null) return "";
return objke_Sub.GetFldValue(strOutFldName).toString();
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
export function ke_Sub_SortFun_Defa(a:clske_SubEN , b:clske_SubEN): number 
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
export function ke_Sub_SortFun_Defa_2Fld(a:clske_SubEN , b:clske_SubEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.ke_SuperId == b.ke_SuperId) return a.ke_SubName_cn.localeCompare(b.ke_SubName_cn);
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
export function ke_Sub_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clske_SubEN.con_ke_SubId:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SubId.localeCompare(b.ke_SubId);
}
case clske_SubEN.con_ke_SuperId:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SuperId.localeCompare(b.ke_SuperId);
}
case clske_SubEN.con_ke_SubName_cn:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SubName_cn.localeCompare(b.ke_SubName_cn);
}
case clske_SubEN.con_ke_SubName_en:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SubName_en.localeCompare(b.ke_SubName_en);
}
case clske_SubEN.con_ke_SubDescribe_cn:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SubDescribe_cn.localeCompare(b.ke_SubDescribe_cn);
}
case clske_SubEN.con_ke_SubDescribe_en:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.ke_SubDescribe_en.localeCompare(b.ke_SubDescribe_en);
}
case clske_SubEN.con_UpdDate:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clske_SubEN.con_UpdUser:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clske_SubEN.con_Memo:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.memo.localeCompare(b.memo);
}
case clske_SubEN.con_Link:
return (a: clske_SubEN, b: clske_SubEN) => {
return a.link.localeCompare(b.link);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ke_Sub]中不存在！(in ${ ke_Sub_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clske_SubEN.con_ke_SubId:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SubId.localeCompare(a.ke_SubId);
}
case clske_SubEN.con_ke_SuperId:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SuperId.localeCompare(a.ke_SuperId);
}
case clske_SubEN.con_ke_SubName_cn:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SubName_cn.localeCompare(a.ke_SubName_cn);
}
case clske_SubEN.con_ke_SubName_en:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SubName_en.localeCompare(a.ke_SubName_en);
}
case clske_SubEN.con_ke_SubDescribe_cn:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SubDescribe_cn.localeCompare(a.ke_SubDescribe_cn);
}
case clske_SubEN.con_ke_SubDescribe_en:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.ke_SubDescribe_en.localeCompare(a.ke_SubDescribe_en);
}
case clske_SubEN.con_UpdDate:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clske_SubEN.con_UpdUser:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clske_SubEN.con_Memo:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.memo.localeCompare(a.memo);
}
case clske_SubEN.con_Link:
return (a: clske_SubEN, b: clske_SubEN) => {
return b.link.localeCompare(a.link);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ke_Sub]中不存在！(in ${ ke_Sub_ConstructorName}.${ strThisFuncName})`;
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
export async function ke_Sub_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clske_SubEN.con_ke_SubId:
return (obj: clske_SubEN) => {
return obj.ke_SubId === value;
}
case clske_SubEN.con_ke_SuperId:
return (obj: clske_SubEN) => {
return obj.ke_SuperId === value;
}
case clske_SubEN.con_ke_SubName_cn:
return (obj: clske_SubEN) => {
return obj.ke_SubName_cn === value;
}
case clske_SubEN.con_ke_SubName_en:
return (obj: clske_SubEN) => {
return obj.ke_SubName_en === value;
}
case clske_SubEN.con_ke_SubDescribe_cn:
return (obj: clske_SubEN) => {
return obj.ke_SubDescribe_cn === value;
}
case clske_SubEN.con_ke_SubDescribe_en:
return (obj: clske_SubEN) => {
return obj.ke_SubDescribe_en === value;
}
case clske_SubEN.con_UpdDate:
return (obj: clske_SubEN) => {
return obj.updDate === value;
}
case clske_SubEN.con_UpdUser:
return (obj: clske_SubEN) => {
return obj.updUser === value;
}
case clske_SubEN.con_Memo:
return (obj: clske_SubEN) => {
return obj.memo === value;
}
case clske_SubEN.con_Link:
return (obj: clske_SubEN) => {
return obj.link === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ke_Sub]中不存在！(in ${ ke_Sub_ConstructorName}.${ strThisFuncName})`;
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
export async function ke_Sub_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetFirstObjAsync(strWhereCond: string): Promise<clske_SubEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objke_Sub = ke_Sub_GetObjFromJsonObj(returnObj);
return objke_Sub;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clske_SubEN._CurrTabName;
clske_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clske_SubEN._CurrTabName);
if (IsNullOrEmpty(clske_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clske_SubEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrke_SubExObjLst_Cache: Array<clske_SubEN> = CacheHelper.Get(strKey);
const arrke_SubObjLst_T = ke_Sub_GetObjLstByJSONObjLst(arrke_SubExObjLst_Cache);
return arrke_SubObjLst_T;
}
try
{
const arrke_SubExObjLst = await ke_Sub_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrke_SubExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SubExObjLst.length);
console.log(strInfo);
return arrke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ke_Sub_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clske_SubEN._CurrTabName;
clske_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clske_SubEN._CurrTabName);
if (IsNullOrEmpty(clske_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clske_SubEN.CacheAddiCondition);
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
const arrke_SubExObjLst_Cache: Array<clske_SubEN> = JSON.parse(strTempObjLst);
const arrke_SubObjLst_T = ke_Sub_GetObjLstByJSONObjLst(arrke_SubExObjLst_Cache);
return arrke_SubObjLst_T;
}
try
{
const arrke_SubExObjLst = await ke_Sub_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrke_SubExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SubExObjLst.length);
console.log(strInfo);
return arrke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ke_Sub_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clske_SubEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrke_SubObjLst_Cache: Array<clske_SubEN> = JSON.parse(strTempObjLst);
return arrke_SubObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function ke_Sub_GetObjLstAsync(strWhereCond: string): Promise<Array<clske_SubEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clske_SubEN._CurrTabName;
clske_SubEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clske_SubEN._CurrTabName);
if (IsNullOrEmpty(clske_SubEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clske_SubEN.CacheAddiCondition);
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
const arrke_SubExObjLst_Cache: Array<clske_SubEN> = JSON.parse(strTempObjLst);
const arrke_SubObjLst_T = ke_Sub_GetObjLstByJSONObjLst(arrke_SubExObjLst_Cache);
return arrke_SubObjLst_T;
}
try
{
const arrke_SubExObjLst = await ke_Sub_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrke_SubExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrke_SubExObjLst.length);
console.log(strInfo);
return arrke_SubExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ke_Sub_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clske_SubEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrke_SubObjLst_Cache: Array<clske_SubEN> = JSON.parse(strTempObjLst);
return arrke_SubObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ke_Sub_GetObjLst_Cache(): Promise<Array<clske_SubEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrke_SubObjLst_Cache;
switch (clske_SubEN.CacheModeId)
{
case "04"://sessionStorage
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_ClientCache();
break;
default:
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_ClientCache();
break;
}
const arrke_SubObjLst = ke_Sub_GetObjLstByJSONObjLst(arrke_SubObjLst_Cache);
return arrke_SubObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ke_Sub_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrke_SubObjLst_Cache;
switch (clske_SubEN.CacheModeId)
{
case "04"://sessionStorage
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrke_SubObjLst_Cache = null;
break;
default:
arrke_SubObjLst_Cache = null;
break;
}
return arrke_SubObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrke_SubId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ke_Sub_GetSubObjLst_Cache(objke_Sub_Cond: clske_SubEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
let arrke_Sub_Sel: Array < clske_SubEN > = arrke_SubObjLst_Cache;
if (objke_Sub_Cond.sf_FldComparisonOp == null || objke_Sub_Cond.sf_FldComparisonOp == "") return arrke_Sub_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objke_Sub_Cond.sf_FldComparisonOp);
//console.log("clske_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrke_Sub_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objke_Sub_Cond), ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clske_SubEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrke_SubId:关键字列表
 * @returns 对象列表
 **/
export async function ke_Sub_GetObjLstByke_SubIdLstAsync(arrke_SubId: Array<string>): Promise<Array<clske_SubEN>>  
{
const strThisFuncName = "GetObjLstByke_SubIdLstAsync";
const strAction = "GetObjLstByke_SubIdLst";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrke_SubId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLstByke_SubIdLst_Cache(arrke_SubIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByke_SubIdLst_Cache";
try
{
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
const arrke_Sub_Sel: Array <clske_SubEN> = arrke_SubObjLst_Cache.filter(x => arrke_SubIdLst.indexOf(x.ke_SubId)>-1);
return arrke_Sub_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrke_SubIdLst.join(","), ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clske_SubEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function ke_Sub_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clske_SubEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clske_SubEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
if (arrke_SubObjLst_Cache.length == 0) return arrke_SubObjLst_Cache;
let arrke_Sub_Sel = arrke_SubObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objke_Sub_Cond = new clske_SubEN();
ObjectAssign(objke_Sub_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clske_SubWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrke_Sub_Sel.length == 0) return arrke_Sub_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrke_Sub_Sel = arrke_Sub_Sel.sort(ke_Sub_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrke_Sub_Sel = arrke_Sub_Sel.sort(objPagerPara.sortFun);
}
arrke_Sub_Sel = arrke_Sub_Sel.slice(intStart, intEnd);     
return arrke_Sub_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, ke_Sub_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clske_SubEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function ke_Sub_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clske_SubEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", ke_Sub_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ke_Sub_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param strke_SubId:关键字
 * @returns 获取删除的结果
 **/
export async function ke_Sub_DelRecordAsync(strke_SubId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strke_SubId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strke_SubId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param arrke_SubId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ke_Sub_Delke_SubsAsync(arrke_SubId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delke_SubsAsync";
const strAction = "Delke_Subs";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrke_SubId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_Delke_SubsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delke_SubsByCondAsync";
const strAction = "Delke_SubsByCond";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ke_Sub_AddNewRecordAsync(objke_SubEN: clske_SubEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objke_SubEN.ke_SubId === null || objke_SubEN.ke_SubId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objke_SubEN);
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ke_Sub_AddNewRecordWithMaxIdAsync(objke_SubEN: clske_SubEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ke_Sub_AddNewRecordWithReturnKeyAsync(objke_SubEN: clske_SubEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ke_Sub_AddNewRecordWithReturnKey(objke_SubEN: clske_SubEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objke_SubEN.ke_SubId === null || objke_SubEN.ke_SubId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ke_Sub_UpdateRecordAsync(objke_SubEN: clske_SubEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objke_SubEN.sf_UpdFldSetStr === undefined || objke_SubEN.sf_UpdFldSetStr === null || objke_SubEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objke_SubEN.ke_SubId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_SubEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ke_Sub_UpdateWithConditionAsync(objke_SubEN: clske_SubEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objke_SubEN.sf_UpdFldSetStr === undefined || objke_SubEN.sf_UpdFldSetStr === null || objke_SubEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objke_SubEN.ke_SubId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
objke_SubEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objke_SubEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_IsExistRecord_Cache(objke_Sub_Cond: clske_SubEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
if (arrke_SubObjLst_Cache == null) return false;
let arrke_Sub_Sel: Array < clske_SubEN > = arrke_SubObjLst_Cache;
if (objke_Sub_Cond.sf_FldComparisonOp == null || objke_Sub_Cond.sf_FldComparisonOp == "") return arrke_Sub_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objke_Sub_Cond.sf_FldComparisonOp);
//console.log("clske_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrke_Sub_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objke_Sub_Cond), ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_IsExist(strke_SubId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_IsExist_Cache(strke_SubId:string) {
const strThisFuncName = "IsExist_Cache";
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
if (arrke_SubObjLst_Cache == null) return false;
try
{
const arrke_Sub_Sel: Array <clske_SubEN> = arrke_SubObjLst_Cache.filter(x => x.ke_SubId == strke_SubId);
if (arrke_Sub_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strke_SubId, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_IsExistAsync(strke_SubId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
 * @param objke_Sub_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function ke_Sub_GetRecCountByCond_Cache(objke_Sub_Cond: clske_SubEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrke_SubObjLst_Cache = await ke_Sub_GetObjLst_Cache();
if (arrke_SubObjLst_Cache == null) return 0;
let arrke_Sub_Sel: Array < clske_SubEN > = arrke_SubObjLst_Cache;
if (objke_Sub_Cond.sf_FldComparisonOp == null || objke_Sub_Cond.sf_FldComparisonOp == "") return arrke_Sub_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objke_Sub_Cond.sf_FldComparisonOp);
//console.log("clske_SubWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objke_Sub_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objke_Sub_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrke_Sub_Sel = arrke_Sub_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrke_Sub_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objke_Sub_Cond), ke_Sub_ConstructorName, strThisFuncName);
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
export async function ke_Sub_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(ke_Sub_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, ke_Sub_ConstructorName, strThisFuncName);
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
export function ke_Sub_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ke_Sub_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clske_SubEN._CurrTabName;
switch (clske_SubEN.CacheModeId)
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
vke_Sub_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function ke_Sub_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clske_SubEN._CurrTabName;
switch (clske_SubEN.CacheModeId)
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
export function ke_Sub_CheckPropertyNew(pobjke_SubEN: clske_SubEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjke_SubEN.ke_SuperId) === true )
{
 throw new Error("(errid:Watl000058)字段[知识分类Id]不能为空(In 知识经济子类)!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_cn) === true )
{
 throw new Error("(errid:Watl000058)字段[知识子类名]不能为空(In 知识经济子类)!(clske_SubBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjke_SubEN.ke_SubId) == false && GetStrLen(pobjke_SubEN.ke_SubId) > 4)
{
 throw new Error("(errid:Watl000059)字段[知识子类Id(ke_SubId)]的长度不能超过4(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubId)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SuperId) == false && GetStrLen(pobjke_SubEN.ke_SuperId) > 4)
{
 throw new Error("(errid:Watl000059)字段[知识分类Id(ke_SuperId)]的长度不能超过4(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SuperId)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_cn) == false && GetStrLen(pobjke_SubEN.ke_SubName_cn) > 200)
{
 throw new Error("(errid:Watl000059)字段[知识子类名(ke_SubName_cn)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubName_cn)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_en) == false && GetStrLen(pobjke_SubEN.ke_SubName_en) > 200)
{
 throw new Error("(errid:Watl000059)字段[知识子类英文名(ke_SubName_en)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubName_en)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_cn) == false && GetStrLen(pobjke_SubEN.ke_SubDescribe_cn) > 500)
{
 throw new Error("(errid:Watl000059)字段[知识子类描述(ke_SubDescribe_cn)]的长度不能超过500(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubDescribe_cn)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_en) == false && GetStrLen(pobjke_SubEN.ke_SubDescribe_en) > 500)
{
 throw new Error("(errid:Watl000059)字段[知识子类英文描述(ke_SubDescribe_en)]的长度不能超过500(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubDescribe_en)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.updDate) == false && GetStrLen(pobjke_SubEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.updDate)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.updUser) == false && GetStrLen(pobjke_SubEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.updUser)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.memo) == false && GetStrLen(pobjke_SubEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.memo)(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.link) == false && GetStrLen(pobjke_SubEN.link) > 200)
{
 throw new Error("(errid:Watl000059)字段[相应链接(link)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.link)(clske_SubBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjke_SubEN.ke_SubId) == false && undefined !== pobjke_SubEN.ke_SubId && tzDataType.isString(pobjke_SubEN.ke_SubId) === false)
{
 throw new Error("(errid:Watl000060)字段[知识子类Id(ke_SubId)]的值:[$(pobjke_SubEN.ke_SubId)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SuperId) == false && undefined !== pobjke_SubEN.ke_SuperId && tzDataType.isString(pobjke_SubEN.ke_SuperId) === false)
{
 throw new Error("(errid:Watl000060)字段[知识分类Id(ke_SuperId)]的值:[$(pobjke_SubEN.ke_SuperId)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_cn) == false && undefined !== pobjke_SubEN.ke_SubName_cn && tzDataType.isString(pobjke_SubEN.ke_SubName_cn) === false)
{
 throw new Error("(errid:Watl000060)字段[知识子类名(ke_SubName_cn)]的值:[$(pobjke_SubEN.ke_SubName_cn)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_en) == false && undefined !== pobjke_SubEN.ke_SubName_en && tzDataType.isString(pobjke_SubEN.ke_SubName_en) === false)
{
 throw new Error("(errid:Watl000060)字段[知识子类英文名(ke_SubName_en)]的值:[$(pobjke_SubEN.ke_SubName_en)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_cn) == false && undefined !== pobjke_SubEN.ke_SubDescribe_cn && tzDataType.isString(pobjke_SubEN.ke_SubDescribe_cn) === false)
{
 throw new Error("(errid:Watl000060)字段[知识子类描述(ke_SubDescribe_cn)]的值:[$(pobjke_SubEN.ke_SubDescribe_cn)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_en) == false && undefined !== pobjke_SubEN.ke_SubDescribe_en && tzDataType.isString(pobjke_SubEN.ke_SubDescribe_en) === false)
{
 throw new Error("(errid:Watl000060)字段[知识子类英文描述(ke_SubDescribe_en)]的值:[$(pobjke_SubEN.ke_SubDescribe_en)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.updDate) == false && undefined !== pobjke_SubEN.updDate && tzDataType.isString(pobjke_SubEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjke_SubEN.updDate)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.updUser) == false && undefined !== pobjke_SubEN.updUser && tzDataType.isString(pobjke_SubEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjke_SubEN.updUser)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.memo) == false && undefined !== pobjke_SubEN.memo && tzDataType.isString(pobjke_SubEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjke_SubEN.memo)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjke_SubEN.link) == false && undefined !== pobjke_SubEN.link && tzDataType.isString(pobjke_SubEN.link) === false)
{
 throw new Error("(errid:Watl000060)字段[相应链接(link)]的值:[$(pobjke_SubEN.link)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjke_SubEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ke_Sub_CheckProperty4Update (pobjke_SubEN: clske_SubEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjke_SubEN.ke_SubId) == false && GetStrLen(pobjke_SubEN.ke_SubId) > 4)
{
 throw new Error("(errid:Watl000062)字段[知识子类Id(ke_SubId)]的长度不能超过4(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubId)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SuperId) == false && GetStrLen(pobjke_SubEN.ke_SuperId) > 4)
{
 throw new Error("(errid:Watl000062)字段[知识分类Id(ke_SuperId)]的长度不能超过4(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SuperId)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_cn) == false && GetStrLen(pobjke_SubEN.ke_SubName_cn) > 200)
{
 throw new Error("(errid:Watl000062)字段[知识子类名(ke_SubName_cn)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubName_cn)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_en) == false && GetStrLen(pobjke_SubEN.ke_SubName_en) > 200)
{
 throw new Error("(errid:Watl000062)字段[知识子类英文名(ke_SubName_en)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubName_en)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_cn) == false && GetStrLen(pobjke_SubEN.ke_SubDescribe_cn) > 500)
{
 throw new Error("(errid:Watl000062)字段[知识子类描述(ke_SubDescribe_cn)]的长度不能超过500(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubDescribe_cn)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_en) == false && GetStrLen(pobjke_SubEN.ke_SubDescribe_en) > 500)
{
 throw new Error("(errid:Watl000062)字段[知识子类英文描述(ke_SubDescribe_en)]的长度不能超过500(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.ke_SubDescribe_en)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.updDate) == false && GetStrLen(pobjke_SubEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.updDate)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.updUser) == false && GetStrLen(pobjke_SubEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.updUser)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.memo) == false && GetStrLen(pobjke_SubEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.memo)(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.link) == false && GetStrLen(pobjke_SubEN.link) > 200)
{
 throw new Error("(errid:Watl000062)字段[相应链接(link)]的长度不能超过200(In 知识经济子类(ke_Sub))!值:$(pobjke_SubEN.link)(clske_SubBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjke_SubEN.ke_SubId) == false && undefined !== pobjke_SubEN.ke_SubId && tzDataType.isString(pobjke_SubEN.ke_SubId) === false)
{
 throw new Error("(errid:Watl000063)字段[知识子类Id(ke_SubId)]的值:[$(pobjke_SubEN.ke_SubId)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SuperId) == false && undefined !== pobjke_SubEN.ke_SuperId && tzDataType.isString(pobjke_SubEN.ke_SuperId) === false)
{
 throw new Error("(errid:Watl000063)字段[知识分类Id(ke_SuperId)]的值:[$(pobjke_SubEN.ke_SuperId)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_cn) == false && undefined !== pobjke_SubEN.ke_SubName_cn && tzDataType.isString(pobjke_SubEN.ke_SubName_cn) === false)
{
 throw new Error("(errid:Watl000063)字段[知识子类名(ke_SubName_cn)]的值:[$(pobjke_SubEN.ke_SubName_cn)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubName_en) == false && undefined !== pobjke_SubEN.ke_SubName_en && tzDataType.isString(pobjke_SubEN.ke_SubName_en) === false)
{
 throw new Error("(errid:Watl000063)字段[知识子类英文名(ke_SubName_en)]的值:[$(pobjke_SubEN.ke_SubName_en)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_cn) == false && undefined !== pobjke_SubEN.ke_SubDescribe_cn && tzDataType.isString(pobjke_SubEN.ke_SubDescribe_cn) === false)
{
 throw new Error("(errid:Watl000063)字段[知识子类描述(ke_SubDescribe_cn)]的值:[$(pobjke_SubEN.ke_SubDescribe_cn)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.ke_SubDescribe_en) == false && undefined !== pobjke_SubEN.ke_SubDescribe_en && tzDataType.isString(pobjke_SubEN.ke_SubDescribe_en) === false)
{
 throw new Error("(errid:Watl000063)字段[知识子类英文描述(ke_SubDescribe_en)]的值:[$(pobjke_SubEN.ke_SubDescribe_en)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.updDate) == false && undefined !== pobjke_SubEN.updDate && tzDataType.isString(pobjke_SubEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjke_SubEN.updDate)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.updUser) == false && undefined !== pobjke_SubEN.updUser && tzDataType.isString(pobjke_SubEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjke_SubEN.updUser)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.memo) == false && undefined !== pobjke_SubEN.memo && tzDataType.isString(pobjke_SubEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjke_SubEN.memo)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjke_SubEN.link) == false && undefined !== pobjke_SubEN.link && tzDataType.isString(pobjke_SubEN.link) === false)
{
 throw new Error("(errid:Watl000063)字段[相应链接(link)]的值:[$(pobjke_SubEN.link)], 非法，应该为字符型(In 知识经济子类(ke_Sub))!(clske_SubBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjke_SubEN.ke_SubId) === true )
{
 throw new Error("(errid:Watl000064)字段[知识子类Id]不能为空(In 知识经济子类)!(clske_SubBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjke_SubEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ke_Sub_GetJSONStrByObj (pobjke_SubEN: clske_SubEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjke_SubEN.sf_UpdFldSetStr = pobjke_SubEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjke_SubEN);
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
export function ke_Sub_GetObjLstByJSONStr (strJSON: string): Array<clske_SubEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrke_SubObjLst = new Array<clske_SubEN>();
if (strJSON === "")
{
return arrke_SubObjLst;
}
try
{
arrke_SubObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrke_SubObjLst;
}
return arrke_SubObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrke_SubObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ke_Sub_GetObjLstByJSONObjLst (arrke_SubObjLstS: Array<clske_SubEN>): Array<clske_SubEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrke_SubObjLst = new Array<clske_SubEN>();
for (const objInFor of arrke_SubObjLstS) {
const obj1 = ke_Sub_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrke_SubObjLst.push(obj1);
}
return arrke_SubObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ke_Sub_GetObjByJSONStr (strJSON: string): clske_SubEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjke_SubEN = new clske_SubEN();
if (strJSON === "")
{
return pobjke_SubEN;
}
try
{
pobjke_SubEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjke_SubEN;
}
return pobjke_SubEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ke_Sub_GetCombineCondition(objke_Sub_Cond: clske_SubEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SubId) == true)
{
const strComparisonOp_ke_SubId:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SubId];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SubId, objke_Sub_Cond.ke_SubId, strComparisonOp_ke_SubId);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SuperId) == true)
{
const strComparisonOp_ke_SuperId:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SuperId];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SuperId, objke_Sub_Cond.ke_SuperId, strComparisonOp_ke_SuperId);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SubName_cn) == true)
{
const strComparisonOp_ke_SubName_cn:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SubName_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SubName_cn, objke_Sub_Cond.ke_SubName_cn, strComparisonOp_ke_SubName_cn);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SubName_en) == true)
{
const strComparisonOp_ke_SubName_en:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SubName_en];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SubName_en, objke_Sub_Cond.ke_SubName_en, strComparisonOp_ke_SubName_en);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SubDescribe_cn) == true)
{
const strComparisonOp_ke_SubDescribe_cn:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SubDescribe_cn];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SubDescribe_cn, objke_Sub_Cond.ke_SubDescribe_cn, strComparisonOp_ke_SubDescribe_cn);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_ke_SubDescribe_en) == true)
{
const strComparisonOp_ke_SubDescribe_en:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_ke_SubDescribe_en];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_ke_SubDescribe_en, objke_Sub_Cond.ke_SubDescribe_en, strComparisonOp_ke_SubDescribe_en);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_UpdDate, objke_Sub_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_UpdUser, objke_Sub_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_Memo, objke_Sub_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objke_Sub_Cond.dicFldComparisonOp, clske_SubEN.con_Link) == true)
{
const strComparisonOp_Link:string = objke_Sub_Cond.dicFldComparisonOp[clske_SubEN.con_Link];
strWhereCond += Format(" And {0} {2} '{1}'", clske_SubEN.con_Link, objke_Sub_Cond.link, strComparisonOp_Link);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objke_SubENS:源对象
 * @param objke_SubENT:目标对象
*/
export function ke_Sub_CopyObjTo(objke_SubENS: clske_SubEN , objke_SubENT: clske_SubEN ): void 
{
objke_SubENT.ke_SubId = objke_SubENS.ke_SubId; //知识子类Id
objke_SubENT.ke_SuperId = objke_SubENS.ke_SuperId; //知识分类Id
objke_SubENT.ke_SubName_cn = objke_SubENS.ke_SubName_cn; //知识子类名
objke_SubENT.ke_SubName_en = objke_SubENS.ke_SubName_en; //知识子类英文名
objke_SubENT.ke_SubDescribe_cn = objke_SubENS.ke_SubDescribe_cn; //知识子类描述
objke_SubENT.ke_SubDescribe_en = objke_SubENS.ke_SubDescribe_en; //知识子类英文描述
objke_SubENT.updDate = objke_SubENS.updDate; //修改日期
objke_SubENT.updUser = objke_SubENS.updUser; //修改人
objke_SubENT.memo = objke_SubENS.memo; //备注
objke_SubENT.link = objke_SubENS.link; //相应链接
objke_SubENT.sf_UpdFldSetStr = objke_SubENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objke_SubENS:源对象
 * @param objke_SubENT:目标对象
*/
export function ke_Sub_GetObjFromJsonObj(objke_SubENS: clske_SubEN): clske_SubEN 
{
 const objke_SubENT: clske_SubEN = new clske_SubEN();
ObjectAssign(objke_SubENT, objke_SubENS);
 return objke_SubENT;
}