
 /**
 * 类名:clsgs_PaperVWApi
 * 表名:gs_PaperV(01120678)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:46
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
 * 论文历史版本表(gs_PaperV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsgs_PaperVEN } from "../../L0_Entity/GraduateEduPaper/clsgs_PaperVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const gs_PaperV_Controller = "gs_PaperVApi";
 export const gs_PaperV_ConstructorName = "gs_PaperV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperVId:关键字
 * @returns 对象
 **/
export async function gs_PaperV_GetObjByPaperVIdAsync(lngPaperVId: number): Promise<clsgs_PaperVEN>  
{
const strThisFuncName = "GetObjByPaperVIdAsync";

if (lngPaperVId == 0)
{
  const strMsg = Format("参数:[lngPaperVId]不能为空！(In GetObjByPaperVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperVId";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperV = gs_PaperV_GetObjFromJsonObj(returnObj);
return objgs_PaperV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function gs_PaperV_SortFun_Defa(a:clsgs_PaperVEN , b:clsgs_PaperVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.paperVId-b.paperVId;
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
export function gs_PaperV_SortFun_Defa_2Fld(a:clsgs_PaperVEN , b:clsgs_PaperVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.paperId == b.paperId) return a.paperTitle.localeCompare(b.paperTitle);
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
export function gs_PaperV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsgs_PaperVEN.con_PaperVId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperVId-b.paperVId;
}
case clsgs_PaperVEN.con_PaperId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsgs_PaperVEN.con_PaperTitle:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsgs_PaperVEN.con_PaperContent:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsgs_PaperVEN.con_Periodical:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsgs_PaperVEN.con_Author:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.author.localeCompare(b.author);
}
case clsgs_PaperVEN.con_ResearchQuestion:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsgs_PaperVEN.con_Keyword:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsgs_PaperVEN.con_LiteratureSources:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsgs_PaperVEN.con_LiteratureLink:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsgs_PaperVEN.con_UploadfileUrl:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsgs_PaperVEN.con_IsQuotethesis:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_IsSubmit:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_IsChecked:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_QuoteId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.quoteId.localeCompare(b.quoteId);
}
case clsgs_PaperVEN.con_Checker:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.checker.localeCompare(b.checker);
}
case clsgs_PaperVEN.con_LiteratureTypeId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsgs_PaperVEN.con_UpdUser:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsgs_PaperVEN.con_UpdDate:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsgs_PaperVEN.con_id_CurrEduCls:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsgs_PaperVEN.con_PaperTypeId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsgs_PaperVEN.con_PaperStatusId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.paperStatusId.localeCompare(b.paperStatusId);
}
case clsgs_PaperVEN.con_Memo:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperV]中不存在！(in ${ gs_PaperV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsgs_PaperVEN.con_PaperVId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperVId-a.paperVId;
}
case clsgs_PaperVEN.con_PaperId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsgs_PaperVEN.con_PaperTitle:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsgs_PaperVEN.con_PaperContent:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsgs_PaperVEN.con_Periodical:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsgs_PaperVEN.con_Author:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.author.localeCompare(a.author);
}
case clsgs_PaperVEN.con_ResearchQuestion:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsgs_PaperVEN.con_Keyword:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsgs_PaperVEN.con_LiteratureSources:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsgs_PaperVEN.con_LiteratureLink:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsgs_PaperVEN.con_UploadfileUrl:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsgs_PaperVEN.con_IsQuotethesis:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_IsSubmit:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_IsChecked:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsgs_PaperVEN.con_QuoteId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.quoteId.localeCompare(a.quoteId);
}
case clsgs_PaperVEN.con_Checker:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.checker.localeCompare(a.checker);
}
case clsgs_PaperVEN.con_LiteratureTypeId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsgs_PaperVEN.con_UpdUser:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsgs_PaperVEN.con_UpdDate:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsgs_PaperVEN.con_id_CurrEduCls:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsgs_PaperVEN.con_PaperTypeId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsgs_PaperVEN.con_PaperStatusId:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.paperStatusId.localeCompare(a.paperStatusId);
}
case clsgs_PaperVEN.con_Memo:
return (a: clsgs_PaperVEN, b: clsgs_PaperVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperV]中不存在！(in ${ gs_PaperV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsgs_PaperVEN.con_PaperVId:
return (obj: clsgs_PaperVEN) => {
return obj.paperVId === value;
}
case clsgs_PaperVEN.con_PaperId:
return (obj: clsgs_PaperVEN) => {
return obj.paperId === value;
}
case clsgs_PaperVEN.con_PaperTitle:
return (obj: clsgs_PaperVEN) => {
return obj.paperTitle === value;
}
case clsgs_PaperVEN.con_PaperContent:
return (obj: clsgs_PaperVEN) => {
return obj.paperContent === value;
}
case clsgs_PaperVEN.con_Periodical:
return (obj: clsgs_PaperVEN) => {
return obj.periodical === value;
}
case clsgs_PaperVEN.con_Author:
return (obj: clsgs_PaperVEN) => {
return obj.author === value;
}
case clsgs_PaperVEN.con_ResearchQuestion:
return (obj: clsgs_PaperVEN) => {
return obj.researchQuestion === value;
}
case clsgs_PaperVEN.con_Keyword:
return (obj: clsgs_PaperVEN) => {
return obj.keyword === value;
}
case clsgs_PaperVEN.con_LiteratureSources:
return (obj: clsgs_PaperVEN) => {
return obj.literatureSources === value;
}
case clsgs_PaperVEN.con_LiteratureLink:
return (obj: clsgs_PaperVEN) => {
return obj.literatureLink === value;
}
case clsgs_PaperVEN.con_UploadfileUrl:
return (obj: clsgs_PaperVEN) => {
return obj.uploadfileUrl === value;
}
case clsgs_PaperVEN.con_IsQuotethesis:
return (obj: clsgs_PaperVEN) => {
return obj.isQuotethesis === value;
}
case clsgs_PaperVEN.con_IsSubmit:
return (obj: clsgs_PaperVEN) => {
return obj.isSubmit === value;
}
case clsgs_PaperVEN.con_IsChecked:
return (obj: clsgs_PaperVEN) => {
return obj.isChecked === value;
}
case clsgs_PaperVEN.con_QuoteId:
return (obj: clsgs_PaperVEN) => {
return obj.quoteId === value;
}
case clsgs_PaperVEN.con_Checker:
return (obj: clsgs_PaperVEN) => {
return obj.checker === value;
}
case clsgs_PaperVEN.con_LiteratureTypeId:
return (obj: clsgs_PaperVEN) => {
return obj.literatureTypeId === value;
}
case clsgs_PaperVEN.con_UpdUser:
return (obj: clsgs_PaperVEN) => {
return obj.updUser === value;
}
case clsgs_PaperVEN.con_UpdDate:
return (obj: clsgs_PaperVEN) => {
return obj.updDate === value;
}
case clsgs_PaperVEN.con_id_CurrEduCls:
return (obj: clsgs_PaperVEN) => {
return obj.id_CurrEduCls === value;
}
case clsgs_PaperVEN.con_PaperTypeId:
return (obj: clsgs_PaperVEN) => {
return obj.paperTypeId === value;
}
case clsgs_PaperVEN.con_PaperStatusId:
return (obj: clsgs_PaperVEN) => {
return obj.paperStatusId === value;
}
case clsgs_PaperVEN.con_Memo:
return (obj: clsgs_PaperVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[gs_PaperV]中不存在！(in ${ gs_PaperV_ConstructorName}.${ strThisFuncName})`;
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
export async function gs_PaperV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetFirstObjAsync(strWhereCond: string): Promise<clsgs_PaperVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objgs_PaperV = gs_PaperV_GetObjFromJsonObj(returnObj);
return objgs_PaperV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetObjLstByPaperVIdLstAsync(arrPaperVId: Array<string>): Promise<Array<clsgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
const strAction = "GetObjLstByPaperVIdLst";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsgs_PaperVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", gs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = gs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_DelRecordAsync(lngPaperVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngPaperVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngPaperVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_Delgs_PaperVsAsync(arrPaperVId: Array<string>): Promise<number> 
{
const strThisFuncName = "Delgs_PaperVsAsync";
const strAction = "Delgs_PaperVs";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_Delgs_PaperVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "Delgs_PaperVsByCondAsync";
const strAction = "Delgs_PaperVsByCond";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function gs_PaperV_AddNewRecordAsync(objgs_PaperVEN: clsgs_PaperVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objgs_PaperVEN);
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function gs_PaperV_AddNewRecordWithReturnKeyAsync(objgs_PaperVEN: clsgs_PaperVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function gs_PaperV_AddNewRecordWithReturnKey(objgs_PaperVEN: clsgs_PaperVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objgs_PaperVEN.paperVId === null || objgs_PaperVEN.paperVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function gs_PaperV_UpdateRecordAsync(objgs_PaperVEN: clsgs_PaperVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objgs_PaperVEN.sf_UpdFldSetStr === undefined || objgs_PaperVEN.sf_UpdFldSetStr === null || objgs_PaperVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVEN.paperVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objgs_PaperVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
 * @param objgs_PaperVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function gs_PaperV_UpdateWithConditionAsync(objgs_PaperVEN: clsgs_PaperVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objgs_PaperVEN.sf_UpdFldSetStr === undefined || objgs_PaperVEN.sf_UpdFldSetStr === null || objgs_PaperVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperVEN.paperVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
objgs_PaperVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objgs_PaperVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_IsExist(lngPaperVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_IsExistAsync(lngPaperVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export async function gs_PaperV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(gs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, gs_PaperV_ConstructorName, strThisFuncName);
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
export function gs_PaperV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function gs_PaperV_CheckPropertyNew(pobjgs_PaperVEN: clsgs_PaperVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjgs_PaperVEN.paperId) === true 
 || pobjgs_PaperVEN.paperId.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文历史版本表)!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTitle) === true )
{
 throw new Error("(errid:Watl000058)字段[论文标题]不能为空(In 论文历史版本表)!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureTypeId) === true )
{
 throw new Error("(errid:Watl000058)字段[作文类型Id]不能为空(In 论文历史版本表)!(clsgs_PaperVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperVEN.paperId) == false && GetStrLen(pobjgs_PaperVEN.paperId) > 8)
{
 throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperId)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTitle) == false && GetStrLen(pobjgs_PaperVEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000059)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperTitle)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.periodical) == false && GetStrLen(pobjgs_PaperVEN.periodical) > 100)
{
 throw new Error("(errid:Watl000059)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.periodical)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.author) == false && GetStrLen(pobjgs_PaperVEN.author) > 200)
{
 throw new Error("(errid:Watl000059)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.author)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.researchQuestion) == false && GetStrLen(pobjgs_PaperVEN.researchQuestion) > 2000)
{
 throw new Error("(errid:Watl000059)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.researchQuestion)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.keyword) == false && GetStrLen(pobjgs_PaperVEN.keyword) > 1000)
{
 throw new Error("(errid:Watl000059)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.keyword)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureSources) == false && GetStrLen(pobjgs_PaperVEN.literatureSources) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureSources)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureLink) == false && GetStrLen(pobjgs_PaperVEN.literatureLink) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureLink)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.uploadfileUrl) == false && GetStrLen(pobjgs_PaperVEN.uploadfileUrl) > 1000)
{
 throw new Error("(errid:Watl000059)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.uploadfileUrl)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.quoteId) == false && GetStrLen(pobjgs_PaperVEN.quoteId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.quoteId)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.checker) == false && GetStrLen(pobjgs_PaperVEN.checker) > 20)
{
 throw new Error("(errid:Watl000059)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.checker)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureTypeId) == false && GetStrLen(pobjgs_PaperVEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureTypeId)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updUser) == false && GetStrLen(pobjgs_PaperVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.updUser)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updDate) == false && GetStrLen(pobjgs_PaperVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.updDate)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.id_CurrEduCls)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTypeId) == false && GetStrLen(pobjgs_PaperVEN.paperTypeId) > 2)
{
 throw new Error("(errid:Watl000059)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperTypeId)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperStatusId) == false && GetStrLen(pobjgs_PaperVEN.paperStatusId) > 2)
{
 throw new Error("(errid:Watl000059)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperStatusId)(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.memo) == false && GetStrLen(pobjgs_PaperVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.memo)(clsgs_PaperVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperVEN.paperVId && undefined !== pobjgs_PaperVEN.paperVId && tzDataType.isNumber(pobjgs_PaperVEN.paperVId) === false)
{
 throw new Error("(errid:Watl000060)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperId) == false && undefined !== pobjgs_PaperVEN.paperId && tzDataType.isString(pobjgs_PaperVEN.paperId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTitle) == false && undefined !== pobjgs_PaperVEN.paperTitle && tzDataType.isString(pobjgs_PaperVEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000060)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperContent) == false && undefined !== pobjgs_PaperVEN.paperContent && tzDataType.isString(pobjgs_PaperVEN.paperContent) === false)
{
 throw new Error("(errid:Watl000060)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.periodical) == false && undefined !== pobjgs_PaperVEN.periodical && tzDataType.isString(pobjgs_PaperVEN.periodical) === false)
{
 throw new Error("(errid:Watl000060)字段[期刊(periodical)]的值:[$(pobjgs_PaperVEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.author) == false && undefined !== pobjgs_PaperVEN.author && tzDataType.isString(pobjgs_PaperVEN.author) === false)
{
 throw new Error("(errid:Watl000060)字段[作者(author)]的值:[$(pobjgs_PaperVEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.researchQuestion) == false && undefined !== pobjgs_PaperVEN.researchQuestion && tzDataType.isString(pobjgs_PaperVEN.researchQuestion) === false)
{
 throw new Error("(errid:Watl000060)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.keyword) == false && undefined !== pobjgs_PaperVEN.keyword && tzDataType.isString(pobjgs_PaperVEN.keyword) === false)
{
 throw new Error("(errid:Watl000060)字段[关键字(keyword)]的值:[$(pobjgs_PaperVEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureSources) == false && undefined !== pobjgs_PaperVEN.literatureSources && tzDataType.isString(pobjgs_PaperVEN.literatureSources) === false)
{
 throw new Error("(errid:Watl000060)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureLink) == false && undefined !== pobjgs_PaperVEN.literatureLink && tzDataType.isString(pobjgs_PaperVEN.literatureLink) === false)
{
 throw new Error("(errid:Watl000060)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVEN.uploadfileUrl && tzDataType.isString(pobjgs_PaperVEN.uploadfileUrl) === false)
{
 throw new Error("(errid:Watl000060)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVEN.isQuotethesis && undefined !== pobjgs_PaperVEN.isQuotethesis && tzDataType.isBoolean(pobjgs_PaperVEN.isQuotethesis) === false)
{
 throw new Error("(errid:Watl000060)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVEN.isSubmit && undefined !== pobjgs_PaperVEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (null != pobjgs_PaperVEN.isChecked && undefined !== pobjgs_PaperVEN.isChecked && tzDataType.isBoolean(pobjgs_PaperVEN.isChecked) === false)
{
 throw new Error("(errid:Watl000060)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.quoteId) == false && undefined !== pobjgs_PaperVEN.quoteId && tzDataType.isString(pobjgs_PaperVEN.quoteId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.checker) == false && undefined !== pobjgs_PaperVEN.checker && tzDataType.isString(pobjgs_PaperVEN.checker) === false)
{
 throw new Error("(errid:Watl000060)字段[审核人(checker)]的值:[$(pobjgs_PaperVEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureTypeId) == false && undefined !== pobjgs_PaperVEN.literatureTypeId && tzDataType.isString(pobjgs_PaperVEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updUser) == false && undefined !== pobjgs_PaperVEN.updUser && tzDataType.isString(pobjgs_PaperVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperVEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updDate) == false && undefined !== pobjgs_PaperVEN.updDate && tzDataType.isString(pobjgs_PaperVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTypeId) == false && undefined !== pobjgs_PaperVEN.paperTypeId && tzDataType.isString(pobjgs_PaperVEN.paperTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperStatusId) == false && undefined !== pobjgs_PaperVEN.paperStatusId && tzDataType.isString(pobjgs_PaperVEN.paperStatusId) === false)
{
 throw new Error("(errid:Watl000060)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.memo) == false && undefined !== pobjgs_PaperVEN.memo && tzDataType.isString(pobjgs_PaperVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperVEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjgs_PaperVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function gs_PaperV_CheckProperty4Update (pobjgs_PaperVEN: clsgs_PaperVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjgs_PaperVEN.paperId) == false && GetStrLen(pobjgs_PaperVEN.paperId) > 8)
{
 throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperId)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTitle) == false && GetStrLen(pobjgs_PaperVEN.paperTitle) > 500)
{
 throw new Error("(errid:Watl000062)字段[论文标题(paperTitle)]的长度不能超过500(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperTitle)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.periodical) == false && GetStrLen(pobjgs_PaperVEN.periodical) > 100)
{
 throw new Error("(errid:Watl000062)字段[期刊(periodical)]的长度不能超过100(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.periodical)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.author) == false && GetStrLen(pobjgs_PaperVEN.author) > 200)
{
 throw new Error("(errid:Watl000062)字段[作者(author)]的长度不能超过200(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.author)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.researchQuestion) == false && GetStrLen(pobjgs_PaperVEN.researchQuestion) > 2000)
{
 throw new Error("(errid:Watl000062)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.researchQuestion)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.keyword) == false && GetStrLen(pobjgs_PaperVEN.keyword) > 1000)
{
 throw new Error("(errid:Watl000062)字段[关键字(keyword)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.keyword)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureSources) == false && GetStrLen(pobjgs_PaperVEN.literatureSources) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文献来源(literatureSources)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureSources)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureLink) == false && GetStrLen(pobjgs_PaperVEN.literatureLink) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文献链接(literatureLink)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureLink)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.uploadfileUrl) == false && GetStrLen(pobjgs_PaperVEN.uploadfileUrl) > 1000)
{
 throw new Error("(errid:Watl000062)字段[文件地址(uploadfileUrl)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.uploadfileUrl)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.quoteId) == false && GetStrLen(pobjgs_PaperVEN.quoteId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(quoteId)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.quoteId)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.checker) == false && GetStrLen(pobjgs_PaperVEN.checker) > 20)
{
 throw new Error("(errid:Watl000062)字段[审核人(checker)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.checker)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureTypeId) == false && GetStrLen(pobjgs_PaperVEN.literatureTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.literatureTypeId)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updUser) == false && GetStrLen(pobjgs_PaperVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.updUser)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updDate) == false && GetStrLen(pobjgs_PaperVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.updDate)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.id_CurrEduCls) == false && GetStrLen(pobjgs_PaperVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.id_CurrEduCls)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTypeId) == false && GetStrLen(pobjgs_PaperVEN.paperTypeId) > 2)
{
 throw new Error("(errid:Watl000062)字段[论文类型Id(paperTypeId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperTypeId)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperStatusId) == false && GetStrLen(pobjgs_PaperVEN.paperStatusId) > 2)
{
 throw new Error("(errid:Watl000062)字段[论文状态Id(paperStatusId)]的长度不能超过2(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.paperStatusId)(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.memo) == false && GetStrLen(pobjgs_PaperVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文历史版本表(gs_PaperV))!值:$(pobjgs_PaperVEN.memo)(clsgs_PaperVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjgs_PaperVEN.paperVId && undefined !== pobjgs_PaperVEN.paperVId && tzDataType.isNumber(pobjgs_PaperVEN.paperVId) === false)
{
 throw new Error("(errid:Watl000063)字段[PaperVId(paperVId)]的值:[$(pobjgs_PaperVEN.paperVId)], 非法，应该为数值型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperId) == false && undefined !== pobjgs_PaperVEN.paperId && tzDataType.isString(pobjgs_PaperVEN.paperId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperVEN.paperId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTitle) == false && undefined !== pobjgs_PaperVEN.paperTitle && tzDataType.isString(pobjgs_PaperVEN.paperTitle) === false)
{
 throw new Error("(errid:Watl000063)字段[论文标题(paperTitle)]的值:[$(pobjgs_PaperVEN.paperTitle)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperContent) == false && undefined !== pobjgs_PaperVEN.paperContent && tzDataType.isString(pobjgs_PaperVEN.paperContent) === false)
{
 throw new Error("(errid:Watl000063)字段[主题内容(paperContent)]的值:[$(pobjgs_PaperVEN.paperContent)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.periodical) == false && undefined !== pobjgs_PaperVEN.periodical && tzDataType.isString(pobjgs_PaperVEN.periodical) === false)
{
 throw new Error("(errid:Watl000063)字段[期刊(periodical)]的值:[$(pobjgs_PaperVEN.periodical)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.author) == false && undefined !== pobjgs_PaperVEN.author && tzDataType.isString(pobjgs_PaperVEN.author) === false)
{
 throw new Error("(errid:Watl000063)字段[作者(author)]的值:[$(pobjgs_PaperVEN.author)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.researchQuestion) == false && undefined !== pobjgs_PaperVEN.researchQuestion && tzDataType.isString(pobjgs_PaperVEN.researchQuestion) === false)
{
 throw new Error("(errid:Watl000063)字段[研究问题(researchQuestion)]的值:[$(pobjgs_PaperVEN.researchQuestion)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.keyword) == false && undefined !== pobjgs_PaperVEN.keyword && tzDataType.isString(pobjgs_PaperVEN.keyword) === false)
{
 throw new Error("(errid:Watl000063)字段[关键字(keyword)]的值:[$(pobjgs_PaperVEN.keyword)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureSources) == false && undefined !== pobjgs_PaperVEN.literatureSources && tzDataType.isString(pobjgs_PaperVEN.literatureSources) === false)
{
 throw new Error("(errid:Watl000063)字段[文献来源(literatureSources)]的值:[$(pobjgs_PaperVEN.literatureSources)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureLink) == false && undefined !== pobjgs_PaperVEN.literatureLink && tzDataType.isString(pobjgs_PaperVEN.literatureLink) === false)
{
 throw new Error("(errid:Watl000063)字段[文献链接(literatureLink)]的值:[$(pobjgs_PaperVEN.literatureLink)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.uploadfileUrl) == false && undefined !== pobjgs_PaperVEN.uploadfileUrl && tzDataType.isString(pobjgs_PaperVEN.uploadfileUrl) === false)
{
 throw new Error("(errid:Watl000063)字段[文件地址(uploadfileUrl)]的值:[$(pobjgs_PaperVEN.uploadfileUrl)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVEN.isQuotethesis && undefined !== pobjgs_PaperVEN.isQuotethesis && tzDataType.isBoolean(pobjgs_PaperVEN.isQuotethesis) === false)
{
 throw new Error("(errid:Watl000063)字段[是否引用论文(isQuotethesis)]的值:[$(pobjgs_PaperVEN.isQuotethesis)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVEN.isSubmit && undefined !== pobjgs_PaperVEN.isSubmit && tzDataType.isBoolean(pobjgs_PaperVEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjgs_PaperVEN.isSubmit)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (null != pobjgs_PaperVEN.isChecked && undefined !== pobjgs_PaperVEN.isChecked && tzDataType.isBoolean(pobjgs_PaperVEN.isChecked) === false)
{
 throw new Error("(errid:Watl000063)字段[是否检查(isChecked)]的值:[$(pobjgs_PaperVEN.isChecked)], 非法，应该为布尔型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.quoteId) == false && undefined !== pobjgs_PaperVEN.quoteId && tzDataType.isString(pobjgs_PaperVEN.quoteId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(quoteId)]的值:[$(pobjgs_PaperVEN.quoteId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.checker) == false && undefined !== pobjgs_PaperVEN.checker && tzDataType.isString(pobjgs_PaperVEN.checker) === false)
{
 throw new Error("(errid:Watl000063)字段[审核人(checker)]的值:[$(pobjgs_PaperVEN.checker)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.literatureTypeId) == false && undefined !== pobjgs_PaperVEN.literatureTypeId && tzDataType.isString(pobjgs_PaperVEN.literatureTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjgs_PaperVEN.literatureTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updUser) == false && undefined !== pobjgs_PaperVEN.updUser && tzDataType.isString(pobjgs_PaperVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperVEN.updUser)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.updDate) == false && undefined !== pobjgs_PaperVEN.updDate && tzDataType.isString(pobjgs_PaperVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperVEN.updDate)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperVEN.id_CurrEduCls && tzDataType.isString(pobjgs_PaperVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperVEN.id_CurrEduCls)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperTypeId) == false && undefined !== pobjgs_PaperVEN.paperTypeId && tzDataType.isString(pobjgs_PaperVEN.paperTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文类型Id(paperTypeId)]的值:[$(pobjgs_PaperVEN.paperTypeId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.paperStatusId) == false && undefined !== pobjgs_PaperVEN.paperStatusId && tzDataType.isString(pobjgs_PaperVEN.paperStatusId) === false)
{
 throw new Error("(errid:Watl000063)字段[论文状态Id(paperStatusId)]的值:[$(pobjgs_PaperVEN.paperStatusId)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjgs_PaperVEN.memo) == false && undefined !== pobjgs_PaperVEN.memo && tzDataType.isString(pobjgs_PaperVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperVEN.memo)], 非法，应该为字符型(In 论文历史版本表(gs_PaperV))!(clsgs_PaperVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjgs_PaperVEN.paperVId 
 || pobjgs_PaperVEN.paperVId != null && pobjgs_PaperVEN.paperVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[PaperVId]不能为空(In 论文历史版本表)!(clsgs_PaperVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjgs_PaperVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperV_GetJSONStrByObj (pobjgs_PaperVEN: clsgs_PaperVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjgs_PaperVEN.sf_UpdFldSetStr = pobjgs_PaperVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjgs_PaperVEN);
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
export function gs_PaperV_GetObjLstByJSONStr (strJSON: string): Array<clsgs_PaperVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrgs_PaperVObjLst = new Array<clsgs_PaperVEN>();
if (strJSON === "")
{
return arrgs_PaperVObjLst;
}
try
{
arrgs_PaperVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrgs_PaperVObjLst;
}
return arrgs_PaperVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrgs_PaperVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function gs_PaperV_GetObjLstByJSONObjLst (arrgs_PaperVObjLstS: Array<clsgs_PaperVEN>): Array<clsgs_PaperVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrgs_PaperVObjLst = new Array<clsgs_PaperVEN>();
for (const objInFor of arrgs_PaperVObjLstS) {
const obj1 = gs_PaperV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrgs_PaperVObjLst.push(obj1);
}
return arrgs_PaperVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function gs_PaperV_GetObjByJSONStr (strJSON: string): clsgs_PaperVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjgs_PaperVEN = new clsgs_PaperVEN();
if (strJSON === "")
{
return pobjgs_PaperVEN;
}
try
{
pobjgs_PaperVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjgs_PaperVEN;
}
return pobjgs_PaperVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function gs_PaperV_GetCombineCondition(objgs_PaperV_Cond: clsgs_PaperVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_PaperVId) == true)
{
const strComparisonOp_PaperVId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_PaperVId];
strWhereCond += Format(" And {0} {2} {1}", clsgs_PaperVEN.con_PaperVId, objgs_PaperV_Cond.paperVId, strComparisonOp_PaperVId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_PaperId, objgs_PaperV_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_PaperTitle, objgs_PaperV_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_Periodical, objgs_PaperV_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_Author) == true)
{
const strComparisonOp_Author:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_Author, objgs_PaperV_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_ResearchQuestion, objgs_PaperV_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_Keyword, objgs_PaperV_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_LiteratureSources, objgs_PaperV_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_LiteratureLink, objgs_PaperV_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_UploadfileUrl, objgs_PaperV_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_IsQuotethesis) == true)
{
if (objgs_PaperV_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_IsSubmit) == true)
{
if (objgs_PaperV_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_IsChecked) == true)
{
if (objgs_PaperV_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsgs_PaperVEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsgs_PaperVEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_QuoteId) == true)
{
const strComparisonOp_QuoteId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_QuoteId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_QuoteId, objgs_PaperV_Cond.quoteId, strComparisonOp_QuoteId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_Checker, objgs_PaperV_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_LiteratureTypeId, objgs_PaperV_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_UpdUser, objgs_PaperV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_UpdDate, objgs_PaperV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_id_CurrEduCls, objgs_PaperV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_PaperTypeId, objgs_PaperV_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_PaperStatusId) == true)
{
const strComparisonOp_PaperStatusId:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_PaperStatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_PaperStatusId, objgs_PaperV_Cond.paperStatusId, strComparisonOp_PaperStatusId);
}
if (Object.prototype.hasOwnProperty.call(objgs_PaperV_Cond.dicFldComparisonOp, clsgs_PaperVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objgs_PaperV_Cond.dicFldComparisonOp[clsgs_PaperVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsgs_PaperVEN.con_Memo, objgs_PaperV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperV(论文历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngPaperVId: PaperVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperV_GetUniCondStr_PaperVId(objgs_PaperVEN: clsgs_PaperVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and PaperVId = '{0}'", objgs_PaperVEN.paperVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--gs_PaperV(论文历史版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngPaperVId: PaperVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function gs_PaperV_GetUniCondStr4Update_PaperVId(objgs_PaperVEN: clsgs_PaperVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and PaperVId <> '{0}'", objgs_PaperVEN.paperVId);
 strWhereCond +=  Format(" and PaperVId = '{0}'", objgs_PaperVEN.paperVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objgs_PaperVENS:源对象
 * @param objgs_PaperVENT:目标对象
*/
export function gs_PaperV_CopyObjTo(objgs_PaperVENS: clsgs_PaperVEN , objgs_PaperVENT: clsgs_PaperVEN ): void 
{
objgs_PaperVENT.paperVId = objgs_PaperVENS.paperVId; //PaperVId
objgs_PaperVENT.paperId = objgs_PaperVENS.paperId; //论文Id
objgs_PaperVENT.paperTitle = objgs_PaperVENS.paperTitle; //论文标题
objgs_PaperVENT.paperContent = objgs_PaperVENS.paperContent; //主题内容
objgs_PaperVENT.periodical = objgs_PaperVENS.periodical; //期刊
objgs_PaperVENT.author = objgs_PaperVENS.author; //作者
objgs_PaperVENT.researchQuestion = objgs_PaperVENS.researchQuestion; //研究问题
objgs_PaperVENT.keyword = objgs_PaperVENS.keyword; //关键字
objgs_PaperVENT.literatureSources = objgs_PaperVENS.literatureSources; //文献来源
objgs_PaperVENT.literatureLink = objgs_PaperVENS.literatureLink; //文献链接
objgs_PaperVENT.uploadfileUrl = objgs_PaperVENS.uploadfileUrl; //文件地址
objgs_PaperVENT.isQuotethesis = objgs_PaperVENS.isQuotethesis; //是否引用论文
objgs_PaperVENT.isSubmit = objgs_PaperVENS.isSubmit; //是否提交
objgs_PaperVENT.isChecked = objgs_PaperVENS.isChecked; //是否检查
objgs_PaperVENT.quoteId = objgs_PaperVENS.quoteId; //引用Id
objgs_PaperVENT.checker = objgs_PaperVENS.checker; //审核人
objgs_PaperVENT.literatureTypeId = objgs_PaperVENS.literatureTypeId; //作文类型Id
objgs_PaperVENT.updUser = objgs_PaperVENS.updUser; //修改人
objgs_PaperVENT.updDate = objgs_PaperVENS.updDate; //修改日期
objgs_PaperVENT.id_CurrEduCls = objgs_PaperVENS.id_CurrEduCls; //教学班流水号
objgs_PaperVENT.paperTypeId = objgs_PaperVENS.paperTypeId; //论文类型Id
objgs_PaperVENT.paperStatusId = objgs_PaperVENS.paperStatusId; //论文状态Id
objgs_PaperVENT.memo = objgs_PaperVENS.memo; //备注
objgs_PaperVENT.sf_UpdFldSetStr = objgs_PaperVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objgs_PaperVENS:源对象
 * @param objgs_PaperVENT:目标对象
*/
export function gs_PaperV_GetObjFromJsonObj(objgs_PaperVENS: clsgs_PaperVEN): clsgs_PaperVEN 
{
 const objgs_PaperVENT: clsgs_PaperVEN = new clsgs_PaperVEN();
ObjectAssign(objgs_PaperVENT, objgs_PaperVENS);
 return objgs_PaperVENT;
}