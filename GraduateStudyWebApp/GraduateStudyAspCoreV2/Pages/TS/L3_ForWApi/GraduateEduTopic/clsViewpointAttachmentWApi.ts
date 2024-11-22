
 /**
 * 类名:clsViewpointAttachmentWApi
 * 表名:ViewpointAttachment(01120591)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:16
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
 * 观点附件表(ViewpointAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsViewpointAttachmentEN } from "../../L0_Entity/GraduateEduTopic/clsViewpointAttachmentEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const viewpointAttachment_Controller = "ViewpointAttachmentApi";
 export const viewpointAttachment_ConstructorName = "viewpointAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngViewpointAttachmentId:关键字
 * @returns 对象
 **/
export async function ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId: number): Promise<clsViewpointAttachmentEN|null>  
{
const strThisFuncName = "GetObjByViewpointAttachmentIdAsync";

if (lngViewpointAttachmentId == 0)
{
  const strMsg = Format("参数:[lngViewpointAttachmentId]不能为空！(In clsViewpointAttachmentWApi.GetObjByViewpointAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByViewpointAttachmentId";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngViewpointAttachmentId": lngViewpointAttachmentId,
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
const objViewpointAttachment = ViewpointAttachment_GetObjFromJsonObj(returnObj);
return objViewpointAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param lngViewpointAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ViewpointAttachment_GetObjByViewpointAttachmentId_Cache(lngViewpointAttachmentId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByViewpointAttachmentId_Cache";

if (lngViewpointAttachmentId == 0)
{
  const strMsg = Format("参数:[lngViewpointAttachmentId]不能为空！(In clsViewpointAttachmentWApi.GetObjByViewpointAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrViewpointAttachment_Sel: Array <clsViewpointAttachmentEN> = arrViewpointAttachmentObjLst_Cache.filter(x => 
 x.viewpointAttachmentId == lngViewpointAttachmentId );
let objViewpointAttachment: clsViewpointAttachmentEN;
if (arrViewpointAttachment_Sel.length > 0)
{
objViewpointAttachment = arrViewpointAttachment_Sel[0];
return objViewpointAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objViewpointAttachment_Const = await ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId);
if (objViewpointAttachment_Const != null)
{
ViewpointAttachment_ReFreshThisCache(strid_CurrEduCls);
return objViewpointAttachment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAttachmentId, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngViewpointAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ViewpointAttachment_GetObjByViewpointAttachmentId_localStorage(lngViewpointAttachmentId: number) {
const strThisFuncName = "GetObjByViewpointAttachmentId_localStorage";

if (lngViewpointAttachmentId == 0)
{
  const strMsg = Format("参数:[lngViewpointAttachmentId]不能为空！(In clsViewpointAttachmentWApi.GetObjByViewpointAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, lngViewpointAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objViewpointAttachment_Cache: clsViewpointAttachmentEN = JSON.parse(strTempObj);
return objViewpointAttachment_Cache;
}
try
{
const objViewpointAttachment = await ViewpointAttachment_GetObjByViewpointAttachmentIdAsync(lngViewpointAttachmentId);
if (objViewpointAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objViewpointAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objViewpointAttachment;
}
return objViewpointAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAttachmentId, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objViewpointAttachment:所给的对象
 * @returns 对象
*/
export async function ViewpointAttachment_UpdateObjInLst_Cache(objViewpointAttachment: clsViewpointAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrViewpointAttachmentObjLst_Cache.find(x => x.viewpointAttachmentId == objViewpointAttachment.viewpointAttachmentId && x.viewpointAttachmentName == objViewpointAttachment.viewpointAttachmentName);
if (obj != null)
{
objViewpointAttachment.viewpointAttachmentId = obj.viewpointAttachmentId;
ObjectAssign( obj, objViewpointAttachment);
}
else
{
arrViewpointAttachmentObjLst_Cache.push(objViewpointAttachment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
export async function ViewpointAttachment_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsViewpointAttachmentWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsViewpointAttachmentWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsViewpointAttachmentEN.con_ViewpointAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsViewpointAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsViewpointAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngViewpointAttachmentId = Number(strInValue);
if (lngViewpointAttachmentId == 0)
{
return "";
}
const objViewpointAttachment = await ViewpointAttachment_GetObjByViewpointAttachmentId_Cache(lngViewpointAttachmentId , strid_CurrEduCls_C);
if (objViewpointAttachment == null) return "";
if (objViewpointAttachment.GetFldValue(strOutFldName) == null) return "";
return objViewpointAttachment.GetFldValue(strOutFldName).toString();
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
export function ViewpointAttachment_SortFun_Defa(a:clsViewpointAttachmentEN , b:clsViewpointAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.viewpointAttachmentId-b.viewpointAttachmentId;
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
export function ViewpointAttachment_SortFun_Defa_2Fld(a:clsViewpointAttachmentEN , b:clsViewpointAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.viewpointAttachmentName == b.viewpointAttachmentName) return a.viewpointId.localeCompare(b.viewpointId);
else return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
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
export function ViewpointAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsViewpointAttachmentEN.con_ViewpointAttachmentId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
return a.viewpointAttachmentId-b.viewpointAttachmentId;
}
case clsViewpointAttachmentEN.con_ViewpointAttachmentName:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.viewpointAttachmentName == null) return -1;
if (b.viewpointAttachmentName == null) return 1;
return a.viewpointAttachmentName.localeCompare(b.viewpointAttachmentName);
}
case clsViewpointAttachmentEN.con_ViewpointId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.viewpointId == null) return -1;
if (b.viewpointId == null) return 1;
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsViewpointAttachmentEN.con_FilePath:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsViewpointAttachmentEN.con_UpdUserId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.updUserId == null) return -1;
if (b.updUserId == null) return 1;
return a.updUserId.localeCompare(b.updUserId);
}
case clsViewpointAttachmentEN.con_UpdDate:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsViewpointAttachmentEN.con_Memo:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsViewpointAttachmentEN.con_id_CurrEduCls:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${ viewpointAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsViewpointAttachmentEN.con_ViewpointAttachmentId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
return b.viewpointAttachmentId-a.viewpointAttachmentId;
}
case clsViewpointAttachmentEN.con_ViewpointAttachmentName:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.viewpointAttachmentName == null) return -1;
if (a.viewpointAttachmentName == null) return 1;
return b.viewpointAttachmentName.localeCompare(a.viewpointAttachmentName);
}
case clsViewpointAttachmentEN.con_ViewpointId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.viewpointId == null) return -1;
if (a.viewpointId == null) return 1;
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsViewpointAttachmentEN.con_FilePath:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsViewpointAttachmentEN.con_UpdUserId:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.updUserId == null) return -1;
if (a.updUserId == null) return 1;
return b.updUserId.localeCompare(a.updUserId);
}
case clsViewpointAttachmentEN.con_UpdDate:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsViewpointAttachmentEN.con_Memo:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsViewpointAttachmentEN.con_id_CurrEduCls:
return (a: clsViewpointAttachmentEN, b: clsViewpointAttachmentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${ viewpointAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsViewpointAttachmentEN.con_ViewpointAttachmentId:
return (obj: clsViewpointAttachmentEN) => {
return obj.viewpointAttachmentId === value;
}
case clsViewpointAttachmentEN.con_ViewpointAttachmentName:
return (obj: clsViewpointAttachmentEN) => {
return obj.viewpointAttachmentName === value;
}
case clsViewpointAttachmentEN.con_ViewpointId:
return (obj: clsViewpointAttachmentEN) => {
return obj.viewpointId === value;
}
case clsViewpointAttachmentEN.con_FilePath:
return (obj: clsViewpointAttachmentEN) => {
return obj.filePath === value;
}
case clsViewpointAttachmentEN.con_UpdUserId:
return (obj: clsViewpointAttachmentEN) => {
return obj.updUserId === value;
}
case clsViewpointAttachmentEN.con_UpdDate:
return (obj: clsViewpointAttachmentEN) => {
return obj.updDate === value;
}
case clsViewpointAttachmentEN.con_Memo:
return (obj: clsViewpointAttachmentEN) => {
return obj.memo === value;
}
case clsViewpointAttachmentEN.con_id_CurrEduCls:
return (obj: clsViewpointAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[ViewpointAttachment]中不存在！(in ${ viewpointAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function ViewpointAttachment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsViewpointAttachmentWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsViewpointAttachmentWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsViewpointAttachmentEN.con_ViewpointAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrViewpointAttachment = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrViewpointAttachment == null) return [];
let arrViewpointAttachment_Sel = arrViewpointAttachment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrViewpointAttachment_Sel.length == 0) return [];
return arrViewpointAttachment_Sel.map(x=>x.viewpointAttachmentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function ViewpointAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsViewpointAttachmentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const objViewpointAttachment = ViewpointAttachment_GetObjFromJsonObj(returnObj);
return objViewpointAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsViewpointAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsViewpointAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsViewpointAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsViewpointAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrViewpointAttachmentExObjLst_Cache: Array<clsViewpointAttachmentEN> = CacheHelper.Get(strKey);
const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
return arrViewpointAttachmentObjLst_T;
}
try
{
const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrViewpointAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
console.log(strInfo);
return arrViewpointAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ViewpointAttachment_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsViewpointAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsViewpointAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsViewpointAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsViewpointAttachmentEN.CacheAddiCondition);
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
const arrViewpointAttachmentExObjLst_Cache: Array<clsViewpointAttachmentEN> = JSON.parse(strTempObjLst);
const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
return arrViewpointAttachmentObjLst_T;
}
try
{
const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrViewpointAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
console.log(strInfo);
return arrViewpointAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ViewpointAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrViewpointAttachmentObjLst_Cache: Array<clsViewpointAttachmentEN> = JSON.parse(strTempObjLst);
return arrViewpointAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function ViewpointAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsViewpointAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsViewpointAttachmentEN.WhereFormat) == false)
{
strWhereCond = Format(clsViewpointAttachmentEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsViewpointAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsViewpointAttachmentEN.CacheAddiCondition);
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
const arrViewpointAttachmentExObjLst_Cache: Array<clsViewpointAttachmentEN> = JSON.parse(strTempObjLst);
const arrViewpointAttachmentObjLst_T = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentExObjLst_Cache);
return arrViewpointAttachmentObjLst_T;
}
try
{
const arrViewpointAttachmentExObjLst = await ViewpointAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrViewpointAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointAttachmentExObjLst.length);
console.log(strInfo);
return arrViewpointAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ViewpointAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrViewpointAttachmentObjLst_Cache: Array<clsViewpointAttachmentEN> = JSON.parse(strTempObjLst);
return arrViewpointAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsViewpointAttachmentEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsViewpointAttachmentWApi.ViewpointAttachment_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsViewpointAttachmentWApi.ViewpointAttachment_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrViewpointAttachmentObjLst_Cache;
switch (clsViewpointAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrViewpointAttachmentObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(arrViewpointAttachmentObjLst_Cache);
return arrViewpointAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function ViewpointAttachment_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrViewpointAttachmentObjLst_Cache;
switch (clsViewpointAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrViewpointAttachmentObjLst_Cache = null;
break;
default:
arrViewpointAttachmentObjLst_Cache = null;
break;
}
return arrViewpointAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngViewpointAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ViewpointAttachment_GetSubObjLst_Cache(objViewpointAttachment_Cond: clsViewpointAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
let arrViewpointAttachment_Sel: Array < clsViewpointAttachmentEN > = arrViewpointAttachmentObjLst_Cache;
if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "") return arrViewpointAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
//console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objViewpointAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrViewpointAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objViewpointAttachment_Cond), viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsViewpointAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrViewpointAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function ViewpointAttachment_GetObjLstByViewpointAttachmentIdLstAsync(arrViewpointAttachmentId: Array<string>): Promise<Array<clsViewpointAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByViewpointAttachmentIdLstAsync";
const strAction = "GetObjLstByViewpointAttachmentIdLst";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param arrlngViewpointAttachmentIdLst:关键字列表
 * @returns 对象列表
*/
export async function ViewpointAttachment_GetObjLstByViewpointAttachmentIdLst_Cache(arrViewpointAttachmentIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByViewpointAttachmentIdLst_Cache";
try
{
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
const arrViewpointAttachment_Sel: Array <clsViewpointAttachmentEN> = arrViewpointAttachmentObjLst_Cache.filter(x => arrViewpointAttachmentIdLst.indexOf(x.viewpointAttachmentId)>-1);
return arrViewpointAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointAttachmentIdLst.join(","), viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsViewpointAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsViewpointAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsViewpointAttachmentEN>();
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrViewpointAttachmentObjLst_Cache.length == 0) return arrViewpointAttachmentObjLst_Cache;
let arrViewpointAttachment_Sel = arrViewpointAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objViewpointAttachment_Cond = new clsViewpointAttachmentEN();
ObjectAssign(objViewpointAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsViewpointAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrViewpointAttachment_Sel.length == 0) return arrViewpointAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.sort(ViewpointAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.sort(objPagerPara.sortFun);
}
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.slice(intStart, intEnd);     
return arrViewpointAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsViewpointAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function ViewpointAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsViewpointAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsViewpointAttachmentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = ViewpointAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param lngViewpointAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function ViewpointAttachment_DelRecordAsync(lngViewpointAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngViewpointAttachmentId);
try
{
const response = await axios.delete(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param arrViewpointAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function ViewpointAttachment_DelViewpointAttachmentsAsync(arrViewpointAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelViewpointAttachmentsAsync";
const strAction = "DelViewpointAttachments";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrViewpointAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_DelViewpointAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelViewpointAttachmentsByCondAsync";
const strAction = "DelViewpointAttachmentsByCond";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function ViewpointAttachment_AddNewRecordAsync(objViewpointAttachmentEN: clsViewpointAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objViewpointAttachmentEN);
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function ViewpointAttachment_AddNewRecordWithReturnKeyAsync(objViewpointAttachmentEN: clsViewpointAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function ViewpointAttachment_AddNewRecordWithReturnKey(objViewpointAttachmentEN: clsViewpointAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objViewpointAttachmentEN.viewpointAttachmentId === null || objViewpointAttachmentEN.viewpointAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function ViewpointAttachment_UpdateRecordAsync(objViewpointAttachmentEN: clsViewpointAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objViewpointAttachmentEN.sfUpdFldSetStr === undefined || objViewpointAttachmentEN.sfUpdFldSetStr === null || objViewpointAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAttachmentEN.viewpointAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objViewpointAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function ViewpointAttachment_UpdateWithConditionAsync(objViewpointAttachmentEN: clsViewpointAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objViewpointAttachmentEN.sfUpdFldSetStr === undefined || objViewpointAttachmentEN.sfUpdFldSetStr === null || objViewpointAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointAttachmentEN.viewpointAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
objViewpointAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objViewpointAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objlngViewpointAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function ViewpointAttachment_IsExistRecord_Cache(objViewpointAttachment_Cond: clsViewpointAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrViewpointAttachmentObjLst_Cache == null) return false;
let arrViewpointAttachment_Sel: Array < clsViewpointAttachmentEN > = arrViewpointAttachmentObjLst_Cache;
if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "") return arrViewpointAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
//console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objViewpointAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrViewpointAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objViewpointAttachment_Cond), viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param lngViewpointAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function ViewpointAttachment_IsExist(lngViewpointAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ViewpointAttachmentId": lngViewpointAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param lngViewpointAttachmentId:所给的关键字
 * @returns 对象
*/
export async function ViewpointAttachment_IsExist_Cache(lngViewpointAttachmentId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrViewpointAttachmentObjLst_Cache == null) return false;
try
{
const arrViewpointAttachment_Sel: Array <clsViewpointAttachmentEN> = arrViewpointAttachmentObjLst_Cache.filter(x => x.viewpointAttachmentId == lngViewpointAttachmentId);
if (arrViewpointAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngViewpointAttachmentId, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngViewpointAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function ViewpointAttachment_IsExistAsync(lngViewpointAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngViewpointAttachmentId": lngViewpointAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
 * @param objViewpointAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function ViewpointAttachment_GetRecCountByCond_Cache(objViewpointAttachment_Cond: clsViewpointAttachmentEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrViewpointAttachmentObjLst_Cache = await ViewpointAttachment_GetObjLst_Cache(strid_CurrEduCls);
if (arrViewpointAttachmentObjLst_Cache == null) return 0;
let arrViewpointAttachment_Sel: Array < clsViewpointAttachmentEN > = arrViewpointAttachmentObjLst_Cache;
if (objViewpointAttachment_Cond.sf_FldComparisonOp == null || objViewpointAttachment_Cond.sf_FldComparisonOp == "") return arrViewpointAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objViewpointAttachment_Cond.sf_FldComparisonOp);
//console.log("clsViewpointAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objViewpointAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objViewpointAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrViewpointAttachment_Sel = arrViewpointAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrViewpointAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objViewpointAttachment_Cond), viewpointAttachment_ConstructorName, strThisFuncName);
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
export async function ViewpointAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(viewpointAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, viewpointAttachment_ConstructorName, strThisFuncName);
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
export function ViewpointAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function ViewpointAttachment_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsViewpointAttachmentWApi.clsViewpointAttachmentWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsViewpointAttachmentWApi.clsViewpointAttachmentWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsViewpointAttachmentEN.CacheModeId)
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
export function ViewpointAttachment_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsViewpointAttachmentEN._CurrTabName, strid_CurrEduCls);
switch (clsViewpointAttachmentEN.CacheModeId)
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
export function ViewpointAttachment_CheckPropertyNew(pobjViewpointAttachmentEN: clsViewpointAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjViewpointAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 观点附件表)!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && GetStrLen(pobjViewpointAttachmentEN.viewpointAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(viewpointAttachmentName)]的长度不能超过200(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointAttachmentName)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointId) == false && GetStrLen(pobjViewpointAttachmentEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[观点Id(viewpointId)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointId)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.filePath) == false && GetStrLen(pobjViewpointAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.filePath)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updUserId) == false && GetStrLen(pobjViewpointAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updUserId)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updDate) == false && GetStrLen(pobjViewpointAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updDate)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.memo) == false && GetStrLen(pobjViewpointAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.memo)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.id_CurrEduCls)(clsViewpointAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointAttachmentEN.viewpointAttachmentId && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentId && tzDataType.isNumber(pobjViewpointAttachmentEN.viewpointAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[主键Id(viewpointAttachmentId)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentId)], 非法，应该为数值型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentName && tzDataType.isString(pobjViewpointAttachmentEN.viewpointAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(viewpointAttachmentName)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentName)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointId) == false && undefined !== pobjViewpointAttachmentEN.viewpointId && tzDataType.isString(pobjViewpointAttachmentEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAttachmentEN.viewpointId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.filePath) == false && undefined !== pobjViewpointAttachmentEN.filePath && tzDataType.isString(pobjViewpointAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjViewpointAttachmentEN.filePath)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updUserId) == false && undefined !== pobjViewpointAttachmentEN.updUserId && tzDataType.isString(pobjViewpointAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointAttachmentEN.updUserId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updDate) == false && undefined !== pobjViewpointAttachmentEN.updDate && tzDataType.isString(pobjViewpointAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjViewpointAttachmentEN.updDate)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.memo) == false && undefined !== pobjViewpointAttachmentEN.memo && tzDataType.isString(pobjViewpointAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointAttachmentEN.memo)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.id_CurrEduCls) == false && undefined !== pobjViewpointAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjViewpointAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjViewpointAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function ViewpointAttachment_CheckProperty4Update (pobjViewpointAttachmentEN: clsViewpointAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && GetStrLen(pobjViewpointAttachmentEN.viewpointAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(viewpointAttachmentName)]的长度不能超过200(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointAttachmentName)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointId) == false && GetStrLen(pobjViewpointAttachmentEN.viewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[观点Id(viewpointId)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.viewpointId)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.filePath) == false && GetStrLen(pobjViewpointAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.filePath)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updUserId) == false && GetStrLen(pobjViewpointAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updUserId)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updDate) == false && GetStrLen(pobjViewpointAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.updDate)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.memo) == false && GetStrLen(pobjViewpointAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.memo)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjViewpointAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 观点附件表(ViewpointAttachment))!值:$(pobjViewpointAttachmentEN.id_CurrEduCls)(clsViewpointAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjViewpointAttachmentEN.viewpointAttachmentId && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentId && tzDataType.isNumber(pobjViewpointAttachmentEN.viewpointAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[主键Id(viewpointAttachmentId)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentId)], 非法，应该为数值型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointAttachmentName) == false && undefined !== pobjViewpointAttachmentEN.viewpointAttachmentName && tzDataType.isString(pobjViewpointAttachmentEN.viewpointAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(viewpointAttachmentName)]的值:[$(pobjViewpointAttachmentEN.viewpointAttachmentName)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.viewpointId) == false && undefined !== pobjViewpointAttachmentEN.viewpointId && tzDataType.isString(pobjViewpointAttachmentEN.viewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[观点Id(viewpointId)]的值:[$(pobjViewpointAttachmentEN.viewpointId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.filePath) == false && undefined !== pobjViewpointAttachmentEN.filePath && tzDataType.isString(pobjViewpointAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjViewpointAttachmentEN.filePath)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updUserId) == false && undefined !== pobjViewpointAttachmentEN.updUserId && tzDataType.isString(pobjViewpointAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjViewpointAttachmentEN.updUserId)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.updDate) == false && undefined !== pobjViewpointAttachmentEN.updDate && tzDataType.isString(pobjViewpointAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjViewpointAttachmentEN.updDate)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.memo) == false && undefined !== pobjViewpointAttachmentEN.memo && tzDataType.isString(pobjViewpointAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointAttachmentEN.memo)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjViewpointAttachmentEN.id_CurrEduCls) == false && undefined !== pobjViewpointAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjViewpointAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjViewpointAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 观点附件表(ViewpointAttachment))!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjViewpointAttachmentEN.viewpointAttachmentId 
 || pobjViewpointAttachmentEN.viewpointAttachmentId != null && pobjViewpointAttachmentEN.viewpointAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[主键Id]不能为空(In 观点附件表)!(clsViewpointAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjViewpointAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointAttachment_GetJSONStrByObj (pobjViewpointAttachmentEN: clsViewpointAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjViewpointAttachmentEN.sfUpdFldSetStr = pobjViewpointAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjViewpointAttachmentEN);
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
export function ViewpointAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsViewpointAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrViewpointAttachmentObjLst = new Array<clsViewpointAttachmentEN>();
if (strJSON === "")
{
return arrViewpointAttachmentObjLst;
}
try
{
arrViewpointAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrViewpointAttachmentObjLst;
}
return arrViewpointAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrViewpointAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function ViewpointAttachment_GetObjLstByJSONObjLst (arrViewpointAttachmentObjLstS: Array<clsViewpointAttachmentEN>): Array<clsViewpointAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrViewpointAttachmentObjLst = new Array<clsViewpointAttachmentEN>();
for (const objInFor of arrViewpointAttachmentObjLstS) {
const obj1 = ViewpointAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrViewpointAttachmentObjLst.push(obj1);
}
return arrViewpointAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function ViewpointAttachment_GetObjByJSONStr (strJSON: string): clsViewpointAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjViewpointAttachmentEN = new clsViewpointAttachmentEN();
if (strJSON === "")
{
return pobjViewpointAttachmentEN;
}
try
{
pobjViewpointAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjViewpointAttachmentEN;
}
return pobjViewpointAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function ViewpointAttachment_GetCombineCondition(objViewpointAttachment_Cond: clsViewpointAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_ViewpointAttachmentId) == true)
{
const strComparisonOp_ViewpointAttachmentId:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_ViewpointAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsViewpointAttachmentEN.con_ViewpointAttachmentId, objViewpointAttachment_Cond.viewpointAttachmentId, strComparisonOp_ViewpointAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_ViewpointAttachmentName) == true)
{
const strComparisonOp_ViewpointAttachmentName:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_ViewpointAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_ViewpointAttachmentName, objViewpointAttachment_Cond.viewpointAttachmentName, strComparisonOp_ViewpointAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_ViewpointId, objViewpointAttachment_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_FilePath, objViewpointAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_UpdUserId, objViewpointAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_UpdDate, objViewpointAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_Memo, objViewpointAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objViewpointAttachment_Cond.dicFldComparisonOp, clsViewpointAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objViewpointAttachment_Cond.dicFldComparisonOp[clsViewpointAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsViewpointAttachmentEN.con_id_CurrEduCls, objViewpointAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointAttachment(观点附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngViewpointAttachmentId: 主键Id(要求唯一的字段)
 * @param strViewpointAttachmentName: 附件名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointAttachment_GetUniCondStr_ViewpointAttachmentId_ViewpointAttachmentName(objViewpointAttachmentEN: clsViewpointAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and ViewpointAttachmentId = '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
 strWhereCond +=  Format(" and ViewpointAttachmentName = '{0}'", objViewpointAttachmentEN.viewpointAttachmentName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--ViewpointAttachment(观点附件表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngViewpointAttachmentId: 主键Id(要求唯一的字段)
 * @param strViewpointAttachmentName: 附件名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function ViewpointAttachment_GetUniCondStr4Update_ViewpointAttachmentId_ViewpointAttachmentName(objViewpointAttachmentEN: clsViewpointAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and ViewpointAttachmentId <> '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
 strWhereCond +=  Format(" and ViewpointAttachmentId = '{0}'", objViewpointAttachmentEN.viewpointAttachmentId);
 strWhereCond +=  Format(" and ViewpointAttachmentName = '{0}'", objViewpointAttachmentEN.viewpointAttachmentName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objViewpointAttachmentENS:源对象
 * @param objViewpointAttachmentENT:目标对象
*/
export function ViewpointAttachment_CopyObjTo(objViewpointAttachmentENS: clsViewpointAttachmentEN , objViewpointAttachmentENT: clsViewpointAttachmentEN ): void 
{
objViewpointAttachmentENT.viewpointAttachmentId = objViewpointAttachmentENS.viewpointAttachmentId; //主键Id
objViewpointAttachmentENT.viewpointAttachmentName = objViewpointAttachmentENS.viewpointAttachmentName; //附件名称
objViewpointAttachmentENT.viewpointId = objViewpointAttachmentENS.viewpointId; //观点Id
objViewpointAttachmentENT.filePath = objViewpointAttachmentENS.filePath; //文件路径
objViewpointAttachmentENT.updUserId = objViewpointAttachmentENS.updUserId; //修改用户Id
objViewpointAttachmentENT.updDate = objViewpointAttachmentENS.updDate; //修改日期
objViewpointAttachmentENT.memo = objViewpointAttachmentENS.memo; //备注
objViewpointAttachmentENT.id_CurrEduCls = objViewpointAttachmentENS.id_CurrEduCls; //教学班流水号
objViewpointAttachmentENT.sfUpdFldSetStr = objViewpointAttachmentENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objViewpointAttachmentENS:源对象
 * @param objViewpointAttachmentENT:目标对象
*/
export function ViewpointAttachment_GetObjFromJsonObj(objViewpointAttachmentENS: clsViewpointAttachmentEN): clsViewpointAttachmentEN 
{
 const objViewpointAttachmentENT: clsViewpointAttachmentEN = new clsViewpointAttachmentEN();
ObjectAssign(objViewpointAttachmentENT, objViewpointAttachmentENS);
 return objViewpointAttachmentENT;
}