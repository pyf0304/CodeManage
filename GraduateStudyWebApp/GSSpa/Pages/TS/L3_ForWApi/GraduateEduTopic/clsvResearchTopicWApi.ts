
 /**
 * 类名:clsvResearchTopicWApi
 * 表名:vResearchTopic(01120612)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:50
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
 * 研究主题视图(vResearchTopic)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvResearchTopicEN } from "../../L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vResearchTopic_Controller = "vResearchTopicApi";
 export const vResearchTopic_ConstructorName = "vResearchTopic";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTopicId:关键字
 * @returns 对象
 **/
export async function vResearchTopic_GetObjByTopicIdAsync(strTopicId: string): Promise<clsvResearchTopicEN>  
{
const strThisFuncName = "GetObjByTopicIdAsync";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In GetObjByTopicIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTopicId";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTopicId": strTopicId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvResearchTopic = vResearchTopic_GetObjFromJsonObj(returnObj);
return objvResearchTopic;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param strTopicId:所给的关键字
 * @returns 对象
*/
export async function vResearchTopic_GetObjByTopicId_Cache(strTopicId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTopicId_Cache";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In GetObjByTopicId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvResearchTopic_Sel: Array <clsvResearchTopicEN> = arrvResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
let objvResearchTopic: clsvResearchTopicEN;
if (arrvResearchTopic_Sel.length > 0)
{
objvResearchTopic = arrvResearchTopic_Sel[0];
return objvResearchTopic;
}
else
{
if (bolTryAsyncOnce == true)
{
objvResearchTopic = await vResearchTopic_GetObjByTopicIdAsync(strTopicId);
if (objvResearchTopic != null)
{
vResearchTopic_ReFreshThisCache(strid_CurrEduCls);
return objvResearchTopic;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTopicId:所给的关键字
 * @returns 对象
*/
export async function vResearchTopic_GetObjByTopicId_localStorage(strTopicId: string) {
const strThisFuncName = "GetObjByTopicId_localStorage";

if (IsNullOrEmpty(strTopicId) == true)
{
  const strMsg = Format("参数:[strTopicId]不能为空！(In GetObjByTopicId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strTopicId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvResearchTopic_Cache: clsvResearchTopicEN = JSON.parse(strTempObj);
return objvResearchTopic_Cache;
}
try
{
const objvResearchTopic = await vResearchTopic_GetObjByTopicIdAsync(strTopicId);
if (objvResearchTopic != null)
{
localStorage.setItem(strKey, JSON.stringify(objvResearchTopic));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvResearchTopic;
}
return objvResearchTopic;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicId, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_func(strInFldName:string , strOutFldName:string , strInValue:string , strid_CurrEduCls_C: string)
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

if (strInFldName != clsvResearchTopicEN.con_TopicId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvResearchTopicEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvResearchTopicEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTopicId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvResearchTopic = await vResearchTopic_GetObjByTopicId_Cache(strTopicId , strid_CurrEduCls_C);
if (objvResearchTopic == null) return "";
return objvResearchTopic.GetFldValue(strOutFldName).toString();
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
export function vResearchTopic_SortFun_Defa(a:clsvResearchTopicEN , b:clsvResearchTopicEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicId.localeCompare(b.topicId);
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
export function vResearchTopic_SortFun_Defa_2Fld(a:clsvResearchTopicEN , b:clsvResearchTopicEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicName == b.topicName) return a.topicContent.localeCompare(b.topicContent);
else return a.topicName.localeCompare(b.topicName);
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
export function vResearchTopic_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvResearchTopicEN.con_TopicId:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvResearchTopicEN.con_TopicName:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvResearchTopicEN.con_TopicContent:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.topicContent.localeCompare(b.topicContent);
}
case clsvResearchTopicEN.con_TopicProposePeople:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.topicProposePeople.localeCompare(b.topicProposePeople);
}
case clsvResearchTopicEN.con_OrderNum:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.orderNum-b.orderNum;
}
case clsvResearchTopicEN.con_UpdDate:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvResearchTopicEN.con_UpdUser:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvResearchTopicEN.con_Memo:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvResearchTopicEN.con_IsSubmit:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvResearchTopicEN.con_UserName:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvResearchTopicEN.con_id_CurrEduCls:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvResearchTopicEN.con_ShareId:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return a.shareId.localeCompare(b.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${ vResearchTopic_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvResearchTopicEN.con_TopicId:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvResearchTopicEN.con_TopicName:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvResearchTopicEN.con_TopicContent:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.topicContent.localeCompare(a.topicContent);
}
case clsvResearchTopicEN.con_TopicProposePeople:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.topicProposePeople.localeCompare(a.topicProposePeople);
}
case clsvResearchTopicEN.con_OrderNum:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.orderNum-a.orderNum;
}
case clsvResearchTopicEN.con_UpdDate:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvResearchTopicEN.con_UpdUser:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvResearchTopicEN.con_Memo:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvResearchTopicEN.con_IsSubmit:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvResearchTopicEN.con_UserName:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvResearchTopicEN.con_id_CurrEduCls:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvResearchTopicEN.con_ShareId:
return (a: clsvResearchTopicEN, b: clsvResearchTopicEN) => {
return b.shareId.localeCompare(a.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${ vResearchTopic_ConstructorName}.${ strThisFuncName})`;
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
export async function vResearchTopic_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvResearchTopicEN.con_TopicId:
return (obj: clsvResearchTopicEN) => {
return obj.topicId === value;
}
case clsvResearchTopicEN.con_TopicName:
return (obj: clsvResearchTopicEN) => {
return obj.topicName === value;
}
case clsvResearchTopicEN.con_TopicContent:
return (obj: clsvResearchTopicEN) => {
return obj.topicContent === value;
}
case clsvResearchTopicEN.con_TopicProposePeople:
return (obj: clsvResearchTopicEN) => {
return obj.topicProposePeople === value;
}
case clsvResearchTopicEN.con_OrderNum:
return (obj: clsvResearchTopicEN) => {
return obj.orderNum === value;
}
case clsvResearchTopicEN.con_UpdDate:
return (obj: clsvResearchTopicEN) => {
return obj.updDate === value;
}
case clsvResearchTopicEN.con_UpdUser:
return (obj: clsvResearchTopicEN) => {
return obj.updUser === value;
}
case clsvResearchTopicEN.con_Memo:
return (obj: clsvResearchTopicEN) => {
return obj.memo === value;
}
case clsvResearchTopicEN.con_IsSubmit:
return (obj: clsvResearchTopicEN) => {
return obj.isSubmit === value;
}
case clsvResearchTopicEN.con_UserName:
return (obj: clsvResearchTopicEN) => {
return obj.userName === value;
}
case clsvResearchTopicEN.con_id_CurrEduCls:
return (obj: clsvResearchTopicEN) => {
return obj.id_CurrEduCls === value;
}
case clsvResearchTopicEN.con_ShareId:
return (obj: clsvResearchTopicEN) => {
return obj.shareId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vResearchTopic]中不存在！(in ${ vResearchTopic_ConstructorName}.${ strThisFuncName})`;
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
export async function vResearchTopic_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetFirstObjAsync(strWhereCond: string): Promise<clsvResearchTopicEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvResearchTopic = vResearchTopic_GetObjFromJsonObj(returnObj);
return objvResearchTopic;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
clsvResearchTopicEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvResearchTopicEN._CurrTabName);
if (IsNullOrEmpty(clsvResearchTopicEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvResearchTopicEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvResearchTopicExObjLst_Cache: Array<clsvResearchTopicEN> = CacheHelper.Get(strKey);
const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
return arrvResearchTopicObjLst_T;
}
try
{
const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvResearchTopicExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
console.log(strInfo);
return arrvResearchTopicExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vResearchTopic_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
clsvResearchTopicEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvResearchTopicEN._CurrTabName);
if (IsNullOrEmpty(clsvResearchTopicEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvResearchTopicEN.CacheAddiCondition);
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
const arrvResearchTopicExObjLst_Cache: Array<clsvResearchTopicEN> = JSON.parse(strTempObjLst);
const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
return arrvResearchTopicObjLst_T;
}
try
{
const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvResearchTopicExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
console.log(strInfo);
return arrvResearchTopicExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvResearchTopicObjLst_Cache: Array<clsvResearchTopicEN> = JSON.parse(strTempObjLst);
return arrvResearchTopicObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vResearchTopic_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvResearchTopicEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
clsvResearchTopicEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvResearchTopicEN._CurrTabName);
if (IsNullOrEmpty(clsvResearchTopicEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvResearchTopicEN.CacheAddiCondition);
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
const arrvResearchTopicExObjLst_Cache: Array<clsvResearchTopicEN> = JSON.parse(strTempObjLst);
const arrvResearchTopicObjLst_T = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicExObjLst_Cache);
return arrvResearchTopicObjLst_T;
}
try
{
const arrvResearchTopicExObjLst = await vResearchTopic_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvResearchTopicExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvResearchTopicExObjLst.length);
console.log(strInfo);
return arrvResearchTopicExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvResearchTopicObjLst_Cache: Array<clsvResearchTopicEN> = JSON.parse(strTempObjLst);
return arrvResearchTopicObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vResearchTopic_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvResearchTopicEN>>
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
let arrvResearchTopicObjLst_Cache;
switch (clsvResearchTopicEN.CacheModeId)
{
case "04"://sessionStorage
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvResearchTopicObjLst = vResearchTopic_GetObjLstByJSONObjLst(arrvResearchTopicObjLst_Cache);
return arrvResearchTopicObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vResearchTopic_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvResearchTopicObjLst_Cache;
switch (clsvResearchTopicEN.CacheModeId)
{
case "04"://sessionStorage
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvResearchTopicObjLst_Cache = null;
break;
default:
arrvResearchTopicObjLst_Cache = null;
break;
}
return arrvResearchTopicObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTopicId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vResearchTopic_GetSubObjLst_Cache(objvResearchTopic_Cond: clsvResearchTopicEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
let arrvResearchTopic_Sel: Array < clsvResearchTopicEN > = arrvResearchTopicObjLst_Cache;
if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "") return arrvResearchTopic_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
//console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvResearchTopic_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvResearchTopic_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvResearchTopic_Cond), vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvResearchTopicEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTopicId:关键字列表
 * @returns 对象列表
 **/
export async function vResearchTopic_GetObjLstByTopicIdLstAsync(arrTopicId: Array<string>): Promise<Array<clsvResearchTopicEN>>  
{
const strThisFuncName = "GetObjLstByTopicIdLstAsync";
const strAction = "GetObjLstByTopicIdLst";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param arrstrTopicIdLst:关键字列表
 * @returns 对象列表
*/
export async function vResearchTopic_GetObjLstByTopicIdLst_Cache(arrTopicIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByTopicIdLst_Cache";
try
{
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
const arrvResearchTopic_Sel: Array <clsvResearchTopicEN> = arrvResearchTopicObjLst_Cache.filter(x => arrTopicIdLst.indexOf(x.topicId)>-1);
return arrvResearchTopic_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicIdLst.join(","), vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvResearchTopicEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vResearchTopic_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvResearchTopicEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvResearchTopicEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
if (arrvResearchTopicObjLst_Cache.length == 0) return arrvResearchTopicObjLst_Cache;
let arrvResearchTopic_Sel = arrvResearchTopicObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvResearchTopic_Cond = new clsvResearchTopicEN();
ObjectAssign(objvResearchTopic_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvResearchTopicWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvResearchTopic_Sel.length == 0) return arrvResearchTopic_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvResearchTopic_Sel = arrvResearchTopic_Sel.sort(vResearchTopic_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvResearchTopic_Sel = arrvResearchTopic_Sel.sort(objPagerPara.sortFun);
}
arrvResearchTopic_Sel = arrvResearchTopic_Sel.slice(intStart, intEnd);     
return arrvResearchTopic_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvResearchTopicEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vResearchTopic_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvResearchTopicEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vResearchTopic_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vResearchTopic_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param objstrTopicId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vResearchTopic_IsExistRecord_Cache(objvResearchTopic_Cond: clsvResearchTopicEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
if (arrvResearchTopicObjLst_Cache == null) return false;
let arrvResearchTopic_Sel: Array < clsvResearchTopicEN > = arrvResearchTopicObjLst_Cache;
if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "") return arrvResearchTopic_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
//console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvResearchTopic_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvResearchTopic_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvResearchTopic_Cond), vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param strTopicId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vResearchTopic_IsExist(strTopicId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TopicId": strTopicId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param strTopicId:所给的关键字
 * @returns 对象
*/
export async function vResearchTopic_IsExist_Cache(strTopicId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
if (arrvResearchTopicObjLst_Cache == null) return false;
try
{
const arrvResearchTopic_Sel: Array <clsvResearchTopicEN> = arrvResearchTopicObjLst_Cache.filter(x => x.topicId == strTopicId);
if (arrvResearchTopic_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicId, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTopicId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vResearchTopic_IsExistAsync(strTopicId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTopicId": strTopicId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
export async function vResearchTopic_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vResearchTopic_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vResearchTopic_ConstructorName, strThisFuncName);
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
 * @param objvResearchTopic_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vResearchTopic_GetRecCountByCond_Cache(objvResearchTopic_Cond: clsvResearchTopicEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvResearchTopicObjLst_Cache = await vResearchTopic_GetObjLst_Cache(strid_CurrEduCls);
if (arrvResearchTopicObjLst_Cache == null) return 0;
let arrvResearchTopic_Sel: Array < clsvResearchTopicEN > = arrvResearchTopicObjLst_Cache;
if (objvResearchTopic_Cond.sf_FldComparisonOp == null || objvResearchTopic_Cond.sf_FldComparisonOp == "") return arrvResearchTopic_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvResearchTopic_Cond.sf_FldComparisonOp);
//console.log("clsvResearchTopicWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvResearchTopic_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvResearchTopic_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvResearchTopic_Sel = arrvResearchTopic_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvResearchTopic_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvResearchTopic_Cond), vResearchTopic_ConstructorName, strThisFuncName);
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
export function vResearchTopic_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vResearchTopic_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strid_CurrEduCls);
switch (clsvResearchTopicEN.CacheModeId)
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
export function vResearchTopic_GetJSONStrByObj (pobjvResearchTopicEN: clsvResearchTopicEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvResearchTopicEN);
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
export function vResearchTopic_GetObjLstByJSONStr (strJSON: string): Array<clsvResearchTopicEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvResearchTopicObjLst = new Array<clsvResearchTopicEN>();
if (strJSON === "")
{
return arrvResearchTopicObjLst;
}
try
{
arrvResearchTopicObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvResearchTopicObjLst;
}
return arrvResearchTopicObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvResearchTopicObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vResearchTopic_GetObjLstByJSONObjLst (arrvResearchTopicObjLstS: Array<clsvResearchTopicEN>): Array<clsvResearchTopicEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvResearchTopicObjLst = new Array<clsvResearchTopicEN>();
for (const objInFor of arrvResearchTopicObjLstS) {
const obj1 = vResearchTopic_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvResearchTopicObjLst.push(obj1);
}
return arrvResearchTopicObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vResearchTopic_GetObjByJSONStr (strJSON: string): clsvResearchTopicEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvResearchTopicEN = new clsvResearchTopicEN();
if (strJSON === "")
{
return pobjvResearchTopicEN;
}
try
{
pobjvResearchTopicEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvResearchTopicEN;
}
return pobjvResearchTopicEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vResearchTopic_GetCombineCondition(objvResearchTopic_Cond: clsvResearchTopicEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_TopicId, objvResearchTopic_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_TopicName, objvResearchTopic_Cond.topicName, strComparisonOp_TopicName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_TopicProposePeople) == true)
{
const strComparisonOp_TopicProposePeople:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_TopicProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_TopicProposePeople, objvResearchTopic_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvResearchTopicEN.con_OrderNum, objvResearchTopic_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_UpdDate, objvResearchTopic_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_UpdUser, objvResearchTopic_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_Memo, objvResearchTopic_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_IsSubmit) == true)
{
if (objvResearchTopic_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvResearchTopicEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvResearchTopicEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_UserName, objvResearchTopic_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_id_CurrEduCls, objvResearchTopic_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvResearchTopic_Cond.dicFldComparisonOp, clsvResearchTopicEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvResearchTopic_Cond.dicFldComparisonOp[clsvResearchTopicEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvResearchTopicEN.con_ShareId, objvResearchTopic_Cond.shareId, strComparisonOp_ShareId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvResearchTopicENS:源对象
 * @param objvResearchTopicENT:目标对象
*/
export function vResearchTopic_CopyObjTo(objvResearchTopicENS: clsvResearchTopicEN , objvResearchTopicENT: clsvResearchTopicEN ): void 
{
objvResearchTopicENT.topicId = objvResearchTopicENS.topicId; //主题Id
objvResearchTopicENT.topicName = objvResearchTopicENS.topicName; //栏目主题
objvResearchTopicENT.topicContent = objvResearchTopicENS.topicContent; //主题内容
objvResearchTopicENT.topicProposePeople = objvResearchTopicENS.topicProposePeople; //主题提出人
objvResearchTopicENT.orderNum = objvResearchTopicENS.orderNum; //序号
objvResearchTopicENT.updDate = objvResearchTopicENS.updDate; //修改日期
objvResearchTopicENT.updUser = objvResearchTopicENS.updUser; //修改人
objvResearchTopicENT.memo = objvResearchTopicENS.memo; //备注
objvResearchTopicENT.isSubmit = objvResearchTopicENS.isSubmit; //是否提交
objvResearchTopicENT.userName = objvResearchTopicENS.userName; //用户名
objvResearchTopicENT.id_CurrEduCls = objvResearchTopicENS.id_CurrEduCls; //教学班流水号
objvResearchTopicENT.shareId = objvResearchTopicENS.shareId; //分享Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvResearchTopicENS:源对象
 * @param objvResearchTopicENT:目标对象
*/
export function vResearchTopic_GetObjFromJsonObj(objvResearchTopicENS: clsvResearchTopicEN): clsvResearchTopicEN 
{
 const objvResearchTopicENT: clsvResearchTopicEN = new clsvResearchTopicEN();
ObjectAssign(objvResearchTopicENT, objvResearchTopicENS);
 return objvResearchTopicENT;
}