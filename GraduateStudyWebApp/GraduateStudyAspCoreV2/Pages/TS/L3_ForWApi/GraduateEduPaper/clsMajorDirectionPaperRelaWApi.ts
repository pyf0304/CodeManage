
 /**
 * 类名:clsMajorDirectionPaperRelaWApi
 * 表名:MajorDirectionPaperRela(01120554)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:07
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
 * 专业方向论文关系(MajorDirectionPaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsMajorDirectionPaperRelaEN } from "../../L0_Entity/GraduateEduPaper/clsMajorDirectionPaperRelaEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const majorDirectionPaperRela_Controller = "MajorDirectionPaperRelaApi";
 export const majorDirectionPaperRela_ConstructorName = "majorDirectionPaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function MajorDirectionPaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsMajorDirectionPaperRelaEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsMajorDirectionPaperRelaWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const objMajorDirectionPaperRela = MajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
return objMajorDirectionPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjBymId_Cache(lngmId:number,strid_XzMajor:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsMajorDirectionPaperRelaWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
try
{
const arrMajorDirectionPaperRela_Sel: Array <clsMajorDirectionPaperRelaEN> = arrMajorDirectionPaperRelaObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objMajorDirectionPaperRela: clsMajorDirectionPaperRelaEN;
if (arrMajorDirectionPaperRela_Sel.length > 0)
{
objMajorDirectionPaperRela = arrMajorDirectionPaperRela_Sel[0];
return objMajorDirectionPaperRela;
}
else
{
if (bolTryAsyncOnce == true)
{
const objMajorDirectionPaperRela_Const = await MajorDirectionPaperRela_GetObjBymIdAsync(lngmId);
if (objMajorDirectionPaperRela_Const != null)
{
MajorDirectionPaperRela_ReFreshThisCache(strid_XzMajor);
return objMajorDirectionPaperRela_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsMajorDirectionPaperRelaWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objMajorDirectionPaperRela_Cache: clsMajorDirectionPaperRelaEN = JSON.parse(strTempObj);
return objMajorDirectionPaperRela_Cache;
}
try
{
const objMajorDirectionPaperRela = await MajorDirectionPaperRela_GetObjBymIdAsync(lngmId);
if (objMajorDirectionPaperRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objMajorDirectionPaperRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objMajorDirectionPaperRela;
}
return objMajorDirectionPaperRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objMajorDirectionPaperRela:所给的对象
 * @returns 对象
*/
export async function MajorDirectionPaperRela_UpdateObjInLst_Cache(objMajorDirectionPaperRela: clsMajorDirectionPaperRelaEN,strid_XzMajor: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
const obj = arrMajorDirectionPaperRelaObjLst_Cache.find(x => x.majorDirectionId == objMajorDirectionPaperRela.majorDirectionId && x.paperId == objMajorDirectionPaperRela.paperId);
if (obj != null)
{
objMajorDirectionPaperRela.mId = obj.mId;
ObjectAssign( obj, objMajorDirectionPaperRela);
}
else
{
arrMajorDirectionPaperRelaObjLst_Cache.push(objMajorDirectionPaperRela);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 @param strid_XzMajor:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function MajorDirectionPaperRela_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_XzMajor_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_XzMajor_C) == true)
{
  const strMsg = Format("参数:[strid_XzMajor_C]不能为空！(In clsMajorDirectionPaperRelaWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor_C]的长度:[{0}]不正确！(clsMajorDirectionPaperRelaWApi.func)", strid_XzMajor_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsMajorDirectionPaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsMajorDirectionPaperRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsMajorDirectionPaperRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objMajorDirectionPaperRela = await MajorDirectionPaperRela_GetObjBymId_Cache(lngmId , strid_XzMajor_C);
if (objMajorDirectionPaperRela == null) return "";
if (objMajorDirectionPaperRela.GetFldValue(strOutFldName) == null) return "";
return objMajorDirectionPaperRela.GetFldValue(strOutFldName).toString();
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
export function MajorDirectionPaperRela_SortFun_Defa(a:clsMajorDirectionPaperRelaEN , b:clsMajorDirectionPaperRelaEN): number 
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
export function MajorDirectionPaperRela_SortFun_Defa_2Fld(a:clsMajorDirectionPaperRelaEN , b:clsMajorDirectionPaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.majorDirectionId == b.majorDirectionId) return a.paperId.localeCompare(b.paperId);
else return a.majorDirectionId.localeCompare(b.majorDirectionId);
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
export function MajorDirectionPaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsMajorDirectionPaperRelaEN.con_mId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
return a.mId-b.mId;
}
case clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (a.majorDirectionId == null) return -1;
if (b.majorDirectionId == null) return 1;
return a.majorDirectionId.localeCompare(b.majorDirectionId);
}
case clsMajorDirectionPaperRelaEN.con_PaperId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsMajorDirectionPaperRelaEN.con_UpdDate:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsMajorDirectionPaperRelaEN.con_UpdUser:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsMajorDirectionPaperRelaEN.con_Memo:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${ majorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsMajorDirectionPaperRelaEN.con_mId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
return b.mId-a.mId;
}
case clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (b.majorDirectionId == null) return -1;
if (a.majorDirectionId == null) return 1;
return b.majorDirectionId.localeCompare(a.majorDirectionId);
}
case clsMajorDirectionPaperRelaEN.con_PaperId:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsMajorDirectionPaperRelaEN.con_UpdDate:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsMajorDirectionPaperRelaEN.con_UpdUser:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsMajorDirectionPaperRelaEN.con_Memo:
return (a: clsMajorDirectionPaperRelaEN, b: clsMajorDirectionPaperRelaEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${ majorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function MajorDirectionPaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsMajorDirectionPaperRelaEN.con_mId:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.mId === value;
}
case clsMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.majorDirectionId === value;
}
case clsMajorDirectionPaperRelaEN.con_PaperId:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.paperId === value;
}
case clsMajorDirectionPaperRelaEN.con_UpdDate:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.updDate === value;
}
case clsMajorDirectionPaperRelaEN.con_UpdUser:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.updUser === value;
}
case clsMajorDirectionPaperRelaEN.con_Memo:
return (obj: clsMajorDirectionPaperRelaEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[MajorDirectionPaperRela]中不存在！(in ${ majorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
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
 @param strid_XzMajor:缓存的分类字段
 * @returns 返回一个关键字值列表
*/
export async function MajorDirectionPaperRela_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_XzMajor_C: string): Promise<Array<number>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_XzMajor_C) == true)
{
  const strMsg = Format("参数:[strid_XzMajor_C]不能为空！(In clsMajorDirectionPaperRelaWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor_C]的长度:[{0}]不正确！(clsMajorDirectionPaperRelaWApi.funcKey)", strid_XzMajor_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsMajorDirectionPaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrMajorDirectionPaperRela = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor_C);
if (arrMajorDirectionPaperRela == null) return [];
let arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrMajorDirectionPaperRela_Sel.length == 0) return [];
return arrMajorDirectionPaperRela_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function MajorDirectionPaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsMajorDirectionPaperRelaEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const objMajorDirectionPaperRela = MajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
return objMajorDirectionPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLst_ClientCache(strid_XzMajor: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsMajorDirectionPaperRelaEN.WhereFormat, strid_XzMajor);
}
else
{
strWhereCond = Format("id_XzMajor='{0}'", strid_XzMajor);
}
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsMajorDirectionPaperRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrMajorDirectionPaperRelaExObjLst_Cache: Array<clsMajorDirectionPaperRelaEN> = CacheHelper.Get(strKey);
const arrMajorDirectionPaperRelaObjLst_T = MajorDirectionPaperRela_GetObjLstByJSONObjLst(arrMajorDirectionPaperRelaExObjLst_Cache);
return arrMajorDirectionPaperRelaObjLst_T;
}
try
{
const arrMajorDirectionPaperRelaExObjLst = await MajorDirectionPaperRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrMajorDirectionPaperRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrMajorDirectionPaperRelaExObjLst.length);
console.log(strInfo);
return arrMajorDirectionPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLst_localStorage(strid_XzMajor: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsMajorDirectionPaperRelaEN.WhereFormat, strid_XzMajor);
}
else
{
strWhereCond = Format("id_XzMajor='{0}'", strid_XzMajor);
}
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsMajorDirectionPaperRelaEN.CacheAddiCondition);
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
const arrMajorDirectionPaperRelaExObjLst_Cache: Array<clsMajorDirectionPaperRelaEN> = JSON.parse(strTempObjLst);
const arrMajorDirectionPaperRelaObjLst_T = MajorDirectionPaperRela_GetObjLstByJSONObjLst(arrMajorDirectionPaperRelaExObjLst_Cache);
return arrMajorDirectionPaperRelaObjLst_T;
}
try
{
const arrMajorDirectionPaperRelaExObjLst = await MajorDirectionPaperRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrMajorDirectionPaperRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrMajorDirectionPaperRelaExObjLst.length);
console.log(strInfo);
return arrMajorDirectionPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLst_localStorage_PureCache(strid_XzMajor: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_XzMajor='{0}'", strid_XzMajor);
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrMajorDirectionPaperRelaObjLst_Cache: Array<clsMajorDirectionPaperRelaEN> = JSON.parse(strTempObjLst);
return arrMajorDirectionPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLst_sessionStorage(strid_XzMajor: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.WhereFormat) == false)
{
strWhereCond = Format(clsMajorDirectionPaperRelaEN.WhereFormat, strid_XzMajor);
}
else
{
strWhereCond = Format("id_XzMajor='{0}'", strid_XzMajor);
}
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
if (IsNullOrEmpty(clsMajorDirectionPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsMajorDirectionPaperRelaEN.CacheAddiCondition);
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
const arrMajorDirectionPaperRelaExObjLst_Cache: Array<clsMajorDirectionPaperRelaEN> = JSON.parse(strTempObjLst);
const arrMajorDirectionPaperRelaObjLst_T = MajorDirectionPaperRela_GetObjLstByJSONObjLst(arrMajorDirectionPaperRelaExObjLst_Cache);
return arrMajorDirectionPaperRelaObjLst_T;
}
try
{
const arrMajorDirectionPaperRelaExObjLst = await MajorDirectionPaperRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrMajorDirectionPaperRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrMajorDirectionPaperRelaExObjLst.length);
console.log(strInfo);
return arrMajorDirectionPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLst_sessionStorage_PureCache(strid_XzMajor: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_XzMajor='{0}'", strid_XzMajor);
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrMajorDirectionPaperRelaObjLst_Cache: Array<clsMajorDirectionPaperRelaEN> = JSON.parse(strTempObjLst);
return arrMajorDirectionPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor: string): Promise<Array<clsMajorDirectionPaperRelaEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
const strMsg = Format("缓存分类变量:[id_XzMajor]不能为空！(in clsMajorDirectionPaperRelaWApi.MajorDirectionPaperRela_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(in clsMajorDirectionPaperRelaWApi.MajorDirectionPaperRela_GetObjLst_Cache() )", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}
let arrMajorDirectionPaperRelaObjLst_Cache;
switch (clsMajorDirectionPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_sessionStorage(strid_XzMajor);
break;
case "03"://localStorage
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_localStorage(strid_XzMajor);
break;
case "02"://ClientCache
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_ClientCache(strid_XzMajor);
break;
default:
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_ClientCache(strid_XzMajor);
break;
}
const arrMajorDirectionPaperRelaObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(arrMajorDirectionPaperRelaObjLst_Cache);
return arrMajorDirectionPaperRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLst_PureCache(strid_XzMajor: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrMajorDirectionPaperRelaObjLst_Cache;
switch (clsMajorDirectionPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_sessionStorage_PureCache(strid_XzMajor);
break;
case "03"://localStorage
arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_localStorage_PureCache(strid_XzMajor);
break;
case "02"://ClientCache
arrMajorDirectionPaperRelaObjLst_Cache = null;
break;
default:
arrMajorDirectionPaperRelaObjLst_Cache = null;
break;
}
return arrMajorDirectionPaperRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function MajorDirectionPaperRela_GetSubObjLst_Cache(objMajorDirectionPaperRela_Cond: clsMajorDirectionPaperRelaEN,strid_XzMajor: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
let arrMajorDirectionPaperRela_Sel: Array < clsMajorDirectionPaperRelaEN > = arrMajorDirectionPaperRelaObjLst_Cache;
if (objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == null || objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == "") return arrMajorDirectionPaperRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objMajorDirectionPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsMajorDirectionPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objMajorDirectionPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objMajorDirectionPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrMajorDirectionPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objMajorDirectionPaperRela_Cond), majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsMajorDirectionPaperRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>,strid_XzMajor: string) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
const arrMajorDirectionPaperRela_Sel: Array <clsMajorDirectionPaperRelaEN> = arrMajorDirectionPaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrMajorDirectionPaperRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_XzMajor: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsMajorDirectionPaperRelaEN>();
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
if (arrMajorDirectionPaperRelaObjLst_Cache.length == 0) return arrMajorDirectionPaperRelaObjLst_Cache;
let arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objMajorDirectionPaperRela_Cond = new clsMajorDirectionPaperRelaEN();
ObjectAssign(objMajorDirectionPaperRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsMajorDirectionPaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objMajorDirectionPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrMajorDirectionPaperRela_Sel.length == 0) return arrMajorDirectionPaperRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.sort(MajorDirectionPaperRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.sort(objPagerPara.sortFun);
}
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.slice(intStart, intEnd);     
return arrMajorDirectionPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsMajorDirectionPaperRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function MajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsMajorDirectionPaperRelaEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = MajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_DelRecordAsync(lngmId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_DelMajorDirectionPaperRelasAsync(arrmId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelMajorDirectionPaperRelasAsync";
const strAction = "DelMajorDirectionPaperRelas";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_DelMajorDirectionPaperRelasByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelMajorDirectionPaperRelasByCondAsync";
const strAction = "DelMajorDirectionPaperRelasByCond";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRelaEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function MajorDirectionPaperRela_AddNewRecordAsync(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objMajorDirectionPaperRelaEN);
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objMajorDirectionPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRelaEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function MajorDirectionPaperRela_AddNewRecordWithReturnKeyAsync(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objMajorDirectionPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRelaEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function MajorDirectionPaperRela_AddNewRecordWithReturnKey(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objMajorDirectionPaperRelaEN.mId === null || objMajorDirectionPaperRelaEN.mId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objMajorDirectionPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRelaEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function MajorDirectionPaperRela_UpdateRecordAsync(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objMajorDirectionPaperRelaEN.sfUpdFldSetStr === undefined || objMajorDirectionPaperRelaEN.sfUpdFldSetStr === null || objMajorDirectionPaperRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMajorDirectionPaperRelaEN.mId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objMajorDirectionPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRelaEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function MajorDirectionPaperRela_UpdateWithConditionAsync(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objMajorDirectionPaperRelaEN.sfUpdFldSetStr === undefined || objMajorDirectionPaperRelaEN.sfUpdFldSetStr === null || objMajorDirectionPaperRelaEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objMajorDirectionPaperRelaEN.mId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
objMajorDirectionPaperRelaEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objMajorDirectionPaperRelaEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_IsExistRecord_Cache(objMajorDirectionPaperRela_Cond: clsMajorDirectionPaperRelaEN,strid_XzMajor: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
if (arrMajorDirectionPaperRelaObjLst_Cache == null) return false;
let arrMajorDirectionPaperRela_Sel: Array < clsMajorDirectionPaperRelaEN > = arrMajorDirectionPaperRelaObjLst_Cache;
if (objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == null || objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == "") return arrMajorDirectionPaperRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objMajorDirectionPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsMajorDirectionPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objMajorDirectionPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objMajorDirectionPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrMajorDirectionPaperRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objMajorDirectionPaperRela_Cond), majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_IsExist_Cache(lngmId:number,strid_XzMajor:string) {
const strThisFuncName = "IsExist_Cache";
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
if (arrMajorDirectionPaperRelaObjLst_Cache == null) return false;
try
{
const arrMajorDirectionPaperRela_Sel: Array <clsMajorDirectionPaperRelaEN> = arrMajorDirectionPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrMajorDirectionPaperRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param objMajorDirectionPaperRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function MajorDirectionPaperRela_GetRecCountByCond_Cache(objMajorDirectionPaperRela_Cond: clsMajorDirectionPaperRelaEN,strid_XzMajor: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrMajorDirectionPaperRelaObjLst_Cache = await MajorDirectionPaperRela_GetObjLst_Cache(strid_XzMajor);
if (arrMajorDirectionPaperRelaObjLst_Cache == null) return 0;
let arrMajorDirectionPaperRela_Sel: Array < clsMajorDirectionPaperRelaEN > = arrMajorDirectionPaperRelaObjLst_Cache;
if (objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == null || objMajorDirectionPaperRela_Cond.sf_FldComparisonOp == "") return arrMajorDirectionPaperRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objMajorDirectionPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsMajorDirectionPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objMajorDirectionPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objMajorDirectionPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrMajorDirectionPaperRela_Sel = arrMajorDirectionPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrMajorDirectionPaperRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objMajorDirectionPaperRela_Cond), majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function MajorDirectionPaperRela_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(majorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, majorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export function MajorDirectionPaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function MajorDirectionPaperRela_ReFreshCache(strid_XzMajor: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_XzMajor) == true)
{
  const strMsg = Format("参数:[strid_XzMajor]不能为空！(In clsMajorDirectionPaperRelaWApi.clsMajorDirectionPaperRelaWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzMajor.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_XzMajor]的长度:[{0}]不正确！(clsMajorDirectionPaperRelaWApi.clsMajorDirectionPaperRelaWApi.ReFreshCache)", strid_XzMajor.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
switch (clsMajorDirectionPaperRelaEN.CacheModeId)
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
export function MajorDirectionPaperRela_ReFreshThisCache(strid_XzMajor: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsMajorDirectionPaperRelaEN._CurrTabName, strid_XzMajor);
switch (clsMajorDirectionPaperRelaEN.CacheModeId)
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
export function MajorDirectionPaperRela_CheckPropertyNew(pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 专业方向论文关系)!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.majorDirectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.majorDirectionId)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.paperId) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.paperId)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updDate) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updDate)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updUser) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updUser)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.memo) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.memo)(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjMajorDirectionPaperRelaEN.mId && undefined !== pobjMajorDirectionPaperRelaEN.mId && tzDataType.isNumber(pobjMajorDirectionPaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjMajorDirectionPaperRelaEN.mId)], 非法，应该为数值型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && undefined !== pobjMajorDirectionPaperRelaEN.majorDirectionId && tzDataType.isString(pobjMajorDirectionPaperRelaEN.majorDirectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[研究方向Id(majorDirectionId)]的值:[$(pobjMajorDirectionPaperRelaEN.majorDirectionId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.paperId) == false && undefined !== pobjMajorDirectionPaperRelaEN.paperId && tzDataType.isString(pobjMajorDirectionPaperRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjMajorDirectionPaperRelaEN.paperId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updDate) == false && undefined !== pobjMajorDirectionPaperRelaEN.updDate && tzDataType.isString(pobjMajorDirectionPaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjMajorDirectionPaperRelaEN.updDate)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updUser) == false && undefined !== pobjMajorDirectionPaperRelaEN.updUser && tzDataType.isString(pobjMajorDirectionPaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjMajorDirectionPaperRelaEN.updUser)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.memo) == false && undefined !== pobjMajorDirectionPaperRelaEN.memo && tzDataType.isString(pobjMajorDirectionPaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjMajorDirectionPaperRelaEN.memo)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjMajorDirectionPaperRelaEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function MajorDirectionPaperRela_CheckProperty4Update (pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.majorDirectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[研究方向Id(majorDirectionId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.majorDirectionId)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.paperId) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.paperId)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updDate) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updDate)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updUser) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.updUser)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.memo) == false && GetStrLen(pobjMajorDirectionPaperRelaEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业方向论文关系(MajorDirectionPaperRela))!值:$(pobjMajorDirectionPaperRelaEN.memo)(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjMajorDirectionPaperRelaEN.mId && undefined !== pobjMajorDirectionPaperRelaEN.mId && tzDataType.isNumber(pobjMajorDirectionPaperRelaEN.mId) === false)
{
 throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjMajorDirectionPaperRelaEN.mId)], 非法，应该为数值型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.majorDirectionId) == false && undefined !== pobjMajorDirectionPaperRelaEN.majorDirectionId && tzDataType.isString(pobjMajorDirectionPaperRelaEN.majorDirectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[研究方向Id(majorDirectionId)]的值:[$(pobjMajorDirectionPaperRelaEN.majorDirectionId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.paperId) == false && undefined !== pobjMajorDirectionPaperRelaEN.paperId && tzDataType.isString(pobjMajorDirectionPaperRelaEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjMajorDirectionPaperRelaEN.paperId)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updDate) == false && undefined !== pobjMajorDirectionPaperRelaEN.updDate && tzDataType.isString(pobjMajorDirectionPaperRelaEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjMajorDirectionPaperRelaEN.updDate)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.updUser) == false && undefined !== pobjMajorDirectionPaperRelaEN.updUser && tzDataType.isString(pobjMajorDirectionPaperRelaEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjMajorDirectionPaperRelaEN.updUser)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjMajorDirectionPaperRelaEN.memo) == false && undefined !== pobjMajorDirectionPaperRelaEN.memo && tzDataType.isString(pobjMajorDirectionPaperRelaEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjMajorDirectionPaperRelaEN.memo)], 非法，应该为字符型(In 专业方向论文关系(MajorDirectionPaperRela))!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjMajorDirectionPaperRelaEN.mId 
 || pobjMajorDirectionPaperRelaEN.mId != null && pobjMajorDirectionPaperRelaEN.mId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[mId]不能为空(In 专业方向论文关系)!(clsMajorDirectionPaperRelaBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjMajorDirectionPaperRelaEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function MajorDirectionPaperRela_GetJSONStrByObj (pobjMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjMajorDirectionPaperRelaEN.sfUpdFldSetStr = pobjMajorDirectionPaperRelaEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjMajorDirectionPaperRelaEN);
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
export function MajorDirectionPaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsMajorDirectionPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrMajorDirectionPaperRelaObjLst = new Array<clsMajorDirectionPaperRelaEN>();
if (strJSON === "")
{
return arrMajorDirectionPaperRelaObjLst;
}
try
{
arrMajorDirectionPaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrMajorDirectionPaperRelaObjLst;
}
return arrMajorDirectionPaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrMajorDirectionPaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function MajorDirectionPaperRela_GetObjLstByJSONObjLst (arrMajorDirectionPaperRelaObjLstS: Array<clsMajorDirectionPaperRelaEN>): Array<clsMajorDirectionPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrMajorDirectionPaperRelaObjLst = new Array<clsMajorDirectionPaperRelaEN>();
for (const objInFor of arrMajorDirectionPaperRelaObjLstS) {
const obj1 = MajorDirectionPaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrMajorDirectionPaperRelaObjLst.push(obj1);
}
return arrMajorDirectionPaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function MajorDirectionPaperRela_GetObjByJSONStr (strJSON: string): clsMajorDirectionPaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN();
if (strJSON === "")
{
return pobjMajorDirectionPaperRelaEN;
}
try
{
pobjMajorDirectionPaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjMajorDirectionPaperRelaEN;
}
return pobjMajorDirectionPaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function MajorDirectionPaperRela_GetCombineCondition(objMajorDirectionPaperRela_Cond: clsMajorDirectionPaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsMajorDirectionPaperRelaEN.con_mId, objMajorDirectionPaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_MajorDirectionId) == true)
{
const strComparisonOp_MajorDirectionId:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_MajorDirectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN.con_MajorDirectionId, objMajorDirectionPaperRela_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
}
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN.con_PaperId, objMajorDirectionPaperRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN.con_UpdDate, objMajorDirectionPaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN.con_UpdUser, objMajorDirectionPaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsMajorDirectionPaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsMajorDirectionPaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsMajorDirectionPaperRelaEN.con_Memo, objMajorDirectionPaperRela_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--MajorDirectionPaperRela(专业方向论文关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strMajorDirectionId: 研究方向Id(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function MajorDirectionPaperRela_GetUniCondStr_MajorDirectionId_PaperId(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and MajorDirectionId = '{0}'", objMajorDirectionPaperRelaEN.majorDirectionId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objMajorDirectionPaperRelaEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--MajorDirectionPaperRela(专业方向论文关系),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strMajorDirectionId: 研究方向Id(要求唯一的字段)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function MajorDirectionPaperRela_GetUniCondStr4Update_MajorDirectionId_PaperId(objMajorDirectionPaperRelaEN: clsMajorDirectionPaperRelaEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objMajorDirectionPaperRelaEN.mId);
 strWhereCond +=  Format(" and MajorDirectionId = '{0}'", objMajorDirectionPaperRelaEN.majorDirectionId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objMajorDirectionPaperRelaEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objMajorDirectionPaperRelaENS:源对象
 * @param objMajorDirectionPaperRelaENT:目标对象
*/
export function MajorDirectionPaperRela_CopyObjTo(objMajorDirectionPaperRelaENS: clsMajorDirectionPaperRelaEN , objMajorDirectionPaperRelaENT: clsMajorDirectionPaperRelaEN ): void 
{
objMajorDirectionPaperRelaENT.mId = objMajorDirectionPaperRelaENS.mId; //mId
objMajorDirectionPaperRelaENT.majorDirectionId = objMajorDirectionPaperRelaENS.majorDirectionId; //研究方向Id
objMajorDirectionPaperRelaENT.paperId = objMajorDirectionPaperRelaENS.paperId; //论文Id
objMajorDirectionPaperRelaENT.updDate = objMajorDirectionPaperRelaENS.updDate; //修改日期
objMajorDirectionPaperRelaENT.updUser = objMajorDirectionPaperRelaENS.updUser; //修改人
objMajorDirectionPaperRelaENT.memo = objMajorDirectionPaperRelaENS.memo; //备注
objMajorDirectionPaperRelaENT.sfUpdFldSetStr = objMajorDirectionPaperRelaENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objMajorDirectionPaperRelaENS:源对象
 * @param objMajorDirectionPaperRelaENT:目标对象
*/
export function MajorDirectionPaperRela_GetObjFromJsonObj(objMajorDirectionPaperRelaENS: clsMajorDirectionPaperRelaEN): clsMajorDirectionPaperRelaEN 
{
 const objMajorDirectionPaperRelaENT: clsMajorDirectionPaperRelaEN = new clsMajorDirectionPaperRelaEN();
ObjectAssign(objMajorDirectionPaperRelaENT, objMajorDirectionPaperRelaENS);
 return objMajorDirectionPaperRelaENT;
}