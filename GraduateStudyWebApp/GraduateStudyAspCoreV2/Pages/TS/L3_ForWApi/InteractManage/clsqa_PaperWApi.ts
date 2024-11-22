
 /**
 * 类名:clsqa_PaperWApi
 * 表名:qa_Paper(01120643)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:05
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
 * 论文答疑表(qa_Paper)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsqa_PaperEN } from "../../L0_Entity/InteractManage/clsqa_PaperEN.js";
import { vqa_Paper_ReFreshThisCache } from "../../L3_ForWApi/InteractManage/clsvqa_PaperWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const qa_Paper_Controller = "qa_PaperApi";
 export const qa_Paper_ConstructorName = "qa_Paper";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strqa_PaperId:关键字
 * @returns 对象
 **/
export async function qa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId: string): Promise<clsqa_PaperEN|null>  
{
const strThisFuncName = "GetObjByqa_PaperIdAsync";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In clsqa_PaperWApi.GetObjByqa_PaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsqa_PaperWApi.GetObjByqa_PaperIdAsync)", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByqa_PaperId";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strqa_PaperId": strqa_PaperId,
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
const objqa_Paper = qa_Paper_GetObjFromJsonObj(returnObj);
return objqa_Paper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param strqa_PaperId:所给的关键字
 * @returns 对象
*/
export async function qa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByqa_PaperId_Cache";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In clsqa_PaperWApi.GetObjByqa_PaperId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsqa_PaperWApi.GetObjByqa_PaperId_Cache)", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrqa_Paper_Sel: Array <clsqa_PaperEN> = arrqa_PaperObjLst_Cache.filter(x => 
 x.qa_PaperId == strqa_PaperId );
let objqa_Paper: clsqa_PaperEN;
if (arrqa_Paper_Sel.length > 0)
{
objqa_Paper = arrqa_Paper_Sel[0];
return objqa_Paper;
}
else
{
if (bolTryAsyncOnce == true)
{
const objqa_Paper_Const = await qa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
if (objqa_Paper_Const != null)
{
qa_Paper_ReFreshThisCache(strid_CurrEduCls);
return objqa_Paper_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strqa_PaperId:所给的关键字
 * @returns 对象
*/
export async function qa_Paper_GetObjByqa_PaperId_localStorage(strqa_PaperId: string) {
const strThisFuncName = "GetObjByqa_PaperId_localStorage";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In clsqa_PaperWApi.GetObjByqa_PaperId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！(clsqa_PaperWApi.GetObjByqa_PaperId_localStorage)", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strqa_PaperId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objqa_Paper_Cache: clsqa_PaperEN = JSON.parse(strTempObj);
return objqa_Paper_Cache;
}
try
{
const objqa_Paper = await qa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
if (objqa_Paper != null)
{
localStorage.setItem(strKey, JSON.stringify(objqa_Paper));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objqa_Paper;
}
return objqa_Paper;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objqa_Paper:所给的对象
 * @returns 对象
*/
export async function qa_Paper_UpdateObjInLst_Cache(objqa_Paper: clsqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrqa_PaperObjLst_Cache.find(x => x.qa_PaperId == objqa_Paper.qa_PaperId);
if (obj != null)
{
objqa_Paper.qa_PaperId = obj.qa_PaperId;
ObjectAssign( obj, objqa_Paper);
}
else
{
arrqa_PaperObjLst_Cache.push(objqa_Paper);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_func(strInFldName:string , strOutFldName:string , strInValue:string 
, strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsqa_PaperWApi.func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsqa_PaperWApi.func)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsqa_PaperEN.con_qa_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsqa_PaperEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsqa_PaperEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strqa_PaperId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objqa_Paper = await qa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId , strid_CurrEduCls_C);
if (objqa_Paper == null) return "";
if (objqa_Paper.GetFldValue(strOutFldName) == null) return "";
return objqa_Paper.GetFldValue(strOutFldName).toString();
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
export function qa_Paper_SortFun_Defa(a:clsqa_PaperEN , b:clsqa_PaperEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.qa_PaperId.localeCompare(b.qa_PaperId);
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
export function qa_Paper_SortFun_Defa_2Fld(a:clsqa_PaperEN , b:clsqa_PaperEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.questionsCount - b.questionsCount;
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
export function qa_Paper_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsqa_PaperEN.con_qa_PaperId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return a.qa_PaperId.localeCompare(b.qa_PaperId);
}
case clsqa_PaperEN.con_PaperId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.paperId == null) return -1;
if (b.paperId == null) return 1;
return a.paperId.localeCompare(b.paperId);
}
case clsqa_PaperEN.con_QuestionsCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return a.questionsCount-b.questionsCount;
}
case clsqa_PaperEN.con_IsDelete:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.isDelete == true) return 1;
else return -1
}
case clsqa_PaperEN.con_IsPublic:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsqa_PaperEN.con_IsSubmit:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsqa_PaperEN.con_UpdUser:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsqa_PaperEN.con_UpdDate:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsqa_PaperEN.con_Memo:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsqa_PaperEN.con_id_CurrEduCls:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsqa_PaperEN.con_AnswerCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return a.answerCount-b.answerCount;
}
case clsqa_PaperEN.con_ShareId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (a.shareId == null) return -1;
if (b.shareId == null) return 1;
return a.shareId.localeCompare(b.shareId);
}
case clsqa_PaperEN.con_TagsCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return a.tagsCount-b.tagsCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Paper]中不存在！(in ${ qa_Paper_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsqa_PaperEN.con_qa_PaperId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return b.qa_PaperId.localeCompare(a.qa_PaperId);
}
case clsqa_PaperEN.con_PaperId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.paperId == null) return -1;
if (a.paperId == null) return 1;
return b.paperId.localeCompare(a.paperId);
}
case clsqa_PaperEN.con_QuestionsCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return b.questionsCount-a.questionsCount;
}
case clsqa_PaperEN.con_IsDelete:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.isDelete == true) return 1;
else return -1
}
case clsqa_PaperEN.con_IsPublic:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsqa_PaperEN.con_IsSubmit:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsqa_PaperEN.con_UpdUser:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsqa_PaperEN.con_UpdDate:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsqa_PaperEN.con_Memo:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsqa_PaperEN.con_id_CurrEduCls:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsqa_PaperEN.con_AnswerCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return b.answerCount-a.answerCount;
}
case clsqa_PaperEN.con_ShareId:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
if (b.shareId == null) return -1;
if (a.shareId == null) return 1;
return b.shareId.localeCompare(a.shareId);
}
case clsqa_PaperEN.con_TagsCount:
return (a: clsqa_PaperEN, b: clsqa_PaperEN) => {
return b.tagsCount-a.tagsCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Paper]中不存在！(in ${ qa_Paper_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_Paper_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsqa_PaperEN.con_qa_PaperId:
return (obj: clsqa_PaperEN) => {
return obj.qa_PaperId === value;
}
case clsqa_PaperEN.con_PaperId:
return (obj: clsqa_PaperEN) => {
return obj.paperId === value;
}
case clsqa_PaperEN.con_QuestionsCount:
return (obj: clsqa_PaperEN) => {
return obj.questionsCount === value;
}
case clsqa_PaperEN.con_IsDelete:
return (obj: clsqa_PaperEN) => {
return obj.isDelete === value;
}
case clsqa_PaperEN.con_IsPublic:
return (obj: clsqa_PaperEN) => {
return obj.isPublic === value;
}
case clsqa_PaperEN.con_IsSubmit:
return (obj: clsqa_PaperEN) => {
return obj.isSubmit === value;
}
case clsqa_PaperEN.con_UpdUser:
return (obj: clsqa_PaperEN) => {
return obj.updUser === value;
}
case clsqa_PaperEN.con_UpdDate:
return (obj: clsqa_PaperEN) => {
return obj.updDate === value;
}
case clsqa_PaperEN.con_Memo:
return (obj: clsqa_PaperEN) => {
return obj.memo === value;
}
case clsqa_PaperEN.con_id_CurrEduCls:
return (obj: clsqa_PaperEN) => {
return obj.id_CurrEduCls === value;
}
case clsqa_PaperEN.con_AnswerCount:
return (obj: clsqa_PaperEN) => {
return obj.answerCount === value;
}
case clsqa_PaperEN.con_ShareId:
return (obj: clsqa_PaperEN) => {
return obj.shareId === value;
}
case clsqa_PaperEN.con_TagsCount:
return (obj: clsqa_PaperEN) => {
return obj.tagsCount === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[qa_Paper]中不存在！(in ${ qa_Paper_ConstructorName}.${ strThisFuncName})`;
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
export async function qa_Paper_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string, strid_CurrEduCls_C: string): Promise<Array<string>>
{
//const strThisFuncName = "funcKey";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In clsqa_PaperWApi.funcKey)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsqa_PaperWApi.funcKey)", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName == clsqa_PaperEN.con_qa_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrqa_Paper = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls_C);
if (arrqa_Paper == null) return [];
let arrqa_Paper_Sel = arrqa_Paper;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrqa_Paper_Sel.length == 0) return [];
return arrqa_Paper_Sel.map(x=>x.qa_PaperId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function qa_Paper_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetFirstObjAsync(strWhereCond: string): Promise<clsqa_PaperEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const objqa_Paper = qa_Paper_GetObjFromJsonObj(returnObj);
return objqa_Paper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsqa_PaperEN.WhereFormat) == false)
{
strWhereCond = Format(clsqa_PaperEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_PaperEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrqa_PaperExObjLst_Cache: Array<clsqa_PaperEN> = CacheHelper.Get(strKey);
const arrqa_PaperObjLst_T = qa_Paper_GetObjLstByJSONObjLst(arrqa_PaperExObjLst_Cache);
return arrqa_PaperObjLst_T;
}
try
{
const arrqa_PaperExObjLst = await qa_Paper_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrqa_PaperExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_PaperExObjLst.length);
console.log(strInfo);
return arrqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_Paper_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsqa_PaperEN.WhereFormat) == false)
{
strWhereCond = Format(clsqa_PaperEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_PaperEN.CacheAddiCondition);
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
const arrqa_PaperExObjLst_Cache: Array<clsqa_PaperEN> = JSON.parse(strTempObjLst);
const arrqa_PaperObjLst_T = qa_Paper_GetObjLstByJSONObjLst(arrqa_PaperExObjLst_Cache);
return arrqa_PaperObjLst_T;
}
try
{
const arrqa_PaperExObjLst = await qa_Paper_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrqa_PaperExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_PaperExObjLst.length);
console.log(strInfo);
return arrqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrqa_PaperObjLst_Cache: Array<clsqa_PaperEN> = JSON.parse(strTempObjLst);
return arrqa_PaperObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function qa_Paper_GetObjLstAsync(strWhereCond: string): Promise<Array<clsqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
if (IsNullOrEmpty(clsqa_PaperEN.WhereFormat) == false)
{
strWhereCond = Format(clsqa_PaperEN.WhereFormat, strid_CurrEduCls);
}
else
{
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
}
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (IsNullOrEmpty(clsqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsqa_PaperEN.CacheAddiCondition);
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
const arrqa_PaperExObjLst_Cache: Array<clsqa_PaperEN> = JSON.parse(strTempObjLst);
const arrqa_PaperObjLst_T = qa_Paper_GetObjLstByJSONObjLst(arrqa_PaperExObjLst_Cache);
return arrqa_PaperObjLst_T;
}
try
{
const arrqa_PaperExObjLst = await qa_Paper_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrqa_PaperExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_PaperExObjLst.length);
console.log(strInfo);
return arrqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrqa_PaperObjLst_Cache: Array<clsqa_PaperEN> = JSON.parse(strTempObjLst);
return arrqa_PaperObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_Paper_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsqa_PaperEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！(in clsqa_PaperWApi.qa_Paper_GetObjLst_Cache() )");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsqa_PaperWApi.qa_Paper_GetObjLst_Cache() )", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrqa_PaperObjLst_Cache;
switch (clsqa_PaperEN.CacheModeId)
{
case "04"://sessionStorage
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrqa_PaperObjLst = qa_Paper_GetObjLstByJSONObjLst(arrqa_PaperObjLst_Cache);
return arrqa_PaperObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function qa_Paper_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrqa_PaperObjLst_Cache;
switch (clsqa_PaperEN.CacheModeId)
{
case "04"://sessionStorage
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrqa_PaperObjLst_Cache = null;
break;
default:
arrqa_PaperObjLst_Cache = null;
break;
}
return arrqa_PaperObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrqa_PaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function qa_Paper_GetSubObjLst_Cache(objqa_Paper_Cond: clsqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
let arrqa_Paper_Sel: Array < clsqa_PaperEN > = arrqa_PaperObjLst_Cache;
if (objqa_Paper_Cond.sf_FldComparisonOp == null || objqa_Paper_Cond.sf_FldComparisonOp == "") return arrqa_Paper_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objqa_Paper_Cond), qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_PaperEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrqa_PaperId:关键字列表
 * @returns 对象列表
 **/
export async function qa_Paper_GetObjLstByqa_PaperIdLstAsync(arrqa_PaperId: Array<string>): Promise<Array<clsqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByqa_PaperIdLstAsync";
const strAction = "GetObjLstByqa_PaperIdLst";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrqa_PaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param arrstrqa_PaperIdLst:关键字列表
 * @returns 对象列表
*/
export async function qa_Paper_GetObjLstByqa_PaperIdLst_Cache(arrqa_PaperIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByqa_PaperIdLst_Cache";
try
{
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
const arrqa_Paper_Sel: Array <clsqa_PaperEN> = arrqa_PaperObjLst_Cache.filter(x => arrqa_PaperIdLst.indexOf(x.qa_PaperId)>-1);
return arrqa_Paper_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrqa_PaperIdLst.join(","), qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsqa_PaperEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsqa_PaperEN>();
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrqa_PaperObjLst_Cache.length == 0) return arrqa_PaperObjLst_Cache;
let arrqa_Paper_Sel = arrqa_PaperObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objqa_Paper_Cond = new clsqa_PaperEN();
ObjectAssign(objqa_Paper_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsqa_PaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_Paper_Sel.length == 0) return arrqa_Paper_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(qa_Paper_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrqa_Paper_Sel = arrqa_Paper_Sel.sort(objPagerPara.sortFun);
}
arrqa_Paper_Sel = arrqa_Paper_Sel.slice(intStart, intEnd);     
return arrqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsqa_PaperEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function qa_Paper_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsqa_PaperEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = qa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param strqa_PaperId:关键字
 * @returns 获取删除的结果
 **/
export async function qa_Paper_DelRecordAsync(strqa_PaperId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strqa_PaperId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param arrqa_PaperId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function qa_Paper_Delqa_PapersAsync(arrqa_PaperId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delqa_PapersAsync";
const strAction = "Delqa_Papers";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrqa_PaperId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_Delqa_PapersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delqa_PapersByCondAsync";
const strAction = "Delqa_PapersByCond";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function qa_Paper_AddNewRecordAsync(objqa_PaperEN: clsqa_PaperEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objqa_PaperEN);
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function qa_Paper_AddNewRecordWithMaxIdAsync(objqa_PaperEN: clsqa_PaperEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function qa_Paper_AddNewRecordWithReturnKeyAsync(objqa_PaperEN: clsqa_PaperEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function qa_Paper_AddNewRecordWithReturnKey(objqa_PaperEN: clsqa_PaperEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objqa_PaperEN.qa_PaperId === null || objqa_PaperEN.qa_PaperId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function qa_Paper_UpdateRecordAsync(objqa_PaperEN: clsqa_PaperEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objqa_PaperEN.sfUpdFldSetStr === undefined || objqa_PaperEN.sfUpdFldSetStr === null || objqa_PaperEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_PaperEN.qa_PaperId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_PaperEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function qa_Paper_UpdateWithConditionAsync(objqa_PaperEN: clsqa_PaperEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objqa_PaperEN.sfUpdFldSetStr === undefined || objqa_PaperEN.sfUpdFldSetStr === null || objqa_PaperEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_PaperEN.qa_PaperId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
objqa_PaperEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objqa_PaperEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objstrqa_PaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function qa_Paper_IsExistRecord_Cache(objqa_Paper_Cond: clsqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrqa_PaperObjLst_Cache == null) return false;
let arrqa_Paper_Sel: Array < clsqa_PaperEN > = arrqa_PaperObjLst_Cache;
if (objqa_Paper_Cond.sf_FldComparisonOp == null || objqa_Paper_Cond.sf_FldComparisonOp == "") return arrqa_Paper_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrqa_Paper_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objqa_Paper_Cond), qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param strqa_PaperId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function qa_Paper_IsExist(strqa_PaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"qa_PaperId": strqa_PaperId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param strqa_PaperId:所给的关键字
 * @returns 对象
*/
export async function qa_Paper_IsExist_Cache(strqa_PaperId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrqa_PaperObjLst_Cache == null) return false;
try
{
const arrqa_Paper_Sel: Array <clsqa_PaperEN> = arrqa_PaperObjLst_Cache.filter(x => x.qa_PaperId == strqa_PaperId);
if (arrqa_Paper_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strqa_PaperId, qa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strqa_PaperId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function qa_Paper_IsExistAsync(strqa_PaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strqa_PaperId": strqa_PaperId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
 * @param objqa_Paper_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function qa_Paper_GetRecCountByCond_Cache(objqa_Paper_Cond: clsqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrqa_PaperObjLst_Cache = await qa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrqa_PaperObjLst_Cache == null) return 0;
let arrqa_Paper_Sel: Array < clsqa_PaperEN > = arrqa_PaperObjLst_Cache;
if (objqa_Paper_Cond.sf_FldComparisonOp == null || objqa_Paper_Cond.sf_FldComparisonOp == "") return arrqa_Paper_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrqa_Paper_Sel = arrqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrqa_Paper_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objqa_Paper_Cond), qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export async function qa_Paper_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(qa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qa_Paper_ConstructorName, strThisFuncName);
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
export function qa_Paper_GetWebApiUrl(strController: string, strAction: string): string {
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
export function qa_Paper_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsqa_PaperWApi.clsqa_PaperWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsqa_PaperWApi.clsqa_PaperWApi.ReFreshCache)", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
switch (clsqa_PaperEN.CacheModeId)
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
vqa_Paper_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function qa_Paper_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsqa_PaperEN._CurrTabName, strid_CurrEduCls);
switch (clsqa_PaperEN.CacheModeId)
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
export function qa_Paper_CheckPropertyNew(pobjqa_PaperEN: clsqa_PaperEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_PaperEN.qa_PaperId) == false && GetStrLen(pobjqa_PaperEN.qa_PaperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.qa_PaperId)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.paperId) == false && GetStrLen(pobjqa_PaperEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.paperId)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updUser) == false && GetStrLen(pobjqa_PaperEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.updUser)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updDate) == false && GetStrLen(pobjqa_PaperEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.updDate)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.memo) == false && GetStrLen(pobjqa_PaperEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.memo)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.id_CurrEduCls) == false && GetStrLen(pobjqa_PaperEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.id_CurrEduCls)(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.shareId) == false && GetStrLen(pobjqa_PaperEN.shareId) > 2)
{
 throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.shareId)(clsqa_PaperBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjqa_PaperEN.qa_PaperId) == false && undefined !== pobjqa_PaperEN.qa_PaperId && tzDataType.isString(pobjqa_PaperEN.qa_PaperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjqa_PaperEN.qa_PaperId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.paperId) == false && undefined !== pobjqa_PaperEN.paperId && tzDataType.isString(pobjqa_PaperEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjqa_PaperEN.paperId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.questionsCount && undefined !== pobjqa_PaperEN.questionsCount && tzDataType.isNumber(pobjqa_PaperEN.questionsCount) === false)
{
 throw new Error("(errid:Watl000060)字段[提问计数(questionsCount)]的值:[$(pobjqa_PaperEN.questionsCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.isDelete && undefined !== pobjqa_PaperEN.isDelete && tzDataType.isBoolean(pobjqa_PaperEN.isDelete) === false)
{
 throw new Error("(errid:Watl000060)字段[是否删除(isDelete)]的值:[$(pobjqa_PaperEN.isDelete)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.isPublic && undefined !== pobjqa_PaperEN.isPublic && tzDataType.isBoolean(pobjqa_PaperEN.isPublic) === false)
{
 throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjqa_PaperEN.isPublic)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.isSubmit && undefined !== pobjqa_PaperEN.isSubmit && tzDataType.isBoolean(pobjqa_PaperEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjqa_PaperEN.isSubmit)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updUser) == false && undefined !== pobjqa_PaperEN.updUser && tzDataType.isString(pobjqa_PaperEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjqa_PaperEN.updUser)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updDate) == false && undefined !== pobjqa_PaperEN.updDate && tzDataType.isString(pobjqa_PaperEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjqa_PaperEN.updDate)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.memo) == false && undefined !== pobjqa_PaperEN.memo && tzDataType.isString(pobjqa_PaperEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_PaperEN.memo)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.id_CurrEduCls) == false && undefined !== pobjqa_PaperEN.id_CurrEduCls && tzDataType.isString(pobjqa_PaperEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_PaperEN.id_CurrEduCls)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.answerCount && undefined !== pobjqa_PaperEN.answerCount && tzDataType.isNumber(pobjqa_PaperEN.answerCount) === false)
{
 throw new Error("(errid:Watl000060)字段[回答计数(answerCount)]的值:[$(pobjqa_PaperEN.answerCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.shareId) == false && undefined !== pobjqa_PaperEN.shareId && tzDataType.isString(pobjqa_PaperEN.shareId) === false)
{
 throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjqa_PaperEN.shareId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
if (null != pobjqa_PaperEN.tagsCount && undefined !== pobjqa_PaperEN.tagsCount && tzDataType.isNumber(pobjqa_PaperEN.tagsCount) === false)
{
 throw new Error("(errid:Watl000060)字段[论文标注数(tagsCount)]的值:[$(pobjqa_PaperEN.tagsCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjqa_PaperEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function qa_Paper_CheckProperty4Update (pobjqa_PaperEN: clsqa_PaperEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjqa_PaperEN.qa_PaperId) == false && GetStrLen(pobjqa_PaperEN.qa_PaperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文答疑Id(qa_PaperId)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.qa_PaperId)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.paperId) == false && GetStrLen(pobjqa_PaperEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.paperId)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updUser) == false && GetStrLen(pobjqa_PaperEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.updUser)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updDate) == false && GetStrLen(pobjqa_PaperEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.updDate)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.memo) == false && GetStrLen(pobjqa_PaperEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.memo)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.id_CurrEduCls) == false && GetStrLen(pobjqa_PaperEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.id_CurrEduCls)(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.shareId) == false && GetStrLen(pobjqa_PaperEN.shareId) > 2)
{
 throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 论文答疑表(qa_Paper))!值:$(pobjqa_PaperEN.shareId)(clsqa_PaperBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjqa_PaperEN.qa_PaperId) == false && undefined !== pobjqa_PaperEN.qa_PaperId && tzDataType.isString(pobjqa_PaperEN.qa_PaperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文答疑Id(qa_PaperId)]的值:[$(pobjqa_PaperEN.qa_PaperId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.paperId) == false && undefined !== pobjqa_PaperEN.paperId && tzDataType.isString(pobjqa_PaperEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjqa_PaperEN.paperId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.questionsCount && undefined !== pobjqa_PaperEN.questionsCount && tzDataType.isNumber(pobjqa_PaperEN.questionsCount) === false)
{
 throw new Error("(errid:Watl000063)字段[提问计数(questionsCount)]的值:[$(pobjqa_PaperEN.questionsCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.isDelete && undefined !== pobjqa_PaperEN.isDelete && tzDataType.isBoolean(pobjqa_PaperEN.isDelete) === false)
{
 throw new Error("(errid:Watl000063)字段[是否删除(isDelete)]的值:[$(pobjqa_PaperEN.isDelete)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.isPublic && undefined !== pobjqa_PaperEN.isPublic && tzDataType.isBoolean(pobjqa_PaperEN.isPublic) === false)
{
 throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjqa_PaperEN.isPublic)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.isSubmit && undefined !== pobjqa_PaperEN.isSubmit && tzDataType.isBoolean(pobjqa_PaperEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjqa_PaperEN.isSubmit)], 非法，应该为布尔型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updUser) == false && undefined !== pobjqa_PaperEN.updUser && tzDataType.isString(pobjqa_PaperEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjqa_PaperEN.updUser)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.updDate) == false && undefined !== pobjqa_PaperEN.updDate && tzDataType.isString(pobjqa_PaperEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjqa_PaperEN.updDate)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.memo) == false && undefined !== pobjqa_PaperEN.memo && tzDataType.isString(pobjqa_PaperEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_PaperEN.memo)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.id_CurrEduCls) == false && undefined !== pobjqa_PaperEN.id_CurrEduCls && tzDataType.isString(pobjqa_PaperEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_PaperEN.id_CurrEduCls)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.answerCount && undefined !== pobjqa_PaperEN.answerCount && tzDataType.isNumber(pobjqa_PaperEN.answerCount) === false)
{
 throw new Error("(errid:Watl000063)字段[回答计数(answerCount)]的值:[$(pobjqa_PaperEN.answerCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjqa_PaperEN.shareId) == false && undefined !== pobjqa_PaperEN.shareId && tzDataType.isString(pobjqa_PaperEN.shareId) === false)
{
 throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjqa_PaperEN.shareId)], 非法，应该为字符型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
if (null != pobjqa_PaperEN.tagsCount && undefined !== pobjqa_PaperEN.tagsCount && tzDataType.isNumber(pobjqa_PaperEN.tagsCount) === false)
{
 throw new Error("(errid:Watl000063)字段[论文标注数(tagsCount)]的值:[$(pobjqa_PaperEN.tagsCount)], 非法，应该为数值型(In 论文答疑表(qa_Paper))!(clsqa_PaperBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjqa_PaperEN.qa_PaperId) === true )
{
 throw new Error("(errid:Watl000064)字段[论文答疑Id]不能为空(In 论文答疑表)!(clsqa_PaperBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjqa_PaperEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_Paper_GetJSONStrByObj (pobjqa_PaperEN: clsqa_PaperEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjqa_PaperEN.sfUpdFldSetStr = pobjqa_PaperEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjqa_PaperEN);
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
export function qa_Paper_GetObjLstByJSONStr (strJSON: string): Array<clsqa_PaperEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrqa_PaperObjLst = new Array<clsqa_PaperEN>();
if (strJSON === "")
{
return arrqa_PaperObjLst;
}
try
{
arrqa_PaperObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrqa_PaperObjLst;
}
return arrqa_PaperObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrqa_PaperObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function qa_Paper_GetObjLstByJSONObjLst (arrqa_PaperObjLstS: Array<clsqa_PaperEN>): Array<clsqa_PaperEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrqa_PaperObjLst = new Array<clsqa_PaperEN>();
for (const objInFor of arrqa_PaperObjLstS) {
const obj1 = qa_Paper_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrqa_PaperObjLst.push(obj1);
}
return arrqa_PaperObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function qa_Paper_GetObjByJSONStr (strJSON: string): clsqa_PaperEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjqa_PaperEN = new clsqa_PaperEN();
if (strJSON === "")
{
return pobjqa_PaperEN;
}
try
{
pobjqa_PaperEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjqa_PaperEN;
}
return pobjqa_PaperEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function qa_Paper_GetCombineCondition(objqa_Paper_Cond: clsqa_PaperEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_qa_PaperId) == true)
{
const strComparisonOp_qa_PaperId:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_qa_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_qa_PaperId, objqa_Paper_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_PaperId, objqa_Paper_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_QuestionsCount) == true)
{
const strComparisonOp_QuestionsCount:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_QuestionsCount];
strWhereCond += Format(" And {0} {2} {1}", clsqa_PaperEN.con_QuestionsCount, objqa_Paper_Cond.questionsCount, strComparisonOp_QuestionsCount);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_IsDelete) == true)
{
if (objqa_Paper_Cond.isDelete == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PaperEN.con_IsDelete);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PaperEN.con_IsDelete);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_IsPublic) == true)
{
if (objqa_Paper_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PaperEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PaperEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_IsSubmit) == true)
{
if (objqa_Paper_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsqa_PaperEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsqa_PaperEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_UpdUser, objqa_Paper_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_UpdDate, objqa_Paper_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_Memo, objqa_Paper_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_id_CurrEduCls, objqa_Paper_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_AnswerCount) == true)
{
const strComparisonOp_AnswerCount:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_AnswerCount];
strWhereCond += Format(" And {0} {2} {1}", clsqa_PaperEN.con_AnswerCount, objqa_Paper_Cond.answerCount, strComparisonOp_AnswerCount);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsqa_PaperEN.con_ShareId, objqa_Paper_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objqa_Paper_Cond.dicFldComparisonOp, clsqa_PaperEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objqa_Paper_Cond.dicFldComparisonOp[clsqa_PaperEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsqa_PaperEN.con_TagsCount, objqa_Paper_Cond.tagsCount, strComparisonOp_TagsCount);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_Paper(论文答疑表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strqa_PaperId: 论文答疑Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_Paper_GetUniCondStr_qa_PaperId(objqa_PaperEN: clsqa_PaperEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and qa_PaperId = '{0}'", objqa_PaperEN.qa_PaperId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--qa_Paper(论文答疑表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strqa_PaperId: 论文答疑Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function qa_Paper_GetUniCondStr4Update_qa_PaperId(objqa_PaperEN: clsqa_PaperEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and qa_PaperId <> '{0}'", objqa_PaperEN.qa_PaperId);
 strWhereCond +=  Format(" and qa_PaperId = '{0}'", objqa_PaperEN.qa_PaperId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objqa_PaperENS:源对象
 * @param objqa_PaperENT:目标对象
*/
export function qa_Paper_CopyObjTo(objqa_PaperENS: clsqa_PaperEN , objqa_PaperENT: clsqa_PaperEN ): void 
{
objqa_PaperENT.qa_PaperId = objqa_PaperENS.qa_PaperId; //论文答疑Id
objqa_PaperENT.paperId = objqa_PaperENS.paperId; //论文Id
objqa_PaperENT.questionsCount = objqa_PaperENS.questionsCount; //提问计数
objqa_PaperENT.isDelete = objqa_PaperENS.isDelete; //是否删除
objqa_PaperENT.isPublic = objqa_PaperENS.isPublic; //是否公开
objqa_PaperENT.isSubmit = objqa_PaperENS.isSubmit; //是否提交
objqa_PaperENT.updUser = objqa_PaperENS.updUser; //修改人
objqa_PaperENT.updDate = objqa_PaperENS.updDate; //修改日期
objqa_PaperENT.memo = objqa_PaperENS.memo; //备注
objqa_PaperENT.id_CurrEduCls = objqa_PaperENS.id_CurrEduCls; //教学班流水号
objqa_PaperENT.answerCount = objqa_PaperENS.answerCount; //回答计数
objqa_PaperENT.shareId = objqa_PaperENS.shareId; //分享Id
objqa_PaperENT.tagsCount = objqa_PaperENS.tagsCount; //论文标注数
objqa_PaperENT.sfUpdFldSetStr = objqa_PaperENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objqa_PaperENS:源对象
 * @param objqa_PaperENT:目标对象
*/
export function qa_Paper_GetObjFromJsonObj(objqa_PaperENS: clsqa_PaperEN): clsqa_PaperEN 
{
 const objqa_PaperENT: clsqa_PaperEN = new clsqa_PaperEN();
ObjectAssign(objqa_PaperENT, objqa_PaperENS);
 return objqa_PaperENT;
}