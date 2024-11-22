
 /**
 * 类名:clsgs_TopicRoleWApi
 * 表名:gs_TopicRole(01120869)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 16:10:02
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
 * 主题权限表(gs_TopicRole)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TopicRoleEN } from "../../L0_Entity/GraduateEduTopic/clsgs_TopicRoleEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_TopicRole_Controller = "gs_TopicRoleApi";
 export const gs_TopicRole_ConstructorName = "gs_TopicRole";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTopicRoleId:关键字
 * @returns 对象
 **/
export async function gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId: string): Promise<clsgs_TopicRoleEN>  
{
const strThisFuncName = "GetObjByTopicRoleIdAsync";

if (IsNullOrEmpty(strTopicRoleId) == true)
{
  const strMsg = Format("参数:[strTopicRoleId]不能为空！(In GetObjByTopicRoleIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicRoleId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！", strTopicRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTopicRoleId";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTopicRoleId": strTopicRoleId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TopicRole = gs_TopicRole_GetObjFromJsonObj(returnObj);
return objgs_TopicRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param strTopicRoleId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicRole_GetObjByTopicRoleId_Cache(strTopicRoleId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTopicRoleId_Cache";

if (IsNullOrEmpty(strTopicRoleId) == true)
{
  const strMsg = Format("参数:[strTopicRoleId]不能为空！(In GetObjByTopicRoleId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicRoleId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！", strTopicRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
try
{
const arrgs_TopicRole_Sel: Array <clsgs_TopicRoleEN> = arrgs_TopicRoleObjLst_Cache.filter(x => x.topicRoleId == strTopicRoleId);
let objgs_TopicRole: clsgs_TopicRoleEN;
if (arrgs_TopicRole_Sel.length > 0)
{
objgs_TopicRole = arrgs_TopicRole_Sel[0];
return objgs_TopicRole;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_TopicRole = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
if (objgs_TopicRole != null)
{
gs_TopicRole_ReFreshThisCache();
return objgs_TopicRole;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicRoleId, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTopicRoleId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicRole_GetObjByTopicRoleId_localStorage(strTopicRoleId: string) {
const strThisFuncName = "GetObjByTopicRoleId_localStorage";

if (IsNullOrEmpty(strTopicRoleId) == true)
{
  const strMsg = Format("参数:[strTopicRoleId]不能为空！(In GetObjByTopicRoleId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicRoleId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTopicRoleId]的长度:[{0}]不正确！", strTopicRoleId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TopicRoleEN._CurrTabName, strTopicRoleId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_TopicRole_Cache: clsgs_TopicRoleEN = JSON.parse(strTempObj);
return objgs_TopicRole_Cache;
}
try
{
const objgs_TopicRole = await gs_TopicRole_GetObjByTopicRoleIdAsync(strTopicRoleId);
if (objgs_TopicRole != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_TopicRole));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_TopicRole;
}
return objgs_TopicRole;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicRoleId, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_TopicRole:所给的对象
 * @returns 对象
*/
export async function gs_TopicRole_UpdateObjInLst_Cache(objgs_TopicRole: clsgs_TopicRoleEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
const obj = arrgs_TopicRoleObjLst_Cache.find(x => x.topicRoleId == objgs_TopicRole.topicRoleId);
if (obj != null)
{
objgs_TopicRole.topicRoleId = obj.topicRoleId;
ObjectAssign( obj, objgs_TopicRole);
}
else
{
arrgs_TopicRoleObjLst_Cache.push(objgs_TopicRole);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_TopicRoleEN.con_TopicRoleId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TopicRoleEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TopicRoleEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTopicRoleId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_TopicRole = await gs_TopicRole_GetObjByTopicRoleId_Cache(strTopicRoleId );
if (objgs_TopicRole == null) return "";
return objgs_TopicRole.GetFldValue(strOutFldName).toString();
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
export function gs_TopicRole_SortFun_Defa(a:clsgs_TopicRoleEN , b:clsgs_TopicRoleEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicRoleId.localeCompare(b.topicRoleId);
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
export function gs_TopicRole_SortFun_Defa_2Fld(a:clsgs_TopicRoleEN , b:clsgs_TopicRoleEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.menuNum.localeCompare(b.menuNum);
else return a.topicId.localeCompare(b.topicId);
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
export function gs_TopicRole_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TopicRoleEN.con_TopicRoleId:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.topicRoleId.localeCompare(b.topicRoleId);
}
case clsgs_TopicRoleEN.con_TopicId:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsgs_TopicRoleEN.con_MenuNum:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.menuNum.localeCompare(b.menuNum);
}
case clsgs_TopicRoleEN.con_MenuName:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.menuName.localeCompare(b.menuName);
}
case clsgs_TopicRoleEN.con_MenuIsHide:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
if (a.menuIsHide == true) return 1;
else return -1
}
case clsgs_TopicRoleEN.con_UpdDate:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TopicRoleEN.con_UpdUser:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TopicRoleEN.con_Memo:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_TopicRoleEN.con_IsDefault:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
if (a.isDefault == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${ gs_TopicRole_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TopicRoleEN.con_TopicRoleId:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.topicRoleId.localeCompare(a.topicRoleId);
}
case clsgs_TopicRoleEN.con_TopicId:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsgs_TopicRoleEN.con_MenuNum:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.menuNum.localeCompare(a.menuNum);
}
case clsgs_TopicRoleEN.con_MenuName:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.menuName.localeCompare(a.menuName);
}
case clsgs_TopicRoleEN.con_MenuIsHide:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
if (b.menuIsHide == true) return 1;
else return -1
}
case clsgs_TopicRoleEN.con_UpdDate:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TopicRoleEN.con_UpdUser:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TopicRoleEN.con_Memo:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_TopicRoleEN.con_IsDefault:
return (a: clsgs_TopicRoleEN, b: clsgs_TopicRoleEN) => {
if (b.isDefault == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${ gs_TopicRole_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TopicRole_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TopicRoleEN.con_TopicRoleId:
return (obj: clsgs_TopicRoleEN) => {
return obj.topicRoleId === value;
}
case clsgs_TopicRoleEN.con_TopicId:
return (obj: clsgs_TopicRoleEN) => {
return obj.topicId === value;
}
case clsgs_TopicRoleEN.con_MenuNum:
return (obj: clsgs_TopicRoleEN) => {
return obj.menuNum === value;
}
case clsgs_TopicRoleEN.con_MenuName:
return (obj: clsgs_TopicRoleEN) => {
return obj.menuName === value;
}
case clsgs_TopicRoleEN.con_MenuIsHide:
return (obj: clsgs_TopicRoleEN) => {
return obj.menuIsHide === value;
}
case clsgs_TopicRoleEN.con_UpdDate:
return (obj: clsgs_TopicRoleEN) => {
return obj.updDate === value;
}
case clsgs_TopicRoleEN.con_UpdUser:
return (obj: clsgs_TopicRoleEN) => {
return obj.updUser === value;
}
case clsgs_TopicRoleEN.con_Memo:
return (obj: clsgs_TopicRoleEN) => {
return obj.memo === value;
}
case clsgs_TopicRoleEN.con_IsDefault:
return (obj: clsgs_TopicRoleEN) => {
return obj.isDefault === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_TopicRole]中不存在！(in ${ gs_TopicRole_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_TopicRole_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TopicRoleEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_TopicRole = gs_TopicRole_GetObjFromJsonObj(returnObj);
return objgs_TopicRole;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicRoleEN._CurrTabName;
clsgs_TopicRoleEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicRoleEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicRoleEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TopicRoleExObjLst_Cache: Array<clsgs_TopicRoleEN> = CacheHelper.Get(strKey);
const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
return arrgs_TopicRoleObjLst_T;
}
try
{
const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TopicRoleExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
console.log(strInfo);
return arrgs_TopicRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicRole_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicRoleEN._CurrTabName;
clsgs_TopicRoleEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicRoleEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicRoleEN.CacheAddiCondition);
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
const arrgs_TopicRoleExObjLst_Cache: Array<clsgs_TopicRoleEN> = JSON.parse(strTempObjLst);
const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
return arrgs_TopicRoleObjLst_T;
}
try
{
const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TopicRoleExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
console.log(strInfo);
return arrgs_TopicRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicRole_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TopicRoleEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TopicRoleObjLst_Cache: Array<clsgs_TopicRoleEN> = JSON.parse(strTempObjLst);
return arrgs_TopicRoleObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_TopicRole_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TopicRoleEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TopicRoleEN._CurrTabName;
clsgs_TopicRoleEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TopicRoleEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TopicRoleEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TopicRoleEN.CacheAddiCondition);
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
const arrgs_TopicRoleExObjLst_Cache: Array<clsgs_TopicRoleEN> = JSON.parse(strTempObjLst);
const arrgs_TopicRoleObjLst_T = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleExObjLst_Cache);
return arrgs_TopicRoleObjLst_T;
}
try
{
const arrgs_TopicRoleExObjLst = await gs_TopicRole_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TopicRoleExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TopicRoleExObjLst.length);
console.log(strInfo);
return arrgs_TopicRoleExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicRole_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TopicRoleEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TopicRoleObjLst_Cache: Array<clsgs_TopicRoleEN> = JSON.parse(strTempObjLst);
return arrgs_TopicRoleObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicRole_GetObjLst_Cache(): Promise<Array<clsgs_TopicRoleEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_TopicRoleObjLst_Cache;
switch (clsgs_TopicRoleEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_ClientCache();
break;
default:
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_ClientCache();
break;
}
const arrgs_TopicRoleObjLst = gs_TopicRole_GetObjLstByJSONObjLst(arrgs_TopicRoleObjLst_Cache);
return arrgs_TopicRoleObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_TopicRole_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TopicRoleObjLst_Cache;
switch (clsgs_TopicRoleEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_TopicRoleObjLst_Cache = null;
break;
default:
arrgs_TopicRoleObjLst_Cache = null;
break;
}
return arrgs_TopicRoleObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTopicRoleId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TopicRole_GetSubObjLst_Cache(objgs_TopicRole_Cond: clsgs_TopicRoleEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
let arrgs_TopicRole_Sel: Array < clsgs_TopicRoleEN > = arrgs_TopicRoleObjLst_Cache;
if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "") return arrgs_TopicRole_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TopicRole_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_TopicRole_Cond), gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicRoleEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTopicRoleId:关键字列表
 * @returns 对象列表
 **/
export async function gs_TopicRole_GetObjLstByTopicRoleIdLstAsync(arrTopicRoleId: Array<string>): Promise<Array<clsgs_TopicRoleEN>>  
{
const strThisFuncName = "GetObjLstByTopicRoleIdLstAsync";
const strAction = "GetObjLstByTopicRoleIdLst";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicRoleId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param arrstrTopicRoleIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_TopicRole_GetObjLstByTopicRoleIdLst_Cache(arrTopicRoleIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByTopicRoleIdLst_Cache";
try
{
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
const arrgs_TopicRole_Sel: Array <clsgs_TopicRoleEN> = arrgs_TopicRoleObjLst_Cache.filter(x => arrTopicRoleIdLst.indexOf(x.topicRoleId)>-1);
return arrgs_TopicRole_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicRoleIdLst.join(","), gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicRoleEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_TopicRole_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TopicRoleEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TopicRoleEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
if (arrgs_TopicRoleObjLst_Cache.length == 0) return arrgs_TopicRoleObjLst_Cache;
let arrgs_TopicRole_Sel = arrgs_TopicRoleObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_TopicRole_Cond = new clsgs_TopicRoleEN();
ObjectAssign(objgs_TopicRole_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TopicRoleWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TopicRole_Sel.length == 0) return arrgs_TopicRole_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(gs_TopicRole_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.sort(objPagerPara.sortFun);
}
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.slice(intStart, intEnd);     
return arrgs_TopicRole_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TopicRoleEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_TopicRole_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TopicRoleEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_TopicRole_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param strTopicRoleId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_TopicRole_DelRecordAsync(strTopicRoleId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strTopicRoleId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strTopicRoleId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param arrTopicRoleId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_TopicRole_Delgs_TopicRolesAsync(arrTopicRoleId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TopicRolesAsync";
const strAction = "Delgs_TopicRoles";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicRoleId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_Delgs_TopicRolesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TopicRolesByCondAsync";
const strAction = "Delgs_TopicRolesByCond";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TopicRole_AddNewRecordAsync(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TopicRoleEN);
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_TopicRole_AddNewRecordWithMaxIdAsync(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_TopicRole_AddNewRecordWithReturnKeyAsync(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_TopicRole_AddNewRecordWithReturnKey(objgs_TopicRoleEN: clsgs_TopicRoleEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TopicRoleEN.topicRoleId === null || objgs_TopicRoleEN.topicRoleId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_TopicRole_UpdateRecordAsync(objgs_TopicRoleEN: clsgs_TopicRoleEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TopicRoleEN.sf_UpdFldSetStr === undefined || objgs_TopicRoleEN.sf_UpdFldSetStr === null || objgs_TopicRoleEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicRoleEN.topicRoleId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRoleEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_TopicRole_UpdateWithConditionAsync(objgs_TopicRoleEN: clsgs_TopicRoleEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TopicRoleEN.sf_UpdFldSetStr === undefined || objgs_TopicRoleEN.sf_UpdFldSetStr === null || objgs_TopicRoleEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TopicRoleEN.topicRoleId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
objgs_TopicRoleEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TopicRoleEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objstrTopicRoleId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_TopicRole_IsExistRecord_Cache(objgs_TopicRole_Cond: clsgs_TopicRoleEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
if (arrgs_TopicRoleObjLst_Cache == null) return false;
let arrgs_TopicRole_Sel: Array < clsgs_TopicRoleEN > = arrgs_TopicRoleObjLst_Cache;
if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "") return arrgs_TopicRole_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_TopicRole_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_TopicRole_Cond), gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param strTopicRoleId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_TopicRole_IsExist(strTopicRoleId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TopicRoleId": strTopicRoleId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param strTopicRoleId:所给的关键字
 * @returns 对象
*/
export async function gs_TopicRole_IsExist_Cache(strTopicRoleId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
if (arrgs_TopicRoleObjLst_Cache == null) return false;
try
{
const arrgs_TopicRole_Sel: Array <clsgs_TopicRoleEN> = arrgs_TopicRoleObjLst_Cache.filter(x => x.topicRoleId == strTopicRoleId);
if (arrgs_TopicRole_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicRoleId, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTopicRoleId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_TopicRole_IsExistAsync(strTopicRoleId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTopicRoleId": strTopicRoleId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export async function gs_TopicRole_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
 * @param objgs_TopicRole_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_TopicRole_GetRecCountByCond_Cache(objgs_TopicRole_Cond: clsgs_TopicRoleEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TopicRoleObjLst_Cache = await gs_TopicRole_GetObjLst_Cache();
if (arrgs_TopicRoleObjLst_Cache == null) return 0;
let arrgs_TopicRole_Sel: Array < clsgs_TopicRoleEN > = arrgs_TopicRoleObjLst_Cache;
if (objgs_TopicRole_Cond.sf_FldComparisonOp == null || objgs_TopicRole_Cond.sf_FldComparisonOp == "") return arrgs_TopicRole_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_TopicRole_Cond.sf_FldComparisonOp);
//console.log("clsgs_TopicRoleWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_TopicRole_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_TopicRole_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_TopicRole_Sel = arrgs_TopicRole_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_TopicRole_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_TopicRole_Cond), gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

 /**
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function gs_TopicRole_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
try
{
const response = await axios.get(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function gs_TopicRole_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_TopicRole_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_TopicRole_ConstructorName, strThisFuncName);
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
export function gs_TopicRole_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_TopicRole_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_TopicRoleEN._CurrTabName;
switch (clsgs_TopicRoleEN.CacheModeId)
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
export function gs_TopicRole_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_TopicRoleEN._CurrTabName;
switch (clsgs_TopicRoleEN.CacheModeId)
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
export function gs_TopicRole_CheckPropertyNew(pobjgs_TopicRoleEN: clsgs_TopicRoleEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicRoleId) == false && GetStrLen(pobjgs_TopicRoleEN.topicRoleId) > 10)
{
 throw new Error("(errid:Watl000059)字段[主题权限Id(topicRoleId)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicRoleId)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicId) == false && GetStrLen(pobjgs_TopicRoleEN.topicId) > 8)
{
 throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicId)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuNum) == false && GetStrLen(pobjgs_TopicRoleEN.menuNum) > 10)
{
 throw new Error("(errid:Watl000059)字段[菜单编号(menuNum)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuNum)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuName) == false && GetStrLen(pobjgs_TopicRoleEN.menuName) > 100)
{
 throw new Error("(errid:Watl000059)字段[菜单名称(menuName)]的长度不能超过100(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuName)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updDate) == false && GetStrLen(pobjgs_TopicRoleEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updDate)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updUser) == false && GetStrLen(pobjgs_TopicRoleEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updUser)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.memo) == false && GetStrLen(pobjgs_TopicRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.memo)(clsgs_TopicRoleBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicRoleId) == false && undefined !== pobjgs_TopicRoleEN.topicRoleId && tzDataType.isString(pobjgs_TopicRoleEN.topicRoleId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题权限Id(topicRoleId)]的值:[$(pobjgs_TopicRoleEN.topicRoleId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicId) == false && undefined !== pobjgs_TopicRoleEN.topicId && tzDataType.isString(pobjgs_TopicRoleEN.topicId) === false)
{
 throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_TopicRoleEN.topicId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuNum) == false && undefined !== pobjgs_TopicRoleEN.menuNum && tzDataType.isString(pobjgs_TopicRoleEN.menuNum) === false)
{
 throw new Error("(errid:Watl000060)字段[菜单编号(menuNum)]的值:[$(pobjgs_TopicRoleEN.menuNum)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuName) == false && undefined !== pobjgs_TopicRoleEN.menuName && tzDataType.isString(pobjgs_TopicRoleEN.menuName) === false)
{
 throw new Error("(errid:Watl000060)字段[菜单名称(menuName)]的值:[$(pobjgs_TopicRoleEN.menuName)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (null != pobjgs_TopicRoleEN.menuIsHide && undefined !== pobjgs_TopicRoleEN.menuIsHide && tzDataType.isBoolean(pobjgs_TopicRoleEN.menuIsHide) === false)
{
 throw new Error("(errid:Watl000060)字段[菜单是否隐藏(menuIsHide)]的值:[$(pobjgs_TopicRoleEN.menuIsHide)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updDate) == false && undefined !== pobjgs_TopicRoleEN.updDate && tzDataType.isString(pobjgs_TopicRoleEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TopicRoleEN.updDate)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updUser) == false && undefined !== pobjgs_TopicRoleEN.updUser && tzDataType.isString(pobjgs_TopicRoleEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TopicRoleEN.updUser)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.memo) == false && undefined !== pobjgs_TopicRoleEN.memo && tzDataType.isString(pobjgs_TopicRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TopicRoleEN.memo)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
if (null != pobjgs_TopicRoleEN.isDefault && undefined !== pobjgs_TopicRoleEN.isDefault && tzDataType.isBoolean(pobjgs_TopicRoleEN.isDefault) === false)
{
 throw new Error("(errid:Watl000060)字段[是否默认(isDefault)]的值:[$(pobjgs_TopicRoleEN.isDefault)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TopicRoleEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_TopicRole_CheckProperty4Update (pobjgs_TopicRoleEN: clsgs_TopicRoleEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicRoleId) == false && GetStrLen(pobjgs_TopicRoleEN.topicRoleId) > 10)
{
 throw new Error("(errid:Watl000062)字段[主题权限Id(topicRoleId)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicRoleId)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicId) == false && GetStrLen(pobjgs_TopicRoleEN.topicId) > 8)
{
 throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.topicId)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuNum) == false && GetStrLen(pobjgs_TopicRoleEN.menuNum) > 10)
{
 throw new Error("(errid:Watl000062)字段[菜单编号(menuNum)]的长度不能超过10(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuNum)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuName) == false && GetStrLen(pobjgs_TopicRoleEN.menuName) > 100)
{
 throw new Error("(errid:Watl000062)字段[菜单名称(menuName)]的长度不能超过100(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.menuName)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updDate) == false && GetStrLen(pobjgs_TopicRoleEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updDate)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updUser) == false && GetStrLen(pobjgs_TopicRoleEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.updUser)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.memo) == false && GetStrLen(pobjgs_TopicRoleEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 主题权限表(gs_TopicRole))!值:$(pobjgs_TopicRoleEN.memo)(clsgs_TopicRoleBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicRoleId) == false && undefined !== pobjgs_TopicRoleEN.topicRoleId && tzDataType.isString(pobjgs_TopicRoleEN.topicRoleId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题权限Id(topicRoleId)]的值:[$(pobjgs_TopicRoleEN.topicRoleId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicId) == false && undefined !== pobjgs_TopicRoleEN.topicId && tzDataType.isString(pobjgs_TopicRoleEN.topicId) === false)
{
 throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_TopicRoleEN.topicId)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuNum) == false && undefined !== pobjgs_TopicRoleEN.menuNum && tzDataType.isString(pobjgs_TopicRoleEN.menuNum) === false)
{
 throw new Error("(errid:Watl000063)字段[菜单编号(menuNum)]的值:[$(pobjgs_TopicRoleEN.menuNum)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.menuName) == false && undefined !== pobjgs_TopicRoleEN.menuName && tzDataType.isString(pobjgs_TopicRoleEN.menuName) === false)
{
 throw new Error("(errid:Watl000063)字段[菜单名称(menuName)]的值:[$(pobjgs_TopicRoleEN.menuName)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (null != pobjgs_TopicRoleEN.menuIsHide && undefined !== pobjgs_TopicRoleEN.menuIsHide && tzDataType.isBoolean(pobjgs_TopicRoleEN.menuIsHide) === false)
{
 throw new Error("(errid:Watl000063)字段[菜单是否隐藏(menuIsHide)]的值:[$(pobjgs_TopicRoleEN.menuIsHide)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updDate) == false && undefined !== pobjgs_TopicRoleEN.updDate && tzDataType.isString(pobjgs_TopicRoleEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TopicRoleEN.updDate)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.updUser) == false && undefined !== pobjgs_TopicRoleEN.updUser && tzDataType.isString(pobjgs_TopicRoleEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TopicRoleEN.updUser)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TopicRoleEN.memo) == false && undefined !== pobjgs_TopicRoleEN.memo && tzDataType.isString(pobjgs_TopicRoleEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TopicRoleEN.memo)], 非法，应该为字符型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
if (null != pobjgs_TopicRoleEN.isDefault && undefined !== pobjgs_TopicRoleEN.isDefault && tzDataType.isBoolean(pobjgs_TopicRoleEN.isDefault) === false)
{
 throw new Error("(errid:Watl000063)字段[是否默认(isDefault)]的值:[$(pobjgs_TopicRoleEN.isDefault)], 非法，应该为布尔型(In 主题权限表(gs_TopicRole))!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TopicRoleEN.topicRoleId) === true )
{
 throw new Error("(errid:Watl000064)字段[主题权限Id]不能为空(In 主题权限表)!(clsgs_TopicRoleBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TopicRoleEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TopicRole_GetJSONStrByObj (pobjgs_TopicRoleEN: clsgs_TopicRoleEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TopicRoleEN.sf_UpdFldSetStr = pobjgs_TopicRoleEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TopicRoleEN);
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
export function gs_TopicRole_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TopicRoleEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TopicRoleObjLst = new Array<clsgs_TopicRoleEN>();
if (strJSON === "")
{
return arrgs_TopicRoleObjLst;
}
try
{
arrgs_TopicRoleObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TopicRoleObjLst;
}
return arrgs_TopicRoleObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TopicRoleObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_TopicRole_GetObjLstByJSONObjLst (arrgs_TopicRoleObjLstS: Array<clsgs_TopicRoleEN>): Array<clsgs_TopicRoleEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TopicRoleObjLst = new Array<clsgs_TopicRoleEN>();
for (const objInFor of arrgs_TopicRoleObjLstS) {
const obj1 = gs_TopicRole_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TopicRoleObjLst.push(obj1);
}
return arrgs_TopicRoleObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_TopicRole_GetObjByJSONStr (strJSON: string): clsgs_TopicRoleEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TopicRoleEN = new clsgs_TopicRoleEN();
if (strJSON === "")
{
return pobjgs_TopicRoleEN;
}
try
{
pobjgs_TopicRoleEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TopicRoleEN;
}
return pobjgs_TopicRoleEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_TopicRole_GetCombineCondition(objgs_TopicRole_Cond: clsgs_TopicRoleEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_TopicRoleId) == true)
{
const strComparisonOp_TopicRoleId:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_TopicRoleId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_TopicRoleId, objgs_TopicRole_Cond.topicRoleId, strComparisonOp_TopicRoleId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_TopicId, objgs_TopicRole_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_MenuNum) == true)
{
const strComparisonOp_MenuNum:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_MenuNum];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_MenuNum, objgs_TopicRole_Cond.menuNum, strComparisonOp_MenuNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_MenuName) == true)
{
const strComparisonOp_MenuName:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_MenuName];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_MenuName, objgs_TopicRole_Cond.menuName, strComparisonOp_MenuName);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_MenuIsHide) == true)
{
if (objgs_TopicRole_Cond.menuIsHide == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_TopicRoleEN.con_MenuIsHide);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_TopicRoleEN.con_MenuIsHide);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_UpdDate, objgs_TopicRole_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_UpdUser, objgs_TopicRole_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_TopicRole_Cond.dicFldComparisonOp[clsgs_TopicRoleEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TopicRoleEN.con_Memo, objgs_TopicRole_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_TopicRole_Cond.dicFldComparisonOp, clsgs_TopicRoleEN.con_IsDefault) == true)
{
if (objgs_TopicRole_Cond.isDefault == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_TopicRoleEN.con_IsDefault);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_TopicRoleEN.con_IsDefault);
}
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TopicRole(主题权限表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicRoleId: 主题权限Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TopicRole_GetUniCondStr_TopicRoleId(objgs_TopicRoleEN: clsgs_TopicRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.topicRoleId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_TopicRole(主题权限表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicRoleId: 主题权限Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_TopicRole_GetUniCondStr4Update_TopicRoleId(objgs_TopicRoleEN: clsgs_TopicRoleEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TopicRoleId <> '{0}'", objgs_TopicRoleEN.topicRoleId);
 strWhereCond +=  Format(" and TopicRoleId = '{0}'", objgs_TopicRoleEN.topicRoleId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TopicRoleENS:源对象
 * @param objgs_TopicRoleENT:目标对象
*/
export function gs_TopicRole_CopyObjTo(objgs_TopicRoleENS: clsgs_TopicRoleEN , objgs_TopicRoleENT: clsgs_TopicRoleEN ): void 
{
objgs_TopicRoleENT.topicRoleId = objgs_TopicRoleENS.topicRoleId; //主题权限Id
objgs_TopicRoleENT.topicId = objgs_TopicRoleENS.topicId; //主题Id
objgs_TopicRoleENT.menuNum = objgs_TopicRoleENS.menuNum; //菜单编号
objgs_TopicRoleENT.menuName = objgs_TopicRoleENS.menuName; //菜单名称
objgs_TopicRoleENT.menuIsHide = objgs_TopicRoleENS.menuIsHide; //菜单是否隐藏
objgs_TopicRoleENT.updDate = objgs_TopicRoleENS.updDate; //修改日期
objgs_TopicRoleENT.updUser = objgs_TopicRoleENS.updUser; //修改人
objgs_TopicRoleENT.memo = objgs_TopicRoleENS.memo; //备注
objgs_TopicRoleENT.isDefault = objgs_TopicRoleENS.isDefault; //是否默认
objgs_TopicRoleENT.sf_UpdFldSetStr = objgs_TopicRoleENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TopicRoleENS:源对象
 * @param objgs_TopicRoleENT:目标对象
*/
export function gs_TopicRole_GetObjFromJsonObj(objgs_TopicRoleENS: clsgs_TopicRoleEN): clsgs_TopicRoleEN 
{
 const objgs_TopicRoleENT: clsgs_TopicRoleEN = new clsgs_TopicRoleEN();
ObjectAssign(objgs_TopicRoleENT, objgs_TopicRoleENS);
 return objgs_TopicRoleENT;
}