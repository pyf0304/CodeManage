
 /**
 * 类名:clsvgs_PTopicObjectiveRelaWApi
 * 表名:vgs_PTopicObjectiveRela(01120667)
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
 * 论文客观关系视图(vgs_PTopicObjectiveRela)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvgs_PTopicObjectiveRelaEN } from "../../L0_Entity/GraduateEduPaper/clsvgs_PTopicObjectiveRelaEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vgs_PTopicObjectiveRela_Controller = "vgs_PTopicObjectiveRelaApi";
 export const vgs_PTopicObjectiveRela_ConstructorName = "vgs_PTopicObjectiveRela";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vgs_PTopicObjectiveRela_GetObjBymIdAsync(lngmId: number): Promise<clsvgs_PTopicObjectiveRelaEN>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PTopicObjectiveRela = vgs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objvgs_PTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function vgs_PTopicObjectiveRela_SortFun_Defa(a:clsvgs_PTopicObjectiveRelaEN , b:clsvgs_PTopicObjectiveRelaEN): number 
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
export function vgs_PTopicObjectiveRela_SortFun_Defa_2Fld(a:clsvgs_PTopicObjectiveRelaEN , b:clsvgs_PTopicObjectiveRelaEN): number 
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
export function vgs_PTopicObjectiveRela_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvgs_PTopicObjectiveRelaEN.con_mId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.mId-b.mId;
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.paperId.localeCompare(b.paperId);
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.paperTitle.localeCompare(b.paperTitle);
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.paperTypeId.localeCompare(b.paperTypeId);
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.sectionId.localeCompare(b.sectionId);
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.sectionName.localeCompare(b.sectionName);
}
case clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.topicObjectiveId.localeCompare(b.topicObjectiveId);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objectiveName.localeCompare(b.objectiveName);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objectiveContent.localeCompare(b.objectiveContent);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objectiveType.localeCompare(b.objectiveType);
}
case clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objectiveTypeName.localeCompare(b.objectiveTypeName);
}
case clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.teaScore-b.teaScore;
}
case clsvgs_PTopicObjectiveRelaEN.con_StuScore:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.stuScore-b.stuScore;
}
case clsvgs_PTopicObjectiveRelaEN.con_score:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.score-b.score;
}
case clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_OkCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.okCount-b.okCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.versionCount-b.versionCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.citationCount-b.citationCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvgs_PTopicObjectiveRelaEN.con_Memo:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objUserId.localeCompare(b.objUserId);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.objDate.localeCompare(b.objDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.conclusion.localeCompare(b.conclusion);
}
case clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_ShareId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return a.shareId.localeCompare(b.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${ vgs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvgs_PTopicObjectiveRelaEN.con_mId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.mId-a.mId;
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.paperId.localeCompare(a.paperId);
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.paperTitle.localeCompare(a.paperTitle);
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.paperTypeId.localeCompare(a.paperTypeId);
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.sectionId.localeCompare(a.sectionId);
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.sectionName.localeCompare(a.sectionName);
}
case clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.topicObjectiveId.localeCompare(a.topicObjectiveId);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objectiveName.localeCompare(a.objectiveName);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objectiveContent.localeCompare(a.objectiveContent);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objectiveType.localeCompare(a.objectiveType);
}
case clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objectiveTypeName.localeCompare(a.objectiveTypeName);
}
case clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.teaScore-a.teaScore;
}
case clsvgs_PTopicObjectiveRelaEN.con_StuScore:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.stuScore-a.stuScore;
}
case clsvgs_PTopicObjectiveRelaEN.con_score:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.score-a.score;
}
case clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_OkCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.okCount-a.okCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.versionCount-a.versionCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.citationCount-a.citationCount;
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvgs_PTopicObjectiveRelaEN.con_Memo:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objUserId.localeCompare(a.objUserId);
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.objDate.localeCompare(a.objDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.conclusion.localeCompare(a.conclusion);
}
case clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsvgs_PTopicObjectiveRelaEN.con_ShareId:
return (a: clsvgs_PTopicObjectiveRelaEN, b: clsvgs_PTopicObjectiveRelaEN) => {
return b.shareId.localeCompare(a.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${ vgs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PTopicObjectiveRela_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvgs_PTopicObjectiveRelaEN.con_mId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.mId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.paperId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTitle:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.paperTitle === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.paperTypeId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.sectionId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_SectionName:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.sectionName === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.topicObjectiveId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objectiveName === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveContent:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objectiveContent === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objectiveType === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_IsSubmit:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.isSubmit === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objectiveTypeName === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_TeaScore:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.teaScore === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_StuScore:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.stuScore === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_score:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.score === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.appraiseCount === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_OkCount:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.okCount === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_VersionCount:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.versionCount === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_CitationCount:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.citationCount === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdDate:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.updDate === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_UpdUser:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.updUser === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_Memo:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.memo === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjUserId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objUserId === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ObjDate:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.objDate === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_Conclusion:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.conclusion === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_CreateDate:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.createDate === value;
}
case clsvgs_PTopicObjectiveRelaEN.con_ShareId:
return (obj: clsvgs_PTopicObjectiveRelaEN) => {
return obj.shareId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vgs_PTopicObjectiveRela]中不存在！(in ${ vgs_PTopicObjectiveRela_ConstructorName}.${ strThisFuncName})`;
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
export async function vgs_PTopicObjectiveRela_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetFirstObjAsync(strWhereCond: string): Promise<clsvgs_PTopicObjectiveRelaEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvgs_PTopicObjectiveRela = vgs_PTopicObjectiveRela_GetObjFromJsonObj(returnObj);
return objvgs_PTopicObjectiveRela;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvgs_PTopicObjectiveRelaEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export async function vgs_PTopicObjectiveRela_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vgs_PTopicObjectiveRela_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vgs_PTopicObjectiveRela_ConstructorName, strThisFuncName);
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
export function vgs_PTopicObjectiveRela_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vgs_PTopicObjectiveRela_GetJSONStrByObj (pobjvgs_PTopicObjectiveRelaEN: clsvgs_PTopicObjectiveRelaEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvgs_PTopicObjectiveRelaEN);
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
export function vgs_PTopicObjectiveRela_GetObjLstByJSONStr (strJSON: string): Array<clsvgs_PTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvgs_PTopicObjectiveRelaObjLst = new Array<clsvgs_PTopicObjectiveRelaEN>();
if (strJSON === "")
{
return arrvgs_PTopicObjectiveRelaObjLst;
}
try
{
arrvgs_PTopicObjectiveRelaObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvgs_PTopicObjectiveRelaObjLst;
}
return arrvgs_PTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvgs_PTopicObjectiveRelaObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vgs_PTopicObjectiveRela_GetObjLstByJSONObjLst (arrvgs_PTopicObjectiveRelaObjLstS: Array<clsvgs_PTopicObjectiveRelaEN>): Array<clsvgs_PTopicObjectiveRelaEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvgs_PTopicObjectiveRelaObjLst = new Array<clsvgs_PTopicObjectiveRelaEN>();
for (const objInFor of arrvgs_PTopicObjectiveRelaObjLstS) {
const obj1 = vgs_PTopicObjectiveRela_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvgs_PTopicObjectiveRelaObjLst.push(obj1);
}
return arrvgs_PTopicObjectiveRelaObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vgs_PTopicObjectiveRela_GetObjByJSONStr (strJSON: string): clsvgs_PTopicObjectiveRelaEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
if (strJSON === "")
{
return pobjvgs_PTopicObjectiveRelaEN;
}
try
{
pobjvgs_PTopicObjectiveRelaEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvgs_PTopicObjectiveRelaEN;
}
return pobjvgs_PTopicObjectiveRelaEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vgs_PTopicObjectiveRela_GetCombineCondition(objvgs_PTopicObjectiveRela_Cond: clsvgs_PTopicObjectiveRelaEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_mId, objvgs_PTopicObjectiveRela_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_PaperId) == true)
{
const strComparisonOp_PaperId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_PaperId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_PaperId, objvgs_PTopicObjectiveRela_Cond.paperId, strComparisonOp_PaperId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_PaperTitle) == true)
{
const strComparisonOp_PaperTitle:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_PaperTitle];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_PaperTitle, objvgs_PTopicObjectiveRela_Cond.paperTitle, strComparisonOp_PaperTitle);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId) == true)
{
const strComparisonOp_PaperTypeId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_PaperTypeId, objvgs_PTopicObjectiveRela_Cond.paperTypeId, strComparisonOp_PaperTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_SectionId) == true)
{
const strComparisonOp_SectionId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_SectionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_SectionId, objvgs_PTopicObjectiveRela_Cond.sectionId, strComparisonOp_SectionId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_SectionName) == true)
{
const strComparisonOp_SectionName:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_SectionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_SectionName, objvgs_PTopicObjectiveRela_Cond.sectionName, strComparisonOp_SectionName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId) == true)
{
const strComparisonOp_TopicObjectiveId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_TopicObjectiveId, objvgs_PTopicObjectiveRela_Cond.topicObjectiveId, strComparisonOp_TopicObjectiveId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName) == true)
{
const strComparisonOp_ObjectiveName:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ObjectiveName, objvgs_PTopicObjectiveRela_Cond.objectiveName, strComparisonOp_ObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType) == true)
{
const strComparisonOp_ObjectiveType:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ObjectiveType, objvgs_PTopicObjectiveRela_Cond.objectiveType, strComparisonOp_ObjectiveType);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_IsSubmit) == true)
{
if (objvgs_PTopicObjectiveRela_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvgs_PTopicObjectiveRelaEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvgs_PTopicObjectiveRelaEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName) == true)
{
const strComparisonOp_ObjectiveTypeName:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ObjectiveTypeName, objvgs_PTopicObjectiveRela_Cond.objectiveTypeName, strComparisonOp_ObjectiveTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_TeaScore, objvgs_PTopicObjectiveRela_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_StuScore, objvgs_PTopicObjectiveRela_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_score) == true)
{
const strComparisonOp_score:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_score, objvgs_PTopicObjectiveRela_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_AppraiseCount, objvgs_PTopicObjectiveRela_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_OkCount, objvgs_PTopicObjectiveRela_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_VersionCount, objvgs_PTopicObjectiveRela_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvgs_PTopicObjectiveRelaEN.con_CitationCount, objvgs_PTopicObjectiveRela_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_UpdDate, objvgs_PTopicObjectiveRela_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_UpdUser, objvgs_PTopicObjectiveRela_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_Memo, objvgs_PTopicObjectiveRela_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ObjUserId) == true)
{
const strComparisonOp_ObjUserId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ObjUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ObjUserId, objvgs_PTopicObjectiveRela_Cond.objUserId, strComparisonOp_ObjUserId);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ObjDate) == true)
{
const strComparisonOp_ObjDate:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ObjDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ObjDate, objvgs_PTopicObjectiveRela_Cond.objDate, strComparisonOp_ObjDate);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_CreateDate, objvgs_PTopicObjectiveRela_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp, clsvgs_PTopicObjectiveRelaEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvgs_PTopicObjectiveRela_Cond.dicFldComparisonOp[clsvgs_PTopicObjectiveRelaEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvgs_PTopicObjectiveRelaEN.con_ShareId, objvgs_PTopicObjectiveRela_Cond.shareId, strComparisonOp_ShareId);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvgs_PTopicObjectiveRelaENS:源对象
 * @param objvgs_PTopicObjectiveRelaENT:目标对象
*/
export function vgs_PTopicObjectiveRela_CopyObjTo(objvgs_PTopicObjectiveRelaENS: clsvgs_PTopicObjectiveRelaEN , objvgs_PTopicObjectiveRelaENT: clsvgs_PTopicObjectiveRelaEN ): void 
{
objvgs_PTopicObjectiveRelaENT.mId = objvgs_PTopicObjectiveRelaENS.mId; //mId
objvgs_PTopicObjectiveRelaENT.paperId = objvgs_PTopicObjectiveRelaENS.paperId; //论文Id
objvgs_PTopicObjectiveRelaENT.paperTitle = objvgs_PTopicObjectiveRelaENS.paperTitle; //论文标题
objvgs_PTopicObjectiveRelaENT.paperTypeId = objvgs_PTopicObjectiveRelaENS.paperTypeId; //论文类型Id
objvgs_PTopicObjectiveRelaENT.sectionId = objvgs_PTopicObjectiveRelaENS.sectionId; //节Id
objvgs_PTopicObjectiveRelaENT.sectionName = objvgs_PTopicObjectiveRelaENS.sectionName; //节名
objvgs_PTopicObjectiveRelaENT.topicObjectiveId = objvgs_PTopicObjectiveRelaENS.topicObjectiveId; //客观Id
objvgs_PTopicObjectiveRelaENT.objectiveName = objvgs_PTopicObjectiveRelaENS.objectiveName; //客观名称
objvgs_PTopicObjectiveRelaENT.objectiveContent = objvgs_PTopicObjectiveRelaENS.objectiveContent; //客观内容
objvgs_PTopicObjectiveRelaENT.objectiveType = objvgs_PTopicObjectiveRelaENS.objectiveType; //客观类型
objvgs_PTopicObjectiveRelaENT.isSubmit = objvgs_PTopicObjectiveRelaENS.isSubmit; //是否提交
objvgs_PTopicObjectiveRelaENT.objectiveTypeName = objvgs_PTopicObjectiveRelaENS.objectiveTypeName; //ObjectiveTypeName
objvgs_PTopicObjectiveRelaENT.teaScore = objvgs_PTopicObjectiveRelaENS.teaScore; //教师评分
objvgs_PTopicObjectiveRelaENT.stuScore = objvgs_PTopicObjectiveRelaENS.stuScore; //学生平均分
objvgs_PTopicObjectiveRelaENT.score = objvgs_PTopicObjectiveRelaENS.score; //评分
objvgs_PTopicObjectiveRelaENT.appraiseCount = objvgs_PTopicObjectiveRelaENS.appraiseCount; //评论数
objvgs_PTopicObjectiveRelaENT.okCount = objvgs_PTopicObjectiveRelaENS.okCount; //点赞统计
objvgs_PTopicObjectiveRelaENT.versionCount = objvgs_PTopicObjectiveRelaENS.versionCount; //版本统计
objvgs_PTopicObjectiveRelaENT.citationCount = objvgs_PTopicObjectiveRelaENS.citationCount; //引用统计
objvgs_PTopicObjectiveRelaENT.updDate = objvgs_PTopicObjectiveRelaENS.updDate; //修改日期
objvgs_PTopicObjectiveRelaENT.updUser = objvgs_PTopicObjectiveRelaENS.updUser; //修改人
objvgs_PTopicObjectiveRelaENT.memo = objvgs_PTopicObjectiveRelaENS.memo; //备注
objvgs_PTopicObjectiveRelaENT.objUserId = objvgs_PTopicObjectiveRelaENS.objUserId; //ObjUserId
objvgs_PTopicObjectiveRelaENT.objDate = objvgs_PTopicObjectiveRelaENS.objDate; //ObjDate
objvgs_PTopicObjectiveRelaENT.conclusion = objvgs_PTopicObjectiveRelaENS.conclusion; //结论
objvgs_PTopicObjectiveRelaENT.createDate = objvgs_PTopicObjectiveRelaENS.createDate; //建立日期
objvgs_PTopicObjectiveRelaENT.shareId = objvgs_PTopicObjectiveRelaENS.shareId; //分享Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvgs_PTopicObjectiveRelaENS:源对象
 * @param objvgs_PTopicObjectiveRelaENT:目标对象
*/
export function vgs_PTopicObjectiveRela_GetObjFromJsonObj(objvgs_PTopicObjectiveRelaENS: clsvgs_PTopicObjectiveRelaEN): clsvgs_PTopicObjectiveRelaEN 
{
 const objvgs_PTopicObjectiveRelaENT: clsvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
ObjectAssign(objvgs_PTopicObjectiveRelaENT, objvgs_PTopicObjectiveRelaENS);
 return objvgs_PTopicObjectiveRelaENT;
}