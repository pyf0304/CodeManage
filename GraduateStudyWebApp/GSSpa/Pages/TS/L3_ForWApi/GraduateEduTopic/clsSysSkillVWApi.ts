
 /**
 * 类名:clsSysSkillVWApi
 * 表名:SysSkillV(01120647)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:59
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
 * SysSkillV(SysSkillV)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsSysSkillVEN } from "../../L0_Entity/GraduateEduTopic/clsSysSkillVEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysSkillV_Controller = "SysSkillVApi";
 export const sysSkillV_ConstructorName = "sysSkillV";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param lngSkillVId:关键字
 * @returns 对象
 **/
export async function SysSkillV_GetObjBySkillVIdAsync(lngSkillVId: number): Promise<clsSysSkillVEN>  
{
const strThisFuncName = "GetObjBySkillVIdAsync";

if (lngSkillVId == 0)
{
  const strMsg = Format("参数:[lngSkillVId]不能为空！(In GetObjBySkillVIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjBySkillVId";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"lngSkillVId": lngSkillVId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSkillV = SysSkillV_GetObjFromJsonObj(returnObj);
return objSysSkillV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export function SysSkillV_SortFun_Defa(a:clsSysSkillVEN , b:clsSysSkillVEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.skillVId-b.skillVId;
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
export function SysSkillV_SortFun_Defa_2Fld(a:clsSysSkillVEN , b:clsSysSkillVEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.skillId == b.skillId) return a.skillName.localeCompare(b.skillName);
else return a.skillId.localeCompare(b.skillId);
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
export function SysSkillV_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysSkillVEN.con_SkillVId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.skillVId-b.skillVId;
}
case clsSysSkillVEN.con_SkillId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.skillId.localeCompare(b.skillId);
}
case clsSysSkillVEN.con_SkillName:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.skillName.localeCompare(b.skillName);
}
case clsSysSkillVEN.con_OperationTypeId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.operationTypeId.localeCompare(b.operationTypeId);
}
case clsSysSkillVEN.con_Process:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.process.localeCompare(b.process);
}
case clsSysSkillVEN.con_LevelId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.levelId.localeCompare(b.levelId);
}
case clsSysSkillVEN.con_UpdUser:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSysSkillVEN.con_UpdDate:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSysSkillVEN.con_CitationId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.citationId.localeCompare(b.citationId);
}
case clsSysSkillVEN.con_id_CurrEduCls:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
case clsSysSkillVEN.con_PdfContent:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.pdfContent.localeCompare(b.pdfContent);
}
case clsSysSkillVEN.con_PdfPageNum:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.pdfPageNum-b.pdfPageNum;
}
case clsSysSkillVEN.con_Memo:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkillV]中不存在！(in ${ sysSkillV_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysSkillVEN.con_SkillVId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.skillVId-a.skillVId;
}
case clsSysSkillVEN.con_SkillId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.skillId.localeCompare(a.skillId);
}
case clsSysSkillVEN.con_SkillName:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.skillName.localeCompare(a.skillName);
}
case clsSysSkillVEN.con_OperationTypeId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.operationTypeId.localeCompare(a.operationTypeId);
}
case clsSysSkillVEN.con_Process:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.process.localeCompare(a.process);
}
case clsSysSkillVEN.con_LevelId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.levelId.localeCompare(a.levelId);
}
case clsSysSkillVEN.con_UpdUser:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSysSkillVEN.con_UpdDate:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSysSkillVEN.con_CitationId:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.citationId.localeCompare(a.citationId);
}
case clsSysSkillVEN.con_id_CurrEduCls:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
case clsSysSkillVEN.con_PdfContent:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.pdfContent.localeCompare(a.pdfContent);
}
case clsSysSkillVEN.con_PdfPageNum:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.pdfPageNum-a.pdfPageNum;
}
case clsSysSkillVEN.con_Memo:
return (a: clsSysSkillVEN, b: clsSysSkillVEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkillV]中不存在！(in ${ sysSkillV_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSkillV_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysSkillVEN.con_SkillVId:
return (obj: clsSysSkillVEN) => {
return obj.skillVId === value;
}
case clsSysSkillVEN.con_SkillId:
return (obj: clsSysSkillVEN) => {
return obj.skillId === value;
}
case clsSysSkillVEN.con_SkillName:
return (obj: clsSysSkillVEN) => {
return obj.skillName === value;
}
case clsSysSkillVEN.con_OperationTypeId:
return (obj: clsSysSkillVEN) => {
return obj.operationTypeId === value;
}
case clsSysSkillVEN.con_Process:
return (obj: clsSysSkillVEN) => {
return obj.process === value;
}
case clsSysSkillVEN.con_LevelId:
return (obj: clsSysSkillVEN) => {
return obj.levelId === value;
}
case clsSysSkillVEN.con_UpdUser:
return (obj: clsSysSkillVEN) => {
return obj.updUser === value;
}
case clsSysSkillVEN.con_UpdDate:
return (obj: clsSysSkillVEN) => {
return obj.updDate === value;
}
case clsSysSkillVEN.con_CitationId:
return (obj: clsSysSkillVEN) => {
return obj.citationId === value;
}
case clsSysSkillVEN.con_id_CurrEduCls:
return (obj: clsSysSkillVEN) => {
return obj.id_CurrEduCls === value;
}
case clsSysSkillVEN.con_PdfContent:
return (obj: clsSysSkillVEN) => {
return obj.pdfContent === value;
}
case clsSysSkillVEN.con_PdfPageNum:
return (obj: clsSysSkillVEN) => {
return obj.pdfPageNum === value;
}
case clsSysSkillVEN.con_Memo:
return (obj: clsSysSkillVEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysSkillV]中不存在！(in ${ sysSkillV_ConstructorName}.${ strThisFuncName})`;
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
export async function SysSkillV_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetFirstObjAsync(strWhereCond: string): Promise<clsSysSkillVEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysSkillV = SysSkillV_GetObjFromJsonObj(returnObj);
return objSysSkillV;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysSkillVEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkillV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param arrSkillVId:关键字列表
 * @returns 对象列表
 **/
export async function SysSkillV_GetObjLstBySkillVIdLstAsync(arrSkillVId: Array<string>): Promise<Array<clsSysSkillVEN>>  
{
const strThisFuncName = "GetObjLstBySkillVIdLstAsync";
const strAction = "GetObjLstBySkillVIdLst";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSkillVId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkillV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysSkillVEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkillV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysSkillVEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkillV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysSkillVEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysSkillV_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysSkillV_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param lngSkillVId:关键字
 * @returns 获取删除的结果
 **/
export async function SysSkillV_DelRecordAsync(lngSkillVId: number): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, lngSkillVId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": lngSkillVId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param arrSkillVId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysSkillV_DelSysSkillVsAsync(arrSkillVId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysSkillVsAsync";
const strAction = "DelSysSkillVs";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrSkillVId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_DelSysSkillVsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysSkillVsByCondAsync";
const strAction = "DelSysSkillVsByCond";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param objSysSkillVEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysSkillV_AddNewRecordAsync(objSysSkillVEN: clsSysSkillVEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objSysSkillVEN);
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param objSysSkillVEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysSkillV_AddNewRecordWithReturnKeyAsync(objSysSkillVEN: clsSysSkillVEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param objSysSkillVEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysSkillV_AddNewRecordWithReturnKey(objSysSkillVEN: clsSysSkillVEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysSkillVEN.skillVId === null || objSysSkillVEN.skillVId === 0)
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param objSysSkillVEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysSkillV_UpdateRecordAsync(objSysSkillVEN: clsSysSkillVEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysSkillVEN.sf_UpdFldSetStr === undefined || objSysSkillVEN.sf_UpdFldSetStr === null || objSysSkillVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillVEN.skillVId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysSkillVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param objSysSkillVEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysSkillV_UpdateWithConditionAsync(objSysSkillVEN: clsSysSkillVEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysSkillVEN.sf_UpdFldSetStr === undefined || objSysSkillVEN.sf_UpdFldSetStr === null || objSysSkillVEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSkillVEN.skillVId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
objSysSkillVEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysSkillVEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param lngSkillVId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysSkillV_IsExist(lngSkillVId: number, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"SkillVId": lngSkillVId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
 * @param lngSkillVId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysSkillV_IsExistAsync(lngSkillVId: number): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "lngSkillVId": lngSkillVId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export async function SysSkillV_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysSkillV_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysSkillV_ConstructorName, strThisFuncName);
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
export function SysSkillV_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysSkillV_CheckPropertyNew(pobjSysSkillVEN: clsSysSkillVEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysSkillVEN.skillId) === true )
{
 throw new Error("(errid:Watl000058)字段[技能Id]不能为空(In SysSkillV)!(clsSysSkillVBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSkillVEN.skillId) == false && GetStrLen(pobjSysSkillVEN.skillId) > 10)
{
 throw new Error("(errid:Watl000059)字段[技能Id(skillId)]的长度不能超过10(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.skillId)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillName) == false && GetStrLen(pobjSysSkillVEN.skillName) > 200)
{
 throw new Error("(errid:Watl000059)字段[技能名称(skillName)]的长度不能超过200(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.skillName)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.operationTypeId) == false && GetStrLen(pobjSysSkillVEN.operationTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.operationTypeId)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.levelId) == false && GetStrLen(pobjSysSkillVEN.levelId) > 2)
{
 throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.levelId)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updUser) == false && GetStrLen(pobjSysSkillVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.updUser)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updDate) == false && GetStrLen(pobjSysSkillVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.updDate)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.citationId) == false && GetStrLen(pobjSysSkillVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.citationId)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.id_CurrEduCls) == false && GetStrLen(pobjSysSkillVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.id_CurrEduCls)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.pdfContent) == false && GetStrLen(pobjSysSkillVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.pdfContent)(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.memo) == false && GetStrLen(pobjSysSkillVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.memo)(clsSysSkillVBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (null != pobjSysSkillVEN.skillVId && undefined !== pobjSysSkillVEN.skillVId && tzDataType.isNumber(pobjSysSkillVEN.skillVId) === false)
{
 throw new Error("(errid:Watl000060)字段[SkillVId(skillVId)]的值:[$(pobjSysSkillVEN.skillVId)], 非法，应该为数值型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillId) == false && undefined !== pobjSysSkillVEN.skillId && tzDataType.isString(pobjSysSkillVEN.skillId) === false)
{
 throw new Error("(errid:Watl000060)字段[技能Id(skillId)]的值:[$(pobjSysSkillVEN.skillId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillName) == false && undefined !== pobjSysSkillVEN.skillName && tzDataType.isString(pobjSysSkillVEN.skillName) === false)
{
 throw new Error("(errid:Watl000060)字段[技能名称(skillName)]的值:[$(pobjSysSkillVEN.skillName)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.operationTypeId) == false && undefined !== pobjSysSkillVEN.operationTypeId && tzDataType.isString(pobjSysSkillVEN.operationTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillVEN.operationTypeId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.process) == false && undefined !== pobjSysSkillVEN.process && tzDataType.isString(pobjSysSkillVEN.process) === false)
{
 throw new Error("(errid:Watl000060)字段[实施过程(process)]的值:[$(pobjSysSkillVEN.process)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.levelId) == false && undefined !== pobjSysSkillVEN.levelId && tzDataType.isString(pobjSysSkillVEN.levelId) === false)
{
 throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSkillVEN.levelId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updUser) == false && undefined !== pobjSysSkillVEN.updUser && tzDataType.isString(pobjSysSkillVEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSkillVEN.updUser)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updDate) == false && undefined !== pobjSysSkillVEN.updDate && tzDataType.isString(pobjSysSkillVEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSkillVEN.updDate)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.citationId) == false && undefined !== pobjSysSkillVEN.citationId && tzDataType.isString(pobjSysSkillVEN.citationId) === false)
{
 throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSkillVEN.citationId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.id_CurrEduCls) == false && undefined !== pobjSysSkillVEN.id_CurrEduCls && tzDataType.isString(pobjSysSkillVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillVEN.id_CurrEduCls)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.pdfContent) == false && undefined !== pobjSysSkillVEN.pdfContent && tzDataType.isString(pobjSysSkillVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillVEN.pdfContent)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (null != pobjSysSkillVEN.pdfPageNum && undefined !== pobjSysSkillVEN.pdfPageNum && tzDataType.isNumber(pobjSysSkillVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillVEN.pdfPageNum)], 非法，应该为数值型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.memo) == false && undefined !== pobjSysSkillVEN.memo && tzDataType.isString(pobjSysSkillVEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSkillVEN.memo)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysSkillVEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysSkillV_CheckProperty4Update (pobjSysSkillVEN: clsSysSkillVEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysSkillVEN.skillId) == false && GetStrLen(pobjSysSkillVEN.skillId) > 10)
{
 throw new Error("(errid:Watl000062)字段[技能Id(skillId)]的长度不能超过10(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.skillId)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillName) == false && GetStrLen(pobjSysSkillVEN.skillName) > 200)
{
 throw new Error("(errid:Watl000062)字段[技能名称(skillName)]的长度不能超过200(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.skillName)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.operationTypeId) == false && GetStrLen(pobjSysSkillVEN.operationTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.operationTypeId)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.levelId) == false && GetStrLen(pobjSysSkillVEN.levelId) > 2)
{
 throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.levelId)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updUser) == false && GetStrLen(pobjSysSkillVEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.updUser)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updDate) == false && GetStrLen(pobjSysSkillVEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.updDate)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.citationId) == false && GetStrLen(pobjSysSkillVEN.citationId) > 8)
{
 throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.citationId)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.id_CurrEduCls) == false && GetStrLen(pobjSysSkillVEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.id_CurrEduCls)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.pdfContent) == false && GetStrLen(pobjSysSkillVEN.pdfContent) > 2000)
{
 throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.pdfContent)(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.memo) == false && GetStrLen(pobjSysSkillVEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In SysSkillV(SysSkillV))!值:$(pobjSysSkillVEN.memo)(clsSysSkillVBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (null != pobjSysSkillVEN.skillVId && undefined !== pobjSysSkillVEN.skillVId && tzDataType.isNumber(pobjSysSkillVEN.skillVId) === false)
{
 throw new Error("(errid:Watl000063)字段[SkillVId(skillVId)]的值:[$(pobjSysSkillVEN.skillVId)], 非法，应该为数值型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillId) == false && undefined !== pobjSysSkillVEN.skillId && tzDataType.isString(pobjSysSkillVEN.skillId) === false)
{
 throw new Error("(errid:Watl000063)字段[技能Id(skillId)]的值:[$(pobjSysSkillVEN.skillId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.skillName) == false && undefined !== pobjSysSkillVEN.skillName && tzDataType.isString(pobjSysSkillVEN.skillName) === false)
{
 throw new Error("(errid:Watl000063)字段[技能名称(skillName)]的值:[$(pobjSysSkillVEN.skillName)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.operationTypeId) == false && undefined !== pobjSysSkillVEN.operationTypeId && tzDataType.isString(pobjSysSkillVEN.operationTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysSkillVEN.operationTypeId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.process) == false && undefined !== pobjSysSkillVEN.process && tzDataType.isString(pobjSysSkillVEN.process) === false)
{
 throw new Error("(errid:Watl000063)字段[实施过程(process)]的值:[$(pobjSysSkillVEN.process)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.levelId) == false && undefined !== pobjSysSkillVEN.levelId && tzDataType.isString(pobjSysSkillVEN.levelId) === false)
{
 throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSkillVEN.levelId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updUser) == false && undefined !== pobjSysSkillVEN.updUser && tzDataType.isString(pobjSysSkillVEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSkillVEN.updUser)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.updDate) == false && undefined !== pobjSysSkillVEN.updDate && tzDataType.isString(pobjSysSkillVEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSkillVEN.updDate)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.citationId) == false && undefined !== pobjSysSkillVEN.citationId && tzDataType.isString(pobjSysSkillVEN.citationId) === false)
{
 throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSkillVEN.citationId)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.id_CurrEduCls) == false && undefined !== pobjSysSkillVEN.id_CurrEduCls && tzDataType.isString(pobjSysSkillVEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSkillVEN.id_CurrEduCls)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.pdfContent) == false && undefined !== pobjSysSkillVEN.pdfContent && tzDataType.isString(pobjSysSkillVEN.pdfContent) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSkillVEN.pdfContent)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (null != pobjSysSkillVEN.pdfPageNum && undefined !== pobjSysSkillVEN.pdfPageNum && tzDataType.isNumber(pobjSysSkillVEN.pdfPageNum) === false)
{
 throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSkillVEN.pdfPageNum)], 非法，应该为数值型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysSkillVEN.memo) == false && undefined !== pobjSysSkillVEN.memo && tzDataType.isString(pobjSysSkillVEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSkillVEN.memo)], 非法，应该为字符型(In SysSkillV(SysSkillV))!(clsSysSkillVBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (null === pobjSysSkillVEN.skillVId 
 || pobjSysSkillVEN.skillVId != null && pobjSysSkillVEN.skillVId.toString()  ===  "")
{
 throw new Error("(errid:Watl000064)字段[SkillVId]不能为空(In SysSkillV)!(clsSysSkillVBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysSkillVEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSkillV_GetJSONStrByObj (pobjSysSkillVEN: clsSysSkillVEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysSkillVEN.sf_UpdFldSetStr = pobjSysSkillVEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysSkillVEN);
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
export function SysSkillV_GetObjLstByJSONStr (strJSON: string): Array<clsSysSkillVEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysSkillVObjLst = new Array<clsSysSkillVEN>();
if (strJSON === "")
{
return arrSysSkillVObjLst;
}
try
{
arrSysSkillVObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysSkillVObjLst;
}
return arrSysSkillVObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysSkillVObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysSkillV_GetObjLstByJSONObjLst (arrSysSkillVObjLstS: Array<clsSysSkillVEN>): Array<clsSysSkillVEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysSkillVObjLst = new Array<clsSysSkillVEN>();
for (const objInFor of arrSysSkillVObjLstS) {
const obj1 = SysSkillV_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysSkillVObjLst.push(obj1);
}
return arrSysSkillVObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysSkillV_GetObjByJSONStr (strJSON: string): clsSysSkillVEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysSkillVEN = new clsSysSkillVEN();
if (strJSON === "")
{
return pobjSysSkillVEN;
}
try
{
pobjSysSkillVEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysSkillVEN;
}
return pobjSysSkillVEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysSkillV_GetCombineCondition(objSysSkillV_Cond: clsSysSkillVEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_SkillVId) == true)
{
const strComparisonOp_SkillVId:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_SkillVId];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillVEN.con_SkillVId, objSysSkillV_Cond.skillVId, strComparisonOp_SkillVId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_SkillId) == true)
{
const strComparisonOp_SkillId:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_SkillId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_SkillId, objSysSkillV_Cond.skillId, strComparisonOp_SkillId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_SkillName) == true)
{
const strComparisonOp_SkillName:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_SkillName];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_SkillName, objSysSkillV_Cond.skillName, strComparisonOp_SkillName);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_OperationTypeId) == true)
{
const strComparisonOp_OperationTypeId:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_OperationTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_OperationTypeId, objSysSkillV_Cond.operationTypeId, strComparisonOp_OperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_LevelId) == true)
{
const strComparisonOp_LevelId:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_LevelId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_LevelId, objSysSkillV_Cond.levelId, strComparisonOp_LevelId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_UpdUser, objSysSkillV_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_UpdDate, objSysSkillV_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_CitationId) == true)
{
const strComparisonOp_CitationId:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_CitationId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_CitationId, objSysSkillV_Cond.citationId, strComparisonOp_CitationId);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_id_CurrEduCls, objSysSkillV_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_PdfContent) == true)
{
const strComparisonOp_PdfContent:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_PdfContent];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_PdfContent, objSysSkillV_Cond.pdfContent, strComparisonOp_PdfContent);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_PdfPageNum) == true)
{
const strComparisonOp_PdfPageNum:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_PdfPageNum];
strWhereCond += Format(" And {0} {2} {1}", clsSysSkillVEN.con_PdfPageNum, objSysSkillV_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
}
if (Object.prototype.hasOwnProperty.call(objSysSkillV_Cond.dicFldComparisonOp, clsSysSkillVEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysSkillV_Cond.dicFldComparisonOp[clsSysSkillVEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysSkillVEN.con_Memo, objSysSkillV_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSkillV(SysSkillV),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param lngSkillVId: SkillVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSkillV_GetUniCondStr_SkillVId(objSysSkillVEN: clsSysSkillVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and SkillVId = '{0}'", objSysSkillVEN.skillVId);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--SysSkillV(SysSkillV),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param lngSkillVId: SkillVId(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function SysSkillV_GetUniCondStr4Update_SkillVId(objSysSkillVEN: clsSysSkillVEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and SkillVId <> '{0}'", objSysSkillVEN.skillVId);
 strWhereCond +=  Format(" and SkillVId = '{0}'", objSysSkillVEN.skillVId);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysSkillVENS:源对象
 * @param objSysSkillVENT:目标对象
*/
export function SysSkillV_CopyObjTo(objSysSkillVENS: clsSysSkillVEN , objSysSkillVENT: clsSysSkillVEN ): void 
{
objSysSkillVENT.skillVId = objSysSkillVENS.skillVId; //SkillVId
objSysSkillVENT.skillId = objSysSkillVENS.skillId; //技能Id
objSysSkillVENT.skillName = objSysSkillVENS.skillName; //技能名称
objSysSkillVENT.operationTypeId = objSysSkillVENS.operationTypeId; //操作类型ID
objSysSkillVENT.process = objSysSkillVENS.process; //实施过程
objSysSkillVENT.levelId = objSysSkillVENS.levelId; //级别Id
objSysSkillVENT.updUser = objSysSkillVENS.updUser; //修改人
objSysSkillVENT.updDate = objSysSkillVENS.updDate; //修改日期
objSysSkillVENT.citationId = objSysSkillVENS.citationId; //引用Id
objSysSkillVENT.id_CurrEduCls = objSysSkillVENS.id_CurrEduCls; //教学班流水号
objSysSkillVENT.pdfContent = objSysSkillVENS.pdfContent; //Pdf内容
objSysSkillVENT.pdfPageNum = objSysSkillVENS.pdfPageNum; //Pdf页码
objSysSkillVENT.memo = objSysSkillVENS.memo; //备注
objSysSkillVENT.sf_UpdFldSetStr = objSysSkillVENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysSkillVENS:源对象
 * @param objSysSkillVENT:目标对象
*/
export function SysSkillV_GetObjFromJsonObj(objSysSkillVENS: clsSysSkillVEN): clsSysSkillVEN 
{
 const objSysSkillVENT: clsSysSkillVEN = new clsSysSkillVEN();
ObjectAssign(objSysSkillVENT, objSysSkillVENS);
 return objSysSkillVENT;
}