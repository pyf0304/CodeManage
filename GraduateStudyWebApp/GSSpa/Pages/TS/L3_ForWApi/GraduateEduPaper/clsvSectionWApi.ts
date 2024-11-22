
 /**
 * 类名:clsvSectionWApi
 * 表名:vSection(01120559)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:39
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
 * 论文节视图(vSection)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvSectionEN } from "../../L0_Entity/GraduateEduPaper/clsvSectionEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vSection_Controller = "vSectionApi";
 export const vSection_ConstructorName = "vSection";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSectionId:关键字
 * @returns 对象
 **/
export async function vSection_GetObjBySectionIdAsync(strSectionId: string): Promise<clsvSectionEN>  
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
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSection = vSection_GetObjFromJsonObj(returnObj);
return objvSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjBySectionId_Cache(strSectionId: string, bolTryAsyncOnce: boolean = true) {
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
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
try
{
const arrvSection_Sel: Array <clsvSectionEN> = arrvSectionObjLst_Cache.filter(x => x.sectionId == strSectionId);
let objvSection: clsvSectionEN;
if (arrvSection_Sel.length > 0)
{
objvSection = arrvSection_Sel[0];
return objvSection;
}
else
{
if (bolTryAsyncOnce == true)
{
objvSection = await vSection_GetObjBySectionIdAsync(strSectionId);
if (objvSection != null)
{
vSection_ReFreshThisCache();
return objvSection;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSectionId, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjBySectionId_localStorage(strSectionId: string) {
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
const strKey = Format("{0}_{1}", clsvSectionEN._CurrTabName, strSectionId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvSection_Cache: clsvSectionEN = JSON.parse(strTempObj);
return objvSection_Cache;
}
try
{
const objvSection = await vSection_GetObjBySectionIdAsync(strSectionId);
if (objvSection != null)
{
localStorage.setItem(strKey, JSON.stringify(objvSection));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvSection;
}
return objvSection;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSectionId, vSection_ConstructorName, strThisFuncName);
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
 * @returns 返回一个输出字段值
*/
export async function vSection_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvSectionEN.con_SectionId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvSectionEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvSectionEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSectionId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvSection = await vSection_GetObjBySectionId_Cache(strSectionId );
if (objvSection == null) return "";
return objvSection.GetFldValue(strOutFldName).toString();
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
export function vSection_SortFun_Defa(a:clsvSectionEN , b:clsvSectionEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.sectionId.localeCompare(b.sectionId);
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
export function vSection_SortFun_Defa_2Fld(a:clsvSectionEN , b:clsvSectionEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.sectionName == b.sectionName) return a.paperId.localeCompare(b.paperId);
else return a.sectionName.localeCompare(b.sectionName);
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
export function vSection_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvSectionEN.con_SectionId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvSectionEN.con_SectionName:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsvSectionEN.con_PaperId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvSectionEN.con_OrderNum:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.orderNum-b.orderNum;
}
case clsvSectionEN.con_UpdDate:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvSectionEN.con_UpdUser:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvSectionEN.con_Memo:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvSectionEN.con_PaperTitle:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvSectionEN.con_Author:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.author.localeCompare(b.author);
}
case clsvSectionEN.con_ResearchQuestion:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvSectionEN.con_Keyword:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvSectionEN.con_ParentId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return a.parentId.localeCompare(b.parentId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSection]中不存在！(in ${ vSection_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvSectionEN.con_SectionId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvSectionEN.con_SectionName:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsvSectionEN.con_PaperId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvSectionEN.con_OrderNum:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.orderNum-a.orderNum;
}
case clsvSectionEN.con_UpdDate:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvSectionEN.con_UpdUser:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvSectionEN.con_Memo:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvSectionEN.con_PaperTitle:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvSectionEN.con_Author:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.author.localeCompare(a.author);
}
case clsvSectionEN.con_ResearchQuestion:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvSectionEN.con_Keyword:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvSectionEN.con_ParentId:
return (a: clsvSectionEN, b: clsvSectionEN) => {
return b.parentId.localeCompare(a.parentId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSection]中不存在！(in ${ vSection_ConstructorName}.${ strThisFuncName})`;
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
export async function vSection_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvSectionEN.con_SectionId:
return (obj: clsvSectionEN) => {
return obj.sectionId === value;
}
case clsvSectionEN.con_SectionName:
return (obj: clsvSectionEN) => {
return obj.sectionName === value;
}
case clsvSectionEN.con_PaperId:
return (obj: clsvSectionEN) => {
return obj.paperId === value;
}
case clsvSectionEN.con_OrderNum:
return (obj: clsvSectionEN) => {
return obj.orderNum === value;
}
case clsvSectionEN.con_UpdDate:
return (obj: clsvSectionEN) => {
return obj.updDate === value;
}
case clsvSectionEN.con_UpdUser:
return (obj: clsvSectionEN) => {
return obj.updUser === value;
}
case clsvSectionEN.con_Memo:
return (obj: clsvSectionEN) => {
return obj.memo === value;
}
case clsvSectionEN.con_PaperTitle:
return (obj: clsvSectionEN) => {
return obj.paperTitle === value;
}
case clsvSectionEN.con_Author:
return (obj: clsvSectionEN) => {
return obj.author === value;
}
case clsvSectionEN.con_ResearchQuestion:
return (obj: clsvSectionEN) => {
return obj.researchQuestion === value;
}
case clsvSectionEN.con_Keyword:
return (obj: clsvSectionEN) => {
return obj.keyword === value;
}
case clsvSectionEN.con_ParentId:
return (obj: clsvSectionEN) => {
return obj.parentId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vSection]中不存在！(in ${ vSection_ConstructorName}.${ strThisFuncName})`;
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
export async function vSection_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetFirstObjAsync(strWhereCond: string): Promise<clsvSectionEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvSection = vSection_GetObjFromJsonObj(returnObj);
return objvSection;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSectionEN._CurrTabName;
clsvSectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSectionEN._CurrTabName);
if (IsNullOrEmpty(clsvSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSectionEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvSectionExObjLst_Cache: Array<clsvSectionEN> = CacheHelper.Get(strKey);
const arrvSectionObjLst_T = vSection_GetObjLstByJSONObjLst(arrvSectionExObjLst_Cache);
return arrvSectionObjLst_T;
}
try
{
const arrvSectionExObjLst = await vSection_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvSectionExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSectionExObjLst.length);
console.log(strInfo);
return arrvSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSection_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSectionEN._CurrTabName;
clsvSectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSectionEN._CurrTabName);
if (IsNullOrEmpty(clsvSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSectionEN.CacheAddiCondition);
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
const arrvSectionExObjLst_Cache: Array<clsvSectionEN> = JSON.parse(strTempObjLst);
const arrvSectionObjLst_T = vSection_GetObjLstByJSONObjLst(arrvSectionExObjLst_Cache);
return arrvSectionObjLst_T;
}
try
{
const arrvSectionExObjLst = await vSection_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvSectionExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSectionExObjLst.length);
console.log(strInfo);
return arrvSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSection_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvSectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvSectionObjLst_Cache: Array<clsvSectionEN> = JSON.parse(strTempObjLst);
return arrvSectionObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vSection_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvSectionEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvSectionEN._CurrTabName;
clsvSectionEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvSectionEN._CurrTabName);
if (IsNullOrEmpty(clsvSectionEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvSectionEN.CacheAddiCondition);
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
const arrvSectionExObjLst_Cache: Array<clsvSectionEN> = JSON.parse(strTempObjLst);
const arrvSectionObjLst_T = vSection_GetObjLstByJSONObjLst(arrvSectionExObjLst_Cache);
return arrvSectionObjLst_T;
}
try
{
const arrvSectionExObjLst = await vSection_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvSectionExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSectionExObjLst.length);
console.log(strInfo);
return arrvSectionExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSection_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvSectionEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvSectionObjLst_Cache: Array<clsvSectionEN> = JSON.parse(strTempObjLst);
return arrvSectionObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSection_GetObjLst_Cache(): Promise<Array<clsvSectionEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvSectionObjLst_Cache;
switch (clsvSectionEN.CacheModeId)
{
case "04"://sessionStorage
arrvSectionObjLst_Cache = await vSection_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvSectionObjLst_Cache = await vSection_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvSectionObjLst_Cache = await vSection_GetObjLst_ClientCache();
break;
default:
arrvSectionObjLst_Cache = await vSection_GetObjLst_ClientCache();
break;
}
const arrvSectionObjLst = vSection_GetObjLstByJSONObjLst(arrvSectionObjLst_Cache);
return arrvSectionObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vSection_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvSectionObjLst_Cache;
switch (clsvSectionEN.CacheModeId)
{
case "04"://sessionStorage
arrvSectionObjLst_Cache = await vSection_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvSectionObjLst_Cache = await vSection_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvSectionObjLst_Cache = null;
break;
default:
arrvSectionObjLst_Cache = null;
break;
}
return arrvSectionObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSectionId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vSection_GetSubObjLst_Cache(objvSection_Cond: clsvSectionEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
let arrvSection_Sel: Array < clsvSectionEN > = arrvSectionObjLst_Cache;
if (objvSection_Cond.sf_FldComparisonOp == null || objvSection_Cond.sf_FldComparisonOp == "") return arrvSection_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSection_Cond.sf_FldComparisonOp);
//console.log("clsvSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvSection_Cond), vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSectionEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSectionId:关键字列表
 * @returns 对象列表
 **/
export async function vSection_GetObjLstBySectionIdLstAsync(arrSectionId: Array<string>): Promise<Array<clsvSectionEN>>  
{
const strThisFuncName = "GetObjLstBySectionIdLstAsync";
const strAction = "GetObjLstBySectionIdLst";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSectionId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLstBySectionIdLst_Cache(arrSectionIdLst: Array<string>) {
const strThisFuncName = "GetObjLstBySectionIdLst_Cache";
try
{
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
const arrvSection_Sel: Array <clsvSectionEN> = arrvSectionObjLst_Cache.filter(x => arrSectionIdLst.indexOf(x.sectionId)>-1);
return arrvSection_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSectionIdLst.join(","), vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSectionEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vSection_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvSectionEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvSectionEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
if (arrvSectionObjLst_Cache.length == 0) return arrvSectionObjLst_Cache;
let arrvSection_Sel = arrvSectionObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvSection_Cond = new clsvSectionEN();
ObjectAssign(objvSection_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvSectionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSection_Sel = arrvSection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSection_Sel.length == 0) return arrvSection_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvSection_Sel = arrvSection_Sel.sort(vSection_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvSection_Sel = arrvSection_Sel.sort(objPagerPara.sortFun);
}
arrvSection_Sel = arrvSection_Sel.slice(intStart, intEnd);     
return arrvSection_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vSection_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvSectionEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vSection_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvSectionEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vSection_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vSection_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vSection_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vSection_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvSectionEN);
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vSection_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvSectionEN);
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vSection_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvSectionEN);
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSectionEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vSection_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objvSectionEN);
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_IsExistRecord_Cache(objvSection_Cond: clsvSectionEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
if (arrvSectionObjLst_Cache == null) return false;
let arrvSection_Sel: Array < clsvSectionEN > = arrvSectionObjLst_Cache;
if (objvSection_Cond.sf_FldComparisonOp == null || objvSection_Cond.sf_FldComparisonOp == "") return arrvSection_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSection_Cond.sf_FldComparisonOp);
//console.log("clsvSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvSection_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvSection_Cond), vSection_ConstructorName, strThisFuncName);
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
export async function vSection_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_IsExist(strSectionId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_IsExist_Cache(strSectionId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
if (arrvSectionObjLst_Cache == null) return false;
try
{
const arrvSection_Sel: Array <clsvSectionEN> = arrvSectionObjLst_Cache.filter(x => x.sectionId == strSectionId);
if (arrvSection_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSectionId, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_IsExistAsync(strSectionId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
export async function vSection_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vSection_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vSection_ConstructorName, strThisFuncName);
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
 * @param objvSection_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vSection_GetRecCountByCond_Cache(objvSection_Cond: clsvSectionEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvSectionObjLst_Cache = await vSection_GetObjLst_Cache();
if (arrvSectionObjLst_Cache == null) return 0;
let arrvSection_Sel: Array < clsvSectionEN > = arrvSectionObjLst_Cache;
if (objvSection_Cond.sf_FldComparisonOp == null || objvSection_Cond.sf_FldComparisonOp == "") return arrvSection_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvSection_Cond.sf_FldComparisonOp);
//console.log("clsvSectionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvSection_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvSection_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvSection_Sel = arrvSection_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvSection_Sel = arrvSection_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvSection_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvSection_Cond), vSection_ConstructorName, strThisFuncName);
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
export function vSection_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vSection_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvSectionEN._CurrTabName;
switch (clsvSectionEN.CacheModeId)
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
export function vSection_GetJSONStrByObj (pobjvSectionEN: clsvSectionEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvSectionEN);
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
export function vSection_GetObjLstByJSONStr (strJSON: string): Array<clsvSectionEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvSectionObjLst = new Array<clsvSectionEN>();
if (strJSON === "")
{
return arrvSectionObjLst;
}
try
{
arrvSectionObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvSectionObjLst;
}
return arrvSectionObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvSectionObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vSection_GetObjLstByJSONObjLst (arrvSectionObjLstS: Array<clsvSectionEN>): Array<clsvSectionEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvSectionObjLst = new Array<clsvSectionEN>();
for (const objInFor of arrvSectionObjLstS) {
const obj1 = vSection_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvSectionObjLst.push(obj1);
}
return arrvSectionObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vSection_GetObjByJSONStr (strJSON: string): clsvSectionEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvSectionEN = new clsvSectionEN();
if (strJSON === "")
{
return pobjvSectionEN;
}
try
{
pobjvSectionEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvSectionEN;
}
return pobjvSectionEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vSection_GetCombineCondition(objvSection_Cond: clsvSectionEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_SectionId, objvSection_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_SectionName, objvSection_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_PaperId, objvSection_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvSectionEN.con_OrderNum, objvSection_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_UpdDate, objvSection_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_UpdUser, objvSection_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_Memo, objvSection_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_PaperTitle, objvSection_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_Author, objvSection_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_ResearchQuestion, objvSection_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_Keyword, objvSection_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvSection_Cond.dicFldComparisonOp, clsvSectionEN.con_ParentId) == true)
{
const strComparisonOp_ParentId:string = objvSection_Cond.dicFldComparisonOp[clsvSectionEN.con_ParentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvSectionEN.con_ParentId, objvSection_Cond.parentId, strComparisonOp_ParentId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvSectionENS:源对象
 * @param objvSectionENT:目标对象
*/
export function vSection_CopyObjTo(objvSectionENS: clsvSectionEN , objvSectionENT: clsvSectionEN ): void 
{
objvSectionENT.sectionId = objvSectionENS.sectionId; //节Id
objvSectionENT.sectionName = objvSectionENS.sectionName; //节名
objvSectionENT.paperId = objvSectionENS.paperId; //节名称
objvSectionENT.orderNum = objvSectionENS.orderNum; //序号
objvSectionENT.updDate = objvSectionENS.updDate; //修改日期
objvSectionENT.updUser = objvSectionENS.updUser; //修改人
objvSectionENT.memo = objvSectionENS.memo; //备注
objvSectionENT.paperTitle = objvSectionENS.paperTitle; //论文标题
objvSectionENT.author = objvSectionENS.author; //作者
objvSectionENT.researchQuestion = objvSectionENS.researchQuestion; //研究问题
objvSectionENT.keyword = objvSectionENS.keyword; //关键字
objvSectionENT.parentId = objvSectionENS.parentId; //父节点Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvSectionENS:源对象
 * @param objvSectionENT:目标对象
*/
export function vSection_GetObjFromJsonObj(objvSectionENS: clsvSectionEN): clsvSectionEN 
{
 const objvSectionENT: clsvSectionEN = new clsvSectionEN();
ObjectAssign(objvSectionENT, objvSectionENS);
 return objvSectionENT;
}