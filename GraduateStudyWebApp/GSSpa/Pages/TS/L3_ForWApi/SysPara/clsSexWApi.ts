
 /**
 * 类名:clsSexWApi
 * 表名:Sex(01120103)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:07
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
 * 性别(Sex)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsSexEN } from "../../L0_Entity/SysPara/clsSexEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const sex_Controller = "SexApi";
 export const sex_ConstructorName = "sex";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_Sex:关键字
 * @returns 对象
 **/
export async function Sex_GetObjByid_SexAsync(strid_Sex: string): Promise<clsSexEN>  
{
const strThisFuncName = "GetObjByid_SexAsync";

if (IsNullOrEmpty(strid_Sex) == true)
{
  const strMsg = Format("参数:[strid_Sex]不能为空！(In GetObjByid_SexAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Sex.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_Sex]的长度:[{0}]不正确！", strid_Sex.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_Sex";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_Sex": strid_Sex,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSex = Sex_GetObjFromJsonObj(returnObj);
return objSex;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export function Sex_SortFun_Defa(a:clsSexEN , b:clsSexEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_Sex.localeCompare(b.id_Sex);
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
export function Sex_SortFun_Defa_2Fld(a:clsSexEN , b:clsSexEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.sexID == b.sexID) return a.sexDesc.localeCompare(b.sexDesc);
else return a.sexID.localeCompare(b.sexID);
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
export function Sex_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsSexEN.con_id_Sex:
return (a: clsSexEN, b: clsSexEN) => {
return a.id_Sex.localeCompare(b.id_Sex);
}
case clsSexEN.con_SexID:
return (a: clsSexEN, b: clsSexEN) => {
return a.sexID.localeCompare(b.sexID);
}
case clsSexEN.con_SexDesc:
return (a: clsSexEN, b: clsSexEN) => {
return a.sexDesc.localeCompare(b.sexDesc);
}
case clsSexEN.con_SexDesc_EN:
return (a: clsSexEN, b: clsSexEN) => {
return a.sexDesc_EN.localeCompare(b.sexDesc_EN);
}
case clsSexEN.con_ModifyDate:
return (a: clsSexEN, b: clsSexEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsSexEN.con_ModifyUserID:
return (a: clsSexEN, b: clsSexEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsSexEN.con_Memo:
return (a: clsSexEN, b: clsSexEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${ sex_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsSexEN.con_id_Sex:
return (a: clsSexEN, b: clsSexEN) => {
return b.id_Sex.localeCompare(a.id_Sex);
}
case clsSexEN.con_SexID:
return (a: clsSexEN, b: clsSexEN) => {
return b.sexID.localeCompare(a.sexID);
}
case clsSexEN.con_SexDesc:
return (a: clsSexEN, b: clsSexEN) => {
return b.sexDesc.localeCompare(a.sexDesc);
}
case clsSexEN.con_SexDesc_EN:
return (a: clsSexEN, b: clsSexEN) => {
return b.sexDesc_EN.localeCompare(a.sexDesc_EN);
}
case clsSexEN.con_ModifyDate:
return (a: clsSexEN, b: clsSexEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsSexEN.con_ModifyUserID:
return (a: clsSexEN, b: clsSexEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsSexEN.con_Memo:
return (a: clsSexEN, b: clsSexEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${ sex_ConstructorName}.${ strThisFuncName})`;
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
export async function Sex_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsSexEN.con_id_Sex:
return (obj: clsSexEN) => {
return obj.id_Sex === value;
}
case clsSexEN.con_SexID:
return (obj: clsSexEN) => {
return obj.sexID === value;
}
case clsSexEN.con_SexDesc:
return (obj: clsSexEN) => {
return obj.sexDesc === value;
}
case clsSexEN.con_SexDesc_EN:
return (obj: clsSexEN) => {
return obj.sexDesc_EN === value;
}
case clsSexEN.con_ModifyDate:
return (obj: clsSexEN) => {
return obj.modifyDate === value;
}
case clsSexEN.con_ModifyUserID:
return (obj: clsSexEN) => {
return obj.modifyUserID === value;
}
case clsSexEN.con_Memo:
return (obj: clsSexEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Sex]中不存在！(in ${ sex_ConstructorName}.${ strThisFuncName})`;
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
export async function Sex_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetFirstObjAsync(strWhereCond: string): Promise<clsSexEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objSex = Sex_GetObjFromJsonObj(returnObj);
return objSex;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetObjLstAsync(strWhereCond: string): Promise<Array<clsSexEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param arrid_Sex:关键字列表
 * @returns 对象列表
 **/
export async function Sex_GetObjLstByid_SexLstAsync(arrid_Sex: Array<string>): Promise<Array<clsSexEN>>  
{
const strThisFuncName = "GetObjLstByid_SexLstAsync";
const strAction = "GetObjLstByid_SexLst";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Sex);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsSexEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsSexEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsSexEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", sex_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Sex_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param strid_Sex:关键字
 * @returns 获取删除的结果
 **/
export async function Sex_DelRecordAsync(strid_Sex: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(sex_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_Sex);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strid_Sex, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param arrid_Sex:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function Sex_DelSexsAsync(arrid_Sex: Array<string>): Promise<number> 
{
const strThisFuncName = "DelSexsAsync";
const strAction = "DelSexs";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Sex);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_DelSexsByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelSexsByCondAsync";
const strAction = "DelSexsByCond";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Sex_AddNewRecordAsync(objSexEN: clsSexEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objSexEN.id_Sex === null || objSexEN.id_Sex === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objSexEN);
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Sex_AddNewRecordWithMaxIdAsync(objSexEN: clsSexEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function Sex_AddNewRecordWithReturnKeyAsync(objSexEN: clsSexEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function Sex_AddNewRecordWithReturnKey(objSexEN: clsSexEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objSexEN.id_Sex === null || objSexEN.id_Sex === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function Sex_UpdateRecordAsync(objSexEN: clsSexEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param objSexEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function Sex_UpdateWithConditionAsync(objSexEN: clsSexEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objSexEN.sf_UpdFldSetStr === undefined || objSexEN.sf_UpdFldSetStr === null || objSexEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSexEN.id_Sex);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(sex_Controller, strAction);
objSexEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objSexEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param strid_Sex:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function Sex_IsExist(strid_Sex: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_Sex": strid_Sex,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
 * @param strid_Sex:关键字
 * @returns 是否存在?存在返回True
 **/
export async function Sex_IsExistAsync(strid_Sex: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_Sex": strid_Sex }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export async function Sex_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(sex_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, sex_ConstructorName, strThisFuncName);
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
export function Sex_GetWebApiUrl(strController: string, strAction: string): string {
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
export function Sex_CheckPropertyNew(pobjSexEN: clsSexEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSexEN.id_Sex) == false && GetStrLen(pobjSexEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexID) == false && GetStrLen(pobjSexEN.sexID) > 4)
{
 throw new Error("(errid:Watl000059)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc) == false && GetStrLen(pobjSexEN.sexDesc) > 10)
{
 throw new Error("(errid:Watl000059)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc_EN) == false && GetStrLen(pobjSexEN.sexDesc_EN) > 10)
{
 throw new Error("(errid:Watl000059)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.modifyDate) == false && GetStrLen(pobjSexEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.modifyUserID) == false && GetStrLen(pobjSexEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.memo) == false && GetStrLen(pobjSexEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && tzDataType.isString(pobjSexEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && tzDataType.isString(pobjSexEN.sexID) === false)
{
 throw new Error("(errid:Watl000060)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && tzDataType.isString(pobjSexEN.sexDesc) === false)
{
 throw new Error("(errid:Watl000060)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && tzDataType.isString(pobjSexEN.sexDesc_EN) === false)
{
 throw new Error("(errid:Watl000060)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && tzDataType.isString(pobjSexEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && tzDataType.isString(pobjSexEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && tzDataType.isString(pobjSexEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjSexEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Sex_CheckProperty4Update (pobjSexEN: clsSexEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjSexEN.id_Sex) == false && GetStrLen(pobjSexEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.id_Sex)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexID) == false && GetStrLen(pobjSexEN.sexID) > 4)
{
 throw new Error("(errid:Watl000062)字段[性别ID(sexID)]的长度不能超过4(In 性别(Sex))!值:$(pobjSexEN.sexID)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc) == false && GetStrLen(pobjSexEN.sexDesc) > 10)
{
 throw new Error("(errid:Watl000062)字段[性别名称(sexDesc)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc_EN) == false && GetStrLen(pobjSexEN.sexDesc_EN) > 10)
{
 throw new Error("(errid:Watl000062)字段[SexDesc_EN(sexDesc_EN)]的长度不能超过10(In 性别(Sex))!值:$(pobjSexEN.sexDesc_EN)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.modifyDate) == false && GetStrLen(pobjSexEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 性别(Sex))!值:$(pobjSexEN.modifyDate)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.modifyUserID) == false && GetStrLen(pobjSexEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 性别(Sex))!值:$(pobjSexEN.modifyUserID)(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.memo) == false && GetStrLen(pobjSexEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 性别(Sex))!值:$(pobjSexEN.memo)(clsSexBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjSexEN.id_Sex) == false && undefined !== pobjSexEN.id_Sex && tzDataType.isString(pobjSexEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjSexEN.id_Sex)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexID) == false && undefined !== pobjSexEN.sexID && tzDataType.isString(pobjSexEN.sexID) === false)
{
 throw new Error("(errid:Watl000063)字段[性别ID(sexID)]的值:[$(pobjSexEN.sexID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc) == false && undefined !== pobjSexEN.sexDesc && tzDataType.isString(pobjSexEN.sexDesc) === false)
{
 throw new Error("(errid:Watl000063)字段[性别名称(sexDesc)]的值:[$(pobjSexEN.sexDesc)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.sexDesc_EN) == false && undefined !== pobjSexEN.sexDesc_EN && tzDataType.isString(pobjSexEN.sexDesc_EN) === false)
{
 throw new Error("(errid:Watl000063)字段[SexDesc_EN(sexDesc_EN)]的值:[$(pobjSexEN.sexDesc_EN)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.modifyDate) == false && undefined !== pobjSexEN.modifyDate && tzDataType.isString(pobjSexEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjSexEN.modifyDate)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.modifyUserID) == false && undefined !== pobjSexEN.modifyUserID && tzDataType.isString(pobjSexEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjSexEN.modifyUserID)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjSexEN.memo) == false && undefined !== pobjSexEN.memo && tzDataType.isString(pobjSexEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSexEN.memo)], 非法，应该为字符型(In 性别(Sex))!(clsSexBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjSexEN.id_Sex) === true )
{
 throw new Error("(errid:Watl000064)字段[性别流水号]不能为空(In 性别)!(clsSexBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjSexEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Sex_GetJSONStrByObj (pobjSexEN: clsSexEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjSexEN.sf_UpdFldSetStr = pobjSexEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjSexEN);
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
export function Sex_GetObjLstByJSONStr (strJSON: string): Array<clsSexEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrSexObjLst = new Array<clsSexEN>();
if (strJSON === "")
{
return arrSexObjLst;
}
try
{
arrSexObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrSexObjLst;
}
return arrSexObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrSexObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function Sex_GetObjLstByJSONObjLst (arrSexObjLstS: Array<clsSexEN>): Array<clsSexEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrSexObjLst = new Array<clsSexEN>();
for (const objInFor of arrSexObjLstS) {
const obj1 = Sex_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrSexObjLst.push(obj1);
}
return arrSexObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Sex_GetObjByJSONStr (strJSON: string): clsSexEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjSexEN = new clsSexEN();
if (strJSON === "")
{
return pobjSexEN;
}
try
{
pobjSexEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjSexEN;
}
return pobjSexEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function Sex_GetCombineCondition(objSex_Cond: clsSexEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_id_Sex) == true)
{
const strComparisonOp_id_Sex:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_id_Sex];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_id_Sex, objSex_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_SexID) == true)
{
const strComparisonOp_SexID:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_SexID];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_SexID, objSex_Cond.sexID, strComparisonOp_SexID);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_SexDesc) == true)
{
const strComparisonOp_SexDesc:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_SexDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_SexDesc, objSex_Cond.sexDesc, strComparisonOp_SexDesc);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_SexDesc_EN) == true)
{
const strComparisonOp_SexDesc_EN:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_SexDesc_EN];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_SexDesc_EN, objSex_Cond.sexDesc_EN, strComparisonOp_SexDesc_EN);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_ModifyDate, objSex_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_ModifyUserID, objSex_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objSex_Cond.dicFldComparisonOp, clsSexEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objSex_Cond.dicFldComparisonOp[clsSexEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsSexEN.con_Memo, objSex_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objSexENS:源对象
 * @param objSexENT:目标对象
*/
export function Sex_CopyObjTo(objSexENS: clsSexEN , objSexENT: clsSexEN ): void 
{
objSexENT.id_Sex = objSexENS.id_Sex; //性别流水号
objSexENT.sexID = objSexENS.sexID; //性别ID
objSexENT.sexDesc = objSexENS.sexDesc; //性别名称
objSexENT.sexDesc_EN = objSexENS.sexDesc_EN; //SexDesc_EN
objSexENT.modifyDate = objSexENS.modifyDate; //修改日期
objSexENT.modifyUserID = objSexENS.modifyUserID; //修改人
objSexENT.memo = objSexENS.memo; //备注
objSexENT.sf_UpdFldSetStr = objSexENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objSexENS:源对象
 * @param objSexENT:目标对象
*/
export function Sex_GetObjFromJsonObj(objSexENS: clsSexEN): clsSexEN 
{
 const objSexENT: clsSexEN = new clsSexEN();
ObjectAssign(objSexENT, objSexENS);
 return objSexENT;
}