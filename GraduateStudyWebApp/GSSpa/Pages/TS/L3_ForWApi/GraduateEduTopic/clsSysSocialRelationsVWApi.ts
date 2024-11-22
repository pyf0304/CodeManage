
 /**
 * 类名:clsSysSocialRelationsVWApi
 * 表名:SysSocialRelationsV(01120645)
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
 * 社会关系版本表(SysSocialRelationsV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsSysSocialRelationsVEN } from "../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysSocialRelationsV_Controller = "SysSocialRelationsVApi";
 export const sysSocialRelationsV_ConstructorName = "sysSocialRelationsV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngSocialVId:关键字
 * @returns 对象
 **/
export async function SysSocialRelationsV_GetObjBySocialVIdAsync(lngSocialVId: number): Promise<clsSysSocialRelationsVEN>  
{
const strThisFuncName = "GetObjBySocialVIdAsync";

if (lngSocialVId == 0)
{
  const strMsg = Format("参数:[lngSocialVId]不能为空！(In GetObjBySocialVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBySocialVId";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngSocialVId": lngSocialVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSocialRelationsV = SysSocialRelationsV_GetObjFromJsonObj(returnObj);
return objSysSocialRelationsV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export function SysSocialRelationsV_SortFun_Defa(a:clsSysSocialRelationsVEN , b:clsSysSocialRelationsVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.socialVId-b.socialVId;
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
export function SysSocialRelationsV_SortFun_Defa_2Fld(a:clsSysSocialRelationsVEN , b:clsSysSocialRelationsVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.socialId == b.socialId) return a.fullName.localeCompare(b.fullName);
else return a.socialId.localeCompare(b.socialId);
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
export function SysSocialRelationsV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysSocialRelationsVEN.con_SocialVId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.socialVId-b.socialVId;
}
case clsSysSocialRelationsVEN.con_SocialId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.socialId.localeCompare(b.socialId);
}
case clsSysSocialRelationsVEN.con_FullName:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.fullName.localeCompare(b.fullName);
}
case clsSysSocialRelationsVEN.con_Nationality:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.nationality.localeCompare(b.nationality);
}
case clsSysSocialRelationsVEN.con_WorkUnit:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.workUnit.localeCompare(b.workUnit);
}
case clsSysSocialRelationsVEN.con_Major:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.major.localeCompare(b.major);
}
case clsSysSocialRelationsVEN.con_Achievement:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.achievement.localeCompare(b.achievement);
}
case clsSysSocialRelationsVEN.con_DetailedDescription:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.detailedDescription.localeCompare(b.detailedDescription);
}
case clsSysSocialRelationsVEN.con_LevelId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.levelId.localeCompare(b.levelId);
}
case clsSysSocialRelationsVEN.con_UpdUser:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSysSocialRelationsVEN.con_UpdDate:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSysSocialRelationsVEN.con_id_CurrEduCls:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysSocialRelationsVEN.con_Memo:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.memo.localeCompare(b.memo);
}
case clsSysSocialRelationsVEN.con_CitationId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return a.citationId.localeCompare(b.citationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${ sysSocialRelationsV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysSocialRelationsVEN.con_SocialVId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.socialVId-a.socialVId;
}
case clsSysSocialRelationsVEN.con_SocialId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.socialId.localeCompare(a.socialId);
}
case clsSysSocialRelationsVEN.con_FullName:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.fullName.localeCompare(a.fullName);
}
case clsSysSocialRelationsVEN.con_Nationality:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.nationality.localeCompare(a.nationality);
}
case clsSysSocialRelationsVEN.con_WorkUnit:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.workUnit.localeCompare(a.workUnit);
}
case clsSysSocialRelationsVEN.con_Major:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.major.localeCompare(a.major);
}
case clsSysSocialRelationsVEN.con_Achievement:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.achievement.localeCompare(a.achievement);
}
case clsSysSocialRelationsVEN.con_DetailedDescription:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.detailedDescription.localeCompare(a.detailedDescription);
}
case clsSysSocialRelationsVEN.con_LevelId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.levelId.localeCompare(a.levelId);
}
case clsSysSocialRelationsVEN.con_UpdUser:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSysSocialRelationsVEN.con_UpdDate:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSysSocialRelationsVEN.con_id_CurrEduCls:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysSocialRelationsVEN.con_Memo:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.memo.localeCompare(a.memo);
}
case clsSysSocialRelationsVEN.con_CitationId:
return (a: clsSysSocialRelationsVEN, b: clsSysSocialRelationsVEN) => {
return b.citationId.localeCompare(a.citationId);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${ sysSocialRelationsV_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSocialRelationsV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysSocialRelationsVEN.con_SocialVId:
return (obj: clsSysSocialRelationsVEN) => {
return obj.socialVId === value;
}
case clsSysSocialRelationsVEN.con_SocialId:
return (obj: clsSysSocialRelationsVEN) => {
return obj.socialId === value;
}
case clsSysSocialRelationsVEN.con_FullName:
return (obj: clsSysSocialRelationsVEN) => {
return obj.fullName === value;
}
case clsSysSocialRelationsVEN.con_Nationality:
return (obj: clsSysSocialRelationsVEN) => {
return obj.nationality === value;
}
case clsSysSocialRelationsVEN.con_WorkUnit:
return (obj: clsSysSocialRelationsVEN) => {
return obj.workUnit === value;
}
case clsSysSocialRelationsVEN.con_Major:
return (obj: clsSysSocialRelationsVEN) => {
return obj.major === value;
}
case clsSysSocialRelationsVEN.con_Achievement:
return (obj: clsSysSocialRelationsVEN) => {
return obj.achievement === value;
}
case clsSysSocialRelationsVEN.con_DetailedDescription:
return (obj: clsSysSocialRelationsVEN) => {
return obj.detailedDescription === value;
}
case clsSysSocialRelationsVEN.con_LevelId:
return (obj: clsSysSocialRelationsVEN) => {
return obj.levelId === value;
}
case clsSysSocialRelationsVEN.con_UpdUser:
return (obj: clsSysSocialRelationsVEN) => {
return obj.updUser === value;
}
case clsSysSocialRelationsVEN.con_UpdDate:
return (obj: clsSysSocialRelationsVEN) => {
return obj.updDate === value;
}
case clsSysSocialRelationsVEN.con_id_CurrEduCls:
return (obj: clsSysSocialRelationsVEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysSocialRelationsVEN.con_Memo:
return (obj: clsSysSocialRelationsVEN) => {
return obj.memo === value;
}
case clsSysSocialRelationsVEN.con_CitationId:
return (obj: clsSysSocialRelationsVEN) => {
return obj.citationId === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelationsV]中不存在！(in ${ sysSocialRelationsV_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSocialRelationsV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetFirstObjAsync(strWhereCond: string): Promise<clsSysSocialRelationsVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSocialRelationsV = SysSocialRelationsV_GetObjFromJsonObj(returnObj);
return objSysSocialRelationsV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysSocialRelationsVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param arrSocialVId:关键字列表
 * @returns 对象列表
 **/
export async function SysSocialRelationsV_GetObjLstBySocialVIdLstAsync(arrSocialVId: Array<string>): Promise<Array<clsSysSocialRelationsVEN>>  
{
const strThisFuncName = "GetObjLstBySocialVIdLstAsync";
const strAction = "GetObjLstBySocialVIdLst";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSocialVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysSocialRelationsVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysSocialRelationsVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysSocialRelationsVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSocialRelationsV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param lngSocialVId:关键字
 * @returns 获取删除的结果
 **/
export async function SysSocialRelationsV_DelRecordAsync(lngSocialVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngSocialVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngSocialVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param arrSocialVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysSocialRelationsV_DelSysSocialRelationsVsAsync(arrSocialVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysSocialRelationsVsAsync";
const strAction = "DelSysSocialRelationsVs";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSocialVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_DelSysSocialRelationsVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysSocialRelationsVsByCondAsync";
const strAction = "DelSysSocialRelationsVsByCond";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param objSysSocialRelationsVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysSocialRelationsV_AddNewRecordAsync(objSysSocialRelationsVEN: clsSysSocialRelationsVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysSocialRelationsVEN);
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSocialRelationsVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param objSysSocialRelationsVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysSocialRelationsV_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsVEN: clsSysSocialRelationsVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSocialRelationsVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param objSysSocialRelationsVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysSocialRelationsV_AddNewRecordWithReturnKey(objSysSocialRelationsVEN: clsSysSocialRelationsVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysSocialRelationsVEN.socialVId === null || objSysSocialRelationsVEN.socialVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSocialRelationsVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param objSysSocialRelationsVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysSocialRelationsV_UpdateRecordAsync(objSysSocialRelationsVEN: clsSysSocialRelationsVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysSocialRelationsVEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVEN.sf_UpdFldSetStr === null || objSysSocialRelationsVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVEN.socialVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSocialRelationsVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param objSysSocialRelationsVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysSocialRelationsV_UpdateWithConditionAsync(objSysSocialRelationsVEN: clsSysSocialRelationsVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysSocialRelationsVEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsVEN.sf_UpdFldSetStr === null || objSysSocialRelationsVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsVEN.socialVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
objSysSocialRelationsVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysSocialRelationsVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param lngSocialVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysSocialRelationsV_IsExist(lngSocialVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SocialVId": lngSocialVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
 * @param lngSocialVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysSocialRelationsV_IsExistAsync(lngSocialVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngSocialVId": lngSocialVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export async function SysSocialRelationsV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysSocialRelationsV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSocialRelationsV_ConstructorName, strThisFuncName);
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
export function SysSocialRelationsV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysSocialRelationsV_CheckPropertyNew(pobjSysSocialRelationsVEN: clsSysSocialRelationsVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.socialId) === true )
{
 throw new Error("(errid:Watl000058)字段[社会Id]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.socialId) == false && GetStrLen(pobjSysSocialRelationsVEN.socialId) > 10)
{
 throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.socialId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.fullName) == false && GetStrLen(pobjSysSocialRelationsVEN.fullName) > 50)
{
 throw new Error("(errid:Watl000059)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.fullName)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.nationality) == false && GetStrLen(pobjSysSocialRelationsVEN.nationality) > 50)
{
 throw new Error("(errid:Watl000059)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.nationality)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.workUnit) == false && GetStrLen(pobjSysSocialRelationsVEN.workUnit) > 100)
{
 throw new Error("(errid:Watl000059)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.workUnit)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.major) == false && GetStrLen(pobjSysSocialRelationsVEN.major) > 50)
{
 throw new Error("(errid:Watl000059)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.major)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.achievement) == false && GetStrLen(pobjSysSocialRelationsVEN.achievement) > 5000)
{
 throw new Error("(errid:Watl000059)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.achievement)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.levelId) == false && GetStrLen(pobjSysSocialRelationsVEN.levelId) > 2)
{
 throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.levelId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updUser) == false && GetStrLen(pobjSysSocialRelationsVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updUser)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updDate) == false && GetStrLen(pobjSysSocialRelationsVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updDate)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && GetStrLen(pobjSysSocialRelationsVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.id_CurrEduCls)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.memo) == false && GetStrLen(pobjSysSocialRelationsVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.memo)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.citationId) == false && GetStrLen(pobjSysSocialRelationsVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.citationId)(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjSysSocialRelationsVEN.socialVId && undefined !== pobjSysSocialRelationsVEN.socialVId && tzDataType.isNumber(pobjSysSocialRelationsVEN.socialVId) === false)
{
 throw new Error("(errid:Watl000060)字段[社会版本Id(socialVId)]的值:[$(pobjSysSocialRelationsVEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.socialId) == false && undefined !== pobjSysSocialRelationsVEN.socialId && tzDataType.isString(pobjSysSocialRelationsVEN.socialId) === false)
{
 throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.fullName) == false && undefined !== pobjSysSocialRelationsVEN.fullName && tzDataType.isString(pobjSysSocialRelationsVEN.fullName) === false)
{
 throw new Error("(errid:Watl000060)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.nationality) == false && undefined !== pobjSysSocialRelationsVEN.nationality && tzDataType.isString(pobjSysSocialRelationsVEN.nationality) === false)
{
 throw new Error("(errid:Watl000060)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.workUnit) == false && undefined !== pobjSysSocialRelationsVEN.workUnit && tzDataType.isString(pobjSysSocialRelationsVEN.workUnit) === false)
{
 throw new Error("(errid:Watl000060)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.major) == false && undefined !== pobjSysSocialRelationsVEN.major && tzDataType.isString(pobjSysSocialRelationsVEN.major) === false)
{
 throw new Error("(errid:Watl000060)字段[专业(major)]的值:[$(pobjSysSocialRelationsVEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.achievement) == false && undefined !== pobjSysSocialRelationsVEN.achievement && tzDataType.isString(pobjSysSocialRelationsVEN.achievement) === false)
{
 throw new Error("(errid:Watl000060)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVEN.detailedDescription && tzDataType.isString(pobjSysSocialRelationsVEN.detailedDescription) === false)
{
 throw new Error("(errid:Watl000060)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.levelId) == false && undefined !== pobjSysSocialRelationsVEN.levelId && tzDataType.isString(pobjSysSocialRelationsVEN.levelId) === false)
{
 throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updUser) == false && undefined !== pobjSysSocialRelationsVEN.updUser && tzDataType.isString(pobjSysSocialRelationsVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updDate) == false && undefined !== pobjSysSocialRelationsVEN.updDate && tzDataType.isString(pobjSysSocialRelationsVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVEN.id_CurrEduCls && tzDataType.isString(pobjSysSocialRelationsVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.memo) == false && undefined !== pobjSysSocialRelationsVEN.memo && tzDataType.isString(pobjSysSocialRelationsVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.citationId) == false && undefined !== pobjSysSocialRelationsVEN.citationId && tzDataType.isString(pobjSysSocialRelationsVEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysSocialRelationsVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysSocialRelationsV_CheckProperty4Update (pobjSysSocialRelationsVEN: clsSysSocialRelationsVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.socialId) == false && GetStrLen(pobjSysSocialRelationsVEN.socialId) > 10)
{
 throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.socialId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.fullName) == false && GetStrLen(pobjSysSocialRelationsVEN.fullName) > 50)
{
 throw new Error("(errid:Watl000062)字段[姓名(fullName)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.fullName)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.nationality) == false && GetStrLen(pobjSysSocialRelationsVEN.nationality) > 50)
{
 throw new Error("(errid:Watl000062)字段[国籍(nationality)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.nationality)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.workUnit) == false && GetStrLen(pobjSysSocialRelationsVEN.workUnit) > 100)
{
 throw new Error("(errid:Watl000062)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.workUnit)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.major) == false && GetStrLen(pobjSysSocialRelationsVEN.major) > 50)
{
 throw new Error("(errid:Watl000062)字段[专业(major)]的长度不能超过50(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.major)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.achievement) == false && GetStrLen(pobjSysSocialRelationsVEN.achievement) > 5000)
{
 throw new Error("(errid:Watl000062)字段[成就(achievement)]的长度不能超过5000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.achievement)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.levelId) == false && GetStrLen(pobjSysSocialRelationsVEN.levelId) > 2)
{
 throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.levelId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updUser) == false && GetStrLen(pobjSysSocialRelationsVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updUser)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updDate) == false && GetStrLen(pobjSysSocialRelationsVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.updDate)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && GetStrLen(pobjSysSocialRelationsVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.id_CurrEduCls)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.memo) == false && GetStrLen(pobjSysSocialRelationsVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.memo)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.citationId) == false && GetStrLen(pobjSysSocialRelationsVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 社会关系版本表(SysSocialRelationsV))!值:$(pobjSysSocialRelationsVEN.citationId)(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjSysSocialRelationsVEN.socialVId && undefined !== pobjSysSocialRelationsVEN.socialVId && tzDataType.isNumber(pobjSysSocialRelationsVEN.socialVId) === false)
{
 throw new Error("(errid:Watl000063)字段[社会版本Id(socialVId)]的值:[$(pobjSysSocialRelationsVEN.socialVId)], 非法，应该为数值型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.socialId) == false && undefined !== pobjSysSocialRelationsVEN.socialId && tzDataType.isString(pobjSysSocialRelationsVEN.socialId) === false)
{
 throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsVEN.socialId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.fullName) == false && undefined !== pobjSysSocialRelationsVEN.fullName && tzDataType.isString(pobjSysSocialRelationsVEN.fullName) === false)
{
 throw new Error("(errid:Watl000063)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsVEN.fullName)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.nationality) == false && undefined !== pobjSysSocialRelationsVEN.nationality && tzDataType.isString(pobjSysSocialRelationsVEN.nationality) === false)
{
 throw new Error("(errid:Watl000063)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsVEN.nationality)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.workUnit) == false && undefined !== pobjSysSocialRelationsVEN.workUnit && tzDataType.isString(pobjSysSocialRelationsVEN.workUnit) === false)
{
 throw new Error("(errid:Watl000063)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsVEN.workUnit)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.major) == false && undefined !== pobjSysSocialRelationsVEN.major && tzDataType.isString(pobjSysSocialRelationsVEN.major) === false)
{
 throw new Error("(errid:Watl000063)字段[专业(major)]的值:[$(pobjSysSocialRelationsVEN.major)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.achievement) == false && undefined !== pobjSysSocialRelationsVEN.achievement && tzDataType.isString(pobjSysSocialRelationsVEN.achievement) === false)
{
 throw new Error("(errid:Watl000063)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsVEN.achievement)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsVEN.detailedDescription && tzDataType.isString(pobjSysSocialRelationsVEN.detailedDescription) === false)
{
 throw new Error("(errid:Watl000063)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsVEN.detailedDescription)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.levelId) == false && undefined !== pobjSysSocialRelationsVEN.levelId && tzDataType.isString(pobjSysSocialRelationsVEN.levelId) === false)
{
 throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsVEN.levelId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updUser) == false && undefined !== pobjSysSocialRelationsVEN.updUser && tzDataType.isString(pobjSysSocialRelationsVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsVEN.updUser)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.updDate) == false && undefined !== pobjSysSocialRelationsVEN.updDate && tzDataType.isString(pobjSysSocialRelationsVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsVEN.updDate)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsVEN.id_CurrEduCls && tzDataType.isString(pobjSysSocialRelationsVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsVEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.memo) == false && undefined !== pobjSysSocialRelationsVEN.memo && tzDataType.isString(pobjSysSocialRelationsVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSocialRelationsVEN.memo)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSocialRelationsVEN.citationId) == false && undefined !== pobjSysSocialRelationsVEN.citationId && tzDataType.isString(pobjSysSocialRelationsVEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsVEN.citationId)], 非法，应该为字符型(In 社会关系版本表(SysSocialRelationsV))!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSysSocialRelationsVEN.socialVId 
 || pobjSysSocialRelationsVEN.socialVId != null && pobjSysSocialRelationsVEN.socialVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[社会版本Id]不能为空(In 社会关系版本表)!(clsSysSocialRelationsVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysSocialRelationsVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSocialRelationsV_GetJSONStrByObj (pobjSysSocialRelationsVEN: clsSysSocialRelationsVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysSocialRelationsVEN.sf_UpdFldSetStr = pobjSysSocialRelationsVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysSocialRelationsVEN);
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
export function SysSocialRelationsV_GetObjLstByJSONStr (strJSON: string): Array<clsSysSocialRelationsVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysSocialRelationsVObjLst = new Array<clsSysSocialRelationsVEN>();
if (strJSON === "")
{
return arrSysSocialRelationsVObjLst;
}
try
{
arrSysSocialRelationsVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysSocialRelationsVObjLst;
}
return arrSysSocialRelationsVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysSocialRelationsVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysSocialRelationsV_GetObjLstByJSONObjLst (arrSysSocialRelationsVObjLstS: Array<clsSysSocialRelationsVEN>): Array<clsSysSocialRelationsVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysSocialRelationsVObjLst = new Array<clsSysSocialRelationsVEN>();
for (const objInFor of arrSysSocialRelationsVObjLstS) {
const obj1 = SysSocialRelationsV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysSocialRelationsVObjLst.push(obj1);
}
return arrSysSocialRelationsVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSocialRelationsV_GetObjByJSONStr (strJSON: string): clsSysSocialRelationsVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysSocialRelationsVEN = new clsSysSocialRelationsVEN();
if (strJSON === "")
{
return pobjSysSocialRelationsVEN;
}
try
{
pobjSysSocialRelationsVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysSocialRelationsVEN;
}
return pobjSysSocialRelationsVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysSocialRelationsV_GetCombineCondition(objSysSocialRelationsV_Cond: clsSysSocialRelationsVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_SocialVId) == true)
{
const strComparisonOp_SocialVId:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_SocialVId];
strWhereCond += Format(" And {0} {2} {1}", clsSysSocialRelationsVEN.con_SocialVId, objSysSocialRelationsV_Cond.socialVId, strComparisonOp_SocialVId);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_SocialId) == true)
{
const strComparisonOp_SocialId:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_SocialId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_SocialId, objSysSocialRelationsV_Cond.socialId, strComparisonOp_SocialId);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_FullName) == true)
{
const strComparisonOp_FullName:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_FullName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_FullName, objSysSocialRelationsV_Cond.fullName, strComparisonOp_FullName);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_Nationality) == true)
{
const strComparisonOp_Nationality:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_Nationality];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_Nationality, objSysSocialRelationsV_Cond.nationality, strComparisonOp_Nationality);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_WorkUnit) == true)
{
const strComparisonOp_WorkUnit:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_WorkUnit];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_WorkUnit, objSysSocialRelationsV_Cond.workUnit, strComparisonOp_WorkUnit);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_Major) == true)
{
const strComparisonOp_Major:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_Major];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_Major, objSysSocialRelationsV_Cond.major, strComparisonOp_Major);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_Achievement) == true)
{
const strComparisonOp_Achievement:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_Achievement];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_Achievement, objSysSocialRelationsV_Cond.achievement, strComparisonOp_Achievement);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_LevelId) == true)
{
const strComparisonOp_LevelId:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_LevelId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_LevelId, objSysSocialRelationsV_Cond.levelId, strComparisonOp_LevelId);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_UpdUser, objSysSocialRelationsV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_UpdDate, objSysSocialRelationsV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_id_CurrEduCls, objSysSocialRelationsV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_Memo, objSysSocialRelationsV_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysSocialRelationsV_Cond.dicFldComparisonOp, clsSysSocialRelationsVEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objSysSocialRelationsV_Cond.dicFldComparisonOp[clsSysSocialRelationsVEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSocialRelationsVEN.con_CitationId, objSysSocialRelationsV_Cond.citationId, strComparisonOp_CitationId);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSocialRelationsV(社会关系版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngSocialVId: 社会版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSocialRelationsV_GetUniCondStr_SocialVId(objSysSocialRelationsVEN: clsSysSocialRelationsVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SocialVId = '{0}'", objSysSocialRelationsVEN.socialVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSocialRelationsV(社会关系版本表),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngSocialVId: 社会版本Id(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSocialRelationsV_GetUniCondStr4Update_SocialVId(objSysSocialRelationsVEN: clsSysSocialRelationsVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SocialVId <> '{0}'", objSysSocialRelationsVEN.socialVId);
 strWhereCond +=  Format(" and SocialVId = '{0}'", objSysSocialRelationsVEN.socialVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysSocialRelationsVENS:源对象
 * @param objSysSocialRelationsVENT:目标对象
*/
export function SysSocialRelationsV_CopyObjTo(objSysSocialRelationsVENS: clsSysSocialRelationsVEN , objSysSocialRelationsVENT: clsSysSocialRelationsVEN ): void 
{
objSysSocialRelationsVENT.socialVId = objSysSocialRelationsVENS.socialVId; //社会版本Id
objSysSocialRelationsVENT.socialId = objSysSocialRelationsVENS.socialId; //社会Id
objSysSocialRelationsVENT.fullName = objSysSocialRelationsVENS.fullName; //姓名
objSysSocialRelationsVENT.nationality = objSysSocialRelationsVENS.nationality; //国籍
objSysSocialRelationsVENT.workUnit = objSysSocialRelationsVENS.workUnit; //工作单位
objSysSocialRelationsVENT.major = objSysSocialRelationsVENS.major; //专业
objSysSocialRelationsVENT.achievement = objSysSocialRelationsVENS.achievement; //成就
objSysSocialRelationsVENT.detailedDescription = objSysSocialRelationsVENS.detailedDescription; //详细说明
objSysSocialRelationsVENT.levelId = objSysSocialRelationsVENS.levelId; //级别Id
objSysSocialRelationsVENT.updUser = objSysSocialRelationsVENS.updUser; //修改人
objSysSocialRelationsVENT.updDate = objSysSocialRelationsVENS.updDate; //修改日期
objSysSocialRelationsVENT.id_CurrEduCls = objSysSocialRelationsVENS.id_CurrEduCls; //教学班流水号
objSysSocialRelationsVENT.memo = objSysSocialRelationsVENS.memo; //备注
objSysSocialRelationsVENT.citationId = objSysSocialRelationsVENS.citationId; //引用Id
objSysSocialRelationsVENT.sf_UpdFldSetStr = objSysSocialRelationsVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysSocialRelationsVENS:源对象
 * @param objSysSocialRelationsVENT:目标对象
*/
export function SysSocialRelationsV_GetObjFromJsonObj(objSysSocialRelationsVENS: clsSysSocialRelationsVEN): clsSysSocialRelationsVEN 
{
 const objSysSocialRelationsVENT: clsSysSocialRelationsVEN = new clsSysSocialRelationsVEN();
ObjectAssign(objSysSocialRelationsVENT, objSysSocialRelationsVENS);
 return objSysSocialRelationsVENT;
}