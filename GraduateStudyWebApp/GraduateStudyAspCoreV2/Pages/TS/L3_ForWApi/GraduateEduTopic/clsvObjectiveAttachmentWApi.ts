
 /**
 * 类名:clsvObjectiveAttachmentWApi
 * 表名:vObjectiveAttachment(01120618)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:44:46
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
 * vObjectiveAttachment(vObjectiveAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvObjectiveAttachmentEN } from "../../L0_Entity/GraduateEduTopic/clsvObjectiveAttachmentEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vObjectiveAttachment_Controller = "vObjectiveAttachmentApi";
 export const vObjectiveAttachment_ConstructorName = "vObjectiveAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngObjectiveAttachmentId:关键字
 * @returns 对象
 **/
export async function vObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId: number): Promise<clsvObjectiveAttachmentEN|null>  
{
const strThisFuncName = "GetObjByObjectiveAttachmentIdAsync";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In clsvObjectiveAttachmentWApi.GetObjByObjectiveAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByObjectiveAttachmentId";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvObjectiveAttachment = vObjectiveAttachment_GetObjFromJsonObj(returnObj);
return objvObjectiveAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByObjectiveAttachmentId_Cache";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In clsvObjectiveAttachmentWApi.GetObjByObjectiveAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvObjectiveAttachment_Sel: Array <clsvObjectiveAttachmentEN> = arrvObjectiveAttachmentObjLst_Cache.filter(x => 
 x.objectiveAttachmentId == lngObjectiveAttachmentId );
let objvObjectiveAttachment: clsvObjectiveAttachmentEN;
if (arrvObjectiveAttachment_Sel.length > 0)
{
objvObjectiveAttachment = arrvObjectiveAttachment_Sel[0];
return objvObjectiveAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvObjectiveAttachment_Const = await vObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
if (objvObjectiveAttachment_Const != null)
{
vObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls);
return objvObjectiveAttachment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjByObjectiveAttachmentId_localStorage(lngObjectiveAttachmentId: number) {
const strThisFuncName = "GetObjByObjectiveAttachmentId_localStorage";

if (lngObjectiveAttachmentId == 0)
{
  const strMsg = Format("参数:[lngObjectiveAttachmentId]不能为空！(In clsvObjectiveAttachmentWApi.GetObjByObjectiveAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, lngObjectiveAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvObjectiveAttachment_Cache: clsvObjectiveAttachmentEN = JSON.parse(strTempObj);
return objvObjectiveAttachment_Cache;
}
try
{
const objvObjectiveAttachment = await vObjectiveAttachment_GetObjByObjectiveAttachmentIdAsync(lngObjectiveAttachmentId);
if (objvObjectiveAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objvObjectiveAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvObjectiveAttachment;
}
return objvObjectiveAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngObjectiveAttachmentId, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vObjectiveAttachment_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvObjectiveAttachmentWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvObjectiveAttachmentWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvObjectiveAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvObjectiveAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngObjectiveAttachmentId = Number(strInValue);
if (lngObjectiveAttachmentId == 0)
{
return "";
}
const objvObjectiveAttachment = await vObjectiveAttachment_GetObjByObjectiveAttachmentId_Cache(lngObjectiveAttachmentId , strid_CurrEduCls_C);
if (objvObjectiveAttachment == null) return "";
if (objvObjectiveAttachment.GetFldValue(strOutFldName) == null) return "";
return objvObjectiveAttachment.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vObjectiveAttachment_SortFun_Defa(a:clsvObjectiveAttachmentEN , b:clsvObjectiveAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.objectiveAttachmentId-b.objectiveAttachmentId;
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vObjectiveAttachment_SortFun_Defa_2Fld(a:clsvObjectiveAttachmentEN , b:clsvObjectiveAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicObjectiveId == b.topicObjectiveId) return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
else return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vObjectiveAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvObjectiveAttachmentEN.con_TopicObjectiveId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return a.objectiveAttachmentId-b.objectiveAttachmentId;
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.objectiveAttachmentName == null) return -1;
if (b.objectiveAttachmentName == null) return 1;
return a.objectiveAttachmentName.localeCompare(b.objectiveAttachmentName);
}
case clsvObjectiveAttachmentEN.con_FilePath:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsvObjectiveAttachmentEN.con_UpdDate:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvObjectiveAttachmentEN.con_UpdUserId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.updUserId == null) return -1;
if (b.updUserId == null) return 1;
return a.updUserId.localeCompare(b.updUserId);
}
case clsvObjectiveAttachmentEN.con_Memo:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvObjectiveAttachmentEN.con_ObjectiveName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.objectiveName == null) return -1;
if (b.objectiveName == null) return 1;
return a.objectiveName.localeCompare(b.objectiveName);
}
case clsvObjectiveAttachmentEN.con_ObjectiveContent:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.objectiveContent == null) return -1;
if (b.objectiveContent == null) return 1;
return a.objectiveContent.localeCompare(b.objectiveContent);
}
case clsvObjectiveAttachmentEN.con_ObjectiveType:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.objectiveType == null) return -1;
if (b.objectiveType == null) return 1;
return a.objectiveType.localeCompare(b.objectiveType);
}
case clsvObjectiveAttachmentEN.con_ObjectiveTypeName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.objectiveTypeName == null) return -1;
if (b.objectiveTypeName == null) return 1;
return a.objectiveTypeName.localeCompare(b.objectiveTypeName);
}
case clsvObjectiveAttachmentEN.con_Conclusion:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.conclusion == null) return -1;
if (b.conclusion == null) return 1;
return a.conclusion.localeCompare(b.conclusion);
}
case clsvObjectiveAttachmentEN.con_id_CurrEduCls:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vObjectiveAttachment]中不存在！(in ${ vObjectiveAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvObjectiveAttachmentEN.con_TopicObjectiveId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return b.objectiveAttachmentId-a.objectiveAttachmentId;
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.objectiveAttachmentName == null) return -1;
if (a.objectiveAttachmentName == null) return 1;
return b.objectiveAttachmentName.localeCompare(a.objectiveAttachmentName);
}
case clsvObjectiveAttachmentEN.con_FilePath:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsvObjectiveAttachmentEN.con_UpdDate:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvObjectiveAttachmentEN.con_UpdUserId:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.updUserId == null) return -1;
if (a.updUserId == null) return 1;
return b.updUserId.localeCompare(a.updUserId);
}
case clsvObjectiveAttachmentEN.con_Memo:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvObjectiveAttachmentEN.con_ObjectiveName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.objectiveName == null) return -1;
if (a.objectiveName == null) return 1;
return b.objectiveName.localeCompare(a.objectiveName);
}
case clsvObjectiveAttachmentEN.con_ObjectiveContent:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.objectiveContent == null) return -1;
if (a.objectiveContent == null) return 1;
return b.objectiveContent.localeCompare(a.objectiveContent);
}
case clsvObjectiveAttachmentEN.con_ObjectiveType:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.objectiveType == null) return -1;
if (a.objectiveType == null) return 1;
return b.objectiveType.localeCompare(a.objectiveType);
}
case clsvObjectiveAttachmentEN.con_ObjectiveTypeName:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.objectiveTypeName == null) return -1;
if (a.objectiveTypeName == null) return 1;
return b.objectiveTypeName.localeCompare(a.objectiveTypeName);
}
case clsvObjectiveAttachmentEN.con_Conclusion:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.conclusion == null) return -1;
if (a.conclusion == null) return 1;
return b.conclusion.localeCompare(a.conclusion);
}
case clsvObjectiveAttachmentEN.con_id_CurrEduCls:
return (a: clsvObjectiveAttachmentEN, b: clsvObjectiveAttachmentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vObjectiveAttachment]中不存在！(in ${ vObjectiveAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vObjectiveAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvObjectiveAttachmentEN.con_TopicObjectiveId:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.topicObjectiveId === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveAttachmentId === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveAttachmentName === value;
}
case clsvObjectiveAttachmentEN.con_FilePath:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.filePath === value;
}
case clsvObjectiveAttachmentEN.con_UpdDate:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.updDate === value;
}
case clsvObjectiveAttachmentEN.con_UpdUserId:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.updUserId === value;
}
case clsvObjectiveAttachmentEN.con_Memo:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.memo === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveName:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveName === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveContent:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveContent === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveType:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveType === value;
}
case clsvObjectiveAttachmentEN.con_ObjectiveTypeName:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.objectiveTypeName === value;
}
case clsvObjectiveAttachmentEN.con_Conclusion:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.conclusion === value;
}
case clsvObjectiveAttachmentEN.con_id_CurrEduCls:
return (obj: clsvObjectiveAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vObjectiveAttachment]中不存在！(in ${ vObjectiveAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function vObjectiveAttachment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvObjectiveAttachmentWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvObjectiveAttachmentWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrvObjectiveAttachment = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvObjectiveAttachment == null) return [];
let arrvObjectiveAttachment_Sel = arrvObjectiveAttachment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvObjectiveAttachment_Sel.length == 0) return [];
return arrvObjectiveAttachment_Sel.map(x=>x.objectiveAttachmentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vObjectiveAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsvObjectiveAttachmentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvObjectiveAttachment = vObjectiveAttachment_GetObjFromJsonObj(returnObj);
return objvObjectiveAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvObjectiveAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvObjectiveAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvObjectiveAttachmentExObjLst_Cache: Array<clsvObjectiveAttachmentEN> = CacheHelper.Get(strKey);
const arrvObjectiveAttachmentObjLst_T = vObjectiveAttachment_GetObjLstByJSONObjLst(arrvObjectiveAttachmentExObjLst_Cache);
return arrvObjectiveAttachmentObjLst_T;
}
try
{
const arrvObjectiveAttachmentExObjLst = await vObjectiveAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvObjectiveAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrvObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvObjectiveAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvObjectiveAttachmentEN.CacheAddiCondition);
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
const arrvObjectiveAttachmentExObjLst_Cache: Array<clsvObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
const arrvObjectiveAttachmentObjLst_T = vObjectiveAttachment_GetObjLstByJSONObjLst(arrvObjectiveAttachmentExObjLst_Cache);
return arrvObjectiveAttachmentObjLst_T;
}
try
{
const arrvObjectiveAttachmentExObjLst = await vObjectiveAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvObjectiveAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrvObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvObjectiveAttachmentObjLst_Cache: Array<clsvObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
return arrvObjectiveAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vObjectiveAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsvObjectiveAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvObjectiveAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvObjectiveAttachmentEN.CacheAddiCondition);
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
const arrvObjectiveAttachmentExObjLst_Cache: Array<clsvObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
const arrvObjectiveAttachmentObjLst_T = vObjectiveAttachment_GetObjLstByJSONObjLst(arrvObjectiveAttachmentExObjLst_Cache);
return arrvObjectiveAttachmentObjLst_T;
}
try
{
const arrvObjectiveAttachmentExObjLst = await vObjectiveAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvObjectiveAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvObjectiveAttachmentExObjLst.length);
console.log(strInfo);
return arrvObjectiveAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvObjectiveAttachmentObjLst_Cache: Array<clsvObjectiveAttachmentEN> = JSON.parse(strTempObjLst);
return arrvObjectiveAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvObjectiveAttachmentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvObjectiveAttachmentWApi.vObjectiveAttachment_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvObjectiveAttachmentWApi.vObjectiveAttachment_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvObjectiveAttachmentObjLst_Cache;
switch (clsvObjectiveAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvObjectiveAttachmentObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(arrvObjectiveAttachmentObjLst_Cache);
return arrvObjectiveAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vObjectiveAttachment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvObjectiveAttachmentObjLst_Cache;
switch (clsvObjectiveAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvObjectiveAttachmentObjLst_Cache = null;
break;
default:
arrvObjectiveAttachmentObjLst_Cache = null;
break;
}
return arrvObjectiveAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngObjectiveAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vObjectiveAttachment_GetSubObjLst_Cache(objvObjectiveAttachment_Cond: clsvObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
let arrvObjectiveAttachment_Sel: Array < clsvObjectiveAttachmentEN > = arrvObjectiveAttachmentObjLst_Cache;
if (objvObjectiveAttachment_Cond.sf_FldComparisonOp == null || objvObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrvObjectiveAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsvObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvObjectiveAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvObjectiveAttachment_Cond), vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvObjectiveAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrObjectiveAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function vObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLstAsync(arrObjectiveAttachmentId: Array<string>): Promise<Array<clsvObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLstAsync";
const strAction = "GetObjLstByObjectiveAttachmentIdLst";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrObjectiveAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLstByObjectiveAttachmentIdLst_Cache(arrObjectiveAttachmentIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByObjectiveAttachmentIdLst_Cache";
try
{
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
const arrvObjectiveAttachment_Sel: Array <clsvObjectiveAttachmentEN> = arrvObjectiveAttachmentObjLst_Cache.filter(x => arrObjectiveAttachmentIdLst.indexOf(x.objectiveAttachmentId)>-1);
return arrvObjectiveAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrObjectiveAttachmentIdLst.join(","), vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vObjectiveAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvObjectiveAttachmentEN>();
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvObjectiveAttachmentObjLst_Cache.length == 0) return arrvObjectiveAttachmentObjLst_Cache;
let arrvObjectiveAttachment_Sel = arrvObjectiveAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvObjectiveAttachment_Cond = new clsvObjectiveAttachmentEN();
ObjectAssign(objvObjectiveAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvObjectiveAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvObjectiveAttachment_Sel.length == 0) return arrvObjectiveAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.sort(vObjectiveAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.sort(objPagerPara.sortFun);
}
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.slice(intStart, intEnd);     
return arrvObjectiveAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvObjectiveAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vObjectiveAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvObjectiveAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvObjectiveAttachmentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vObjectiveAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_IsExistRecord_Cache(objvObjectiveAttachment_Cond: clsvObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvObjectiveAttachmentObjLst_Cache == null) return false;
let arrvObjectiveAttachment_Sel: Array < clsvObjectiveAttachmentEN > = arrvObjectiveAttachmentObjLst_Cache;
if (objvObjectiveAttachment_Cond.sf_FldComparisonOp == null || objvObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrvObjectiveAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsvObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvObjectiveAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvObjectiveAttachment_Cond), vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_IsExist(lngObjectiveAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_IsExist_Cache(lngObjectiveAttachmentId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvObjectiveAttachmentObjLst_Cache == null) return false;
try
{
const arrvObjectiveAttachment_Sel: Array <clsvObjectiveAttachmentEN> = arrvObjectiveAttachmentObjLst_Cache.filter(x => x.objectiveAttachmentId == lngObjectiveAttachmentId);
if (arrvObjectiveAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngObjectiveAttachmentId, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_IsExistAsync(lngObjectiveAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export async function vObjectiveAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vObjectiveAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vObjectiveAttachment_ConstructorName, strThisFuncName);
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
 * @param objvObjectiveAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vObjectiveAttachment_GetRecCountByCond_Cache(objvObjectiveAttachment_Cond: clsvObjectiveAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvObjectiveAttachmentObjLst_Cache = await vObjectiveAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrvObjectiveAttachmentObjLst_Cache == null) return 0;
let arrvObjectiveAttachment_Sel: Array < clsvObjectiveAttachmentEN > = arrvObjectiveAttachmentObjLst_Cache;
if (objvObjectiveAttachment_Cond.sf_FldComparisonOp == null || objvObjectiveAttachment_Cond.sf_FldComparisonOp == "") return arrvObjectiveAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvObjectiveAttachment_Cond.sf_FldComparisonOp);
//console.log("clsvObjectiveAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvObjectiveAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvObjectiveAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvObjectiveAttachment_Sel = arrvObjectiveAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvObjectiveAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvObjectiveAttachment_Cond), vObjectiveAttachment_ConstructorName, strThisFuncName);
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
export function vObjectiveAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vObjectiveAttachment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsvObjectiveAttachmentEN.CacheModeId)
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vObjectiveAttachment_GetJSONStrByObj (pobjvObjectiveAttachmentEN: clsvObjectiveAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvObjectiveAttachmentEN);
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function vObjectiveAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsvObjectiveAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvObjectiveAttachmentObjLst = new Array<clsvObjectiveAttachmentEN>();
if (strJSON === "")
{
return arrvObjectiveAttachmentObjLst;
}
try
{
arrvObjectiveAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvObjectiveAttachmentObjLst;
}
return arrvObjectiveAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvObjectiveAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vObjectiveAttachment_GetObjLstByJSONObjLst (arrvObjectiveAttachmentObjLstS: Array<clsvObjectiveAttachmentEN>): Array<clsvObjectiveAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvObjectiveAttachmentObjLst = new Array<clsvObjectiveAttachmentEN>();
for (const objInFor of arrvObjectiveAttachmentObjLstS) {
const obj1 = vObjectiveAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvObjectiveAttachmentObjLst.push(obj1);
}
return arrvObjectiveAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vObjectiveAttachment_GetObjByJSONStr (strJSON: string): clsvObjectiveAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
if (strJSON === "")
{
return pobjvObjectiveAttachmentEN;
}
try
{
pobjvObjectiveAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvObjectiveAttachmentEN;
}
return pobjvObjectiveAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vObjectiveAttachment_GetCombineCondition(objvObjectiveAttachment_Cond: clsvObjectiveAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_TopicObjectiveId, objvObjectiveAttachment_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId) == true)
{
const strComparisonOp_ObjectiveAttachmentId:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsvObjectiveAttachmentEN.con_ObjectiveAttachmentId, objvObjectiveAttachment_Cond.objectiveAttachmentId, strComparisonOp_ObjectiveAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName) == true)
{
const strComparisonOp_ObjectiveAttachmentName:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_ObjectiveAttachmentName, objvObjectiveAttachment_Cond.objectiveAttachmentName, strComparisonOp_ObjectiveAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_FilePath, objvObjectiveAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_UpdDate, objvObjectiveAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_UpdUserId, objvObjectiveAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_Memo, objvObjectiveAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_ObjectiveName) == true)
{
const strComparisonOp_ObjectiveName:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_ObjectiveName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_ObjectiveName, objvObjectiveAttachment_Cond.objectiveName, strComparisonOp_ObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_ObjectiveType) == true)
{
const strComparisonOp_ObjectiveType:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_ObjectiveType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_ObjectiveType, objvObjectiveAttachment_Cond.objectiveType, strComparisonOp_ObjectiveType);
}
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_ObjectiveTypeName) == true)
{
const strComparisonOp_ObjectiveTypeName:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_ObjectiveTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_ObjectiveTypeName, objvObjectiveAttachment_Cond.objectiveTypeName, strComparisonOp_ObjectiveTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvObjectiveAttachment_Cond.dicFldComparisonOp, clsvObjectiveAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvObjectiveAttachment_Cond.dicFldComparisonOp[clsvObjectiveAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvObjectiveAttachmentEN.con_id_CurrEduCls, objvObjectiveAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvObjectiveAttachmentENS:源对象
 * @param objvObjectiveAttachmentENT:目标对象
*/
export function vObjectiveAttachment_CopyObjTo(objvObjectiveAttachmentENS: clsvObjectiveAttachmentEN , objvObjectiveAttachmentENT: clsvObjectiveAttachmentEN ): void 
{
objvObjectiveAttachmentENT.topicObjectiveId = objvObjectiveAttachmentENS.topicObjectiveId; //客观Id
objvObjectiveAttachmentENT.objectiveAttachmentId = objvObjectiveAttachmentENS.objectiveAttachmentId; //客观附件Id
objvObjectiveAttachmentENT.objectiveAttachmentName = objvObjectiveAttachmentENS.objectiveAttachmentName; //附件名称
objvObjectiveAttachmentENT.filePath = objvObjectiveAttachmentENS.filePath; //文件路径
objvObjectiveAttachmentENT.updDate = objvObjectiveAttachmentENS.updDate; //修改日期
objvObjectiveAttachmentENT.updUserId = objvObjectiveAttachmentENS.updUserId; //修改用户Id
objvObjectiveAttachmentENT.memo = objvObjectiveAttachmentENS.memo; //备注
objvObjectiveAttachmentENT.objectiveName = objvObjectiveAttachmentENS.objectiveName; //客观名称
objvObjectiveAttachmentENT.objectiveContent = objvObjectiveAttachmentENS.objectiveContent; //客观内容
objvObjectiveAttachmentENT.objectiveType = objvObjectiveAttachmentENS.objectiveType; //客观类型
objvObjectiveAttachmentENT.objectiveTypeName = objvObjectiveAttachmentENS.objectiveTypeName; //ObjectiveTypeName
objvObjectiveAttachmentENT.conclusion = objvObjectiveAttachmentENS.conclusion; //结论
objvObjectiveAttachmentENT.id_CurrEduCls = objvObjectiveAttachmentENS.id_CurrEduCls; //教学班流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvObjectiveAttachmentENS:源对象
 * @param objvObjectiveAttachmentENT:目标对象
*/
export function vObjectiveAttachment_GetObjFromJsonObj(objvObjectiveAttachmentENS: clsvObjectiveAttachmentEN): clsvObjectiveAttachmentEN 
{
 const objvObjectiveAttachmentENT: clsvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
ObjectAssign(objvObjectiveAttachmentENT, objvObjectiveAttachmentENS);
 return objvObjectiveAttachmentENT;
}