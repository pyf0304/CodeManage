
 /**
 * 类名:clsvPaperWApi
 * 表名:vPaper(01120549)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:37
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
 * v论文表(vPaper)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvPaperEN } from "../../L0_Entity/GraduateEduPaper/clsvPaperEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vPaper_Controller = "vPaperApi";
 export const vPaper_ConstructorName = "vPaper";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strPaperId:关键字
 * @returns 对象
 **/
export async function vPaper_GetObjByPaperIdAsync(strPaperId: string): Promise<clsvPaperEN>  
{
const strThisFuncName = "GetObjByPaperIdAsync";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByPaperId";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaper = vPaper_GetObjFromJsonObj(returnObj);
return objvPaper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjByPaperId_Cache(strPaperId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByPaperId_Cache";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
try
{
const arrvPaper_Sel: Array <clsvPaperEN> = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
let objvPaper: clsvPaperEN;
if (arrvPaper_Sel.length > 0)
{
objvPaper = arrvPaper_Sel[0];
return objvPaper;
}
else
{
if (bolTryAsyncOnce == true)
{
objvPaper = await vPaper_GetObjByPaperIdAsync(strPaperId);
if (objvPaper != null)
{
vPaper_ReFreshThisCache();
return objvPaper;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjByPaperId_localStorage(strPaperId: string) {
const strThisFuncName = "GetObjByPaperId_localStorage";

if (IsNullOrEmpty(strPaperId) == true)
{
  const strMsg = Format("参数:[strPaperId]不能为空！(In GetObjByPaperId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strPaperId.length != 8)
{
const strMsg = Format("缓存分类变量:[strPaperId]的长度:[{0}]不正确！", strPaperId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvPaperEN._CurrTabName, strPaperId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvPaper_Cache: clsvPaperEN = JSON.parse(strTempObj);
return objvPaper_Cache;
}
try
{
const objvPaper = await vPaper_GetObjByPaperIdAsync(strPaperId);
if (objvPaper != null)
{
localStorage.setItem(strKey, JSON.stringify(objvPaper));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvPaper;
}
return objvPaper;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperId, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvPaperEN.con_PaperId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvPaperEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvPaperEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strPaperId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvPaper = await vPaper_GetObjByPaperId_Cache(strPaperId );
if (objvPaper == null) return "";
return objvPaper.GetFldValue(strOutFldName).toString();
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
export function vPaper_SortFun_Defa(a:clsvPaperEN , b:clsvPaperEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperId.localeCompare(b.paperId);
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
export function vPaper_SortFun_Defa_2Fld(a:clsvPaperEN , b:clsvPaperEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperTitle == b.paperTitle) return a.paperContent.localeCompare(b.paperContent);
else return a.paperTitle.localeCompare(b.paperTitle);
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
export function vPaper_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvPaperEN.con_PaperId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvPaperEN.con_PaperTitle:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvPaperEN.con_PaperContent:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvPaperEN.con_Periodical:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvPaperEN.con_Author:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.author.localeCompare(b.author);
}
case clsvPaperEN.con_ResearchQuestion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvPaperEN.con_Keyword:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvPaperEN.con_LiteratureSources:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsvPaperEN.con_LiteratureLink:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsvPaperEN.con_UploadfileUrl:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvPaperEN.con_IsQuotethesis:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsvPaperEN.con_QuoteId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.quoteId.localeCompare(b.quoteId);
}
case clsvPaperEN.con_IsChecked:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsvPaperEN.con_Checker:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.checker.localeCompare(b.checker);
}
case clsvPaperEN.con_LiteratureTypeId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsvPaperEN.con_LiteratureTypeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.literatureTypeName.localeCompare(b.literatureTypeName);
}
case clsvPaperEN.con_BrowseNumber:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.browseNumber-b.browseNumber;
}
case clsvPaperEN.con_IsSubmit:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvPaperEN.con_AppraiseCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvPaperEN.con_AttachmentCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.attachmentCount-b.attachmentCount;
}
case clsvPaperEN.con_CollectionCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.collectionCount-b.collectionCount;
}
case clsvPaperEN.con_DownloadCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.downloadCount-b.downloadCount;
}
case clsvPaperEN.con_OkCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.okCount-b.okCount;
}
case clsvPaperEN.con_Pcount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.pcount-b.pcount;
}
case clsvPaperEN.con_score:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.score-b.score;
}
case clsvPaperEN.con_StuScore:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.stuScore-b.stuScore;
}
case clsvPaperEN.con_TeaScore:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.teaScore-b.teaScore;
}
case clsvPaperEN.con_PaperTypeId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsvPaperEN.con_PaperTypeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperTypeName.localeCompare(b.paperTypeName);
}
case clsvPaperEN.con_PaperStatusId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperStatusId.localeCompare(b.paperStatusId);
}
case clsvPaperEN.con_PaperStatusName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperStatusName.localeCompare(b.paperStatusName);
}
case clsvPaperEN.con_VersionCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.versionCount-b.versionCount;
}
case clsvPaperEN.con_IsPublic:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsvPaperEN.con_AskQuestion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.askQuestion.localeCompare(b.askQuestion);
}
case clsvPaperEN.con_ResearchStatus:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.researchStatus.localeCompare(b.researchStatus);
}
case clsvPaperEN.con_InnovationPoints:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.innovationPoints.localeCompare(b.innovationPoints);
}
case clsvPaperEN.con_ResearchDesign:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.researchDesign.localeCompare(b.researchDesign);
}
case clsvPaperEN.con_DimensionDataProcess:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.dimensionDataProcess.localeCompare(b.dimensionDataProcess);
}
case clsvPaperEN.con_ExpectedConclusion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.expectedConclusion.localeCompare(b.expectedConclusion);
}
case clsvPaperEN.con_ShareId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.shareId.localeCompare(b.shareId);
}
case clsvPaperEN.con_PaperQCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.paperQCount-b.paperQCount;
}
case clsvPaperEN.con_SubVCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.subVCount-b.subVCount;
}
case clsvPaperEN.con_TagsCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.tagsCount-b.tagsCount;
}
case clsvPaperEN.con_TeaQCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.teaQCount-b.teaQCount;
}
case clsvPaperEN.con_CreateDate:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvPaperEN.con_UpdUser:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvPaperEN.con_UserName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvPaperEN.con_IsGSuser:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (a.isGSuser == true) return 1;
else return -1
}
case clsvPaperEN.con_CollegeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvPaperEN.con_id_XzCollege:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvPaperEN.con_id_XzMajor:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvPaperEN.con_MajorName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvPaperEN.con_UpdDate:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvPaperEN.con_Memo:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${ vPaper_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvPaperEN.con_PaperId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvPaperEN.con_PaperTitle:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvPaperEN.con_PaperContent:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvPaperEN.con_Periodical:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvPaperEN.con_Author:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.author.localeCompare(a.author);
}
case clsvPaperEN.con_ResearchQuestion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvPaperEN.con_Keyword:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvPaperEN.con_LiteratureSources:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsvPaperEN.con_LiteratureLink:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsvPaperEN.con_UploadfileUrl:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvPaperEN.con_IsQuotethesis:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsvPaperEN.con_QuoteId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.quoteId.localeCompare(a.quoteId);
}
case clsvPaperEN.con_IsChecked:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsvPaperEN.con_Checker:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.checker.localeCompare(a.checker);
}
case clsvPaperEN.con_LiteratureTypeId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsvPaperEN.con_LiteratureTypeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.literatureTypeName.localeCompare(a.literatureTypeName);
}
case clsvPaperEN.con_BrowseNumber:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.browseNumber-a.browseNumber;
}
case clsvPaperEN.con_IsSubmit:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvPaperEN.con_AppraiseCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvPaperEN.con_AttachmentCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.attachmentCount-a.attachmentCount;
}
case clsvPaperEN.con_CollectionCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.collectionCount-a.collectionCount;
}
case clsvPaperEN.con_DownloadCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.downloadCount-a.downloadCount;
}
case clsvPaperEN.con_OkCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.okCount-a.okCount;
}
case clsvPaperEN.con_Pcount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.pcount-a.pcount;
}
case clsvPaperEN.con_score:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.score-a.score;
}
case clsvPaperEN.con_StuScore:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.stuScore-a.stuScore;
}
case clsvPaperEN.con_TeaScore:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.teaScore-a.teaScore;
}
case clsvPaperEN.con_PaperTypeId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsvPaperEN.con_PaperTypeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperTypeName.localeCompare(a.paperTypeName);
}
case clsvPaperEN.con_PaperStatusId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperStatusId.localeCompare(a.paperStatusId);
}
case clsvPaperEN.con_PaperStatusName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperStatusName.localeCompare(a.paperStatusName);
}
case clsvPaperEN.con_VersionCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.versionCount-a.versionCount;
}
case clsvPaperEN.con_IsPublic:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsvPaperEN.con_AskQuestion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.askQuestion.localeCompare(a.askQuestion);
}
case clsvPaperEN.con_ResearchStatus:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.researchStatus.localeCompare(a.researchStatus);
}
case clsvPaperEN.con_InnovationPoints:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.innovationPoints.localeCompare(a.innovationPoints);
}
case clsvPaperEN.con_ResearchDesign:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.researchDesign.localeCompare(a.researchDesign);
}
case clsvPaperEN.con_DimensionDataProcess:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.dimensionDataProcess.localeCompare(a.dimensionDataProcess);
}
case clsvPaperEN.con_ExpectedConclusion:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.expectedConclusion.localeCompare(a.expectedConclusion);
}
case clsvPaperEN.con_ShareId:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.shareId.localeCompare(a.shareId);
}
case clsvPaperEN.con_PaperQCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.paperQCount-a.paperQCount;
}
case clsvPaperEN.con_SubVCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.subVCount-a.subVCount;
}
case clsvPaperEN.con_TagsCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.tagsCount-a.tagsCount;
}
case clsvPaperEN.con_TeaQCount:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.teaQCount-a.teaQCount;
}
case clsvPaperEN.con_CreateDate:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvPaperEN.con_UpdUser:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvPaperEN.con_UserName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvPaperEN.con_IsGSuser:
return (a: clsvPaperEN, b: clsvPaperEN) => {
if (b.isGSuser == true) return 1;
else return -1
}
case clsvPaperEN.con_CollegeName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvPaperEN.con_id_XzCollege:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvPaperEN.con_id_XzMajor:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvPaperEN.con_MajorName:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvPaperEN.con_UpdDate:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvPaperEN.con_Memo:
return (a: clsvPaperEN, b: clsvPaperEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${ vPaper_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaper_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvPaperEN.con_PaperId:
return (obj: clsvPaperEN) => {
return obj.paperId === value;
}
case clsvPaperEN.con_PaperTitle:
return (obj: clsvPaperEN) => {
return obj.paperTitle === value;
}
case clsvPaperEN.con_PaperContent:
return (obj: clsvPaperEN) => {
return obj.paperContent === value;
}
case clsvPaperEN.con_Periodical:
return (obj: clsvPaperEN) => {
return obj.periodical === value;
}
case clsvPaperEN.con_Author:
return (obj: clsvPaperEN) => {
return obj.author === value;
}
case clsvPaperEN.con_ResearchQuestion:
return (obj: clsvPaperEN) => {
return obj.researchQuestion === value;
}
case clsvPaperEN.con_Keyword:
return (obj: clsvPaperEN) => {
return obj.keyword === value;
}
case clsvPaperEN.con_LiteratureSources:
return (obj: clsvPaperEN) => {
return obj.literatureSources === value;
}
case clsvPaperEN.con_LiteratureLink:
return (obj: clsvPaperEN) => {
return obj.literatureLink === value;
}
case clsvPaperEN.con_UploadfileUrl:
return (obj: clsvPaperEN) => {
return obj.uploadfileUrl === value;
}
case clsvPaperEN.con_IsQuotethesis:
return (obj: clsvPaperEN) => {
return obj.isQuotethesis === value;
}
case clsvPaperEN.con_QuoteId:
return (obj: clsvPaperEN) => {
return obj.quoteId === value;
}
case clsvPaperEN.con_IsChecked:
return (obj: clsvPaperEN) => {
return obj.isChecked === value;
}
case clsvPaperEN.con_Checker:
return (obj: clsvPaperEN) => {
return obj.checker === value;
}
case clsvPaperEN.con_LiteratureTypeId:
return (obj: clsvPaperEN) => {
return obj.literatureTypeId === value;
}
case clsvPaperEN.con_LiteratureTypeName:
return (obj: clsvPaperEN) => {
return obj.literatureTypeName === value;
}
case clsvPaperEN.con_BrowseNumber:
return (obj: clsvPaperEN) => {
return obj.browseNumber === value;
}
case clsvPaperEN.con_IsSubmit:
return (obj: clsvPaperEN) => {
return obj.isSubmit === value;
}
case clsvPaperEN.con_AppraiseCount:
return (obj: clsvPaperEN) => {
return obj.appraiseCount === value;
}
case clsvPaperEN.con_AttachmentCount:
return (obj: clsvPaperEN) => {
return obj.attachmentCount === value;
}
case clsvPaperEN.con_CollectionCount:
return (obj: clsvPaperEN) => {
return obj.collectionCount === value;
}
case clsvPaperEN.con_DownloadCount:
return (obj: clsvPaperEN) => {
return obj.downloadCount === value;
}
case clsvPaperEN.con_OkCount:
return (obj: clsvPaperEN) => {
return obj.okCount === value;
}
case clsvPaperEN.con_Pcount:
return (obj: clsvPaperEN) => {
return obj.pcount === value;
}
case clsvPaperEN.con_score:
return (obj: clsvPaperEN) => {
return obj.score === value;
}
case clsvPaperEN.con_StuScore:
return (obj: clsvPaperEN) => {
return obj.stuScore === value;
}
case clsvPaperEN.con_TeaScore:
return (obj: clsvPaperEN) => {
return obj.teaScore === value;
}
case clsvPaperEN.con_PaperTypeId:
return (obj: clsvPaperEN) => {
return obj.paperTypeId === value;
}
case clsvPaperEN.con_PaperTypeName:
return (obj: clsvPaperEN) => {
return obj.paperTypeName === value;
}
case clsvPaperEN.con_PaperStatusId:
return (obj: clsvPaperEN) => {
return obj.paperStatusId === value;
}
case clsvPaperEN.con_PaperStatusName:
return (obj: clsvPaperEN) => {
return obj.paperStatusName === value;
}
case clsvPaperEN.con_VersionCount:
return (obj: clsvPaperEN) => {
return obj.versionCount === value;
}
case clsvPaperEN.con_IsPublic:
return (obj: clsvPaperEN) => {
return obj.isPublic === value;
}
case clsvPaperEN.con_AskQuestion:
return (obj: clsvPaperEN) => {
return obj.askQuestion === value;
}
case clsvPaperEN.con_ResearchStatus:
return (obj: clsvPaperEN) => {
return obj.researchStatus === value;
}
case clsvPaperEN.con_InnovationPoints:
return (obj: clsvPaperEN) => {
return obj.innovationPoints === value;
}
case clsvPaperEN.con_ResearchDesign:
return (obj: clsvPaperEN) => {
return obj.researchDesign === value;
}
case clsvPaperEN.con_DimensionDataProcess:
return (obj: clsvPaperEN) => {
return obj.dimensionDataProcess === value;
}
case clsvPaperEN.con_ExpectedConclusion:
return (obj: clsvPaperEN) => {
return obj.expectedConclusion === value;
}
case clsvPaperEN.con_ShareId:
return (obj: clsvPaperEN) => {
return obj.shareId === value;
}
case clsvPaperEN.con_PaperQCount:
return (obj: clsvPaperEN) => {
return obj.paperQCount === value;
}
case clsvPaperEN.con_SubVCount:
return (obj: clsvPaperEN) => {
return obj.subVCount === value;
}
case clsvPaperEN.con_TagsCount:
return (obj: clsvPaperEN) => {
return obj.tagsCount === value;
}
case clsvPaperEN.con_TeaQCount:
return (obj: clsvPaperEN) => {
return obj.teaQCount === value;
}
case clsvPaperEN.con_CreateDate:
return (obj: clsvPaperEN) => {
return obj.createDate === value;
}
case clsvPaperEN.con_UpdUser:
return (obj: clsvPaperEN) => {
return obj.updUser === value;
}
case clsvPaperEN.con_UserName:
return (obj: clsvPaperEN) => {
return obj.userName === value;
}
case clsvPaperEN.con_IsGSuser:
return (obj: clsvPaperEN) => {
return obj.isGSuser === value;
}
case clsvPaperEN.con_CollegeName:
return (obj: clsvPaperEN) => {
return obj.collegeName === value;
}
case clsvPaperEN.con_id_XzCollege:
return (obj: clsvPaperEN) => {
return obj.id_XzCollege === value;
}
case clsvPaperEN.con_id_XzMajor:
return (obj: clsvPaperEN) => {
return obj.id_XzMajor === value;
}
case clsvPaperEN.con_MajorName:
return (obj: clsvPaperEN) => {
return obj.majorName === value;
}
case clsvPaperEN.con_UpdDate:
return (obj: clsvPaperEN) => {
return obj.updDate === value;
}
case clsvPaperEN.con_Memo:
return (obj: clsvPaperEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vPaper]中不存在！(in ${ vPaper_ConstructorName}.${ strThisFuncName})`;
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
export async function vPaper_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetFirstObjAsync(strWhereCond: string): Promise<clsvPaperEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvPaper = vPaper_GetObjFromJsonObj(returnObj);
return objvPaper;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperEN._CurrTabName;
clsvPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvPaperExObjLst_Cache: Array<clsvPaperEN> = CacheHelper.Get(strKey);
const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
return arrvPaperObjLst_T;
}
try
{
const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvPaperExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
console.log(strInfo);
return arrvPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaper_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperEN._CurrTabName;
clsvPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEN.CacheAddiCondition);
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
const arrvPaperExObjLst_Cache: Array<clsvPaperEN> = JSON.parse(strTempObjLst);
const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
return arrvPaperObjLst_T;
}
try
{
const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvPaperExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
console.log(strInfo);
return arrvPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaper_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvPaperObjLst_Cache: Array<clsvPaperEN> = JSON.parse(strTempObjLst);
return arrvPaperObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vPaper_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvPaperEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvPaperEN._CurrTabName;
clsvPaperEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvPaperEN._CurrTabName);
if (IsNullOrEmpty(clsvPaperEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvPaperEN.CacheAddiCondition);
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
const arrvPaperExObjLst_Cache: Array<clsvPaperEN> = JSON.parse(strTempObjLst);
const arrvPaperObjLst_T = vPaper_GetObjLstByJSONObjLst(arrvPaperExObjLst_Cache);
return arrvPaperObjLst_T;
}
try
{
const arrvPaperExObjLst = await vPaper_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvPaperExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperExObjLst.length);
console.log(strInfo);
return arrvPaperExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaper_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvPaperEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvPaperObjLst_Cache: Array<clsvPaperEN> = JSON.parse(strTempObjLst);
return arrvPaperObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaper_GetObjLst_Cache(): Promise<Array<clsvPaperEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvPaperObjLst_Cache;
switch (clsvPaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperObjLst_Cache = await vPaper_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvPaperObjLst_Cache = await vPaper_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvPaperObjLst_Cache = await vPaper_GetObjLst_ClientCache();
break;
default:
arrvPaperObjLst_Cache = await vPaper_GetObjLst_ClientCache();
break;
}
const arrvPaperObjLst = vPaper_GetObjLstByJSONObjLst(arrvPaperObjLst_Cache);
return arrvPaperObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vPaper_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvPaperObjLst_Cache;
switch (clsvPaperEN.CacheModeId)
{
case "04"://sessionStorage
arrvPaperObjLst_Cache = await vPaper_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvPaperObjLst_Cache = await vPaper_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvPaperObjLst_Cache = null;
break;
default:
arrvPaperObjLst_Cache = null;
break;
}
return arrvPaperObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrPaperId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vPaper_GetSubObjLst_Cache(objvPaper_Cond: clsvPaperEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
let arrvPaper_Sel: Array < clsvPaperEN > = arrvPaperObjLst_Cache;
if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "") return arrvPaper_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
//console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvPaper_Cond), vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperId:关键字列表
 * @returns 对象列表
 **/
export async function vPaper_GetObjLstByPaperIdLstAsync(arrPaperId: Array<string>): Promise<Array<clsvPaperEN>>  
{
const strThisFuncName = "GetObjLstByPaperIdLstAsync";
const strAction = "GetObjLstByPaperIdLst";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLstByPaperIdLst_Cache(arrPaperIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByPaperIdLst_Cache";
try
{
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
const arrvPaper_Sel: Array <clsvPaperEN> = arrvPaperObjLst_Cache.filter(x => arrPaperIdLst.indexOf(x.paperId)>-1);
return arrvPaper_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperIdLst.join(","), vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vPaper_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvPaperEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvPaperEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
if (arrvPaperObjLst_Cache.length == 0) return arrvPaperObjLst_Cache;
let arrvPaper_Sel = arrvPaperObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvPaper_Cond = new clsvPaperEN();
ObjectAssign(objvPaper_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaper_Sel = arrvPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaper_Sel.length == 0) return arrvPaper_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvPaper_Sel = arrvPaper_Sel.sort(vPaper_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvPaper_Sel = arrvPaper_Sel.sort(objPagerPara.sortFun);
}
arrvPaper_Sel = arrvPaper_Sel.slice(intStart, intEnd);     
return arrvPaper_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vPaper_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvPaperEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vPaper_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvPaperEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vPaper_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vPaper_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_IsExistRecord_Cache(objvPaper_Cond: clsvPaperEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
if (arrvPaperObjLst_Cache == null) return false;
let arrvPaper_Sel: Array < clsvPaperEN > = arrvPaperObjLst_Cache;
if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "") return arrvPaper_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
//console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvPaper_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvPaper_Cond), vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_IsExist(strPaperId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_IsExist_Cache(strPaperId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
if (arrvPaperObjLst_Cache == null) return false;
try
{
const arrvPaper_Sel: Array <clsvPaperEN> = arrvPaperObjLst_Cache.filter(x => x.paperId == strPaperId);
if (arrvPaper_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperId, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_IsExistAsync(strPaperId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
export async function vPaper_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vPaper_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vPaper_ConstructorName, strThisFuncName);
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
 * @param objvPaper_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vPaper_GetRecCountByCond_Cache(objvPaper_Cond: clsvPaperEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvPaperObjLst_Cache = await vPaper_GetObjLst_Cache();
if (arrvPaperObjLst_Cache == null) return 0;
let arrvPaper_Sel: Array < clsvPaperEN > = arrvPaperObjLst_Cache;
if (objvPaper_Cond.sf_FldComparisonOp == null || objvPaper_Cond.sf_FldComparisonOp == "") return arrvPaper_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvPaper_Cond.sf_FldComparisonOp);
//console.log("clsvPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvPaper_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvPaper_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvPaper_Sel = arrvPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvPaper_Sel = arrvPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvPaper_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvPaper_Cond), vPaper_ConstructorName, strThisFuncName);
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
export function vPaper_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vPaper_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvPaperEN._CurrTabName;
switch (clsvPaperEN.CacheModeId)
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
export function vPaper_GetJSONStrByObj (pobjvPaperEN: clsvPaperEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvPaperEN);
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
export function vPaper_GetObjLstByJSONStr (strJSON: string): Array<clsvPaperEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvPaperObjLst = new Array<clsvPaperEN>();
if (strJSON === "")
{
return arrvPaperObjLst;
}
try
{
arrvPaperObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPaperObjLst;
}
return arrvPaperObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvPaperObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vPaper_GetObjLstByJSONObjLst (arrvPaperObjLstS: Array<clsvPaperEN>): Array<clsvPaperEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvPaperObjLst = new Array<clsvPaperEN>();
for (const objInFor of arrvPaperObjLstS) {
const obj1 = vPaper_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvPaperObjLst.push(obj1);
}
return arrvPaperObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vPaper_GetObjByJSONStr (strJSON: string): clsvPaperEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvPaperEN = new clsvPaperEN();
if (strJSON === "")
{
return pobjvPaperEN;
}
try
{
pobjvPaperEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPaperEN;
}
return pobjvPaperEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vPaper_GetCombineCondition(objvPaper_Cond: clsvPaperEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperId, objvPaper_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperTitle, objvPaper_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_Periodical, objvPaper_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_Author, objvPaper_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_ResearchQuestion, objvPaper_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_Keyword, objvPaper_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_LiteratureSources, objvPaper_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_LiteratureLink, objvPaper_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_UploadfileUrl, objvPaper_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_IsQuotethesis) == true)
{
if (objvPaper_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_QuoteId) == true)
{
const strComparisonOp_QuoteId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_QuoteId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_QuoteId, objvPaper_Cond.quoteId, strComparisonOp_QuoteId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_IsChecked) == true)
{
if (objvPaper_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_Checker, objvPaper_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_LiteratureTypeId, objvPaper_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_LiteratureTypeName) == true)
{
const strComparisonOp_LiteratureTypeName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_LiteratureTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_LiteratureTypeName, objvPaper_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_BrowseNumber) == true)
{
const strComparisonOp_BrowseNumber:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_BrowseNumber];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_BrowseNumber, objvPaper_Cond.browseNumber, strComparisonOp_BrowseNumber);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_IsSubmit) == true)
{
if (objvPaper_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_AppraiseCount, objvPaper_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_AttachmentCount) == true)
{
const strComparisonOp_AttachmentCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_AttachmentCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_AttachmentCount, objvPaper_Cond.attachmentCount, strComparisonOp_AttachmentCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_CollectionCount) == true)
{
const strComparisonOp_CollectionCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_CollectionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_CollectionCount, objvPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_DownloadCount) == true)
{
const strComparisonOp_DownloadCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_DownloadCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_DownloadCount, objvPaper_Cond.downloadCount, strComparisonOp_DownloadCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_OkCount, objvPaper_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Pcount) == true)
{
const strComparisonOp_Pcount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Pcount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_Pcount, objvPaper_Cond.pcount, strComparisonOp_Pcount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_score) == true)
{
const strComparisonOp_score:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_score, objvPaper_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_StuScore, objvPaper_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_TeaScore, objvPaper_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperTypeId, objvPaper_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperTypeName) == true)
{
const strComparisonOp_PaperTypeName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperTypeName, objvPaper_Cond.paperTypeName, strComparisonOp_PaperTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperStatusId) == true)
{
const strComparisonOp_PaperStatusId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperStatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperStatusId, objvPaper_Cond.paperStatusId, strComparisonOp_PaperStatusId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperStatusName) == true)
{
const strComparisonOp_PaperStatusName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperStatusName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_PaperStatusName, objvPaper_Cond.paperStatusName, strComparisonOp_PaperStatusName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_VersionCount, objvPaper_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_IsPublic) == true)
{
if (objvPaper_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_AskQuestion) == true)
{
const strComparisonOp_AskQuestion:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_AskQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_AskQuestion, objvPaper_Cond.askQuestion, strComparisonOp_AskQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_ResearchStatus) == true)
{
const strComparisonOp_ResearchStatus:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_ResearchStatus];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_ResearchStatus, objvPaper_Cond.researchStatus, strComparisonOp_ResearchStatus);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_InnovationPoints) == true)
{
const strComparisonOp_InnovationPoints:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_InnovationPoints];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_InnovationPoints, objvPaper_Cond.innovationPoints, strComparisonOp_InnovationPoints);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_ResearchDesign) == true)
{
const strComparisonOp_ResearchDesign:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_ResearchDesign];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_ResearchDesign, objvPaper_Cond.researchDesign, strComparisonOp_ResearchDesign);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_DimensionDataProcess) == true)
{
const strComparisonOp_DimensionDataProcess:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_DimensionDataProcess];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_DimensionDataProcess, objvPaper_Cond.dimensionDataProcess, strComparisonOp_DimensionDataProcess);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_ExpectedConclusion) == true)
{
const strComparisonOp_ExpectedConclusion:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_ExpectedConclusion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_ExpectedConclusion, objvPaper_Cond.expectedConclusion, strComparisonOp_ExpectedConclusion);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_ShareId, objvPaper_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_PaperQCount) == true)
{
const strComparisonOp_PaperQCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_PaperQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_PaperQCount, objvPaper_Cond.paperQCount, strComparisonOp_PaperQCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_SubVCount) == true)
{
const strComparisonOp_SubVCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_SubVCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_SubVCount, objvPaper_Cond.subVCount, strComparisonOp_SubVCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_TagsCount) == true)
{
const strComparisonOp_TagsCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_TagsCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_TagsCount, objvPaper_Cond.tagsCount, strComparisonOp_TagsCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_TeaQCount) == true)
{
const strComparisonOp_TeaQCount:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_TeaQCount];
strWhereCond += Format(" And {0} {2} {1}", clsvPaperEN.con_TeaQCount, objvPaper_Cond.teaQCount, strComparisonOp_TeaQCount);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_CreateDate, objvPaper_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_UpdUser, objvPaper_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_UserName, objvPaper_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_IsGSuser) == true)
{
if (objvPaper_Cond.isGSuser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvPaperEN.con_IsGSuser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvPaperEN.con_IsGSuser);
}
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_CollegeName, objvPaper_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_id_XzCollege, objvPaper_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_id_XzMajor, objvPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_MajorName, objvPaper_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_UpdDate, objvPaper_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvPaper_Cond.dicFldComparisonOp, clsvPaperEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvPaper_Cond.dicFldComparisonOp[clsvPaperEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvPaperEN.con_Memo, objvPaper_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvPaperENS:源对象
 * @param objvPaperENT:目标对象
*/
export function vPaper_CopyObjTo(objvPaperENS: clsvPaperEN , objvPaperENT: clsvPaperEN ): void 
{
objvPaperENT.paperId = objvPaperENS.paperId; //论文Id
objvPaperENT.paperTitle = objvPaperENS.paperTitle; //论文标题
objvPaperENT.paperContent = objvPaperENS.paperContent; //主题内容
objvPaperENT.periodical = objvPaperENS.periodical; //期刊
objvPaperENT.author = objvPaperENS.author; //作者
objvPaperENT.researchQuestion = objvPaperENS.researchQuestion; //研究问题
objvPaperENT.keyword = objvPaperENS.keyword; //关键字
objvPaperENT.literatureSources = objvPaperENS.literatureSources; //文献来源
objvPaperENT.literatureLink = objvPaperENS.literatureLink; //文献链接
objvPaperENT.uploadfileUrl = objvPaperENS.uploadfileUrl; //文件地址
objvPaperENT.isQuotethesis = objvPaperENS.isQuotethesis; //是否引用论文
objvPaperENT.quoteId = objvPaperENS.quoteId; //引用Id
objvPaperENT.isChecked = objvPaperENS.isChecked; //是否检查
objvPaperENT.checker = objvPaperENS.checker; //审核人
objvPaperENT.literatureTypeId = objvPaperENS.literatureTypeId; //作文类型Id
objvPaperENT.literatureTypeName = objvPaperENS.literatureTypeName; //作文类型名
objvPaperENT.browseNumber = objvPaperENS.browseNumber; //浏览量
objvPaperENT.isSubmit = objvPaperENS.isSubmit; //是否提交
objvPaperENT.appraiseCount = objvPaperENS.appraiseCount; //评论数
objvPaperENT.attachmentCount = objvPaperENS.attachmentCount; //附件计数
objvPaperENT.collectionCount = objvPaperENS.collectionCount; //收藏数
objvPaperENT.downloadCount = objvPaperENS.downloadCount; //下载数
objvPaperENT.okCount = objvPaperENS.okCount; //点赞统计
objvPaperENT.pcount = objvPaperENS.pcount; //读写数
objvPaperENT.score = objvPaperENS.score; //评分
objvPaperENT.stuScore = objvPaperENS.stuScore; //学生平均分
objvPaperENT.teaScore = objvPaperENS.teaScore; //教师评分
objvPaperENT.paperTypeId = objvPaperENS.paperTypeId; //论文类型Id
objvPaperENT.paperTypeName = objvPaperENS.paperTypeName; //论文类型名
objvPaperENT.paperStatusId = objvPaperENS.paperStatusId; //论文状态Id
objvPaperENT.paperStatusName = objvPaperENS.paperStatusName; //论文状态名
objvPaperENT.versionCount = objvPaperENS.versionCount; //版本统计
objvPaperENT.isPublic = objvPaperENS.isPublic; //是否公开
objvPaperENT.askQuestion = objvPaperENS.askQuestion; //问题提出
objvPaperENT.researchStatus = objvPaperENS.researchStatus; //目前研究的现状
objvPaperENT.innovationPoints = objvPaperENS.innovationPoints; //创新点
objvPaperENT.researchDesign = objvPaperENS.researchDesign; //研究设计
objvPaperENT.dimensionDataProcess = objvPaperENS.dimensionDataProcess; //数据处理的维度
objvPaperENT.expectedConclusion = objvPaperENS.expectedConclusion; //预期结论
objvPaperENT.shareId = objvPaperENS.shareId; //分享Id
objvPaperENT.paperQCount = objvPaperENS.paperQCount; //论文答疑数
objvPaperENT.subVCount = objvPaperENS.subVCount; //论文子观点数
objvPaperENT.tagsCount = objvPaperENS.tagsCount; //论文标注数
objvPaperENT.teaQCount = objvPaperENS.teaQCount; //教师提问数
objvPaperENT.createDate = objvPaperENS.createDate; //建立日期
objvPaperENT.updUser = objvPaperENS.updUser; //修改人
objvPaperENT.userName = objvPaperENS.userName; //用户名
objvPaperENT.isGSuser = objvPaperENS.isGSuser; //是否GS用户
objvPaperENT.collegeName = objvPaperENS.collegeName; //学院名称
objvPaperENT.id_XzCollege = objvPaperENS.id_XzCollege; //学院流水号
objvPaperENT.id_XzMajor = objvPaperENS.id_XzMajor; //专业流水号
objvPaperENT.majorName = objvPaperENS.majorName; //专业名称
objvPaperENT.updDate = objvPaperENS.updDate; //修改日期
objvPaperENT.memo = objvPaperENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvPaperENS:源对象
 * @param objvPaperENT:目标对象
*/
export function vPaper_GetObjFromJsonObj(objvPaperENS: clsvPaperEN): clsvPaperEN 
{
 const objvPaperENT: clsvPaperEN = new clsvPaperEN();
ObjectAssign(objvPaperENT, objvPaperENS);
 return objvPaperENT;
}