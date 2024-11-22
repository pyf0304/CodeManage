
 /**
 * 类名:clsPaperEduClsRelaWApi
 * 表名:PaperEduClsRela(01120919)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:01
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
 * 论文教学班关系(PaperEduClsRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsPaperEduClsRelaEN } from "../../L0_Entity/GraduateEduPaper/clsPaperEduClsRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const paperEduClsRela_Controller = "PaperEduClsRelaApi";
 export const paperEduClsRela_ConstructorName = "paperEduClsRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function PaperEduClsRela_GetObjBymIdAsync(lngmId: number): Promise<clsPaperEduClsRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsPaperEduClsRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngmId": lngmId,
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
const objPaperEduClsRela = PaperEduClsRela_GetObjFromJsonObj(returnObj);
return objPaperEduClsRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function PaperEduClsRela_GetObjBymId_Cache(lngmId:number,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsPaperEduClsRelaWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrPaperEduClsRela_Sel: Array <clsPaperEduClsRelaEN> = arrPaperEduClsRelaObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objPaperEduClsRela: clsPaperEduClsRelaEN;
if (arrPaperEduClsRela_Sel.length > 0)
{
objPaperEduClsRela = arrPaperEduClsRela_Sel[0];
return objPaperEduClsRela;
}
else
{
if (bolTryAsyncOnce == true)
{
const objPaperEduClsRela_Const = await PaperEduClsRela_GetObjBymIdAsync(lngmId);
if (objPaperEduClsRela_Const != null)
{
PaperEduClsRela_ReFreshThisCache(strid_CurrEduCls);
return objPaperEduClsRela_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function PaperEduClsRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsPaperEduClsRelaWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objPaperEduClsRela_Cache: clsPaperEduClsRelaEN = JSON.parse(strTempObj);
return objPaperEduClsRela_Cache;
}
try
{
const objPaperEduClsRela = await PaperEduClsRela_GetObjBymIdAsync(lngmId);
if (objPaperEduClsRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objPaperEduClsRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objPaperEduClsRela;
}
return objPaperEduClsRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objPaperEduClsRela:所给的对象
 * @returns 对象
*/
export async function PaperEduClsRela_UpdateObjInLst_Cache(objPaperEduClsRela: clsPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrPaperEduClsRelaObjLst_Cache.find(x => x.paperId == objPaperEduClsRela.paperId && x.id_CurrEduCls == objPaperEduClsRela.id_CurrEduCls);
if (obj != null)
{
objPaperEduClsRela.mId = obj.mId;
ObjectAssign( obj, objPaperEduClsRela);
}
else
{
arrPaperEduClsRelaObjLst_Cache.push(objPaperEduClsRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperEduClsRelaWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperEduClsRelaWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsPaperEduClsRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsPaperEduClsRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsPaperEduClsRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objPaperEduClsRela = await PaperEduClsRela_GetObjBymId_Cache(lngmId , strid_CurrEduCls_C);
if (objPaperEduClsRela == null) return "";
if (objPaperEduClsRela.GetFldValue(strOutFldName) == null) return "";
return objPaperEduClsRela.GetFldValue(strOutFldName).toString();
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
export function PaperEduClsRela_SortFun_Defa(a:clsPaperEduClsRelaEN , b:clsPaperEduClsRelaEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function PaperEduClsRela_SortFun_Defa_2Fld(a:clsPaperEduClsRelaEN , b:clsPaperEduClsRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.paperTitle.localeCompare(b.paperTitle);
else return a.paperId.localeCompare(b.paperId);
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
export function PaperEduClsRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsPaperEduClsRelaEN.con_mId:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
return a.mId-b.mId;
}
case clsPaperEduClsRelaEN.con_PaperId:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsPaperEduClsRelaEN.con_PaperTitle:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.paperTitle == null) return -1;
if (b.paperTitle == null) return 1;
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsPaperEduClsRelaEN.con_id_CurrEduCls:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsPaperEduClsRelaEN.con_Author:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsPaperEduClsRelaEN.con_UpdUser:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsPaperEduClsRelaEN.con_UpdDate:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsPaperEduClsRelaEN.con_Memo:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${ paperEduClsRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsPaperEduClsRelaEN.con_mId:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
return b.mId-a.mId;
}
case clsPaperEduClsRelaEN.con_PaperId:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsPaperEduClsRelaEN.con_PaperTitle:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.paperTitle == null) return -1;
if (a.paperTitle == null) return 1;
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsPaperEduClsRelaEN.con_id_CurrEduCls:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsPaperEduClsRelaEN.con_Author:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsPaperEduClsRelaEN.con_UpdUser:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsPaperEduClsRelaEN.con_UpdDate:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsPaperEduClsRelaEN.con_Memo:
return (a: clsPaperEduClsRelaEN, b: clsPaperEduClsRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${ paperEduClsRela_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperEduClsRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsPaperEduClsRelaEN.con_mId:
return (obj: clsPaperEduClsRelaEN) => {
return obj.mId === value;
}
case clsPaperEduClsRelaEN.con_PaperId:
return (obj: clsPaperEduClsRelaEN) => {
return obj.paperId === value;
}
case clsPaperEduClsRelaEN.con_PaperTitle:
return (obj: clsPaperEduClsRelaEN) => {
return obj.paperTitle === value;
}
case clsPaperEduClsRelaEN.con_id_CurrEduCls:
return (obj: clsPaperEduClsRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsPaperEduClsRelaEN.con_Author:
return (obj: clsPaperEduClsRelaEN) => {
return obj.author === value;
}
case clsPaperEduClsRelaEN.con_UpdUser:
return (obj: clsPaperEduClsRelaEN) => {
return obj.updUser === value;
}
case clsPaperEduClsRelaEN.con_UpdDate:
return (obj: clsPaperEduClsRelaEN) => {
return obj.updDate === value;
}
case clsPaperEduClsRelaEN.con_Memo:
return (obj: clsPaperEduClsRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[PaperEduClsRela]中不存在！(in ${ paperEduClsRela_ConstructorName}.${ strThisFuncName})`;
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
export async function PaperEduClsRela_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperEduClsRelaWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperEduClsRelaWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsPaperEduClsRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrPaperEduClsRela = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrPaperEduClsRela == null) return [];
let arrPaperEduClsRela_Sel = arrPaperEduClsRela;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrPaperEduClsRela_Sel.length == 0) return [];
return arrPaperEduClsRela_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperEduClsRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetFirstObjAsync(strWhereCond: string): Promise<clsPaperEduClsRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const objPaperEduClsRela = PaperEduClsRela_GetObjFromJsonObj(returnObj);
return objPaperEduClsRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperEduClsRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperEduClsRelaEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperEduClsRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrPaperEduClsRelaExObjLst_Cache: Array<clsPaperEduClsRelaEN> = CacheHelper.Get(strKey);
const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
return arrPaperEduClsRelaObjLst_T;
}
try
{
const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrPaperEduClsRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperEduClsRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperEduClsRelaEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperEduClsRelaEN.CacheAddiCondition);
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
const arrPaperEduClsRelaExObjLst_Cache: Array<clsPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
return arrPaperEduClsRelaObjLst_T;
}
try
{
const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrPaperEduClsRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrPaperEduClsRelaObjLst_Cache: Array<clsPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
return arrPaperEduClsRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function PaperEduClsRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsPaperEduClsRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsPaperEduClsRelaEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsPaperEduClsRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsPaperEduClsRelaEN.CacheAddiCondition);
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
const arrPaperEduClsRelaExObjLst_Cache: Array<clsPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
const arrPaperEduClsRelaObjLst_T = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaExObjLst_Cache);
return arrPaperEduClsRelaObjLst_T;
}
try
{
const arrPaperEduClsRelaExObjLst = await PaperEduClsRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrPaperEduClsRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperEduClsRelaExObjLst.length);
console.log(strInfo);
return arrPaperEduClsRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrPaperEduClsRelaObjLst_Cache: Array<clsPaperEduClsRelaEN> = JSON.parse(strTempObjLst);
return arrPaperEduClsRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsPaperEduClsRelaEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsPaperEduClsRelaWApi.PaperEduClsRela_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsPaperEduClsRelaWApi.PaperEduClsRela_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrPaperEduClsRelaObjLst_Cache;
switch (clsPaperEduClsRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrPaperEduClsRelaObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(arrPaperEduClsRelaObjLst_Cache);
return arrPaperEduClsRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function PaperEduClsRela_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrPaperEduClsRelaObjLst_Cache;
switch (clsPaperEduClsRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrPaperEduClsRelaObjLst_Cache = null;
break;
default:
arrPaperEduClsRelaObjLst_Cache = null;
break;
}
return arrPaperEduClsRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperEduClsRela_GetSubObjLst_Cache(objPaperEduClsRela_Cond: clsPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
let arrPaperEduClsRela_Sel: Array < clsPaperEduClsRelaEN > = arrPaperEduClsRelaObjLst_Cache;
if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrPaperEduClsRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperEduClsRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objPaperEduClsRela_Cond), paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperEduClsRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function PaperEduClsRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function PaperEduClsRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
const arrPaperEduClsRela_Sel: Array <clsPaperEduClsRelaEN> = arrPaperEduClsRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrPaperEduClsRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperEduClsRelaEN>();
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperEduClsRelaObjLst_Cache.length == 0) return arrPaperEduClsRelaObjLst_Cache;
let arrPaperEduClsRela_Sel = arrPaperEduClsRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objPaperEduClsRela_Cond = new clsPaperEduClsRelaEN();
ObjectAssign(objPaperEduClsRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsPaperEduClsRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperEduClsRela_Sel.length == 0) return arrPaperEduClsRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(PaperEduClsRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.sort(objPagerPara.sortFun);
}
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.slice(intStart, intEnd);     
return arrPaperEduClsRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsPaperEduClsRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function PaperEduClsRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsPaperEduClsRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsPaperEduClsRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = PaperEduClsRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @returns 获取删除的结果
 **/
export async function PaperEduClsRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param arrmId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function PaperEduClsRela_DelPaperEduClsRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelPaperEduClsRelasAsync";
const strAction = "DelPaperEduClsRelas";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_DelPaperEduClsRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelPaperEduClsRelasByCondAsync";
const strAction = "DelPaperEduClsRelasByCond";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function PaperEduClsRela_AddNewRecordAsync(objPaperEduClsRelaEN: clsPaperEduClsRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objPaperEduClsRelaEN);
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperEduClsRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function PaperEduClsRela_AddNewRecordWithReturnKeyAsync(objPaperEduClsRelaEN: clsPaperEduClsRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperEduClsRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function PaperEduClsRela_AddNewRecordWithReturnKey(objPaperEduClsRelaEN: clsPaperEduClsRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objPaperEduClsRelaEN.mId === null || objPaperEduClsRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperEduClsRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function PaperEduClsRela_UpdateRecordAsync(objPaperEduClsRelaEN: clsPaperEduClsRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objPaperEduClsRelaEN.sfUpdFldSetStr === undefined || objPaperEduClsRelaEN.sfUpdFldSetStr === null || objPaperEduClsRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEduClsRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPaperEduClsRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function PaperEduClsRela_UpdateWithConditionAsync(objPaperEduClsRelaEN: clsPaperEduClsRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objPaperEduClsRelaEN.sfUpdFldSetStr === undefined || objPaperEduClsRelaEN.sfUpdFldSetStr === null || objPaperEduClsRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperEduClsRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
objPaperEduClsRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objPaperEduClsRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function PaperEduClsRela_IsExistRecord_Cache(objPaperEduClsRela_Cond: clsPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperEduClsRelaObjLst_Cache == null) return false;
let arrPaperEduClsRela_Sel: Array < clsPaperEduClsRelaEN > = arrPaperEduClsRelaObjLst_Cache;
if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrPaperEduClsRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrPaperEduClsRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objPaperEduClsRela_Cond), paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function PaperEduClsRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"mId": lngmId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function PaperEduClsRela_IsExist_Cache(lngmId:number,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperEduClsRelaObjLst_Cache == null) return false;
try
{
const arrPaperEduClsRela_Sel: Array <clsPaperEduClsRelaEN> = arrPaperEduClsRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrPaperEduClsRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function PaperEduClsRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngmId": lngmId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
 * @param objPaperEduClsRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function PaperEduClsRela_GetRecCountByCond_Cache(objPaperEduClsRela_Cond: clsPaperEduClsRelaEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrPaperEduClsRelaObjLst_Cache = await PaperEduClsRela_GetObjLst_Cache(strid_CurrEduCls);
if (arrPaperEduClsRelaObjLst_Cache == null) return 0;
let arrPaperEduClsRela_Sel: Array < clsPaperEduClsRelaEN > = arrPaperEduClsRelaObjLst_Cache;
if (objPaperEduClsRela_Cond.sf_FldComparisonOp == null || objPaperEduClsRela_Cond.sf_FldComparisonOp == "") return arrPaperEduClsRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objPaperEduClsRela_Cond.sf_FldComparisonOp);
//console.log("clsPaperEduClsRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objPaperEduClsRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objPaperEduClsRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrPaperEduClsRela_Sel = arrPaperEduClsRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrPaperEduClsRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objPaperEduClsRela_Cond), paperEduClsRela_ConstructorName, strThisFuncName);
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
export async function PaperEduClsRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(paperEduClsRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, paperEduClsRela_ConstructorName, strThisFuncName);
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
export function PaperEduClsRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function PaperEduClsRela_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsPaperEduClsRelaWApi.clsPaperEduClsRelaWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsPaperEduClsRelaWApi.clsPaperEduClsRelaWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperEduClsRelaEN.CacheModeId)
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
export function PaperEduClsRela_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsPaperEduClsRelaEN._CurrTabName, strid_CurrEduCls);
switch (clsPaperEduClsRelaEN.CacheModeId)
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

//(IsNeedGC == false)该表下拉框功能不需要生成;

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperEduClsRela_CheckPropertyNew(pobjPaperEduClsRelaEN: clsPaperEduClsRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperId) === true 
 || pobjPaperEduClsRelaEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文教学班关系)!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperId) == false && GetStrLen(pobjPaperEduClsRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperId)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperTitle) == false && GetStrLen(pobjPaperEduClsRelaEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperTitle)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && GetStrLen(pobjPaperEduClsRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.id_CurrEduCls)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.author) == false && GetStrLen(pobjPaperEduClsRelaEN.author) > 200)
{
 throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.author)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updUser) == false && GetStrLen(pobjPaperEduClsRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updUser)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updDate) == false && GetStrLen(pobjPaperEduClsRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updDate)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.memo) == false && GetStrLen(pobjPaperEduClsRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.memo)(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperEduClsRelaEN.mId && undefined !== pobjPaperEduClsRelaEN.mId && tzDataType.isNumber(pobjPaperEduClsRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjPaperEduClsRelaEN.mId)], 非法，应该为数值型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperId) == false && undefined !== pobjPaperEduClsRelaEN.paperId && tzDataType.isString(pobjPaperEduClsRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperEduClsRelaEN.paperId)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperTitle) == false && undefined !== pobjPaperEduClsRelaEN.paperTitle && tzDataType.isString(pobjPaperEduClsRelaEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjPaperEduClsRelaEN.paperTitle)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && undefined !== pobjPaperEduClsRelaEN.id_CurrEduCls && tzDataType.isString(pobjPaperEduClsRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperEduClsRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.author) == false && undefined !== pobjPaperEduClsRelaEN.author && tzDataType.isString(pobjPaperEduClsRelaEN.author) === false)
{
 throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjPaperEduClsRelaEN.author)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updUser) == false && undefined !== pobjPaperEduClsRelaEN.updUser && tzDataType.isString(pobjPaperEduClsRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperEduClsRelaEN.updUser)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updDate) == false && undefined !== pobjPaperEduClsRelaEN.updDate && tzDataType.isString(pobjPaperEduClsRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperEduClsRelaEN.updDate)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.memo) == false && undefined !== pobjPaperEduClsRelaEN.memo && tzDataType.isString(pobjPaperEduClsRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperEduClsRelaEN.memo)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjPaperEduClsRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function PaperEduClsRela_CheckProperty4Update (pobjPaperEduClsRelaEN: clsPaperEduClsRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperId) == false && GetStrLen(pobjPaperEduClsRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperId)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperTitle) == false && GetStrLen(pobjPaperEduClsRelaEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.paperTitle)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && GetStrLen(pobjPaperEduClsRelaEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.id_CurrEduCls)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.author) == false && GetStrLen(pobjPaperEduClsRelaEN.author) > 200)
{
 throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.author)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updUser) == false && GetStrLen(pobjPaperEduClsRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updUser)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updDate) == false && GetStrLen(pobjPaperEduClsRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.updDate)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.memo) == false && GetStrLen(pobjPaperEduClsRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文教学班关系(PaperEduClsRela))!值:$(pobjPaperEduClsRelaEN.memo)(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjPaperEduClsRelaEN.mId && undefined !== pobjPaperEduClsRelaEN.mId && tzDataType.isNumber(pobjPaperEduClsRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjPaperEduClsRelaEN.mId)], 非法，应该为数值型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperId) == false && undefined !== pobjPaperEduClsRelaEN.paperId && tzDataType.isString(pobjPaperEduClsRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperEduClsRelaEN.paperId)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.paperTitle) == false && undefined !== pobjPaperEduClsRelaEN.paperTitle && tzDataType.isString(pobjPaperEduClsRelaEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjPaperEduClsRelaEN.paperTitle)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.id_CurrEduCls) == false && undefined !== pobjPaperEduClsRelaEN.id_CurrEduCls && tzDataType.isString(pobjPaperEduClsRelaEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperEduClsRelaEN.id_CurrEduCls)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.author) == false && undefined !== pobjPaperEduClsRelaEN.author && tzDataType.isString(pobjPaperEduClsRelaEN.author) === false)
{
 throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjPaperEduClsRelaEN.author)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updUser) == false && undefined !== pobjPaperEduClsRelaEN.updUser && tzDataType.isString(pobjPaperEduClsRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperEduClsRelaEN.updUser)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.updDate) == false && undefined !== pobjPaperEduClsRelaEN.updDate && tzDataType.isString(pobjPaperEduClsRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperEduClsRelaEN.updDate)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjPaperEduClsRelaEN.memo) == false && undefined !== pobjPaperEduClsRelaEN.memo && tzDataType.isString(pobjPaperEduClsRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperEduClsRelaEN.memo)], 非法，应该为字符型(In 论文教学班关系(PaperEduClsRela))!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjPaperEduClsRelaEN.mId 
 || pobjPaperEduClsRelaEN.mId != null && pobjPaperEduClsRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 论文教学班关系)!(clsPaperEduClsRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjPaperEduClsRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperEduClsRela_GetJSONStrByObj (pobjPaperEduClsRelaEN: clsPaperEduClsRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjPaperEduClsRelaEN.sfUpdFldSetStr = pobjPaperEduClsRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjPaperEduClsRelaEN);
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
export function PaperEduClsRela_GetObjLstByJSONStr (strJSON: string): Array<clsPaperEduClsRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrPaperEduClsRelaObjLst = new Array<clsPaperEduClsRelaEN>();
if (strJSON === "")
{
return arrPaperEduClsRelaObjLst;
}
try
{
arrPaperEduClsRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrPaperEduClsRelaObjLst;
}
return arrPaperEduClsRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrPaperEduClsRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function PaperEduClsRela_GetObjLstByJSONObjLst (arrPaperEduClsRelaObjLstS: Array<clsPaperEduClsRelaEN>): Array<clsPaperEduClsRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrPaperEduClsRelaObjLst = new Array<clsPaperEduClsRelaEN>();
for (const objInFor of arrPaperEduClsRelaObjLstS) {
const obj1 = PaperEduClsRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrPaperEduClsRelaObjLst.push(obj1);
}
return arrPaperEduClsRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function PaperEduClsRela_GetObjByJSONStr (strJSON: string): clsPaperEduClsRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjPaperEduClsRelaEN = new clsPaperEduClsRelaEN();
if (strJSON === "")
{
return pobjPaperEduClsRelaEN;
}
try
{
pobjPaperEduClsRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjPaperEduClsRelaEN;
}
return pobjPaperEduClsRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function PaperEduClsRela_GetCombineCondition(objPaperEduClsRela_Cond: clsPaperEduClsRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsPaperEduClsRelaEN.con_mId, objPaperEduClsRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_PaperId, objPaperEduClsRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_PaperTitle, objPaperEduClsRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_id_CurrEduCls, objPaperEduClsRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_Author) == true)
{
const strComparisonOp_Author:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_Author, objPaperEduClsRela_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_UpdUser, objPaperEduClsRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_UpdDate, objPaperEduClsRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objPaperEduClsRela_Cond.dicFldComparisonOp, clsPaperEduClsRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objPaperEduClsRela_Cond.dicFldComparisonOp[clsPaperEduClsRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsPaperEduClsRelaEN.con_Memo, objPaperEduClsRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperEduClsRela(论文教学班关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperEduClsRela_GetUniCondStr_PaperId_id_CurrEduCls(objPaperEduClsRelaEN: clsPaperEduClsRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperEduClsRelaEN.paperId);
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objPaperEduClsRelaEN.id_CurrEduCls);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--PaperEduClsRela(论文教学班关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strid_CurrEduCls: 教学班流水号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function PaperEduClsRela_GetUniCondStr4Update_PaperId_id_CurrEduCls(objPaperEduClsRelaEN: clsPaperEduClsRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objPaperEduClsRelaEN.mId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objPaperEduClsRelaEN.paperId);
 strWhereCond +=  Format(" and id_CurrEduCls = '{0}'", objPaperEduClsRelaEN.id_CurrEduCls);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objPaperEduClsRelaENS:源对象
 * @param objPaperEduClsRelaENT:目标对象
*/
export function PaperEduClsRela_CopyObjTo(objPaperEduClsRelaENS: clsPaperEduClsRelaEN , objPaperEduClsRelaENT: clsPaperEduClsRelaEN ): void 
{
objPaperEduClsRelaENT.mId = objPaperEduClsRelaENS.mId; //mId
objPaperEduClsRelaENT.paperId = objPaperEduClsRelaENS.paperId; //论文Id
objPaperEduClsRelaENT.paperTitle = objPaperEduClsRelaENS.paperTitle; //论文标题
objPaperEduClsRelaENT.id_CurrEduCls = objPaperEduClsRelaENS.id_CurrEduCls; //教学班流水号
objPaperEduClsRelaENT.author = objPaperEduClsRelaENS.author; //作者
objPaperEduClsRelaENT.updUser = objPaperEduClsRelaENS.updUser; //修改人
objPaperEduClsRelaENT.updDate = objPaperEduClsRelaENS.updDate; //修改日期
objPaperEduClsRelaENT.memo = objPaperEduClsRelaENS.memo; //备注
objPaperEduClsRelaENT.sfUpdFldSetStr = objPaperEduClsRelaENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objPaperEduClsRelaENS:源对象
 * @param objPaperEduClsRelaENT:目标对象
*/
export function PaperEduClsRela_GetObjFromJsonObj(objPaperEduClsRelaENS: clsPaperEduClsRelaEN): clsPaperEduClsRelaEN 
{
 const objPaperEduClsRelaENT: clsPaperEduClsRelaEN = new clsPaperEduClsRelaEN();
ObjectAssign(objPaperEduClsRelaENT, objPaperEduClsRelaENS);
 return objPaperEduClsRelaENT;
}