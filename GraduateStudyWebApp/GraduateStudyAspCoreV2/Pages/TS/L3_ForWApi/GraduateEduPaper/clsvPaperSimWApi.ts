﻿
 /**
 * 类名:clsvPaperSimWApi
 * 表名:vPaperSim(01120597)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/15 23:44:07
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
 * 论文简化视图(vPaperSim)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月15日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvPaperSimEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperSimEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaperSim_Controller = "vPaperSimApi";
 export const vPaperSim_ConstructorName = "vPaperSim";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPaperId:关键字
 * @returns 对象
 **/
export async function vPaperSim_GetObjByPaperIdAsync(strPaperId: string): Promise<clsvPaperSimEN|null>  
{
const strThisFuncName = "GetObjByPaperIdAsync";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In clsvPaperSimWApi.GetObjByPaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！(clsvPaperSimWApi.GetObjByPaperIdAsync)", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPaperId";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strPaperId": strPaperId,
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
const objvPaperSim = vPaperSim_GetObjFromJsonObj(returnObj);
return objvPaperSim;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSim_GetObjByPaperId_Cache(strPaperId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperId_Cache";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In clsvPaperSimWApi.GetObjByPaperId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！(clsvPaperSimWApi.GetObjByPaperId_Cache)", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
try
{
const arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => 
 x.paperId == strPaperId );
let objvPaperSim: clsvPaperSimEN;
if (arrvPaperSim_Sel.length > 0)
{
objvPaperSim = arrvPaperSim_Sel[0];
return objvPaperSim;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvPaperSim_Const = await vPaperSim_GetObjByPaperIdAsync(strPaperId);
if (objvPaperSim_Const != null)
{
vPaperSim_ReFreshThisCache();
return objvPaperSim_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSim_GetObjByPaperId_localStorage(strPaperId: string) {
const strThisFuncName = "GetObjByPaperId_localStorage";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In clsvPaperSimWApi.GetObjByPaperId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！(clsvPaperSimWApi.GetObjByPaperId_localStorage)", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvPaperSimEN._CurrTabName, strPaperId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvPaperSim_Cache: clsvPaperSimEN = JSON.parse(strTempObj);
return objvPaperSim_Cache;
}
try
{
const objvPaperSim = await vPaperSim_GetObjByPaperIdAsync(strPaperId);
if (objvPaperSim != null)
{
localStorage.setItem(strKey, JSON.stringify(objvPaperSim));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvPaperSim;
}
return objvPaperSim;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function vPaperSim_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsvPaperSimEN.con_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvPaperSimEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvPaperSimEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPaperId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvPaperSim = await vPaperSim_GetObjByPaperId_Cache(strPaperId );
if (objvPaperSim == null) return "";
if (objvPaperSim.GetFldValue(strOutFldName) == null) return "";
return objvPaperSim.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSim_SortFun_Defa(a:clsvPaperSimEN , b:clsvPaperSimEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperId.localeCompare(b.paperId);
}
/**
 * 排序函数。根据表对象中随机两个字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param  a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSim_SortFun_Defa_2Fld(a:clsvPaperSimEN , b:clsvPaperSimEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperTitle == b.paperTitle) return a.paperContent.localeCompare(b.paperContent);
else return a.paperTitle.localeCompare(b.paperTitle);
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vPaperSim_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperSimEN.con_PaperId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperSimEN.con_PaperTitle:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperSimEN.con_PaperContent:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.paperContent == null) return -1;
if (b.paperContent == null) return 1;
return a.paperContent.localeCompare(b.paperContent);
}
case clsvPaperSimEN.con_Periodical:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.periodical == null) return -1;
if (b.periodical == null) return 1;
return a.periodical.localeCompare(b.periodical);
}
case clsvPaperSimEN.con_Author:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsvPaperSimEN.con_ResearchQuestion:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.researchQuestion == null) return -1;
if (b.researchQuestion == null) return 1;
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvPaperSimEN.con_UpdDate:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperSimEN.con_UserName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.userName == null) return -1;
if (b.userName == null) return 1;
return a.userName.localeCompare(b.userName);
}
case clsvPaperSimEN.con_id_XzCollege:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.id_XzCollege == null) return -1;
if (b.id_XzCollege == null) return 1;
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvPaperSimEN.con_CollegeName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.collegeName == null) return -1;
if (b.collegeName == null) return 1;
return a.collegeName.localeCompare(b.collegeName);
}
case clsvPaperSimEN.con_id_XzMajor:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.id_XzMajor == null) return -1;
if (b.id_XzMajor == null) return 1;
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvPaperSimEN.con_MajorName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.majorName == null) return -1;
if (b.majorName == null) return 1;
return a.majorName.localeCompare(b.majorName);
}
case clsvPaperSimEN.con_Keyword:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.keyword == null) return -1;
if (b.keyword == null) return 1;
return a.keyword.localeCompare(b.keyword);
}
case clsvPaperSimEN.con_LiteratureSources:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.literatureSources == null) return -1;
if (b.literatureSources == null) return 1;
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsvPaperSimEN.con_LiteratureLink:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.literatureLink == null) return -1;
if (b.literatureLink == null) return 1;
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsvPaperSimEN.con_UploadfileUrl:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.uploadfileUrl == null) return -1;
if (b.uploadfileUrl == null) return 1;
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvPaperSimEN.con_IsQuotethesis:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsvPaperSimEN.con_QuoteId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.quoteId == null) return -1;
if (b.quoteId == null) return 1;
return a.quoteId.localeCompare(b.quoteId);
}
case clsvPaperSimEN.con_Checker:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.checker == null) return -1;
if (b.checker == null) return 1;
return a.checker.localeCompare(b.checker);
}
case clsvPaperSimEN.con_IsChecked:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsvPaperSimEN.con_LiteratureTypeId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsvPaperSimEN.con_BrowseNumber:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.browseNumber-b.browseNumber;
}
case clsvPaperSimEN.con_LiteratureTypeName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.literatureTypeName == null) return -1;
if (b.literatureTypeName == null) return 1;
return a.literatureTypeName.localeCompare(b.literatureTypeName);
}
case clsvPaperSimEN.con_IsSubmit:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvPaperSimEN.con_AppraiseCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvPaperSimEN.con_AttachmentCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvPaperSimEN.con_CollectionCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.collectionCount-b.collectionCount;
}
case clsvPaperSimEN.con_DownloadCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.downloadCount-b.downloadCount;
}
case clsvPaperSimEN.con_Memo:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvPaperSimEN.con_OkCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.okCount-b.okCount;
}
case clsvPaperSimEN.con_Pcount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.pcount-b.pcount;
}
case clsvPaperSimEN.con_Score:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.score-b.score;
}
case clsvPaperSimEN.con_StuScore:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.stuScore-b.stuScore;
}
case clsvPaperSimEN.con_TeaScore:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.teaScore-b.teaScore;
}
case clsvPaperSimEN.con_PaperQCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.paperQCount-b.paperQCount;
}
case clsvPaperSimEN.con_SubVCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.subVCount-b.subVCount;
}
case clsvPaperSimEN.con_TagsCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.tagsCount-b.tagsCount;
}
case clsvPaperSimEN.con_TeaQCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return a.teaQCount-b.teaQCount;
}
case clsvPaperSimEN.con_UpdUser:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSim]中不存在！(in ${ vPaperSim_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperSimEN.con_PaperId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperSimEN.con_PaperTitle:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperSimEN.con_PaperContent:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.paperContent == null) return -1;
if (a.paperContent == null) return 1;
return b.paperContent.localeCompare(a.paperContent);
}
case clsvPaperSimEN.con_Periodical:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.periodical == null) return -1;
if (a.periodical == null) return 1;
return b.periodical.localeCompare(a.periodical);
}
case clsvPaperSimEN.con_Author:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsvPaperSimEN.con_ResearchQuestion:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.researchQuestion == null) return -1;
if (a.researchQuestion == null) return 1;
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvPaperSimEN.con_UpdDate:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperSimEN.con_UserName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.userName == null) return -1;
if (a.userName == null) return 1;
return b.userName.localeCompare(a.userName);
}
case clsvPaperSimEN.con_id_XzCollege:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.id_XzCollege == null) return -1;
if (a.id_XzCollege == null) return 1;
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvPaperSimEN.con_CollegeName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.collegeName == null) return -1;
if (a.collegeName == null) return 1;
return b.collegeName.localeCompare(a.collegeName);
}
case clsvPaperSimEN.con_id_XzMajor:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.id_XzMajor == null) return -1;
if (a.id_XzMajor == null) return 1;
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvPaperSimEN.con_MajorName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.majorName == null) return -1;
if (a.majorName == null) return 1;
return b.majorName.localeCompare(a.majorName);
}
case clsvPaperSimEN.con_Keyword:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.keyword == null) return -1;
if (a.keyword == null) return 1;
return b.keyword.localeCompare(a.keyword);
}
case clsvPaperSimEN.con_LiteratureSources:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.literatureSources == null) return -1;
if (a.literatureSources == null) return 1;
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsvPaperSimEN.con_LiteratureLink:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.literatureLink == null) return -1;
if (a.literatureLink == null) return 1;
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsvPaperSimEN.con_UploadfileUrl:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.uploadfileUrl == null) return -1;
if (a.uploadfileUrl == null) return 1;
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvPaperSimEN.con_IsQuotethesis:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsvPaperSimEN.con_QuoteId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.quoteId == null) return -1;
if (a.quoteId == null) return 1;
return b.quoteId.localeCompare(a.quoteId);
}
case clsvPaperSimEN.con_Checker:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.checker == null) return -1;
if (a.checker == null) return 1;
return b.checker.localeCompare(a.checker);
}
case clsvPaperSimEN.con_IsChecked:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsvPaperSimEN.con_LiteratureTypeId:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsvPaperSimEN.con_BrowseNumber:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.browseNumber-a.browseNumber;
}
case clsvPaperSimEN.con_LiteratureTypeName:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.literatureTypeName == null) return -1;
if (a.literatureTypeName == null) return 1;
return b.literatureTypeName.localeCompare(a.literatureTypeName);
}
case clsvPaperSimEN.con_IsSubmit:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvPaperSimEN.con_AppraiseCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvPaperSimEN.con_AttachmentCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvPaperSimEN.con_CollectionCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.collectionCount-a.collectionCount;
}
case clsvPaperSimEN.con_DownloadCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.downloadCount-a.downloadCount;
}
case clsvPaperSimEN.con_Memo:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvPaperSimEN.con_OkCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.okCount-a.okCount;
}
case clsvPaperSimEN.con_Pcount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.pcount-a.pcount;
}
case clsvPaperSimEN.con_Score:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.score-a.score;
}
case clsvPaperSimEN.con_StuScore:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.stuScore-a.stuScore;
}
case clsvPaperSimEN.con_TeaScore:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.teaScore-a.teaScore;
}
case clsvPaperSimEN.con_PaperQCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.paperQCount-a.paperQCount;
}
case clsvPaperSimEN.con_SubVCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.subVCount-a.subVCount;
}
case clsvPaperSimEN.con_TagsCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.tagsCount-a.tagsCount;
}
case clsvPaperSimEN.con_TeaQCount:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
return b.teaQCount-a.teaQCount;
}
case clsvPaperSimEN.con_UpdUser:
return (a: clsvPaperSimEN, b: clsvPaperSimEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSim]中不存在！(in ${ vPaperSim_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
}

/**
 * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
 * @param strKey:比较的关键字段名称
 * @param value:给定值
 * @returns 返回对象的字段值是否等于给定值
*/
export async function vPaperSim_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperSimEN.con_PaperId:
return (obj: clsvPaperSimEN) => {
return obj.paperId === value;
}
case clsvPaperSimEN.con_PaperTitle:
return (obj: clsvPaperSimEN) => {
return obj.paperTitle === value;
}
case clsvPaperSimEN.con_PaperContent:
return (obj: clsvPaperSimEN) => {
return obj.paperContent === value;
}
case clsvPaperSimEN.con_Periodical:
return (obj: clsvPaperSimEN) => {
return obj.periodical === value;
}
case clsvPaperSimEN.con_Author:
return (obj: clsvPaperSimEN) => {
return obj.author === value;
}
case clsvPaperSimEN.con_ResearchQuestion:
return (obj: clsvPaperSimEN) => {
return obj.researchQuestion === value;
}
case clsvPaperSimEN.con_UpdDate:
return (obj: clsvPaperSimEN) => {
return obj.updDate === value;
}
case clsvPaperSimEN.con_UserName:
return (obj: clsvPaperSimEN) => {
return obj.userName === value;
}
case clsvPaperSimEN.con_id_XzCollege:
return (obj: clsvPaperSimEN) => {
return obj.id_XzCollege === value;
}
case clsvPaperSimEN.con_CollegeName:
return (obj: clsvPaperSimEN) => {
return obj.collegeName === value;
}
case clsvPaperSimEN.con_id_XzMajor:
return (obj: clsvPaperSimEN) => {
return obj.id_XzMajor === value;
}
case clsvPaperSimEN.con_MajorName:
return (obj: clsvPaperSimEN) => {
return obj.majorName === value;
}
case clsvPaperSimEN.con_Keyword:
return (obj: clsvPaperSimEN) => {
return obj.keyword === value;
}
case clsvPaperSimEN.con_LiteratureSources:
return (obj: clsvPaperSimEN) => {
return obj.literatureSources === value;
}
case clsvPaperSimEN.con_LiteratureLink:
return (obj: clsvPaperSimEN) => {
return obj.literatureLink === value;
}
case clsvPaperSimEN.con_UploadfileUrl:
return (obj: clsvPaperSimEN) => {
return obj.uploadfileUrl === value;
}
case clsvPaperSimEN.con_IsQuotethesis:
return (obj: clsvPaperSimEN) => {
return obj.isQuotethesis === value;
}
case clsvPaperSimEN.con_QuoteId:
return (obj: clsvPaperSimEN) => {
return obj.quoteId === value;
}
case clsvPaperSimEN.con_Checker:
return (obj: clsvPaperSimEN) => {
return obj.checker === value;
}
case clsvPaperSimEN.con_IsChecked:
return (obj: clsvPaperSimEN) => {
return obj.isChecked === value;
}
case clsvPaperSimEN.con_LiteratureTypeId:
return (obj: clsvPaperSimEN) => {
return obj.literatureTypeId === value;
}
case clsvPaperSimEN.con_BrowseNumber:
return (obj: clsvPaperSimEN) => {
return obj.browseNumber === value;
}
case clsvPaperSimEN.con_LiteratureTypeName:
return (obj: clsvPaperSimEN) => {
return obj.literatureTypeName === value;
}
case clsvPaperSimEN.con_IsSubmit:
return (obj: clsvPaperSimEN) => {
return obj.isSubmit === value;
}
case clsvPaperSimEN.con_AppraiseCount:
return (obj: clsvPaperSimEN) => {
return obj.appraiseCount === value;
}
case clsvPaperSimEN.con_AttachmentCount:
return (obj: clsvPaperSimEN) => {
return obj.attachmentCount === value;
}
case clsvPaperSimEN.con_CollectionCount:
return (obj: clsvPaperSimEN) => {
return obj.collectionCount === value;
}
case clsvPaperSimEN.con_DownloadCount:
return (obj: clsvPaperSimEN) => {
return obj.downloadCount === value;
}
case clsvPaperSimEN.con_Memo:
return (obj: clsvPaperSimEN) => {
return obj.memo === value;
}
case clsvPaperSimEN.con_OkCount:
return (obj: clsvPaperSimEN) => {
return obj.okCount === value;
}
case clsvPaperSimEN.con_Pcount:
return (obj: clsvPaperSimEN) => {
return obj.pcount === value;
}
case clsvPaperSimEN.con_Score:
return (obj: clsvPaperSimEN) => {
return obj.score === value;
}
case clsvPaperSimEN.con_StuScore:
return (obj: clsvPaperSimEN) => {
return obj.stuScore === value;
}
case clsvPaperSimEN.con_TeaScore:
return (obj: clsvPaperSimEN) => {
return obj.teaScore === value;
}
case clsvPaperSimEN.con_PaperQCount:
return (obj: clsvPaperSimEN) => {
return obj.paperQCount === value;
}
case clsvPaperSimEN.con_SubVCount:
return (obj: clsvPaperSimEN) => {
return obj.subVCount === value;
}
case clsvPaperSimEN.con_TagsCount:
return (obj: clsvPaperSimEN) => {
return obj.tagsCount === value;
}
case clsvPaperSimEN.con_TeaQCount:
return (obj: clsvPaperSimEN) => {
return obj.teaQCount === value;
}
case clsvPaperSimEN.con_UpdUser:
return (obj: clsvPaperSimEN) => {
return obj.updUser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaperSim]中不存在！(in ${ vPaperSim_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 * @returns 返回一个关键字值列表
*/
export async function vPaperSim_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsvPaperSimEN.con_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrvPaperSim = await vPaperSim_GetObjLst_Cache();
if (arrvPaperSim == null) return [];
let arrvPaperSim_Sel = arrvPaperSim;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvPaperSim_Sel.length == 0) return [];
return arrvPaperSim_Sel.map(x=>x.paperId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vPaperSim_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperSimEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const objvPaperSim = vPaperSim_GetObjFromJsonObj(returnObj);
return objvPaperSim;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSimEN._CurrTabName;
if (IsNullOrEmpty(clsvPaperSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSimEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvPaperSimExObjLst_Cache: Array<clsvPaperSimEN> = CacheHelper.Get(strKey);
const arrvPaperSimObjLst_T = vPaperSim_GetObjLstByJSONObjLst(arrvPaperSimExObjLst_Cache);
return arrvPaperSimObjLst_T;
}
try
{
const arrvPaperSimExObjLst = await vPaperSim_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvPaperSimExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimExObjLst.length);
console.log(strInfo);
return arrvPaperSimExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSim_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSimEN._CurrTabName;
if (IsNullOrEmpty(clsvPaperSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSimEN.CacheAddiCondition);
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
const arrvPaperSimExObjLst_Cache: Array<clsvPaperSimEN> = JSON.parse(strTempObjLst);
const arrvPaperSimObjLst_T = vPaperSim_GetObjLstByJSONObjLst(arrvPaperSimExObjLst_Cache);
return arrvPaperSimObjLst_T;
}
try
{
const arrvPaperSimExObjLst = await vPaperSim_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvPaperSimExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimExObjLst.length);
console.log(strInfo);
return arrvPaperSimExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSim_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperSimEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvPaperSimObjLst_Cache: Array<clsvPaperSimEN> = JSON.parse(strTempObjLst);
return arrvPaperSimObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vPaperSim_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperSimEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperSimEN._CurrTabName;
if (IsNullOrEmpty(clsvPaperSimEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperSimEN.CacheAddiCondition);
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
const arrvPaperSimExObjLst_Cache: Array<clsvPaperSimEN> = JSON.parse(strTempObjLst);
const arrvPaperSimObjLst_T = vPaperSim_GetObjLstByJSONObjLst(arrvPaperSimExObjLst_Cache);
return arrvPaperSimObjLst_T;
}
try
{
const arrvPaperSimExObjLst = await vPaperSim_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSimExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSimExObjLst.length);
console.log(strInfo);
return arrvPaperSimExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSim_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperSimEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvPaperSimObjLst_Cache: Array<clsvPaperSimEN> = JSON.parse(strTempObjLst);
return arrvPaperSimObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSim_GetObjLst_Cache(): Promise<Array<clsvPaperSimEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvPaperSimObjLst_Cache;
switch (clsvPaperSimEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_ClientCache();
break;
default:
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_ClientCache();
break;
}
const arrvPaperSimObjLst = vPaperSim_GetObjLstByJSONObjLst(arrvPaperSimObjLst_Cache);
return arrvPaperSimObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaperSim_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvPaperSimObjLst_Cache;
switch (clsvPaperSimEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvPaperSimObjLst_Cache = null;
break;
default:
arrvPaperSimObjLst_Cache = null;
break;
}
return arrvPaperSimObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSim_GetSubObjLst_Cache(objvPaperSim_Cond: clsvPaperSimEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
let arrvPaperSim_Sel = arrvPaperSimObjLst_Cache;
if (objvPaperSim_Cond.sf_FldComparisonOp == null || objvPaperSim_Cond.sf_FldComparisonOp == "") return arrvPaperSim_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSim_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSim_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSim_Cond), vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSimEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperId:关键字列表
 * @returns 对象列表
 **/
export async function vPaperSim_GetObjLstByPaperIdLstAsync(arrPaperId: Array<string>): Promise<Array<clsvPaperSimEN>>  
{
const strThisFuncName = "GetObjLstByPaperIdLstAsync";
const strAction = "GetObjLstByPaperIdLst";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param arrstrPaperIdLst:关键字列表
 * @returns 对象列表
*/
export async function vPaperSim_GetObjLstByPaperIdLst_Cache(arrPaperIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByPaperIdLst_Cache";
try
{
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
const arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => arrPaperIdLst.indexOf(x.paperId)>-1);
return arrvPaperSim_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperIdLst.join(","), vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperSimEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperSimEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvPaperSimEN>();
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
if (arrvPaperSimObjLst_Cache.length == 0) return arrvPaperSimObjLst_Cache;
let arrvPaperSim_Sel = arrvPaperSimObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaperSim_Cond = new clsvPaperSimEN();
ObjectAssign(objvPaperSim_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperSimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSim_Sel.length == 0) return arrvPaperSim_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaperSim_Sel = arrvPaperSim_Sel.sort(vPaperSim_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaperSim_Sel = arrvPaperSim_Sel.sort(objPagerPara.sortFun);
}
arrvPaperSim_Sel = arrvPaperSim_Sel.slice(intStart, intEnd);     
return arrvPaperSim_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperSimEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vPaperSim_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperSimEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvPaperSimEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaperSim_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaperSim_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param objstrPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaperSim_IsExistRecord_Cache(objvPaperSim_Cond: clsvPaperSimEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
if (arrvPaperSimObjLst_Cache == null) return false;
let arrvPaperSim_Sel = arrvPaperSimObjLst_Cache;
if (objvPaperSim_Cond.sf_FldComparisonOp == null || objvPaperSim_Cond.sf_FldComparisonOp == "") return arrvPaperSim_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSim_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaperSim_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvPaperSim_Cond), vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param strPaperId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vPaperSim_IsExist(strPaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperId": strPaperId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param strPaperId:所给的关键字
 * @returns 对象
*/
export async function vPaperSim_IsExist_Cache(strPaperId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
if (arrvPaperSimObjLst_Cache == null) return false;
try
{
const arrvPaperSim_Sel = arrvPaperSimObjLst_Cache.filter(x => x.paperId == strPaperId);
if (arrvPaperSim_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperId, vPaperSim_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strPaperId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vPaperSim_IsExistAsync(strPaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strPaperId": strPaperId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
export async function vPaperSim_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaperSim_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaperSim_ConstructorName, strThisFuncName);
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
 * @param objvPaperSim_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaperSim_GetRecCountByCond_Cache(objvPaperSim_Cond: clsvPaperSimEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvPaperSimObjLst_Cache = await vPaperSim_GetObjLst_Cache();
if (arrvPaperSimObjLst_Cache == null) return 0;
let arrvPaperSim_Sel = arrvPaperSimObjLst_Cache;
if (objvPaperSim_Cond.sf_FldComparisonOp == null || objvPaperSim_Cond.sf_FldComparisonOp == "") return arrvPaperSim_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaperSim_Cond.sf_FldComparisonOp);
//console.log("clsvPaperSimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaperSim_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaperSim_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaperSim_Sel = arrvPaperSim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaperSim_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvPaperSim_Cond), vPaperSim_ConstructorName, strThisFuncName);
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
export function vPaperSim_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaperSim_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvPaperSimEN._CurrTabName;
switch (clsvPaperSimEN.CacheModeId)
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
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSim_GetJSONStrByObj (pobjvPaperSimEN: clsvPaperSimEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperSimEN);
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
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象列表
*/
export function vPaperSim_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperSimEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperSimObjLst = new Array<clsvPaperSimEN>();
if (strJSON === "")
{
return arrvPaperSimObjLst;
}
try
{
arrvPaperSimObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperSimObjLst;
}
return arrvPaperSimObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperSimObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaperSim_GetObjLstByJSONObjLst (arrvPaperSimObjLstS: Array<clsvPaperSimEN>): Array<clsvPaperSimEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperSimObjLst = new Array<clsvPaperSimEN>();
for (const objInFor of arrvPaperSimObjLstS) {
const obj1 = vPaperSim_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperSimObjLst.push(obj1);
}
return arrvPaperSimObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-15
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaperSim_GetObjByJSONStr (strJSON: string): clsvPaperSimEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperSimEN = new clsvPaperSimEN();
if (strJSON === "")
{
return pobjvPaperSimEN;
}
try
{
pobjvPaperSimEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperSimEN;
}
return pobjvPaperSimEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaperSim_GetCombineCondition(objvPaperSim_Cond: clsvPaperSimEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_PaperId, objvPaperSim_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_PaperTitle, objvPaperSim_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_Periodical, objvPaperSim_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_Author, objvPaperSim_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_ResearchQuestion, objvPaperSim_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_UpdDate, objvPaperSim_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_UserName, objvPaperSim_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_id_XzCollege, objvPaperSim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_CollegeName, objvPaperSim_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_id_XzMajor, objvPaperSim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_MajorName, objvPaperSim_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_Keyword, objvPaperSim_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_LiteratureSources, objvPaperSim_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_LiteratureLink, objvPaperSim_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_UploadfileUrl, objvPaperSim_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_IsQuotethesis) == true)
{
if (objvPaperSim_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperSimEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperSimEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_QuoteId) == true)
{
const strComparisonOp_QuoteId:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_QuoteId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_QuoteId, objvPaperSim_Cond.quoteId, strComparisonOp_QuoteId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_Checker, objvPaperSim_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_IsChecked) == true)
{
if (objvPaperSim_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperSimEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperSimEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_LiteratureTypeId, objvPaperSim_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_BrowseNumber, objvPaperSim_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_LiteratureTypeName) == true)
{
const strComparisonOp_LiteratureTypeName:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_LiteratureTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_LiteratureTypeName, objvPaperSim_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_IsSubmit) == true)
{
if (objvPaperSim_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperSimEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperSimEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_AppraiseCount, objvPaperSim_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_AttachmentCount, objvPaperSim_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_CollectionCount) == true)
{
const strComparisonOp_CollectionCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_CollectionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_CollectionCount, objvPaperSim_Cond.collectionCount, strComparisonOp_CollectionCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_DownloadCount) == true)
{
const strComparisonOp_DownloadCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_DownloadCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_DownloadCount, objvPaperSim_Cond.downloadCount, strComparisonOp_DownloadCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_Memo, objvPaperSim_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_OkCount, objvPaperSim_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Pcount) == true)
{
const strComparisonOp_Pcount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Pcount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_Pcount, objvPaperSim_Cond.pcount, strComparisonOp_Pcount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_Score, objvPaperSim_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_StuScore, objvPaperSim_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_TeaScore, objvPaperSim_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_PaperQCount) == true)
{
const strComparisonOp_PaperQCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_PaperQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_PaperQCount, objvPaperSim_Cond.paperQCount, strComparisonOp_PaperQCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_SubVCount) == true)
{
const strComparisonOp_SubVCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_SubVCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_SubVCount, objvPaperSim_Cond.subVCount, strComparisonOp_SubVCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_TagsCount, objvPaperSim_Cond.tagsCount, strComparisonOp_TagsCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_TeaQCount) == true)
{
const strComparisonOp_TeaQCount:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_TeaQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperSimEN.con_TeaQCount, objvPaperSim_Cond.teaQCount, strComparisonOp_TeaQCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaperSim_Cond.dicFldComparisonOp, clsvPaperSimEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaperSim_Cond.dicFldComparisonOp[clsvPaperSimEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperSimEN.con_UpdUser, objvPaperSim_Cond.updUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperSimENS:源对象
 * @param objvPaperSimENT:目标对象
*/
export function vPaperSim_CopyObjTo(objvPaperSimENS: clsvPaperSimEN , objvPaperSimENT: clsvPaperSimEN ): void 
{
objvPaperSimENT.paperId = objvPaperSimENS.paperId; //论文Id
objvPaperSimENT.paperTitle = objvPaperSimENS.paperTitle; //论文标题
objvPaperSimENT.paperContent = objvPaperSimENS.paperContent; //主题内容
objvPaperSimENT.periodical = objvPaperSimENS.periodical; //期刊
objvPaperSimENT.author = objvPaperSimENS.author; //作者
objvPaperSimENT.researchQuestion = objvPaperSimENS.researchQuestion; //研究问题
objvPaperSimENT.updDate = objvPaperSimENS.updDate; //修改日期
objvPaperSimENT.userName = objvPaperSimENS.userName; //用户名
objvPaperSimENT.id_XzCollege = objvPaperSimENS.id_XzCollege; //学院流水号
objvPaperSimENT.collegeName = objvPaperSimENS.collegeName; //学院名称
objvPaperSimENT.id_XzMajor = objvPaperSimENS.id_XzMajor; //专业流水号
objvPaperSimENT.majorName = objvPaperSimENS.majorName; //专业名称
objvPaperSimENT.keyword = objvPaperSimENS.keyword; //关键字
objvPaperSimENT.literatureSources = objvPaperSimENS.literatureSources; //文献来源
objvPaperSimENT.literatureLink = objvPaperSimENS.literatureLink; //文献链接
objvPaperSimENT.uploadfileUrl = objvPaperSimENS.uploadfileUrl; //文件地址
objvPaperSimENT.isQuotethesis = objvPaperSimENS.isQuotethesis; //是否引用论文
objvPaperSimENT.quoteId = objvPaperSimENS.quoteId; //引用Id
objvPaperSimENT.checker = objvPaperSimENS.checker; //审核人
objvPaperSimENT.isChecked = objvPaperSimENS.isChecked; //是否检查
objvPaperSimENT.literatureTypeId = objvPaperSimENS.literatureTypeId; //作文类型Id
objvPaperSimENT.browseNumber = objvPaperSimENS.browseNumber; //浏览量
objvPaperSimENT.literatureTypeName = objvPaperSimENS.literatureTypeName; //作文类型名
objvPaperSimENT.isSubmit = objvPaperSimENS.isSubmit; //是否提交
objvPaperSimENT.appraiseCount = objvPaperSimENS.appraiseCount; //评论数
objvPaperSimENT.attachmentCount = objvPaperSimENS.attachmentCount; //附件计数
objvPaperSimENT.collectionCount = objvPaperSimENS.collectionCount; //收藏数量
objvPaperSimENT.downloadCount = objvPaperSimENS.downloadCount; //下载数
objvPaperSimENT.memo = objvPaperSimENS.memo; //备注
objvPaperSimENT.okCount = objvPaperSimENS.okCount; //点赞统计
objvPaperSimENT.pcount = objvPaperSimENS.pcount; //读写数
objvPaperSimENT.score = objvPaperSimENS.score; //评分
objvPaperSimENT.stuScore = objvPaperSimENS.stuScore; //学生平均分
objvPaperSimENT.teaScore = objvPaperSimENS.teaScore; //教师评分
objvPaperSimENT.paperQCount = objvPaperSimENS.paperQCount; //论文答疑数
objvPaperSimENT.subVCount = objvPaperSimENS.subVCount; //论文子观点数
objvPaperSimENT.tagsCount = objvPaperSimENS.tagsCount; //论文标注数
objvPaperSimENT.teaQCount = objvPaperSimENS.teaQCount; //教师提问数
objvPaperSimENT.updUser = objvPaperSimENS.updUser; //修改人
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperSimENS:源对象
 * @param objvPaperSimENT:目标对象
*/
export function vPaperSim_GetObjFromJsonObj(objvPaperSimENS: clsvPaperSimEN): clsvPaperSimEN 
{
 const objvPaperSimENT: clsvPaperSimEN = new clsvPaperSimEN();
ObjectAssign(objvPaperSimENT, objvPaperSimENS);
 return objvPaperSimENT;
}