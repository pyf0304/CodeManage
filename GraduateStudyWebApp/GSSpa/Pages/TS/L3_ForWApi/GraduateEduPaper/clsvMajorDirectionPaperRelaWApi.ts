
 /**
 * 类名:clsvMajorDirectionPaperRelaWApi
 * 表名:vMajorDirectionPaperRela(01120555)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:39
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
 * v专业方向论文关系(vMajorDirectionPaperRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvMajorDirectionPaperRelaEN } from "../../L0_Entity/GraduateEduPaper/clsvMajorDirectionPaperRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vMajorDirectionPaperRela_Controller = "vMajorDirectionPaperRelaApi";
 export const vMajorDirectionPaperRela_ConstructorName = "vMajorDirectionPaperRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vMajorDirectionPaperRela_GetObjBymIdAsync(lngmId: number): Promise<clsvMajorDirectionPaperRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvMajorDirectionPaperRela = vMajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
return objvMajorDirectionPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export function vMajorDirectionPaperRela_SortFun_Defa(a:clsvMajorDirectionPaperRelaEN , b:clsvMajorDirectionPaperRelaEN): number 
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
export function vMajorDirectionPaperRela_SortFun_Defa_2Fld(a:clsvMajorDirectionPaperRelaEN , b:clsvMajorDirectionPaperRelaEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.majorDirectionId == b.majorDirectionId) return a.paperId.localeCompare(b.paperId);
else return a.majorDirectionId.localeCompare(b.majorDirectionId);
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
export function vMajorDirectionPaperRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvMajorDirectionPaperRelaEN.con_mId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.mId-b.mId;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorDirectionId.localeCompare(b.majorDirectionId);
}
case clsvMajorDirectionPaperRelaEN.con_PaperId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvMajorDirectionPaperRelaEN.con_UpdDate:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvMajorDirectionPaperRelaEN.con_UpdUser:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvMajorDirectionPaperRelaEN.con_Memo:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorDirectionENName.localeCompare(b.majorDirectionENName);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorDirectionName.localeCompare(b.majorDirectionName);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorDirectionExplain.localeCompare(b.majorDirectionExplain);
}
case clsvMajorDirectionPaperRelaEN.con_IsVisible:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_PaperTitle:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvMajorDirectionPaperRelaEN.con_PaperContent:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.paperContent.localeCompare(b.paperContent);
}
case clsvMajorDirectionPaperRelaEN.con_Periodical:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.periodical.localeCompare(b.periodical);
}
case clsvMajorDirectionPaperRelaEN.con_Author:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.author.localeCompare(b.author);
}
case clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.researchQuestion.localeCompare(b.researchQuestion);
}
case clsvMajorDirectionPaperRelaEN.con_Keyword:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.keyword.localeCompare(b.keyword);
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.literatureSources.localeCompare(b.literatureSources);
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.literatureLink.localeCompare(b.literatureLink);
}
case clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
}
case clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (a.isQuotethesis == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_Checker:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.checker.localeCompare(b.checker);
}
case clsvMajorDirectionPaperRelaEN.con_IsChecked:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (a.isChecked == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_MajorID:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorID.localeCompare(b.majorID);
}
case clsvMajorDirectionPaperRelaEN.con_MajorName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvMajorDirectionPaperRelaEN.con_UserName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return a.userName.localeCompare(b.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${ vMajorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvMajorDirectionPaperRelaEN.con_mId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.mId-a.mId;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorDirectionId.localeCompare(a.majorDirectionId);
}
case clsvMajorDirectionPaperRelaEN.con_PaperId:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvMajorDirectionPaperRelaEN.con_UpdDate:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvMajorDirectionPaperRelaEN.con_UpdUser:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvMajorDirectionPaperRelaEN.con_Memo:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorDirectionENName.localeCompare(a.majorDirectionENName);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorDirectionName.localeCompare(a.majorDirectionName);
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorDirectionExplain.localeCompare(a.majorDirectionExplain);
}
case clsvMajorDirectionPaperRelaEN.con_IsVisible:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_PaperTitle:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvMajorDirectionPaperRelaEN.con_PaperContent:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.paperContent.localeCompare(a.paperContent);
}
case clsvMajorDirectionPaperRelaEN.con_Periodical:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.periodical.localeCompare(a.periodical);
}
case clsvMajorDirectionPaperRelaEN.con_Author:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.author.localeCompare(a.author);
}
case clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.researchQuestion.localeCompare(a.researchQuestion);
}
case clsvMajorDirectionPaperRelaEN.con_Keyword:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.keyword.localeCompare(a.keyword);
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.literatureSources.localeCompare(a.literatureSources);
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.literatureLink.localeCompare(a.literatureLink);
}
case clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
}
case clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (b.isQuotethesis == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_Checker:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.checker.localeCompare(a.checker);
}
case clsvMajorDirectionPaperRelaEN.con_IsChecked:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
if (b.isChecked == true) return 1;
else return -1
}
case clsvMajorDirectionPaperRelaEN.con_MajorID:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorID.localeCompare(a.majorID);
}
case clsvMajorDirectionPaperRelaEN.con_MajorName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvMajorDirectionPaperRelaEN.con_UserName:
return (a: clsvMajorDirectionPaperRelaEN, b: clsvMajorDirectionPaperRelaEN) => {
return b.userName.localeCompare(a.userName);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${ vMajorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vMajorDirectionPaperRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvMajorDirectionPaperRelaEN.con_mId:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.mId === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionId:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorDirectionId === value;
}
case clsvMajorDirectionPaperRelaEN.con_PaperId:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.paperId === value;
}
case clsvMajorDirectionPaperRelaEN.con_UpdDate:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.updDate === value;
}
case clsvMajorDirectionPaperRelaEN.con_UpdUser:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.updUser === value;
}
case clsvMajorDirectionPaperRelaEN.con_Memo:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.memo === value;
}
case clsvMajorDirectionPaperRelaEN.con_id_XzMajor:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.id_XzMajor === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorDirectionENName === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionName:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorDirectionName === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorDirectionExplain === value;
}
case clsvMajorDirectionPaperRelaEN.con_IsVisible:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.isVisible === value;
}
case clsvMajorDirectionPaperRelaEN.con_PaperTitle:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.paperTitle === value;
}
case clsvMajorDirectionPaperRelaEN.con_PaperContent:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.paperContent === value;
}
case clsvMajorDirectionPaperRelaEN.con_Periodical:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.periodical === value;
}
case clsvMajorDirectionPaperRelaEN.con_Author:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.author === value;
}
case clsvMajorDirectionPaperRelaEN.con_ResearchQuestion:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.researchQuestion === value;
}
case clsvMajorDirectionPaperRelaEN.con_Keyword:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.keyword === value;
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureSources:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.literatureSources === value;
}
case clsvMajorDirectionPaperRelaEN.con_LiteratureLink:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.literatureLink === value;
}
case clsvMajorDirectionPaperRelaEN.con_UploadfileUrl:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.uploadfileUrl === value;
}
case clsvMajorDirectionPaperRelaEN.con_IsQuotethesis:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.isQuotethesis === value;
}
case clsvMajorDirectionPaperRelaEN.con_Checker:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.checker === value;
}
case clsvMajorDirectionPaperRelaEN.con_IsChecked:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.isChecked === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorID:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorID === value;
}
case clsvMajorDirectionPaperRelaEN.con_MajorName:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.majorName === value;
}
case clsvMajorDirectionPaperRelaEN.con_UserName:
return (obj: clsvMajorDirectionPaperRelaEN) => {
return obj.userName === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vMajorDirectionPaperRela]中不存在！(in ${ vMajorDirectionPaperRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vMajorDirectionPaperRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvMajorDirectionPaperRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvMajorDirectionPaperRela = vMajorDirectionPaperRela_GetObjFromJsonObj(returnObj);
return objvMajorDirectionPaperRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vMajorDirectionPaperRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvMajorDirectionPaperRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vMajorDirectionPaperRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vMajorDirectionPaperRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export async function vMajorDirectionPaperRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vMajorDirectionPaperRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vMajorDirectionPaperRela_ConstructorName, strThisFuncName);
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
export function vMajorDirectionPaperRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vMajorDirectionPaperRela_GetJSONStrByObj (pobjvMajorDirectionPaperRelaEN: clsvMajorDirectionPaperRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvMajorDirectionPaperRelaEN);
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
export function vMajorDirectionPaperRela_GetObjLstByJSONStr (strJSON: string): Array<clsvMajorDirectionPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvMajorDirectionPaperRelaObjLst = new Array<clsvMajorDirectionPaperRelaEN>();
if (strJSON === "")
{
return arrvMajorDirectionPaperRelaObjLst;
}
try
{
arrvMajorDirectionPaperRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvMajorDirectionPaperRelaObjLst;
}
return arrvMajorDirectionPaperRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvMajorDirectionPaperRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vMajorDirectionPaperRela_GetObjLstByJSONObjLst (arrvMajorDirectionPaperRelaObjLstS: Array<clsvMajorDirectionPaperRelaEN>): Array<clsvMajorDirectionPaperRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvMajorDirectionPaperRelaObjLst = new Array<clsvMajorDirectionPaperRelaEN>();
for (const objInFor of arrvMajorDirectionPaperRelaObjLstS) {
const obj1 = vMajorDirectionPaperRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvMajorDirectionPaperRelaObjLst.push(obj1);
}
return arrvMajorDirectionPaperRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vMajorDirectionPaperRela_GetObjByJSONStr (strJSON: string): clsvMajorDirectionPaperRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
if (strJSON === "")
{
return pobjvMajorDirectionPaperRelaEN;
}
try
{
pobjvMajorDirectionPaperRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvMajorDirectionPaperRelaEN;
}
return pobjvMajorDirectionPaperRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vMajorDirectionPaperRela_GetCombineCondition(objvMajorDirectionPaperRela_Cond: clsvMajorDirectionPaperRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvMajorDirectionPaperRelaEN.con_mId, objvMajorDirectionPaperRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorDirectionId) == true)
{
const strComparisonOp_MajorDirectionId:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorDirectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionId, objvMajorDirectionPaperRela_Cond.majorDirectionId, strComparisonOp_MajorDirectionId);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_PaperId, objvMajorDirectionPaperRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_UpdDate, objvMajorDirectionPaperRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_UpdUser, objvMajorDirectionPaperRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_Memo, objvMajorDirectionPaperRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_id_XzMajor, objvMajorDirectionPaperRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName) == true)
{
const strComparisonOp_MajorDirectionENName:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionENName, objvMajorDirectionPaperRela_Cond.majorDirectionENName, strComparisonOp_MajorDirectionENName);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorDirectionName) == true)
{
const strComparisonOp_MajorDirectionName:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorDirectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionName, objvMajorDirectionPaperRela_Cond.majorDirectionName, strComparisonOp_MajorDirectionName);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain) == true)
{
const strComparisonOp_MajorDirectionExplain:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorDirectionExplain, objvMajorDirectionPaperRela_Cond.majorDirectionExplain, strComparisonOp_MajorDirectionExplain);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_IsVisible) == true)
{
if (objvMajorDirectionPaperRela_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_PaperTitle, objvMajorDirectionPaperRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_Periodical) == true)
{
const strComparisonOp_Periodical:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_Periodical];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_Periodical, objvMajorDirectionPaperRela_Cond.periodical, strComparisonOp_Periodical);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_Author) == true)
{
const strComparisonOp_Author:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_Author];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_Author, objvMajorDirectionPaperRela_Cond.author, strComparisonOp_Author);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_ResearchQuestion) == true)
{
const strComparisonOp_ResearchQuestion:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_ResearchQuestion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_ResearchQuestion, objvMajorDirectionPaperRela_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_Keyword) == true)
{
const strComparisonOp_Keyword:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_Keyword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_Keyword, objvMajorDirectionPaperRela_Cond.keyword, strComparisonOp_Keyword);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_LiteratureSources) == true)
{
const strComparisonOp_LiteratureSources:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_LiteratureSources];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_LiteratureSources, objvMajorDirectionPaperRela_Cond.literatureSources, strComparisonOp_LiteratureSources);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_LiteratureLink) == true)
{
const strComparisonOp_LiteratureLink:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_LiteratureLink];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_LiteratureLink, objvMajorDirectionPaperRela_Cond.literatureLink, strComparisonOp_LiteratureLink);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_UploadfileUrl) == true)
{
const strComparisonOp_UploadfileUrl:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_UploadfileUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_UploadfileUrl, objvMajorDirectionPaperRela_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_IsQuotethesis) == true)
{
if (objvMajorDirectionPaperRela_Cond.isQuotethesis == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsQuotethesis);
}
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_Checker) == true)
{
const strComparisonOp_Checker:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_Checker];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_Checker, objvMajorDirectionPaperRela_Cond.checker, strComparisonOp_Checker);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_IsChecked) == true)
{
if (objvMajorDirectionPaperRela_Cond.isChecked == true)
{
strWhereCond += Format(" And {0} = '1'", clsvMajorDirectionPaperRelaEN.con_IsChecked);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvMajorDirectionPaperRelaEN.con_IsChecked);
}
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorID) == true)
{
const strComparisonOp_MajorID:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorID, objvMajorDirectionPaperRela_Cond.majorID, strComparisonOp_MajorID);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_MajorName, objvMajorDirectionPaperRela_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvMajorDirectionPaperRela_Cond.dicFldComparisonOp, clsvMajorDirectionPaperRelaEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvMajorDirectionPaperRela_Cond.dicFldComparisonOp[clsvMajorDirectionPaperRelaEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvMajorDirectionPaperRelaEN.con_UserName, objvMajorDirectionPaperRela_Cond.userName, strComparisonOp_UserName);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvMajorDirectionPaperRelaENS:源对象
 * @param objvMajorDirectionPaperRelaENT:目标对象
*/
export function vMajorDirectionPaperRela_CopyObjTo(objvMajorDirectionPaperRelaENS: clsvMajorDirectionPaperRelaEN , objvMajorDirectionPaperRelaENT: clsvMajorDirectionPaperRelaEN ): void 
{
objvMajorDirectionPaperRelaENT.mId = objvMajorDirectionPaperRelaENS.mId; //mId
objvMajorDirectionPaperRelaENT.majorDirectionId = objvMajorDirectionPaperRelaENS.majorDirectionId; //研究方向Id
objvMajorDirectionPaperRelaENT.paperId = objvMajorDirectionPaperRelaENS.paperId; //论文Id
objvMajorDirectionPaperRelaENT.updDate = objvMajorDirectionPaperRelaENS.updDate; //修改日期
objvMajorDirectionPaperRelaENT.updUser = objvMajorDirectionPaperRelaENS.updUser; //修改人
objvMajorDirectionPaperRelaENT.memo = objvMajorDirectionPaperRelaENS.memo; //备注
objvMajorDirectionPaperRelaENT.id_XzMajor = objvMajorDirectionPaperRelaENS.id_XzMajor; //专业流水号
objvMajorDirectionPaperRelaENT.majorDirectionENName = objvMajorDirectionPaperRelaENS.majorDirectionENName; //研究方向英文名
objvMajorDirectionPaperRelaENT.majorDirectionName = objvMajorDirectionPaperRelaENS.majorDirectionName; //研究方向名
objvMajorDirectionPaperRelaENT.majorDirectionExplain = objvMajorDirectionPaperRelaENS.majorDirectionExplain; //专业方向说明
objvMajorDirectionPaperRelaENT.isVisible = objvMajorDirectionPaperRelaENS.isVisible; //是否显示
objvMajorDirectionPaperRelaENT.paperTitle = objvMajorDirectionPaperRelaENS.paperTitle; //论文标题
objvMajorDirectionPaperRelaENT.paperContent = objvMajorDirectionPaperRelaENS.paperContent; //主题内容
objvMajorDirectionPaperRelaENT.periodical = objvMajorDirectionPaperRelaENS.periodical; //期刊
objvMajorDirectionPaperRelaENT.author = objvMajorDirectionPaperRelaENS.author; //作者
objvMajorDirectionPaperRelaENT.researchQuestion = objvMajorDirectionPaperRelaENS.researchQuestion; //研究问题
objvMajorDirectionPaperRelaENT.keyword = objvMajorDirectionPaperRelaENS.keyword; //关键字
objvMajorDirectionPaperRelaENT.literatureSources = objvMajorDirectionPaperRelaENS.literatureSources; //文献来源
objvMajorDirectionPaperRelaENT.literatureLink = objvMajorDirectionPaperRelaENS.literatureLink; //文献链接
objvMajorDirectionPaperRelaENT.uploadfileUrl = objvMajorDirectionPaperRelaENS.uploadfileUrl; //文件地址
objvMajorDirectionPaperRelaENT.isQuotethesis = objvMajorDirectionPaperRelaENS.isQuotethesis; //是否引用论文
objvMajorDirectionPaperRelaENT.checker = objvMajorDirectionPaperRelaENS.checker; //审核人
objvMajorDirectionPaperRelaENT.isChecked = objvMajorDirectionPaperRelaENS.isChecked; //是否检查
objvMajorDirectionPaperRelaENT.majorID = objvMajorDirectionPaperRelaENS.majorID; //专业ID
objvMajorDirectionPaperRelaENT.majorName = objvMajorDirectionPaperRelaENS.majorName; //专业名称
objvMajorDirectionPaperRelaENT.userName = objvMajorDirectionPaperRelaENS.userName; //用户名
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvMajorDirectionPaperRelaENS:源对象
 * @param objvMajorDirectionPaperRelaENT:目标对象
*/
export function vMajorDirectionPaperRela_GetObjFromJsonObj(objvMajorDirectionPaperRelaENS: clsvMajorDirectionPaperRelaEN): clsvMajorDirectionPaperRelaEN 
{
 const objvMajorDirectionPaperRelaENT: clsvMajorDirectionPaperRelaEN = new clsvMajorDirectionPaperRelaEN();
ObjectAssign(objvMajorDirectionPaperRelaENT, objvMajorDirectionPaperRelaENS);
 return objvMajorDirectionPaperRelaENT;
}