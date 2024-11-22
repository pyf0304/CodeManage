
 /**
 * 类名:clsPaperSubAttachmentWApi
 * 表名:PaperSubAttachment(01120579)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:33
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 子观点附件(PaperSubAttachment)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPaperSubAttachmentEN } from "../../L0_Entity/GraduateEduPaper/clsPaperSubAttachmentEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperSubAttachment_Controller = "PaperSubAttachmentApi";
 export const paperSubAttachment_ConstructorName = "paperSubAttachment";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperSubAttachmentId:关键字
 * @returns 对象
 **/
export async function PaperSubAttachment_GetObjByPaperSubAttachmentIdAsync(lngPaperSubAttachmentId: number): Promise<clsPaperSubAttachmentEN|null>  
{
const strThisFuncName = "GetObjByPaperSubAttachmentIdAsync";

if (lngPaperSubAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperSubAttachmentId]不能为空！(In clsPaperSubAttachmentWApi.GetObjByPaperSubAttachmentIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperSubAttachmentId";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperSubAttachmentId": lngPaperSubAttachmentId,
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
const objPaperSubAttachment = PaperSubAttachment_GetObjFromJsonObj(returnObj);
return objPaperSubAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperSubAttachment_GetObjByPaperSubAttachmentId_Cache(lngPaperSubAttachmentId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperSubAttachmentId_Cache";

if (lngPaperSubAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperSubAttachmentId]不能为空！(In clsPaperSubAttachmentWApi.GetObjByPaperSubAttachmentId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
try
{
const arrPaperSubAttachment_Sel: Array <clsPaperSubAttachmentEN> = arrPaperSubAttachmentObjLst_Cache.filter(x => 
 x.paperSubAttachmentId == lngPaperSubAttachmentId );
let objPaperSubAttachment: clsPaperSubAttachmentEN;
if (arrPaperSubAttachment_Sel.length > 0)
{
objPaperSubAttachment = arrPaperSubAttachment_Sel[0];
return objPaperSubAttachment;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPaperSubAttachment_Const = await PaperSubAttachment_GetObjByPaperSubAttachmentIdAsync(lngPaperSubAttachmentId);
if (objPaperSubAttachment_Const != null)
{
PaperSubAttachment_ReFreshThisCache();
return objPaperSubAttachment_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubAttachmentId, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperSubAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperSubAttachment_GetObjByPaperSubAttachmentId_localStorage(lngPaperSubAttachmentId: number) {
const strThisFuncName = "GetObjByPaperSubAttachmentId_localStorage";

if (lngPaperSubAttachmentId == 0)
{
  const strMsg = Format("参数:[lngPaperSubAttachmentId]不能为空！(In clsPaperSubAttachmentWApi.GetObjByPaperSubAttachmentId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperSubAttachmentEN._CurrTabName, lngPaperSubAttachmentId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperSubAttachment_Cache: clsPaperSubAttachmentEN = JSON.parse(strTempObj);
return objPaperSubAttachment_Cache;
}
try
{
const objPaperSubAttachment = await PaperSubAttachment_GetObjByPaperSubAttachmentIdAsync(lngPaperSubAttachmentId);
if (objPaperSubAttachment != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperSubAttachment));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperSubAttachment;
}
return objPaperSubAttachment;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubAttachmentId, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperSubAttachment:所给的对象
 * @returns 对象
*/
export async function PaperSubAttachment_UpdateObjInLst_Cache(objPaperSubAttachment: clsPaperSubAttachmentEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
const obj = arrPaperSubAttachmentObjLst_Cache.find(x => x.paperSubAttachmentName == objPaperSubAttachment.paperSubAttachmentName);
if (obj != null)
{
objPaperSubAttachment.paperSubAttachmentId = obj.paperSubAttachmentId;
ObjectAssign( obj, objPaperSubAttachment);
}
else
{
arrPaperSubAttachmentObjLst_Cache.push(objPaperSubAttachment);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function PaperSubAttachment_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsPaperSubAttachmentEN.con_PaperSubAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperSubAttachmentEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPaperSubAttachmentEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperSubAttachmentId = Number(strInValue);
if (lngPaperSubAttachmentId == 0)
{
return "";
}
const objPaperSubAttachment = await PaperSubAttachment_GetObjByPaperSubAttachmentId_Cache(lngPaperSubAttachmentId );
if (objPaperSubAttachment == null) return "";
if (objPaperSubAttachment.GetFldValue(strOutFldName) == null) return "";
return objPaperSubAttachment.GetFldValue(strOutFldName).toString();
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
export function PaperSubAttachment_SortFun_Defa(a:clsPaperSubAttachmentEN , b:clsPaperSubAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperSubAttachmentId-b.paperSubAttachmentId;
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
export function PaperSubAttachment_SortFun_Defa_2Fld(a:clsPaperSubAttachmentEN , b:clsPaperSubAttachmentEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperSubAttachmentName == b.paperSubAttachmentName) return a.filePath.localeCompare(b.filePath);
else return a.paperSubAttachmentName.localeCompare(b.paperSubAttachmentName);
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
export function PaperSubAttachment_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
return a.paperSubAttachmentId-b.paperSubAttachmentId;
}
case clsPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.paperSubAttachmentName == null) return -1;
if (b.paperSubAttachmentName == null) return 1;
return a.paperSubAttachmentName.localeCompare(b.paperSubAttachmentName);
}
case clsPaperSubAttachmentEN.con_FilePath:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
return a.filePath.localeCompare(b.filePath);
}
case clsPaperSubAttachmentEN.con_UpdUserId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.updUserId == null) return -1;
if (b.updUserId == null) return 1;
return a.updUserId.localeCompare(b.updUserId);
}
case clsPaperSubAttachmentEN.con_UpdDate:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsPaperSubAttachmentEN.con_Memo:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsPaperSubAttachmentEN.con_id_CurrEduCls:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsPaperSubAttachmentEN.con_PaperRWId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.paperRWId == null) return -1;
if (b.paperRWId == null) return 1;
return a.paperRWId.localeCompare(b.paperRWId);
}
case clsPaperSubAttachmentEN.con_SubViewpointId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (a.subViewpointId == null) return -1;
if (b.subViewpointId == null) return 1;
return a.subViewpointId.localeCompare(b.subViewpointId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubAttachment]中不存在！(in ${ paperSubAttachment_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
return b.paperSubAttachmentId-a.paperSubAttachmentId;
}
case clsPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.paperSubAttachmentName == null) return -1;
if (a.paperSubAttachmentName == null) return 1;
return b.paperSubAttachmentName.localeCompare(a.paperSubAttachmentName);
}
case clsPaperSubAttachmentEN.con_FilePath:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
return b.filePath.localeCompare(a.filePath);
}
case clsPaperSubAttachmentEN.con_UpdUserId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.updUserId == null) return -1;
if (a.updUserId == null) return 1;
return b.updUserId.localeCompare(a.updUserId);
}
case clsPaperSubAttachmentEN.con_UpdDate:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsPaperSubAttachmentEN.con_Memo:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsPaperSubAttachmentEN.con_id_CurrEduCls:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsPaperSubAttachmentEN.con_PaperRWId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.paperRWId == null) return -1;
if (a.paperRWId == null) return 1;
return b.paperRWId.localeCompare(a.paperRWId);
}
case clsPaperSubAttachmentEN.con_SubViewpointId:
return (a: clsPaperSubAttachmentEN, b: clsPaperSubAttachmentEN) => {
if (b.subViewpointId == null) return -1;
if (a.subViewpointId == null) return 1;
return b.subViewpointId.localeCompare(a.subViewpointId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubAttachment]中不存在！(in ${ paperSubAttachment_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperSubAttachment_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperSubAttachmentEN.con_PaperSubAttachmentId:
return (obj: clsPaperSubAttachmentEN) => {
return obj.paperSubAttachmentId === value;
}
case clsPaperSubAttachmentEN.con_PaperSubAttachmentName:
return (obj: clsPaperSubAttachmentEN) => {
return obj.paperSubAttachmentName === value;
}
case clsPaperSubAttachmentEN.con_FilePath:
return (obj: clsPaperSubAttachmentEN) => {
return obj.filePath === value;
}
case clsPaperSubAttachmentEN.con_UpdUserId:
return (obj: clsPaperSubAttachmentEN) => {
return obj.updUserId === value;
}
case clsPaperSubAttachmentEN.con_UpdDate:
return (obj: clsPaperSubAttachmentEN) => {
return obj.updDate === value;
}
case clsPaperSubAttachmentEN.con_Memo:
return (obj: clsPaperSubAttachmentEN) => {
return obj.memo === value;
}
case clsPaperSubAttachmentEN.con_id_CurrEduCls:
return (obj: clsPaperSubAttachmentEN) => {
return obj.id_CurrEduCls === value;
}
case clsPaperSubAttachmentEN.con_PaperRWId:
return (obj: clsPaperSubAttachmentEN) => {
return obj.paperRWId === value;
}
case clsPaperSubAttachmentEN.con_SubViewpointId:
return (obj: clsPaperSubAttachmentEN) => {
return obj.subViewpointId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperSubAttachment]中不存在！(in ${ paperSubAttachment_ConstructorName}.${ strThisFuncName})`;
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
 * @returns 返回一个关键字值列表
*/
export async function PaperSubAttachment_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsPaperSubAttachmentEN.con_PaperSubAttachmentId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrPaperSubAttachment = await PaperSubAttachment_GetObjLst_Cache();
if (arrPaperSubAttachment == null) return [];
let arrPaperSubAttachment_Sel = arrPaperSubAttachment;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPaperSubAttachment_Sel.length == 0) return [];
return arrPaperSubAttachment_Sel.map(x=>x.paperSubAttachmentId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperSubAttachment_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperSubAttachmentEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const objPaperSubAttachment = PaperSubAttachment_GetObjFromJsonObj(returnObj);
return objPaperSubAttachment;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubAttachmentEN._CurrTabName;
if (IsNullOrEmpty(clsPaperSubAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubAttachmentEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperSubAttachmentExObjLst_Cache: Array<clsPaperSubAttachmentEN> = CacheHelper.Get(strKey);
const arrPaperSubAttachmentObjLst_T = PaperSubAttachment_GetObjLstByJSONObjLst(arrPaperSubAttachmentExObjLst_Cache);
return arrPaperSubAttachmentObjLst_T;
}
try
{
const arrPaperSubAttachmentExObjLst = await PaperSubAttachment_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperSubAttachmentExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperSubAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubAttachment_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubAttachmentEN._CurrTabName;
if (IsNullOrEmpty(clsPaperSubAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubAttachmentEN.CacheAddiCondition);
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
const arrPaperSubAttachmentExObjLst_Cache: Array<clsPaperSubAttachmentEN> = JSON.parse(strTempObjLst);
const arrPaperSubAttachmentObjLst_T = PaperSubAttachment_GetObjLstByJSONObjLst(arrPaperSubAttachmentExObjLst_Cache);
return arrPaperSubAttachmentObjLst_T;
}
try
{
const arrPaperSubAttachmentExObjLst = await PaperSubAttachment_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperSubAttachmentExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperSubAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubAttachment_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperSubAttachmentEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperSubAttachmentObjLst_Cache: Array<clsPaperSubAttachmentEN> = JSON.parse(strTempObjLst);
return arrPaperSubAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperSubAttachment_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperSubAttachmentEN._CurrTabName;
if (IsNullOrEmpty(clsPaperSubAttachmentEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperSubAttachmentEN.CacheAddiCondition);
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
const arrPaperSubAttachmentExObjLst_Cache: Array<clsPaperSubAttachmentEN> = JSON.parse(strTempObjLst);
const arrPaperSubAttachmentObjLst_T = PaperSubAttachment_GetObjLstByJSONObjLst(arrPaperSubAttachmentExObjLst_Cache);
return arrPaperSubAttachmentObjLst_T;
}
try
{
const arrPaperSubAttachmentExObjLst = await PaperSubAttachment_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperSubAttachmentExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperSubAttachmentExObjLst.length);
console.log(strInfo);
return arrPaperSubAttachmentExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubAttachment_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperSubAttachmentEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperSubAttachmentObjLst_Cache: Array<clsPaperSubAttachmentEN> = JSON.parse(strTempObjLst);
return arrPaperSubAttachmentObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubAttachment_GetObjLst_Cache(): Promise<Array<clsPaperSubAttachmentEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPaperSubAttachmentObjLst_Cache;
switch (clsPaperSubAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_ClientCache();
break;
default:
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_ClientCache();
break;
}
const arrPaperSubAttachmentObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(arrPaperSubAttachmentObjLst_Cache);
return arrPaperSubAttachmentObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperSubAttachment_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperSubAttachmentObjLst_Cache;
switch (clsPaperSubAttachmentEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPaperSubAttachmentObjLst_Cache = null;
break;
default:
arrPaperSubAttachmentObjLst_Cache = null;
break;
}
return arrPaperSubAttachmentObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperSubAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperSubAttachment_GetSubObjLst_Cache(objPaperSubAttachment_Cond: clsPaperSubAttachmentEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
let arrPaperSubAttachment_Sel: Array < clsPaperSubAttachmentEN > = arrPaperSubAttachmentObjLst_Cache;
if (objPaperSubAttachment_Cond.sf_FldComparisonOp == null || objPaperSubAttachment_Cond.sf_FldComparisonOp == "") return arrPaperSubAttachment_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubAttachment_Cond), paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubAttachmentEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperSubAttachmentId:关键字列表
 * @returns 对象列表
 **/
export async function PaperSubAttachment_GetObjLstByPaperSubAttachmentIdLstAsync(arrPaperSubAttachmentId: Array<string>): Promise<Array<clsPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPaperSubAttachmentIdLstAsync";
const strAction = "GetObjLstByPaperSubAttachmentIdLst";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubAttachmentId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperSubAttachmentIdLst:关键字列表
 * @returns 对象列表
*/
export async function PaperSubAttachment_GetObjLstByPaperSubAttachmentIdLst_Cache(arrPaperSubAttachmentIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByPaperSubAttachmentIdLst_Cache";
try
{
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
const arrPaperSubAttachment_Sel: Array <clsPaperSubAttachmentEN> = arrPaperSubAttachmentObjLst_Cache.filter(x => arrPaperSubAttachmentIdLst.indexOf(x.paperSubAttachmentId)>-1);
return arrPaperSubAttachment_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubAttachmentIdLst.join(","), paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperSubAttachmentEN>();
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
if (arrPaperSubAttachmentObjLst_Cache.length == 0) return arrPaperSubAttachmentObjLst_Cache;
let arrPaperSubAttachment_Sel = arrPaperSubAttachmentObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperSubAttachment_Cond = new clsPaperSubAttachmentEN();
ObjectAssign(objPaperSubAttachment_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperSubAttachmentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubAttachment_Sel.length == 0) return arrPaperSubAttachment_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.sort(PaperSubAttachment_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.sort(objPagerPara.sortFun);
}
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.slice(intStart, intEnd);     
return arrPaperSubAttachment_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperSubAttachmentEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperSubAttachment_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperSubAttachmentEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperSubAttachmentEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperSubAttachment_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperSubAttachment_DelRecordAsync(lngPaperSubAttachmentId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperSubAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param arrPaperSubAttachmentId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperSubAttachment_DelPaperSubAttachmentsAsync(arrPaperSubAttachmentId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperSubAttachmentsAsync";
const strAction = "DelPaperSubAttachments";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperSubAttachmentId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_DelPaperSubAttachmentsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperSubAttachmentsByCondAsync";
const strAction = "DelPaperSubAttachmentsByCond";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachmentEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperSubAttachment_AddNewRecordAsync(objPaperSubAttachmentEN: clsPaperSubAttachmentEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperSubAttachmentEN);
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachmentEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperSubAttachment_AddNewRecordWithReturnKeyAsync(objPaperSubAttachmentEN: clsPaperSubAttachmentEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachmentEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperSubAttachment_AddNewRecordWithReturnKey(objPaperSubAttachmentEN: clsPaperSubAttachmentEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperSubAttachmentEN.paperSubAttachmentId === null || objPaperSubAttachmentEN.paperSubAttachmentId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachmentEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperSubAttachment_UpdateRecordAsync(objPaperSubAttachmentEN: clsPaperSubAttachmentEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperSubAttachmentEN.sfUpdFldSetStr === undefined || objPaperSubAttachmentEN.sfUpdFldSetStr === null || objPaperSubAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubAttachmentEN.paperSubAttachmentId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachmentEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperSubAttachment_UpdateWithConditionAsync(objPaperSubAttachmentEN: clsPaperSubAttachmentEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperSubAttachmentEN.sfUpdFldSetStr === undefined || objPaperSubAttachmentEN.sfUpdFldSetStr === null || objPaperSubAttachmentEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperSubAttachmentEN.paperSubAttachmentId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
objPaperSubAttachmentEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperSubAttachmentEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objlngPaperSubAttachmentId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperSubAttachment_IsExistRecord_Cache(objPaperSubAttachment_Cond: clsPaperSubAttachmentEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
if (arrPaperSubAttachmentObjLst_Cache == null) return false;
let arrPaperSubAttachment_Sel: Array < clsPaperSubAttachmentEN > = arrPaperSubAttachmentObjLst_Cache;
if (objPaperSubAttachment_Cond.sf_FldComparisonOp == null || objPaperSubAttachment_Cond.sf_FldComparisonOp == "") return arrPaperSubAttachment_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperSubAttachment_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperSubAttachment_Cond), paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PaperSubAttachment_IsExist(lngPaperSubAttachmentId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperSubAttachmentId": lngPaperSubAttachmentId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param lngPaperSubAttachmentId:所给的关键字
 * @returns 对象
*/
export async function PaperSubAttachment_IsExist_Cache(lngPaperSubAttachmentId:number) {
const strThisFuncName = "IsExist_Cache";
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
if (arrPaperSubAttachmentObjLst_Cache == null) return false;
try
{
const arrPaperSubAttachment_Sel: Array <clsPaperSubAttachmentEN> = arrPaperSubAttachmentObjLst_Cache.filter(x => x.paperSubAttachmentId == lngPaperSubAttachmentId);
if (arrPaperSubAttachment_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubAttachmentId, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperSubAttachmentId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PaperSubAttachment_IsExistAsync(lngPaperSubAttachmentId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperSubAttachmentId": lngPaperSubAttachmentId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
 * @param objPaperSubAttachment_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperSubAttachment_GetRecCountByCond_Cache(objPaperSubAttachment_Cond: clsPaperSubAttachmentEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperSubAttachmentObjLst_Cache = await PaperSubAttachment_GetObjLst_Cache();
if (arrPaperSubAttachmentObjLst_Cache == null) return 0;
let arrPaperSubAttachment_Sel: Array < clsPaperSubAttachmentEN > = arrPaperSubAttachmentObjLst_Cache;
if (objPaperSubAttachment_Cond.sf_FldComparisonOp == null || objPaperSubAttachment_Cond.sf_FldComparisonOp == "") return arrPaperSubAttachment_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperSubAttachment_Cond.sf_FldComparisonOp);
//console.log("clsPaperSubAttachmentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperSubAttachment_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperSubAttachment_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperSubAttachment_Sel = arrPaperSubAttachment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperSubAttachment_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperSubAttachment_Cond), paperSubAttachment_ConstructorName, strThisFuncName);
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
export async function PaperSubAttachment_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperSubAttachment_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperSubAttachment_ConstructorName, strThisFuncName);
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
export function PaperSubAttachment_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperSubAttachment_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPaperSubAttachmentEN._CurrTabName;
switch (clsPaperSubAttachmentEN.CacheModeId)
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
export function PaperSubAttachment_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPaperSubAttachmentEN._CurrTabName;
switch (clsPaperSubAttachmentEN.CacheModeId)
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
export function PaperSubAttachment_CheckPropertyNew(pobjPaperSubAttachmentEN: clsPaperSubAttachmentEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.filePath) === true )
{
 throw new Error("(errid:Watl000058)字段[文件路径]不能为空(In 子观点附件)!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperSubAttachmentName) == false && GetStrLen(pobjPaperSubAttachmentEN.paperSubAttachmentName) > 200)
{
 throw new Error("(errid:Watl000059)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.paperSubAttachmentName)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.filePath) == false && GetStrLen(pobjPaperSubAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000059)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.filePath)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updUserId) == false && GetStrLen(pobjPaperSubAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.updUserId)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updDate) == false && GetStrLen(pobjPaperSubAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.updDate)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.memo) == false && GetStrLen(pobjPaperSubAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.memo)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjPaperSubAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.id_CurrEduCls)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperRWId) == false && GetStrLen(pobjPaperSubAttachmentEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.paperRWId)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.subViewpointId) == false && GetStrLen(pobjPaperSubAttachmentEN.subViewpointId) > 8)
{
 throw new Error("(errid:Watl000059)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.subViewpointId)(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjPaperSubAttachmentEN.paperSubAttachmentId && tzDataType.isNumber(pobjPaperSubAttachmentEN.paperSubAttachmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjPaperSubAttachmentEN.paperSubAttachmentName && tzDataType.isString(pobjPaperSubAttachmentEN.paperSubAttachmentName) === false)
{
 throw new Error("(errid:Watl000060)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.filePath) == false && undefined !== pobjPaperSubAttachmentEN.filePath && tzDataType.isString(pobjPaperSubAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000060)字段[文件路径(filePath)]的值:[$(pobjPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updUserId) == false && undefined !== pobjPaperSubAttachmentEN.updUserId && tzDataType.isString(pobjPaperSubAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updDate) == false && undefined !== pobjPaperSubAttachmentEN.updDate && tzDataType.isString(pobjPaperSubAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.memo) == false && undefined !== pobjPaperSubAttachmentEN.memo && tzDataType.isString(pobjPaperSubAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.id_CurrEduCls) == false && undefined !== pobjPaperSubAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjPaperSubAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjPaperSubAttachmentEN.paperRWId && tzDataType.isString(pobjPaperSubAttachmentEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.subViewpointId) == false && undefined !== pobjPaperSubAttachmentEN.subViewpointId && tzDataType.isString(pobjPaperSubAttachmentEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000060)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubAttachmentEN.subViewpointId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperSubAttachmentEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperSubAttachment_CheckProperty4Update (pobjPaperSubAttachmentEN: clsPaperSubAttachmentEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperSubAttachmentName) == false && GetStrLen(pobjPaperSubAttachmentEN.paperSubAttachmentName) > 200)
{
 throw new Error("(errid:Watl000062)字段[附件名称(paperSubAttachmentName)]的长度不能超过200(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.paperSubAttachmentName)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.filePath) == false && GetStrLen(pobjPaperSubAttachmentEN.filePath) > 500)
{
 throw new Error("(errid:Watl000062)字段[文件路径(filePath)]的长度不能超过500(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.filePath)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updUserId) == false && GetStrLen(pobjPaperSubAttachmentEN.updUserId) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.updUserId)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updDate) == false && GetStrLen(pobjPaperSubAttachmentEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.updDate)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.memo) == false && GetStrLen(pobjPaperSubAttachmentEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.memo)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.id_CurrEduCls) == false && GetStrLen(pobjPaperSubAttachmentEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.id_CurrEduCls)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperRWId) == false && GetStrLen(pobjPaperSubAttachmentEN.paperRWId) > 8)
{
 throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.paperRWId)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.subViewpointId) == false && GetStrLen(pobjPaperSubAttachmentEN.subViewpointId) > 8)
{
 throw new Error("(errid:Watl000062)字段[子观点Id(subViewpointId)]的长度不能超过8(In 子观点附件(PaperSubAttachment))!值:$(pobjPaperSubAttachmentEN.subViewpointId)(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperSubAttachmentEN.paperSubAttachmentId && undefined !== pobjPaperSubAttachmentEN.paperSubAttachmentId && tzDataType.isNumber(pobjPaperSubAttachmentEN.paperSubAttachmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点附件Id(paperSubAttachmentId)]的值:[$(pobjPaperSubAttachmentEN.paperSubAttachmentId)], 非法，应该为数值型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperSubAttachmentName) == false && undefined !== pobjPaperSubAttachmentEN.paperSubAttachmentName && tzDataType.isString(pobjPaperSubAttachmentEN.paperSubAttachmentName) === false)
{
 throw new Error("(errid:Watl000063)字段[附件名称(paperSubAttachmentName)]的值:[$(pobjPaperSubAttachmentEN.paperSubAttachmentName)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.filePath) == false && undefined !== pobjPaperSubAttachmentEN.filePath && tzDataType.isString(pobjPaperSubAttachmentEN.filePath) === false)
{
 throw new Error("(errid:Watl000063)字段[文件路径(filePath)]的值:[$(pobjPaperSubAttachmentEN.filePath)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updUserId) == false && undefined !== pobjPaperSubAttachmentEN.updUserId && tzDataType.isString(pobjPaperSubAttachmentEN.updUserId) === false)
{
 throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjPaperSubAttachmentEN.updUserId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.updDate) == false && undefined !== pobjPaperSubAttachmentEN.updDate && tzDataType.isString(pobjPaperSubAttachmentEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperSubAttachmentEN.updDate)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.memo) == false && undefined !== pobjPaperSubAttachmentEN.memo && tzDataType.isString(pobjPaperSubAttachmentEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperSubAttachmentEN.memo)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.id_CurrEduCls) == false && undefined !== pobjPaperSubAttachmentEN.id_CurrEduCls && tzDataType.isString(pobjPaperSubAttachmentEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperSubAttachmentEN.id_CurrEduCls)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.paperRWId) == false && undefined !== pobjPaperSubAttachmentEN.paperRWId && tzDataType.isString(pobjPaperSubAttachmentEN.paperRWId) === false)
{
 throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjPaperSubAttachmentEN.paperRWId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperSubAttachmentEN.subViewpointId) == false && undefined !== pobjPaperSubAttachmentEN.subViewpointId && tzDataType.isString(pobjPaperSubAttachmentEN.subViewpointId) === false)
{
 throw new Error("(errid:Watl000063)字段[子观点Id(subViewpointId)]的值:[$(pobjPaperSubAttachmentEN.subViewpointId)], 非法，应该为字符型(In 子观点附件(PaperSubAttachment))!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperSubAttachmentEN.paperSubAttachmentId 
 || pobjPaperSubAttachmentEN.paperSubAttachmentId != null && pobjPaperSubAttachmentEN.paperSubAttachmentId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[子观点附件Id]不能为空(In 子观点附件)!(clsPaperSubAttachmentBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperSubAttachmentEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubAttachment_GetJSONStrByObj (pobjPaperSubAttachmentEN: clsPaperSubAttachmentEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperSubAttachmentEN.sfUpdFldSetStr = pobjPaperSubAttachmentEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperSubAttachmentEN);
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
export function PaperSubAttachment_GetObjLstByJSONStr (strJSON: string): Array<clsPaperSubAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperSubAttachmentObjLst = new Array<clsPaperSubAttachmentEN>();
if (strJSON === "")
{
return arrPaperSubAttachmentObjLst;
}
try
{
arrPaperSubAttachmentObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperSubAttachmentObjLst;
}
return arrPaperSubAttachmentObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperSubAttachmentObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperSubAttachment_GetObjLstByJSONObjLst (arrPaperSubAttachmentObjLstS: Array<clsPaperSubAttachmentEN>): Array<clsPaperSubAttachmentEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperSubAttachmentObjLst = new Array<clsPaperSubAttachmentEN>();
for (const objInFor of arrPaperSubAttachmentObjLstS) {
const obj1 = PaperSubAttachment_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperSubAttachmentObjLst.push(obj1);
}
return arrPaperSubAttachmentObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperSubAttachment_GetObjByJSONStr (strJSON: string): clsPaperSubAttachmentEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
if (strJSON === "")
{
return pobjPaperSubAttachmentEN;
}
try
{
pobjPaperSubAttachmentEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperSubAttachmentEN;
}
return pobjPaperSubAttachmentEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperSubAttachment_GetCombineCondition(objPaperSubAttachment_Cond: clsPaperSubAttachmentEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_PaperSubAttachmentId) == true)
{
const strComparisonOp_PaperSubAttachmentId:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_PaperSubAttachmentId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperSubAttachmentEN.con_PaperSubAttachmentId, objPaperSubAttachment_Cond.paperSubAttachmentId, strComparisonOp_PaperSubAttachmentId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_PaperSubAttachmentName) == true)
{
const strComparisonOp_PaperSubAttachmentName:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_PaperSubAttachmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_PaperSubAttachmentName, objPaperSubAttachment_Cond.paperSubAttachmentName, strComparisonOp_PaperSubAttachmentName);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_FilePath) == true)
{
const strComparisonOp_FilePath:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_FilePath];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_FilePath, objPaperSubAttachment_Cond.filePath, strComparisonOp_FilePath);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_UpdUserId, objPaperSubAttachment_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_UpdDate, objPaperSubAttachment_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_Memo, objPaperSubAttachment_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_id_CurrEduCls, objPaperSubAttachment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_PaperRWId) == true)
{
const strComparisonOp_PaperRWId:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_PaperRWId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_PaperRWId, objPaperSubAttachment_Cond.paperRWId, strComparisonOp_PaperRWId);
}
if (Object.prototype.hasOwnProperty.call(objPaperSubAttachment_Cond.dicFldComparisonOp, clsPaperSubAttachmentEN.con_SubViewpointId) == true)
{
const strComparisonOp_SubViewpointId:string = objPaperSubAttachment_Cond.dicFldComparisonOp[clsPaperSubAttachmentEN.con_SubViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperSubAttachmentEN.con_SubViewpointId, objPaperSubAttachment_Cond.subViewpointId, strComparisonOp_SubViewpointId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubAttachment(子观点附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperSubAttachmentName: 附件名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubAttachment_GetUniCondStr_SubViewpointId_PaperSubAttachmentName(objPaperSubAttachmentEN: clsPaperSubAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.paperSubAttachmentName);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperSubAttachment(子观点附件),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperSubAttachmentName: 附件名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperSubAttachment_GetUniCondStr4Update_SubViewpointId_PaperSubAttachmentName(objPaperSubAttachmentEN: clsPaperSubAttachmentEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperSubAttachmentId <> '{0}'", objPaperSubAttachmentEN.paperSubAttachmentId);
 strWhereCond +=  Format(" and PaperSubAttachmentName = '{0}'", objPaperSubAttachmentEN.paperSubAttachmentName);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperSubAttachmentENS:源对象
 * @param objPaperSubAttachmentENT:目标对象
*/
export function PaperSubAttachment_CopyObjTo(objPaperSubAttachmentENS: clsPaperSubAttachmentEN , objPaperSubAttachmentENT: clsPaperSubAttachmentEN ): void 
{
objPaperSubAttachmentENT.paperSubAttachmentId = objPaperSubAttachmentENS.paperSubAttachmentId; //子观点附件Id
objPaperSubAttachmentENT.paperSubAttachmentName = objPaperSubAttachmentENS.paperSubAttachmentName; //附件名称
objPaperSubAttachmentENT.filePath = objPaperSubAttachmentENS.filePath; //文件路径
objPaperSubAttachmentENT.updUserId = objPaperSubAttachmentENS.updUserId; //修改用户Id
objPaperSubAttachmentENT.updDate = objPaperSubAttachmentENS.updDate; //修改日期
objPaperSubAttachmentENT.memo = objPaperSubAttachmentENS.memo; //备注
objPaperSubAttachmentENT.id_CurrEduCls = objPaperSubAttachmentENS.id_CurrEduCls; //教学班流水号
objPaperSubAttachmentENT.paperRWId = objPaperSubAttachmentENS.paperRWId; //课文阅读
objPaperSubAttachmentENT.subViewpointId = objPaperSubAttachmentENS.subViewpointId; //子观点Id
objPaperSubAttachmentENT.sfUpdFldSetStr = objPaperSubAttachmentENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperSubAttachmentENS:源对象
 * @param objPaperSubAttachmentENT:目标对象
*/
export function PaperSubAttachment_GetObjFromJsonObj(objPaperSubAttachmentENS: clsPaperSubAttachmentEN): clsPaperSubAttachmentEN 
{
 const objPaperSubAttachmentENT: clsPaperSubAttachmentEN = new clsPaperSubAttachmentEN();
ObjectAssign(objPaperSubAttachmentENT, objPaperSubAttachmentENS);
 return objPaperSubAttachmentENT;
}