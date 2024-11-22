
 /**
 * 类名:clsvqa_PaperWApi
 * 表名:vqa_Paper(01120637)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:32
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
 * v论文答疑(vqa_Paper)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvqa_PaperEN } from "../../L0_Entity/InteractManage/clsvqa_PaperEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vqa_Paper_Controller = "vqa_PaperApi";
 export const vqa_Paper_ConstructorName = "vqa_Paper";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strqa_PaperId:关键字
 * @returns 对象
 **/
export async function vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId: string): Promise<clsvqa_PaperEN>  
{
const strThisFuncName = "GetObjByqa_PaperIdAsync";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In GetObjByqa_PaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByqa_PaperId";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvqa_Paper = vqa_Paper_GetObjFromJsonObj(returnObj);
return objvqa_Paper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByqa_PaperId_Cache";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In GetObjByqa_PaperId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrvqa_Paper_Sel: Array <clsvqa_PaperEN> = arrvqa_PaperObjLst_Cache.filter(x => x.qa_PaperId == strqa_PaperId);
let objvqa_Paper: clsvqa_PaperEN;
if (arrvqa_Paper_Sel.length > 0)
{
objvqa_Paper = arrvqa_Paper_Sel[0];
return objvqa_Paper;
}
else
{
if (bolTryAsyncOnce == true)
{
objvqa_Paper = await vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
if (objvqa_Paper != null)
{
vqa_Paper_ReFreshThisCache(strid_CurrEduCls);
return objvqa_Paper;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjByqa_PaperId_localStorage(strqa_PaperId: string) {
const strThisFuncName = "GetObjByqa_PaperId_localStorage";

if (IsNullOrEmpty(strqa_PaperId) == true)
{
  const strMsg = Format("参数:[strqa_PaperId]不能为空！(In GetObjByqa_PaperId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strqa_PaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strqa_PaperId]的长度:[{0}]不正确！", strqa_PaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strqa_PaperId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvqa_Paper_Cache: clsvqa_PaperEN = JSON.parse(strTempObj);
return objvqa_Paper_Cache;
}
try
{
const objvqa_Paper = await vqa_Paper_GetObjByqa_PaperIdAsync(strqa_PaperId);
if (objvqa_Paper != null)
{
localStorage.setItem(strKey, JSON.stringify(objvqa_Paper));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvqa_Paper;
}
return objvqa_Paper;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strqa_PaperId, vqa_Paper_ConstructorName, strThisFuncName);
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
 @param strid_CurrEduCls:缓存的分类字段
 * @returns 返回一个输出字段值
*/
export async function vqa_Paper_func(strInFldName:string , strOutFldName:string , strInValue:string , strid_CurrEduCls_C: string)
{
//const strThisFuncName = "func";

if (IsNullOrEmpty(strid_CurrEduCls_C) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls_C]不能为空！(In func)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls_C.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
console.error(strMsg);
throw (strMsg);
}

if (strInFldName != clsvqa_PaperEN.con_qa_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvqa_PaperEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvqa_PaperEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strqa_PaperId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvqa_Paper = await vqa_Paper_GetObjByqa_PaperId_Cache(strqa_PaperId , strid_CurrEduCls_C);
if (objvqa_Paper == null) return "";
return objvqa_Paper.GetFldValue(strOutFldName).toString();
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
export function vqa_Paper_SortFun_Defa(a:clsvqa_PaperEN , b:clsvqa_PaperEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.qa_PaperId.localeCompare(b.qa_PaperId);
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
export function vqa_Paper_SortFun_Defa_2Fld(a:clsvqa_PaperEN , b:clsvqa_PaperEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.questionsCount - b.questionsCount;
else return a.paperId.localeCompare(b.paperId);
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
export function vqa_Paper_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvqa_PaperEN.con_qa_PaperId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.qa_PaperId.localeCompare(b.qa_PaperId);
}
case clsvqa_PaperEN.con_PaperId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvqa_PaperEN.con_QuestionsCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.questionsCount-b.questionsCount;
}
case clsvqa_PaperEN.con_IsDelete:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (a.isDelete == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_IsPublic:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_IsSubmit:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_UpdUser:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvqa_PaperEN.con_UserName:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvqa_PaperEN.con_UpdDate:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvqa_PaperEN.con_Memo:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvqa_PaperEN.con_PaperTitle:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvqa_PaperEN.con_AttachmentCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvqa_PaperEN.con_PaperContent:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvqa_PaperEN.con_Periodical:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvqa_PaperEN.con_Author:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.author.localeCompare(b.author);
}
case clsvqa_PaperEN.con_ResearchQuestion:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvqa_PaperEN.con_LiteratureSources:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsvqa_PaperEN.con_UploadfileUrl:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvqa_PaperEN.con_id_XzMajor:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvqa_PaperEN.con_MajorName:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvqa_PaperEN.con_id_CurrEduCls:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvqa_PaperEN.con_AnswerCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.answerCount-b.answerCount;
}
case clsvqa_PaperEN.con_ShareId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvqa_PaperEN.con_TagsCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return a.tagsCount-b.tagsCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${ vqa_Paper_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvqa_PaperEN.con_qa_PaperId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.qa_PaperId.localeCompare(a.qa_PaperId);
}
case clsvqa_PaperEN.con_PaperId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvqa_PaperEN.con_QuestionsCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.questionsCount-a.questionsCount;
}
case clsvqa_PaperEN.con_IsDelete:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (b.isDelete == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_IsPublic:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_IsSubmit:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvqa_PaperEN.con_UpdUser:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvqa_PaperEN.con_UserName:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvqa_PaperEN.con_UpdDate:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvqa_PaperEN.con_Memo:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvqa_PaperEN.con_PaperTitle:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvqa_PaperEN.con_AttachmentCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvqa_PaperEN.con_PaperContent:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvqa_PaperEN.con_Periodical:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvqa_PaperEN.con_Author:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.author.localeCompare(a.author);
}
case clsvqa_PaperEN.con_ResearchQuestion:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvqa_PaperEN.con_LiteratureSources:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsvqa_PaperEN.con_UploadfileUrl:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvqa_PaperEN.con_id_XzMajor:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvqa_PaperEN.con_MajorName:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvqa_PaperEN.con_id_CurrEduCls:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvqa_PaperEN.con_AnswerCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.answerCount-a.answerCount;
}
case clsvqa_PaperEN.con_ShareId:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvqa_PaperEN.con_TagsCount:
return (a: clsvqa_PaperEN, b: clsvqa_PaperEN) => {
return b.tagsCount-a.tagsCount;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${ vqa_Paper_ConstructorName}.${ strThisFuncName})`;
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
export async function vqa_Paper_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvqa_PaperEN.con_qa_PaperId:
return (obj: clsvqa_PaperEN) => {
return obj.qa_PaperId === value;
}
case clsvqa_PaperEN.con_PaperId:
return (obj: clsvqa_PaperEN) => {
return obj.paperId === value;
}
case clsvqa_PaperEN.con_QuestionsCount:
return (obj: clsvqa_PaperEN) => {
return obj.questionsCount === value;
}
case clsvqa_PaperEN.con_IsDelete:
return (obj: clsvqa_PaperEN) => {
return obj.isDelete === value;
}
case clsvqa_PaperEN.con_IsPublic:
return (obj: clsvqa_PaperEN) => {
return obj.isPublic === value;
}
case clsvqa_PaperEN.con_IsSubmit:
return (obj: clsvqa_PaperEN) => {
return obj.isSubmit === value;
}
case clsvqa_PaperEN.con_UpdUser:
return (obj: clsvqa_PaperEN) => {
return obj.updUser === value;
}
case clsvqa_PaperEN.con_UserName:
return (obj: clsvqa_PaperEN) => {
return obj.userName === value;
}
case clsvqa_PaperEN.con_UpdDate:
return (obj: clsvqa_PaperEN) => {
return obj.updDate === value;
}
case clsvqa_PaperEN.con_Memo:
return (obj: clsvqa_PaperEN) => {
return obj.memo === value;
}
case clsvqa_PaperEN.con_PaperTitle:
return (obj: clsvqa_PaperEN) => {
return obj.paperTitle === value;
}
case clsvqa_PaperEN.con_AttachmentCount:
return (obj: clsvqa_PaperEN) => {
return obj.attachmentCount === value;
}
case clsvqa_PaperEN.con_PaperContent:
return (obj: clsvqa_PaperEN) => {
return obj.paperContent === value;
}
case clsvqa_PaperEN.con_Periodical:
return (obj: clsvqa_PaperEN) => {
return obj.periodical === value;
}
case clsvqa_PaperEN.con_Author:
return (obj: clsvqa_PaperEN) => {
return obj.author === value;
}
case clsvqa_PaperEN.con_ResearchQuestion:
return (obj: clsvqa_PaperEN) => {
return obj.researchQuestion === value;
}
case clsvqa_PaperEN.con_LiteratureSources:
return (obj: clsvqa_PaperEN) => {
return obj.literatureSources === value;
}
case clsvqa_PaperEN.con_UploadfileUrl:
return (obj: clsvqa_PaperEN) => {
return obj.uploadfileUrl === value;
}
case clsvqa_PaperEN.con_id_XzMajor:
return (obj: clsvqa_PaperEN) => {
return obj.id_XzMajor === value;
}
case clsvqa_PaperEN.con_MajorName:
return (obj: clsvqa_PaperEN) => {
return obj.majorName === value;
}
case clsvqa_PaperEN.con_id_CurrEduCls:
return (obj: clsvqa_PaperEN) => {
return obj.id_CurrEduCls === value;
}
case clsvqa_PaperEN.con_AnswerCount:
return (obj: clsvqa_PaperEN) => {
return obj.answerCount === value;
}
case clsvqa_PaperEN.con_ShareId:
return (obj: clsvqa_PaperEN) => {
return obj.shareId === value;
}
case clsvqa_PaperEN.con_TagsCount:
return (obj: clsvqa_PaperEN) => {
return obj.tagsCount === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vqa_Paper]中不存在！(in ${ vqa_Paper_ConstructorName}.${ strThisFuncName})`;
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
export async function vqa_Paper_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetFirstObjAsync(strWhereCond: string): Promise<clsvqa_PaperEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvqa_Paper = vqa_Paper_GetObjFromJsonObj(returnObj);
return objvqa_Paper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
clsvqa_PaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvqa_PaperEN._CurrTabName);
if (IsNullOrEmpty(clsvqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_PaperEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvqa_PaperExObjLst_Cache: Array<clsvqa_PaperEN> = CacheHelper.Get(strKey);
const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
return arrvqa_PaperObjLst_T;
}
try
{
const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvqa_PaperExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
console.log(strInfo);
return arrvqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Paper_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
clsvqa_PaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvqa_PaperEN._CurrTabName);
if (IsNullOrEmpty(clsvqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_PaperEN.CacheAddiCondition);
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
const arrvqa_PaperExObjLst_Cache: Array<clsvqa_PaperEN> = JSON.parse(strTempObjLst);
const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
return arrvqa_PaperObjLst_T;
}
try
{
const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvqa_PaperExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
console.log(strInfo);
return arrvqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvqa_PaperObjLst_Cache: Array<clsvqa_PaperEN> = JSON.parse(strTempObjLst);
return arrvqa_PaperObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vqa_Paper_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
clsvqa_PaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvqa_PaperEN._CurrTabName);
if (IsNullOrEmpty(clsvqa_PaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvqa_PaperEN.CacheAddiCondition);
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
const arrvqa_PaperExObjLst_Cache: Array<clsvqa_PaperEN> = JSON.parse(strTempObjLst);
const arrvqa_PaperObjLst_T = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperExObjLst_Cache);
return arrvqa_PaperObjLst_T;
}
try
{
const arrvqa_PaperExObjLst = await vqa_Paper_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvqa_PaperExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_PaperExObjLst.length);
console.log(strInfo);
return arrvqa_PaperExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvqa_PaperObjLst_Cache: Array<clsvqa_PaperEN> = JSON.parse(strTempObjLst);
return arrvqa_PaperObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Paper_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsvqa_PaperEN>>
{
//const strThisFuncName = "GetObjLst_Cache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
const strMsg = Format("缓存分类变量:[id_CurrEduCls]不能为空！");
console.error(strMsg);
throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}
let arrvqa_PaperObjLst_Cache;
switch (clsvqa_PaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrvqa_PaperObjLst = vqa_Paper_GetObjLstByJSONObjLst(arrvqa_PaperObjLst_Cache);
return arrvqa_PaperObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vqa_Paper_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvqa_PaperObjLst_Cache;
switch (clsvqa_PaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrvqa_PaperObjLst_Cache = null;
break;
default:
arrvqa_PaperObjLst_Cache = null;
break;
}
return arrvqa_PaperObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrqa_PaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vqa_Paper_GetSubObjLst_Cache(objvqa_Paper_Cond: clsvqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
let arrvqa_Paper_Sel: Array < clsvqa_PaperEN > = arrvqa_PaperObjLst_Cache;
if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "") return arrvqa_Paper_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvqa_Paper_Cond), vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvqa_PaperEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrqa_PaperId:关键字列表
 * @returns 对象列表
 **/
export async function vqa_Paper_GetObjLstByqa_PaperIdLstAsync(arrqa_PaperId: Array<string>): Promise<Array<clsvqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByqa_PaperIdLstAsync";
const strAction = "GetObjLstByqa_PaperIdLst";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrqa_PaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLstByqa_PaperIdLst_Cache(arrqa_PaperIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByqa_PaperIdLst_Cache";
try
{
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
const arrvqa_Paper_Sel: Array <clsvqa_PaperEN> = arrvqa_PaperObjLst_Cache.filter(x => arrqa_PaperIdLst.indexOf(x.qa_PaperId)>-1);
return arrvqa_Paper_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrqa_PaperIdLst.join(","), vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvqa_PaperEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vqa_Paper_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvqa_PaperEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrvqa_PaperObjLst_Cache.length == 0) return arrvqa_PaperObjLst_Cache;
let arrvqa_Paper_Sel = arrvqa_PaperObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvqa_Paper_Cond = new clsvqa_PaperEN();
ObjectAssign(objvqa_Paper_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvqa_PaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvqa_Paper_Sel.length == 0) return arrvqa_Paper_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvqa_Paper_Sel = arrvqa_Paper_Sel.sort(vqa_Paper_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvqa_Paper_Sel = arrvqa_Paper_Sel.sort(objPagerPara.sortFun);
}
arrvqa_Paper_Sel = arrvqa_Paper_Sel.slice(intStart, intEnd);     
return arrvqa_Paper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvqa_PaperEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vqa_Paper_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvqa_PaperEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vqa_Paper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vqa_Paper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_IsExistRecord_Cache(objvqa_Paper_Cond: clsvqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrvqa_PaperObjLst_Cache == null) return false;
let arrvqa_Paper_Sel: Array < clsvqa_PaperEN > = arrvqa_PaperObjLst_Cache;
if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "") return arrvqa_Paper_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvqa_Paper_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvqa_Paper_Cond), vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_IsExist(strqa_PaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_IsExist_Cache(strqa_PaperId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrvqa_PaperObjLst_Cache == null) return false;
try
{
const arrvqa_Paper_Sel: Array <clsvqa_PaperEN> = arrvqa_PaperObjLst_Cache.filter(x => x.qa_PaperId == strqa_PaperId);
if (arrvqa_Paper_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strqa_PaperId, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_IsExistAsync(strqa_PaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
export async function vqa_Paper_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vqa_Paper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vqa_Paper_ConstructorName, strThisFuncName);
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
 * @param objvqa_Paper_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vqa_Paper_GetRecCountByCond_Cache(objvqa_Paper_Cond: clsvqa_PaperEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvqa_PaperObjLst_Cache = await vqa_Paper_GetObjLst_Cache(strid_CurrEduCls);
if (arrvqa_PaperObjLst_Cache == null) return 0;
let arrvqa_Paper_Sel: Array < clsvqa_PaperEN > = arrvqa_PaperObjLst_Cache;
if (objvqa_Paper_Cond.sf_FldComparisonOp == null || objvqa_Paper_Cond.sf_FldComparisonOp == "") return arrvqa_Paper_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvqa_Paper_Cond.sf_FldComparisonOp);
//console.log("clsvqa_PaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvqa_Paper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvqa_Paper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvqa_Paper_Sel = arrvqa_Paper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvqa_Paper_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvqa_Paper_Cond), vqa_Paper_ConstructorName, strThisFuncName);
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
export function vqa_Paper_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vqa_Paper_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strid_CurrEduCls);
switch (clsvqa_PaperEN.CacheModeId)
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
export function vqa_Paper_GetJSONStrByObj (pobjvqa_PaperEN: clsvqa_PaperEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvqa_PaperEN);
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
export function vqa_Paper_GetObjLstByJSONStr (strJSON: string): Array<clsvqa_PaperEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvqa_PaperObjLst = new Array<clsvqa_PaperEN>();
if (strJSON === "")
{
return arrvqa_PaperObjLst;
}
try
{
arrvqa_PaperObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvqa_PaperObjLst;
}
return arrvqa_PaperObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvqa_PaperObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vqa_Paper_GetObjLstByJSONObjLst (arrvqa_PaperObjLstS: Array<clsvqa_PaperEN>): Array<clsvqa_PaperEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvqa_PaperObjLst = new Array<clsvqa_PaperEN>();
for (const objInFor of arrvqa_PaperObjLstS) {
const obj1 = vqa_Paper_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvqa_PaperObjLst.push(obj1);
}
return arrvqa_PaperObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vqa_Paper_GetObjByJSONStr (strJSON: string): clsvqa_PaperEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvqa_PaperEN = new clsvqa_PaperEN();
if (strJSON === "")
{
return pobjvqa_PaperEN;
}
try
{
pobjvqa_PaperEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvqa_PaperEN;
}
return pobjvqa_PaperEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vqa_Paper_GetCombineCondition(objvqa_Paper_Cond: clsvqa_PaperEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_qa_PaperId) == true)
{
const strComparisonOp_qa_PaperId:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_qa_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_qa_PaperId, objvqa_Paper_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_PaperId, objvqa_Paper_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_QuestionsCount) == true)
{
const strComparisonOp_QuestionsCount:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_QuestionsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_PaperEN.con_QuestionsCount, objvqa_Paper_Cond.questionsCount, strComparisonOp_QuestionsCount);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_IsDelete) == true)
{
if (objvqa_Paper_Cond.isDelete == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_PaperEN.con_IsDelete);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_PaperEN.con_IsDelete);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_IsPublic) == true)
{
if (objvqa_Paper_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_PaperEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_PaperEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_IsSubmit) == true)
{
if (objvqa_Paper_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvqa_PaperEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvqa_PaperEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_UpdUser, objvqa_Paper_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_UserName, objvqa_Paper_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_UpdDate, objvqa_Paper_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_Memo, objvqa_Paper_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_PaperTitle, objvqa_Paper_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_PaperEN.con_AttachmentCount, objvqa_Paper_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_Periodical, objvqa_Paper_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_Author, objvqa_Paper_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_ResearchQuestion, objvqa_Paper_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_LiteratureSources, objvqa_Paper_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_UploadfileUrl, objvqa_Paper_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_id_XzMajor, objvqa_Paper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_MajorName, objvqa_Paper_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_id_CurrEduCls, objvqa_Paper_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_AnswerCount) == true)
{
const strComparisonOp_AnswerCount:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_AnswerCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_PaperEN.con_AnswerCount, objvqa_Paper_Cond.answerCount, strComparisonOp_AnswerCount);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvqa_PaperEN.con_ShareId, objvqa_Paper_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvqa_Paper_Cond.dicFldComparisonOp, clsvqa_PaperEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objvqa_Paper_Cond.dicFldComparisonOp[clsvqa_PaperEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvqa_PaperEN.con_TagsCount, objvqa_Paper_Cond.tagsCount, strComparisonOp_TagsCount);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvqa_PaperENS:源对象
 * @param objvqa_PaperENT:目标对象
*/
export function vqa_Paper_CopyObjTo(objvqa_PaperENS: clsvqa_PaperEN , objvqa_PaperENT: clsvqa_PaperEN ): void 
{
objvqa_PaperENT.qa_PaperId = objvqa_PaperENS.qa_PaperId; //论文答疑Id
objvqa_PaperENT.paperId = objvqa_PaperENS.paperId; //论文Id
objvqa_PaperENT.questionsCount = objvqa_PaperENS.questionsCount; //提问计数
objvqa_PaperENT.isDelete = objvqa_PaperENS.isDelete; //是否删除
objvqa_PaperENT.isPublic = objvqa_PaperENS.isPublic; //是否公开
objvqa_PaperENT.isSubmit = objvqa_PaperENS.isSubmit; //是否提交
objvqa_PaperENT.updUser = objvqa_PaperENS.updUser; //修改人
objvqa_PaperENT.userName = objvqa_PaperENS.userName; //用户名
objvqa_PaperENT.updDate = objvqa_PaperENS.updDate; //修改日期
objvqa_PaperENT.memo = objvqa_PaperENS.memo; //备注
objvqa_PaperENT.paperTitle = objvqa_PaperENS.paperTitle; //论文标题
objvqa_PaperENT.attachmentCount = objvqa_PaperENS.attachmentCount; //附件计数
objvqa_PaperENT.paperContent = objvqa_PaperENS.paperContent; //主题内容
objvqa_PaperENT.periodical = objvqa_PaperENS.periodical; //期刊
objvqa_PaperENT.author = objvqa_PaperENS.author; //作者
objvqa_PaperENT.researchQuestion = objvqa_PaperENS.researchQuestion; //研究问题
objvqa_PaperENT.literatureSources = objvqa_PaperENS.literatureSources; //文献来源
objvqa_PaperENT.uploadfileUrl = objvqa_PaperENS.uploadfileUrl; //文件地址
objvqa_PaperENT.id_XzMajor = objvqa_PaperENS.id_XzMajor; //专业流水号
objvqa_PaperENT.majorName = objvqa_PaperENS.majorName; //专业名称
objvqa_PaperENT.id_CurrEduCls = objvqa_PaperENS.id_CurrEduCls; //教学班流水号
objvqa_PaperENT.answerCount = objvqa_PaperENS.answerCount; //回答计数
objvqa_PaperENT.shareId = objvqa_PaperENS.shareId; //分享Id
objvqa_PaperENT.tagsCount = objvqa_PaperENS.tagsCount; //论文标注数
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvqa_PaperENS:源对象
 * @param objvqa_PaperENT:目标对象
*/
export function vqa_Paper_GetObjFromJsonObj(objvqa_PaperENS: clsvqa_PaperEN): clsvqa_PaperEN 
{
 const objvqa_PaperENT: clsvqa_PaperEN = new clsvqa_PaperEN();
ObjectAssign(objvqa_PaperENT, objvqa_PaperENS);
 return objvqa_PaperENT;
}