
 /**
 * 类名:clsvgs_PaperVWApi
 * 表名:vgs_PaperV(01120677)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:43
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
 * 论文历史版本视图(vgs_PaperV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvgs_PaperVEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PaperVEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PaperV_Controller = "vgs_PaperVApi";
 export const vgs_PaperV_ConstructorName = "vgs_PaperV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngPaperVId:关键字
 * @returns 对象
 **/
export async function vgs_PaperV_GetObjByPaperVIdAsync(lngPaperVId: number): Promise<clsvgs_PaperVEN>  
{
const strThisFuncName = "GetObjByPaperVIdAsync";

if (lngPaperVId == 0)
{
  const strMsg = Format("参数:[lngPaperVId]不能为空！(In GetObjByPaperVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByPaperVId";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperV = vgs_PaperV_GetObjFromJsonObj(returnObj);
return objvgs_PaperV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vgs_PaperV_SortFun_Defa(a:clsvgs_PaperVEN , b:clsvgs_PaperVEN): number 
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
export function vgs_PaperV_SortFun_Defa_2Fld(a:clsvgs_PaperVEN , b:clsvgs_PaperVEN): number 
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
export function vgs_PaperV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PaperVEN.con_PaperVId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperVId-b.paperVId;
}
case clsvgs_PaperVEN.con_PaperId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PaperVEN.con_PaperTitle:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_PaperVEN.con_PaperContent:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvgs_PaperVEN.con_Periodical:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvgs_PaperVEN.con_Author:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.author.localeCompare(b.author);
}
case clsvgs_PaperVEN.con_ResearchQuestion:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvgs_PaperVEN.con_Keyword:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvgs_PaperVEN.con_LiteratureSources:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsvgs_PaperVEN.con_LiteratureLink:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsvgs_PaperVEN.con_UploadfileUrl:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvgs_PaperVEN.con_IsQuotethesis:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_IsSubmit:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_IsChecked:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_QuoteId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.quoteId.localeCompare(b.quoteId);
}
case clsvgs_PaperVEN.con_Checker:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.checker.localeCompare(b.checker);
}
case clsvgs_PaperVEN.con_LiteratureTypeId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.literatureTypeId.localeCompare(b.literatureTypeId);
}
case clsvgs_PaperVEN.con_LiteratureTypeName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.literatureTypeName.localeCompare(b.literatureTypeName);
}
case clsvgs_PaperVEN.con_UpdUser:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PaperVEN.con_UpdDate:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PaperVEN.con_id_CurrEduCls:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvgs_PaperVEN.con_PaperTypeId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsvgs_PaperVEN.con_PaperTypeName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperTypeName.localeCompare(b.paperTypeName);
}
case clsvgs_PaperVEN.con_PaperStatusId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperStatusId.localeCompare(b.paperStatusId);
}
case clsvgs_PaperVEN.con_PaperStatusName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.paperStatusName.localeCompare(b.paperStatusName);
}
case clsvgs_PaperVEN.con_Memo:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${ vgs_PaperV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PaperVEN.con_PaperVId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperVId-a.paperVId;
}
case clsvgs_PaperVEN.con_PaperId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PaperVEN.con_PaperTitle:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_PaperVEN.con_PaperContent:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvgs_PaperVEN.con_Periodical:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvgs_PaperVEN.con_Author:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.author.localeCompare(a.author);
}
case clsvgs_PaperVEN.con_ResearchQuestion:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvgs_PaperVEN.con_Keyword:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvgs_PaperVEN.con_LiteratureSources:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsvgs_PaperVEN.con_LiteratureLink:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsvgs_PaperVEN.con_UploadfileUrl:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvgs_PaperVEN.con_IsQuotethesis:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_IsSubmit:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_IsChecked:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsvgs_PaperVEN.con_QuoteId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.quoteId.localeCompare(a.quoteId);
}
case clsvgs_PaperVEN.con_Checker:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.checker.localeCompare(a.checker);
}
case clsvgs_PaperVEN.con_LiteratureTypeId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.literatureTypeId.localeCompare(a.literatureTypeId);
}
case clsvgs_PaperVEN.con_LiteratureTypeName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.literatureTypeName.localeCompare(a.literatureTypeName);
}
case clsvgs_PaperVEN.con_UpdUser:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PaperVEN.con_UpdDate:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PaperVEN.con_id_CurrEduCls:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvgs_PaperVEN.con_PaperTypeId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsvgs_PaperVEN.con_PaperTypeName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperTypeName.localeCompare(a.paperTypeName);
}
case clsvgs_PaperVEN.con_PaperStatusId:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperStatusId.localeCompare(a.paperStatusId);
}
case clsvgs_PaperVEN.con_PaperStatusName:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.paperStatusName.localeCompare(a.paperStatusName);
}
case clsvgs_PaperVEN.con_Memo:
return (a: clsvgs_PaperVEN, b: clsvgs_PaperVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${ vgs_PaperV_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PaperVEN.con_PaperVId:
return (obj: clsvgs_PaperVEN) => {
return obj.paperVId === value;
}
case clsvgs_PaperVEN.con_PaperId:
return (obj: clsvgs_PaperVEN) => {
return obj.paperId === value;
}
case clsvgs_PaperVEN.con_PaperTitle:
return (obj: clsvgs_PaperVEN) => {
return obj.paperTitle === value;
}
case clsvgs_PaperVEN.con_PaperContent:
return (obj: clsvgs_PaperVEN) => {
return obj.paperContent === value;
}
case clsvgs_PaperVEN.con_Periodical:
return (obj: clsvgs_PaperVEN) => {
return obj.periodical === value;
}
case clsvgs_PaperVEN.con_Author:
return (obj: clsvgs_PaperVEN) => {
return obj.author === value;
}
case clsvgs_PaperVEN.con_ResearchQuestion:
return (obj: clsvgs_PaperVEN) => {
return obj.researchQuestion === value;
}
case clsvgs_PaperVEN.con_Keyword:
return (obj: clsvgs_PaperVEN) => {
return obj.keyword === value;
}
case clsvgs_PaperVEN.con_LiteratureSources:
return (obj: clsvgs_PaperVEN) => {
return obj.literatureSources === value;
}
case clsvgs_PaperVEN.con_LiteratureLink:
return (obj: clsvgs_PaperVEN) => {
return obj.literatureLink === value;
}
case clsvgs_PaperVEN.con_UploadfileUrl:
return (obj: clsvgs_PaperVEN) => {
return obj.uploadfileUrl === value;
}
case clsvgs_PaperVEN.con_IsQuotethesis:
return (obj: clsvgs_PaperVEN) => {
return obj.isQuotethesis === value;
}
case clsvgs_PaperVEN.con_IsSubmit:
return (obj: clsvgs_PaperVEN) => {
return obj.isSubmit === value;
}
case clsvgs_PaperVEN.con_IsChecked:
return (obj: clsvgs_PaperVEN) => {
return obj.isChecked === value;
}
case clsvgs_PaperVEN.con_QuoteId:
return (obj: clsvgs_PaperVEN) => {
return obj.quoteId === value;
}
case clsvgs_PaperVEN.con_Checker:
return (obj: clsvgs_PaperVEN) => {
return obj.checker === value;
}
case clsvgs_PaperVEN.con_LiteratureTypeId:
return (obj: clsvgs_PaperVEN) => {
return obj.literatureTypeId === value;
}
case clsvgs_PaperVEN.con_LiteratureTypeName:
return (obj: clsvgs_PaperVEN) => {
return obj.literatureTypeName === value;
}
case clsvgs_PaperVEN.con_UpdUser:
return (obj: clsvgs_PaperVEN) => {
return obj.updUser === value;
}
case clsvgs_PaperVEN.con_UpdDate:
return (obj: clsvgs_PaperVEN) => {
return obj.updDate === value;
}
case clsvgs_PaperVEN.con_id_CurrEduCls:
return (obj: clsvgs_PaperVEN) => {
return obj.id_CurrEduCls === value;
}
case clsvgs_PaperVEN.con_PaperTypeId:
return (obj: clsvgs_PaperVEN) => {
return obj.paperTypeId === value;
}
case clsvgs_PaperVEN.con_PaperTypeName:
return (obj: clsvgs_PaperVEN) => {
return obj.paperTypeName === value;
}
case clsvgs_PaperVEN.con_PaperStatusId:
return (obj: clsvgs_PaperVEN) => {
return obj.paperStatusId === value;
}
case clsvgs_PaperVEN.con_PaperStatusName:
return (obj: clsvgs_PaperVEN) => {
return obj.paperStatusName === value;
}
case clsvgs_PaperVEN.con_Memo:
return (obj: clsvgs_PaperVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperV]中不存在！(in ${ vgs_PaperV_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PaperV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PaperVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PaperV = vgs_PaperV_GetObjFromJsonObj(returnObj);
return objvgs_PaperV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetObjLstByPaperVIdLstAsync(arrPaperVId: Array<string>): Promise<Array<clsvgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByPaperVIdLstAsync";
const strAction = "GetObjLstByPaperVIdLst";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrPaperVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PaperVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PaperVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PaperV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_IsExist(lngPaperVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_IsExistAsync(lngPaperVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
export async function vgs_PaperV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PaperV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PaperV_ConstructorName, strThisFuncName);
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
 * 获取WebApi的地址
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
 * @returns 返回当前文件中Web服务的地址
*/
export function vgs_PaperV_GetWebApiUrl(strController: string, strAction: string): string {
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

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperV_GetJSONStrByObj (pobjvgs_PaperVEN: clsvgs_PaperVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PaperVEN);
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
export function vgs_PaperV_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PaperVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PaperVObjLst = new Array<clsvgs_PaperVEN>();
if (strJSON === "")
{
return arrvgs_PaperVObjLst;
}
try
{
arrvgs_PaperVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PaperVObjLst;
}
return arrvgs_PaperVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PaperVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PaperV_GetObjLstByJSONObjLst (arrvgs_PaperVObjLstS: Array<clsvgs_PaperVEN>): Array<clsvgs_PaperVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PaperVObjLst = new Array<clsvgs_PaperVEN>();
for (const objInFor of arrvgs_PaperVObjLstS) {
const obj1 = vgs_PaperV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PaperVObjLst.push(obj1);
}
return arrvgs_PaperVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PaperV_GetObjByJSONStr (strJSON: string): clsvgs_PaperVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PaperVEN = new clsvgs_PaperVEN();
if (strJSON === "")
{
return pobjvgs_PaperVEN;
}
try
{
pobjvgs_PaperVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PaperVEN;
}
return pobjvgs_PaperVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PaperV_GetCombineCondition(objvgs_PaperV_Cond: clsvgs_PaperVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperVId) == true)
{
const strComparisonOp_PaperVId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperVId];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PaperVEN.con_PaperVId, objvgs_PaperV_Cond.paperVId, strComparisonOp_PaperVId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperId, objvgs_PaperV_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperTitle, objvgs_PaperV_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_Periodical, objvgs_PaperV_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_Author, objvgs_PaperV_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_ResearchQuestion, objvgs_PaperV_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_Keyword, objvgs_PaperV_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_LiteratureSources, objvgs_PaperV_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_LiteratureLink, objvgs_PaperV_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_UploadfileUrl, objvgs_PaperV_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_IsQuotethesis) == true)
{
if (objvgs_PaperV_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PaperVEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PaperVEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_IsSubmit) == true)
{
if (objvgs_PaperV_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PaperVEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PaperVEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_IsChecked) == true)
{
if (objvgs_PaperV_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PaperVEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PaperVEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_QuoteId) == true)
{
const strComparisonOp_QuoteId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_QuoteId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_QuoteId, objvgs_PaperV_Cond.quoteId, strComparisonOp_QuoteId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_Checker, objvgs_PaperV_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_LiteratureTypeId) == true)
{
const strComparisonOp_LiteratureTypeId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_LiteratureTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_LiteratureTypeId, objvgs_PaperV_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_LiteratureTypeName) == true)
{
const strComparisonOp_LiteratureTypeName:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_LiteratureTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_LiteratureTypeName, objvgs_PaperV_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_UpdUser, objvgs_PaperV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_UpdDate, objvgs_PaperV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_id_CurrEduCls, objvgs_PaperV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperTypeId, objvgs_PaperV_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperTypeName) == true)
{
const strComparisonOp_PaperTypeName:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperTypeName, objvgs_PaperV_Cond.paperTypeName, strComparisonOp_PaperTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperStatusId) == true)
{
const strComparisonOp_PaperStatusId:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperStatusId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperStatusId, objvgs_PaperV_Cond.paperStatusId, strComparisonOp_PaperStatusId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_PaperStatusName) == true)
{
const strComparisonOp_PaperStatusName:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_PaperStatusName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_PaperStatusName, objvgs_PaperV_Cond.paperStatusName, strComparisonOp_PaperStatusName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PaperV_Cond.dicFldComparisonOp, clsvgs_PaperVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_PaperV_Cond.dicFldComparisonOp[clsvgs_PaperVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PaperVEN.con_Memo, objvgs_PaperV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PaperVENS:源对象
 * @param objvgs_PaperVENT:目标对象
*/
export function vgs_PaperV_CopyObjTo(objvgs_PaperVENS: clsvgs_PaperVEN , objvgs_PaperVENT: clsvgs_PaperVEN ): void 
{
objvgs_PaperVENT.paperVId = objvgs_PaperVENS.paperVId; //PaperVId
objvgs_PaperVENT.paperId = objvgs_PaperVENS.paperId; //论文Id
objvgs_PaperVENT.paperTitle = objvgs_PaperVENS.paperTitle; //论文标题
objvgs_PaperVENT.paperContent = objvgs_PaperVENS.paperContent; //主题内容
objvgs_PaperVENT.periodical = objvgs_PaperVENS.periodical; //期刊
objvgs_PaperVENT.author = objvgs_PaperVENS.author; //作者
objvgs_PaperVENT.researchQuestion = objvgs_PaperVENS.researchQuestion; //研究问题
objvgs_PaperVENT.keyword = objvgs_PaperVENS.keyword; //关键字
objvgs_PaperVENT.literatureSources = objvgs_PaperVENS.literatureSources; //文献来源
objvgs_PaperVENT.literatureLink = objvgs_PaperVENS.literatureLink; //文献链接
objvgs_PaperVENT.uploadfileUrl = objvgs_PaperVENS.uploadfileUrl; //文件地址
objvgs_PaperVENT.isQuotethesis = objvgs_PaperVENS.isQuotethesis; //是否引用论文
objvgs_PaperVENT.isSubmit = objvgs_PaperVENS.isSubmit; //是否提交
objvgs_PaperVENT.isChecked = objvgs_PaperVENS.isChecked; //是否检查
objvgs_PaperVENT.quoteId = objvgs_PaperVENS.quoteId; //引用Id
objvgs_PaperVENT.checker = objvgs_PaperVENS.checker; //审核人
objvgs_PaperVENT.literatureTypeId = objvgs_PaperVENS.literatureTypeId; //作文类型Id
objvgs_PaperVENT.literatureTypeName = objvgs_PaperVENS.literatureTypeName; //作文类型名
objvgs_PaperVENT.updUser = objvgs_PaperVENS.updUser; //修改人
objvgs_PaperVENT.updDate = objvgs_PaperVENS.updDate; //修改日期
objvgs_PaperVENT.id_CurrEduCls = objvgs_PaperVENS.id_CurrEduCls; //教学班流水号
objvgs_PaperVENT.paperTypeId = objvgs_PaperVENS.paperTypeId; //论文类型Id
objvgs_PaperVENT.paperTypeName = objvgs_PaperVENS.paperTypeName; //论文类型名
objvgs_PaperVENT.paperStatusId = objvgs_PaperVENS.paperStatusId; //论文状态Id
objvgs_PaperVENT.paperStatusName = objvgs_PaperVENS.paperStatusName; //论文状态名
objvgs_PaperVENT.memo = objvgs_PaperVENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PaperVENS:源对象
 * @param objvgs_PaperVENT:目标对象
*/
export function vgs_PaperV_GetObjFromJsonObj(objvgs_PaperVENS: clsvgs_PaperVEN): clsvgs_PaperVEN 
{
 const objvgs_PaperVENT: clsvgs_PaperVEN = new clsvgs_PaperVEN();
ObjectAssign(objvgs_PaperVENT, objvgs_PaperVENS);
 return objvgs_PaperVENT;
}