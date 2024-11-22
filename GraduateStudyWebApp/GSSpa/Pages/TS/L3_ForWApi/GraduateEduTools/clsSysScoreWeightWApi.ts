
 /**
 * 类名:clsSysScoreWeightWApi
 * 表名:SysScoreWeight(01120629)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:16
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 系统分数权重表(SysScoreWeight)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsSysScoreWeightEN } from "../../L0_Entity/GraduateEduTools/clsSysScoreWeightEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sysScoreWeight_Controller = "SysScoreWeightApi";
 export const sysScoreWeight_ConstructorName = "sysScoreWeight";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strScoreWeightId:关键字
 * @returns 对象
 **/
export async function SysScoreWeight_GetObjByScoreWeightIdAsync(strScoreWeightId: string): Promise<clsSysScoreWeightEN>  
{
const strThisFuncName = "GetObjByScoreWeightIdAsync";

if (IsNullOrEmpty(strScoreWeightId) == true)
{
  const strMsg = Format("参数:[strScoreWeightId]不能为空！(In GetObjByScoreWeightIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strScoreWeightId.length != 1)
{
const strMsg = Format("缓存分类变量:[strScoreWeightId]的长度:[{0}]不正确！", strScoreWeightId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByScoreWeightId";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strScoreWeightId": strScoreWeightId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysScoreWeight = SysScoreWeight_GetObjFromJsonObj(returnObj);
return objSysScoreWeight;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export function SysScoreWeight_SortFun_Defa(a:clsSysScoreWeightEN , b:clsSysScoreWeightEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.scoreWeightId.localeCompare(b.scoreWeightId);
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
export function SysScoreWeight_SortFun_Defa_2Fld(a:clsSysScoreWeightEN , b:clsSysScoreWeightEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.memo == b.memo) return a.scoreTypeId.localeCompare(b.scoreTypeId);
else return a.memo.localeCompare(b.memo);
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
export function SysScoreWeight_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSysScoreWeightEN.con_ScoreWeightId:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.scoreWeightId.localeCompare(b.scoreWeightId);
}
case clsSysScoreWeightEN.con_Memo:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.memo.localeCompare(b.memo);
}
case clsSysScoreWeightEN.con_IsPublic:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
if (a.isPublic == true) return 1;
else return -1
}
case clsSysScoreWeightEN.con_ScoreTypeId:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.scoreTypeId.localeCompare(b.scoreTypeId);
}
case clsSysScoreWeightEN.con_ScoreWeightValue:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.scoreWeightValue.localeCompare(b.scoreWeightValue);
}
case clsSysScoreWeightEN.con_UpdDate:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsSysScoreWeightEN.con_UpdUser:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsSysScoreWeightEN.con_id_CurrEduCls:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${ sysScoreWeight_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSysScoreWeightEN.con_ScoreWeightId:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.scoreWeightId.localeCompare(a.scoreWeightId);
}
case clsSysScoreWeightEN.con_Memo:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.memo.localeCompare(a.memo);
}
case clsSysScoreWeightEN.con_IsPublic:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
if (b.isPublic == true) return 1;
else return -1
}
case clsSysScoreWeightEN.con_ScoreTypeId:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.scoreTypeId.localeCompare(a.scoreTypeId);
}
case clsSysScoreWeightEN.con_ScoreWeightValue:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.scoreWeightValue.localeCompare(a.scoreWeightValue);
}
case clsSysScoreWeightEN.con_UpdDate:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsSysScoreWeightEN.con_UpdUser:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsSysScoreWeightEN.con_id_CurrEduCls:
return (a: clsSysScoreWeightEN, b: clsSysScoreWeightEN) => {
return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${ sysScoreWeight_ConstructorName}.${ strThisFuncName})`;
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
export async function SysScoreWeight_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSysScoreWeightEN.con_ScoreWeightId:
return (obj: clsSysScoreWeightEN) => {
return obj.scoreWeightId === value;
}
case clsSysScoreWeightEN.con_Memo:
return (obj: clsSysScoreWeightEN) => {
return obj.memo === value;
}
case clsSysScoreWeightEN.con_IsPublic:
return (obj: clsSysScoreWeightEN) => {
return obj.isPublic === value;
}
case clsSysScoreWeightEN.con_ScoreTypeId:
return (obj: clsSysScoreWeightEN) => {
return obj.scoreTypeId === value;
}
case clsSysScoreWeightEN.con_ScoreWeightValue:
return (obj: clsSysScoreWeightEN) => {
return obj.scoreWeightValue === value;
}
case clsSysScoreWeightEN.con_UpdDate:
return (obj: clsSysScoreWeightEN) => {
return obj.updDate === value;
}
case clsSysScoreWeightEN.con_UpdUser:
return (obj: clsSysScoreWeightEN) => {
return obj.updUser === value;
}
case clsSysScoreWeightEN.con_id_CurrEduCls:
return (obj: clsSysScoreWeightEN) => {
return obj.id_CurrEduCls === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[SysScoreWeight]中不存在！(in ${ sysScoreWeight_ConstructorName}.${ strThisFuncName})`;
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
export async function SysScoreWeight_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetFirstObjAsync(strWhereCond: string): Promise<clsSysScoreWeightEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSysScoreWeight = SysScoreWeight_GetObjFromJsonObj(returnObj);
return objSysScoreWeight;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param arrScoreWeightId:关键字列表
 * @returns 对象列表
 **/
export async function SysScoreWeight_GetObjLstByScoreWeightIdLstAsync(arrScoreWeightId: Array<string>): Promise<Array<clsSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByScoreWeightIdLstAsync";
const strAction = "GetObjLstByScoreWeightIdLst";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrScoreWeightId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSysScoreWeightEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSysScoreWeightEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = SysScoreWeight_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:关键字
 * @returns 获取删除的结果
 **/
export async function SysScoreWeight_DelRecordAsync(strScoreWeightId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strScoreWeightId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strScoreWeightId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param arrScoreWeightId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function SysScoreWeight_DelSysScoreWeightsAsync(arrScoreWeightId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSysScoreWeightsAsync";
const strAction = "DelSysScoreWeights";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrScoreWeightId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_DelSysScoreWeightsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSysScoreWeightsByCondAsync";
const strAction = "DelSysScoreWeightsByCond";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysScoreWeight_AddNewRecordAsync(objSysScoreWeightEN: clsSysScoreWeightEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSysScoreWeightEN.scoreWeightId === null || objSysScoreWeightEN.scoreWeightId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSysScoreWeightEN);
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function SysScoreWeight_AddNewRecordWithMaxIdAsync(objSysScoreWeightEN: clsSysScoreWeightEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function SysScoreWeight_AddNewRecordWithReturnKeyAsync(objSysScoreWeightEN: clsSysScoreWeightEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function SysScoreWeight_AddNewRecordWithReturnKey(objSysScoreWeightEN: clsSysScoreWeightEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSysScoreWeightEN.scoreWeightId === null || objSysScoreWeightEN.scoreWeightId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function SysScoreWeight_UpdateRecordAsync(objSysScoreWeightEN: clsSysScoreWeightEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSysScoreWeightEN.sf_UpdFldSetStr === undefined || objSysScoreWeightEN.sf_UpdFldSetStr === null || objSysScoreWeightEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreWeightEN.scoreWeightId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param objSysScoreWeightEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function SysScoreWeight_UpdateWithConditionAsync(objSysScoreWeightEN: clsSysScoreWeightEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSysScoreWeightEN.sf_UpdFldSetStr === undefined || objSysScoreWeightEN.sf_UpdFldSetStr === null || objSysScoreWeightEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreWeightEN.scoreWeightId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
objSysScoreWeightEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSysScoreWeightEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function SysScoreWeight_IsExist(strScoreWeightId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"ScoreWeightId": strScoreWeightId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
 * @param strScoreWeightId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function SysScoreWeight_IsExistAsync(strScoreWeightId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strScoreWeightId": strScoreWeightId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export async function SysScoreWeight_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sysScoreWeight_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sysScoreWeight_ConstructorName, strThisFuncName);
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
export function SysScoreWeight_GetWebApiUrl(strController: string, strAction: string): string {
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
export function SysScoreWeight_CheckPropertyNew(pobjSysScoreWeightEN: clsSysScoreWeightEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightValue) === true )
{
 throw new Error("(errid:Watl000058)字段[分数权重值]不能为空(In 系统分数权重表)!(clsSysScoreWeightBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightId) == false && GetStrLen(pobjSysScoreWeightEN.scoreWeightId) > 1)
{
 throw new Error("(errid:Watl000059)字段[分数权重Id(scoreWeightId)]的长度不能超过1(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightId)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.memo) == false && GetStrLen(pobjSysScoreWeightEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.memo)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreTypeId) == false && GetStrLen(pobjSysScoreWeightEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000059)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreTypeId)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightValue) == false && GetStrLen(pobjSysScoreWeightEN.scoreWeightValue) > 20)
{
 throw new Error("(errid:Watl000059)字段[分数权重值(scoreWeightValue)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightValue)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updDate) == false && GetStrLen(pobjSysScoreWeightEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updDate)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updUser) == false && GetStrLen(pobjSysScoreWeightEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updUser)(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.id_CurrEduCls) == false && GetStrLen(pobjSysScoreWeightEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.id_CurrEduCls)(clsSysScoreWeightBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightId) == false && undefined !== pobjSysScoreWeightEN.scoreWeightId && tzDataType.isString(pobjSysScoreWeightEN.scoreWeightId) === false)
{
 throw new Error("(errid:Watl000060)字段[分数权重Id(scoreWeightId)]的值:[$(pobjSysScoreWeightEN.scoreWeightId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.memo) == false && undefined !== pobjSysScoreWeightEN.memo && tzDataType.isString(pobjSysScoreWeightEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysScoreWeightEN.memo)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (null != pobjSysScoreWeightEN.isPublic && undefined !== pobjSysScoreWeightEN.isPublic && tzDataType.isBoolean(pobjSysScoreWeightEN.isPublic) === false)
{
 throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjSysScoreWeightEN.isPublic)], 非法，应该为布尔型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreTypeId) == false && undefined !== pobjSysScoreWeightEN.scoreTypeId && tzDataType.isString(pobjSysScoreWeightEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000060)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreWeightEN.scoreTypeId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightValue) == false && undefined !== pobjSysScoreWeightEN.scoreWeightValue && tzDataType.isString(pobjSysScoreWeightEN.scoreWeightValue) === false)
{
 throw new Error("(errid:Watl000060)字段[分数权重值(scoreWeightValue)]的值:[$(pobjSysScoreWeightEN.scoreWeightValue)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updDate) == false && undefined !== pobjSysScoreWeightEN.updDate && tzDataType.isString(pobjSysScoreWeightEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysScoreWeightEN.updDate)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updUser) == false && undefined !== pobjSysScoreWeightEN.updUser && tzDataType.isString(pobjSysScoreWeightEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysScoreWeightEN.updUser)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.id_CurrEduCls) == false && undefined !== pobjSysScoreWeightEN.id_CurrEduCls && tzDataType.isString(pobjSysScoreWeightEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreWeightEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSysScoreWeightEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function SysScoreWeight_CheckProperty4Update (pobjSysScoreWeightEN: clsSysScoreWeightEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightId) == false && GetStrLen(pobjSysScoreWeightEN.scoreWeightId) > 1)
{
 throw new Error("(errid:Watl000062)字段[分数权重Id(scoreWeightId)]的长度不能超过1(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightId)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.memo) == false && GetStrLen(pobjSysScoreWeightEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.memo)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreTypeId) == false && GetStrLen(pobjSysScoreWeightEN.scoreTypeId) > 4)
{
 throw new Error("(errid:Watl000062)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreTypeId)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightValue) == false && GetStrLen(pobjSysScoreWeightEN.scoreWeightValue) > 20)
{
 throw new Error("(errid:Watl000062)字段[分数权重值(scoreWeightValue)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.scoreWeightValue)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updDate) == false && GetStrLen(pobjSysScoreWeightEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updDate)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updUser) == false && GetStrLen(pobjSysScoreWeightEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.updUser)(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.id_CurrEduCls) == false && GetStrLen(pobjSysScoreWeightEN.id_CurrEduCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统分数权重表(SysScoreWeight))!值:$(pobjSysScoreWeightEN.id_CurrEduCls)(clsSysScoreWeightBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightId) == false && undefined !== pobjSysScoreWeightEN.scoreWeightId && tzDataType.isString(pobjSysScoreWeightEN.scoreWeightId) === false)
{
 throw new Error("(errid:Watl000063)字段[分数权重Id(scoreWeightId)]的值:[$(pobjSysScoreWeightEN.scoreWeightId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.memo) == false && undefined !== pobjSysScoreWeightEN.memo && tzDataType.isString(pobjSysScoreWeightEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysScoreWeightEN.memo)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (null != pobjSysScoreWeightEN.isPublic && undefined !== pobjSysScoreWeightEN.isPublic && tzDataType.isBoolean(pobjSysScoreWeightEN.isPublic) === false)
{
 throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjSysScoreWeightEN.isPublic)], 非法，应该为布尔型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreTypeId) == false && undefined !== pobjSysScoreWeightEN.scoreTypeId && tzDataType.isString(pobjSysScoreWeightEN.scoreTypeId) === false)
{
 throw new Error("(errid:Watl000063)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreWeightEN.scoreTypeId)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightValue) == false && undefined !== pobjSysScoreWeightEN.scoreWeightValue && tzDataType.isString(pobjSysScoreWeightEN.scoreWeightValue) === false)
{
 throw new Error("(errid:Watl000063)字段[分数权重值(scoreWeightValue)]的值:[$(pobjSysScoreWeightEN.scoreWeightValue)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updDate) == false && undefined !== pobjSysScoreWeightEN.updDate && tzDataType.isString(pobjSysScoreWeightEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysScoreWeightEN.updDate)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.updUser) == false && undefined !== pobjSysScoreWeightEN.updUser && tzDataType.isString(pobjSysScoreWeightEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysScoreWeightEN.updUser)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSysScoreWeightEN.id_CurrEduCls) == false && undefined !== pobjSysScoreWeightEN.id_CurrEduCls && tzDataType.isString(pobjSysScoreWeightEN.id_CurrEduCls) === false)
{
 throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysScoreWeightEN.id_CurrEduCls)], 非法，应该为字符型(In 系统分数权重表(SysScoreWeight))!(clsSysScoreWeightBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSysScoreWeightEN.scoreWeightId) === true )
{
 throw new Error("(errid:Watl000064)字段[分数权重Id]不能为空(In 系统分数权重表)!(clsSysScoreWeightBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSysScoreWeightEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreWeight_GetJSONStrByObj (pobjSysScoreWeightEN: clsSysScoreWeightEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSysScoreWeightEN.sf_UpdFldSetStr = pobjSysScoreWeightEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSysScoreWeightEN);
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
export function SysScoreWeight_GetObjLstByJSONStr (strJSON: string): Array<clsSysScoreWeightEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSysScoreWeightObjLst = new Array<clsSysScoreWeightEN>();
if (strJSON === "")
{
return arrSysScoreWeightObjLst;
}
try
{
arrSysScoreWeightObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSysScoreWeightObjLst;
}
return arrSysScoreWeightObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSysScoreWeightObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function SysScoreWeight_GetObjLstByJSONObjLst (arrSysScoreWeightObjLstS: Array<clsSysScoreWeightEN>): Array<clsSysScoreWeightEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSysScoreWeightObjLst = new Array<clsSysScoreWeightEN>();
for (const objInFor of arrSysScoreWeightObjLstS) {
const obj1 = SysScoreWeight_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSysScoreWeightObjLst.push(obj1);
}
return arrSysScoreWeightObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function SysScoreWeight_GetObjByJSONStr (strJSON: string): clsSysScoreWeightEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSysScoreWeightEN = new clsSysScoreWeightEN();
if (strJSON === "")
{
return pobjSysScoreWeightEN;
}
try
{
pobjSysScoreWeightEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSysScoreWeightEN;
}
return pobjSysScoreWeightEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function SysScoreWeight_GetCombineCondition(objSysScoreWeight_Cond: clsSysScoreWeightEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_ScoreWeightId) == true)
{
const strComparisonOp_ScoreWeightId:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_ScoreWeightId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_ScoreWeightId, objSysScoreWeight_Cond.scoreWeightId, strComparisonOp_ScoreWeightId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_Memo, objSysScoreWeight_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_IsPublic) == true)
{
if (objSysScoreWeight_Cond.isPublic == true)
{
strWhereCond += Format(" And {0} = '1'", clsSysScoreWeightEN.con_IsPublic);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsSysScoreWeightEN.con_IsPublic);
}
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_ScoreTypeId) == true)
{
const strComparisonOp_ScoreTypeId:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_ScoreTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_ScoreTypeId, objSysScoreWeight_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_ScoreWeightValue) == true)
{
const strComparisonOp_ScoreWeightValue:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_ScoreWeightValue];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_ScoreWeightValue, objSysScoreWeight_Cond.scoreWeightValue, strComparisonOp_ScoreWeightValue);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_UpdDate, objSysScoreWeight_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_UpdUser, objSysScoreWeight_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objSysScoreWeight_Cond.dicFldComparisonOp, clsSysScoreWeightEN.con_id_CurrEduCls) == true)
{
const strComparisonOp_id_CurrEduCls:string = objSysScoreWeight_Cond.dicFldComparisonOp[clsSysScoreWeightEN.con_id_CurrEduCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsSysScoreWeightEN.con_id_CurrEduCls, objSysScoreWeight_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSysScoreWeightENS:源对象
 * @param objSysScoreWeightENT:目标对象
*/
export function SysScoreWeight_CopyObjTo(objSysScoreWeightENS: clsSysScoreWeightEN , objSysScoreWeightENT: clsSysScoreWeightEN ): void 
{
objSysScoreWeightENT.scoreWeightId = objSysScoreWeightENS.scoreWeightId; //分数权重Id
objSysScoreWeightENT.memo = objSysScoreWeightENS.memo; //备注
objSysScoreWeightENT.isPublic = objSysScoreWeightENS.isPublic; //是否公开
objSysScoreWeightENT.scoreTypeId = objSysScoreWeightENS.scoreTypeId; //分数类型Id
objSysScoreWeightENT.scoreWeightValue = objSysScoreWeightENS.scoreWeightValue; //分数权重值
objSysScoreWeightENT.updDate = objSysScoreWeightENS.updDate; //修改日期
objSysScoreWeightENT.updUser = objSysScoreWeightENS.updUser; //修改人
objSysScoreWeightENT.id_CurrEduCls = objSysScoreWeightENS.id_CurrEduCls; //教学班流水号
objSysScoreWeightENT.sf_UpdFldSetStr = objSysScoreWeightENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSysScoreWeightENS:源对象
 * @param objSysScoreWeightENT:目标对象
*/
export function SysScoreWeight_GetObjFromJsonObj(objSysScoreWeightENS: clsSysScoreWeightEN): clsSysScoreWeightEN 
{
 const objSysScoreWeightENT: clsSysScoreWeightEN = new clsSysScoreWeightEN();
ObjectAssign(objSysScoreWeightENT, objSysScoreWeightENS);
 return objSysScoreWeightENT;
}