
 /**
 * 类名:clsvRTResearchResultWApi
 * 表名:vRTResearchResult(01120621)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 16:26:34
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
 * 主题研究结果关系(vRTResearchResult)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvRTResearchResultEN } from "../../L0_Entity/GraduateEduTopic/clsvRTResearchResultEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vRTResearchResult_Controller = "vRTResearchResultApi";
 export const vRTResearchResult_ConstructorName = "vRTResearchResult";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vRTResearchResult_GetObjBymIdAsync(lngmId: number): Promise<clsvRTResearchResultEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTResearchResult = vRTResearchResult_GetObjFromJsonObj(returnObj);
return objvRTResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
try
{
const arrvRTResearchResult_Sel: Array <clsvRTResearchResultEN> = arrvRTResearchResultObjLst_Cache.filter(x => x.mId == lngmId);
let objvRTResearchResult: clsvRTResearchResultEN;
if (arrvRTResearchResult_Sel.length > 0)
{
objvRTResearchResult = arrvRTResearchResult_Sel[0];
return objvRTResearchResult;
}
else
{
if (bolTryAsyncOnce == true)
{
objvRTResearchResult = await vRTResearchResult_GetObjBymIdAsync(lngmId);
if (objvRTResearchResult != null)
{
vRTResearchResult_ReFreshThisCache();
return objvRTResearchResult;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvRTResearchResultEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvRTResearchResult_Cache: clsvRTResearchResultEN = JSON.parse(strTempObj);
return objvRTResearchResult_Cache;
}
try
{
const objvRTResearchResult = await vRTResearchResult_GetObjBymIdAsync(lngmId);
if (objvRTResearchResult != null)
{
localStorage.setItem(strKey, JSON.stringify(objvRTResearchResult));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvRTResearchResult;
}
return objvRTResearchResult;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvRTResearchResultEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvRTResearchResultEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvRTResearchResultEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvRTResearchResult = await vRTResearchResult_GetObjBymId_Cache(lngmId );
if (objvRTResearchResult == null) return "";
return objvRTResearchResult.GetFldValue(strOutFldName).toString();
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
export function vRTResearchResult_SortFun_Defa(a:clsvRTResearchResultEN , b:clsvRTResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vRTResearchResult_SortFun_Defa_2Fld(a:clsvRTResearchResultEN , b:clsvRTResearchResultEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicId == b.topicId) return a.paperId.localeCompare(b.paperId);
else return a.topicId.localeCompare(b.topicId);
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
export function vRTResearchResult_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvRTResearchResultEN.con_TopicId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvRTResearchResultEN.con_PaperId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvRTResearchResultEN.con_UpdDate:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvRTResearchResultEN.con_UpdUser:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvRTResearchResultEN.con_Memo:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvRTResearchResultEN.con_mId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.mId-b.mId;
}
case clsvRTResearchResultEN.con_UserName:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvRTResearchResultEN.con_PaperTitle:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvRTResearchResultEN.con_PaperContent:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvRTResearchResultEN.con_TopicName:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvRTResearchResultEN.con_TopicContent:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.topicContent.localeCompare(b.topicContent);
}
case clsvRTResearchResultEN.con_TopicProposePeople:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.topicProposePeople.localeCompare(b.topicProposePeople);
}
case clsvRTResearchResultEN.con_Periodical:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvRTResearchResultEN.con_Author:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return a.author.localeCompare(b.author);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${ vRTResearchResult_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvRTResearchResultEN.con_TopicId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvRTResearchResultEN.con_PaperId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvRTResearchResultEN.con_UpdDate:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvRTResearchResultEN.con_UpdUser:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvRTResearchResultEN.con_Memo:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvRTResearchResultEN.con_mId:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.mId-a.mId;
}
case clsvRTResearchResultEN.con_UserName:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvRTResearchResultEN.con_PaperTitle:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvRTResearchResultEN.con_PaperContent:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvRTResearchResultEN.con_TopicName:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvRTResearchResultEN.con_TopicContent:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.topicContent.localeCompare(a.topicContent);
}
case clsvRTResearchResultEN.con_TopicProposePeople:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.topicProposePeople.localeCompare(a.topicProposePeople);
}
case clsvRTResearchResultEN.con_Periodical:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvRTResearchResultEN.con_Author:
return (a: clsvRTResearchResultEN, b: clsvRTResearchResultEN) => {
return b.author.localeCompare(a.author);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${ vRTResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTResearchResult_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvRTResearchResultEN.con_TopicId:
return (obj: clsvRTResearchResultEN) => {
return obj.topicId === value;
}
case clsvRTResearchResultEN.con_PaperId:
return (obj: clsvRTResearchResultEN) => {
return obj.paperId === value;
}
case clsvRTResearchResultEN.con_UpdDate:
return (obj: clsvRTResearchResultEN) => {
return obj.updDate === value;
}
case clsvRTResearchResultEN.con_UpdUser:
return (obj: clsvRTResearchResultEN) => {
return obj.updUser === value;
}
case clsvRTResearchResultEN.con_Memo:
return (obj: clsvRTResearchResultEN) => {
return obj.memo === value;
}
case clsvRTResearchResultEN.con_mId:
return (obj: clsvRTResearchResultEN) => {
return obj.mId === value;
}
case clsvRTResearchResultEN.con_UserName:
return (obj: clsvRTResearchResultEN) => {
return obj.userName === value;
}
case clsvRTResearchResultEN.con_PaperTitle:
return (obj: clsvRTResearchResultEN) => {
return obj.paperTitle === value;
}
case clsvRTResearchResultEN.con_PaperContent:
return (obj: clsvRTResearchResultEN) => {
return obj.paperContent === value;
}
case clsvRTResearchResultEN.con_TopicName:
return (obj: clsvRTResearchResultEN) => {
return obj.topicName === value;
}
case clsvRTResearchResultEN.con_TopicContent:
return (obj: clsvRTResearchResultEN) => {
return obj.topicContent === value;
}
case clsvRTResearchResultEN.con_TopicProposePeople:
return (obj: clsvRTResearchResultEN) => {
return obj.topicProposePeople === value;
}
case clsvRTResearchResultEN.con_Periodical:
return (obj: clsvRTResearchResultEN) => {
return obj.periodical === value;
}
case clsvRTResearchResultEN.con_Author:
return (obj: clsvRTResearchResultEN) => {
return obj.author === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTResearchResult]中不存在！(in ${ vRTResearchResult_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTResearchResult_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetFirstObjAsync(strWhereCond: string): Promise<clsvRTResearchResultEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTResearchResult = vRTResearchResult_GetObjFromJsonObj(returnObj);
return objvRTResearchResult;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTResearchResultEN._CurrTabName;
clsvRTResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvRTResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTResearchResultEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvRTResearchResultExObjLst_Cache: Array<clsvRTResearchResultEN> = CacheHelper.Get(strKey);
const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
return arrvRTResearchResultObjLst_T;
}
try
{
const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvRTResearchResultExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
console.log(strInfo);
return arrvRTResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTResearchResult_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTResearchResultEN._CurrTabName;
clsvRTResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvRTResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTResearchResultEN.CacheAddiCondition);
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
const arrvRTResearchResultExObjLst_Cache: Array<clsvRTResearchResultEN> = JSON.parse(strTempObjLst);
const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
return arrvRTResearchResultObjLst_T;
}
try
{
const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvRTResearchResultExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
console.log(strInfo);
return arrvRTResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTResearchResult_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTResearchResultEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvRTResearchResultObjLst_Cache: Array<clsvRTResearchResultEN> = JSON.parse(strTempObjLst);
return arrvRTResearchResultObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vRTResearchResult_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTResearchResultEN._CurrTabName;
clsvRTResearchResultEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTResearchResultEN._CurrTabName);
if (IsNullOrEmpty(clsvRTResearchResultEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTResearchResultEN.CacheAddiCondition);
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
const arrvRTResearchResultExObjLst_Cache: Array<clsvRTResearchResultEN> = JSON.parse(strTempObjLst);
const arrvRTResearchResultObjLst_T = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultExObjLst_Cache);
return arrvRTResearchResultObjLst_T;
}
try
{
const arrvRTResearchResultExObjLst = await vRTResearchResult_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvRTResearchResultExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTResearchResultExObjLst.length);
console.log(strInfo);
return arrvRTResearchResultExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTResearchResult_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTResearchResultEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvRTResearchResultObjLst_Cache: Array<clsvRTResearchResultEN> = JSON.parse(strTempObjLst);
return arrvRTResearchResultObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTResearchResult_GetObjLst_Cache(): Promise<Array<clsvRTResearchResultEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvRTResearchResultObjLst_Cache;
switch (clsvRTResearchResultEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_ClientCache();
break;
default:
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_ClientCache();
break;
}
const arrvRTResearchResultObjLst = vRTResearchResult_GetObjLstByJSONObjLst(arrvRTResearchResultObjLst_Cache);
return arrvRTResearchResultObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTResearchResult_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvRTResearchResultObjLst_Cache;
switch (clsvRTResearchResultEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvRTResearchResultObjLst_Cache = null;
break;
default:
arrvRTResearchResultObjLst_Cache = null;
break;
}
return arrvRTResearchResultObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTResearchResult_GetSubObjLst_Cache(objvRTResearchResult_Cond: clsvRTResearchResultEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
let arrvRTResearchResult_Sel: Array < clsvRTResearchResultEN > = arrvRTResearchResultObjLst_Cache;
if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "") return arrvRTResearchResult_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTResearchResult_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvRTResearchResult_Cond), vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTResearchResultEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vRTResearchResult_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
const arrvRTResearchResult_Sel: Array <clsvRTResearchResultEN> = arrvRTResearchResultObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvRTResearchResult_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTResearchResultEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vRTResearchResult_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvRTResearchResultEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
if (arrvRTResearchResultObjLst_Cache.length == 0) return arrvRTResearchResultObjLst_Cache;
let arrvRTResearchResult_Sel = arrvRTResearchResultObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvRTResearchResult_Cond = new clsvRTResearchResultEN();
ObjectAssign(objvRTResearchResult_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvRTResearchResultWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTResearchResult_Sel.length == 0) return arrvRTResearchResult_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.sort(vRTResearchResult_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.sort(objPagerPara.sortFun);
}
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.slice(intStart, intEnd);     
return arrvRTResearchResult_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTResearchResultEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vRTResearchResult_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvRTResearchResultEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTResearchResult_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_IsExistRecord_Cache(objvRTResearchResult_Cond: clsvRTResearchResultEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
if (arrvRTResearchResultObjLst_Cache == null) return false;
let arrvRTResearchResult_Sel: Array < clsvRTResearchResultEN > = arrvRTResearchResultObjLst_Cache;
if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "") return arrvRTResearchResult_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTResearchResult_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvRTResearchResult_Cond), vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
if (arrvRTResearchResultObjLst_Cache == null) return false;
try
{
const arrvRTResearchResult_Sel: Array <clsvRTResearchResultEN> = arrvRTResearchResultObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvRTResearchResult_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
export async function vRTResearchResult_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vRTResearchResult_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTResearchResult_ConstructorName, strThisFuncName);
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
 * @param objvRTResearchResult_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vRTResearchResult_GetRecCountByCond_Cache(objvRTResearchResult_Cond: clsvRTResearchResultEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvRTResearchResultObjLst_Cache = await vRTResearchResult_GetObjLst_Cache();
if (arrvRTResearchResultObjLst_Cache == null) return 0;
let arrvRTResearchResult_Sel: Array < clsvRTResearchResultEN > = arrvRTResearchResultObjLst_Cache;
if (objvRTResearchResult_Cond.sf_FldComparisonOp == null || objvRTResearchResult_Cond.sf_FldComparisonOp == "") return arrvRTResearchResult_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTResearchResult_Cond.sf_FldComparisonOp);
//console.log("clsvRTResearchResultWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTResearchResult_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTResearchResult_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTResearchResult_Sel = arrvRTResearchResult_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTResearchResult_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvRTResearchResult_Cond), vRTResearchResult_ConstructorName, strThisFuncName);
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
export function vRTResearchResult_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vRTResearchResult_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvRTResearchResultEN._CurrTabName;
switch (clsvRTResearchResultEN.CacheModeId)
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
export function vRTResearchResult_GetJSONStrByObj (pobjvRTResearchResultEN: clsvRTResearchResultEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvRTResearchResultEN);
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
export function vRTResearchResult_GetObjLstByJSONStr (strJSON: string): Array<clsvRTResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvRTResearchResultObjLst = new Array<clsvRTResearchResultEN>();
if (strJSON === "")
{
return arrvRTResearchResultObjLst;
}
try
{
arrvRTResearchResultObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvRTResearchResultObjLst;
}
return arrvRTResearchResultObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvRTResearchResultObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vRTResearchResult_GetObjLstByJSONObjLst (arrvRTResearchResultObjLstS: Array<clsvRTResearchResultEN>): Array<clsvRTResearchResultEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvRTResearchResultObjLst = new Array<clsvRTResearchResultEN>();
for (const objInFor of arrvRTResearchResultObjLstS) {
const obj1 = vRTResearchResult_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvRTResearchResultObjLst.push(obj1);
}
return arrvRTResearchResultObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTResearchResult_GetObjByJSONStr (strJSON: string): clsvRTResearchResultEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvRTResearchResultEN = new clsvRTResearchResultEN();
if (strJSON === "")
{
return pobjvRTResearchResultEN;
}
try
{
pobjvRTResearchResultEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvRTResearchResultEN;
}
return pobjvRTResearchResultEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vRTResearchResult_GetCombineCondition(objvRTResearchResult_Cond: clsvRTResearchResultEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_TopicId, objvRTResearchResult_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_PaperId, objvRTResearchResult_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_UpdDate, objvRTResearchResult_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_UpdUser, objvRTResearchResult_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_Memo, objvRTResearchResult_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvRTResearchResultEN.con_mId, objvRTResearchResult_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_UserName, objvRTResearchResult_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_PaperTitle, objvRTResearchResult_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_TopicName, objvRTResearchResult_Cond.topicName, strComparisonOp_TopicName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_TopicProposePeople) == true)
{
const strComparisonOp_TopicProposePeople:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_TopicProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_TopicProposePeople, objvRTResearchResult_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_Periodical, objvRTResearchResult_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvRTResearchResult_Cond.dicFldComparisonOp, clsvRTResearchResultEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvRTResearchResult_Cond.dicFldComparisonOp[clsvRTResearchResultEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTResearchResultEN.con_Author, objvRTResearchResult_Cond.author, strComparisonOp_Author);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvRTResearchResultENS:源对象
 * @param objvRTResearchResultENT:目标对象
*/
export function vRTResearchResult_CopyObjTo(objvRTResearchResultENS: clsvRTResearchResultEN , objvRTResearchResultENT: clsvRTResearchResultEN ): void 
{
objvRTResearchResultENT.topicId = objvRTResearchResultENS.topicId; //主题Id
objvRTResearchResultENT.paperId = objvRTResearchResultENS.paperId; //论文Id
objvRTResearchResultENT.updDate = objvRTResearchResultENS.updDate; //修改日期
objvRTResearchResultENT.updUser = objvRTResearchResultENS.updUser; //修改人
objvRTResearchResultENT.memo = objvRTResearchResultENS.memo; //备注
objvRTResearchResultENT.mId = objvRTResearchResultENS.mId; //mId
objvRTResearchResultENT.userName = objvRTResearchResultENS.userName; //用户名
objvRTResearchResultENT.paperTitle = objvRTResearchResultENS.paperTitle; //论文标题
objvRTResearchResultENT.paperContent = objvRTResearchResultENS.paperContent; //主题内容
objvRTResearchResultENT.topicName = objvRTResearchResultENS.topicName; //栏目主题
objvRTResearchResultENT.topicContent = objvRTResearchResultENS.topicContent; //主题内容
objvRTResearchResultENT.topicProposePeople = objvRTResearchResultENS.topicProposePeople; //主题提出人
objvRTResearchResultENT.periodical = objvRTResearchResultENS.periodical; //期刊
objvRTResearchResultENT.author = objvRTResearchResultENS.author; //作者
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvRTResearchResultENS:源对象
 * @param objvRTResearchResultENT:目标对象
*/
export function vRTResearchResult_GetObjFromJsonObj(objvRTResearchResultENS: clsvRTResearchResultEN): clsvRTResearchResultEN 
{
 const objvRTResearchResultENT: clsvRTResearchResultEN = new clsvRTResearchResultEN();
ObjectAssign(objvRTResearchResultENT, objvRTResearchResultENS);
 return objvRTResearchResultENT;
}