
 /**
 * 类名:clsvgs_PViewpointRelaWApi
 * 表名:vgs_PViewpointRela(01120669)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:42
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
 * 论文观点关系视图(vgs_PViewpointRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvgs_PViewpointRelaEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PViewpointRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PViewpointRela_Controller = "vgs_PViewpointRelaApi";
 export const vgs_PViewpointRela_ConstructorName = "vgs_PViewpointRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vgs_PViewpointRela_GetObjBymIdAsync(lngmId: number): Promise<clsvgs_PViewpointRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PViewpointRela = vgs_PViewpointRela_GetObjFromJsonObj(returnObj);
return objvgs_PViewpointRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export function vgs_PViewpointRela_SortFun_Defa(a:clsvgs_PViewpointRelaEN , b:clsvgs_PViewpointRelaEN): number 
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
export function vgs_PViewpointRela_SortFun_Defa_2Fld(a:clsvgs_PViewpointRelaEN , b:clsvgs_PViewpointRelaEN): number 
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
export function vgs_PViewpointRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PViewpointRelaEN.con_mId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.mId-b.mId;
}
case clsvgs_PViewpointRelaEN.con_PaperId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PViewpointRelaEN.con_PaperTitle:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_PViewpointRelaEN.con_PaperTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsvgs_PViewpointRelaEN.con_SectionId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvgs_PViewpointRelaEN.con_SectionName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsvgs_PViewpointRelaEN.con_ViewpointId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewpointId.localeCompare(b.viewpointId);
}
case clsvgs_PViewpointRelaEN.con_ViewpointName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewpointName.localeCompare(b.viewpointName);
}
case clsvgs_PViewpointRelaEN.con_ViewpointContent:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewpointContent.localeCompare(b.viewpointContent);
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
}
case clsvgs_PViewpointRelaEN.con_Reason:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.reason.localeCompare(b.reason);
}
case clsvgs_PViewpointRelaEN.con_VPProposePeople:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.vpProposePeople.localeCompare(b.vpProposePeople);
}
case clsvgs_PViewpointRelaEN.con_IsSubmit:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_PViewpointRelaEN.con_UserTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.userTypeId.localeCompare(b.userTypeId);
}
case clsvgs_PViewpointRelaEN.con_UserTypeName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.userTypeName.localeCompare(b.userTypeName);
}
case clsvgs_PViewpointRelaEN.con_AppraiseCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvgs_PViewpointRelaEN.con_score:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.score-b.score;
}
case clsvgs_PViewpointRelaEN.con_StuScore:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.stuScore-b.stuScore;
}
case clsvgs_PViewpointRelaEN.con_TeaScore:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.teaScore-b.teaScore;
}
case clsvgs_PViewpointRelaEN.con_OkCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.okCount-b.okCount;
}
case clsvgs_PViewpointRelaEN.con_CitationCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.citationCount-b.citationCount;
}
case clsvgs_PViewpointRelaEN.con_VersionCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_PViewpointRelaEN.con_ProposePeople:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.proposePeople.localeCompare(b.proposePeople);
}
case clsvgs_PViewpointRelaEN.con_UpdDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PViewpointRelaEN.con_UpdUser:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PViewpointRelaEN.con_Memo:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvgs_PViewpointRelaEN.con_ViewsDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewsDate.localeCompare(b.viewsDate);
}
case clsvgs_PViewpointRelaEN.con_ViewsUserId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.viewsUserId.localeCompare(b.viewsUserId);
}
case clsvgs_PViewpointRelaEN.con_CreateDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvgs_PViewpointRelaEN.con_ShareId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return a.shareId.localeCompare(b.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${ vgs_PViewpointRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PViewpointRelaEN.con_mId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.mId-a.mId;
}
case clsvgs_PViewpointRelaEN.con_PaperId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PViewpointRelaEN.con_PaperTitle:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_PViewpointRelaEN.con_PaperTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsvgs_PViewpointRelaEN.con_SectionId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvgs_PViewpointRelaEN.con_SectionName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsvgs_PViewpointRelaEN.con_ViewpointId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewpointId.localeCompare(a.viewpointId);
}
case clsvgs_PViewpointRelaEN.con_ViewpointName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewpointName.localeCompare(a.viewpointName);
}
case clsvgs_PViewpointRelaEN.con_ViewpointContent:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewpointContent.localeCompare(a.viewpointContent);
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
}
case clsvgs_PViewpointRelaEN.con_Reason:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.reason.localeCompare(a.reason);
}
case clsvgs_PViewpointRelaEN.con_VPProposePeople:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.vpProposePeople.localeCompare(a.vpProposePeople);
}
case clsvgs_PViewpointRelaEN.con_IsSubmit:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_PViewpointRelaEN.con_UserTypeId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.userTypeId.localeCompare(a.userTypeId);
}
case clsvgs_PViewpointRelaEN.con_UserTypeName:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.userTypeName.localeCompare(a.userTypeName);
}
case clsvgs_PViewpointRelaEN.con_AppraiseCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvgs_PViewpointRelaEN.con_score:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.score-a.score;
}
case clsvgs_PViewpointRelaEN.con_StuScore:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.stuScore-a.stuScore;
}
case clsvgs_PViewpointRelaEN.con_TeaScore:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.teaScore-a.teaScore;
}
case clsvgs_PViewpointRelaEN.con_OkCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.okCount-a.okCount;
}
case clsvgs_PViewpointRelaEN.con_CitationCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.citationCount-a.citationCount;
}
case clsvgs_PViewpointRelaEN.con_VersionCount:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_PViewpointRelaEN.con_ProposePeople:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.proposePeople.localeCompare(a.proposePeople);
}
case clsvgs_PViewpointRelaEN.con_UpdDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PViewpointRelaEN.con_UpdUser:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PViewpointRelaEN.con_Memo:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvgs_PViewpointRelaEN.con_ViewsDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewsDate.localeCompare(a.viewsDate);
}
case clsvgs_PViewpointRelaEN.con_ViewsUserId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.viewsUserId.localeCompare(a.viewsUserId);
}
case clsvgs_PViewpointRelaEN.con_CreateDate:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvgs_PViewpointRelaEN.con_ShareId:
return (a: clsvgs_PViewpointRelaEN, b: clsvgs_PViewpointRelaEN) => {
return b.shareId.localeCompare(a.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${ vgs_PViewpointRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PViewpointRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PViewpointRelaEN.con_mId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.mId === value;
}
case clsvgs_PViewpointRelaEN.con_PaperId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.paperId === value;
}
case clsvgs_PViewpointRelaEN.con_PaperTitle:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.paperTitle === value;
}
case clsvgs_PViewpointRelaEN.con_PaperTypeId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.paperTypeId === value;
}
case clsvgs_PViewpointRelaEN.con_SectionId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.sectionId === value;
}
case clsvgs_PViewpointRelaEN.con_SectionName:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.sectionName === value;
}
case clsvgs_PViewpointRelaEN.con_ViewpointId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewpointId === value;
}
case clsvgs_PViewpointRelaEN.con_ViewpointName:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewpointName === value;
}
case clsvgs_PViewpointRelaEN.con_ViewpointContent:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewpointContent === value;
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewpointTypeId === value;
}
case clsvgs_PViewpointRelaEN.con_ViewpointTypeName:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewpointTypeName === value;
}
case clsvgs_PViewpointRelaEN.con_Reason:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.reason === value;
}
case clsvgs_PViewpointRelaEN.con_VPProposePeople:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.vpProposePeople === value;
}
case clsvgs_PViewpointRelaEN.con_IsSubmit:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.isSubmit === value;
}
case clsvgs_PViewpointRelaEN.con_UserTypeId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.userTypeId === value;
}
case clsvgs_PViewpointRelaEN.con_UserTypeName:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.userTypeName === value;
}
case clsvgs_PViewpointRelaEN.con_AppraiseCount:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.appraiseCount === value;
}
case clsvgs_PViewpointRelaEN.con_score:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.score === value;
}
case clsvgs_PViewpointRelaEN.con_StuScore:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.stuScore === value;
}
case clsvgs_PViewpointRelaEN.con_TeaScore:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.teaScore === value;
}
case clsvgs_PViewpointRelaEN.con_OkCount:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.okCount === value;
}
case clsvgs_PViewpointRelaEN.con_CitationCount:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.citationCount === value;
}
case clsvgs_PViewpointRelaEN.con_VersionCount:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.versionCount === value;
}
case clsvgs_PViewpointRelaEN.con_ProposePeople:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.proposePeople === value;
}
case clsvgs_PViewpointRelaEN.con_UpdDate:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.updDate === value;
}
case clsvgs_PViewpointRelaEN.con_UpdUser:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.updUser === value;
}
case clsvgs_PViewpointRelaEN.con_Memo:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.memo === value;
}
case clsvgs_PViewpointRelaEN.con_ViewsDate:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewsDate === value;
}
case clsvgs_PViewpointRelaEN.con_ViewsUserId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.viewsUserId === value;
}
case clsvgs_PViewpointRelaEN.con_CreateDate:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.createDate === value;
}
case clsvgs_PViewpointRelaEN.con_ShareId:
return (obj: clsvgs_PViewpointRelaEN) => {
return obj.shareId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PViewpointRela]中不存在！(in ${ vgs_PViewpointRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PViewpointRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PViewpointRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PViewpointRela = vgs_PViewpointRela_GetObjFromJsonObj(returnObj);
return objvgs_PViewpointRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PViewpointRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvgs_PViewpointRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PViewpointRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PViewpointRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PViewpointRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PViewpointRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export async function vgs_PViewpointRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PViewpointRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PViewpointRela_ConstructorName, strThisFuncName);
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
export function vgs_PViewpointRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_PViewpointRela_GetJSONStrByObj (pobjvgs_PViewpointRelaEN: clsvgs_PViewpointRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PViewpointRelaEN);
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
export function vgs_PViewpointRela_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PViewpointRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PViewpointRelaObjLst = new Array<clsvgs_PViewpointRelaEN>();
if (strJSON === "")
{
return arrvgs_PViewpointRelaObjLst;
}
try
{
arrvgs_PViewpointRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PViewpointRelaObjLst;
}
return arrvgs_PViewpointRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PViewpointRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PViewpointRela_GetObjLstByJSONObjLst (arrvgs_PViewpointRelaObjLstS: Array<clsvgs_PViewpointRelaEN>): Array<clsvgs_PViewpointRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PViewpointRelaObjLst = new Array<clsvgs_PViewpointRelaEN>();
for (const objInFor of arrvgs_PViewpointRelaObjLstS) {
const obj1 = vgs_PViewpointRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PViewpointRelaObjLst.push(obj1);
}
return arrvgs_PViewpointRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PViewpointRela_GetObjByJSONStr (strJSON: string): clsvgs_PViewpointRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
if (strJSON === "")
{
return pobjvgs_PViewpointRelaEN;
}
try
{
pobjvgs_PViewpointRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PViewpointRelaEN;
}
return pobjvgs_PViewpointRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PViewpointRela_GetCombineCondition(objvgs_PViewpointRela_Cond: clsvgs_PViewpointRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_mId, objvgs_PViewpointRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_PaperId, objvgs_PViewpointRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_PaperTitle, objvgs_PViewpointRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_PaperTypeId, objvgs_PViewpointRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_SectionId, objvgs_PViewpointRela_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_SectionName, objvgs_PViewpointRela_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewpointId) == true)
{
const strComparisonOp_ViewpointId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewpointId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewpointId, objvgs_PViewpointRela_Cond.viewpointId, strComparisonOp_ViewpointId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewpointName) == true)
{
const strComparisonOp_ViewpointName:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewpointName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewpointName, objvgs_PViewpointRela_Cond.viewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewpointTypeId) == true)
{
const strComparisonOp_ViewpointTypeId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewpointTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewpointTypeId, objvgs_PViewpointRela_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewpointTypeName) == true)
{
const strComparisonOp_ViewpointTypeName:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewpointTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewpointTypeName, objvgs_PViewpointRela_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_VPProposePeople) == true)
{
const strComparisonOp_VPProposePeople:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_VPProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_VPProposePeople, objvgs_PViewpointRela_Cond.vpProposePeople, strComparisonOp_VPProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_IsSubmit) == true)
{
if (objvgs_PViewpointRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PViewpointRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PViewpointRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_UserTypeId) == true)
{
const strComparisonOp_UserTypeId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_UserTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_UserTypeId, objvgs_PViewpointRela_Cond.userTypeId, strComparisonOp_UserTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_UserTypeName) == true)
{
const strComparisonOp_UserTypeName:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_UserTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_UserTypeName, objvgs_PViewpointRela_Cond.userTypeName, strComparisonOp_UserTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_AppraiseCount, objvgs_PViewpointRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_score) == true)
{
const strComparisonOp_score:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_score, objvgs_PViewpointRela_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_StuScore, objvgs_PViewpointRela_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_TeaScore, objvgs_PViewpointRela_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_OkCount, objvgs_PViewpointRela_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_CitationCount, objvgs_PViewpointRela_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PViewpointRelaEN.con_VersionCount, objvgs_PViewpointRela_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ProposePeople) == true)
{
const strComparisonOp_ProposePeople:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ProposePeople, objvgs_PViewpointRela_Cond.proposePeople, strComparisonOp_ProposePeople);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_UpdDate, objvgs_PViewpointRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_UpdUser, objvgs_PViewpointRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_Memo, objvgs_PViewpointRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewsDate) == true)
{
const strComparisonOp_ViewsDate:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewsDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewsDate, objvgs_PViewpointRela_Cond.viewsDate, strComparisonOp_ViewsDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ViewsUserId) == true)
{
const strComparisonOp_ViewsUserId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ViewsUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ViewsUserId, objvgs_PViewpointRela_Cond.viewsUserId, strComparisonOp_ViewsUserId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_CreateDate, objvgs_PViewpointRela_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PViewpointRela_Cond.dicFldComparisonOp, clsvgs_PViewpointRelaEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvgs_PViewpointRela_Cond.dicFldComparisonOp[clsvgs_PViewpointRelaEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PViewpointRelaEN.con_ShareId, objvgs_PViewpointRela_Cond.shareId, strComparisonOp_ShareId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PViewpointRelaENS:源对象
 * @param objvgs_PViewpointRelaENT:目标对象
*/
export function vgs_PViewpointRela_CopyObjTo(objvgs_PViewpointRelaENS: clsvgs_PViewpointRelaEN , objvgs_PViewpointRelaENT: clsvgs_PViewpointRelaEN ): void 
{
objvgs_PViewpointRelaENT.mId = objvgs_PViewpointRelaENS.mId; //mId
objvgs_PViewpointRelaENT.paperId = objvgs_PViewpointRelaENS.paperId; //论文Id
objvgs_PViewpointRelaENT.paperTitle = objvgs_PViewpointRelaENS.paperTitle; //论文标题
objvgs_PViewpointRelaENT.paperTypeId = objvgs_PViewpointRelaENS.paperTypeId; //论文类型Id
objvgs_PViewpointRelaENT.sectionId = objvgs_PViewpointRelaENS.sectionId; //节Id
objvgs_PViewpointRelaENT.sectionName = objvgs_PViewpointRelaENS.sectionName; //节名
objvgs_PViewpointRelaENT.viewpointId = objvgs_PViewpointRelaENS.viewpointId; //观点Id
objvgs_PViewpointRelaENT.viewpointName = objvgs_PViewpointRelaENS.viewpointName; //观点名称
objvgs_PViewpointRelaENT.viewpointContent = objvgs_PViewpointRelaENS.viewpointContent; //观点内容
objvgs_PViewpointRelaENT.viewpointTypeId = objvgs_PViewpointRelaENS.viewpointTypeId; //观点类型Id
objvgs_PViewpointRelaENT.viewpointTypeName = objvgs_PViewpointRelaENS.viewpointTypeName; //观点类型名
objvgs_PViewpointRelaENT.reason = objvgs_PViewpointRelaENS.reason; //理由
objvgs_PViewpointRelaENT.vpProposePeople = objvgs_PViewpointRelaENS.vpProposePeople; //观点提出人
objvgs_PViewpointRelaENT.isSubmit = objvgs_PViewpointRelaENS.isSubmit; //是否提交
objvgs_PViewpointRelaENT.userTypeId = objvgs_PViewpointRelaENS.userTypeId; //用户类型Id
objvgs_PViewpointRelaENT.userTypeName = objvgs_PViewpointRelaENS.userTypeName; //用户类型名称
objvgs_PViewpointRelaENT.appraiseCount = objvgs_PViewpointRelaENS.appraiseCount; //评论数
objvgs_PViewpointRelaENT.score = objvgs_PViewpointRelaENS.score; //评分
objvgs_PViewpointRelaENT.stuScore = objvgs_PViewpointRelaENS.stuScore; //学生平均分
objvgs_PViewpointRelaENT.teaScore = objvgs_PViewpointRelaENS.teaScore; //教师评分
objvgs_PViewpointRelaENT.okCount = objvgs_PViewpointRelaENS.okCount; //点赞统计
objvgs_PViewpointRelaENT.citationCount = objvgs_PViewpointRelaENS.citationCount; //引用统计
objvgs_PViewpointRelaENT.versionCount = objvgs_PViewpointRelaENS.versionCount; //版本统计
objvgs_PViewpointRelaENT.proposePeople = objvgs_PViewpointRelaENS.proposePeople; //提出人
objvgs_PViewpointRelaENT.updDate = objvgs_PViewpointRelaENS.updDate; //修改日期
objvgs_PViewpointRelaENT.updUser = objvgs_PViewpointRelaENS.updUser; //修改人
objvgs_PViewpointRelaENT.memo = objvgs_PViewpointRelaENS.memo; //备注
objvgs_PViewpointRelaENT.viewsDate = objvgs_PViewpointRelaENS.viewsDate; //ViewsDate
objvgs_PViewpointRelaENT.viewsUserId = objvgs_PViewpointRelaENS.viewsUserId; //ViewsUserId
objvgs_PViewpointRelaENT.createDate = objvgs_PViewpointRelaENS.createDate; //建立日期
objvgs_PViewpointRelaENT.shareId = objvgs_PViewpointRelaENS.shareId; //分享Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PViewpointRelaENS:源对象
 * @param objvgs_PViewpointRelaENT:目标对象
*/
export function vgs_PViewpointRela_GetObjFromJsonObj(objvgs_PViewpointRelaENS: clsvgs_PViewpointRelaEN): clsvgs_PViewpointRelaEN 
{
 const objvgs_PViewpointRelaENT: clsvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
ObjectAssign(objvgs_PViewpointRelaENT, objvgs_PViewpointRelaENS);
 return objvgs_PViewpointRelaENT;
}