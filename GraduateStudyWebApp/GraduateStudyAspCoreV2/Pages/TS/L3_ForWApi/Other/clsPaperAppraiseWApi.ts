﻿
 /**
 * 类名:clsPaperAppraiseWApi
 * 表名:PaperAppraise(01120567)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:13
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:其他(Other)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 论文评论表(PaperAppraise)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPaperAppraiseEN } from "../../L0_Entity/Other/clsPaperAppraiseEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperAppraise_Controller = "PaperAppraiseApi";
 export const paperAppraise_ConstructorName = "paperAppraise";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperAppraiseId:关键字
 * @returns 对象
 **/
export async function PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId: number): Promise<clsPaperAppraiseEN|null>  
{
const strThisFuncName = "GetObjByPaperAppraiseIdAsync";

if (lngPaperAppraiseId == 0)
{
  const strMsg = Format("参数:[lngPaperAppraiseId]不能为空！(In clsPaperAppraiseWApi.GetObjByPaperAppraiseIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperAppraiseId";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperAppraiseId": lngPaperAppraiseId,
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
const objPaperAppraise = PaperAppraise_GetObjFromJsonObj(returnObj);
return objPaperAppraise;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param lngPaperAppraiseId:所给的关键字
 * @returns 对象
*/
export async function PaperAppraise_GetObjByPaperAppraiseId_Cache(lngPaperAppraiseId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperAppraiseId_Cache";

if (lngPaperAppraiseId == 0)
{
  const strMsg = Format("参数:[lngPaperAppraiseId]不能为空！(In clsPaperAppraiseWApi.GetObjByPaperAppraiseId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
try
{
const arrPaperAppraise_Sel: Array <clsPaperAppraiseEN> = arrPaperAppraiseObjLst_Cache.filter(x => 
 x.paperAppraiseId == lngPaperAppraiseId );
let objPaperAppraise: clsPaperAppraiseEN;
if (arrPaperAppraise_Sel.length > 0)
{
objPaperAppraise = arrPaperAppraise_Sel[0];
return objPaperAppraise;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPaperAppraise_Const = await PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId);
if (objPaperAppraise_Const != null)
{
PaperAppraise_ReFreshThisCache();
return objPaperAppraise_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAppraiseId, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngPaperAppraiseId:所给的关键字
 * @returns 对象
*/
export async function PaperAppraise_GetObjByPaperAppraiseId_localStorage(lngPaperAppraiseId: number) {
const strThisFuncName = "GetObjByPaperAppraiseId_localStorage";

if (lngPaperAppraiseId == 0)
{
  const strMsg = Format("参数:[lngPaperAppraiseId]不能为空！(In clsPaperAppraiseWApi.GetObjByPaperAppraiseId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperAppraiseEN._CurrTabName, lngPaperAppraiseId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperAppraise_Cache: clsPaperAppraiseEN = JSON.parse(strTempObj);
return objPaperAppraise_Cache;
}
try
{
const objPaperAppraise = await PaperAppraise_GetObjByPaperAppraiseIdAsync(lngPaperAppraiseId);
if (objPaperAppraise != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperAppraise));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperAppraise;
}
return objPaperAppraise;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAppraiseId, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperAppraise:所给的对象
 * @returns 对象
*/
export async function PaperAppraise_UpdateObjInLst_Cache(objPaperAppraise: clsPaperAppraiseEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
const obj = arrPaperAppraiseObjLst_Cache.find(x => x.paperId == objPaperAppraise.paperId);
if (obj != null)
{
objPaperAppraise.paperAppraiseId = obj.paperAppraiseId;
ObjectAssign( obj, objPaperAppraise);
}
else
{
arrPaperAppraiseObjLst_Cache.push(objPaperAppraise);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsPaperAppraiseEN.con_PaperAppraiseId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperAppraiseEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPaperAppraiseEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngPaperAppraiseId = Number(strInValue);
if (lngPaperAppraiseId == 0)
{
return "";
}
const objPaperAppraise = await PaperAppraise_GetObjByPaperAppraiseId_Cache(lngPaperAppraiseId );
if (objPaperAppraise == null) return "";
if (objPaperAppraise.GetFldValue(strOutFldName) == null) return "";
return objPaperAppraise.GetFldValue(strOutFldName).toString();
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
export function PaperAppraise_SortFun_Defa(a:clsPaperAppraiseEN , b:clsPaperAppraiseEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperAppraiseId-b.paperAppraiseId;
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
export function PaperAppraise_SortFun_Defa_2Fld(a:clsPaperAppraiseEN , b:clsPaperAppraiseEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperAppraiseContent == b.paperAppraiseContent) return a.appraiseScore - b.appraiseScore;
else return a.paperAppraiseContent.localeCompare(b.paperAppraiseContent);
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
export function PaperAppraise_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperAppraiseEN.con_PaperAppraiseId:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
return a.paperAppraiseId-b.paperAppraiseId;
}
case clsPaperAppraiseEN.con_PaperAppraiseContent:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (a.paperAppraiseContent == null) return -1;
if (b.paperAppraiseContent == null) return 1;
return a.paperAppraiseContent.localeCompare(b.paperAppraiseContent);
}
case clsPaperAppraiseEN.con_AppraiseScore:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
return a.appraiseScore-b.appraiseScore;
}
case clsPaperAppraiseEN.con_PaperId:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsPaperAppraiseEN.con_UpdUser:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsPaperAppraiseEN.con_UpdDate:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsPaperAppraiseEN.con_Memo:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${ paperAppraise_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperAppraiseEN.con_PaperAppraiseId:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
return b.paperAppraiseId-a.paperAppraiseId;
}
case clsPaperAppraiseEN.con_PaperAppraiseContent:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (b.paperAppraiseContent == null) return -1;
if (a.paperAppraiseContent == null) return 1;
return b.paperAppraiseContent.localeCompare(a.paperAppraiseContent);
}
case clsPaperAppraiseEN.con_AppraiseScore:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
return b.appraiseScore-a.appraiseScore;
}
case clsPaperAppraiseEN.con_PaperId:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsPaperAppraiseEN.con_UpdUser:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsPaperAppraiseEN.con_UpdDate:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsPaperAppraiseEN.con_Memo:
return (a: clsPaperAppraiseEN, b: clsPaperAppraiseEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${ paperAppraise_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperAppraise_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperAppraiseEN.con_PaperAppraiseId:
return (obj: clsPaperAppraiseEN) => {
return obj.paperAppraiseId === value;
}
case clsPaperAppraiseEN.con_PaperAppraiseContent:
return (obj: clsPaperAppraiseEN) => {
return obj.paperAppraiseContent === value;
}
case clsPaperAppraiseEN.con_AppraiseScore:
return (obj: clsPaperAppraiseEN) => {
return obj.appraiseScore === value;
}
case clsPaperAppraiseEN.con_PaperId:
return (obj: clsPaperAppraiseEN) => {
return obj.paperId === value;
}
case clsPaperAppraiseEN.con_UpdUser:
return (obj: clsPaperAppraiseEN) => {
return obj.updUser === value;
}
case clsPaperAppraiseEN.con_UpdDate:
return (obj: clsPaperAppraiseEN) => {
return obj.updDate === value;
}
case clsPaperAppraiseEN.con_Memo:
return (obj: clsPaperAppraiseEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperAppraise]中不存在！(in ${ paperAppraise_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperAppraise_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsPaperAppraiseEN.con_PaperAppraiseId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrPaperAppraise = await PaperAppraise_GetObjLst_Cache();
if (arrPaperAppraise == null) return [];
let arrPaperAppraise_Sel = arrPaperAppraise;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPaperAppraise_Sel.length == 0) return [];
return arrPaperAppraise_Sel.map(x=>x.paperAppraiseId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperAppraise_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperAppraiseEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const objPaperAppraise = PaperAppraise_GetObjFromJsonObj(returnObj);
return objPaperAppraise;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperAppraiseEN._CurrTabName;
if (IsNullOrEmpty(clsPaperAppraiseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAppraiseEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperAppraiseExObjLst_Cache: Array<clsPaperAppraiseEN> = CacheHelper.Get(strKey);
const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
return arrPaperAppraiseObjLst_T;
}
try
{
const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperAppraiseExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
console.log(strInfo);
return arrPaperAppraiseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAppraise_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperAppraiseEN._CurrTabName;
if (IsNullOrEmpty(clsPaperAppraiseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAppraiseEN.CacheAddiCondition);
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
const arrPaperAppraiseExObjLst_Cache: Array<clsPaperAppraiseEN> = JSON.parse(strTempObjLst);
const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
return arrPaperAppraiseObjLst_T;
}
try
{
const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperAppraiseExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
console.log(strInfo);
return arrPaperAppraiseExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAppraise_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperAppraiseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperAppraiseObjLst_Cache: Array<clsPaperAppraiseEN> = JSON.parse(strTempObjLst);
return arrPaperAppraiseObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperAppraise_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperAppraiseEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAppraise_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsPaperAppraiseEN._CurrTabName;
if (IsNullOrEmpty(clsPaperAppraiseEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperAppraiseEN.CacheAddiCondition);
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
const arrPaperAppraiseExObjLst_Cache: Array<clsPaperAppraiseEN> = JSON.parse(strTempObjLst);
const arrPaperAppraiseObjLst_T = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseExObjLst_Cache);
return arrPaperAppraiseObjLst_T;
}
try
{
const arrPaperAppraiseExObjLst = await PaperAppraise_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperAppraiseExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperAppraiseExObjLst.length);
console.log(strInfo);
return arrPaperAppraiseExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAppraise_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsPaperAppraiseEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperAppraiseObjLst_Cache: Array<clsPaperAppraiseEN> = JSON.parse(strTempObjLst);
return arrPaperAppraiseObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAppraise_GetObjLst_Cache(): Promise<Array<clsPaperAppraiseEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrPaperAppraiseObjLst_Cache;
switch (clsPaperAppraiseEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_ClientCache();
break;
default:
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_ClientCache();
break;
}
const arrPaperAppraiseObjLst = PaperAppraise_GetObjLstByJSONObjLst(arrPaperAppraiseObjLst_Cache);
return arrPaperAppraiseObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperAppraise_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperAppraiseObjLst_Cache;
switch (clsPaperAppraiseEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrPaperAppraiseObjLst_Cache = null;
break;
default:
arrPaperAppraiseObjLst_Cache = null;
break;
}
return arrPaperAppraiseObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngPaperAppraiseId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperAppraise_GetSubObjLst_Cache(objPaperAppraise_Cond: clsPaperAppraiseEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
let arrPaperAppraise_Sel: Array < clsPaperAppraiseEN > = arrPaperAppraiseObjLst_Cache;
if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "") return arrPaperAppraise_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
//console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAppraise_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperAppraise_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperAppraise_Cond), paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperAppraiseEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperAppraiseId:关键字列表
 * @returns 对象列表
 **/
export async function PaperAppraise_GetObjLstByPaperAppraiseIdLstAsync(arrPaperAppraiseId: Array<string>): Promise<Array<clsPaperAppraiseEN>>  
{
const strThisFuncName = "GetObjLstByPaperAppraiseIdLstAsync";
const strAction = "GetObjLstByPaperAppraiseIdLst";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperAppraiseId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAppraise_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param arrlngPaperAppraiseIdLst:关键字列表
 * @returns 对象列表
*/
export async function PaperAppraise_GetObjLstByPaperAppraiseIdLst_Cache(arrPaperAppraiseIdLst: Array<number>) {
const strThisFuncName = "GetObjLstByPaperAppraiseIdLst_Cache";
try
{
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
const arrPaperAppraise_Sel: Array <clsPaperAppraiseEN> = arrPaperAppraiseObjLst_Cache.filter(x => arrPaperAppraiseIdLst.indexOf(x.paperAppraiseId)>-1);
return arrPaperAppraise_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperAppraiseIdLst.join(","), paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperAppraiseEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAppraise_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperAppraiseEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAppraise_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperAppraiseEN>();
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
if (arrPaperAppraiseObjLst_Cache.length == 0) return arrPaperAppraiseObjLst_Cache;
let arrPaperAppraise_Sel = arrPaperAppraiseObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperAppraise_Cond = new clsPaperAppraiseEN();
ObjectAssign(objPaperAppraise_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperAppraise_Sel.length == 0) return arrPaperAppraise_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperAppraise_Sel = arrPaperAppraise_Sel.sort(PaperAppraise_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperAppraise_Sel = arrPaperAppraise_Sel.sort(objPagerPara.sortFun);
}
arrPaperAppraise_Sel = arrPaperAppraise_Sel.slice(intStart, intEnd);     
return arrPaperAppraise_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperAppraiseEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperAppraise_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperAppraiseEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperAppraiseEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperAppraise_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param lngPaperAppraiseId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperAppraise_DelRecordAsync(lngPaperAppraiseId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperAppraiseId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param arrPaperAppraiseId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperAppraise_DelPaperAppraisesAsync(arrPaperAppraiseId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperAppraisesAsync";
const strAction = "DelPaperAppraises";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperAppraiseId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_DelPaperAppraisesByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperAppraisesByCondAsync";
const strAction = "DelPaperAppraisesByCond";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraiseEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperAppraise_AddNewRecordAsync(objPaperAppraiseEN: clsPaperAppraiseEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperAppraiseEN);
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAppraiseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraiseEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperAppraise_AddNewRecordWithReturnKeyAsync(objPaperAppraiseEN: clsPaperAppraiseEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAppraiseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraiseEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperAppraise_AddNewRecordWithReturnKey(objPaperAppraiseEN: clsPaperAppraiseEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperAppraiseEN.paperAppraiseId === null || objPaperAppraiseEN.paperAppraiseId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAppraiseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraiseEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperAppraise_UpdateRecordAsync(objPaperAppraiseEN: clsPaperAppraiseEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperAppraiseEN.sfUpdFldSetStr === undefined || objPaperAppraiseEN.sfUpdFldSetStr === null || objPaperAppraiseEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAppraiseEN.paperAppraiseId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperAppraiseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraiseEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperAppraise_UpdateWithConditionAsync(objPaperAppraiseEN: clsPaperAppraiseEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperAppraiseEN.sfUpdFldSetStr === undefined || objPaperAppraiseEN.sfUpdFldSetStr === null || objPaperAppraiseEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperAppraiseEN.paperAppraiseId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
objPaperAppraiseEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperAppraiseEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objlngPaperAppraiseId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperAppraise_IsExistRecord_Cache(objPaperAppraise_Cond: clsPaperAppraiseEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
if (arrPaperAppraiseObjLst_Cache == null) return false;
let arrPaperAppraise_Sel: Array < clsPaperAppraiseEN > = arrPaperAppraiseObjLst_Cache;
if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "") return arrPaperAppraise_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
//console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAppraise_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperAppraise_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperAppraise_Cond), paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param lngPaperAppraiseId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PaperAppraise_IsExist(lngPaperAppraiseId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperAppraiseId": lngPaperAppraiseId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param lngPaperAppraiseId:所给的关键字
 * @returns 对象
*/
export async function PaperAppraise_IsExist_Cache(lngPaperAppraiseId:number) {
const strThisFuncName = "IsExist_Cache";
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
if (arrPaperAppraiseObjLst_Cache == null) return false;
try
{
const arrPaperAppraise_Sel: Array <clsPaperAppraiseEN> = arrPaperAppraiseObjLst_Cache.filter(x => x.paperAppraiseId == lngPaperAppraiseId);
if (arrPaperAppraise_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperAppraiseId, paperAppraise_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperAppraiseId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PaperAppraise_IsExistAsync(lngPaperAppraiseId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperAppraiseId": lngPaperAppraiseId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
 * @param objPaperAppraise_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperAppraise_GetRecCountByCond_Cache(objPaperAppraise_Cond: clsPaperAppraiseEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperAppraiseObjLst_Cache = await PaperAppraise_GetObjLst_Cache();
if (arrPaperAppraiseObjLst_Cache == null) return 0;
let arrPaperAppraise_Sel: Array < clsPaperAppraiseEN > = arrPaperAppraiseObjLst_Cache;
if (objPaperAppraise_Cond.sf_FldComparisonOp == null || objPaperAppraise_Cond.sf_FldComparisonOp == "") return arrPaperAppraise_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperAppraise_Cond.sf_FldComparisonOp);
//console.log("clsPaperAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperAppraise_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperAppraise_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperAppraise_Sel = arrPaperAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperAppraise_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperAppraise_Cond), paperAppraise_ConstructorName, strThisFuncName);
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
export async function PaperAppraise_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperAppraise_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperAppraise_ConstructorName, strThisFuncName);
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
export function PaperAppraise_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperAppraise_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsPaperAppraiseEN._CurrTabName;
switch (clsPaperAppraiseEN.CacheModeId)
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
export function PaperAppraise_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsPaperAppraiseEN._CurrTabName;
switch (clsPaperAppraiseEN.CacheModeId)
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
export function PaperAppraise_CheckPropertyNew(pobjPaperAppraiseEN: clsPaperAppraiseEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperAppraiseContent) == false && GetStrLen(pobjPaperAppraiseEN.paperAppraiseContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[论文评论内容(paperAppraiseContent)]的长度不能超过2000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperAppraiseContent)(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperId) == false && GetStrLen(pobjPaperAppraiseEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperId)(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updUser) == false && GetStrLen(pobjPaperAppraiseEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updUser)(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updDate) == false && GetStrLen(pobjPaperAppraiseEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updDate)(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.memo) == false && GetStrLen(pobjPaperAppraiseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.memo)(clsPaperAppraiseBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperAppraiseEN.paperAppraiseId && undefined !== pobjPaperAppraiseEN.paperAppraiseId && tzDataType.isNumber(pobjPaperAppraiseEN.paperAppraiseId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文评论Id(paperAppraiseId)]的值:[$(pobjPaperAppraiseEN.paperAppraiseId)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperAppraiseContent) == false && undefined !== pobjPaperAppraiseEN.paperAppraiseContent && tzDataType.isString(pobjPaperAppraiseEN.paperAppraiseContent) === false)
{
 throw new Error("(errid:Watl000060)字段[论文评论内容(paperAppraiseContent)]的值:[$(pobjPaperAppraiseEN.paperAppraiseContent)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (null != pobjPaperAppraiseEN.appraiseScore && undefined !== pobjPaperAppraiseEN.appraiseScore && tzDataType.isNumber(pobjPaperAppraiseEN.appraiseScore) === false)
{
 throw new Error("(errid:Watl000060)字段[打分(appraiseScore)]的值:[$(pobjPaperAppraiseEN.appraiseScore)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperId) == false && undefined !== pobjPaperAppraiseEN.paperId && tzDataType.isString(pobjPaperAppraiseEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperAppraiseEN.paperId)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updUser) == false && undefined !== pobjPaperAppraiseEN.updUser && tzDataType.isString(pobjPaperAppraiseEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperAppraiseEN.updUser)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updDate) == false && undefined !== pobjPaperAppraiseEN.updDate && tzDataType.isString(pobjPaperAppraiseEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperAppraiseEN.updDate)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.memo) == false && undefined !== pobjPaperAppraiseEN.memo && tzDataType.isString(pobjPaperAppraiseEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperAppraiseEN.memo)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperAppraiseEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperAppraise_CheckProperty4Update (pobjPaperAppraiseEN: clsPaperAppraiseEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperAppraiseContent) == false && GetStrLen(pobjPaperAppraiseEN.paperAppraiseContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[论文评论内容(paperAppraiseContent)]的长度不能超过2000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperAppraiseContent)(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperId) == false && GetStrLen(pobjPaperAppraiseEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.paperId)(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updUser) == false && GetStrLen(pobjPaperAppraiseEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updUser)(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updDate) == false && GetStrLen(pobjPaperAppraiseEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.updDate)(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.memo) == false && GetStrLen(pobjPaperAppraiseEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文评论表(PaperAppraise))!值:$(pobjPaperAppraiseEN.memo)(clsPaperAppraiseBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperAppraiseEN.paperAppraiseId && undefined !== pobjPaperAppraiseEN.paperAppraiseId && tzDataType.isNumber(pobjPaperAppraiseEN.paperAppraiseId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文评论Id(paperAppraiseId)]的值:[$(pobjPaperAppraiseEN.paperAppraiseId)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperAppraiseContent) == false && undefined !== pobjPaperAppraiseEN.paperAppraiseContent && tzDataType.isString(pobjPaperAppraiseEN.paperAppraiseContent) === false)
{
 throw new Error("(errid:Watl000063)字段[论文评论内容(paperAppraiseContent)]的值:[$(pobjPaperAppraiseEN.paperAppraiseContent)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (null != pobjPaperAppraiseEN.appraiseScore && undefined !== pobjPaperAppraiseEN.appraiseScore && tzDataType.isNumber(pobjPaperAppraiseEN.appraiseScore) === false)
{
 throw new Error("(errid:Watl000063)字段[打分(appraiseScore)]的值:[$(pobjPaperAppraiseEN.appraiseScore)], 非法，应该为数值型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.paperId) == false && undefined !== pobjPaperAppraiseEN.paperId && tzDataType.isString(pobjPaperAppraiseEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperAppraiseEN.paperId)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updUser) == false && undefined !== pobjPaperAppraiseEN.updUser && tzDataType.isString(pobjPaperAppraiseEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperAppraiseEN.updUser)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.updDate) == false && undefined !== pobjPaperAppraiseEN.updDate && tzDataType.isString(pobjPaperAppraiseEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperAppraiseEN.updDate)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperAppraiseEN.memo) == false && undefined !== pobjPaperAppraiseEN.memo && tzDataType.isString(pobjPaperAppraiseEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperAppraiseEN.memo)], 非法，应该为字符型(In 论文评论表(PaperAppraise))!(clsPaperAppraiseBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperAppraiseEN.paperAppraiseId 
 || pobjPaperAppraiseEN.paperAppraiseId != null && pobjPaperAppraiseEN.paperAppraiseId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[论文评论Id]不能为空(In 论文评论表)!(clsPaperAppraiseBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperAppraiseEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperAppraise_GetJSONStrByObj (pobjPaperAppraiseEN: clsPaperAppraiseEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperAppraiseEN.sfUpdFldSetStr = pobjPaperAppraiseEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperAppraiseEN);
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
export function PaperAppraise_GetObjLstByJSONStr (strJSON: string): Array<clsPaperAppraiseEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperAppraiseObjLst = new Array<clsPaperAppraiseEN>();
if (strJSON === "")
{
return arrPaperAppraiseObjLst;
}
try
{
arrPaperAppraiseObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperAppraiseObjLst;
}
return arrPaperAppraiseObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperAppraiseObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperAppraise_GetObjLstByJSONObjLst (arrPaperAppraiseObjLstS: Array<clsPaperAppraiseEN>): Array<clsPaperAppraiseEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperAppraiseObjLst = new Array<clsPaperAppraiseEN>();
for (const objInFor of arrPaperAppraiseObjLstS) {
const obj1 = PaperAppraise_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperAppraiseObjLst.push(obj1);
}
return arrPaperAppraiseObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperAppraise_GetObjByJSONStr (strJSON: string): clsPaperAppraiseEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperAppraiseEN = new clsPaperAppraiseEN();
if (strJSON === "")
{
return pobjPaperAppraiseEN;
}
try
{
pobjPaperAppraiseEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperAppraiseEN;
}
return pobjPaperAppraiseEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperAppraise_GetCombineCondition(objPaperAppraise_Cond: clsPaperAppraiseEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_PaperAppraiseId) == true)
{
const strComparisonOp_PaperAppraiseId:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_PaperAppraiseId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperAppraiseEN.con_PaperAppraiseId, objPaperAppraise_Cond.paperAppraiseId, strComparisonOp_PaperAppraiseId);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_PaperAppraiseContent) == true)
{
const strComparisonOp_PaperAppraiseContent:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_PaperAppraiseContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAppraiseEN.con_PaperAppraiseContent, objPaperAppraise_Cond.paperAppraiseContent, strComparisonOp_PaperAppraiseContent);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_AppraiseScore) == true)
{
const strComparisonOp_AppraiseScore:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_AppraiseScore];
strWhereCond += Format(" And {0} {2} {1}", clsPaperAppraiseEN.con_AppraiseScore, objPaperAppraise_Cond.appraiseScore, strComparisonOp_AppraiseScore);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAppraiseEN.con_PaperId, objPaperAppraise_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAppraiseEN.con_UpdUser, objPaperAppraise_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAppraiseEN.con_UpdDate, objPaperAppraise_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperAppraise_Cond.dicFldComparisonOp, clsPaperAppraiseEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperAppraise_Cond.dicFldComparisonOp[clsPaperAppraiseEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperAppraiseEN.con_Memo, objPaperAppraise_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperAppraise(论文评论表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperAppraise_GetUniCondStr_PaperId(objPaperAppraiseEN: clsPaperAppraiseEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperAppraiseEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperAppraise(论文评论表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperAppraise_GetUniCondStr4Update_PaperId(objPaperAppraiseEN: clsPaperAppraiseEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperAppraiseId <> '{0}'", objPaperAppraiseEN.paperAppraiseId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperAppraiseEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperAppraiseENS:源对象
 * @param objPaperAppraiseENT:目标对象
*/
export function PaperAppraise_CopyObjTo(objPaperAppraiseENS: clsPaperAppraiseEN , objPaperAppraiseENT: clsPaperAppraiseEN ): void 
{
objPaperAppraiseENT.paperAppraiseId = objPaperAppraiseENS.paperAppraiseId; //论文评论Id
objPaperAppraiseENT.paperAppraiseContent = objPaperAppraiseENS.paperAppraiseContent; //论文评论内容
objPaperAppraiseENT.appraiseScore = objPaperAppraiseENS.appraiseScore; //打分
objPaperAppraiseENT.paperId = objPaperAppraiseENS.paperId; //论文Id
objPaperAppraiseENT.updUser = objPaperAppraiseENS.updUser; //修改人
objPaperAppraiseENT.updDate = objPaperAppraiseENS.updDate; //修改日期
objPaperAppraiseENT.memo = objPaperAppraiseENS.memo; //备注
objPaperAppraiseENT.sfUpdFldSetStr = objPaperAppraiseENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperAppraiseENS:源对象
 * @param objPaperAppraiseENT:目标对象
*/
export function PaperAppraise_GetObjFromJsonObj(objPaperAppraiseENS: clsPaperAppraiseEN): clsPaperAppraiseEN 
{
 const objPaperAppraiseENT: clsPaperAppraiseEN = new clsPaperAppraiseEN();
ObjectAssign(objPaperAppraiseENT, objPaperAppraiseENS);
 return objPaperAppraiseENT;
}