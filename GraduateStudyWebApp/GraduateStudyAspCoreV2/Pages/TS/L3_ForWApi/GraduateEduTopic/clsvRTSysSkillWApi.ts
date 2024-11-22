
 /**
 * 类名:clsvRTSysSkillWApi
 * 表名:vRTSysSkill(01120656)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:13
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * vRTSysSkill(vRTSysSkill)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsvRTSysSkillEN } from "../../L0_Entity/GraduateEduTopic/clsvRTSysSkillEN.js";
import { clsOrderByData } from "../../PubFun/clsOrderByData.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vRTSysSkill_Controller = "vRTSysSkillApi";
 export const vRTSysSkill_ConstructorName = "vRTSysSkill";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngmId:关键字
 * @returns 对象
 **/
export async function vRTSysSkill_GetObjBymIdAsync(lngmId: number): Promise<clsvRTSysSkillEN|null>  
{
const strThisFuncName = "GetObjBymIdAsync";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvRTSysSkillWApi.GetObjBymIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBymId";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objvRTSysSkill = vRTSysSkill_GetObjFromJsonObj(returnObj);
return objvRTSysSkill;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vRTSysSkill_GetObjBymId_Cache(lngmId: number, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvRTSysSkillWApi.GetObjBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
try
{
const arrvRTSysSkill_Sel: Array <clsvRTSysSkillEN> = arrvRTSysSkillObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objvRTSysSkill: clsvRTSysSkillEN;
if (arrvRTSysSkill_Sel.length > 0)
{
objvRTSysSkill = arrvRTSysSkill_Sel[0];
return objvRTSysSkill;
}
else
{
if (bolTryAsyncOnce == true)
{
const objvRTSysSkill_Const = await vRTSysSkill_GetObjBymIdAsync(lngmId);
if (objvRTSysSkill_Const != null)
{
vRTSysSkill_ReFreshThisCache();
return objvRTSysSkill_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vRTSysSkill_GetObjBymId_localStorage(lngmId: number) {
const strThisFuncName = "GetObjBymId_localStorage";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvRTSysSkillWApi.GetObjBymId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsvRTSysSkillEN._CurrTabName, lngmId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvRTSysSkill_Cache: clsvRTSysSkillEN = JSON.parse(strTempObj);
return objvRTSysSkill_Cache;
}
try
{
const objvRTSysSkill = await vRTSysSkill_GetObjBymIdAsync(lngmId);
if (objvRTSysSkill != null)
{
localStorage.setItem(strKey, JSON.stringify(objvRTSysSkill));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvRTSysSkill;
}
return objvRTSysSkill;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vRTSysSkill_GetNameBymId_Cache(lngmId: number) {
const strThisFuncName = "GetNameBymId_Cache";

if (lngmId == 0)
{
  const strMsg = Format("参数:[lngmId]不能为空！(In clsvRTSysSkillWApi.GetNameBymId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkillObjLst_Cache == null) return "";
try
{
const arrvRTSysSkill_Sel: Array <clsvRTSysSkillEN> = arrvRTSysSkillObjLst_Cache.filter(x => 
 x.mId == lngmId );
let objvRTSysSkill: clsvRTSysSkillEN;
if (arrvRTSysSkill_Sel.length > 0)
{
objvRTSysSkill = arrvRTSysSkill_Sel[0];
return objvRTSysSkill.operationTypeId;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, lngmId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function vRTSysSkill_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsvRTSysSkillEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvRTSysSkillEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsvRTSysSkillEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const lngmId = Number(strInValue);
if (lngmId == 0)
{
return "";
}
const objvRTSysSkill = await vRTSysSkill_GetObjBymId_Cache(lngmId );
if (objvRTSysSkill == null) return "";
if (objvRTSysSkill.GetFldValue(strOutFldName) == null) return "";
return objvRTSysSkill.GetFldValue(strOutFldName).toString();
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
export function vRTSysSkill_SortFun_Defa(a:clsvRTSysSkillEN , b:clsvRTSysSkillEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.mId-b.mId;
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
export function vRTSysSkill_SortFun_Defa_2Fld(a:clsvRTSysSkillEN , b:clsvRTSysSkillEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.topicName == b.topicName) return a.skillName.localeCompare(b.skillName);
else return a.topicName.localeCompare(b.topicName);
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
export function vRTSysSkill_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvRTSysSkillEN.con_TopicName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.topicName == null) return -1;
if (b.topicName == null) return 1;
return a.topicName.localeCompare(b.topicName);
}
case clsvRTSysSkillEN.con_SkillName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.skillName == null) return -1;
if (b.skillName == null) return 1;
return a.skillName.localeCompare(b.skillName);
}
case clsvRTSysSkillEN.con_OperationTypeId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.operationTypeId == null) return -1;
if (b.operationTypeId == null) return 1;
return a.operationTypeId.localeCompare(b.operationTypeId);
}
case clsvRTSysSkillEN.con_Process:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.process == null) return -1;
if (b.process == null) return 1;
return a.process.localeCompare(b.process);
}
case clsvRTSysSkillEN.con_LevelId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.levelId == null) return -1;
if (b.levelId == null) return 1;
return a.levelId.localeCompare(b.levelId);
}
case clsvRTSysSkillEN.con_LevelName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.levelName == null) return -1;
if (b.levelName == null) return 1;
return a.levelName.localeCompare(b.levelName);
}
case clsvRTSysSkillEN.con_SkillUpdUser:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.skillUpdUser == null) return -1;
if (b.skillUpdUser == null) return 1;
return a.skillUpdUser.localeCompare(b.skillUpdUser);
}
case clsvRTSysSkillEN.con_SkillUpdDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.skillUpdDate == null) return -1;
if (b.skillUpdDate == null) return 1;
return a.skillUpdDate.localeCompare(b.skillUpdDate);
}
case clsvRTSysSkillEN.con_OrderNum:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.orderNum-b.orderNum;
}
case clsvRTSysSkillEN.con_id_CurrEduCls:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.id_CurrEduCls == null) return -1;
if (b.id_CurrEduCls == null) return 1;
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsvRTSysSkillEN.con_TopicProposePeople:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.topicProposePeople == null) return -1;
if (b.topicProposePeople == null) return 1;
return a.topicProposePeople.localeCompare(b.topicProposePeople);
}
case clsvRTSysSkillEN.con_TopicContent:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.topicContent == null) return -1;
if (b.topicContent == null) return 1;
return a.topicContent.localeCompare(b.topicContent);
}
case clsvRTSysSkillEN.con_IsSubmit:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsvRTSysSkillEN.con_AppraiseCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsvRTSysSkillEN.con_Score:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.score-b.score;
}
case clsvRTSysSkillEN.con_StuScore:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.stuScore-b.stuScore;
}
case clsvRTSysSkillEN.con_TeaScore:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.teaScore-b.teaScore;
}
case clsvRTSysSkillEN.con_PdfContent:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.pdfContent == null) return -1;
if (b.pdfContent == null) return 1;
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsvRTSysSkillEN.con_PdfPageNum:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsvRTSysSkillEN.con_CitationCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.citationCount-b.citationCount;
}
case clsvRTSysSkillEN.con_VersionCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.versionCount-b.versionCount;
}
case clsvRTSysSkillEN.con_OperationTypeName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.operationTypeName == null) return -1;
if (b.operationTypeName == null) return 1;
return a.operationTypeName.localeCompare(b.operationTypeName);
}
case clsvRTSysSkillEN.con_OkCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.okCount-b.okCount;
}
case clsvRTSysSkillEN.con_CitationId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.citationId == null) return -1;
if (b.citationId == null) return 1;
return a.citationId.localeCompare(b.citationId);
}
case clsvRTSysSkillEN.con_mId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.mId-b.mId;
}
case clsvRTSysSkillEN.con_TopicId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.topicId == null) return -1;
if (b.topicId == null) return 1;
return a.topicId.localeCompare(b.topicId);
}
case clsvRTSysSkillEN.con_SkillId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return a.skillId.localeCompare(b.skillId);
}
case clsvRTSysSkillEN.con_UpdDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsvRTSysSkillEN.con_Memo:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsvRTSysSkillEN.con_UpdUser:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsvRTSysSkillEN.con_CreateDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.createDate == null) return -1;
if (b.createDate == null) return 1;
return a.createDate.localeCompare(b.createDate);
}
case clsvRTSysSkillEN.con_ShareId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.shareId == null) return -1;
if (b.shareId == null) return 1;
return a.shareId.localeCompare(b.shareId);
}
case clsvRTSysSkillEN.con_ClassificationId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (a.classificationId == null) return -1;
if (b.classificationId == null) return 1;
return a.classificationId.localeCompare(b.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${ vRTSysSkill_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvRTSysSkillEN.con_TopicName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.topicName == null) return -1;
if (a.topicName == null) return 1;
return b.topicName.localeCompare(a.topicName);
}
case clsvRTSysSkillEN.con_SkillName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.skillName == null) return -1;
if (a.skillName == null) return 1;
return b.skillName.localeCompare(a.skillName);
}
case clsvRTSysSkillEN.con_OperationTypeId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.operationTypeId == null) return -1;
if (a.operationTypeId == null) return 1;
return b.operationTypeId.localeCompare(a.operationTypeId);
}
case clsvRTSysSkillEN.con_Process:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.process == null) return -1;
if (a.process == null) return 1;
return b.process.localeCompare(a.process);
}
case clsvRTSysSkillEN.con_LevelId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.levelId == null) return -1;
if (a.levelId == null) return 1;
return b.levelId.localeCompare(a.levelId);
}
case clsvRTSysSkillEN.con_LevelName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.levelName == null) return -1;
if (a.levelName == null) return 1;
return b.levelName.localeCompare(a.levelName);
}
case clsvRTSysSkillEN.con_SkillUpdUser:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.skillUpdUser == null) return -1;
if (a.skillUpdUser == null) return 1;
return b.skillUpdUser.localeCompare(a.skillUpdUser);
}
case clsvRTSysSkillEN.con_SkillUpdDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.skillUpdDate == null) return -1;
if (a.skillUpdDate == null) return 1;
return b.skillUpdDate.localeCompare(a.skillUpdDate);
}
case clsvRTSysSkillEN.con_OrderNum:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.orderNum-a.orderNum;
}
case clsvRTSysSkillEN.con_id_CurrEduCls:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.id_CurrEduCls == null) return -1;
if (a.id_CurrEduCls == null) return 1;
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsvRTSysSkillEN.con_TopicProposePeople:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.topicProposePeople == null) return -1;
if (a.topicProposePeople == null) return 1;
return b.topicProposePeople.localeCompare(a.topicProposePeople);
}
case clsvRTSysSkillEN.con_TopicContent:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.topicContent == null) return -1;
if (a.topicContent == null) return 1;
return b.topicContent.localeCompare(a.topicContent);
}
case clsvRTSysSkillEN.con_IsSubmit:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsvRTSysSkillEN.con_AppraiseCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsvRTSysSkillEN.con_Score:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.score-a.score;
}
case clsvRTSysSkillEN.con_StuScore:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.stuScore-a.stuScore;
}
case clsvRTSysSkillEN.con_TeaScore:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.teaScore-a.teaScore;
}
case clsvRTSysSkillEN.con_PdfContent:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.pdfContent == null) return -1;
if (a.pdfContent == null) return 1;
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsvRTSysSkillEN.con_PdfPageNum:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsvRTSysSkillEN.con_CitationCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.citationCount-a.citationCount;
}
case clsvRTSysSkillEN.con_VersionCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.versionCount-a.versionCount;
}
case clsvRTSysSkillEN.con_OperationTypeName:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.operationTypeName == null) return -1;
if (a.operationTypeName == null) return 1;
return b.operationTypeName.localeCompare(a.operationTypeName);
}
case clsvRTSysSkillEN.con_OkCount:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.okCount-a.okCount;
}
case clsvRTSysSkillEN.con_CitationId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.citationId == null) return -1;
if (a.citationId == null) return 1;
return b.citationId.localeCompare(a.citationId);
}
case clsvRTSysSkillEN.con_mId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.mId-a.mId;
}
case clsvRTSysSkillEN.con_TopicId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.topicId == null) return -1;
if (a.topicId == null) return 1;
return b.topicId.localeCompare(a.topicId);
}
case clsvRTSysSkillEN.con_SkillId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
return b.skillId.localeCompare(a.skillId);
}
case clsvRTSysSkillEN.con_UpdDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsvRTSysSkillEN.con_Memo:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsvRTSysSkillEN.con_UpdUser:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsvRTSysSkillEN.con_CreateDate:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.createDate == null) return -1;
if (a.createDate == null) return 1;
return b.createDate.localeCompare(a.createDate);
}
case clsvRTSysSkillEN.con_ShareId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.shareId == null) return -1;
if (a.shareId == null) return 1;
return b.shareId.localeCompare(a.shareId);
}
case clsvRTSysSkillEN.con_ClassificationId:
return (a: clsvRTSysSkillEN, b: clsvRTSysSkillEN) => {
if (b.classificationId == null) return -1;
if (a.classificationId == null) return 1;
return b.classificationId.localeCompare(a.classificationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${ vRTSysSkill_ConstructorName}.${ strThisFuncName})`;
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
export async function vRTSysSkill_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvRTSysSkillEN.con_TopicName:
return (obj: clsvRTSysSkillEN) => {
return obj.topicName === value;
}
case clsvRTSysSkillEN.con_SkillName:
return (obj: clsvRTSysSkillEN) => {
return obj.skillName === value;
}
case clsvRTSysSkillEN.con_OperationTypeId:
return (obj: clsvRTSysSkillEN) => {
return obj.operationTypeId === value;
}
case clsvRTSysSkillEN.con_Process:
return (obj: clsvRTSysSkillEN) => {
return obj.process === value;
}
case clsvRTSysSkillEN.con_LevelId:
return (obj: clsvRTSysSkillEN) => {
return obj.levelId === value;
}
case clsvRTSysSkillEN.con_LevelName:
return (obj: clsvRTSysSkillEN) => {
return obj.levelName === value;
}
case clsvRTSysSkillEN.con_SkillUpdUser:
return (obj: clsvRTSysSkillEN) => {
return obj.skillUpdUser === value;
}
case clsvRTSysSkillEN.con_SkillUpdDate:
return (obj: clsvRTSysSkillEN) => {
return obj.skillUpdDate === value;
}
case clsvRTSysSkillEN.con_OrderNum:
return (obj: clsvRTSysSkillEN) => {
return obj.orderNum === value;
}
case clsvRTSysSkillEN.con_id_CurrEduCls:
return (obj: clsvRTSysSkillEN) => {
return obj.id_CurrEduCls === value;
}
case clsvRTSysSkillEN.con_TopicProposePeople:
return (obj: clsvRTSysSkillEN) => {
return obj.topicProposePeople === value;
}
case clsvRTSysSkillEN.con_TopicContent:
return (obj: clsvRTSysSkillEN) => {
return obj.topicContent === value;
}
case clsvRTSysSkillEN.con_IsSubmit:
return (obj: clsvRTSysSkillEN) => {
return obj.isSubmit === value;
}
case clsvRTSysSkillEN.con_AppraiseCount:
return (obj: clsvRTSysSkillEN) => {
return obj.appraiseCount === value;
}
case clsvRTSysSkillEN.con_Score:
return (obj: clsvRTSysSkillEN) => {
return obj.score === value;
}
case clsvRTSysSkillEN.con_StuScore:
return (obj: clsvRTSysSkillEN) => {
return obj.stuScore === value;
}
case clsvRTSysSkillEN.con_TeaScore:
return (obj: clsvRTSysSkillEN) => {
return obj.teaScore === value;
}
case clsvRTSysSkillEN.con_PdfContent:
return (obj: clsvRTSysSkillEN) => {
return obj.pdfContent === value;
}
case clsvRTSysSkillEN.con_PdfPageNum:
return (obj: clsvRTSysSkillEN) => {
return obj.pdfPageNum === value;
}
case clsvRTSysSkillEN.con_CitationCount:
return (obj: clsvRTSysSkillEN) => {
return obj.citationCount === value;
}
case clsvRTSysSkillEN.con_VersionCount:
return (obj: clsvRTSysSkillEN) => {
return obj.versionCount === value;
}
case clsvRTSysSkillEN.con_OperationTypeName:
return (obj: clsvRTSysSkillEN) => {
return obj.operationTypeName === value;
}
case clsvRTSysSkillEN.con_OkCount:
return (obj: clsvRTSysSkillEN) => {
return obj.okCount === value;
}
case clsvRTSysSkillEN.con_CitationId:
return (obj: clsvRTSysSkillEN) => {
return obj.citationId === value;
}
case clsvRTSysSkillEN.con_mId:
return (obj: clsvRTSysSkillEN) => {
return obj.mId === value;
}
case clsvRTSysSkillEN.con_TopicId:
return (obj: clsvRTSysSkillEN) => {
return obj.topicId === value;
}
case clsvRTSysSkillEN.con_SkillId:
return (obj: clsvRTSysSkillEN) => {
return obj.skillId === value;
}
case clsvRTSysSkillEN.con_UpdDate:
return (obj: clsvRTSysSkillEN) => {
return obj.updDate === value;
}
case clsvRTSysSkillEN.con_Memo:
return (obj: clsvRTSysSkillEN) => {
return obj.memo === value;
}
case clsvRTSysSkillEN.con_UpdUser:
return (obj: clsvRTSysSkillEN) => {
return obj.updUser === value;
}
case clsvRTSysSkillEN.con_CreateDate:
return (obj: clsvRTSysSkillEN) => {
return obj.createDate === value;
}
case clsvRTSysSkillEN.con_ShareId:
return (obj: clsvRTSysSkillEN) => {
return obj.shareId === value;
}
case clsvRTSysSkillEN.con_ClassificationId:
return (obj: clsvRTSysSkillEN) => {
return obj.classificationId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vRTSysSkill]中不存在！(in ${ vRTSysSkill_ConstructorName}.${ strThisFuncName})`;
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
 * @returns 返回一个关键字值列表
*/
export async function vRTSysSkill_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<number>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsvRTSysSkillEN.con_mId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (Number(strInValue) == 0)
{
return [];
}
const arrvRTSysSkill = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkill == null) return [];
let arrvRTSysSkill_Sel = arrvRTSysSkill;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrvRTSysSkill_Sel.length == 0) return [];
return arrvRTSysSkill_Sel.map(x=>x.mId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function vRTSysSkill_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetFirstObjAsync(strWhereCond: string): Promise<clsvRTSysSkillEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const objvRTSysSkill = vRTSysSkill_GetObjFromJsonObj(returnObj);
return objvRTSysSkill;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTSysSkillEN._CurrTabName;
if (IsNullOrEmpty(clsvRTSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTSysSkillEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvRTSysSkillExObjLst_Cache: Array<clsvRTSysSkillEN> = CacheHelper.Get(strKey);
const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
return arrvRTSysSkillObjLst_T;
}
try
{
const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvRTSysSkillExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
console.log(strInfo);
return arrvRTSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTSysSkill_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTSysSkillEN._CurrTabName;
if (IsNullOrEmpty(clsvRTSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTSysSkillEN.CacheAddiCondition);
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
const arrvRTSysSkillExObjLst_Cache: Array<clsvRTSysSkillEN> = JSON.parse(strTempObjLst);
const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
return arrvRTSysSkillObjLst_T;
}
try
{
const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvRTSysSkillExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
console.log(strInfo);
return arrvRTSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTSysSkill_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTSysSkillEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvRTSysSkillObjLst_Cache: Array<clsvRTSysSkillEN> = JSON.parse(strTempObjLst);
return arrvRTSysSkillObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vRTSysSkill_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvRTSysSkillEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvRTSysSkillEN._CurrTabName;
if (IsNullOrEmpty(clsvRTSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvRTSysSkillEN.CacheAddiCondition);
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
const arrvRTSysSkillExObjLst_Cache: Array<clsvRTSysSkillEN> = JSON.parse(strTempObjLst);
const arrvRTSysSkillObjLst_T = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillExObjLst_Cache);
return arrvRTSysSkillObjLst_T;
}
try
{
const arrvRTSysSkillExObjLst = await vRTSysSkill_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvRTSysSkillExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvRTSysSkillExObjLst.length);
console.log(strInfo);
return arrvRTSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTSysSkill_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvRTSysSkillEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvRTSysSkillObjLst_Cache: Array<clsvRTSysSkillEN> = JSON.parse(strTempObjLst);
return arrvRTSysSkillObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTSysSkill_GetObjLst_Cache(): Promise<Array<clsvRTSysSkillEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvRTSysSkillObjLst_Cache;
switch (clsvRTSysSkillEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_ClientCache();
break;
default:
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_ClientCache();
break;
}
const arrvRTSysSkillObjLst = vRTSysSkill_GetObjLstByJSONObjLst(arrvRTSysSkillObjLst_Cache);
return arrvRTSysSkillObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vRTSysSkill_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvRTSysSkillObjLst_Cache;
switch (clsvRTSysSkillEN.CacheModeId)
{
case "04"://sessionStorage
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvRTSysSkillObjLst_Cache = null;
break;
default:
arrvRTSysSkillObjLst_Cache = null;
break;
}
return arrvRTSysSkillObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTSysSkill_GetSubObjLst_Cache(objvRTSysSkill_Cond: clsvRTSysSkillEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
let arrvRTSysSkill_Sel: Array < clsvRTSysSkillEN > = arrvRTSysSkillObjLst_Cache;
if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "") return arrvRTSysSkill_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTSysSkill_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvRTSysSkill_Cond), vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTSysSkillEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrmId:关键字列表
 * @returns 对象列表
 **/
export async function vRTSysSkill_GetObjLstBymIdLstAsync(arrmId: Array<string>): Promise<Array<clsvRTSysSkillEN>>  
{
const strThisFuncName = "GetObjLstBymIdLstAsync";
const strAction = "GetObjLstBymIdLst";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrmId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * @param arrlngmIdLst:关键字列表
 * @returns 对象列表
*/
export async function vRTSysSkill_GetObjLstBymIdLst_Cache(arrmIdLst: Array<number>) {
const strThisFuncName = "GetObjLstBymIdLst_Cache";
try
{
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
const arrvRTSysSkill_Sel: Array <clsvRTSysSkillEN> = arrvRTSysSkillObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId)>-1);
return arrvRTSysSkill_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvRTSysSkillEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvRTSysSkillEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsvRTSysSkillEN>();
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkillObjLst_Cache.length == 0) return arrvRTSysSkillObjLst_Cache;
let arrvRTSysSkill_Sel = arrvRTSysSkillObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvRTSysSkill_Cond = new clsvRTSysSkillEN();
ObjectAssign(objvRTSysSkill_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvRTSysSkillWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTSysSkill_Sel.length == 0) return arrvRTSysSkill_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.sort(vRTSysSkill_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.sort(objPagerPara.sortFun);
}
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.slice(intStart, intEnd);     
return arrvRTSysSkill_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvRTSysSkillEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vRTSysSkill_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvRTSysSkillEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvRTSysSkillEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vRTSysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移顶
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
 * @param objvRTSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTSysSkill_GoTopAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoTopAsync";
let strMsg = "";
const strAction = "GoTop";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
throw strMsg;
}
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录上移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
 * @param objvRTSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTSysSkill_UpMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "UpMoveAsync";
let strMsg = "";
const strAction = "UpMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTSysSkillEN);
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录下移
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
 * @param objvRTSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTSysSkill_DownMoveAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "DownMoveAsync";
let strMsg = "";
const strAction = "DownMove";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTSysSkillEN);
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return (data.returnBool);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * 把所给的关键字列表相关的记录移底
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
 * @param objvRTSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTSysSkill_GoBottomAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "GoBottomAsync";
let strMsg = "";
const strAction = "GoBottom";
if (objOrderByData.KeyIdLst.length == 0)
{
strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objvRTSysSkillEN);
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * 把列表记录重序
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
 * @param objvRTSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function vRTSysSkill_ReOrderAsync(objOrderByData: clsOrderByData): Promise<boolean> 
{
const strThisFuncName = "ReOrderAsync";
const strAction = "ReOrder";
 //var strJSON = JSON.stringify(objvRTSysSkillEN);
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objOrderByData);
const data = response.data;
if (data.errorId == 0)
{
return data.returnBool;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * @param objlngmId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vRTSysSkill_IsExistRecord_Cache(objvRTSysSkill_Cond: clsvRTSysSkillEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkillObjLst_Cache == null) return false;
let arrvRTSysSkill_Sel: Array < clsvRTSysSkillEN > = arrvRTSysSkillObjLst_Cache;
if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "") return arrvRTSysSkill_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvRTSysSkill_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvRTSysSkill_Cond), vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_IsExist(lngmId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * @param lngmId:所给的关键字
 * @returns 对象
*/
export async function vRTSysSkill_IsExist_Cache(lngmId:number) {
const strThisFuncName = "IsExist_Cache";
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkillObjLst_Cache == null) return false;
try
{
const arrvRTSysSkill_Sel: Array <clsvRTSysSkillEN> = arrvRTSysSkillObjLst_Cache.filter(x => x.mId == lngmId);
if (arrvRTSysSkill_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param lngmId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vRTSysSkill_IsExistAsync(lngmId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
export async function vRTSysSkill_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vRTSysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vRTSysSkill_ConstructorName, strThisFuncName);
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
 * @param objvRTSysSkill_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vRTSysSkill_GetRecCountByCond_Cache(objvRTSysSkill_Cond: clsvRTSysSkillEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvRTSysSkillObjLst_Cache = await vRTSysSkill_GetObjLst_Cache();
if (arrvRTSysSkillObjLst_Cache == null) return 0;
let arrvRTSysSkill_Sel: Array < clsvRTSysSkillEN > = arrvRTSysSkillObjLst_Cache;
if (objvRTSysSkill_Cond.sf_FldComparisonOp == null || objvRTSysSkill_Cond.sf_FldComparisonOp == "") return arrvRTSysSkill_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvRTSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsvRTSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvRTSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvRTSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvRTSysSkill_Sel = arrvRTSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvRTSysSkill_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvRTSysSkill_Cond), vRTSysSkill_ConstructorName, strThisFuncName);
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
export function vRTSysSkill_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vRTSysSkill_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvRTSysSkillEN._CurrTabName;
switch (clsvRTSysSkillEN.CacheModeId)
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

/**
 * 绑定基于Web的下拉框,在某一层下的下拉框
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
 * @param objDDL:需要绑定当前表的下拉框
*/
export async function vRTSysSkill__Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In )", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：_Cache");
const arrObjLst_Sel = await vRTSysSkill_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv_V(strDivName, strDdlName, arrObjLst_Sel, clsvRTSysSkillEN.con_mId, clsvRTSysSkillEN.con_OperationTypeId, "vRTSysSkill");
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTSysSkill_GetJSONStrByObj (pobjvRTSysSkillEN: clsvRTSysSkillEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvRTSysSkillEN);
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
export function vRTSysSkill_GetObjLstByJSONStr (strJSON: string): Array<clsvRTSysSkillEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvRTSysSkillObjLst = new Array<clsvRTSysSkillEN>();
if (strJSON === "")
{
return arrvRTSysSkillObjLst;
}
try
{
arrvRTSysSkillObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvRTSysSkillObjLst;
}
return arrvRTSysSkillObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvRTSysSkillObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vRTSysSkill_GetObjLstByJSONObjLst (arrvRTSysSkillObjLstS: Array<clsvRTSysSkillEN>): Array<clsvRTSysSkillEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvRTSysSkillObjLst = new Array<clsvRTSysSkillEN>();
for (const objInFor of arrvRTSysSkillObjLstS) {
const obj1 = vRTSysSkill_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvRTSysSkillObjLst.push(obj1);
}
return arrvRTSysSkillObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vRTSysSkill_GetObjByJSONStr (strJSON: string): clsvRTSysSkillEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvRTSysSkillEN = new clsvRTSysSkillEN();
if (strJSON === "")
{
return pobjvRTSysSkillEN;
}
try
{
pobjvRTSysSkillEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvRTSysSkillEN;
}
return pobjvRTSysSkillEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vRTSysSkill_GetCombineCondition(objvRTSysSkill_Cond: clsvRTSysSkillEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_TopicName) == true)
{
const strComparisonOp_TopicName:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_TopicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_TopicName, objvRTSysSkill_Cond.topicName, strComparisonOp_TopicName);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_SkillName) == true)
{
const strComparisonOp_SkillName:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_SkillName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_SkillName, objvRTSysSkill_Cond.skillName, strComparisonOp_SkillName);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_OperationTypeId) == true)
{
const strComparisonOp_OperationTypeId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_OperationTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_OperationTypeId, objvRTSysSkill_Cond.operationTypeId, strComparisonOp_OperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_LevelId) == true)
{
const strComparisonOp_LevelId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_LevelId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_LevelId, objvRTSysSkill_Cond.levelId, strComparisonOp_LevelId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_LevelName) == true)
{
const strComparisonOp_LevelName:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_LevelName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_LevelName, objvRTSysSkill_Cond.levelName, strComparisonOp_LevelName);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_SkillUpdUser) == true)
{
const strComparisonOp_SkillUpdUser:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_SkillUpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_SkillUpdUser, objvRTSysSkill_Cond.skillUpdUser, strComparisonOp_SkillUpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_SkillUpdDate) == true)
{
const strComparisonOp_SkillUpdDate:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_SkillUpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_SkillUpdDate, objvRTSysSkill_Cond.skillUpdDate, strComparisonOp_SkillUpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_OrderNum, objvRTSysSkill_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_id_CurrEduCls, objvRTSysSkill_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_TopicProposePeople) == true)
{
const strComparisonOp_TopicProposePeople:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_TopicProposePeople];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_TopicProposePeople, objvRTSysSkill_Cond.topicProposePeople, strComparisonOp_TopicProposePeople);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_IsSubmit) == true)
{
if (objvRTSysSkill_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvRTSysSkillEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvRTSysSkillEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_AppraiseCount, objvRTSysSkill_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_Score) == true)
{
const strComparisonOp_Score:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_Score];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_Score, objvRTSysSkill_Cond.score, strComparisonOp_Score);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_StuScore, objvRTSysSkill_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_TeaScore, objvRTSysSkill_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_PdfContent, objvRTSysSkill_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_PdfPageNum, objvRTSysSkill_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_CitationCount, objvRTSysSkill_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_VersionCount, objvRTSysSkill_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_OperationTypeName) == true)
{
const strComparisonOp_OperationTypeName:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_OperationTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_OperationTypeName, objvRTSysSkill_Cond.operationTypeName, strComparisonOp_OperationTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_OkCount, objvRTSysSkill_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_CitationId, objvRTSysSkill_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_mId) == true)
{
const strComparisonOp_mId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_mId];
strWhereCond += Format(" And {0} {2} {1}", clsvRTSysSkillEN.con_mId, objvRTSysSkill_Cond.mId, strComparisonOp_mId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_TopicId) == true)
{
const strComparisonOp_TopicId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_TopicId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_TopicId, objvRTSysSkill_Cond.topicId, strComparisonOp_TopicId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_SkillId) == true)
{
const strComparisonOp_SkillId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_SkillId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_SkillId, objvRTSysSkill_Cond.skillId, strComparisonOp_SkillId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_UpdDate, objvRTSysSkill_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_Memo, objvRTSysSkill_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_UpdUser, objvRTSysSkill_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_CreateDate, objvRTSysSkill_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_ShareId, objvRTSysSkill_Cond.shareId, strComparisonOp_ShareId);
}
if (Object.prototype.hasOwnProperty.call(objvRTSysSkill_Cond.dicFldComparisonOp, clsvRTSysSkillEN.con_ClassificationId) == true)
{
const strComparisonOp_ClassificationId:string = objvRTSysSkill_Cond.dicFldComparisonOp[clsvRTSysSkillEN.con_ClassificationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvRTSysSkillEN.con_ClassificationId, objvRTSysSkill_Cond.classificationId, strComparisonOp_ClassificationId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vRTSysSkill_GetUniCondStr_mId(objvRTSysSkillEN: clsvRTSysSkillEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and mId = '{0}'", objvRTSysSkillEN.mId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--vRTSysSkill(vRTSysSkill),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngmId: mId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function vRTSysSkill_GetUniCondStr4Update_mId(objvRTSysSkillEN: clsvRTSysSkillEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and mId <> '{0}'", objvRTSysSkillEN.mId);
 strWhereCond +=  Format(" and mId = '{0}'", objvRTSysSkillEN.mId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvRTSysSkillENS:源对象
 * @param objvRTSysSkillENT:目标对象
*/
export function vRTSysSkill_CopyObjTo(objvRTSysSkillENS: clsvRTSysSkillEN , objvRTSysSkillENT: clsvRTSysSkillEN ): void 
{
objvRTSysSkillENT.topicName = objvRTSysSkillENS.topicName; //栏目主题
objvRTSysSkillENT.skillName = objvRTSysSkillENS.skillName; //技能名称
objvRTSysSkillENT.operationTypeId = objvRTSysSkillENS.operationTypeId; //操作类型ID
objvRTSysSkillENT.process = objvRTSysSkillENS.process; //实施过程
objvRTSysSkillENT.levelId = objvRTSysSkillENS.levelId; //级别Id
objvRTSysSkillENT.levelName = objvRTSysSkillENS.levelName; //级别名称
objvRTSysSkillENT.skillUpdUser = objvRTSysSkillENS.skillUpdUser; //SkillUpdUser
objvRTSysSkillENT.skillUpdDate = objvRTSysSkillENS.skillUpdDate; //SkillUpdDate
objvRTSysSkillENT.orderNum = objvRTSysSkillENS.orderNum; //序号
objvRTSysSkillENT.id_CurrEduCls = objvRTSysSkillENS.id_CurrEduCls; //教学班流水号
objvRTSysSkillENT.topicProposePeople = objvRTSysSkillENS.topicProposePeople; //主题提出人
objvRTSysSkillENT.topicContent = objvRTSysSkillENS.topicContent; //主题内容
objvRTSysSkillENT.isSubmit = objvRTSysSkillENS.isSubmit; //是否提交
objvRTSysSkillENT.appraiseCount = objvRTSysSkillENS.appraiseCount; //评论数
objvRTSysSkillENT.score = objvRTSysSkillENS.score; //评分
objvRTSysSkillENT.stuScore = objvRTSysSkillENS.stuScore; //学生平均分
objvRTSysSkillENT.teaScore = objvRTSysSkillENS.teaScore; //教师评分
objvRTSysSkillENT.pdfContent = objvRTSysSkillENS.pdfContent; //Pdf内容
objvRTSysSkillENT.pdfPageNum = objvRTSysSkillENS.pdfPageNum; //Pdf页码
objvRTSysSkillENT.citationCount = objvRTSysSkillENS.citationCount; //引用统计
objvRTSysSkillENT.versionCount = objvRTSysSkillENS.versionCount; //版本统计
objvRTSysSkillENT.operationTypeName = objvRTSysSkillENS.operationTypeName; //操作类型名
objvRTSysSkillENT.okCount = objvRTSysSkillENS.okCount; //点赞统计
objvRTSysSkillENT.citationId = objvRTSysSkillENS.citationId; //引用Id
objvRTSysSkillENT.mId = objvRTSysSkillENS.mId; //mId
objvRTSysSkillENT.topicId = objvRTSysSkillENS.topicId; //主题Id
objvRTSysSkillENT.skillId = objvRTSysSkillENS.skillId; //技能Id
objvRTSysSkillENT.updDate = objvRTSysSkillENS.updDate; //修改日期
objvRTSysSkillENT.memo = objvRTSysSkillENS.memo; //备注
objvRTSysSkillENT.updUser = objvRTSysSkillENS.updUser; //修改人
objvRTSysSkillENT.createDate = objvRTSysSkillENS.createDate; //建立日期
objvRTSysSkillENT.shareId = objvRTSysSkillENS.shareId; //分享Id
objvRTSysSkillENT.classificationId = objvRTSysSkillENS.classificationId; //分类Id
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvRTSysSkillENS:源对象
 * @param objvRTSysSkillENT:目标对象
*/
export function vRTSysSkill_GetObjFromJsonObj(objvRTSysSkillENS: clsvRTSysSkillEN): clsvRTSysSkillEN 
{
 const objvRTSysSkillENT: clsvRTSysSkillEN = new clsvRTSysSkillEN();
ObjectAssign(objvRTSysSkillENT, objvRTSysSkillENS);
 return objvRTSysSkillENT;
}