
 /**
 * 类名:clsObjectiveAttachmentWApi
 * 表名:ObjectiveAttachment(01120614)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:52
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
 * 客观附件表(ObjectiveAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsObjectiveAttachmentEN } from "../../L0_Entity/GraduateEduTopic/clsObjectiveAttachmentEN.js";
import { vObjectiveAttachment_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvObjectiveAttachmentWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const objectiveAttachment_Controller = "ObjectiveAttachmentApi";
 export const objectiveAttachment_ConstructorName = "objectiveAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngObjectiveAttachmentId:关键字
 * @returns 对象
 **/
export async function ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId: number): Promise<clsObjectiveAttachmentEN>  
{
const strThisFuncName = "GetObjByObjectiveAttachmentIdAsync";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByObjectiveAttachmentId";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngObjectiveAttachmentId": lngObjectiveAttachmentId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objObjectiveAttachment = ObjectiveAttachment_GetObjFromJsonObj(returnObj);
return objObjectiveAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param lngObjectiveAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByObjectiveAttachmentId_Cache";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrObjectiveAttachment_Sel: Array <clsObjectiveAttachmentEN> = arrObjectiveAttachmentObjLst_Cache.filter(x => x.objectiveAttachmentId == lngObjectiveAttachmentId);
let objObjectiveAttachment: clsObjectiveAttachmentEN;
if (arrObjectiveAttachment_Sel.length > 0)
{
objObjectiveAttachment = arrObjectiveAttachment_Sel[0];
return objObjectiveAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
if (objObjectiveAttachment != null)
{
ObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls);
return objObjectiveAttachment;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngObjectiveAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage(lngObjectiveAttachmentId: number) {
const strThisFuncName = "GetObjByObjectiveAttachmentId_localStorage";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In GetObjByObjectiveAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, lngObjectiveAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objObjectiveAttachment_Cache: clsObjectiveAttachmentEN = JSON.parse(strTempObj);
return objObjectiveAttachment_Cache;
}
try
{
const objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
if (objObjectiveAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objObjectiveAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objObjectiveAttachment;
}
return objObjectiveAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objObjectiveAttachment:所给的对象
 * @returns 对象
*/
export async function ObjectiveAttachment_UpdateObjInLst_Cache(objObjectiveAttachment: clsObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrObjectiveAttachmentObjLst_Cache.find(x => x.topicObjectiveId == objObjectiveAttachment.topicObjectiveId && x.objectiveAttachmentId == objObjectiveAttachment.objectiveAttachmentId);
if (obj != null)
{
objObjectiveAttachment.objectiveAttachmentId = obj.objectiveAttachmentId;
ObjectAssign( obj, objObjectiveAttachment);
}
else
{
arrObjectiveAttachmentObjLst_Cache.push(objObjectiveAttachment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_func(strInFldName:string , strOutFldName:string , strInValue:number , strid_CurrEduCls_C: string)
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

if (strInFldName != clsObjectiveAttachmentEN.con_ObjectiveAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsObjectiveAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsObjectiveAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngObjectiveAttachmentId = Number(strInValue);
if (lngObjectiveAttachmentId == 0)
{
return "";
}
const objObjectiveAttachment = await ObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId , strid_CurrEduCls_C);
if (objObjectiveAttachment == null) return "";
return objObjectiveAttachment.GetFldValue(strOutFldName).toString();
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
export function ObjectiveAttachment_SortFun_Defa(a:clsObjectiveAttachmentEN , b:clsObjectiveAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.objectiveAttachmentId-b.objectiveAttachmentId;
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
export function ObjectiveAttachment_SortFun_Defa_2Fld(a:clsObjectiveAttachmentEN , b:clsObjectiveAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicObjectiveId == b.topicObjectiveId) return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
else return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
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
export function ObjectiveAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsObjectiveAttachmentEN.con_TopicObjectiveId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.objectiveAttachmentId-b.objectiveAttachmentId;
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
}
case clsObjectiveAttachmentEN.con_FilePath:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsObjectiveAttachmentEN.con_UpdDate:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsObjectiveAttachmentEN.con_UpdUserId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsObjectiveAttachmentEN.con_Memo:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.memo.localeCompare(b.memo);
}
case clsObjectiveAttachmentEN.con_id_CurrEduCls:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${ objectiveAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsObjectiveAttachmentEN.con_TopicObjectiveId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.objectiveAttachmentId-a.objectiveAttachmentId;
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.objectiveAttachmentName.localeCompare(a.objectiveAttachmentName);
}
case clsObjectiveAttachmentEN.con_FilePath:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsObjectiveAttachmentEN.con_UpdDate:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsObjectiveAttachmentEN.con_UpdUserId:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsObjectiveAttachmentEN.con_Memo:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.memo.localeCompare(a.memo);
}
case clsObjectiveAttachmentEN.con_id_CurrEduCls:
return (a: clsObjectiveAttachmentEN, b: clsObjectiveAttachmentEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${ objectiveAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ObjectiveAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsObjectiveAttachmentEN.con_TopicObjectiveId:
return (obj: clsObjectiveAttachmentEN) => {
return obj.topicObjectiveId === value;
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (obj: clsObjectiveAttachmentEN) => {
return obj.objectiveAttachmentId === value;
}
case clsObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (obj: clsObjectiveAttachmentEN) => {
return obj.objectiveAttachmentName === value;
}
case clsObjectiveAttachmentEN.con_FilePath:
return (obj: clsObjectiveAttachmentEN) => {
return obj.filePath === value;
}
case clsObjectiveAttachmentEN.con_UpdDate:
return (obj: clsObjectiveAttachmentEN) => {
return obj.updDate === value;
}
case clsObjectiveAttachmentEN.con_UpdUserId:
return (obj: clsObjectiveAttachmentEN) => {
return obj.updUserId === value;
}
case clsObjectiveAttachmentEN.con_Memo:
return (obj: clsObjectiveAttachmentEN) => {
return obj.memo === value;
}
case clsObjectiveAttachmentEN.con_id_CurrEduCls:
return (obj: clsObjectiveAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ObjectiveAttachment]中不存在！(in ${ objectiveAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ObjectiveAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsObjectiveAttachmentEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objObjectiveAttachment = ObjectiveAttachment_GetObjFromJsonObj(returnObj);
return objObjectiveAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
clsObjectiveAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsObjectiveAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsObjectiveAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrObjectiveAttachmentExObjLst_Cache: Array<clsObjectiveAttachmentEN> = CacheHelper.Get(strKey);
const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
return arrObjectiveAttachmentObjLst_T;
}
try
{
const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrObjectiveAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
clsObjectiveAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsObjectiveAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsObjectiveAttachmentEN.CacheAddiCondition);
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
const arrObjectiveAttachmentExObjLst_Cache: Array<clsObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
return arrObjectiveAttachmentObjLst_T;
}
try
{
const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrObjectiveAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrObjectiveAttachmentObjLst_Cache: Array<clsObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
return arrObjectiveAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function ObjectiveAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
clsObjectiveAttachmentEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsObjectiveAttachmentEN._CurrTabName);
if (IsNullOrEmpty(clsObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsObjectiveAttachmentEN.CacheAddiCondition);
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
const arrObjectiveAttachmentExObjLst_Cache: Array<clsObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
const arrObjectiveAttachmentObjLst_T = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentExObjLst_Cache);
return arrObjectiveAttachmentObjLst_T;
}
try
{
const arrObjectiveAttachmentExObjLst = await ObjectiveAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrObjectiveAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrObjectiveAttachmentObjLst_Cache: Array<clsObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
return arrObjectiveAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsObjectiveAttachmentEN>>
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
let arrObjectiveAttachmentObjLst_Cache;
switch (clsObjectiveAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrObjectiveAttachmentObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(arrObjectiveAttachmentObjLst_Cache);
return arrObjectiveAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ObjectiveAttachment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrObjectiveAttachmentObjLst_Cache;
switch (clsObjectiveAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrObjectiveAttachmentObjLst_Cache = null;
break;
default:
arrObjectiveAttachmentObjLst_Cache = null;
break;
}
return arrObjectiveAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngObjectiveAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ObjectiveAttachment_GetSubObjLst_Cache(objObjectiveAttachment_Cond: clsObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
let arrObjectiveAttachment_Sel: Array < clsObjectiveAttachmentEN > = arrObjectiveAttachmentObjLst_Cache;
if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrObjectiveAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrObjectiveAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objObjectiveAttachment_Cond), objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsObjectiveAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrObjectiveAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync(arrObjectiveAttachmentId: Array<string>): Promise<Array<clsObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLstAsync";
const strAction = "GetObjLstByObjectiveAttachmentIdLst";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrObjectiveAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param arrlngObjectiveAttachmentIdLst:关键字列表
 * @returns 对象列表
*/
export async function ObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache(arrObjectiveAttachmentIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLst_Cache";
try
{
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
const arrObjectiveAttachment_Sel: Array <clsObjectiveAttachmentEN> = arrObjectiveAttachmentObjLst_Cache.filter(x => arrObjectiveAttachmentIdLst.indexOf(x.objectiveAttachmentId)>-1);
return arrObjectiveAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrObjectiveAttachmentIdLst.join(","), objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsObjectiveAttachmentEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function ObjectiveAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjectiveAttachmentObjLst_Cache.length == 0) return arrObjectiveAttachmentObjLst_Cache;
let arrObjectiveAttachment_Sel = arrObjectiveAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objObjectiveAttachment_Cond = new clsObjectiveAttachmentEN();
ObjectAssign(objObjectiveAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsObjectiveAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrObjectiveAttachment_Sel.length == 0) return arrObjectiveAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.sort(ObjectiveAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.sort(objPagerPara.sortFun);
}
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.slice(intStart, intEnd);     
return arrObjectiveAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsObjectiveAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function ObjectiveAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param lngObjectiveAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function ObjectiveAttachment_DelRecordAsync(lngObjectiveAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngObjectiveAttachmentId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngObjectiveAttachmentId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param arrObjectiveAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ObjectiveAttachment_DelObjectiveAttachmentsAsync(arrObjectiveAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelObjectiveAttachmentsAsync";
const strAction = "DelObjectiveAttachments";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrObjectiveAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_DelObjectiveAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelObjectiveAttachmentsByCondAsync";
const strAction = "DelObjectiveAttachmentsByCond";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ObjectiveAttachment_AddNewRecordAsync(objObjectiveAttachmentEN: clsObjectiveAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objObjectiveAttachmentEN);
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objObjectiveAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ObjectiveAttachment_AddNewRecordWithReturnKeyAsync(objObjectiveAttachmentEN: clsObjectiveAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objObjectiveAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ObjectiveAttachment_AddNewRecordWithReturnKey(objObjectiveAttachmentEN: clsObjectiveAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objObjectiveAttachmentEN.objectiveAttachmentId === null || objObjectiveAttachmentEN.objectiveAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objObjectiveAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ObjectiveAttachment_UpdateRecordAsync(objObjectiveAttachmentEN: clsObjectiveAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objObjectiveAttachmentEN.sf_UpdFldSetStr === undefined || objObjectiveAttachmentEN.sf_UpdFldSetStr === null || objObjectiveAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objObjectiveAttachmentEN.objectiveAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objObjectiveAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ObjectiveAttachment_UpdateWithConditionAsync(objObjectiveAttachmentEN: clsObjectiveAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objObjectiveAttachmentEN.sf_UpdFldSetStr === undefined || objObjectiveAttachmentEN.sf_UpdFldSetStr === null || objObjectiveAttachmentEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objObjectiveAttachmentEN.objectiveAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
objObjectiveAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objObjectiveAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objlngObjectiveAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ObjectiveAttachment_IsExistRecord_Cache(objObjectiveAttachment_Cond: clsObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjectiveAttachmentObjLst_Cache == null) return false;
let arrObjectiveAttachment_Sel: Array < clsObjectiveAttachmentEN > = arrObjectiveAttachmentObjLst_Cache;
if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrObjectiveAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrObjectiveAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objObjectiveAttachment_Cond), objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param lngObjectiveAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ObjectiveAttachment_IsExist(lngObjectiveAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ObjectiveAttachmentId": lngObjectiveAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param lngObjectiveAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ObjectiveAttachment_IsExist_Cache(lngObjectiveAttachmentId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjectiveAttachmentObjLst_Cache == null) return false;
try
{
const arrObjectiveAttachment_Sel: Array <clsObjectiveAttachmentEN> = arrObjectiveAttachmentObjLst_Cache.filter(x => x.objectiveAttachmentId == lngObjectiveAttachmentId);
if (arrObjectiveAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngObjectiveAttachmentId, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngObjectiveAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ObjectiveAttachment_IsExistAsync(lngObjectiveAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngObjectiveAttachmentId": lngObjectiveAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objObjectiveAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function ObjectiveAttachment_GetRecCountByCond_Cache(objObjectiveAttachment_Cond: clsObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrObjectiveAttachmentObjLst_Cache = await ObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrObjectiveAttachmentObjLst_Cache == null) return 0;
let arrObjectiveAttachment_Sel: Array < clsObjectiveAttachmentEN > = arrObjectiveAttachmentObjLst_Cache;
if (objObjectiveAttachment_Cond.sf_FldComparisonOp == null || objObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrObjectiveAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrObjectiveAttachment_Sel = arrObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrObjectiveAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objObjectiveAttachment_Cond), objectiveAttachment_ConstructorName, strThisFuncName);
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
export async function ObjectiveAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(objectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, objectiveAttachment_ConstructorName, strThisFuncName);
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
export function ObjectiveAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ObjectiveAttachment_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsObjectiveAttachmentWApi.ReFreshCache)");
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
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsObjectiveAttachmentEN.CacheModeId)
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
vObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function ObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsObjectiveAttachmentEN.CacheModeId)
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
export function ObjectiveAttachment_CheckPropertyNew(pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.topicObjectiveId) === true )
{
 throw new Error("(errid:Watl000058)字段[客观Id]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.topicObjectiveId) == false && GetStrLen(pobjObjectiveAttachmentEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000059)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.topicObjectiveId)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && GetStrLen(pobjObjectiveAttachmentEN.objectiveAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(objectiveAttachmentName)]的长度不能超过200(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.objectiveAttachmentName)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.filePath) == false && GetStrLen(pobjObjectiveAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.filePath)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updDate) == false && GetStrLen(pobjObjectiveAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updDate)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updUserId) == false && GetStrLen(pobjObjectiveAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updUserId)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.memo) == false && GetStrLen(pobjObjectiveAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.memo)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjObjectiveAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.id_CurrEduCls)(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.topicObjectiveId) == false && undefined !== pobjObjectiveAttachmentEN.topicObjectiveId && tzDataType.isString(pobjObjectiveAttachmentEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观Id(topicObjectiveId)]的值:[$(pobjObjectiveAttachmentEN.topicObjectiveId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (null != pobjObjectiveAttachmentEN.objectiveAttachmentId && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentId && tzDataType.isNumber(pobjObjectiveAttachmentEN.objectiveAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[客观附件Id(objectiveAttachmentId)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentId)], 非法，应该为数值型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentName && tzDataType.isString(pobjObjectiveAttachmentEN.objectiveAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(objectiveAttachmentName)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentName)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.filePath) == false && undefined !== pobjObjectiveAttachmentEN.filePath && tzDataType.isString(pobjObjectiveAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjObjectiveAttachmentEN.filePath)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updDate) == false && undefined !== pobjObjectiveAttachmentEN.updDate && tzDataType.isString(pobjObjectiveAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjObjectiveAttachmentEN.updDate)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updUserId) == false && undefined !== pobjObjectiveAttachmentEN.updUserId && tzDataType.isString(pobjObjectiveAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjObjectiveAttachmentEN.updUserId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.memo) == false && undefined !== pobjObjectiveAttachmentEN.memo && tzDataType.isString(pobjObjectiveAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjObjectiveAttachmentEN.memo)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && undefined !== pobjObjectiveAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjObjectiveAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjObjectiveAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjObjectiveAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ObjectiveAttachment_CheckProperty4Update (pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.topicObjectiveId) == false && GetStrLen(pobjObjectiveAttachmentEN.topicObjectiveId) > 8)
{
 throw new Error("(errid:Watl000062)字段[客观Id(topicObjectiveId)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.topicObjectiveId)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && GetStrLen(pobjObjectiveAttachmentEN.objectiveAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(objectiveAttachmentName)]的长度不能超过200(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.objectiveAttachmentName)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.filePath) == false && GetStrLen(pobjObjectiveAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.filePath)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updDate) == false && GetStrLen(pobjObjectiveAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updDate)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updUserId) == false && GetStrLen(pobjObjectiveAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.updUserId)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.memo) == false && GetStrLen(pobjObjectiveAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.memo)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjObjectiveAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 客观附件表(ObjectiveAttachment))!值:$(pobjObjectiveAttachmentEN.id_CurrEduCls)(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.topicObjectiveId) == false && undefined !== pobjObjectiveAttachmentEN.topicObjectiveId && tzDataType.isString(pobjObjectiveAttachmentEN.topicObjectiveId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观Id(topicObjectiveId)]的值:[$(pobjObjectiveAttachmentEN.topicObjectiveId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (null != pobjObjectiveAttachmentEN.objectiveAttachmentId && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentId && tzDataType.isNumber(pobjObjectiveAttachmentEN.objectiveAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[客观附件Id(objectiveAttachmentId)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentId)], 非法，应该为数值型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.objectiveAttachmentName) == false && undefined !== pobjObjectiveAttachmentEN.objectiveAttachmentName && tzDataType.isString(pobjObjectiveAttachmentEN.objectiveAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(objectiveAttachmentName)]的值:[$(pobjObjectiveAttachmentEN.objectiveAttachmentName)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.filePath) == false && undefined !== pobjObjectiveAttachmentEN.filePath && tzDataType.isString(pobjObjectiveAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjObjectiveAttachmentEN.filePath)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updDate) == false && undefined !== pobjObjectiveAttachmentEN.updDate && tzDataType.isString(pobjObjectiveAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjObjectiveAttachmentEN.updDate)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.updUserId) == false && undefined !== pobjObjectiveAttachmentEN.updUserId && tzDataType.isString(pobjObjectiveAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjObjectiveAttachmentEN.updUserId)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.memo) == false && undefined !== pobjObjectiveAttachmentEN.memo && tzDataType.isString(pobjObjectiveAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjObjectiveAttachmentEN.memo)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjObjectiveAttachmentEN.id_CurrEduCls) == false && undefined !== pobjObjectiveAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjObjectiveAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjObjectiveAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 客观附件表(ObjectiveAttachment))!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjObjectiveAttachmentEN.objectiveAttachmentId 
 || pobjObjectiveAttachmentEN.objectiveAttachmentId != null && pobjObjectiveAttachmentEN.objectiveAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[客观附件Id]不能为空(In 客观附件表)!(clsObjectiveAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjObjectiveAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ObjectiveAttachment_GetJSONStrByObj (pobjObjectiveAttachmentEN: clsObjectiveAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjObjectiveAttachmentEN.sf_UpdFldSetStr = pobjObjectiveAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjObjectiveAttachmentEN);
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
export function ObjectiveAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsObjectiveAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrObjectiveAttachmentObjLst = new Array<clsObjectiveAttachmentEN>();
if (strJSON === "")
{
return arrObjectiveAttachmentObjLst;
}
try
{
arrObjectiveAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrObjectiveAttachmentObjLst;
}
return arrObjectiveAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrObjectiveAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ObjectiveAttachment_GetObjLstByJSONObjLst (arrObjectiveAttachmentObjLstS: Array<clsObjectiveAttachmentEN>): Array<clsObjectiveAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrObjectiveAttachmentObjLst = new Array<clsObjectiveAttachmentEN>();
for (const objInFor of arrObjectiveAttachmentObjLstS) {
const obj1 = ObjectiveAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrObjectiveAttachmentObjLst.push(obj1);
}
return arrObjectiveAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ObjectiveAttachment_GetObjByJSONStr (strJSON: string): clsObjectiveAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjObjectiveAttachmentEN = new clsObjectiveAttachmentEN();
if (strJSON === "")
{
return pobjObjectiveAttachmentEN;
}
try
{
pobjObjectiveAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjObjectiveAttachmentEN;
}
return pobjObjectiveAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ObjectiveAttachment_GetCombineCondition(objObjectiveAttachment_Cond: clsObjectiveAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_TopicObjectiveId, objObjectiveAttachment_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_ObjectiveAttachmentId) == true)
{
const strComparisonOp_ObjectiveAttachmentId:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_ObjectiveAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsObjectiveAttachmentEN.con_ObjectiveAttachmentId, objObjectiveAttachment_Cond.objectiveAttachmentId, strComparisonOp_ObjectiveAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_ObjectiveAttachmentName) == true)
{
const strComparisonOp_ObjectiveAttachmentName:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_ObjectiveAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_ObjectiveAttachmentName, objObjectiveAttachment_Cond.objectiveAttachmentName, strComparisonOp_ObjectiveAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_FilePath, objObjectiveAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_UpdDate, objObjectiveAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_UpdUserId, objObjectiveAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_Memo, objObjectiveAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objObjectiveAttachment_Cond.dicFldComparisonOp, clsObjectiveAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objObjectiveAttachment_Cond.dicFldComparisonOp[clsObjectiveAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsObjectiveAttachmentEN.con_id_CurrEduCls, objObjectiveAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ObjectiveAttachment(客观附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
 * @param lngObjectiveAttachmentId: 客观附件Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ObjectiveAttachment_GetUniCondStr_TopicObjectiveId_ObjectiveAttachmentId(objObjectiveAttachmentEN: clsObjectiveAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TopicObjectiveId = '{0}'", objObjectiveAttachmentEN.topicObjectiveId);
 strWhereCond +=  Format(" and ObjectiveAttachmentId = '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ObjectiveAttachment(客观附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTopicObjectiveId: 客观Id(要求唯一的字段)
 * @param lngObjectiveAttachmentId: 客观附件Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ObjectiveAttachment_GetUniCondStr4Update_TopicObjectiveId_ObjectiveAttachmentId(objObjectiveAttachmentEN: clsObjectiveAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ObjectiveAttachmentId <> '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
 strWhereCond +=  Format(" and TopicObjectiveId = '{0}'", objObjectiveAttachmentEN.topicObjectiveId);
 strWhereCond +=  Format(" and ObjectiveAttachmentId = '{0}'", objObjectiveAttachmentEN.objectiveAttachmentId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objObjectiveAttachmentENS:源对象
 * @param objObjectiveAttachmentENT:目标对象
*/
export function ObjectiveAttachment_CopyObjTo(objObjectiveAttachmentENS: clsObjectiveAttachmentEN , objObjectiveAttachmentENT: clsObjectiveAttachmentEN ): void 
{
objObjectiveAttachmentENT.topicObjectiveId = objObjectiveAttachmentENS.topicObjectiveId; //客观Id
objObjectiveAttachmentENT.objectiveAttachmentId = objObjectiveAttachmentENS.objectiveAttachmentId; //客观附件Id
objObjectiveAttachmentENT.objectiveAttachmentName = objObjectiveAttachmentENS.objectiveAttachmentName; //附件名称
objObjectiveAttachmentENT.filePath = objObjectiveAttachmentENS.filePath; //文件路径
objObjectiveAttachmentENT.updDate = objObjectiveAttachmentENS.updDate; //修改日期
objObjectiveAttachmentENT.updUserId = objObjectiveAttachmentENS.updUserId; //修改用户Id
objObjectiveAttachmentENT.memo = objObjectiveAttachmentENS.memo; //备注
objObjectiveAttachmentENT.id_CurrEduCls = objObjectiveAttachmentENS.id_CurrEduCls; //教学班流水号
objObjectiveAttachmentENT.sf_UpdFldSetStr = objObjectiveAttachmentENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objObjectiveAttachmentENS:源对象
 * @param objObjectiveAttachmentENT:目标对象
*/
export function ObjectiveAttachment_GetObjFromJsonObj(objObjectiveAttachmentENS: clsObjectiveAttachmentEN): clsObjectiveAttachmentEN 
{
 const objObjectiveAttachmentENT: clsObjectiveAttachmentEN = new clsObjectiveAttachmentEN();
ObjectAssign(objObjectiveAttachmentENT, objObjectiveAttachmentENS);
 return objObjectiveAttachmentENT;
}