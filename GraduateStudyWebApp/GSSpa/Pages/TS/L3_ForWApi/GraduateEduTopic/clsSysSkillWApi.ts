
 /**
 * 类名:clsSysSkillWApi
 * 表名:SysSkill(01120646)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:58
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
 * 技能表(SysSkill)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsSysSkillEN } from "../../L0_Entity/GraduateEduTopic/clsSysSkillEN.js";
import { vSysSkill_ReFreshThisCache } from "../../L3_ForWApi/GraduateEduTopic/clsvSysSkillWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysSkill_Controller = "SysSkillApi";
 export const sysSkill_ConstructorName = "sysSkill";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strSkillId:关键字
 * @returns 对象
 **/
export async function SysSkill_GetObjBySkillIdAsync(strSkillId: string): Promise<clsSysSkillEN>  
{
const strThisFuncName = "GetObjBySkillIdAsync";

if (IsNullOrEmpty(strSkillId) == true)
{
  const strMsg = Format("参数:[strSkillId]不能为空！(In GetObjBySkillIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strSkillId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSkillId]的长度:[{0}]不正确！", strSkillId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjBySkillId";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strSkillId": strSkillId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSkill = SysSkill_GetObjFromJsonObj(returnObj);
return objSysSkill;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param strSkillId:所给的关键字
 * @returns 对象
*/
export async function SysSkill_GetObjBySkillId_Cache(strSkillId:string,strid_CurrEduCls:string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjBySkillId_Cache";

if (IsNullOrEmpty(strSkillId) == true)
{
  const strMsg = Format("参数:[strSkillId]不能为空！(In GetObjBySkillId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strSkillId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSkillId]的长度:[{0}]不正确！", strSkillId.length);
console.error(strMsg);
throw (strMsg);
}
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
try
{
const arrSysSkill_Sel: Array <clsSysSkillEN> = arrSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
let objSysSkill: clsSysSkillEN;
if (arrSysSkill_Sel.length > 0)
{
objSysSkill = arrSysSkill_Sel[0];
return objSysSkill;
}
else
{
if (bolTryAsyncOnce == true)
{
objSysSkill = await SysSkill_GetObjBySkillIdAsync(strSkillId);
if (objSysSkill != null)
{
SysSkill_ReFreshThisCache(strid_CurrEduCls);
return objSysSkill;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strSkillId:所给的关键字
 * @returns 对象
*/
export async function SysSkill_GetObjBySkillId_localStorage(strSkillId: string) {
const strThisFuncName = "GetObjBySkillId_localStorage";

if (IsNullOrEmpty(strSkillId) == true)
{
  const strMsg = Format("参数:[strSkillId]不能为空！(In GetObjBySkillId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strSkillId.length != 10)
{
const strMsg = Format("缓存分类变量:[strSkillId]的长度:[{0}]不正确！", strSkillId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strSkillId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objSysSkill_Cache: clsSysSkillEN = JSON.parse(strTempObj);
return objSysSkill_Cache;
}
try
{
const objSysSkill = await SysSkill_GetObjBySkillIdAsync(strSkillId);
if (objSysSkill != null)
{
localStorage.setItem(strKey, JSON.stringify(objSysSkill));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objSysSkill;
}
return objSysSkill;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSkillId, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objSysSkill:所给的对象
 * @returns 对象
*/
export async function SysSkill_UpdateObjInLst_Cache(objSysSkill: clsSysSkillEN,strid_CurrEduCls: string) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
const obj = arrSysSkillObjLst_Cache.find(x => x.skillId == objSysSkill.skillId);
if (obj != null)
{
objSysSkill.skillId = obj.skillId;
ObjectAssign( obj, objSysSkill);
}
else
{
arrSysSkillObjLst_Cache.push(objSysSkill);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
export async function SysSkill_func(strInFldName:string , strOutFldName:string , strInValue:string , strid_CurrEduCls_C: string)
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

if (strInFldName != clsSysSkillEN.con_SkillId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsSysSkillEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsSysSkillEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strSkillId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objSysSkill = await SysSkill_GetObjBySkillId_Cache(strSkillId , strid_CurrEduCls_C);
if (objSysSkill == null) return "";
return objSysSkill.GetFldValue(strOutFldName).toString();
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
export function SysSkill_SortFun_Defa(a:clsSysSkillEN , b:clsSysSkillEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.skillId.localeCompare(b.skillId);
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
export function SysSkill_SortFun_Defa_2Fld(a:clsSysSkillEN , b:clsSysSkillEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.skillName == b.skillName) return a.operationTypeId.localeCompare(b.operationTypeId);
else return a.skillName.localeCompare(b.skillName);
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
export function SysSkill_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysSkillEN.con_SkillId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.skillId.localeCompare(b.skillId);
}
case clsSysSkillEN.con_SkillName:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.skillName.localeCompare(b.skillName);
}
case clsSysSkillEN.con_OperationTypeId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.operationTypeId.localeCompare(b.operationTypeId);
}
case clsSysSkillEN.con_Process:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.process.localeCompare(b.process);
}
case clsSysSkillEN.con_LevelId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.levelId.localeCompare(b.levelId);
}
case clsSysSkillEN.con_UpdUser:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSysSkillEN.con_UpdDate:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSysSkillEN.con_IsSubmit:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
if (a.isSubmit == true) return 1;
else return -1
}
case clsSysSkillEN.con_CitationId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsSysSkillEN.con_OkCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.okCount-b.okCount;
}
case clsSysSkillEN.con_AppraiseCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.appraiseCount-b.appraiseCount;
}
case clsSysSkillEN.con_score:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.score-b.score;
}
case clsSysSkillEN.con_StuScore:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.stuScore-b.stuScore;
}
case clsSysSkillEN.con_TeaScore:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.teaScore-b.teaScore;
}
case clsSysSkillEN.con_id_CurrEduCls:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysSkillEN.con_PdfContent:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsSysSkillEN.con_PdfPageNum:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsSysSkillEN.con_CitationCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.citationCount-b.citationCount;
}
case clsSysSkillEN.con_VersionCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.versionCount-b.versionCount;
}
case clsSysSkillEN.con_Memo:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.memo.localeCompare(b.memo);
}
case clsSysSkillEN.con_CreateDate:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.createDate.localeCompare(b.createDate);
}
case clsSysSkillEN.con_ShareId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return a.shareId.localeCompare(b.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${ sysSkill_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysSkillEN.con_SkillId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.skillId.localeCompare(a.skillId);
}
case clsSysSkillEN.con_SkillName:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.skillName.localeCompare(a.skillName);
}
case clsSysSkillEN.con_OperationTypeId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.operationTypeId.localeCompare(a.operationTypeId);
}
case clsSysSkillEN.con_Process:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.process.localeCompare(a.process);
}
case clsSysSkillEN.con_LevelId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.levelId.localeCompare(a.levelId);
}
case clsSysSkillEN.con_UpdUser:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSysSkillEN.con_UpdDate:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSysSkillEN.con_IsSubmit:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
if (b.isSubmit == true) return 1;
else return -1
}
case clsSysSkillEN.con_CitationId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsSysSkillEN.con_OkCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.okCount-a.okCount;
}
case clsSysSkillEN.con_AppraiseCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.appraiseCount-a.appraiseCount;
}
case clsSysSkillEN.con_score:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.score-a.score;
}
case clsSysSkillEN.con_StuScore:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.stuScore-a.stuScore;
}
case clsSysSkillEN.con_TeaScore:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.teaScore-a.teaScore;
}
case clsSysSkillEN.con_id_CurrEduCls:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysSkillEN.con_PdfContent:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsSysSkillEN.con_PdfPageNum:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsSysSkillEN.con_CitationCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.citationCount-a.citationCount;
}
case clsSysSkillEN.con_VersionCount:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.versionCount-a.versionCount;
}
case clsSysSkillEN.con_Memo:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.memo.localeCompare(a.memo);
}
case clsSysSkillEN.con_CreateDate:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.createDate.localeCompare(a.createDate);
}
case clsSysSkillEN.con_ShareId:
return (a: clsSysSkillEN, b: clsSysSkillEN) => {
return b.shareId.localeCompare(a.shareId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${ sysSkill_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSkill_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysSkillEN.con_SkillId:
return (obj: clsSysSkillEN) => {
return obj.skillId === value;
}
case clsSysSkillEN.con_SkillName:
return (obj: clsSysSkillEN) => {
return obj.skillName === value;
}
case clsSysSkillEN.con_OperationTypeId:
return (obj: clsSysSkillEN) => {
return obj.operationTypeId === value;
}
case clsSysSkillEN.con_Process:
return (obj: clsSysSkillEN) => {
return obj.process === value;
}
case clsSysSkillEN.con_LevelId:
return (obj: clsSysSkillEN) => {
return obj.levelId === value;
}
case clsSysSkillEN.con_UpdUser:
return (obj: clsSysSkillEN) => {
return obj.updUser === value;
}
case clsSysSkillEN.con_UpdDate:
return (obj: clsSysSkillEN) => {
return obj.updDate === value;
}
case clsSysSkillEN.con_IsSubmit:
return (obj: clsSysSkillEN) => {
return obj.isSubmit === value;
}
case clsSysSkillEN.con_CitationId:
return (obj: clsSysSkillEN) => {
return obj.citationId === value;
}
case clsSysSkillEN.con_OkCount:
return (obj: clsSysSkillEN) => {
return obj.okCount === value;
}
case clsSysSkillEN.con_AppraiseCount:
return (obj: clsSysSkillEN) => {
return obj.appraiseCount === value;
}
case clsSysSkillEN.con_score:
return (obj: clsSysSkillEN) => {
return obj.score === value;
}
case clsSysSkillEN.con_StuScore:
return (obj: clsSysSkillEN) => {
return obj.stuScore === value;
}
case clsSysSkillEN.con_TeaScore:
return (obj: clsSysSkillEN) => {
return obj.teaScore === value;
}
case clsSysSkillEN.con_id_CurrEduCls:
return (obj: clsSysSkillEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysSkillEN.con_PdfContent:
return (obj: clsSysSkillEN) => {
return obj.pdfContent === value;
}
case clsSysSkillEN.con_PdfPageNum:
return (obj: clsSysSkillEN) => {
return obj.pdfPageNum === value;
}
case clsSysSkillEN.con_CitationCount:
return (obj: clsSysSkillEN) => {
return obj.citationCount === value;
}
case clsSysSkillEN.con_VersionCount:
return (obj: clsSysSkillEN) => {
return obj.versionCount === value;
}
case clsSysSkillEN.con_Memo:
return (obj: clsSysSkillEN) => {
return obj.memo === value;
}
case clsSysSkillEN.con_CreateDate:
return (obj: clsSysSkillEN) => {
return obj.createDate === value;
}
case clsSysSkillEN.con_ShareId:
return (obj: clsSysSkillEN) => {
return obj.shareId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkill]中不存在！(in ${ sysSkill_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSkill_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetFirstObjAsync(strWhereCond: string): Promise<clsSysSkillEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSkill = SysSkill_GetObjFromJsonObj(returnObj);
return objSysSkill;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetObjLst_ClientCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
clsSysSkillEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysSkillEN._CurrTabName);
if (IsNullOrEmpty(clsSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysSkillEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrSysSkillExObjLst_Cache: Array<clsSysSkillEN> = CacheHelper.Get(strKey);
const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
return arrSysSkillObjLst_T;
}
try
{
const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrSysSkillExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
console.log(strInfo);
return arrSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysSkill_GetObjLst_localStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
clsSysSkillEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysSkillEN._CurrTabName);
if (IsNullOrEmpty(clsSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysSkillEN.CacheAddiCondition);
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
const arrSysSkillExObjLst_Cache: Array<clsSysSkillEN> = JSON.parse(strTempObjLst);
const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
return arrSysSkillObjLst_T;
}
try
{
const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrSysSkillExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
console.log(strInfo);
return arrSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrSysSkillObjLst_Cache: Array<clsSysSkillEN> = JSON.parse(strTempObjLst);
return arrSysSkillObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function SysSkill_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysSkillEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetObjLst_sessionStorage(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
clsSysSkillEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsSysSkillEN._CurrTabName);
if (IsNullOrEmpty(clsSysSkillEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsSysSkillEN.CacheAddiCondition);
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
const arrSysSkillExObjLst_Cache: Array<clsSysSkillEN> = JSON.parse(strTempObjLst);
const arrSysSkillObjLst_T = SysSkill_GetObjLstByJSONObjLst(arrSysSkillExObjLst_Cache);
return arrSysSkillObjLst_T;
}
try
{
const arrSysSkillExObjLst = await SysSkill_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrSysSkillExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSkillExObjLst.length);
console.log(strInfo);
return arrSysSkillExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls: string)
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
let strWhereCond = "1=1";
strWhereCond = Format("id_CurrEduCls='{0}'", strid_CurrEduCls);
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrSysSkillObjLst_Cache: Array<clsSysSkillEN> = JSON.parse(strTempObjLst);
return arrSysSkillObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysSkill_GetObjLst_Cache(strid_CurrEduCls: string): Promise<Array<clsSysSkillEN>>
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
let arrSysSkillObjLst_Cache;
switch (clsSysSkillEN.CacheModeId)
{
case "04"://sessionStorage
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_sessionStorage(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_localStorage(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
break;
default:
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_ClientCache(strid_CurrEduCls);
break;
}
const arrSysSkillObjLst = SysSkill_GetObjLstByJSONObjLst(arrSysSkillObjLst_Cache);
return arrSysSkillObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function SysSkill_GetObjLst_PureCache(strid_CurrEduCls: string)
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrSysSkillObjLst_Cache;
switch (clsSysSkillEN.CacheModeId)
{
case "04"://sessionStorage
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
break;
case "03"://localStorage
arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
break;
case "02"://ClientCache
arrSysSkillObjLst_Cache = null;
break;
default:
arrSysSkillObjLst_Cache = null;
break;
}
return arrSysSkillObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrSkillId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysSkill_GetSubObjLst_Cache(objSysSkill_Cond: clsSysSkillEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
let arrSysSkill_Sel: Array < clsSysSkillEN > = arrSysSkillObjLst_Cache;
if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "") return arrSysSkill_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysSkill_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objSysSkill_Cond), sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysSkillEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrSkillId:关键字列表
 * @returns 对象列表
 **/
export async function SysSkill_GetObjLstBySkillIdLstAsync(arrSkillId: Array<string>): Promise<Array<clsSysSkillEN>>  
{
const strThisFuncName = "GetObjLstBySkillIdLstAsync";
const strAction = "GetObjLstBySkillIdLst";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSkillId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param arrstrSkillIdLst:关键字列表
 * @returns 对象列表
*/
export async function SysSkill_GetObjLstBySkillIdLst_Cache(arrSkillIdLst: Array<string>,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstBySkillIdLst_Cache";
try
{
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
const arrSysSkill_Sel: Array <clsSysSkillEN> = arrSysSkillObjLst_Cache.filter(x => arrSkillIdLst.indexOf(x.skillId)>-1);
return arrSysSkill_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSkillIdLst.join(","), sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysSkillEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function SysSkill_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysSkillEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysSkillEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetObjLstByPager_Cache(objPagerPara: stuPagerPara,strid_CurrEduCls: string) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysSkillObjLst_Cache.length == 0) return arrSysSkillObjLst_Cache;
let arrSysSkill_Sel = arrSysSkillObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objSysSkill_Cond = new clsSysSkillEN();
ObjectAssign(objSysSkill_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsSysSkillWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysSkill_Sel.length == 0) return arrSysSkill_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrSysSkill_Sel = arrSysSkill_Sel.sort(SysSkill_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrSysSkill_Sel = arrSysSkill_Sel.sort(objPagerPara.sortFun);
}
arrSysSkill_Sel = arrSysSkill_Sel.slice(intStart, intEnd);     
return arrSysSkill_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsSysSkillEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function SysSkill_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysSkillEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkill_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkill_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param strSkillId:关键字
 * @returns 获取删除的结果
 **/
export async function SysSkill_DelRecordAsync(strSkillId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strSkillId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strSkillId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param arrSkillId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysSkill_DelSysSkillsAsync(arrSkillId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysSkillsAsync";
const strAction = "DelSysSkills";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSkillId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_DelSysSkillsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysSkillsByCondAsync";
const strAction = "DelSysSkillsByCond";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysSkill_AddNewRecordAsync(objSysSkillEN: clsSysSkillEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysSkillEN);
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
 * @param objSysSkillEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysSkill_AddNewRecordWithMaxIdAsync(objSysSkillEN: clsSysSkillEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
 * @param objSysSkillEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysSkill_AddNewRecordWithReturnKeyAsync(objSysSkillEN: clsSysSkillEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objSysSkillEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysSkill_AddNewRecordWithReturnKey(objSysSkillEN: clsSysSkillEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysSkillEN.skillId === null || objSysSkillEN.skillId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objSysSkillEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysSkill_UpdateRecordAsync(objSysSkillEN: clsSysSkillEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysSkillEN.sf_UpdFldSetStr === undefined || objSysSkillEN.sf_UpdFldSetStr === null || objSysSkillEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillEN.skillId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objSysSkillEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysSkill_UpdateWithConditionAsync(objSysSkillEN: clsSysSkillEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysSkillEN.sf_UpdFldSetStr === undefined || objSysSkillEN.sf_UpdFldSetStr === null || objSysSkillEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillEN.skillId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
objSysSkillEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysSkillEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objstrSkillId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function SysSkill_IsExistRecord_Cache(objSysSkill_Cond: clsSysSkillEN,strid_CurrEduCls: string) {
const strThisFuncName = "IsExistRecord_Cache";
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysSkillObjLst_Cache == null) return false;
let arrSysSkill_Sel: Array < clsSysSkillEN > = arrSysSkillObjLst_Cache;
if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "") return arrSysSkill_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrSysSkill_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objSysSkill_Cond), sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param strSkillId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysSkill_IsExist(strSkillId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SkillId": strSkillId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param strSkillId:所给的关键字
 * @returns 对象
*/
export async function SysSkill_IsExist_Cache(strSkillId:string,strid_CurrEduCls:string) {
const strThisFuncName = "IsExist_Cache";
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysSkillObjLst_Cache == null) return false;
try
{
const arrSysSkill_Sel: Array <clsSysSkillEN> = arrSysSkillObjLst_Cache.filter(x => x.skillId == strSkillId);
if (arrSysSkill_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSkillId, sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strSkillId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysSkill_IsExistAsync(strSkillId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strSkillId": strSkillId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export async function SysSkill_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
 * @param objSysSkill_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function SysSkill_GetRecCountByCond_Cache(objSysSkill_Cond: clsSysSkillEN,strid_CurrEduCls: string) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrSysSkillObjLst_Cache = await SysSkill_GetObjLst_Cache(strid_CurrEduCls);
if (arrSysSkillObjLst_Cache == null) return 0;
let arrSysSkill_Sel: Array < clsSysSkillEN > = arrSysSkillObjLst_Cache;
if (objSysSkill_Cond.sf_FldComparisonOp == null || objSysSkill_Cond.sf_FldComparisonOp == "") return arrSysSkill_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objSysSkill_Cond.sf_FldComparisonOp);
//console.log("clsSysSkillWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objSysSkill_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objSysSkill_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrSysSkill_Sel = arrSysSkill_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrSysSkill_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objSysSkill_Cond), sysSkill_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

 /**
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function SysSkill_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
try
{
const response = await axios.get(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function SysSkill_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysSkill_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkill_ConstructorName, strThisFuncName);
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
export function SysSkill_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
 **/
export function SysSkill_ReFreshCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshCache";

if (IsNullOrEmpty(strid_CurrEduCls) == true)
{
  const strMsg = Format("参数:[strid_CurrEduCls]不能为空！(In clsSysSkillWApi.ReFreshCache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_CurrEduCls.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
console.error(strMsg);
throw (strMsg);
}

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
switch (clsSysSkillEN.CacheModeId)
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
vSysSkill_ReFreshThisCache(strid_CurrEduCls);
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function SysSkill_ReFreshThisCache(strid_CurrEduCls: string):void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = Format("{0}_{1}", clsSysSkillEN._CurrTabName, strid_CurrEduCls);
switch (clsSysSkillEN.CacheModeId)
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
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysSkill_CheckPropertyNew(pobjSysSkillEN: clsSysSkillEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSkillEN.skillId) == false && GetStrLen(pobjSysSkillEN.skillId) > 10)
{
 throw new Error("(errid:Watl000059)字段[技能Id(skillId)]的长度不能超过10(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillId)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.skillName) == false && GetStrLen(pobjSysSkillEN.skillName) > 200)
{
 throw new Error("(errid:Watl000059)字段[技能名称(skillName)]的长度不能超过200(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillName)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.operationTypeId) == false && GetStrLen(pobjSysSkillEN.operationTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 技能表(SysSkill))!值:$(pobjSysSkillEN.operationTypeId)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.levelId) == false && GetStrLen(pobjSysSkillEN.levelId) > 2)
{
 throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.levelId)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updUser) == false && GetStrLen(pobjSysSkillEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updUser)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updDate) == false && GetStrLen(pobjSysSkillEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updDate)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.citationId) == false && GetStrLen(pobjSysSkillEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.citationId)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.id_CurrEduCls) == false && GetStrLen(pobjSysSkillEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.id_CurrEduCls)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.pdfContent) == false && GetStrLen(pobjSysSkillEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.pdfContent)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.memo) == false && GetStrLen(pobjSysSkillEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.memo)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.createDate) == false && GetStrLen(pobjSysSkillEN.createDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.createDate)(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.shareId) == false && GetStrLen(pobjSysSkillEN.shareId) > 2)
{
 throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.shareId)(clsSysSkillBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysSkillEN.skillId) == false && undefined !== pobjSysSkillEN.skillId && tzDataType.isString(pobjSysSkillEN.skillId) === false)
{
 throw new Error("(errid:Watl000060)字段[技能Id(skillId)]的值:[$(pobjSysSkillEN.skillId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.skillName) == false && undefined !== pobjSysSkillEN.skillName && tzDataType.isString(pobjSysSkillEN.skillName) === false)
{
 throw new Error("(errid:Watl000060)字段[技能名称(skillName)]的值:[$(pobjSysSkillEN.skillName)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.operationTypeId) == false && undefined !== pobjSysSkillEN.operationTypeId && tzDataType.isString(pobjSysSkillEN.operationTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillEN.operationTypeId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.process) == false && undefined !== pobjSysSkillEN.process && tzDataType.isString(pobjSysSkillEN.process) === false)
{
 throw new Error("(errid:Watl000060)字段[实施过程(process)]的值:[$(pobjSysSkillEN.process)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.levelId) == false && undefined !== pobjSysSkillEN.levelId && tzDataType.isString(pobjSysSkillEN.levelId) === false)
{
 throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSkillEN.levelId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updUser) == false && undefined !== pobjSysSkillEN.updUser && tzDataType.isString(pobjSysSkillEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSkillEN.updUser)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updDate) == false && undefined !== pobjSysSkillEN.updDate && tzDataType.isString(pobjSysSkillEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSkillEN.updDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.isSubmit && undefined !== pobjSysSkillEN.isSubmit && tzDataType.isBoolean(pobjSysSkillEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjSysSkillEN.isSubmit)], 非法，应该为布尔型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.citationId) == false && undefined !== pobjSysSkillEN.citationId && tzDataType.isString(pobjSysSkillEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSkillEN.citationId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.okCount && undefined !== pobjSysSkillEN.okCount && tzDataType.isNumber(pobjSysSkillEN.okCount) === false)
{
 throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysSkillEN.okCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.appraiseCount && undefined !== pobjSysSkillEN.appraiseCount && tzDataType.isNumber(pobjSysSkillEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjSysSkillEN.appraiseCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.score && undefined !== pobjSysSkillEN.score && tzDataType.isNumber(pobjSysSkillEN.score) === false)
{
 throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysSkillEN.score)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.stuScore && undefined !== pobjSysSkillEN.stuScore && tzDataType.isNumber(pobjSysSkillEN.stuScore) === false)
{
 throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjSysSkillEN.stuScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.teaScore && undefined !== pobjSysSkillEN.teaScore && tzDataType.isNumber(pobjSysSkillEN.teaScore) === false)
{
 throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjSysSkillEN.teaScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.id_CurrEduCls) == false && undefined !== pobjSysSkillEN.id_CurrEduCls && tzDataType.isString(pobjSysSkillEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillEN.id_CurrEduCls)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.pdfContent) == false && undefined !== pobjSysSkillEN.pdfContent && tzDataType.isString(pobjSysSkillEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillEN.pdfContent)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.pdfPageNum && undefined !== pobjSysSkillEN.pdfPageNum && tzDataType.isNumber(pobjSysSkillEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillEN.pdfPageNum)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.citationCount && undefined !== pobjSysSkillEN.citationCount && tzDataType.isNumber(pobjSysSkillEN.citationCount) === false)
{
 throw new Error("(errid:Watl000060)字段[引用统计(citationCount)]的值:[$(pobjSysSkillEN.citationCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (null != pobjSysSkillEN.versionCount && undefined !== pobjSysSkillEN.versionCount && tzDataType.isNumber(pobjSysSkillEN.versionCount) === false)
{
 throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjSysSkillEN.versionCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.memo) == false && undefined !== pobjSysSkillEN.memo && tzDataType.isString(pobjSysSkillEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSkillEN.memo)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.createDate) == false && undefined !== pobjSysSkillEN.createDate && tzDataType.isString(pobjSysSkillEN.createDate) === false)
{
 throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjSysSkillEN.createDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillEN.shareId) == false && undefined !== pobjSysSkillEN.shareId && tzDataType.isString(pobjSysSkillEN.shareId) === false)
{
 throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjSysSkillEN.shareId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysSkillEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysSkill_CheckProperty4Update (pobjSysSkillEN: clsSysSkillEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSkillEN.skillId) == false && GetStrLen(pobjSysSkillEN.skillId) > 10)
{
 throw new Error("(errid:Watl000062)字段[技能Id(skillId)]的长度不能超过10(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillId)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.skillName) == false && GetStrLen(pobjSysSkillEN.skillName) > 200)
{
 throw new Error("(errid:Watl000062)字段[技能名称(skillName)]的长度不能超过200(In 技能表(SysSkill))!值:$(pobjSysSkillEN.skillName)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.operationTypeId) == false && GetStrLen(pobjSysSkillEN.operationTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 技能表(SysSkill))!值:$(pobjSysSkillEN.operationTypeId)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.levelId) == false && GetStrLen(pobjSysSkillEN.levelId) > 2)
{
 throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.levelId)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updUser) == false && GetStrLen(pobjSysSkillEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updUser)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updDate) == false && GetStrLen(pobjSysSkillEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.updDate)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.citationId) == false && GetStrLen(pobjSysSkillEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.citationId)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.id_CurrEduCls) == false && GetStrLen(pobjSysSkillEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 技能表(SysSkill))!值:$(pobjSysSkillEN.id_CurrEduCls)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.pdfContent) == false && GetStrLen(pobjSysSkillEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.pdfContent)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.memo) == false && GetStrLen(pobjSysSkillEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 技能表(SysSkill))!值:$(pobjSysSkillEN.memo)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.createDate) == false && GetStrLen(pobjSysSkillEN.createDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 技能表(SysSkill))!值:$(pobjSysSkillEN.createDate)(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.shareId) == false && GetStrLen(pobjSysSkillEN.shareId) > 2)
{
 throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 技能表(SysSkill))!值:$(pobjSysSkillEN.shareId)(clsSysSkillBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysSkillEN.skillId) == false && undefined !== pobjSysSkillEN.skillId && tzDataType.isString(pobjSysSkillEN.skillId) === false)
{
 throw new Error("(errid:Watl000063)字段[技能Id(skillId)]的值:[$(pobjSysSkillEN.skillId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.skillName) == false && undefined !== pobjSysSkillEN.skillName && tzDataType.isString(pobjSysSkillEN.skillName) === false)
{
 throw new Error("(errid:Watl000063)字段[技能名称(skillName)]的值:[$(pobjSysSkillEN.skillName)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.operationTypeId) == false && undefined !== pobjSysSkillEN.operationTypeId && tzDataType.isString(pobjSysSkillEN.operationTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillEN.operationTypeId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.process) == false && undefined !== pobjSysSkillEN.process && tzDataType.isString(pobjSysSkillEN.process) === false)
{
 throw new Error("(errid:Watl000063)字段[实施过程(process)]的值:[$(pobjSysSkillEN.process)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.levelId) == false && undefined !== pobjSysSkillEN.levelId && tzDataType.isString(pobjSysSkillEN.levelId) === false)
{
 throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSkillEN.levelId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updUser) == false && undefined !== pobjSysSkillEN.updUser && tzDataType.isString(pobjSysSkillEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSkillEN.updUser)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.updDate) == false && undefined !== pobjSysSkillEN.updDate && tzDataType.isString(pobjSysSkillEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSkillEN.updDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.isSubmit && undefined !== pobjSysSkillEN.isSubmit && tzDataType.isBoolean(pobjSysSkillEN.isSubmit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjSysSkillEN.isSubmit)], 非法，应该为布尔型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.citationId) == false && undefined !== pobjSysSkillEN.citationId && tzDataType.isString(pobjSysSkillEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSkillEN.citationId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.okCount && undefined !== pobjSysSkillEN.okCount && tzDataType.isNumber(pobjSysSkillEN.okCount) === false)
{
 throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysSkillEN.okCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.appraiseCount && undefined !== pobjSysSkillEN.appraiseCount && tzDataType.isNumber(pobjSysSkillEN.appraiseCount) === false)
{
 throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjSysSkillEN.appraiseCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.score && undefined !== pobjSysSkillEN.score && tzDataType.isNumber(pobjSysSkillEN.score) === false)
{
 throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysSkillEN.score)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.stuScore && undefined !== pobjSysSkillEN.stuScore && tzDataType.isNumber(pobjSysSkillEN.stuScore) === false)
{
 throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjSysSkillEN.stuScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.teaScore && undefined !== pobjSysSkillEN.teaScore && tzDataType.isNumber(pobjSysSkillEN.teaScore) === false)
{
 throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjSysSkillEN.teaScore)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.id_CurrEduCls) == false && undefined !== pobjSysSkillEN.id_CurrEduCls && tzDataType.isString(pobjSysSkillEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillEN.id_CurrEduCls)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.pdfContent) == false && undefined !== pobjSysSkillEN.pdfContent && tzDataType.isString(pobjSysSkillEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillEN.pdfContent)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.pdfPageNum && undefined !== pobjSysSkillEN.pdfPageNum && tzDataType.isNumber(pobjSysSkillEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillEN.pdfPageNum)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.citationCount && undefined !== pobjSysSkillEN.citationCount && tzDataType.isNumber(pobjSysSkillEN.citationCount) === false)
{
 throw new Error("(errid:Watl000063)字段[引用统计(citationCount)]的值:[$(pobjSysSkillEN.citationCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (null != pobjSysSkillEN.versionCount && undefined !== pobjSysSkillEN.versionCount && tzDataType.isNumber(pobjSysSkillEN.versionCount) === false)
{
 throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjSysSkillEN.versionCount)], 非法，应该为数值型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.memo) == false && undefined !== pobjSysSkillEN.memo && tzDataType.isString(pobjSysSkillEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSkillEN.memo)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.createDate) == false && undefined !== pobjSysSkillEN.createDate && tzDataType.isString(pobjSysSkillEN.createDate) === false)
{
 throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjSysSkillEN.createDate)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillEN.shareId) == false && undefined !== pobjSysSkillEN.shareId && tzDataType.isString(pobjSysSkillEN.shareId) === false)
{
 throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjSysSkillEN.shareId)], 非法，应该为字符型(In 技能表(SysSkill))!(clsSysSkillBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysSkillEN.skillId) === true )
{
 throw new Error("(errid:Watl000064)字段[技能Id]不能为空(In 技能表)!(clsSysSkillBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysSkillEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSkill_GetJSONStrByObj (pobjSysSkillEN: clsSysSkillEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysSkillEN.sf_UpdFldSetStr = pobjSysSkillEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysSkillEN);
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
export function SysSkill_GetObjLstByJSONStr (strJSON: string): Array<clsSysSkillEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysSkillObjLst = new Array<clsSysSkillEN>();
if (strJSON === "")
{
return arrSysSkillObjLst;
}
try
{
arrSysSkillObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysSkillObjLst;
}
return arrSysSkillObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysSkillObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysSkill_GetObjLstByJSONObjLst (arrSysSkillObjLstS: Array<clsSysSkillEN>): Array<clsSysSkillEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysSkillObjLst = new Array<clsSysSkillEN>();
for (const objInFor of arrSysSkillObjLstS) {
const obj1 = SysSkill_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysSkillObjLst.push(obj1);
}
return arrSysSkillObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSkill_GetObjByJSONStr (strJSON: string): clsSysSkillEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysSkillEN = new clsSysSkillEN();
if (strJSON === "")
{
return pobjSysSkillEN;
}
try
{
pobjSysSkillEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysSkillEN;
}
return pobjSysSkillEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysSkill_GetCombineCondition(objSysSkill_Cond: clsSysSkillEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_SkillId) == true)
{
const strComparisonOp_SkillId:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_SkillId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_SkillId, objSysSkill_Cond.skillId, strComparisonOp_SkillId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_SkillName) == true)
{
const strComparisonOp_SkillName:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_SkillName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_SkillName, objSysSkill_Cond.skillName, strComparisonOp_SkillName);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_OperationTypeId) == true)
{
const strComparisonOp_OperationTypeId:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_OperationTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_OperationTypeId, objSysSkill_Cond.operationTypeId, strComparisonOp_OperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_LevelId) == true)
{
const strComparisonOp_LevelId:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_LevelId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_LevelId, objSysSkill_Cond.levelId, strComparisonOp_LevelId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_UpdUser, objSysSkill_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_UpdDate, objSysSkill_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_IsSubmit) == true)
{
if (objSysSkill_Cond.isSubmit == true)
{
strWhereCond += Format(" And {0} = '1'", clsSysSkillEN.con_IsSubmit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsSysSkillEN.con_IsSubmit);
}
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_CitationId, objSysSkill_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_OkCount) == true)
{
const strComparisonOp_OkCount:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_OkCount];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_OkCount, objSysSkill_Cond.okCount, strComparisonOp_OkCount);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_AppraiseCount) == true)
{
const strComparisonOp_AppraiseCount:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_AppraiseCount];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_AppraiseCount, objSysSkill_Cond.appraiseCount, strComparisonOp_AppraiseCount);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_score) == true)
{
const strComparisonOp_score:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_score];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_score, objSysSkill_Cond.score, strComparisonOp_score);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_StuScore) == true)
{
const strComparisonOp_StuScore:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_StuScore];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_StuScore, objSysSkill_Cond.stuScore, strComparisonOp_StuScore);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_TeaScore) == true)
{
const strComparisonOp_TeaScore:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_TeaScore];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_TeaScore, objSysSkill_Cond.teaScore, strComparisonOp_TeaScore);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_id_CurrEduCls, objSysSkill_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_PdfContent, objSysSkill_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_PdfPageNum, objSysSkill_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_CitationCount) == true)
{
const strComparisonOp_CitationCount:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_CitationCount];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_CitationCount, objSysSkill_Cond.citationCount, strComparisonOp_CitationCount);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_VersionCount) == true)
{
const strComparisonOp_VersionCount:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_VersionCount];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillEN.con_VersionCount, objSysSkill_Cond.versionCount, strComparisonOp_VersionCount);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_Memo, objSysSkill_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_CreateDate) == true)
{
const strComparisonOp_CreateDate:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_CreateDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_CreateDate, objSysSkill_Cond.createDate, strComparisonOp_CreateDate);
}
if (Object.prototype.hasOwnProperty.call(objSysSkill_Cond.dicFldComparisonOp, clsSysSkillEN.con_ShareId) == true)
{
const strComparisonOp_ShareId:string = objSysSkill_Cond.dicFldComparisonOp[clsSysSkillEN.con_ShareId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillEN.con_ShareId, objSysSkill_Cond.shareId, strComparisonOp_ShareId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSkill(技能表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strSkillId: 技能Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSkill_GetUniCondStr_SkillId(objSysSkillEN: clsSysSkillEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SkillId = '{0}'", objSysSkillEN.skillId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSkill(技能表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strSkillId: 技能Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSkill_GetUniCondStr4Update_SkillId(objSysSkillEN: clsSysSkillEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SkillId <> '{0}'", objSysSkillEN.skillId);
 strWhereCond +=  Format(" and SkillId = '{0}'", objSysSkillEN.skillId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysSkillENS:源对象
 * @param objSysSkillENT:目标对象
*/
export function SysSkill_CopyObjTo(objSysSkillENS: clsSysSkillEN , objSysSkillENT: clsSysSkillEN ): void 
{
objSysSkillENT.skillId = objSysSkillENS.skillId; //技能Id
objSysSkillENT.skillName = objSysSkillENS.skillName; //技能名称
objSysSkillENT.operationTypeId = objSysSkillENS.operationTypeId; //操作类型ID
objSysSkillENT.process = objSysSkillENS.process; //实施过程
objSysSkillENT.levelId = objSysSkillENS.levelId; //级别Id
objSysSkillENT.updUser = objSysSkillENS.updUser; //修改人
objSysSkillENT.updDate = objSysSkillENS.updDate; //修改日期
objSysSkillENT.isSubmit = objSysSkillENS.isSubmit; //是否提交
objSysSkillENT.citationId = objSysSkillENS.citationId; //引用Id
objSysSkillENT.okCount = objSysSkillENS.okCount; //点赞统计
objSysSkillENT.appraiseCount = objSysSkillENS.appraiseCount; //评论数
objSysSkillENT.score = objSysSkillENS.score; //评分
objSysSkillENT.stuScore = objSysSkillENS.stuScore; //学生平均分
objSysSkillENT.teaScore = objSysSkillENS.teaScore; //教师评分
objSysSkillENT.id_CurrEduCls = objSysSkillENS.id_CurrEduCls; //教学班流水号
objSysSkillENT.pdfContent = objSysSkillENS.pdfContent; //Pdf内容
objSysSkillENT.pdfPageNum = objSysSkillENS.pdfPageNum; //Pdf页码
objSysSkillENT.citationCount = objSysSkillENS.citationCount; //引用统计
objSysSkillENT.versionCount = objSysSkillENS.versionCount; //版本统计
objSysSkillENT.memo = objSysSkillENS.memo; //备注
objSysSkillENT.createDate = objSysSkillENS.createDate; //建立日期
objSysSkillENT.shareId = objSysSkillENS.shareId; //分享Id
objSysSkillENT.sf_UpdFldSetStr = objSysSkillENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysSkillENS:源对象
 * @param objSysSkillENT:目标对象
*/
export function SysSkill_GetObjFromJsonObj(objSysSkillENS: clsSysSkillEN): clsSysSkillEN 
{
 const objSysSkillENT: clsSysSkillEN = new clsSysSkillEN();
ObjectAssign(objSysSkillENT, objSysSkillENS);
 return objSysSkillENT;
}