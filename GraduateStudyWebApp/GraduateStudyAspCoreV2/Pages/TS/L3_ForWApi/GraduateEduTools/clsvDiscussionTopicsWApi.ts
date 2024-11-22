
 /**
 * 类名:clsvDiscussionTopicsWApi
 * 表名:vDiscussionTopics(01120586)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:52
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v讨论主题视图(vDiscussionTopics)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvDiscussionTopicsEN } from "../../L0_Entity/GraduateEduTools/clsvDiscussionTopicsEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vDiscussionTopics_Controller = "vDiscussionTopicsApi";
 export const vDiscussionTopics_ConstructorName = "vDiscussionTopics";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTopicsId:关键字
 * @returns 对象
 **/
export async function vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId: string): Promise<clsvDiscussionTopicsEN|null>  
{
const strThisFuncName = "GetObjByTopicsIdAsync";

if (IsNullOrEmpty(strTopicsId) == true)
{
  const strMsg = Format("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicsId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsIdAsync)", strTopicsId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTopicsId";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTopicsId": strTopicsId,
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
const objvDiscussionTopics = vDiscussionTopics_GetObjFromJsonObj(returnObj);
return objvDiscussionTopics;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param strTopicsId:所给的关键字
 * @returns 对象
*/
export async function vDiscussionTopics_GetObjByTopicsId_Cache(strTopicsId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTopicsId_Cache";

if (IsNullOrEmpty(strTopicsId) == true)
{
  const strMsg = Format("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicsId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsId_Cache)", strTopicsId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvDiscussionTopics_Sel: Array <clsvDiscussionTopicsEN> = arrvDiscussionTopicsObjLst_Cache.filter(x => 
 x.topicsId == strTopicsId );
let objvDiscussionTopics: clsvDiscussionTopicsEN;
if (arrvDiscussionTopics_Sel.length > 0)
{
objvDiscussionTopics = arrvDiscussionTopics_Sel[0];
return objvDiscussionTopics;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvDiscussionTopics_Const = await vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
if (objvDiscussionTopics_Const != null)
{
vDiscussionTopics_ReFreshThisCache(strid_CurrEduCls);
return objvDiscussionTopics_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTopicsId:所给的关键字
 * @returns 对象
*/
export async function vDiscussionTopics_GetObjByTopicsId_localStorage(strTopicsId: string) {
const strThisFuncName = "GetObjByTopicsId_localStorage";

if (IsNullOrEmpty(strTopicsId) == true)
{
  const strMsg = Format("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTopicsId.length != 8)
{
const strMsg = Format("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsId_localStorage)", strTopicsId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strTopicsId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvDiscussionTopics_Cache: clsvDiscussionTopicsEN = JSON.parse(strTempObj);
return objvDiscussionTopics_Cache;
}
try
{
const objvDiscussionTopics = await vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
if (objvDiscussionTopics != null)
{
localStorage.setItem(strKey, JSON.stringify(objvDiscussionTopics));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvDiscussionTopics;
}
return objvDiscussionTopics;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvDiscussionTopicsWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvDiscussionTopicsEN.con_TopicsId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvDiscussionTopicsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvDiscussionTopicsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTopicsId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvDiscussionTopics = await vDiscussionTopics_GetObjByTopicsId_Cache(strTopicsId , strid_CurrEduCls_C);
if (objvDiscussionTopics == null) return "";
if (objvDiscussionTopics.GetFldValue(strOutFldName) == null) return "";
return objvDiscussionTopics.GetFldValue(strOutFldName).toString();
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
export function vDiscussionTopics_SortFun_Defa(a:clsvDiscussionTopicsEN , b:clsvDiscussionTopicsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.topicsId.localeCompare(b.topicsId);
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
export function vDiscussionTopics_SortFun_Defa_2Fld(a:clsvDiscussionTopicsEN , b:clsvDiscussionTopicsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.discussionTypeId == b.discussionTypeId) return a.discussionTypeName.localeCompare(b.discussionTypeName);
else return a.discussionTypeId.localeCompare(b.discussionTypeId);
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
export function vDiscussionTopics_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvDiscussionTopicsEN.con_TopicsId:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return a.topicsId.localeCompare(b.topicsId);
}
case clsvDiscussionTopicsEN.con_DiscussionTypeId:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return a.discussionTypeId.localeCompare(b.discussionTypeId);
}
case clsvDiscussionTopicsEN.con_DiscussionTypeName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.discussionTypeName == null) return -1;
if (b.discussionTypeName == null) return 1;
return a.discussionTypeName.localeCompare(b.discussionTypeName);
}
case clsvDiscussionTopicsEN.con_TopicsTitle:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.topicsTitle == null) return -1;
if (b.topicsTitle == null) return 1;
return a.topicsTitle.localeCompare(b.topicsTitle);
}
case clsvDiscussionTopicsEN.con_TopicsContent:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.topicsContent == null) return -1;
if (b.topicsContent == null) return 1;
return a.topicsContent.localeCompare(b.topicsContent);
}
case clsvDiscussionTopicsEN.con_IsAudit:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.isAudit == true) return 1;
else return -1
}
case clsvDiscussionTopicsEN.con_IsTop:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.isTop == true) return 1;
else return -1
}
case clsvDiscussionTopicsEN.con_BrowseNumber:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return a.browseNumber-b.browseNumber;
}
case clsvDiscussionTopicsEN.con_UpdDate:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvDiscussionTopicsEN.con_UpdUser:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvDiscussionTopicsEN.con_Memo:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvDiscussionTopicsEN.con_CollegeName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.collegeName == null) return -1;
if (b.collegeName == null) return 1;
return a.collegeName.localeCompare(b.collegeName);
}
case clsvDiscussionTopicsEN.con_id_XzCollege:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.id_XzCollege == null) return -1;
if (b.id_XzCollege == null) return 1;
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvDiscussionTopicsEN.con_id_XzMajor:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.id_XzMajor == null) return -1;
if (b.id_XzMajor == null) return 1;
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvDiscussionTopicsEN.con_MajorName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.majorName == null) return -1;
if (b.majorName == null) return 1;
return a.majorName.localeCompare(b.majorName);
}
case clsvDiscussionTopicsEN.con_UserName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
case clsvDiscussionTopicsEN.con_SubCount:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return a.subCount-b.subCount;
}
case clsvDiscussionTopicsEN.con_id_CurrEduCls:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${ vDiscussionTopics_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvDiscussionTopicsEN.con_TopicsId:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return b.topicsId.localeCompare(a.topicsId);
}
case clsvDiscussionTopicsEN.con_DiscussionTypeId:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return b.discussionTypeId.localeCompare(a.discussionTypeId);
}
case clsvDiscussionTopicsEN.con_DiscussionTypeName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.discussionTypeName == null) return -1;
if (a.discussionTypeName == null) return 1;
return b.discussionTypeName.localeCompare(a.discussionTypeName);
}
case clsvDiscussionTopicsEN.con_TopicsTitle:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.topicsTitle == null) return -1;
if (a.topicsTitle == null) return 1;
return b.topicsTitle.localeCompare(a.topicsTitle);
}
case clsvDiscussionTopicsEN.con_TopicsContent:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.topicsContent == null) return -1;
if (a.topicsContent == null) return 1;
return b.topicsContent.localeCompare(a.topicsContent);
}
case clsvDiscussionTopicsEN.con_IsAudit:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.isAudit == true) return 1;
else return -1
}
case clsvDiscussionTopicsEN.con_IsTop:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.isTop == true) return 1;
else return -1
}
case clsvDiscussionTopicsEN.con_BrowseNumber:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return b.browseNumber-a.browseNumber;
}
case clsvDiscussionTopicsEN.con_UpdDate:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvDiscussionTopicsEN.con_UpdUser:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvDiscussionTopicsEN.con_Memo:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvDiscussionTopicsEN.con_CollegeName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.collegeName == null) return -1;
if (a.collegeName == null) return 1;
return b.collegeName.localeCompare(a.collegeName);
}
case clsvDiscussionTopicsEN.con_id_XzCollege:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.id_XzCollege == null) return -1;
if (a.id_XzCollege == null) return 1;
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvDiscussionTopicsEN.con_id_XzMajor:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.id_XzMajor == null) return -1;
if (a.id_XzMajor == null) return 1;
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvDiscussionTopicsEN.con_MajorName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.majorName == null) return -1;
if (a.majorName == null) return 1;
return b.majorName.localeCompare(a.majorName);
}
case clsvDiscussionTopicsEN.con_UserName:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
case clsvDiscussionTopicsEN.con_SubCount:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
return b.subCount-a.subCount;
}
case clsvDiscussionTopicsEN.con_id_CurrEduCls:
return (a: clsvDiscussionTopicsEN, b: clsvDiscussionTopicsEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${ vDiscussionTopics_ConstructorName}.${ strThisFuncName})`;
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
export async function vDiscussionTopics_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvDiscussionTopicsEN.con_TopicsId:
return (obj: clsvDiscussionTopicsEN) => {
return obj.topicsId === value;
}
case clsvDiscussionTopicsEN.con_DiscussionTypeId:
return (obj: clsvDiscussionTopicsEN) => {
return obj.discussionTypeId === value;
}
case clsvDiscussionTopicsEN.con_DiscussionTypeName:
return (obj: clsvDiscussionTopicsEN) => {
return obj.discussionTypeName === value;
}
case clsvDiscussionTopicsEN.con_TopicsTitle:
return (obj: clsvDiscussionTopicsEN) => {
return obj.topicsTitle === value;
}
case clsvDiscussionTopicsEN.con_TopicsContent:
return (obj: clsvDiscussionTopicsEN) => {
return obj.topicsContent === value;
}
case clsvDiscussionTopicsEN.con_IsAudit:
return (obj: clsvDiscussionTopicsEN) => {
return obj.isAudit === value;
}
case clsvDiscussionTopicsEN.con_IsTop:
return (obj: clsvDiscussionTopicsEN) => {
return obj.isTop === value;
}
case clsvDiscussionTopicsEN.con_BrowseNumber:
return (obj: clsvDiscussionTopicsEN) => {
return obj.browseNumber === value;
}
case clsvDiscussionTopicsEN.con_UpdDate:
return (obj: clsvDiscussionTopicsEN) => {
return obj.updDate === value;
}
case clsvDiscussionTopicsEN.con_UpdUser:
return (obj: clsvDiscussionTopicsEN) => {
return obj.updUser === value;
}
case clsvDiscussionTopicsEN.con_Memo:
return (obj: clsvDiscussionTopicsEN) => {
return obj.memo === value;
}
case clsvDiscussionTopicsEN.con_CollegeName:
return (obj: clsvDiscussionTopicsEN) => {
return obj.collegeName === value;
}
case clsvDiscussionTopicsEN.con_id_XzCollege:
return (obj: clsvDiscussionTopicsEN) => {
return obj.id_XzCollege === value;
}
case clsvDiscussionTopicsEN.con_id_XzMajor:
return (obj: clsvDiscussionTopicsEN) => {
return obj.id_XzMajor === value;
}
case clsvDiscussionTopicsEN.con_MajorName:
return (obj: clsvDiscussionTopicsEN) => {
return obj.majorName === value;
}
case clsvDiscussionTopicsEN.con_UserName:
return (obj: clsvDiscussionTopicsEN) => {
return obj.userName === value;
}
case clsvDiscussionTopicsEN.con_SubCount:
return (obj: clsvDiscussionTopicsEN) => {
return obj.subCount === value;
}
case clsvDiscussionTopicsEN.con_id_CurrEduCls:
return (obj: clsvDiscussionTopicsEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${ vDiscussionTopics_ConstructorName}.${ strThisFuncName})`;
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
export async function vDiscussionTopics_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsvDiscussionTopicsWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsvDiscussionTopicsEN.con_TopicsId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvDiscussionTopics = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrvDiscussionTopics == null) return [];
let arrvDiscussionTopics_Sel = arrvDiscussionTopics;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvDiscussionTopics_Sel.length == 0) return [];
return arrvDiscussionTopics_Sel.map(x=>x.topicsId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vDiscussionTopics_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetFirstObjAsync(strWhereCond: string): Promise<clsvDiscussionTopicsEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const objvDiscussionTopics = vDiscussionTopics_GetObjFromJsonObj(returnObj);
return objvDiscussionTopics;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvDiscussionTopicsEN.WhereFormat) == false)
{
strWhereCond = Format(clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvDiscussionTopicsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvDiscussionTopicsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvDiscussionTopicsExObjLst_Cache: Array<clsvDiscussionTopicsEN> = CacheHelper.Get(strKey);
const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
return arrvDiscussionTopicsObjLst_T;
}
try
{
const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvDiscussionTopicsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
console.log(strInfo);
return arrvDiscussionTopicsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vDiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvDiscussionTopicsEN.WhereFormat) == false)
{
strWhereCond = Format(clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvDiscussionTopicsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvDiscussionTopicsEN.CacheAddiCondition);
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
const arrvDiscussionTopicsExObjLst_Cache: Array<clsvDiscussionTopicsEN> = JSON.parse(strTempObjLst);
const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
return arrvDiscussionTopicsObjLst_T;
}
try
{
const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvDiscussionTopicsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
console.log(strInfo);
return arrvDiscussionTopicsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vDiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvDiscussionTopicsObjLst_Cache: Array<clsvDiscussionTopicsEN> = JSON.parse(strTempObjLst);
return arrvDiscussionTopicsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vDiscussionTopics_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvDiscussionTopicsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsvDiscussionTopicsEN.WhereFormat) == false)
{
strWhereCond = Format(clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsvDiscussionTopicsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvDiscussionTopicsEN.CacheAddiCondition);
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
const arrvDiscussionTopicsExObjLst_Cache: Array<clsvDiscussionTopicsEN> = JSON.parse(strTempObjLst);
const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
return arrvDiscussionTopicsObjLst_T;
}
try
{
const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvDiscussionTopicsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
console.log(strInfo);
return arrvDiscussionTopicsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vDiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvDiscussionTopicsObjLst_Cache: Array<clsvDiscussionTopicsEN> = JSON.parse(strTempObjLst);
return arrvDiscussionTopicsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvDiscussionTopicsEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvDiscussionTopicsWApi.vDiscussionTopics_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvDiscussionTopicsWApi.vDiscussionTopics_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvDiscussionTopicsObjLst_Cache;
switch (clsvDiscussionTopicsEN.CacheModeId)
{
case "04"://sessionStorage
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvDiscussionTopicsObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsObjLst_Cache);
return arrvDiscussionTopicsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vDiscussionTopics_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvDiscussionTopicsObjLst_Cache;
switch (clsvDiscussionTopicsEN.CacheModeId)
{
case "04"://sessionStorage
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvDiscussionTopicsObjLst_Cache = null;
break;
default:
arrvDiscussionTopicsObjLst_Cache = null;
break;
}
return arrvDiscussionTopicsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTopicsId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vDiscussionTopics_GetSubObjLst_Cache(objvDiscussionTopics_Cond: clsvDiscussionTopicsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
let arrvDiscussionTopics_Sel: Array < clsvDiscussionTopicsEN > = arrvDiscussionTopicsObjLst_Cache;
if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "") return arrvDiscussionTopics_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
//console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvDiscussionTopics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvDiscussionTopics_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvDiscussionTopics_Cond), vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvDiscussionTopicsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTopicsId:关键字列表
 * @returns 对象列表
 **/
export async function vDiscussionTopics_GetObjLstByTopicsIdLstAsync(arrTopicsId: Array<string>): Promise<Array<clsvDiscussionTopicsEN>>  
{
const strThisFuncName = "GetObjLstByTopicsIdLstAsync";
const strAction = "GetObjLstByTopicsIdLst";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTopicsId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param arrstrTopicsIdLst:关键字列表
 * @returns 对象列表
*/
export async function vDiscussionTopics_GetObjLstByTopicsIdLst_Cache(arrTopicsIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByTopicsIdLst_Cache";
try
{
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
const arrvDiscussionTopics_Sel: Array <clsvDiscussionTopicsEN> = arrvDiscussionTopicsObjLst_Cache.filter(x => arrTopicsIdLst.indexOf(x.topicsId)>-1);
return arrvDiscussionTopics_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicsIdLst.join(","), vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvDiscussionTopicsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvDiscussionTopicsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvDiscussionTopicsEN>();
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
if (arrvDiscussionTopicsObjLst_Cache.length == 0) return arrvDiscussionTopicsObjLst_Cache;
let arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvDiscussionTopics_Cond = new clsvDiscussionTopicsEN();
ObjectAssign(objvDiscussionTopics_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvDiscussionTopicsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvDiscussionTopics_Sel.length == 0) return arrvDiscussionTopics_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.sort(vDiscussionTopics_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.sort(objPagerPara.sortFun);
}
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.slice(intStart, intEnd);     
return arrvDiscussionTopics_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvDiscussionTopicsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vDiscussionTopics_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvDiscussionTopicsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvDiscussionTopicsEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param objstrTopicsId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vDiscussionTopics_IsExistRecord_Cache(objvDiscussionTopics_Cond: clsvDiscussionTopicsEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
if (arrvDiscussionTopicsObjLst_Cache == null) return false;
let arrvDiscussionTopics_Sel: Array < clsvDiscussionTopicsEN > = arrvDiscussionTopicsObjLst_Cache;
if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "") return arrvDiscussionTopics_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
//console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvDiscussionTopics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvDiscussionTopics_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvDiscussionTopics_Cond), vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param strTopicsId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vDiscussionTopics_IsExist(strTopicsId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TopicsId": strTopicsId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param strTopicsId:所给的关键字
 * @returns 对象
*/
export async function vDiscussionTopics_IsExist_Cache(strTopicsId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
if (arrvDiscussionTopicsObjLst_Cache == null) return false;
try
{
const arrvDiscussionTopics_Sel: Array <clsvDiscussionTopicsEN> = arrvDiscussionTopicsObjLst_Cache.filter(x => x.topicsId == strTopicsId);
if (arrvDiscussionTopics_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicsId, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTopicsId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vDiscussionTopics_IsExistAsync(strTopicsId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTopicsId": strTopicsId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
export async function vDiscussionTopics_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vDiscussionTopics_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vDiscussionTopics_ConstructorName, strThisFuncName);
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
 * @param objvDiscussionTopics_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vDiscussionTopics_GetRecCountByCond_Cache(objvDiscussionTopics_Cond: clsvDiscussionTopicsEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
if (arrvDiscussionTopicsObjLst_Cache == null) return 0;
let arrvDiscussionTopics_Sel: Array < clsvDiscussionTopicsEN > = arrvDiscussionTopicsObjLst_Cache;
if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "") return arrvDiscussionTopics_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
//console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvDiscussionTopics_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvDiscussionTopics_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvDiscussionTopics_Cond), vDiscussionTopics_ConstructorName, strThisFuncName);
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
export function vDiscussionTopics_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vDiscussionTopics_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
switch (clsvDiscussionTopicsEN.CacheModeId)
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
export function vDiscussionTopics_GetJSONStrByObj (pobjvDiscussionTopicsEN: clsvDiscussionTopicsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvDiscussionTopicsEN);
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
export function vDiscussionTopics_GetObjLstByJSONStr (strJSON: string): Array<clsvDiscussionTopicsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvDiscussionTopicsObjLst = new Array<clsvDiscussionTopicsEN>();
if (strJSON === "")
{
return arrvDiscussionTopicsObjLst;
}
try
{
arrvDiscussionTopicsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvDiscussionTopicsObjLst;
}
return arrvDiscussionTopicsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvDiscussionTopicsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vDiscussionTopics_GetObjLstByJSONObjLst (arrvDiscussionTopicsObjLstS: Array<clsvDiscussionTopicsEN>): Array<clsvDiscussionTopicsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvDiscussionTopicsObjLst = new Array<clsvDiscussionTopicsEN>();
for (const objInFor of arrvDiscussionTopicsObjLstS) {
const obj1 = vDiscussionTopics_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvDiscussionTopicsObjLst.push(obj1);
}
return arrvDiscussionTopicsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vDiscussionTopics_GetObjByJSONStr (strJSON: string): clsvDiscussionTopicsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
if (strJSON === "")
{
return pobjvDiscussionTopicsEN;
}
try
{
pobjvDiscussionTopicsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvDiscussionTopicsEN;
}
return pobjvDiscussionTopicsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vDiscussionTopics_GetCombineCondition(objvDiscussionTopics_Cond: clsvDiscussionTopicsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_TopicsId) == true)
{
const strComparisonOp_TopicsId:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_TopicsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_TopicsId, objvDiscussionTopics_Cond.topicsId, strComparisonOp_TopicsId);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_DiscussionTypeId) == true)
{
const strComparisonOp_DiscussionTypeId:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_DiscussionTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_DiscussionTypeId, objvDiscussionTopics_Cond.discussionTypeId, strComparisonOp_DiscussionTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_DiscussionTypeName) == true)
{
const strComparisonOp_DiscussionTypeName:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_DiscussionTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_DiscussionTypeName, objvDiscussionTopics_Cond.discussionTypeName, strComparisonOp_DiscussionTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_TopicsTitle) == true)
{
const strComparisonOp_TopicsTitle:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_TopicsTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_TopicsTitle, objvDiscussionTopics_Cond.topicsTitle, strComparisonOp_TopicsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_IsAudit) == true)
{
if (objvDiscussionTopics_Cond.isAudit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvDiscussionTopicsEN.con_IsAudit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvDiscussionTopicsEN.con_IsAudit);
}
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_IsTop) == true)
{
if (objvDiscussionTopics_Cond.isTop == true)
{
strWhereCond += Format(" And {0} = '1'", clsvDiscussionTopicsEN.con_IsTop);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvDiscussionTopicsEN.con_IsTop);
}
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvDiscussionTopicsEN.con_BrowseNumber, objvDiscussionTopics_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_UpdDate, objvDiscussionTopics_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_UpdUser, objvDiscussionTopics_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_Memo, objvDiscussionTopics_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_CollegeName, objvDiscussionTopics_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_id_XzCollege, objvDiscussionTopics_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_id_XzMajor, objvDiscussionTopics_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_MajorName, objvDiscussionTopics_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_UserName, objvDiscussionTopics_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_SubCount) == true)
{
const strComparisonOp_SubCount:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_SubCount];
strWhereCond += Format(" And {0} {2} {1}", clsvDiscussionTopicsEN.con_SubCount, objvDiscussionTopics_Cond.subCount, strComparisonOp_SubCount);
}
if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvDiscussionTopicsEN.con_id_CurrEduCls, objvDiscussionTopics_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvDiscussionTopicsENS:源对象
 * @param objvDiscussionTopicsENT:目标对象
*/
export function vDiscussionTopics_CopyObjTo(objvDiscussionTopicsENS: clsvDiscussionTopicsEN , objvDiscussionTopicsENT: clsvDiscussionTopicsEN ): void 
{
objvDiscussionTopicsENT.topicsId = objvDiscussionTopicsENS.topicsId; //主题Id
objvDiscussionTopicsENT.discussionTypeId = objvDiscussionTopicsENS.discussionTypeId; //讨论类型Id
objvDiscussionTopicsENT.discussionTypeName = objvDiscussionTopicsENS.discussionTypeName; //讨论类型名称
objvDiscussionTopicsENT.topicsTitle = objvDiscussionTopicsENS.topicsTitle; //主题标题
objvDiscussionTopicsENT.topicsContent = objvDiscussionTopicsENS.topicsContent; //主题内容
objvDiscussionTopicsENT.isAudit = objvDiscussionTopicsENS.isAudit; //是否审核
objvDiscussionTopicsENT.isTop = objvDiscussionTopicsENS.isTop; //是否置顶
objvDiscussionTopicsENT.browseNumber = objvDiscussionTopicsENS.browseNumber; //浏览量
objvDiscussionTopicsENT.updDate = objvDiscussionTopicsENS.updDate; //修改日期
objvDiscussionTopicsENT.updUser = objvDiscussionTopicsENS.updUser; //修改人
objvDiscussionTopicsENT.memo = objvDiscussionTopicsENS.memo; //备注
objvDiscussionTopicsENT.collegeName = objvDiscussionTopicsENS.collegeName; //学院名称
objvDiscussionTopicsENT.id_XzCollege = objvDiscussionTopicsENS.id_XzCollege; //学院流水号
objvDiscussionTopicsENT.id_XzMajor = objvDiscussionTopicsENS.id_XzMajor; //专业流水号
objvDiscussionTopicsENT.majorName = objvDiscussionTopicsENS.majorName; //专业名称
objvDiscussionTopicsENT.userName = objvDiscussionTopicsENS.userName; //用户名
objvDiscussionTopicsENT.subCount = objvDiscussionTopicsENS.subCount; //SubCount
objvDiscussionTopicsENT.id_CurrEduCls = objvDiscussionTopicsENS.id_CurrEduCls; //教学班流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvDiscussionTopicsENS:源对象
 * @param objvDiscussionTopicsENT:目标对象
*/
export function vDiscussionTopics_GetObjFromJsonObj(objvDiscussionTopicsENS: clsvDiscussionTopicsEN): clsvDiscussionTopicsEN 
{
 const objvDiscussionTopicsENT: clsvDiscussionTopicsEN = new clsvDiscussionTopicsEN();
ObjectAssign(objvDiscussionTopicsENT, objvDiscussionTopicsENS);
 return objvDiscussionTopicsENT;
}