
 /**
 * 类名:clsvXzGradeBaseWApi
 * 表名:vXzGradeBase(01120130)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:38
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v年级(vXzGradeBase)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { clsvXzGradeBaseEN } from "../../L0_Entity/SysPara/clsvXzGradeBaseEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vXzGradeBase_Controller = "vXzGradeBaseApi";
 export const vXzGradeBase_ConstructorName = "vXzGradeBase";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_GradeBase:关键字
 * @returns 对象
 **/
export async function vXzGradeBase_GetObjByid_GradeBaseAsync(strid_GradeBase: string): Promise<clsvXzGradeBaseEN|null>  
{
const strThisFuncName = "GetObjByid_GradeBaseAsync";

if (IsNullOrEmpty(strid_GradeBase) == true)
{
  const strMsg = Format("参数:[strid_GradeBase]不能为空！(In clsvXzGradeBaseWApi.GetObjByid_GradeBaseAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_GradeBase.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_GradeBase]的长度:[{0}]不正确！(clsvXzGradeBaseWApi.GetObjByid_GradeBaseAsync)", strid_GradeBase.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_GradeBase";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_GradeBase": strid_GradeBase,
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
const objvXzGradeBase = vXzGradeBase_GetObjFromJsonObj(returnObj);
return objvXzGradeBase;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function vXzGradeBase_SortFun_Defa(a:clsvXzGradeBaseEN , b:clsvXzGradeBaseEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_GradeBase.localeCompare(b.id_GradeBase);
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
export function vXzGradeBase_SortFun_Defa_2Fld(a:clsvXzGradeBaseEN , b:clsvXzGradeBaseEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.gradeBaseID == b.gradeBaseID) return a.gradeBaseName.localeCompare(b.gradeBaseName);
else return a.gradeBaseID.localeCompare(b.gradeBaseID);
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
export function vXzGradeBase_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvXzGradeBaseEN.con_id_GradeBase:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsvXzGradeBaseEN.con_GradeBaseID:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.gradeBaseID == null) return -1;
if (b.gradeBaseID == null) return 1;
return a.gradeBaseID.localeCompare(b.gradeBaseID);
}
case clsvXzGradeBaseEN.con_GradeBaseName:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsvXzGradeBaseEN.con_GradeBaseNameA:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
}
case clsvXzGradeBaseEN.con_SchoolYear:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.schoolYear == null) return -1;
if (b.schoolYear == null) return 1;
return a.schoolYear.localeCompare(b.schoolYear);
}
case clsvXzGradeBaseEN.con_SchoolTerm:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.schoolTerm == null) return -1;
if (b.schoolTerm == null) return 1;
return a.schoolTerm.localeCompare(b.schoolTerm);
}
case clsvXzGradeBaseEN.con_EnterSchoolDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.enterSchoolDate == null) return -1;
if (b.enterSchoolDate == null) return 1;
return a.enterSchoolDate.localeCompare(b.enterSchoolDate);
}
case clsvXzGradeBaseEN.con_CurrentTermSeq:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.currentTermSeq-b.currentTermSeq;
}
case clsvXzGradeBaseEN.con_ExecPlanTermIndex:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.execPlanTermIndex-b.execPlanTermIndex;
}
case clsvXzGradeBaseEN.con_SetEPTermIndexDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.setEPTermIndexDate == null) return -1;
if (b.setEPTermIndexDate == null) return 1;
return a.setEPTermIndexDate.localeCompare(b.setEPTermIndexDate);
}
case clsvXzGradeBaseEN.con_IsOffed:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.isOffed == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_GradeIndex:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.gradeIndex-b.gradeIndex;
}
case clsvXzGradeBaseEN.con_BeginYearMonth:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.beginYearMonth == null) return -1;
if (b.beginYearMonth == null) return 1;
return a.beginYearMonth.localeCompare(b.beginYearMonth);
}
case clsvXzGradeBaseEN.con_EndYearMonth:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.endYearMonth == null) return -1;
if (b.endYearMonth == null) return 1;
return a.endYearMonth.localeCompare(b.endYearMonth);
}
case clsvXzGradeBaseEN.con_AllowUpBaseInfo:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.allowUpBaseInfo == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_Prefix:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.prefix == null) return -1;
if (b.prefix == null) return 1;
return a.prefix.localeCompare(b.prefix);
}
case clsvXzGradeBaseEN.con_PointCalcVersionId:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return a.pointCalcVersionId.localeCompare(b.pointCalcVersionId);
}
case clsvXzGradeBaseEN.con_ModifyUserID:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.modifyUserID == null) return -1;
if (b.modifyUserID == null) return 1;
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvXzGradeBaseEN.con_ModifyDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.modifyDate == null) return -1;
if (b.modifyDate == null) return 1;
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvXzGradeBaseEN.con_id_StudyLevel:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.id_StudyLevel == null) return -1;
if (b.id_StudyLevel == null) return 1;
return a.id_StudyLevel.localeCompare(b.id_StudyLevel);
}
case clsvXzGradeBaseEN.con_StudyLevelName:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.studyLevelName == null) return -1;
if (b.studyLevelName == null) return 1;
return a.studyLevelName.localeCompare(b.studyLevelName);
}
case clsvXzGradeBaseEN.con_IsVisible:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_Memo:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${ vXzGradeBase_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvXzGradeBaseEN.con_id_GradeBase:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsvXzGradeBaseEN.con_GradeBaseID:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.gradeBaseID == null) return -1;
if (a.gradeBaseID == null) return 1;
return b.gradeBaseID.localeCompare(a.gradeBaseID);
}
case clsvXzGradeBaseEN.con_GradeBaseName:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsvXzGradeBaseEN.con_GradeBaseNameA:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
}
case clsvXzGradeBaseEN.con_SchoolYear:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.schoolYear == null) return -1;
if (a.schoolYear == null) return 1;
return b.schoolYear.localeCompare(a.schoolYear);
}
case clsvXzGradeBaseEN.con_SchoolTerm:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.schoolTerm == null) return -1;
if (a.schoolTerm == null) return 1;
return b.schoolTerm.localeCompare(a.schoolTerm);
}
case clsvXzGradeBaseEN.con_EnterSchoolDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.enterSchoolDate == null) return -1;
if (a.enterSchoolDate == null) return 1;
return b.enterSchoolDate.localeCompare(a.enterSchoolDate);
}
case clsvXzGradeBaseEN.con_CurrentTermSeq:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.currentTermSeq-a.currentTermSeq;
}
case clsvXzGradeBaseEN.con_ExecPlanTermIndex:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.execPlanTermIndex-a.execPlanTermIndex;
}
case clsvXzGradeBaseEN.con_SetEPTermIndexDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.setEPTermIndexDate == null) return -1;
if (a.setEPTermIndexDate == null) return 1;
return b.setEPTermIndexDate.localeCompare(a.setEPTermIndexDate);
}
case clsvXzGradeBaseEN.con_IsOffed:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.isOffed == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_GradeIndex:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.gradeIndex-a.gradeIndex;
}
case clsvXzGradeBaseEN.con_BeginYearMonth:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.beginYearMonth == null) return -1;
if (a.beginYearMonth == null) return 1;
return b.beginYearMonth.localeCompare(a.beginYearMonth);
}
case clsvXzGradeBaseEN.con_EndYearMonth:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.endYearMonth == null) return -1;
if (a.endYearMonth == null) return 1;
return b.endYearMonth.localeCompare(a.endYearMonth);
}
case clsvXzGradeBaseEN.con_AllowUpBaseInfo:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.allowUpBaseInfo == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_Prefix:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.prefix == null) return -1;
if (a.prefix == null) return 1;
return b.prefix.localeCompare(a.prefix);
}
case clsvXzGradeBaseEN.con_PointCalcVersionId:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
return b.pointCalcVersionId.localeCompare(a.pointCalcVersionId);
}
case clsvXzGradeBaseEN.con_ModifyUserID:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.modifyUserID == null) return -1;
if (a.modifyUserID == null) return 1;
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvXzGradeBaseEN.con_ModifyDate:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.modifyDate == null) return -1;
if (a.modifyDate == null) return 1;
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvXzGradeBaseEN.con_id_StudyLevel:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.id_StudyLevel == null) return -1;
if (a.id_StudyLevel == null) return 1;
return b.id_StudyLevel.localeCompare(a.id_StudyLevel);
}
case clsvXzGradeBaseEN.con_StudyLevelName:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.studyLevelName == null) return -1;
if (a.studyLevelName == null) return 1;
return b.studyLevelName.localeCompare(a.studyLevelName);
}
case clsvXzGradeBaseEN.con_IsVisible:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsvXzGradeBaseEN.con_Memo:
return (a: clsvXzGradeBaseEN, b: clsvXzGradeBaseEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${ vXzGradeBase_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzGradeBase_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvXzGradeBaseEN.con_id_GradeBase:
return (obj: clsvXzGradeBaseEN) => {
return obj.id_GradeBase === value;
}
case clsvXzGradeBaseEN.con_GradeBaseID:
return (obj: clsvXzGradeBaseEN) => {
return obj.gradeBaseID === value;
}
case clsvXzGradeBaseEN.con_GradeBaseName:
return (obj: clsvXzGradeBaseEN) => {
return obj.gradeBaseName === value;
}
case clsvXzGradeBaseEN.con_GradeBaseNameA:
return (obj: clsvXzGradeBaseEN) => {
return obj.gradeBaseNameA === value;
}
case clsvXzGradeBaseEN.con_SchoolYear:
return (obj: clsvXzGradeBaseEN) => {
return obj.schoolYear === value;
}
case clsvXzGradeBaseEN.con_SchoolTerm:
return (obj: clsvXzGradeBaseEN) => {
return obj.schoolTerm === value;
}
case clsvXzGradeBaseEN.con_EnterSchoolDate:
return (obj: clsvXzGradeBaseEN) => {
return obj.enterSchoolDate === value;
}
case clsvXzGradeBaseEN.con_CurrentTermSeq:
return (obj: clsvXzGradeBaseEN) => {
return obj.currentTermSeq === value;
}
case clsvXzGradeBaseEN.con_ExecPlanTermIndex:
return (obj: clsvXzGradeBaseEN) => {
return obj.execPlanTermIndex === value;
}
case clsvXzGradeBaseEN.con_SetEPTermIndexDate:
return (obj: clsvXzGradeBaseEN) => {
return obj.setEPTermIndexDate === value;
}
case clsvXzGradeBaseEN.con_IsOffed:
return (obj: clsvXzGradeBaseEN) => {
return obj.isOffed === value;
}
case clsvXzGradeBaseEN.con_GradeIndex:
return (obj: clsvXzGradeBaseEN) => {
return obj.gradeIndex === value;
}
case clsvXzGradeBaseEN.con_BeginYearMonth:
return (obj: clsvXzGradeBaseEN) => {
return obj.beginYearMonth === value;
}
case clsvXzGradeBaseEN.con_EndYearMonth:
return (obj: clsvXzGradeBaseEN) => {
return obj.endYearMonth === value;
}
case clsvXzGradeBaseEN.con_AllowUpBaseInfo:
return (obj: clsvXzGradeBaseEN) => {
return obj.allowUpBaseInfo === value;
}
case clsvXzGradeBaseEN.con_Prefix:
return (obj: clsvXzGradeBaseEN) => {
return obj.prefix === value;
}
case clsvXzGradeBaseEN.con_PointCalcVersionId:
return (obj: clsvXzGradeBaseEN) => {
return obj.pointCalcVersionId === value;
}
case clsvXzGradeBaseEN.con_ModifyUserID:
return (obj: clsvXzGradeBaseEN) => {
return obj.modifyUserID === value;
}
case clsvXzGradeBaseEN.con_ModifyDate:
return (obj: clsvXzGradeBaseEN) => {
return obj.modifyDate === value;
}
case clsvXzGradeBaseEN.con_id_StudyLevel:
return (obj: clsvXzGradeBaseEN) => {
return obj.id_StudyLevel === value;
}
case clsvXzGradeBaseEN.con_StudyLevelName:
return (obj: clsvXzGradeBaseEN) => {
return obj.studyLevelName === value;
}
case clsvXzGradeBaseEN.con_IsVisible:
return (obj: clsvXzGradeBaseEN) => {
return obj.isVisible === value;
}
case clsvXzGradeBaseEN.con_Memo:
return (obj: clsvXzGradeBaseEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzGradeBase]中不存在！(in ${ vXzGradeBase_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzGradeBase_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetFirstObjAsync(strWhereCond: string): Promise<clsvXzGradeBaseEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const objvXzGradeBase = vXzGradeBase_GetObjFromJsonObj(returnObj);
return objvXzGradeBase;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
 * @param arrid_GradeBase:关键字列表
 * @returns 对象列表
 **/
export async function vXzGradeBase_GetObjLstByid_GradeBaseLstAsync(arrid_GradeBase: Array<string>): Promise<Array<clsvXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByid_GradeBaseLstAsync";
const strAction = "GetObjLstByid_GradeBaseLst";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_GradeBase);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvXzGradeBaseEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvXzGradeBaseEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsvXzGradeBaseEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzGradeBase_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vXzGradeBase_IsExist(strid_GradeBase: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_GradeBase": strid_GradeBase,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
 * @param strid_GradeBase:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vXzGradeBase_IsExistAsync(strid_GradeBase: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_GradeBase": strid_GradeBase }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export async function vXzGradeBase_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vXzGradeBase_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzGradeBase_ConstructorName, strThisFuncName);
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
export function vXzGradeBase_GetWebApiUrl(strController: string, strAction: string): string {
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
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzGradeBase_GetJSONStrByObj (pobjvXzGradeBaseEN: clsvXzGradeBaseEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvXzGradeBaseEN);
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
export function vXzGradeBase_GetObjLstByJSONStr (strJSON: string): Array<clsvXzGradeBaseEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvXzGradeBaseObjLst = new Array<clsvXzGradeBaseEN>();
if (strJSON === "")
{
return arrvXzGradeBaseObjLst;
}
try
{
arrvXzGradeBaseObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvXzGradeBaseObjLst;
}
return arrvXzGradeBaseObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvXzGradeBaseObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vXzGradeBase_GetObjLstByJSONObjLst (arrvXzGradeBaseObjLstS: Array<clsvXzGradeBaseEN>): Array<clsvXzGradeBaseEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvXzGradeBaseObjLst = new Array<clsvXzGradeBaseEN>();
for (const objInFor of arrvXzGradeBaseObjLstS) {
const obj1 = vXzGradeBase_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvXzGradeBaseObjLst.push(obj1);
}
return arrvXzGradeBaseObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzGradeBase_GetObjByJSONStr (strJSON: string): clsvXzGradeBaseEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvXzGradeBaseEN = new clsvXzGradeBaseEN();
if (strJSON === "")
{
return pobjvXzGradeBaseEN;
}
try
{
pobjvXzGradeBaseEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvXzGradeBaseEN;
}
return pobjvXzGradeBaseEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vXzGradeBase_GetCombineCondition(objvXzGradeBase_Cond: clsvXzGradeBaseEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_id_GradeBase, objvXzGradeBase_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_GradeBaseID) == true)
{
const strComparisonOp_GradeBaseID:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_GradeBaseID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_GradeBaseID, objvXzGradeBase_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_GradeBaseName, objvXzGradeBase_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_GradeBaseNameA) == true)
{
const strComparisonOp_GradeBaseNameA:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_GradeBaseNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_GradeBaseNameA, objvXzGradeBase_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_SchoolYear) == true)
{
const strComparisonOp_SchoolYear:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_SchoolYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_SchoolYear, objvXzGradeBase_Cond.schoolYear, strComparisonOp_SchoolYear);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_SchoolTerm) == true)
{
const strComparisonOp_SchoolTerm:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_SchoolTerm];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_SchoolTerm, objvXzGradeBase_Cond.schoolTerm, strComparisonOp_SchoolTerm);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_EnterSchoolDate) == true)
{
const strComparisonOp_EnterSchoolDate:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_EnterSchoolDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_EnterSchoolDate, objvXzGradeBase_Cond.enterSchoolDate, strComparisonOp_EnterSchoolDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_CurrentTermSeq) == true)
{
const strComparisonOp_CurrentTermSeq:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_CurrentTermSeq];
strWhereCond += Format(" And {0} {2} {1}", clsvXzGradeBaseEN.con_CurrentTermSeq, objvXzGradeBase_Cond.currentTermSeq, strComparisonOp_CurrentTermSeq);
}
//数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_SetEPTermIndexDate) == true)
{
const strComparisonOp_SetEPTermIndexDate:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_SetEPTermIndexDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_SetEPTermIndexDate, objvXzGradeBase_Cond.setEPTermIndexDate, strComparisonOp_SetEPTermIndexDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_IsOffed) == true)
{
if (objvXzGradeBase_Cond.isOffed == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzGradeBaseEN.con_IsOffed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzGradeBaseEN.con_IsOffed);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_GradeIndex) == true)
{
const strComparisonOp_GradeIndex:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_GradeIndex];
strWhereCond += Format(" And {0} {2} {1}", clsvXzGradeBaseEN.con_GradeIndex, objvXzGradeBase_Cond.gradeIndex, strComparisonOp_GradeIndex);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_BeginYearMonth) == true)
{
const strComparisonOp_BeginYearMonth:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_BeginYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_BeginYearMonth, objvXzGradeBase_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_EndYearMonth) == true)
{
const strComparisonOp_EndYearMonth:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_EndYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_EndYearMonth, objvXzGradeBase_Cond.endYearMonth, strComparisonOp_EndYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_AllowUpBaseInfo) == true)
{
if (objvXzGradeBase_Cond.allowUpBaseInfo == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzGradeBaseEN.con_AllowUpBaseInfo);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzGradeBaseEN.con_AllowUpBaseInfo);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_Prefix) == true)
{
const strComparisonOp_Prefix:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_Prefix];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_Prefix, objvXzGradeBase_Cond.prefix, strComparisonOp_Prefix);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_PointCalcVersionId) == true)
{
const strComparisonOp_PointCalcVersionId:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_PointCalcVersionId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_PointCalcVersionId, objvXzGradeBase_Cond.pointCalcVersionId, strComparisonOp_PointCalcVersionId);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_ModifyUserID, objvXzGradeBase_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_ModifyDate, objvXzGradeBase_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_id_StudyLevel) == true)
{
const strComparisonOp_id_StudyLevel:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_id_StudyLevel];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_id_StudyLevel, objvXzGradeBase_Cond.id_StudyLevel, strComparisonOp_id_StudyLevel);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_StudyLevelName) == true)
{
const strComparisonOp_StudyLevelName:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_StudyLevelName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_StudyLevelName, objvXzGradeBase_Cond.studyLevelName, strComparisonOp_StudyLevelName);
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_IsVisible) == true)
{
if (objvXzGradeBase_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzGradeBaseEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzGradeBaseEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzGradeBase_Cond.dicFldComparisonOp, clsvXzGradeBaseEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvXzGradeBase_Cond.dicFldComparisonOp[clsvXzGradeBaseEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzGradeBaseEN.con_Memo, objvXzGradeBase_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvXzGradeBaseENS:源对象
 * @param objvXzGradeBaseENT:目标对象
*/
export function vXzGradeBase_CopyObjTo(objvXzGradeBaseENS: clsvXzGradeBaseEN , objvXzGradeBaseENT: clsvXzGradeBaseEN ): void 
{
objvXzGradeBaseENT.id_GradeBase = objvXzGradeBaseENS.id_GradeBase; //年级流水号
objvXzGradeBaseENT.gradeBaseID = objvXzGradeBaseENS.gradeBaseID; //年级代号
objvXzGradeBaseENT.gradeBaseName = objvXzGradeBaseENS.gradeBaseName; //年级名称
objvXzGradeBaseENT.gradeBaseNameA = objvXzGradeBaseENS.gradeBaseNameA; //年级名称缩写
objvXzGradeBaseENT.schoolYear = objvXzGradeBaseENS.schoolYear; //学年
objvXzGradeBaseENT.schoolTerm = objvXzGradeBaseENS.schoolTerm; //学期
objvXzGradeBaseENT.enterSchoolDate = objvXzGradeBaseENS.enterSchoolDate; //进校日期
objvXzGradeBaseENT.currentTermSeq = objvXzGradeBaseENS.currentTermSeq; //当前学期
objvXzGradeBaseENT.execPlanTermIndex = objvXzGradeBaseENS.execPlanTermIndex; //生成执行计划学期
objvXzGradeBaseENT.setEPTermIndexDate = objvXzGradeBaseENS.setEPTermIndexDate; //设定执行计划学期日期
objvXzGradeBaseENT.isOffed = objvXzGradeBaseENS.isOffed; //是否毕业
objvXzGradeBaseENT.gradeIndex = objvXzGradeBaseENS.gradeIndex; //年级序号
objvXzGradeBaseENT.beginYearMonth = objvXzGradeBaseENS.beginYearMonth; //开始年月
objvXzGradeBaseENT.endYearMonth = objvXzGradeBaseENS.endYearMonth; //结束年月
objvXzGradeBaseENT.allowUpBaseInfo = objvXzGradeBaseENS.allowUpBaseInfo; //允许修改基本信息
objvXzGradeBaseENT.prefix = objvXzGradeBaseENS.prefix; //前缀
objvXzGradeBaseENT.pointCalcVersionId = objvXzGradeBaseENS.pointCalcVersionId; //绩点计算版本Id
objvXzGradeBaseENT.modifyUserID = objvXzGradeBaseENS.modifyUserID; //修改人
objvXzGradeBaseENT.modifyDate = objvXzGradeBaseENS.modifyDate; //修改日期
objvXzGradeBaseENT.id_StudyLevel = objvXzGradeBaseENS.id_StudyLevel; //id_StudyLevel
objvXzGradeBaseENT.studyLevelName = objvXzGradeBaseENS.studyLevelName; //学段名称
objvXzGradeBaseENT.isVisible = objvXzGradeBaseENS.isVisible; //是否显示
objvXzGradeBaseENT.memo = objvXzGradeBaseENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvXzGradeBaseENS:源对象
 * @param objvXzGradeBaseENT:目标对象
*/
export function vXzGradeBase_GetObjFromJsonObj(objvXzGradeBaseENS: clsvXzGradeBaseEN): clsvXzGradeBaseEN 
{
 const objvXzGradeBaseENT: clsvXzGradeBaseEN = new clsvXzGradeBaseEN();
ObjectAssign(objvXzGradeBaseENT, objvXzGradeBaseENS);
 return objvXzGradeBaseENT;
}