
 /**
 * 类名:clsgs_TagsWApi
 * 表名:gs_Tags(01120714)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:13
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 标注(gs_Tags)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsgs_TagsEN } from "../../L0_Entity/InteractManage/clsgs_TagsEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_Tags_Controller = "gs_TagsApi";
 export const gs_Tags_ConstructorName = "gs_Tags";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strTagsId:关键字
 * @returns 对象
 **/
export async function gs_Tags_GetObjByTagsIdAsync(strTagsId: string): Promise<clsgs_TagsEN>  
{
const strThisFuncName = "GetObjByTagsIdAsync";

if (IsNullOrEmpty(strTagsId) == true)
{
  const strMsg = Format("参数:[strTagsId]不能为空！(In GetObjByTagsIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strTagsId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTagsId]的长度:[{0}]不正确！", strTagsId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByTagsId";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strTagsId": strTagsId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_Tags = gs_Tags_GetObjFromJsonObj(returnObj);
return objgs_Tags;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param strTagsId:所给的关键字
 * @returns 对象
*/
export async function gs_Tags_GetObjByTagsId_Cache(strTagsId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByTagsId_Cache";

if (IsNullOrEmpty(strTagsId) == true)
{
  const strMsg = Format("参数:[strTagsId]不能为空！(In GetObjByTagsId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strTagsId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTagsId]的长度:[{0}]不正确！", strTagsId.length);
console.error(strMsg);
throw (strMsg);
}
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
try
{
const arrgs_Tags_Sel: Array <clsgs_TagsEN> = arrgs_TagsObjLst_Cache.filter(x => x.tagsId == strTagsId);
let objgs_Tags: clsgs_TagsEN;
if (arrgs_Tags_Sel.length > 0)
{
objgs_Tags = arrgs_Tags_Sel[0];
return objgs_Tags;
}
else
{
if (bolTryAsyncOnce == true)
{
objgs_Tags = await gs_Tags_GetObjByTagsIdAsync(strTagsId);
if (objgs_Tags != null)
{
gs_Tags_ReFreshThisCache();
return objgs_Tags;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTagsId, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strTagsId:所给的关键字
 * @returns 对象
*/
export async function gs_Tags_GetObjByTagsId_localStorage(strTagsId: string) {
const strThisFuncName = "GetObjByTagsId_localStorage";

if (IsNullOrEmpty(strTagsId) == true)
{
  const strMsg = Format("参数:[strTagsId]不能为空！(In GetObjByTagsId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strTagsId.length != 10)
{
const strMsg = Format("缓存分类变量:[strTagsId]的长度:[{0}]不正确！", strTagsId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsgs_TagsEN._CurrTabName, strTagsId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objgs_Tags_Cache: clsgs_TagsEN = JSON.parse(strTempObj);
return objgs_Tags_Cache;
}
try
{
const objgs_Tags = await gs_Tags_GetObjByTagsIdAsync(strTagsId);
if (objgs_Tags != null)
{
localStorage.setItem(strKey, JSON.stringify(objgs_Tags));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objgs_Tags;
}
return objgs_Tags;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTagsId, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objgs_Tags:所给的对象
 * @returns 对象
*/
export async function gs_Tags_UpdateObjInLst_Cache(objgs_Tags: clsgs_TagsEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
const obj = arrgs_TagsObjLst_Cache.find(x => x.paperId == objgs_Tags.paperId && x.tagsId == objgs_Tags.tagsId);
if (obj != null)
{
objgs_Tags.tagsId = obj.tagsId;
ObjectAssign( obj, objgs_Tags);
}
else
{
arrgs_TagsObjLst_Cache.push(objgs_Tags);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
export async function gs_Tags_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsgs_TagsEN.con_TagsId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsgs_TagsEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsgs_TagsEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strTagsId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objgs_Tags = await gs_Tags_GetObjByTagsId_Cache(strTagsId );
if (objgs_Tags == null) return "";
return objgs_Tags.GetFldValue(strOutFldName).toString();
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
export function gs_Tags_SortFun_Defa(a:clsgs_TagsEN , b:clsgs_TagsEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.tagsId.localeCompare(b.tagsId);
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
export function gs_Tags_SortFun_Defa_2Fld(a:clsgs_TagsEN , b:clsgs_TagsEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.tagsContent == b.tagsContent) return a.pdfContent.localeCompare(b.pdfContent);
else return a.tagsContent.localeCompare(b.tagsContent);
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
export function gs_Tags_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_TagsEN.con_TagsId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.tagsId.localeCompare(b.tagsId);
}
case clsgs_TagsEN.con_TagsContent:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.tagsContent.localeCompare(b.tagsContent);
}
case clsgs_TagsEN.con_PdfContent:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsgs_TagsEN.con_PdfPageNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsgs_TagsEN.con_VoteCount:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.voteCount-b.voteCount;
}
case clsgs_TagsEN.con_OrderNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.orderNum-b.orderNum;
}
case clsgs_TagsEN.con_UpdUser:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_TagsEN.con_UpdDate:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_TagsEN.con_PdfLineNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfLineNum-b.pdfLineNum;
}
case clsgs_TagsEN.con_PdfX:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfX.localeCompare(b.pdfX);
}
case clsgs_TagsEN.con_PdfY:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfY.localeCompare(b.pdfY);
}
case clsgs_TagsEN.con_Memo:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.memo.localeCompare(b.memo);
}
case clsgs_TagsEN.con_id_CurrEduCls:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_TagsEN.con_PaperId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_TagsEN.con_ShareId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsgs_TagsEN.con_PdfPageNumIn:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfPageNumIn.localeCompare(b.pdfPageNumIn);
}
case clsgs_TagsEN.con_PdfPageTop:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfPageTop-b.pdfPageTop;
}
case clsgs_TagsEN.con_PdfDivLet:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfDivLet.localeCompare(b.pdfDivLet);
}
case clsgs_TagsEN.con_PdfDivTop:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfDivTop.localeCompare(b.pdfDivTop);
}
case clsgs_TagsEN.con_PdfZoom:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.pdfZoom.localeCompare(b.pdfZoom);
}
case clsgs_TagsEN.con_TagsTypeId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return a.tagsTypeId.localeCompare(b.tagsTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${ gs_Tags_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_TagsEN.con_TagsId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.tagsId.localeCompare(a.tagsId);
}
case clsgs_TagsEN.con_TagsContent:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.tagsContent.localeCompare(a.tagsContent);
}
case clsgs_TagsEN.con_PdfContent:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsgs_TagsEN.con_PdfPageNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsgs_TagsEN.con_VoteCount:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.voteCount-a.voteCount;
}
case clsgs_TagsEN.con_OrderNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.orderNum-a.orderNum;
}
case clsgs_TagsEN.con_UpdUser:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_TagsEN.con_UpdDate:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_TagsEN.con_PdfLineNum:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfLineNum-a.pdfLineNum;
}
case clsgs_TagsEN.con_PdfX:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfX.localeCompare(a.pdfX);
}
case clsgs_TagsEN.con_PdfY:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfY.localeCompare(a.pdfY);
}
case clsgs_TagsEN.con_Memo:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.memo.localeCompare(a.memo);
}
case clsgs_TagsEN.con_id_CurrEduCls:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_TagsEN.con_PaperId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_TagsEN.con_ShareId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsgs_TagsEN.con_PdfPageNumIn:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfPageNumIn.localeCompare(a.pdfPageNumIn);
}
case clsgs_TagsEN.con_PdfPageTop:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfPageTop-a.pdfPageTop;
}
case clsgs_TagsEN.con_PdfDivLet:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfDivLet.localeCompare(a.pdfDivLet);
}
case clsgs_TagsEN.con_PdfDivTop:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfDivTop.localeCompare(a.pdfDivTop);
}
case clsgs_TagsEN.con_PdfZoom:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.pdfZoom.localeCompare(a.pdfZoom);
}
case clsgs_TagsEN.con_TagsTypeId:
return (a: clsgs_TagsEN, b: clsgs_TagsEN) => {
return b.tagsTypeId.localeCompare(a.tagsTypeId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${ gs_Tags_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_Tags_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_TagsEN.con_TagsId:
return (obj: clsgs_TagsEN) => {
return obj.tagsId === value;
}
case clsgs_TagsEN.con_TagsContent:
return (obj: clsgs_TagsEN) => {
return obj.tagsContent === value;
}
case clsgs_TagsEN.con_PdfContent:
return (obj: clsgs_TagsEN) => {
return obj.pdfContent === value;
}
case clsgs_TagsEN.con_PdfPageNum:
return (obj: clsgs_TagsEN) => {
return obj.pdfPageNum === value;
}
case clsgs_TagsEN.con_VoteCount:
return (obj: clsgs_TagsEN) => {
return obj.voteCount === value;
}
case clsgs_TagsEN.con_OrderNum:
return (obj: clsgs_TagsEN) => {
return obj.orderNum === value;
}
case clsgs_TagsEN.con_UpdUser:
return (obj: clsgs_TagsEN) => {
return obj.updUser === value;
}
case clsgs_TagsEN.con_UpdDate:
return (obj: clsgs_TagsEN) => {
return obj.updDate === value;
}
case clsgs_TagsEN.con_PdfLineNum:
return (obj: clsgs_TagsEN) => {
return obj.pdfLineNum === value;
}
case clsgs_TagsEN.con_PdfX:
return (obj: clsgs_TagsEN) => {
return obj.pdfX === value;
}
case clsgs_TagsEN.con_PdfY:
return (obj: clsgs_TagsEN) => {
return obj.pdfY === value;
}
case clsgs_TagsEN.con_Memo:
return (obj: clsgs_TagsEN) => {
return obj.memo === value;
}
case clsgs_TagsEN.con_id_CurrEduCls:
return (obj: clsgs_TagsEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_TagsEN.con_PaperId:
return (obj: clsgs_TagsEN) => {
return obj.paperId === value;
}
case clsgs_TagsEN.con_ShareId:
return (obj: clsgs_TagsEN) => {
return obj.shareId === value;
}
case clsgs_TagsEN.con_PdfPageNumIn:
return (obj: clsgs_TagsEN) => {
return obj.pdfPageNumIn === value;
}
case clsgs_TagsEN.con_PdfPageTop:
return (obj: clsgs_TagsEN) => {
return obj.pdfPageTop === value;
}
case clsgs_TagsEN.con_PdfDivLet:
return (obj: clsgs_TagsEN) => {
return obj.pdfDivLet === value;
}
case clsgs_TagsEN.con_PdfDivTop:
return (obj: clsgs_TagsEN) => {
return obj.pdfDivTop === value;
}
case clsgs_TagsEN.con_PdfZoom:
return (obj: clsgs_TagsEN) => {
return obj.pdfZoom === value;
}
case clsgs_TagsEN.con_TagsTypeId:
return (obj: clsgs_TagsEN) => {
return obj.tagsTypeId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_Tags]中不存在！(in ${ gs_Tags_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_Tags_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_TagsEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_Tags = gs_Tags_GetObjFromJsonObj(returnObj);
return objgs_Tags;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TagsEN._CurrTabName;
clsgs_TagsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TagsEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TagsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TagsEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrgs_TagsExObjLst_Cache: Array<clsgs_TagsEN> = CacheHelper.Get(strKey);
const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
return arrgs_TagsObjLst_T;
}
try
{
const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrgs_TagsExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
console.log(strInfo);
return arrgs_TagsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Tags_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TagsEN._CurrTabName;
clsgs_TagsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TagsEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TagsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TagsEN.CacheAddiCondition);
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
const arrgs_TagsExObjLst_Cache: Array<clsgs_TagsEN> = JSON.parse(strTempObjLst);
const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
return arrgs_TagsObjLst_T;
}
try
{
const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrgs_TagsExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
console.log(strInfo);
return arrgs_TagsExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Tags_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TagsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrgs_TagsObjLst_Cache: Array<clsgs_TagsEN> = JSON.parse(strTempObjLst);
return arrgs_TagsObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_Tags_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_TagsEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsgs_TagsEN._CurrTabName;
clsgs_TagsEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsgs_TagsEN._CurrTabName);
if (IsNullOrEmpty(clsgs_TagsEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsgs_TagsEN.CacheAddiCondition);
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
const arrgs_TagsExObjLst_Cache: Array<clsgs_TagsEN> = JSON.parse(strTempObjLst);
const arrgs_TagsObjLst_T = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsExObjLst_Cache);
return arrgs_TagsObjLst_T;
}
try
{
const arrgs_TagsExObjLst = await gs_Tags_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrgs_TagsExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TagsExObjLst.length);
console.log(strInfo);
return arrgs_TagsExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Tags_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsgs_TagsEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrgs_TagsObjLst_Cache: Array<clsgs_TagsEN> = JSON.parse(strTempObjLst);
return arrgs_TagsObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Tags_GetObjLst_Cache(): Promise<Array<clsgs_TagsEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrgs_TagsObjLst_Cache;
switch (clsgs_TagsEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_ClientCache();
break;
default:
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_ClientCache();
break;
}
const arrgs_TagsObjLst = gs_Tags_GetObjLstByJSONObjLst(arrgs_TagsObjLst_Cache);
return arrgs_TagsObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function gs_Tags_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrgs_TagsObjLst_Cache;
switch (clsgs_TagsEN.CacheModeId)
{
case "04"://sessionStorage
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrgs_TagsObjLst_Cache = null;
break;
default:
arrgs_TagsObjLst_Cache = null;
break;
}
return arrgs_TagsObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrTagsId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_Tags_GetSubObjLst_Cache(objgs_Tags_Cond: clsgs_TagsEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
let arrgs_Tags_Sel: Array < clsgs_TagsEN > = arrgs_TagsObjLst_Cache;
if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "") return arrgs_Tags_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
//console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Tags_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Tags_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_Tags_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objgs_Tags_Cond), gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TagsEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrTagsId:关键字列表
 * @returns 对象列表
 **/
export async function gs_Tags_GetObjLstByTagsIdLstAsync(arrTagsId: Array<string>): Promise<Array<clsgs_TagsEN>>  
{
const strThisFuncName = "GetObjLstByTagsIdLstAsync";
const strAction = "GetObjLstByTagsIdLst";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTagsId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param arrstrTagsIdLst:关键字列表
 * @returns 对象列表
*/
export async function gs_Tags_GetObjLstByTagsIdLst_Cache(arrTagsIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByTagsIdLst_Cache";
try
{
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
const arrgs_Tags_Sel: Array <clsgs_TagsEN> = arrgs_TagsObjLst_Cache.filter(x => arrTagsIdLst.indexOf(x.tagsId)>-1);
return arrgs_Tags_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTagsIdLst.join(","), gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TagsEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_Tags_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_TagsEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_TagsEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
if (arrgs_TagsObjLst_Cache.length == 0) return arrgs_TagsObjLst_Cache;
let arrgs_Tags_Sel = arrgs_TagsObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objgs_Tags_Cond = new clsgs_TagsEN();
ObjectAssign(objgs_Tags_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsgs_TagsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Tags_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_Tags_Sel.length == 0) return arrgs_Tags_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrgs_Tags_Sel = arrgs_Tags_Sel.sort(gs_Tags_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrgs_Tags_Sel = arrgs_Tags_Sel.sort(objPagerPara.sortFun);
}
arrgs_Tags_Sel = arrgs_Tags_Sel.slice(intStart, intEnd);     
return arrgs_Tags_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsgs_TagsEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_Tags_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_TagsEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_Tags_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_Tags_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param strTagsId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_Tags_DelRecordAsync(strTagsId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strTagsId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strTagsId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param arrTagsId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_Tags_Delgs_TagssAsync(arrTagsId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_TagssAsync";
const strAction = "Delgs_Tagss";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrTagsId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_Delgs_TagssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_TagssByCondAsync";
const strAction = "Delgs_TagssByCond";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_AddNewRecordAsync(objgs_TagsEN: clsgs_TagsEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_TagsEN);
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_AddNewRecordWithMaxIdAsync(objgs_TagsEN: clsgs_TagsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_TagsEN);
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_TagsEN);
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objgs_TagsEN);
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_Tags_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objgs_TagsEN);
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_Tags_AddNewRecordWithReturnKeyAsync(objgs_TagsEN: clsgs_TagsEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_Tags_AddNewRecordWithReturnKey(objgs_TagsEN: clsgs_TagsEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_TagsEN.tagsId === null || objgs_TagsEN.tagsId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_Tags_UpdateRecordAsync(objgs_TagsEN: clsgs_TagsEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_TagsEN.sf_UpdFldSetStr === undefined || objgs_TagsEN.sf_UpdFldSetStr === null || objgs_TagsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TagsEN.tagsId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_TagsEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_Tags_UpdateWithConditionAsync(objgs_TagsEN: clsgs_TagsEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_TagsEN.sf_UpdFldSetStr === undefined || objgs_TagsEN.sf_UpdFldSetStr === null || objgs_TagsEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TagsEN.tagsId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
objgs_TagsEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_TagsEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objstrTagsId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function gs_Tags_IsExistRecord_Cache(objgs_Tags_Cond: clsgs_TagsEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
if (arrgs_TagsObjLst_Cache == null) return false;
let arrgs_Tags_Sel: Array < clsgs_TagsEN > = arrgs_TagsObjLst_Cache;
if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "") return arrgs_Tags_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
//console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Tags_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Tags_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrgs_Tags_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objgs_Tags_Cond), gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param strTagsId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_Tags_IsExist(strTagsId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"TagsId": strTagsId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param strTagsId:所给的关键字
 * @returns 对象
*/
export async function gs_Tags_IsExist_Cache(strTagsId:string) {
const strThisFuncName = "IsExist_Cache";
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
if (arrgs_TagsObjLst_Cache == null) return false;
try
{
const arrgs_Tags_Sel: Array <clsgs_TagsEN> = arrgs_TagsObjLst_Cache.filter(x => x.tagsId == strTagsId);
if (arrgs_Tags_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTagsId, gs_Tags_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strTagsId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_Tags_IsExistAsync(strTagsId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strTagsId": strTagsId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
 * @param objgs_Tags_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function gs_Tags_GetRecCountByCond_Cache(objgs_Tags_Cond: clsgs_TagsEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrgs_TagsObjLst_Cache = await gs_Tags_GetObjLst_Cache();
if (arrgs_TagsObjLst_Cache == null) return 0;
let arrgs_Tags_Sel: Array < clsgs_TagsEN > = arrgs_TagsObjLst_Cache;
if (objgs_Tags_Cond.sf_FldComparisonOp == null || objgs_Tags_Cond.sf_FldComparisonOp == "") return arrgs_Tags_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objgs_Tags_Cond.sf_FldComparisonOp);
//console.log("clsgs_TagsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objgs_Tags_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objgs_Tags_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrgs_Tags_Sel = arrgs_Tags_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrgs_Tags_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objgs_Tags_Cond), gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export async function gs_Tags_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_Tags_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_Tags_ConstructorName, strThisFuncName);
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
export function gs_Tags_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_Tags_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsgs_TagsEN._CurrTabName;
switch (clsgs_TagsEN.CacheModeId)
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
export function gs_Tags_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsgs_TagsEN._CurrTabName;
switch (clsgs_TagsEN.CacheModeId)
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
export function gs_Tags_CheckPropertyNew(pobjgs_TagsEN: clsgs_TagsEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TagsEN.tagsId) == false && GetStrLen(pobjgs_TagsEN.tagsId) > 10)
{
 throw new Error("(errid:Watl000059)字段[标注Id(tagsId)]的长度不能超过10(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsId)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfContent) == false && GetStrLen(pobjgs_TagsEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfContent)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updUser) == false && GetStrLen(pobjgs_TagsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updUser)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updDate) == false && GetStrLen(pobjgs_TagsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updDate)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfX) == false && GetStrLen(pobjgs_TagsEN.pdfX) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfX(pdfX)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfX)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfY) == false && GetStrLen(pobjgs_TagsEN.pdfY) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfY(pdfY)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfY)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.memo) == false && GetStrLen(pobjgs_TagsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.memo)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TagsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.id_CurrEduCls)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.paperId) == false && GetStrLen(pobjgs_TagsEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.paperId)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.shareId) == false && GetStrLen(pobjgs_TagsEN.shareId) > 2)
{
 throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.shareId)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfPageNumIn) == false && GetStrLen(pobjgs_TagsEN.pdfPageNumIn) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfPageNumIn(pdfPageNumIn)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfPageNumIn)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivLet) == false && GetStrLen(pobjgs_TagsEN.pdfDivLet) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfDivLet(pdfDivLet)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivLet)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivTop) == false && GetStrLen(pobjgs_TagsEN.pdfDivTop) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfDivTop(pdfDivTop)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivTop)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfZoom) == false && GetStrLen(pobjgs_TagsEN.pdfZoom) > 50)
{
 throw new Error("(errid:Watl000059)字段[PdfZoom(pdfZoom)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfZoom)(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsTypeId) == false && GetStrLen(pobjgs_TagsEN.tagsTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[标注类型ID(tagsTypeId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsTypeId)(clsgs_TagsBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TagsEN.tagsId) == false && undefined !== pobjgs_TagsEN.tagsId && tzDataType.isString(pobjgs_TagsEN.tagsId) === false)
{
 throw new Error("(errid:Watl000060)字段[标注Id(tagsId)]的值:[$(pobjgs_TagsEN.tagsId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsContent) == false && undefined !== pobjgs_TagsEN.tagsContent && tzDataType.isString(pobjgs_TagsEN.tagsContent) === false)
{
 throw new Error("(errid:Watl000060)字段[标注内容(tagsContent)]的值:[$(pobjgs_TagsEN.tagsContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfContent) == false && undefined !== pobjgs_TagsEN.pdfContent && tzDataType.isString(pobjgs_TagsEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjgs_TagsEN.pdfContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (null != pobjgs_TagsEN.pdfPageNum && undefined !== pobjgs_TagsEN.pdfPageNum && tzDataType.isNumber(pobjgs_TagsEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjgs_TagsEN.pdfPageNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (null != pobjgs_TagsEN.voteCount && undefined !== pobjgs_TagsEN.voteCount && tzDataType.isNumber(pobjgs_TagsEN.voteCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjgs_TagsEN.voteCount)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (null != pobjgs_TagsEN.orderNum && undefined !== pobjgs_TagsEN.orderNum && tzDataType.isNumber(pobjgs_TagsEN.orderNum) === false)
{
 throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_TagsEN.orderNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updUser) == false && undefined !== pobjgs_TagsEN.updUser && tzDataType.isString(pobjgs_TagsEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_TagsEN.updUser)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updDate) == false && undefined !== pobjgs_TagsEN.updDate && tzDataType.isString(pobjgs_TagsEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_TagsEN.updDate)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (null != pobjgs_TagsEN.pdfLineNum && undefined !== pobjgs_TagsEN.pdfLineNum && tzDataType.isNumber(pobjgs_TagsEN.pdfLineNum) === false)
{
 throw new Error("(errid:Watl000060)字段[pdf行号(pdfLineNum)]的值:[$(pobjgs_TagsEN.pdfLineNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfX) == false && undefined !== pobjgs_TagsEN.pdfX && tzDataType.isString(pobjgs_TagsEN.pdfX) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfX(pdfX)]的值:[$(pobjgs_TagsEN.pdfX)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfY) == false && undefined !== pobjgs_TagsEN.pdfY && tzDataType.isString(pobjgs_TagsEN.pdfY) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfY(pdfY)]的值:[$(pobjgs_TagsEN.pdfY)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.memo) == false && undefined !== pobjgs_TagsEN.memo && tzDataType.isString(pobjgs_TagsEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TagsEN.memo)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.id_CurrEduCls) == false && undefined !== pobjgs_TagsEN.id_CurrEduCls && tzDataType.isString(pobjgs_TagsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TagsEN.id_CurrEduCls)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.paperId) == false && undefined !== pobjgs_TagsEN.paperId && tzDataType.isString(pobjgs_TagsEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_TagsEN.paperId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.shareId) == false && undefined !== pobjgs_TagsEN.shareId && tzDataType.isString(pobjgs_TagsEN.shareId) === false)
{
 throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjgs_TagsEN.shareId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfPageNumIn) == false && undefined !== pobjgs_TagsEN.pdfPageNumIn && tzDataType.isString(pobjgs_TagsEN.pdfPageNumIn) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfPageNumIn(pdfPageNumIn)]的值:[$(pobjgs_TagsEN.pdfPageNumIn)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (null != pobjgs_TagsEN.pdfPageTop && undefined !== pobjgs_TagsEN.pdfPageTop && tzDataType.isNumber(pobjgs_TagsEN.pdfPageTop) === false)
{
 throw new Error("(errid:Watl000060)字段[pdf页面顶部位置(pdfPageTop)]的值:[$(pobjgs_TagsEN.pdfPageTop)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivLet) == false && undefined !== pobjgs_TagsEN.pdfDivLet && tzDataType.isString(pobjgs_TagsEN.pdfDivLet) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfDivLet(pdfDivLet)]的值:[$(pobjgs_TagsEN.pdfDivLet)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivTop) == false && undefined !== pobjgs_TagsEN.pdfDivTop && tzDataType.isString(pobjgs_TagsEN.pdfDivTop) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfDivTop(pdfDivTop)]的值:[$(pobjgs_TagsEN.pdfDivTop)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfZoom) == false && undefined !== pobjgs_TagsEN.pdfZoom && tzDataType.isString(pobjgs_TagsEN.pdfZoom) === false)
{
 throw new Error("(errid:Watl000060)字段[PdfZoom(pdfZoom)]的值:[$(pobjgs_TagsEN.pdfZoom)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsTypeId) == false && undefined !== pobjgs_TagsEN.tagsTypeId && tzDataType.isString(pobjgs_TagsEN.tagsTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[标注类型ID(tagsTypeId)]的值:[$(pobjgs_TagsEN.tagsTypeId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_TagsEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_Tags_CheckProperty4Update (pobjgs_TagsEN: clsgs_TagsEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_TagsEN.tagsId) == false && GetStrLen(pobjgs_TagsEN.tagsId) > 10)
{
 throw new Error("(errid:Watl000062)字段[标注Id(tagsId)]的长度不能超过10(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsId)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfContent) == false && GetStrLen(pobjgs_TagsEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfContent)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updUser) == false && GetStrLen(pobjgs_TagsEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updUser)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updDate) == false && GetStrLen(pobjgs_TagsEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.updDate)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfX) == false && GetStrLen(pobjgs_TagsEN.pdfX) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfX(pdfX)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfX)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfY) == false && GetStrLen(pobjgs_TagsEN.pdfY) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfY(pdfY)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfY)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.memo) == false && GetStrLen(pobjgs_TagsEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.memo)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.id_CurrEduCls) == false && GetStrLen(pobjgs_TagsEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.id_CurrEduCls)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.paperId) == false && GetStrLen(pobjgs_TagsEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.paperId)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.shareId) == false && GetStrLen(pobjgs_TagsEN.shareId) > 2)
{
 throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.shareId)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfPageNumIn) == false && GetStrLen(pobjgs_TagsEN.pdfPageNumIn) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfPageNumIn(pdfPageNumIn)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfPageNumIn)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivLet) == false && GetStrLen(pobjgs_TagsEN.pdfDivLet) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfDivLet(pdfDivLet)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivLet)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivTop) == false && GetStrLen(pobjgs_TagsEN.pdfDivTop) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfDivTop(pdfDivTop)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfDivTop)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfZoom) == false && GetStrLen(pobjgs_TagsEN.pdfZoom) > 50)
{
 throw new Error("(errid:Watl000062)字段[PdfZoom(pdfZoom)]的长度不能超过50(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.pdfZoom)(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsTypeId) == false && GetStrLen(pobjgs_TagsEN.tagsTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[标注类型ID(tagsTypeId)]的长度不能超过2(In 标注(gs_Tags))!值:$(pobjgs_TagsEN.tagsTypeId)(clsgs_TagsBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjgs_TagsEN.tagsId) == false && undefined !== pobjgs_TagsEN.tagsId && tzDataType.isString(pobjgs_TagsEN.tagsId) === false)
{
 throw new Error("(errid:Watl000063)字段[标注Id(tagsId)]的值:[$(pobjgs_TagsEN.tagsId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsContent) == false && undefined !== pobjgs_TagsEN.tagsContent && tzDataType.isString(pobjgs_TagsEN.tagsContent) === false)
{
 throw new Error("(errid:Watl000063)字段[标注内容(tagsContent)]的值:[$(pobjgs_TagsEN.tagsContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfContent) == false && undefined !== pobjgs_TagsEN.pdfContent && tzDataType.isString(pobjgs_TagsEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjgs_TagsEN.pdfContent)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (null != pobjgs_TagsEN.pdfPageNum && undefined !== pobjgs_TagsEN.pdfPageNum && tzDataType.isNumber(pobjgs_TagsEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjgs_TagsEN.pdfPageNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (null != pobjgs_TagsEN.voteCount && undefined !== pobjgs_TagsEN.voteCount && tzDataType.isNumber(pobjgs_TagsEN.voteCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjgs_TagsEN.voteCount)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (null != pobjgs_TagsEN.orderNum && undefined !== pobjgs_TagsEN.orderNum && tzDataType.isNumber(pobjgs_TagsEN.orderNum) === false)
{
 throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_TagsEN.orderNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updUser) == false && undefined !== pobjgs_TagsEN.updUser && tzDataType.isString(pobjgs_TagsEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_TagsEN.updUser)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.updDate) == false && undefined !== pobjgs_TagsEN.updDate && tzDataType.isString(pobjgs_TagsEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_TagsEN.updDate)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (null != pobjgs_TagsEN.pdfLineNum && undefined !== pobjgs_TagsEN.pdfLineNum && tzDataType.isNumber(pobjgs_TagsEN.pdfLineNum) === false)
{
 throw new Error("(errid:Watl000063)字段[pdf行号(pdfLineNum)]的值:[$(pobjgs_TagsEN.pdfLineNum)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfX) == false && undefined !== pobjgs_TagsEN.pdfX && tzDataType.isString(pobjgs_TagsEN.pdfX) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfX(pdfX)]的值:[$(pobjgs_TagsEN.pdfX)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfY) == false && undefined !== pobjgs_TagsEN.pdfY && tzDataType.isString(pobjgs_TagsEN.pdfY) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfY(pdfY)]的值:[$(pobjgs_TagsEN.pdfY)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.memo) == false && undefined !== pobjgs_TagsEN.memo && tzDataType.isString(pobjgs_TagsEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TagsEN.memo)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.id_CurrEduCls) == false && undefined !== pobjgs_TagsEN.id_CurrEduCls && tzDataType.isString(pobjgs_TagsEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_TagsEN.id_CurrEduCls)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.paperId) == false && undefined !== pobjgs_TagsEN.paperId && tzDataType.isString(pobjgs_TagsEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_TagsEN.paperId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.shareId) == false && undefined !== pobjgs_TagsEN.shareId && tzDataType.isString(pobjgs_TagsEN.shareId) === false)
{
 throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjgs_TagsEN.shareId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfPageNumIn) == false && undefined !== pobjgs_TagsEN.pdfPageNumIn && tzDataType.isString(pobjgs_TagsEN.pdfPageNumIn) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfPageNumIn(pdfPageNumIn)]的值:[$(pobjgs_TagsEN.pdfPageNumIn)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (null != pobjgs_TagsEN.pdfPageTop && undefined !== pobjgs_TagsEN.pdfPageTop && tzDataType.isNumber(pobjgs_TagsEN.pdfPageTop) === false)
{
 throw new Error("(errid:Watl000063)字段[pdf页面顶部位置(pdfPageTop)]的值:[$(pobjgs_TagsEN.pdfPageTop)], 非法，应该为数值型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivLet) == false && undefined !== pobjgs_TagsEN.pdfDivLet && tzDataType.isString(pobjgs_TagsEN.pdfDivLet) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfDivLet(pdfDivLet)]的值:[$(pobjgs_TagsEN.pdfDivLet)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfDivTop) == false && undefined !== pobjgs_TagsEN.pdfDivTop && tzDataType.isString(pobjgs_TagsEN.pdfDivTop) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfDivTop(pdfDivTop)]的值:[$(pobjgs_TagsEN.pdfDivTop)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.pdfZoom) == false && undefined !== pobjgs_TagsEN.pdfZoom && tzDataType.isString(pobjgs_TagsEN.pdfZoom) === false)
{
 throw new Error("(errid:Watl000063)字段[PdfZoom(pdfZoom)]的值:[$(pobjgs_TagsEN.pdfZoom)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_TagsEN.tagsTypeId) == false && undefined !== pobjgs_TagsEN.tagsTypeId && tzDataType.isString(pobjgs_TagsEN.tagsTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[标注类型ID(tagsTypeId)]的值:[$(pobjgs_TagsEN.tagsTypeId)], 非法，应该为字符型(In 标注(gs_Tags))!(clsgs_TagsBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjgs_TagsEN.tagsId) === true )
{
 throw new Error("(errid:Watl000064)字段[标注Id]不能为空(In 标注)!(clsgs_TagsBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_TagsEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_Tags_GetJSONStrByObj (pobjgs_TagsEN: clsgs_TagsEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_TagsEN.sf_UpdFldSetStr = pobjgs_TagsEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_TagsEN);
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
export function gs_Tags_GetObjLstByJSONStr (strJSON: string): Array<clsgs_TagsEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_TagsObjLst = new Array<clsgs_TagsEN>();
if (strJSON === "")
{
return arrgs_TagsObjLst;
}
try
{
arrgs_TagsObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_TagsObjLst;
}
return arrgs_TagsObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_TagsObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_Tags_GetObjLstByJSONObjLst (arrgs_TagsObjLstS: Array<clsgs_TagsEN>): Array<clsgs_TagsEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_TagsObjLst = new Array<clsgs_TagsEN>();
for (const objInFor of arrgs_TagsObjLstS) {
const obj1 = gs_Tags_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_TagsObjLst.push(obj1);
}
return arrgs_TagsObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_Tags_GetObjByJSONStr (strJSON: string): clsgs_TagsEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_TagsEN = new clsgs_TagsEN();
if (strJSON === "")
{
return pobjgs_TagsEN;
}
try
{
pobjgs_TagsEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_TagsEN;
}
return pobjgs_TagsEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_Tags_GetCombineCondition(objgs_Tags_Cond: clsgs_TagsEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_TagsId) == true)
{
const strComparisonOp_TagsId:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_TagsId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_TagsId, objgs_Tags_Cond.tagsId, strComparisonOp_TagsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfContent, objgs_Tags_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TagsEN.con_PdfPageNum, objgs_Tags_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_VoteCount) == true)
{
const strComparisonOp_VoteCount:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_VoteCount];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TagsEN.con_VoteCount, objgs_Tags_Cond.voteCount, strComparisonOp_VoteCount);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TagsEN.con_OrderNum, objgs_Tags_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_UpdUser, objgs_Tags_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_UpdDate, objgs_Tags_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfLineNum) == true)
{
const strComparisonOp_PdfLineNum:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfLineNum];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TagsEN.con_PdfLineNum, objgs_Tags_Cond.pdfLineNum, strComparisonOp_PdfLineNum);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfX) == true)
{
const strComparisonOp_PdfX:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfX];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfX, objgs_Tags_Cond.pdfX, strComparisonOp_PdfX);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfY) == true)
{
const strComparisonOp_PdfY:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfY];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfY, objgs_Tags_Cond.pdfY, strComparisonOp_PdfY);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_Memo, objgs_Tags_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_id_CurrEduCls, objgs_Tags_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PaperId, objgs_Tags_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_ShareId, objgs_Tags_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfPageNumIn) == true)
{
const strComparisonOp_PdfPageNumIn:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfPageNumIn];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfPageNumIn, objgs_Tags_Cond.pdfPageNumIn, strComparisonOp_PdfPageNumIn);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfPageTop) == true)
{
const strComparisonOp_PdfPageTop:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfPageTop];
strWhereCond += Format(" And {0} {2} {1}", clsgs_TagsEN.con_PdfPageTop, objgs_Tags_Cond.pdfPageTop, strComparisonOp_PdfPageTop);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfDivLet) == true)
{
const strComparisonOp_PdfDivLet:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfDivLet];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfDivLet, objgs_Tags_Cond.pdfDivLet, strComparisonOp_PdfDivLet);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfDivTop) == true)
{
const strComparisonOp_PdfDivTop:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfDivTop];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfDivTop, objgs_Tags_Cond.pdfDivTop, strComparisonOp_PdfDivTop);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_PdfZoom) == true)
{
const strComparisonOp_PdfZoom:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_PdfZoom];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_PdfZoom, objgs_Tags_Cond.pdfZoom, strComparisonOp_PdfZoom);
}
if (Object.prototype.hasOwnProperty.call(objgs_Tags_Cond.dicFldComparisonOp, clsgs_TagsEN.con_TagsTypeId) == true)
{
const strComparisonOp_TagsTypeId:string = objgs_Tags_Cond.dicFldComparisonOp[clsgs_TagsEN.con_TagsTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_TagsEN.con_TagsTypeId, objgs_Tags_Cond.tagsTypeId, strComparisonOp_TagsTypeId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_Tags(标注),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strTagsId: 标注Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_Tags_GetUniCondStr_PaperId_TagsId(objgs_TagsEN: clsgs_TagsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperId = '{0}'", objgs_TagsEN.paperId);
 strWhereCond +=  Format(" and TagsId = '{0}'", objgs_TagsEN.tagsId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_Tags(标注),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strPaperId: 论文Id(要求唯一的字段)
 * @param strTagsId: 标注Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_Tags_GetUniCondStr4Update_PaperId_TagsId(objgs_TagsEN: clsgs_TagsEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and TagsId <> '{0}'", objgs_TagsEN.tagsId);
 strWhereCond +=  Format(" and PaperId = '{0}'", objgs_TagsEN.paperId);
 strWhereCond +=  Format(" and TagsId = '{0}'", objgs_TagsEN.tagsId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_TagsENS:源对象
 * @param objgs_TagsENT:目标对象
*/
export function gs_Tags_CopyObjTo(objgs_TagsENS: clsgs_TagsEN , objgs_TagsENT: clsgs_TagsEN ): void 
{
objgs_TagsENT.tagsId = objgs_TagsENS.tagsId; //标注Id
objgs_TagsENT.tagsContent = objgs_TagsENS.tagsContent; //标注内容
objgs_TagsENT.pdfContent = objgs_TagsENS.pdfContent; //Pdf内容
objgs_TagsENT.pdfPageNum = objgs_TagsENS.pdfPageNum; //Pdf页码
objgs_TagsENT.voteCount = objgs_TagsENS.voteCount; //点赞计数
objgs_TagsENT.orderNum = objgs_TagsENS.orderNum; //序号
objgs_TagsENT.updUser = objgs_TagsENS.updUser; //修改人
objgs_TagsENT.updDate = objgs_TagsENS.updDate; //修改日期
objgs_TagsENT.pdfLineNum = objgs_TagsENS.pdfLineNum; //pdf行号
objgs_TagsENT.pdfX = objgs_TagsENS.pdfX; //PdfX
objgs_TagsENT.pdfY = objgs_TagsENS.pdfY; //PdfY
objgs_TagsENT.memo = objgs_TagsENS.memo; //备注
objgs_TagsENT.id_CurrEduCls = objgs_TagsENS.id_CurrEduCls; //教学班流水号
objgs_TagsENT.paperId = objgs_TagsENS.paperId; //论文Id
objgs_TagsENT.shareId = objgs_TagsENS.shareId; //分享Id
objgs_TagsENT.pdfPageNumIn = objgs_TagsENS.pdfPageNumIn; //PdfPageNumIn
objgs_TagsENT.pdfPageTop = objgs_TagsENS.pdfPageTop; //pdf页面顶部位置
objgs_TagsENT.pdfDivLet = objgs_TagsENS.pdfDivLet; //PdfDivLet
objgs_TagsENT.pdfDivTop = objgs_TagsENS.pdfDivTop; //PdfDivTop
objgs_TagsENT.pdfZoom = objgs_TagsENS.pdfZoom; //PdfZoom
objgs_TagsENT.tagsTypeId = objgs_TagsENS.tagsTypeId; //标注类型ID
objgs_TagsENT.sf_UpdFldSetStr = objgs_TagsENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_TagsENS:源对象
 * @param objgs_TagsENT:目标对象
*/
export function gs_Tags_GetObjFromJsonObj(objgs_TagsENS: clsgs_TagsEN): clsgs_TagsEN 
{
 const objgs_TagsENT: clsgs_TagsEN = new clsgs_TagsEN();
ObjectAssign(objgs_TagsENT, objgs_TagsENS);
 return objgs_TagsENT;
}