
 /**
 * 类名:clsgs_PaperVerWApi
 * 表名:gs_PaperVer(01120678)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:04
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
 * 论文历史版本表(gs_PaperVer)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsgs_PaperVerEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperVer_Controller = "gs_PaperVerApi";
 export const gs_PaperVer_ConstructorName = "gs_PaperVer";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperVId:关键字
 * @returns 对象
 **/
export async function gs_PaperVer_GetObjByPaperVIdAsync(lngPaperVId: number): Promise<clsgs_PaperVerEN|null>  
{
const strThisFuncName = "GetObjByPaperVIdAsync";

if (lngPaperVId == 0)
{
  const strMsg = Format("参数:[lngPaperVId]不能为空！(In clsgs_PaperVerWApi.GetObjByPaperVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperVId";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngPaperVId": lngPaperVId,
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
const objgs_PaperVer = gs_PaperVer_GetObjFromJsonObj(returnObj);
return objgs_PaperVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_PaperVer_SortFun_Defa(a:clsgs_PaperVerEN , b:clsgs_PaperVerEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperVId-b.paperVId;
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
export function gs_PaperVer_SortFun_Defa_2Fld(a:clsgs_PaperVerEN , b:clsgs_PaperVerEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.paperTitle.localeCompare(b.paperTitle);
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
export function gs_PaperVer_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperVerEN.con_PaperVId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return a.paperVId-b.paperVId;
}
case clsgs_PaperVerEN.con_PaperId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PaperVerEN.con_PaperTitle:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsgs_PaperVerEN.con_PaperContent:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.paperContent == null) return -1;
if (b.paperContent == null) return 1;
return a.paperContent.localeCompare(b.paperContent);
}
case clsgs_PaperVerEN.con_Periodical:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.periodical == null) return -1;
if (b.periodical == null) return 1;
return a.periodical.localeCompare(b.periodical);
}
case clsgs_PaperVerEN.con_Author:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.author == null) return -1;
if (b.author == null) return 1;
return a.author.localeCompare(b.author);
}
case clsgs_PaperVerEN.con_ResearchQuestion:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.researchQuestion == null) return -1;
if (b.researchQuestion == null) return 1;
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsgs_PaperVerEN.con_Keyword:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.keyword == null) return -1;
if (b.keyword == null) return 1;
return a.keyword.localeCompare(b.keyword);
}
case clsgs_PaperVerEN.con_LiteratureSources:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.literatureSources == null) return -1;
if (b.literatureSources == null) return 1;
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsgs_PaperVerEN.con_LiteratureLink:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.literatureLink == null) return -1;
if (b.literatureLink == null) return 1;
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsgs_PaperVerEN.con_UploadfileUrl:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.uploadfileUrl == null) return -1;
if (b.uploadfileUrl == null) return 1;
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsgs_PaperVerEN.con_IsQuotethesis:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_IsSubmit:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_IsChecked:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_QuoteId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.quoteId == null) return -1;
if (b.quoteId == null) return 1;
return a.quoteId.localeCompare(b.quoteId);
}
case clsgs_PaperVerEN.con_Checker:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.checker == null) return -1;
if (b.checker == null) return 1;
return a.checker.localeCompare(b.checker);
}
case clsgs_PaperVerEN.con_LiteratureTypeId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsgs_PaperVerEN.con_UpdUser:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperVerEN.con_UpdDate:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperVerEN.con_id_CurrEduCls:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_PaperVerEN.con_PaperTypeId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.paperTypeId == null) return -1;
if (b.paperTypeId == null) return 1;
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsgs_PaperVerEN.con_PaperStatusId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.paperStatusId == null) return -1;
if (b.paperStatusId == null) return 1;
return a.paperStatusId.localeCompare(b.paperStatusId);
}
case clsgs_PaperVerEN.con_Memo:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${ gs_PaperVer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperVerEN.con_PaperVId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return b.paperVId-a.paperVId;
}
case clsgs_PaperVerEN.con_PaperId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PaperVerEN.con_PaperTitle:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsgs_PaperVerEN.con_PaperContent:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.paperContent == null) return -1;
if (a.paperContent == null) return 1;
return b.paperContent.localeCompare(a.paperContent);
}
case clsgs_PaperVerEN.con_Periodical:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.periodical == null) return -1;
if (a.periodical == null) return 1;
return b.periodical.localeCompare(a.periodical);
}
case clsgs_PaperVerEN.con_Author:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.author == null) return -1;
if (a.author == null) return 1;
return b.author.localeCompare(a.author);
}
case clsgs_PaperVerEN.con_ResearchQuestion:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.researchQuestion == null) return -1;
if (a.researchQuestion == null) return 1;
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsgs_PaperVerEN.con_Keyword:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.keyword == null) return -1;
if (a.keyword == null) return 1;
return b.keyword.localeCompare(a.keyword);
}
case clsgs_PaperVerEN.con_LiteratureSources:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.literatureSources == null) return -1;
if (a.literatureSources == null) return 1;
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsgs_PaperVerEN.con_LiteratureLink:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.literatureLink == null) return -1;
if (a.literatureLink == null) return 1;
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsgs_PaperVerEN.con_UploadfileUrl:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.uploadfileUrl == null) return -1;
if (a.uploadfileUrl == null) return 1;
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsgs_PaperVerEN.con_IsQuotethesis:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_IsSubmit:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_IsChecked:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsgs_PaperVerEN.con_QuoteId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.quoteId == null) return -1;
if (a.quoteId == null) return 1;
return b.quoteId.localeCompare(a.quoteId);
}
case clsgs_PaperVerEN.con_Checker:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.checker == null) return -1;
if (a.checker == null) return 1;
return b.checker.localeCompare(a.checker);
}
case clsgs_PaperVerEN.con_LiteratureTypeId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsgs_PaperVerEN.con_UpdUser:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperVerEN.con_UpdDate:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperVerEN.con_id_CurrEduCls:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_PaperVerEN.con_PaperTypeId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.paperTypeId == null) return -1;
if (a.paperTypeId == null) return 1;
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsgs_PaperVerEN.con_PaperStatusId:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.paperStatusId == null) return -1;
if (a.paperStatusId == null) return 1;
return b.paperStatusId.localeCompare(a.paperStatusId);
}
case clsgs_PaperVerEN.con_Memo:
return (a: clsgs_PaperVerEN, b: clsgs_PaperVerEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${ gs_PaperVer_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperVer_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperVerEN.con_PaperVId:
return (obj: clsgs_PaperVerEN) => {
return obj.paperVId === value;
}
case clsgs_PaperVerEN.con_PaperId:
return (obj: clsgs_PaperVerEN) => {
return obj.paperId === value;
}
case clsgs_PaperVerEN.con_PaperTitle:
return (obj: clsgs_PaperVerEN) => {
return obj.paperTitle === value;
}
case clsgs_PaperVerEN.con_PaperContent:
return (obj: clsgs_PaperVerEN) => {
return obj.paperContent === value;
}
case clsgs_PaperVerEN.con_Periodical:
return (obj: clsgs_PaperVerEN) => {
return obj.periodical === value;
}
case clsgs_PaperVerEN.con_Author:
return (obj: clsgs_PaperVerEN) => {
return obj.author === value;
}
case clsgs_PaperVerEN.con_ResearchQuestion:
return (obj: clsgs_PaperVerEN) => {
return obj.researchQuestion === value;
}
case clsgs_PaperVerEN.con_Keyword:
return (obj: clsgs_PaperVerEN) => {
return obj.keyword === value;
}
case clsgs_PaperVerEN.con_LiteratureSources:
return (obj: clsgs_PaperVerEN) => {
return obj.literatureSources === value;
}
case clsgs_PaperVerEN.con_LiteratureLink:
return (obj: clsgs_PaperVerEN) => {
return obj.literatureLink === value;
}
case clsgs_PaperVerEN.con_UploadfileUrl:
return (obj: clsgs_PaperVerEN) => {
return obj.uploadfileUrl === value;
}
case clsgs_PaperVerEN.con_IsQuotethesis:
return (obj: clsgs_PaperVerEN) => {
return obj.isQuotethesis === value;
}
case clsgs_PaperVerEN.con_IsSubmit:
return (obj: clsgs_PaperVerEN) => {
return obj.isSubmit === value;
}
case clsgs_PaperVerEN.con_IsChecked:
return (obj: clsgs_PaperVerEN) => {
return obj.isChecked === value;
}
case clsgs_PaperVerEN.con_QuoteId:
return (obj: clsgs_PaperVerEN) => {
return obj.quoteId === value;
}
case clsgs_PaperVerEN.con_Checker:
return (obj: clsgs_PaperVerEN) => {
return obj.checker === value;
}
case clsgs_PaperVerEN.con_LiteratureTypeId:
return (obj: clsgs_PaperVerEN) => {
return obj.literatureTypeId === value;
}
case clsgs_PaperVerEN.con_UpdUser:
return (obj: clsgs_PaperVerEN) => {
return obj.updUser === value;
}
case clsgs_PaperVerEN.con_UpdDate:
return (obj: clsgs_PaperVerEN) => {
return obj.updDate === value;
}
case clsgs_PaperVerEN.con_id_CurrEduCls:
return (obj: clsgs_PaperVerEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_PaperVerEN.con_PaperTypeId:
return (obj: clsgs_PaperVerEN) => {
return obj.paperTypeId === value;
}
case clsgs_PaperVerEN.con_PaperStatusId:
return (obj: clsgs_PaperVerEN) => {
return obj.paperStatusId === value;
}
case clsgs_PaperVerEN.con_Memo:
return (obj: clsgs_PaperVerEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperVer]中不存在！(in ${ gs_PaperVer_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperVer_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperVerEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const objgs_PaperVer = gs_PaperVer_GetObjFromJsonObj(returnObj);
return objgs_PaperVer;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperVer_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperVerEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrPaperVId:关键字列表
 * @returns 对象列表
 **/
export async function gs_PaperVer_GetObjLstByPaperVIdLstAsync(arrPaperVId: Array<string>): Promise<Array<clsgs_PaperVerEN>>  
{
const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
const strAction = "GetObjLstByPaperVIdLst";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function gs_PaperVer_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperVerEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperVerEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function gs_PaperVer_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperVerEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsgs_PaperVerEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperVer_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param lngPaperVId:关键字
 * @returns 获取删除的结果
 **/
export async function gs_PaperVer_DelRecordAsync(lngPaperVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param arrPaperVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function gs_PaperVer_Delgs_PaperVersAsync(arrPaperVId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperVersAsync";
const strAction = "Delgs_PaperVers";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_Delgs_PaperVersByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperVersByCondAsync";
const strAction = "Delgs_PaperVersByCond";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVerEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperVer_AddNewRecordAsync(objgs_PaperVerEN: clsgs_PaperVerEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperVerEN);
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/

 /**
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objgs_PaperVerEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperVer_AddNewRecordWithReturnKeyAsync(objgs_PaperVerEN: clsgs_PaperVerEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVerEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperVer_AddNewRecordWithReturnKey(objgs_PaperVerEN: clsgs_PaperVerEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperVerEN.paperVId === null || objgs_PaperVerEN.paperVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVerEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperVer_UpdateRecordAsync(objgs_PaperVerEN: clsgs_PaperVerEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperVerEN.sfUpdFldSetStr === undefined || objgs_PaperVerEN.sfUpdFldSetStr === null || objgs_PaperVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVerEN.paperVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVerEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperVer_UpdateWithConditionAsync(objgs_PaperVerEN: clsgs_PaperVerEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperVerEN.sfUpdFldSetStr === undefined || objgs_PaperVerEN.sfUpdFldSetStr === null || objgs_PaperVerEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVerEN.paperVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
objgs_PaperVerEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperVerEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据条件获取是否存在相应的记录？
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
 * @param strWhereCond:条件
 * @returns 是否存在记录？
 **/
export async function gs_PaperVer_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
 * @param lngPaperVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function gs_PaperVer_IsExist(lngPaperVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"PaperVId": lngPaperVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngPaperVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function gs_PaperVer_IsExistAsync(lngPaperVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngPaperVId": lngPaperVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export async function gs_PaperVer_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
//该表在前台TypeScript中，不需要使用Cache;
/*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function gs_PaperVer_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperVer_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperVer_ConstructorName, strThisFuncName);
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
export function gs_PaperVer_GetWebApiUrl(strController: string, strAction: string): string {
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
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;
//该表在前台TypeScript中，不需要使用Cache;

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperVer_CheckPropertyNew(pobjgs_PaperVerEN: clsgs_PaperVerEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperId) === true 
 || pobjgs_PaperVerEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTitle) === true )
{
 throw new Error("(errid:Watl000058)字段[论文标题]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[作文类型Id]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperId) == false && GetStrLen(pobjgs_PaperVerEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperId)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTitle) == false && GetStrLen(pobjgs_PaperVerEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTitle)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.periodical) == false && GetStrLen(pobjgs_PaperVerEN.periodical) > 100)
{
 throw new Error("(errid:Watl000059)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.periodical)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.author) == false && GetStrLen(pobjgs_PaperVerEN.author) > 200)
{
 throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.author)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.researchQuestion) == false && GetStrLen(pobjgs_PaperVerEN.researchQuestion) > 2000)
{
 throw new Error("(errid:Watl000059)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.researchQuestion)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.keyword) == false && GetStrLen(pobjgs_PaperVerEN.keyword) > 1000)
{
 throw new Error("(errid:Watl000059)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.keyword)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureSources) == false && GetStrLen(pobjgs_PaperVerEN.literatureSources) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureSources)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureLink) == false && GetStrLen(pobjgs_PaperVerEN.literatureLink) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureLink)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.uploadfileUrl) == false && GetStrLen(pobjgs_PaperVerEN.uploadfileUrl) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.uploadfileUrl)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.quoteId) == false && GetStrLen(pobjgs_PaperVerEN.quoteId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.quoteId)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.checker) == false && GetStrLen(pobjgs_PaperVerEN.checker) > 20)
{
 throw new Error("(errid:Watl000059)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.checker)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureTypeId) == false && GetStrLen(pobjgs_PaperVerEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureTypeId)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updUser) == false && GetStrLen(pobjgs_PaperVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updUser)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updDate) == false && GetStrLen(pobjgs_PaperVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updDate)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.id_CurrEduCls)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTypeId) == false && GetStrLen(pobjgs_PaperVerEN.paperTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTypeId)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperStatusId) == false && GetStrLen(pobjgs_PaperVerEN.paperStatusId) > 2)
{
 throw new Error("(errid:Watl000059)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperStatusId)(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.memo) == false && GetStrLen(pobjgs_PaperVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.memo)(clsgs_PaperVerBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperVerEN.paperVId && undefined !== pobjgs_PaperVerEN.paperVId && tzDataType.isNumber(pobjgs_PaperVerEN.paperVId) === false)
{
 throw new Error("(errid:Watl000060)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVerEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperId) == false && undefined !== pobjgs_PaperVerEN.paperId && tzDataType.isString(pobjgs_PaperVerEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVerEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTitle) == false && undefined !== pobjgs_PaperVerEN.paperTitle && tzDataType.isString(pobjgs_PaperVerEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVerEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperContent) == false && undefined !== pobjgs_PaperVerEN.paperContent && tzDataType.isString(pobjgs_PaperVerEN.paperContent) === false)
{
 throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVerEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.periodical) == false && undefined !== pobjgs_PaperVerEN.periodical && tzDataType.isString(pobjgs_PaperVerEN.periodical) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊(periodical)]的值:[$(pobjgs_PaperVerEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.author) == false && undefined !== pobjgs_PaperVerEN.author && tzDataType.isString(pobjgs_PaperVerEN.author) === false)
{
 throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjgs_PaperVerEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.researchQuestion) == false && undefined !== pobjgs_PaperVerEN.researchQuestion && tzDataType.isString(pobjgs_PaperVerEN.researchQuestion) === false)
{
 throw new Error("(errid:Watl000060)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVerEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.keyword) == false && undefined !== pobjgs_PaperVerEN.keyword && tzDataType.isString(pobjgs_PaperVerEN.keyword) === false)
{
 throw new Error("(errid:Watl000060)字段[关键字(keyword)]的值:[$(pobjgs_PaperVerEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureSources) == false && undefined !== pobjgs_PaperVerEN.literatureSources && tzDataType.isString(pobjgs_PaperVerEN.literatureSources) === false)
{
 throw new Error("(errid:Watl000060)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVerEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureLink) == false && undefined !== pobjgs_PaperVerEN.literatureLink && tzDataType.isString(pobjgs_PaperVerEN.literatureLink) === false)
{
 throw new Error("(errid:Watl000060)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVerEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVerEN.uploadfileUrl && tzDataType.isString(pobjgs_PaperVerEN.uploadfileUrl) === false)
{
 throw new Error("(errid:Watl000060)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVerEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVerEN.isQuotethesis && undefined !== pobjgs_PaperVerEN.isQuotethesis && tzDataType.isBoolean(pobjgs_PaperVerEN.isQuotethesis) === false)
{
 throw new Error("(errid:Watl000060)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVerEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVerEN.isSubmit && undefined !== pobjgs_PaperVerEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperVerEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVerEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVerEN.isChecked && undefined !== pobjgs_PaperVerEN.isChecked && tzDataType.isBoolean(pobjgs_PaperVerEN.isChecked) === false)
{
 throw new Error("(errid:Watl000060)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVerEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.quoteId) == false && undefined !== pobjgs_PaperVerEN.quoteId && tzDataType.isString(pobjgs_PaperVerEN.quoteId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVerEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.checker) == false && undefined !== pobjgs_PaperVerEN.checker && tzDataType.isString(pobjgs_PaperVerEN.checker) === false)
{
 throw new Error("(errid:Watl000060)字段[审核人(checker)]的值:[$(pobjgs_PaperVerEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureTypeId) == false && undefined !== pobjgs_PaperVerEN.literatureTypeId && tzDataType.isString(pobjgs_PaperVerEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVerEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updUser) == false && undefined !== pobjgs_PaperVerEN.updUser && tzDataType.isString(pobjgs_PaperVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperVerEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updDate) == false && undefined !== pobjgs_PaperVerEN.updDate && tzDataType.isString(pobjgs_PaperVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVerEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVerEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVerEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTypeId) == false && undefined !== pobjgs_PaperVerEN.paperTypeId && tzDataType.isString(pobjgs_PaperVerEN.paperTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVerEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperStatusId) == false && undefined !== pobjgs_PaperVerEN.paperStatusId && tzDataType.isString(pobjgs_PaperVerEN.paperStatusId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVerEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.memo) == false && undefined !== pobjgs_PaperVerEN.memo && tzDataType.isString(pobjgs_PaperVerEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperVerEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperVerEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperVer_CheckProperty4Update (pobjgs_PaperVerEN: clsgs_PaperVerEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperId) == false && GetStrLen(pobjgs_PaperVerEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperId)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTitle) == false && GetStrLen(pobjgs_PaperVerEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTitle)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.periodical) == false && GetStrLen(pobjgs_PaperVerEN.periodical) > 100)
{
 throw new Error("(errid:Watl000062)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.periodical)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.author) == false && GetStrLen(pobjgs_PaperVerEN.author) > 200)
{
 throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.author)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.researchQuestion) == false && GetStrLen(pobjgs_PaperVerEN.researchQuestion) > 2000)
{
 throw new Error("(errid:Watl000062)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.researchQuestion)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.keyword) == false && GetStrLen(pobjgs_PaperVerEN.keyword) > 1000)
{
 throw new Error("(errid:Watl000062)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.keyword)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureSources) == false && GetStrLen(pobjgs_PaperVerEN.literatureSources) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureSources)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureLink) == false && GetStrLen(pobjgs_PaperVerEN.literatureLink) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureLink)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.uploadfileUrl) == false && GetStrLen(pobjgs_PaperVerEN.uploadfileUrl) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.uploadfileUrl)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.quoteId) == false && GetStrLen(pobjgs_PaperVerEN.quoteId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.quoteId)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.checker) == false && GetStrLen(pobjgs_PaperVerEN.checker) > 20)
{
 throw new Error("(errid:Watl000062)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.checker)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureTypeId) == false && GetStrLen(pobjgs_PaperVerEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.literatureTypeId)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updUser) == false && GetStrLen(pobjgs_PaperVerEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updUser)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updDate) == false && GetStrLen(pobjgs_PaperVerEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.updDate)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperVerEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.id_CurrEduCls)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTypeId) == false && GetStrLen(pobjgs_PaperVerEN.paperTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperTypeId)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperStatusId) == false && GetStrLen(pobjgs_PaperVerEN.paperStatusId) > 2)
{
 throw new Error("(errid:Watl000062)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.paperStatusId)(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.memo) == false && GetStrLen(pobjgs_PaperVerEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperVer))!值:$(pobjgs_PaperVerEN.memo)(clsgs_PaperVerBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperVerEN.paperVId && undefined !== pobjgs_PaperVerEN.paperVId && tzDataType.isNumber(pobjgs_PaperVerEN.paperVId) === false)
{
 throw new Error("(errid:Watl000063)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVerEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperId) == false && undefined !== pobjgs_PaperVerEN.paperId && tzDataType.isString(pobjgs_PaperVerEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVerEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTitle) == false && undefined !== pobjgs_PaperVerEN.paperTitle && tzDataType.isString(pobjgs_PaperVerEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVerEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperContent) == false && undefined !== pobjgs_PaperVerEN.paperContent && tzDataType.isString(pobjgs_PaperVerEN.paperContent) === false)
{
 throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVerEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.periodical) == false && undefined !== pobjgs_PaperVerEN.periodical && tzDataType.isString(pobjgs_PaperVerEN.periodical) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊(periodical)]的值:[$(pobjgs_PaperVerEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.author) == false && undefined !== pobjgs_PaperVerEN.author && tzDataType.isString(pobjgs_PaperVerEN.author) === false)
{
 throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjgs_PaperVerEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.researchQuestion) == false && undefined !== pobjgs_PaperVerEN.researchQuestion && tzDataType.isString(pobjgs_PaperVerEN.researchQuestion) === false)
{
 throw new Error("(errid:Watl000063)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVerEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.keyword) == false && undefined !== pobjgs_PaperVerEN.keyword && tzDataType.isString(pobjgs_PaperVerEN.keyword) === false)
{
 throw new Error("(errid:Watl000063)字段[关键字(keyword)]的值:[$(pobjgs_PaperVerEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureSources) == false && undefined !== pobjgs_PaperVerEN.literatureSources && tzDataType.isString(pobjgs_PaperVerEN.literatureSources) === false)
{
 throw new Error("(errid:Watl000063)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVerEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureLink) == false && undefined !== pobjgs_PaperVerEN.literatureLink && tzDataType.isString(pobjgs_PaperVerEN.literatureLink) === false)
{
 throw new Error("(errid:Watl000063)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVerEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVerEN.uploadfileUrl && tzDataType.isString(pobjgs_PaperVerEN.uploadfileUrl) === false)
{
 throw new Error("(errid:Watl000063)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVerEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVerEN.isQuotethesis && undefined !== pobjgs_PaperVerEN.isQuotethesis && tzDataType.isBoolean(pobjgs_PaperVerEN.isQuotethesis) === false)
{
 throw new Error("(errid:Watl000063)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVerEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVerEN.isSubmit && undefined !== pobjgs_PaperVerEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperVerEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVerEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVerEN.isChecked && undefined !== pobjgs_PaperVerEN.isChecked && tzDataType.isBoolean(pobjgs_PaperVerEN.isChecked) === false)
{
 throw new Error("(errid:Watl000063)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVerEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.quoteId) == false && undefined !== pobjgs_PaperVerEN.quoteId && tzDataType.isString(pobjgs_PaperVerEN.quoteId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVerEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.checker) == false && undefined !== pobjgs_PaperVerEN.checker && tzDataType.isString(pobjgs_PaperVerEN.checker) === false)
{
 throw new Error("(errid:Watl000063)字段[审核人(checker)]的值:[$(pobjgs_PaperVerEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.literatureTypeId) == false && undefined !== pobjgs_PaperVerEN.literatureTypeId && tzDataType.isString(pobjgs_PaperVerEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVerEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updUser) == false && undefined !== pobjgs_PaperVerEN.updUser && tzDataType.isString(pobjgs_PaperVerEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperVerEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.updDate) == false && undefined !== pobjgs_PaperVerEN.updDate && tzDataType.isString(pobjgs_PaperVerEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVerEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVerEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperVerEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVerEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperTypeId) == false && undefined !== pobjgs_PaperVerEN.paperTypeId && tzDataType.isString(pobjgs_PaperVerEN.paperTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVerEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.paperStatusId) == false && undefined !== pobjgs_PaperVerEN.paperStatusId && tzDataType.isString(pobjgs_PaperVerEN.paperStatusId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVerEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVerEN.memo) == false && undefined !== pobjgs_PaperVerEN.memo && tzDataType.isString(pobjgs_PaperVerEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperVerEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperVer))!(clsgs_PaperVerBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PaperVerEN.paperVId 
 || pobjgs_PaperVerEN.paperVId != null && pobjgs_PaperVerEN.paperVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[PaperVId]不能为空(In 论文历史版本表)!(clsgs_PaperVerBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperVerEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperVer_GetJSONStrByObj (pobjgs_PaperVerEN: clsgs_PaperVerEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperVerEN.sfUpdFldSetStr = pobjgs_PaperVerEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperVerEN);
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
export function gs_PaperVer_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperVerEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperVerObjLst = new Array<clsgs_PaperVerEN>();
if (strJSON === "")
{
return arrgs_PaperVerObjLst;
}
try
{
arrgs_PaperVerObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperVerObjLst;
}
return arrgs_PaperVerObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperVerObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperVer_GetObjLstByJSONObjLst (arrgs_PaperVerObjLstS: Array<clsgs_PaperVerEN>): Array<clsgs_PaperVerEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperVerObjLst = new Array<clsgs_PaperVerEN>();
for (const objInFor of arrgs_PaperVerObjLstS) {
const obj1 = gs_PaperVer_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperVerObjLst.push(obj1);
}
return arrgs_PaperVerObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperVer_GetObjByJSONStr (strJSON: string): clsgs_PaperVerEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperVerEN = new clsgs_PaperVerEN();
if (strJSON === "")
{
return pobjgs_PaperVerEN;
}
try
{
pobjgs_PaperVerEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperVerEN;
}
return pobjgs_PaperVerEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperVer_GetCombineCondition(objgs_PaperVer_Cond: clsgs_PaperVerEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_PaperVId) == true)
{
const strComparisonOp_PaperVId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_PaperVId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperVerEN.con_PaperVId, objgs_PaperVer_Cond.paperVId, strComparisonOp_PaperVId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_PaperId, objgs_PaperVer_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_PaperTitle, objgs_PaperVer_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_Periodical, objgs_PaperVer_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_Author) == true)
{
const strComparisonOp_Author:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_Author, objgs_PaperVer_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_ResearchQuestion, objgs_PaperVer_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_Keyword, objgs_PaperVer_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_LiteratureSources, objgs_PaperVer_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_LiteratureLink, objgs_PaperVer_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_UploadfileUrl, objgs_PaperVer_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_IsQuotethesis) == true)
{
if (objgs_PaperVer_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_IsSubmit) == true)
{
if (objgs_PaperVer_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_IsChecked) == true)
{
if (objgs_PaperVer_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVerEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVerEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_QuoteId) == true)
{
const strComparisonOp_QuoteId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_QuoteId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_QuoteId, objgs_PaperVer_Cond.quoteId, strComparisonOp_QuoteId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_Checker, objgs_PaperVer_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_LiteratureTypeId, objgs_PaperVer_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_UpdUser, objgs_PaperVer_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_UpdDate, objgs_PaperVer_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_id_CurrEduCls, objgs_PaperVer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_PaperTypeId, objgs_PaperVer_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_PaperStatusId) == true)
{
const strComparisonOp_PaperStatusId:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_PaperStatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_PaperStatusId, objgs_PaperVer_Cond.paperStatusId, strComparisonOp_PaperStatusId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperVer_Cond.dicFldComparisonOp, clsgs_PaperVerEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperVer_Cond.dicFldComparisonOp[clsgs_PaperVerEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVerEN.con_Memo, objgs_PaperVer_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPaperVId: PaperVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperVer_GetUniCondStr_PaperVId(objgs_PaperVerEN: clsgs_PaperVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperVId = '{0}'", objgs_PaperVerEN.paperVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperVer(论文历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPaperVId: PaperVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperVer_GetUniCondStr4Update_PaperVId(objgs_PaperVerEN: clsgs_PaperVerEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperVId <> '{0}'", objgs_PaperVerEN.paperVId);
 strWhereCond +=  Format(" and PaperVId = '{0}'", objgs_PaperVerEN.paperVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperVerENS:源对象
 * @param objgs_PaperVerENT:目标对象
*/
export function gs_PaperVer_CopyObjTo(objgs_PaperVerENS: clsgs_PaperVerEN , objgs_PaperVerENT: clsgs_PaperVerEN ): void 
{
objgs_PaperVerENT.paperVId = objgs_PaperVerENS.paperVId; //PaperVId
objgs_PaperVerENT.paperId = objgs_PaperVerENS.paperId; //论文Id
objgs_PaperVerENT.paperTitle = objgs_PaperVerENS.paperTitle; //论文标题
objgs_PaperVerENT.paperContent = objgs_PaperVerENS.paperContent; //主题内容
objgs_PaperVerENT.periodical = objgs_PaperVerENS.periodical; //期刊
objgs_PaperVerENT.author = objgs_PaperVerENS.author; //作者
objgs_PaperVerENT.researchQuestion = objgs_PaperVerENS.researchQuestion; //研究问题
objgs_PaperVerENT.keyword = objgs_PaperVerENS.keyword; //关键字
objgs_PaperVerENT.literatureSources = objgs_PaperVerENS.literatureSources; //文献来源
objgs_PaperVerENT.literatureLink = objgs_PaperVerENS.literatureLink; //文献链接
objgs_PaperVerENT.uploadfileUrl = objgs_PaperVerENS.uploadfileUrl; //文件地址
objgs_PaperVerENT.isQuotethesis = objgs_PaperVerENS.isQuotethesis; //是否引用论文
objgs_PaperVerENT.isSubmit = objgs_PaperVerENS.isSubmit; //是否提交
objgs_PaperVerENT.isChecked = objgs_PaperVerENS.isChecked; //是否检查
objgs_PaperVerENT.quoteId = objgs_PaperVerENS.quoteId; //引用Id
objgs_PaperVerENT.checker = objgs_PaperVerENS.checker; //审核人
objgs_PaperVerENT.literatureTypeId = objgs_PaperVerENS.literatureTypeId; //作文类型Id
objgs_PaperVerENT.updUser = objgs_PaperVerENS.updUser; //修改人
objgs_PaperVerENT.updDate = objgs_PaperVerENS.updDate; //修改日期
objgs_PaperVerENT.id_CurrEduCls = objgs_PaperVerENS.id_CurrEduCls; //教学班流水号
objgs_PaperVerENT.paperTypeId = objgs_PaperVerENS.paperTypeId; //论文类型Id
objgs_PaperVerENT.paperStatusId = objgs_PaperVerENS.paperStatusId; //论文状态Id
objgs_PaperVerENT.memo = objgs_PaperVerENS.memo; //备注
objgs_PaperVerENT.sfUpdFldSetStr = objgs_PaperVerENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperVerENS:源对象
 * @param objgs_PaperVerENT:目标对象
*/
export function gs_PaperVer_GetObjFromJsonObj(objgs_PaperVerENS: clsgs_PaperVerEN): clsgs_PaperVerEN 
{
 const objgs_PaperVerENT: clsgs_PaperVerEN = new clsgs_PaperVerEN();
ObjectAssign(objgs_PaperVerENT, objgs_PaperVerENS);
 return objgs_PaperVerENT;
}