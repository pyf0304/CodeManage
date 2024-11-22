
 /**
 * 类名:clsSectionWApi
 * 表名:Section(01120558)
 * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
 * 日期:2023/02/26 22:33:17
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
 * 论文节表(Section)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年02月26日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";

import { clsSectionEN } from "../../L0_Entity/GraduateEduPaper/clsSectionEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { vSection_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduPaper/clsvSectionWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const section_Controller = "SectionApi";
 export const section_ConstructorName = "section";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSectionId:关键字
 * @returns 对象
 **/
export async function Section_GetObjBySectionIdAsync(strSectionId: string): Promise<clsSectionEN|null>  
{
const strThisFuncName = "GetObjBySectionIdAsync";

if (IsNullOrEmpty(strSectionId) == true)
{
  const strMsg = Format("参数:[strSectionId]不能为空！(In GetObjBySectionIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySectionId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSectionId": strSectionId,
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
const objSection = Section_GetObjFromJsonObj(returnObj);
return objSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:所给的关键字
 * @returns 对象
*/
export async function Section_GetObjBySectionId_Cache(strSectionId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySectionId_Cache";

if (IsNullOrEmpty(strSectionId) == true)
{
  const strMsg = Format("参数:[strSectionId]不能为空！(In GetObjBySectionId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
try
{
const arrSection_Sel: Array <clsSectionEN> = arrSectionObjLst_Cache.filter(x => 
 x.sectionId == strSectionId );
let objSection: clsSectionEN;
if (arrSection_Sel.length > 0)
{
objSection = arrSection_Sel[0];
return objSection;
}
else
{
if (bolTryAsyncOnce == true)
{
const objSection_Const = await Section_GetObjBySectionIdAsync(strSectionId);
if (objSection_Const != null)
{
Section_ReFreshThisCache();
return objSection_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSectionId, section_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strSectionId:所给的关键字
 * @returns 对象
*/
export async function Section_GetObjBySectionId_localStorage(strSectionId: string) {
const strThisFuncName = "GetObjBySectionId_localStorage";

if (IsNullOrEmpty(strSectionId) == true)
{
  const strMsg = Format("参数:[strSectionId]不能为空！(In GetObjBySectionId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSectionEN._CurrTabName, strSectionId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSection_Cache: clsSectionEN = JSON.parse(strTempObj);
return objSection_Cache;
}
try
{
const objSection = await Section_GetObjBySectionIdAsync(strSectionId);
if (objSection != null)
{
localStorage.setItem(strKey, JSON.stringify(objSection));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSection;
}
return objSection;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSectionId, section_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSection:所给的对象
 * @returns 对象
*/
export async function Section_UpdateObjInLst_Cache(objSection: clsSectionEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
const obj = arrSectionObjLst_Cache.find(x => x.sectionName == objSection.sectionName && x.paperId == objSection.paperId);
if (obj != null)
{
objSection.sectionId = obj.sectionId;
ObjectAssign( obj, objSection);
}
else
{
arrSectionObjLst_Cache.push(objSection);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, section_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strSectionId:所给的关键字
 * @returns 对象
*/
export async function Section_GetNameBySectionId_Cache(strSectionId: string) {
const strThisFuncName = "GetNameBySectionId_Cache";

if (IsNullOrEmpty(strSectionId) == true)
{
  const strMsg = Format("参数:[strSectionId]不能为空！(In GetNameBySectionId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSectionId.length != 8)
{
const strMsg = Format("缓存分类变量:[strSectionId]的长度:[{0}]不正确！", strSectionId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
if (arrSectionObjLst_Cache == null) return "";
try
{
const arrSection_Sel: Array <clsSectionEN> = arrSectionObjLst_Cache.filter(x => 
 x.sectionId == strSectionId );
let objSection: clsSectionEN;
if (arrSection_Sel.length > 0)
{
objSection = arrSection_Sel[0];
return objSection.sectionName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSectionId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function Section_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsSectionEN.con_SectionId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSectionEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsSectionEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSectionId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSection = await Section_GetObjBySectionId_Cache(strSectionId );
if (objSection == null) return "";
if (objSection.GetFldValue(strOutFldName) == null) return "";
return objSection.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function Section_SortFun_Defa(a:clsSectionEN , b:clsSectionEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.sectionId.localeCompare(b.sectionId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function Section_SortFun_Defa_2Fld(a:clsSectionEN , b:clsSectionEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.sectionName == b.sectionName) return a.paperId.localeCompare(b.paperId);
else return a.sectionName.localeCompare(b.sectionName);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function Section_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsSectionEN.con_SectionName:
return (a: clsSectionEN, b: clsSectionEN) => {
if (a.sectionName == null) return -1;
if (b.sectionName == null) return 1;
return a.sectionName.localeCompare(b.sectionName);
}
case clsSectionEN.con_PaperId:
return (a: clsSectionEN, b: clsSectionEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsSectionEN.con_ParentId:
return (a: clsSectionEN, b: clsSectionEN) => {
if (a.parentId == null) return -1;
if (b.parentId == null) return 1;
return a.parentId.localeCompare(b.parentId);
}
case clsSectionEN.con_OrderNum:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.orderNum-b.orderNum;
}
case clsSectionEN.con_UpdDate:
return (a: clsSectionEN, b: clsSectionEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsSectionEN.con_UpdUser:
return (a: clsSectionEN, b: clsSectionEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSectionEN.con_Memo:
return (a: clsSectionEN, b: clsSectionEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsSectionEN.con_SectionName:
return (a: clsSectionEN, b: clsSectionEN) => {
if (b.sectionName == null) return -1;
if (a.sectionName == null) return 1;
return b.sectionName.localeCompare(a.sectionName);
}
case clsSectionEN.con_PaperId:
return (a: clsSectionEN, b: clsSectionEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsSectionEN.con_ParentId:
return (a: clsSectionEN, b: clsSectionEN) => {
if (b.parentId == null) return -1;
if (a.parentId == null) return 1;
return b.parentId.localeCompare(a.parentId);
}
case clsSectionEN.con_OrderNum:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.orderNum-a.orderNum;
}
case clsSectionEN.con_UpdDate:
return (a: clsSectionEN, b: clsSectionEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsSectionEN.con_UpdUser:
return (a: clsSectionEN, b: clsSectionEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSectionEN.con_Memo:
return (a: clsSectionEN, b: clsSectionEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function Section_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSectionEN.con_SectionId:
return (obj: clsSectionEN) => {
return obj.sectionId === value;
}
case clsSectionEN.con_SectionName:
return (obj: clsSectionEN) => {
return obj.sectionName === value;
}
case clsSectionEN.con_PaperId:
return (obj: clsSectionEN) => {
return obj.paperId === value;
}
case clsSectionEN.con_ParentId:
return (obj: clsSectionEN) => {
return obj.parentId === value;
}
case clsSectionEN.con_OrderNum:
return (obj: clsSectionEN) => {
return obj.orderNum === value;
}
case clsSectionEN.con_UpdDate:
return (obj: clsSectionEN) => {
return obj.updDate === value;
}
case clsSectionEN.con_UpdUser:
return (obj: clsSectionEN) => {
return obj.updUser === value;
}
case clsSectionEN.con_Memo:
return (obj: clsSectionEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Section]中不存在！(in ${ section_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 * @returns 返回一个关键字值列表
*/
export async function Section_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsSectionEN.con_SectionId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrSection = await Section_GetObjLst_Cache();
if (arrSection == null) return [];
let arrSection_Sel = arrSection;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrSection_Sel = arrSection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrSection_Sel.length == 0) return [];
return arrSection_Sel.map(x=>x.sectionId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function Section_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetFirstObjAsync(strWhereCond: string): Promise<clsSectionEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const objSection = Section_GetObjFromJsonObj(returnObj);
return objSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSectionEN._CurrTabName;
if (IsNullOrEmpty(clsSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSectionEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSectionExObjLst_Cache: Array<clsSectionEN> = CacheHelper.Get(strKey);
const arrSectionObjLst_T = Section_GetObjLstByJSONObjLst(arrSectionExObjLst_Cache);
return arrSectionObjLst_T;
}
try
{
const arrSectionExObjLst = await Section_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSectionExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSectionExObjLst.length);
console.log(strInfo);
return arrSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Section_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSectionEN._CurrTabName;
if (IsNullOrEmpty(clsSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSectionEN.CacheAddiCondition);
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
const arrSectionExObjLst_Cache: Array<clsSectionEN> = JSON.parse(strTempObjLst);
const arrSectionObjLst_T = Section_GetObjLstByJSONObjLst(arrSectionExObjLst_Cache);
return arrSectionObjLst_T;
}
try
{
const arrSectionExObjLst = await Section_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSectionExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSectionExObjLst.length);
console.log(strInfo);
return arrSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Section_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSectionObjLst_Cache: Array<clsSectionEN> = JSON.parse(strTempObjLst);
return arrSectionObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function Section_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsSectionEN._CurrTabName;
if (IsNullOrEmpty(clsSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSectionEN.CacheAddiCondition);
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
const arrSectionExObjLst_Cache: Array<clsSectionEN> = JSON.parse(strTempObjLst);
const arrSectionObjLst_T = Section_GetObjLstByJSONObjLst(arrSectionExObjLst_Cache);
return arrSectionObjLst_T;
}
try
{
const arrSectionExObjLst = await Section_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSectionExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSectionExObjLst.length);
console.log(strInfo);
return arrSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Section_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsSectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSectionObjLst_Cache: Array<clsSectionEN> = JSON.parse(strTempObjLst);
return arrSectionObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Section_GetObjLst_Cache(): Promise<Array<clsSectionEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrSectionObjLst_Cache;
switch (clsSectionEN.CacheModeId)
{
case "04"://sessionStorage
arrSectionObjLst_Cache = await Section_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrSectionObjLst_Cache = await Section_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrSectionObjLst_Cache = await Section_GetObjLst_ClientCache();
break;
default:
arrSectionObjLst_Cache = await Section_GetObjLst_ClientCache();
break;
}
const arrSectionObjLst = Section_GetObjLstByJSONObjLst(arrSectionObjLst_Cache);
return arrSectionObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Section_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSectionObjLst_Cache;
switch (clsSectionEN.CacheModeId)
{
case "04"://sessionStorage
arrSectionObjLst_Cache = await Section_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrSectionObjLst_Cache = await Section_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrSectionObjLst_Cache = null;
break;
default:
arrSectionObjLst_Cache = null;
break;
}
return arrSectionObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSectionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Section_GetSubObjLst_Cache(objSection_Cond: clsSectionEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
let arrSection_Sel: Array < clsSectionEN > = arrSectionObjLst_Cache;
if (objSection_Cond.sf_FldComparisonOp == null || objSection_Cond.sf_FldComparisonOp == "") return arrSection_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSection_Cond.sf_FldComparisonOp);
//console.log("clsSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSection_Cond), section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSectionEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSectionId:关键字列表
 * @returns 对象列表
 **/
export async function Section_GetObjLstBySectionIdLstAsync(arrSectionId: Array<string>): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstBySectionIdLstAsync";
const strAction = "GetObjLstBySectionIdLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSectionId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param arrstrSectionIdLst:关键字列表
 * @returns 对象列表
*/
export async function Section_GetObjLstBySectionIdLst_Cache(arrSectionIdLst: Array<string>) {
const strThisFuncName = "GetObjLstBySectionIdLst_Cache";
try
{
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
const arrSection_Sel: Array <clsSectionEN> = arrSectionObjLst_Cache.filter(x => arrSectionIdLst.indexOf(x.sectionId)>-1);
return arrSection_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSectionIdLst.join(","), section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSectionEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function Section_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsSectionEN>();
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
if (arrSectionObjLst_Cache.length == 0) return arrSectionObjLst_Cache;
let arrSection_Sel = arrSectionObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSection_Cond = new clsSectionEN();
ObjectAssign(objSection_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSection_Sel = arrSection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSection_Sel.length == 0) return arrSection_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSection_Sel = arrSection_Sel.sort(Section_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSection_Sel = arrSection_Sel.sort(objPagerPara.sortFun);
}
arrSection_Sel = arrSection_Sel.slice(intStart, intEnd);     
return arrSection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, section_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSectionEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function Section_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSectionEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsSectionEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", section_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Section_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:关键字
 * @returns 获取删除的结果
 **/
export async function Section_DelRecordAsync(strSectionId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(section_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strSectionId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param arrSectionId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function Section_DelSectionsAsync(arrSectionId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSectionsAsync";
const strAction = "DelSections";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSectionId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_DelSectionsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSectionsByCondAsync";
const strAction = "DelSectionsByCond";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_AddNewRecordAsync(objSectionEN: clsSectionEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_AddNewRecordWithMaxIdAsync(objSectionEN: clsSectionEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Section_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objSectionEN);
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function Section_AddNewRecordWithReturnKeyAsync(objSectionEN: clsSectionEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function Section_AddNewRecordWithReturnKey(objSectionEN: clsSectionEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSectionEN.sectionId === null || objSectionEN.sectionId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function Section_UpdateRecordAsync(objSectionEN: clsSectionEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSectionEN.sfUpdFldSetStr === undefined || objSectionEN.sfUpdFldSetStr === null || objSectionEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSectionEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function Section_UpdateWithConditionAsync(objSectionEN: clsSectionEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSectionEN.sfUpdFldSetStr === undefined || objSectionEN.sfUpdFldSetStr === null || objSectionEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSectionEN.sectionId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(section_Controller, strAction);
objSectionEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSectionEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objstrSectionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Section_IsExistRecord_Cache(objSection_Cond: clsSectionEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
if (arrSectionObjLst_Cache == null) return false;
let arrSection_Sel: Array < clsSectionEN > = arrSectionObjLst_Cache;
if (objSection_Cond.sf_FldComparisonOp == null || objSection_Cond.sf_FldComparisonOp == "") return arrSection_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSection_Cond.sf_FldComparisonOp);
//console.log("clsSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSection_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSection_Cond), section_ConstructorName, strThisFuncName);
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
export async function Section_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function Section_IsExist(strSectionId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SectionId": strSectionId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param strSectionId:所给的关键字
 * @returns 对象
*/
export async function Section_IsExist_Cache(strSectionId:string) {
const strThisFuncName = "IsExist_Cache";
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
if (arrSectionObjLst_Cache == null) return false;
try
{
const arrSection_Sel: Array <clsSectionEN> = arrSectionObjLst_Cache.filter(x => x.sectionId == strSectionId);
if (arrSection_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSectionId, section_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strSectionId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function Section_IsExistAsync(strSectionId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(section_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSectionId": strSectionId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
 * @param objSection_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function Section_GetRecCountByCond_Cache(objSection_Cond: clsSectionEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSectionObjLst_Cache = await Section_GetObjLst_Cache();
if (arrSectionObjLst_Cache == null) return 0;
let arrSection_Sel: Array < clsSectionEN > = arrSectionObjLst_Cache;
if (objSection_Cond.sf_FldComparisonOp == null || objSection_Cond.sf_FldComparisonOp == "") return arrSection_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSection_Cond.sf_FldComparisonOp);
//console.log("clsSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSection_Sel = arrSection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSection_Sel = arrSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSection_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSection_Cond), section_ConstructorName, strThisFuncName);
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
export async function Section_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export async function Section_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(section_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, section_ConstructorName, strThisFuncName);
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
export function Section_GetWebApiUrl(strController: string, strAction: string): string {
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
export function Section_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsSectionEN._CurrTabName;
switch (clsSectionEN.CacheModeId)
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
vSection_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function Section_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsSectionEN._CurrTabName;
switch (clsSectionEN.CacheModeId)
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

/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
 * @param strPaperId:节名称
*/
export async function Section_BindDdl_SectionIdByPaperIdInDiv_Cache(strDivName: string, strDdlName: string , strPaperId: string)
{
const strThisFuncName = "BindDdl_SectionIdByPaperIdInDiv_Cache";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In BindDdl_SectionIdByPaperIdInDiv)");
console.error(strMsg);
 throw (strMsg);
}

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_SectionIdByPaperIdInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_SectionIdByPaperIdInDiv_Cache");
let arrObjLst_Sel = await Section_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
arrObjLst_Sel = arrObjLst_Sel.filter(x=>x.paperId == strPaperId);
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsSectionEN.con_SectionId, clsSectionEN.con_SectionName, "论文节表");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Section_CheckPropertyNew(pobjSectionEN: clsSectionEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSectionEN.updUser) === true )
{
 throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文节表)!(clsSectionBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && GetStrLen(pobjSectionEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && GetStrLen(pobjSectionEN.sectionName) > 100)
{
 throw new Error("(errid:Watl000059)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && GetStrLen(pobjSectionEN.paperId) > 500)
{
 throw new Error("(errid:Watl000059)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && GetStrLen(pobjSectionEN.parentId) > 10)
{
 throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && GetStrLen(pobjSectionEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && GetStrLen(pobjSectionEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && GetStrLen(pobjSectionEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && tzDataType.isString(pobjSectionEN.sectionId) === false)
{
 throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && tzDataType.isString(pobjSectionEN.sectionName) === false)
{
 throw new Error("(errid:Watl000060)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && tzDataType.isString(pobjSectionEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && tzDataType.isString(pobjSectionEN.parentId) === false)
{
 throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && tzDataType.isNumber(pobjSectionEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && tzDataType.isString(pobjSectionEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && tzDataType.isString(pobjSectionEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && tzDataType.isString(pobjSectionEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSectionEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Section_CheckProperty4Update (pobjSectionEN: clsSectionEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && GetStrLen(pobjSectionEN.sectionId) > 8)
{
 throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文节表(Section))!值:$(pobjSectionEN.sectionId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && GetStrLen(pobjSectionEN.sectionName) > 100)
{
 throw new Error("(errid:Watl000062)字段[节名(sectionName)]的长度不能超过100(In 论文节表(Section))!值:$(pobjSectionEN.sectionName)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && GetStrLen(pobjSectionEN.paperId) > 500)
{
 throw new Error("(errid:Watl000062)字段[节名称(paperId)]的长度不能超过500(In 论文节表(Section))!值:$(pobjSectionEN.paperId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && GetStrLen(pobjSectionEN.parentId) > 10)
{
 throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 论文节表(Section))!值:$(pobjSectionEN.parentId)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && GetStrLen(pobjSectionEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updDate)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && GetStrLen(pobjSectionEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文节表(Section))!值:$(pobjSectionEN.updUser)(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && GetStrLen(pobjSectionEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文节表(Section))!值:$(pobjSectionEN.memo)(clsSectionBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSectionEN.sectionId) == false && undefined !== pobjSectionEN.sectionId && tzDataType.isString(pobjSectionEN.sectionId) === false)
{
 throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjSectionEN.sectionId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.sectionName) == false && undefined !== pobjSectionEN.sectionName && tzDataType.isString(pobjSectionEN.sectionName) === false)
{
 throw new Error("(errid:Watl000063)字段[节名(sectionName)]的值:[$(pobjSectionEN.sectionName)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.paperId) == false && undefined !== pobjSectionEN.paperId && tzDataType.isString(pobjSectionEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[节名称(paperId)]的值:[$(pobjSectionEN.paperId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.parentId) == false && undefined !== pobjSectionEN.parentId && tzDataType.isString(pobjSectionEN.parentId) === false)
{
 throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjSectionEN.parentId)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (null != pobjSectionEN.orderNum && undefined !== pobjSectionEN.orderNum && tzDataType.isNumber(pobjSectionEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjSectionEN.orderNum)], 非法，应该为数值型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updDate) == false && undefined !== pobjSectionEN.updDate && tzDataType.isString(pobjSectionEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSectionEN.updDate)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.updUser) == false && undefined !== pobjSectionEN.updUser && tzDataType.isString(pobjSectionEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSectionEN.updUser)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSectionEN.memo) == false && undefined !== pobjSectionEN.memo && tzDataType.isString(pobjSectionEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSectionEN.memo)], 非法，应该为字符型(In 论文节表(Section))!(clsSectionBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSectionEN.sectionId) === true )
{
 throw new Error("(errid:Watl000064)字段[节Id]不能为空(In 论文节表)!(clsSectionBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSectionEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Section_GetJSONStrByObj (pobjSectionEN: clsSectionEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSectionEN.sfUpdFldSetStr = pobjSectionEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSectionEN);
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
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function Section_GetObjLstByJSONStr (strJSON: string): Array<clsSectionEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSectionObjLst = new Array<clsSectionEN>();
if (strJSON === "")
{
return arrSectionObjLst;
}
try
{
arrSectionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSectionObjLst;
}
return arrSectionObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSectionObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function Section_GetObjLstByJSONObjLst (arrSectionObjLstS: Array<clsSectionEN>): Array<clsSectionEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSectionObjLst = new Array<clsSectionEN>();
for (const objInFor of arrSectionObjLstS) {
const obj1 = Section_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSectionObjLst.push(obj1);
}
return arrSectionObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-02-26
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Section_GetObjByJSONStr (strJSON: string): clsSectionEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSectionEN = new clsSectionEN();
if (strJSON === "")
{
return pobjSectionEN;
}
try
{
pobjSectionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSectionEN;
}
return pobjSectionEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function Section_GetCombineCondition(objSection_Cond: clsSectionEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_SectionId, objSection_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_SectionName, objSection_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_PaperId, objSection_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_ParentId, objSection_Cond.parentId, strComparisonOp_ParentId);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsSectionEN.con_OrderNum, objSection_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_UpdDate, objSection_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_UpdUser, objSection_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSection_Cond.dicFldComparisonOp, clsSectionEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSection_Cond.dicFldComparisonOp[clsSectionEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSectionEN.con_Memo, objSection_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSectionName: 节名(要求唯一的字段)
 * @param strPaperId: 节名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function Section_GetUniCondStr_PaperId_SectionName(objSectionEN: clsSectionEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SectionName = '{0}'", objSectionEN.sectionName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objSectionEN.paperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--Section(论文节表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSectionName: 节名(要求唯一的字段)
 * @param strPaperId: 节名称(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function Section_GetUniCondStr4Update_PaperId_SectionName(objSectionEN: clsSectionEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SectionId <> '{0}'", objSectionEN.sectionId);
 strWhereCond +=  Format(" and SectionName = '{0}'", objSectionEN.sectionName);
 strWhereCond +=  Format(" and PaperId = '{0}'", objSectionEN.paperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSectionENS:源对象
 * @param objSectionENT:目标对象
*/
export function Section_CopyObjTo(objSectionENS: clsSectionEN , objSectionENT: clsSectionEN ): void 
{
objSectionENT.sectionId = objSectionENS.sectionId; //节Id
objSectionENT.sectionName = objSectionENS.sectionName; //节名
objSectionENT.paperId = objSectionENS.paperId; //节名称
objSectionENT.parentId = objSectionENS.parentId; //父节点Id
objSectionENT.orderNum = objSectionENS.orderNum; //序号
objSectionENT.updDate = objSectionENS.updDate; //修改日期
objSectionENT.updUser = objSectionENS.updUser; //修改人
objSectionENT.memo = objSectionENS.memo; //备注
objSectionENT.sfUpdFldSetStr = objSectionENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSectionENS:源对象
 * @param objSectionENT:目标对象
*/
export function Section_GetObjFromJsonObj(objSectionENS: clsSectionEN): clsSectionEN 
{
 const objSectionENT: clsSectionEN = new clsSectionEN();
ObjectAssign(objSectionENT, objSectionENS);
 return objSectionENT;
}