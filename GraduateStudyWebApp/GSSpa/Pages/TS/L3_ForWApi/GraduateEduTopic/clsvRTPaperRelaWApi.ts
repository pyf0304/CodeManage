
 /**
 * 类名:clsvRTPaperRelaWApi
 * 表名:vRTPaperRela(01120583)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 14:57:11
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
 * vRTPaperRela(vRTPaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvRTPaperRelaEN } from "../../L0_Entity/GraduateEduTopic/clsvRTPaperRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vRTPaperRela_Controller = "vRTPaperRelaApi";
 export const vRTPaperRela_ConstructorName = "vRTPaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vRTPaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsvRTPaperRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTPaperRela = vRTPaperRela_GetObjFromJsonObj(returnObj);
return objvRTPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
try
{
const arrvRTPaperRela_Sel: Array <clsvRTPaperRelaEN> = arrvRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
let objvRTPaperRela: clsvRTPaperRelaEN;
if (arrvRTPaperRela_Sel.length > 0)
{
objvRTPaperRela = arrvRTPaperRela_Sel[0];
return objvRTPaperRela;
}
else
{
if (bolTryAsyncOnce == true)
{
objvRTPaperRela = await vRTPaperRela_GetObjBymIdAsync(lngmId);
if (objvRTPaperRela != null)
{
vRTPaperRela_ReFreshThisCache();
return objvRTPaperRela;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvRTPaperRelaEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvRTPaperRela_Cache: clsvRTPaperRelaEN = JSON.parse(strTempObj);
return objvRTPaperRela_Cache;
}
try
{
const objvRTPaperRela = await vRTPaperRela_GetObjBymIdAsync(lngmId);
if (objvRTPaperRela != null)
{
localStorage.setItem(strKey, JSON.stringify(objvRTPaperRela));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvRTPaperRela;
}
return objvRTPaperRela;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvRTPaperRelaEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvRTPaperRelaEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvRTPaperRelaEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvRTPaperRela = await vRTPaperRela_GetObjBymId_Cache(lngmId );
if (objvRTPaperRela == null) return "";
return objvRTPaperRela.GetFldValue(strOutFldName).toString();
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
export function vRTPaperRela_SortFun_Defa(a:clsvRTPaperRelaEN , b:clsvRTPaperRelaEN): number 
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
export function vRTPaperRela_SortFun_Defa_2Fld(a:clsvRTPaperRelaEN , b:clsvRTPaperRelaEN): number 
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
export function vRTPaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvRTPaperRelaEN.con_mId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.mId-b.mId;
}
case clsvRTPaperRelaEN.con_TopicId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.topicId.localeCompare(b.topicId);
}
case clsvRTPaperRelaEN.con_PaperId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvRTPaperRelaEN.con_UpdDate:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvRTPaperRelaEN.con_UpdUser:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvRTPaperRelaEN.con_Memo:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvRTPaperRelaEN.con_TopicName:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.topicName.localeCompare(b.topicName);
}
case clsvRTPaperRelaEN.con_TopicContent:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.topicContent.localeCompare(b.topicContent);
}
case clsvRTPaperRelaEN.con_TopicProposePeople:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.topicProposePeople.localeCompare(b.topicProposePeople);
}
case clsvRTPaperRelaEN.con_PaperTitle:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvRTPaperRelaEN.con_PaperContent:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvRTPaperRelaEN.con_Author:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.author.localeCompare(b.author);
}
case clsvRTPaperRelaEN.con_Periodical:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvRTPaperRelaEN.con_IsSubmit:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvRTPaperRelaEN.con_id_CurrEduCls:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvRTPaperRelaEN.con_PaperDate:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperDate.localeCompare(b.paperDate);
}
case clsvRTPaperRelaEN.con_PaperStatusId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperStatusId.localeCompare(b.paperStatusId);
}
case clsvRTPaperRelaEN.con_PaperTypeId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsvRTPaperRelaEN.con_PaperUserId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.paperUserId.localeCompare(b.paperUserId);
}
case clsvRTPaperRelaEN.con_VersionCount:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return a.versionCount-b.versionCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${ vRTPaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvRTPaperRelaEN.con_mId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.mId-a.mId;
}
case clsvRTPaperRelaEN.con_TopicId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.topicId.localeCompare(a.topicId);
}
case clsvRTPaperRelaEN.con_PaperId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvRTPaperRelaEN.con_UpdDate:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvRTPaperRelaEN.con_UpdUser:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvRTPaperRelaEN.con_Memo:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvRTPaperRelaEN.con_TopicName:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.topicName.localeCompare(a.topicName);
}
case clsvRTPaperRelaEN.con_TopicContent:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.topicContent.localeCompare(a.topicContent);
}
case clsvRTPaperRelaEN.con_TopicProposePeople:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.topicProposePeople.localeCompare(a.topicProposePeople);
}
case clsvRTPaperRelaEN.con_PaperTitle:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvRTPaperRelaEN.con_PaperContent:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvRTPaperRelaEN.con_Author:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.author.localeCompare(a.author);
}
case clsvRTPaperRelaEN.con_Periodical:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvRTPaperRelaEN.con_IsSubmit:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvRTPaperRelaEN.con_id_CurrEduCls:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvRTPaperRelaEN.con_PaperDate:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperDate.localeCompare(a.paperDate);
}
case clsvRTPaperRelaEN.con_PaperStatusId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperStatusId.localeCompare(a.paperStatusId);
}
case clsvRTPaperRelaEN.con_PaperTypeId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsvRTPaperRelaEN.con_PaperUserId:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.paperUserId.localeCompare(a.paperUserId);
}
case clsvRTPaperRelaEN.con_VersionCount:
return (a: clsvRTPaperRelaEN, b: clsvRTPaperRelaEN) => {
return b.versionCount-a.versionCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${ vRTPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTPaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvRTPaperRelaEN.con_mId:
return (obj: clsvRTPaperRelaEN) => {
return obj.mId === value;
}
case clsvRTPaperRelaEN.con_TopicId:
return (obj: clsvRTPaperRelaEN) => {
return obj.topicId === value;
}
case clsvRTPaperRelaEN.con_PaperId:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperId === value;
}
case clsvRTPaperRelaEN.con_UpdDate:
return (obj: clsvRTPaperRelaEN) => {
return obj.updDate === value;
}
case clsvRTPaperRelaEN.con_UpdUser:
return (obj: clsvRTPaperRelaEN) => {
return obj.updUser === value;
}
case clsvRTPaperRelaEN.con_Memo:
return (obj: clsvRTPaperRelaEN) => {
return obj.memo === value;
}
case clsvRTPaperRelaEN.con_TopicName:
return (obj: clsvRTPaperRelaEN) => {
return obj.topicName === value;
}
case clsvRTPaperRelaEN.con_TopicContent:
return (obj: clsvRTPaperRelaEN) => {
return obj.topicContent === value;
}
case clsvRTPaperRelaEN.con_TopicProposePeople:
return (obj: clsvRTPaperRelaEN) => {
return obj.topicProposePeople === value;
}
case clsvRTPaperRelaEN.con_PaperTitle:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperTitle === value;
}
case clsvRTPaperRelaEN.con_PaperContent:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperContent === value;
}
case clsvRTPaperRelaEN.con_Author:
return (obj: clsvRTPaperRelaEN) => {
return obj.author === value;
}
case clsvRTPaperRelaEN.con_Periodical:
return (obj: clsvRTPaperRelaEN) => {
return obj.periodical === value;
}
case clsvRTPaperRelaEN.con_IsSubmit:
return (obj: clsvRTPaperRelaEN) => {
return obj.isSubmit === value;
}
case clsvRTPaperRelaEN.con_id_CurrEduCls:
return (obj: clsvRTPaperRelaEN) => {
return obj.id_CurrEduCls === value;
}
case clsvRTPaperRelaEN.con_PaperDate:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperDate === value;
}
case clsvRTPaperRelaEN.con_PaperStatusId:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperStatusId === value;
}
case clsvRTPaperRelaEN.con_PaperTypeId:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperTypeId === value;
}
case clsvRTPaperRelaEN.con_PaperUserId:
return (obj: clsvRTPaperRelaEN) => {
return obj.paperUserId === value;
}
case clsvRTPaperRelaEN.con_VersionCount:
return (obj: clsvRTPaperRelaEN) => {
return obj.versionCount === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTPaperRela]中不存在！(in ${ vRTPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTPaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvRTPaperRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvRTPaperRela = vRTPaperRela_GetObjFromJsonObj(returnObj);
return objvRTPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTPaperRelaEN._CurrTabName;
clsvRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTPaperRelaEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvRTPaperRelaExObjLst_Cache: Array<clsvRTPaperRelaEN> = CacheHelper.Get(strKey);
const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
return arrvRTPaperRelaObjLst_T;
}
try
{
const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvRTPaperRelaExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrvRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTPaperRela_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTPaperRelaEN._CurrTabName;
clsvRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTPaperRelaEN.CacheAddiCondition);
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
const arrvRTPaperRelaExObjLst_Cache: Array<clsvRTPaperRelaEN> = JSON.parse(strTempObjLst);
const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
return arrvRTPaperRelaObjLst_T;
}
try
{
const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvRTPaperRelaExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrvRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTPaperRela_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTPaperRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvRTPaperRelaObjLst_Cache: Array<clsvRTPaperRelaEN> = JSON.parse(strTempObjLst);
return arrvRTPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vRTPaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTPaperRelaEN._CurrTabName;
clsvRTPaperRelaEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvRTPaperRelaEN._CurrTabName);
if (IsNullOrEmpty(clsvRTPaperRelaEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTPaperRelaEN.CacheAddiCondition);
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
const arrvRTPaperRelaExObjLst_Cache: Array<clsvRTPaperRelaEN> = JSON.parse(strTempObjLst);
const arrvRTPaperRelaObjLst_T = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaExObjLst_Cache);
return arrvRTPaperRelaObjLst_T;
}
try
{
const arrvRTPaperRelaExObjLst = await vRTPaperRela_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvRTPaperRelaExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTPaperRelaExObjLst.length);
console.log(strInfo);
return arrvRTPaperRelaExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTPaperRela_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTPaperRelaEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvRTPaperRelaObjLst_Cache: Array<clsvRTPaperRelaEN> = JSON.parse(strTempObjLst);
return arrvRTPaperRelaObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTPaperRela_GetObjLst_Cache(): Promise<Array<clsvRTPaperRelaEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvRTPaperRelaObjLst_Cache;
switch (clsvRTPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_ClientCache();
break;
default:
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_ClientCache();
break;
}
const arrvRTPaperRelaObjLst = vRTPaperRela_GetObjLstByJSONObjLst(arrvRTPaperRelaObjLst_Cache);
return arrvRTPaperRelaObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTPaperRela_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvRTPaperRelaObjLst_Cache;
switch (clsvRTPaperRelaEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvRTPaperRelaObjLst_Cache = null;
break;
default:
arrvRTPaperRelaObjLst_Cache = null;
break;
}
return arrvRTPaperRelaObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTPaperRela_GetSubObjLst_Cache(objvRTPaperRela_Cond: clsvRTPaperRelaEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
let arrvRTPaperRela_Sel: Array < clsvRTPaperRelaEN > = arrvRTPaperRelaObjLst_Cache;
if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "") return arrvRTPaperRela_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvRTPaperRela_Cond), vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTPaperRelaEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vRTPaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
const arrvRTPaperRela_Sel: Array <clsvRTPaperRelaEN> = arrvRTPaperRelaObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvRTPaperRela_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTPaperRelaEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vRTPaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvRTPaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
if (arrvRTPaperRelaObjLst_Cache.length == 0) return arrvRTPaperRelaObjLst_Cache;
let arrvRTPaperRela_Sel = arrvRTPaperRelaObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvRTPaperRela_Cond = new clsvRTPaperRelaEN();
ObjectAssign(objvRTPaperRela_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvRTPaperRelaWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTPaperRela_Sel.length == 0) return arrvRTPaperRela_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.sort(vRTPaperRela_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.sort(objPagerPara.sortFun);
}
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.slice(intStart, intEnd);     
return arrvRTPaperRela_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTPaperRelaEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vRTPaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvRTPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_IsExistRecord_Cache(objvRTPaperRela_Cond: clsvRTPaperRelaEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
if (arrvRTPaperRelaObjLst_Cache == null) return false;
let arrvRTPaperRela_Sel: Array < clsvRTPaperRelaEN > = arrvRTPaperRelaObjLst_Cache;
if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "") return arrvRTPaperRela_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTPaperRela_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvRTPaperRela_Cond), vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
if (arrvRTPaperRelaObjLst_Cache == null) return false;
try
{
const arrvRTPaperRela_Sel: Array <clsvRTPaperRelaEN> = arrvRTPaperRelaObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvRTPaperRela_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
export async function vRTPaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vRTPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTPaperRela_ConstructorName, strThisFuncName);
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
 * @param objvRTPaperRela_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vRTPaperRela_GetRecCountByCond_Cache(objvRTPaperRela_Cond: clsvRTPaperRelaEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvRTPaperRelaObjLst_Cache = await vRTPaperRela_GetObjLst_Cache();
if (arrvRTPaperRelaObjLst_Cache == null) return 0;
let arrvRTPaperRela_Sel: Array < clsvRTPaperRelaEN > = arrvRTPaperRelaObjLst_Cache;
if (objvRTPaperRela_Cond.sf_FldComparisonOp == null || objvRTPaperRela_Cond.sf_FldComparisonOp == "") return arrvRTPaperRela_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTPaperRela_Cond.sf_FldComparisonOp);
//console.log("clsvRTPaperRelaWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTPaperRela_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTPaperRela_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTPaperRela_Sel = arrvRTPaperRela_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTPaperRela_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvRTPaperRela_Cond), vRTPaperRela_ConstructorName, strThisFuncName);
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
export function vRTPaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vRTPaperRela_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvRTPaperRelaEN._CurrTabName;
switch (clsvRTPaperRelaEN.CacheModeId)
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
export function vRTPaperRela_GetJSONStrByObj (pobjvRTPaperRelaEN: clsvRTPaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvRTPaperRelaEN);
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
export function vRTPaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsvRTPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvRTPaperRelaObjLst = new Array<clsvRTPaperRelaEN>();
if (strJSON === "")
{
return arrvRTPaperRelaObjLst;
}
try
{
arrvRTPaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvRTPaperRelaObjLst;
}
return arrvRTPaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvRTPaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vRTPaperRela_GetObjLstByJSONObjLst (arrvRTPaperRelaObjLstS: Array<clsvRTPaperRelaEN>): Array<clsvRTPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvRTPaperRelaObjLst = new Array<clsvRTPaperRelaEN>();
for (const objInFor of arrvRTPaperRelaObjLstS) {
const obj1 = vRTPaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvRTPaperRelaObjLst.push(obj1);
}
return arrvRTPaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTPaperRela_GetObjByJSONStr (strJSON: string): clsvRTPaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvRTPaperRelaEN = new clsvRTPaperRelaEN();
if (strJSON === "")
{
return pobjvRTPaperRelaEN;
}
try
{
pobjvRTPaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvRTPaperRelaEN;
}
return pobjvRTPaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vRTPaperRela_GetCombineCondition(objvRTPaperRela_Cond: clsvRTPaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvRTPaperRelaEN.con_mId, objvRTPaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_TopicId, objvRTPaperRela_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperId, objvRTPaperRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_UpdDate, objvRTPaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_UpdUser, objvRTPaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_Memo, objvRTPaperRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_TopicName, objvRTPaperRela_Cond.topicName, strComparisonOp_TopicName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_TopicProposePeople) == true)
{
const strComparisonOp_TopicProposePeople:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_TopicProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_TopicProposePeople, objvRTPaperRela_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperTitle, objvRTPaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_Author, objvRTPaperRela_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_Periodical, objvRTPaperRela_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_IsSubmit) == true)
{
if (objvRTPaperRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvRTPaperRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvRTPaperRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_id_CurrEduCls, objvRTPaperRela_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperDate) == true)
{
const strComparisonOp_PaperDate:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperDate, objvRTPaperRela_Cond.paperDate, strComparisonOp_PaperDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperStatusId) == true)
{
const strComparisonOp_PaperStatusId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperStatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperStatusId, objvRTPaperRela_Cond.paperStatusId, strComparisonOp_PaperStatusId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperTypeId, objvRTPaperRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_PaperUserId) == true)
{
const strComparisonOp_PaperUserId:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_PaperUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTPaperRelaEN.con_PaperUserId, objvRTPaperRela_Cond.paperUserId, strComparisonOp_PaperUserId);
}
if (Object.prototype.hasOwnProperty.call(objvRTPaperRela_Cond.dicFldComparisonOp, clsvRTPaperRelaEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvRTPaperRela_Cond.dicFldComparisonOp[clsvRTPaperRelaEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTPaperRelaEN.con_VersionCount, objvRTPaperRela_Cond.versionCount, strComparisonOp_VersionCount);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvRTPaperRelaENS:源对象
 * @param objvRTPaperRelaENT:目标对象
*/
export function vRTPaperRela_CopyObjTo(objvRTPaperRelaENS: clsvRTPaperRelaEN , objvRTPaperRelaENT: clsvRTPaperRelaEN ): void 
{
objvRTPaperRelaENT.mId = objvRTPaperRelaENS.mId; //mId
objvRTPaperRelaENT.topicId = objvRTPaperRelaENS.topicId; //主题Id
objvRTPaperRelaENT.paperId = objvRTPaperRelaENS.paperId; //论文Id
objvRTPaperRelaENT.updDate = objvRTPaperRelaENS.updDate; //修改日期
objvRTPaperRelaENT.updUser = objvRTPaperRelaENS.updUser; //修改人
objvRTPaperRelaENT.memo = objvRTPaperRelaENS.memo; //备注
objvRTPaperRelaENT.topicName = objvRTPaperRelaENS.topicName; //栏目主题
objvRTPaperRelaENT.topicContent = objvRTPaperRelaENS.topicContent; //主题内容
objvRTPaperRelaENT.topicProposePeople = objvRTPaperRelaENS.topicProposePeople; //主题提出人
objvRTPaperRelaENT.paperTitle = objvRTPaperRelaENS.paperTitle; //论文标题
objvRTPaperRelaENT.paperContent = objvRTPaperRelaENS.paperContent; //主题内容
objvRTPaperRelaENT.author = objvRTPaperRelaENS.author; //作者
objvRTPaperRelaENT.periodical = objvRTPaperRelaENS.periodical; //期刊
objvRTPaperRelaENT.isSubmit = objvRTPaperRelaENS.isSubmit; //是否提交
objvRTPaperRelaENT.id_CurrEduCls = objvRTPaperRelaENS.id_CurrEduCls; //教学班流水号
objvRTPaperRelaENT.paperDate = objvRTPaperRelaENS.paperDate; //PaperDate
objvRTPaperRelaENT.paperStatusId = objvRTPaperRelaENS.paperStatusId; //论文状态Id
objvRTPaperRelaENT.paperTypeId = objvRTPaperRelaENS.paperTypeId; //论文类型Id
objvRTPaperRelaENT.paperUserId = objvRTPaperRelaENS.paperUserId; //PaperUserId
objvRTPaperRelaENT.versionCount = objvRTPaperRelaENS.versionCount; //版本统计
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvRTPaperRelaENS:源对象
 * @param objvRTPaperRelaENT:目标对象
*/
export function vRTPaperRela_GetObjFromJsonObj(objvRTPaperRelaENS: clsvRTPaperRelaEN): clsvRTPaperRelaEN 
{
 const objvRTPaperRelaENT: clsvRTPaperRelaEN = new clsvRTPaperRelaEN();
ObjectAssign(objvRTPaperRelaENT, objvRTPaperRelaENS);
 return objvRTPaperRelaENT;
}