
 /**
 * 类名:clsvcc_CourseTypeWApi
 * 表名:vcc_CourseType(01120059)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:24
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v课程类型(vcc_CourseType)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvcc_CourseTypeEN } from "../../L0_Entity/CourseLearning/clsvcc_CourseTypeEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vcc_CourseType_Controller = "vcc_CourseTypeApi";
 export const vcc_CourseType_ConstructorName = "vcc_CourseType";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strCourseTypeID:关键字
 * @returns 对象
 **/
export async function vcc_CourseType_GetObjByCourseTypeIDAsync(strCourseTypeID: string): Promise<clsvcc_CourseTypeEN>  
{
const strThisFuncName = "GetObjByCourseTypeIDAsync";

if (IsNullOrEmpty(strCourseTypeID) == true)
{
  const strMsg = Format("参数:[strCourseTypeID]不能为空！(In GetObjByCourseTypeIDAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strCourseTypeID.length != 4)
{
const strMsg = Format("缓存分类变量:[strCourseTypeID]的长度:[{0}]不正确！", strCourseTypeID.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByCourseTypeID";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strCourseTypeID": strCourseTypeID,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseType = vcc_CourseType_GetObjFromJsonObj(returnObj);
return objvcc_CourseType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export function vcc_CourseType_SortFun_Defa(a:clsvcc_CourseTypeEN , b:clsvcc_CourseTypeEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.courseTypeID.localeCompare(b.courseTypeID);
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
export function vcc_CourseType_SortFun_Defa_2Fld(a:clsvcc_CourseTypeEN , b:clsvcc_CourseTypeEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.courseTypeName == b.courseTypeName) return a.id_School.localeCompare(b.id_School);
else return a.courseTypeName.localeCompare(b.courseTypeName);
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
export function vcc_CourseType_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvcc_CourseTypeEN.con_CourseTypeID:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.courseTypeID.localeCompare(b.courseTypeID);
}
case clsvcc_CourseTypeEN.con_CourseTypeName:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.courseTypeName.localeCompare(b.courseTypeName);
}
case clsvcc_CourseTypeEN.con_id_School:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.id_School.localeCompare(b.id_School);
}
case clsvcc_CourseTypeEN.con_SchoolId:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.schoolId.localeCompare(b.schoolId);
}
case clsvcc_CourseTypeEN.con_SchoolName:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.schoolName.localeCompare(b.schoolName);
}
case clsvcc_CourseTypeEN.con_IsUse:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
if (a.isUse == true) return 1;
else return -1
}
case clsvcc_CourseTypeEN.con_UpdDate:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvcc_CourseTypeEN.con_UpdUserId:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.updUserId.localeCompare(b.updUserId);
}
case clsvcc_CourseTypeEN.con_Memo:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseType]中不存在！(in ${ vcc_CourseType_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvcc_CourseTypeEN.con_CourseTypeID:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.courseTypeID.localeCompare(a.courseTypeID);
}
case clsvcc_CourseTypeEN.con_CourseTypeName:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.courseTypeName.localeCompare(a.courseTypeName);
}
case clsvcc_CourseTypeEN.con_id_School:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.id_School.localeCompare(a.id_School);
}
case clsvcc_CourseTypeEN.con_SchoolId:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.schoolId.localeCompare(a.schoolId);
}
case clsvcc_CourseTypeEN.con_SchoolName:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.schoolName.localeCompare(a.schoolName);
}
case clsvcc_CourseTypeEN.con_IsUse:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
if (b.isUse == true) return 1;
else return -1
}
case clsvcc_CourseTypeEN.con_UpdDate:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvcc_CourseTypeEN.con_UpdUserId:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.updUserId.localeCompare(a.updUserId);
}
case clsvcc_CourseTypeEN.con_Memo:
return (a: clsvcc_CourseTypeEN, b: clsvcc_CourseTypeEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseType]中不存在！(in ${ vcc_CourseType_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseType_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvcc_CourseTypeEN.con_CourseTypeID:
return (obj: clsvcc_CourseTypeEN) => {
return obj.courseTypeID === value;
}
case clsvcc_CourseTypeEN.con_CourseTypeName:
return (obj: clsvcc_CourseTypeEN) => {
return obj.courseTypeName === value;
}
case clsvcc_CourseTypeEN.con_id_School:
return (obj: clsvcc_CourseTypeEN) => {
return obj.id_School === value;
}
case clsvcc_CourseTypeEN.con_SchoolId:
return (obj: clsvcc_CourseTypeEN) => {
return obj.schoolId === value;
}
case clsvcc_CourseTypeEN.con_SchoolName:
return (obj: clsvcc_CourseTypeEN) => {
return obj.schoolName === value;
}
case clsvcc_CourseTypeEN.con_IsUse:
return (obj: clsvcc_CourseTypeEN) => {
return obj.isUse === value;
}
case clsvcc_CourseTypeEN.con_UpdDate:
return (obj: clsvcc_CourseTypeEN) => {
return obj.updDate === value;
}
case clsvcc_CourseTypeEN.con_UpdUserId:
return (obj: clsvcc_CourseTypeEN) => {
return obj.updUserId === value;
}
case clsvcc_CourseTypeEN.con_Memo:
return (obj: clsvcc_CourseTypeEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseType]中不存在！(in ${ vcc_CourseType_ConstructorName}.${ strThisFuncName})`;
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
export async function vcc_CourseType_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetFirstObjAsync(strWhereCond: string): Promise<clsvcc_CourseTypeEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvcc_CourseType = vcc_CourseType_GetObjFromJsonObj(returnObj);
return objvcc_CourseType;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvcc_CourseTypeEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
 * @param arrCourseTypeID:关键字列表
 * @returns 对象列表
 **/
export async function vcc_CourseType_GetObjLstByCourseTypeIDLstAsync(arrCourseTypeID: Array<string>): Promise<Array<clsvcc_CourseTypeEN>>  
{
const strThisFuncName = "GetObjLstByCourseTypeIDLstAsync";
const strAction = "GetObjLstByCourseTypeIDLst";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrCourseTypeID);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvcc_CourseTypeEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvcc_CourseTypeEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvcc_CourseTypeEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vcc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
 * @param strCourseTypeID:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vcc_CourseType_IsExist(strCourseTypeID: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"CourseTypeID": strCourseTypeID,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
 * @param strCourseTypeID:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vcc_CourseType_IsExistAsync(strCourseTypeID: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strCourseTypeID": strCourseTypeID }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export async function vcc_CourseType_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vcc_CourseType_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vcc_CourseType_ConstructorName, strThisFuncName);
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
export function vcc_CourseType_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vcc_CourseType_GetJSONStrByObj (pobjvcc_CourseTypeEN: clsvcc_CourseTypeEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvcc_CourseTypeEN);
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
export function vcc_CourseType_GetObjLstByJSONStr (strJSON: string): Array<clsvcc_CourseTypeEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvcc_CourseTypeObjLst = new Array<clsvcc_CourseTypeEN>();
if (strJSON === "")
{
return arrvcc_CourseTypeObjLst;
}
try
{
arrvcc_CourseTypeObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvcc_CourseTypeObjLst;
}
return arrvcc_CourseTypeObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvcc_CourseTypeObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vcc_CourseType_GetObjLstByJSONObjLst (arrvcc_CourseTypeObjLstS: Array<clsvcc_CourseTypeEN>): Array<clsvcc_CourseTypeEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvcc_CourseTypeObjLst = new Array<clsvcc_CourseTypeEN>();
for (const objInFor of arrvcc_CourseTypeObjLstS) {
const obj1 = vcc_CourseType_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvcc_CourseTypeObjLst.push(obj1);
}
return arrvcc_CourseTypeObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vcc_CourseType_GetObjByJSONStr (strJSON: string): clsvcc_CourseTypeEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
if (strJSON === "")
{
return pobjvcc_CourseTypeEN;
}
try
{
pobjvcc_CourseTypeEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvcc_CourseTypeEN;
}
return pobjvcc_CourseTypeEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vcc_CourseType_GetCombineCondition(objvcc_CourseType_Cond: clsvcc_CourseTypeEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_CourseTypeID) == true)
{
const strComparisonOp_CourseTypeID:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_CourseTypeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_CourseTypeID, objvcc_CourseType_Cond.courseTypeID, strComparisonOp_CourseTypeID);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_CourseTypeName) == true)
{
const strComparisonOp_CourseTypeName:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_CourseTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_CourseTypeName, objvcc_CourseType_Cond.courseTypeName, strComparisonOp_CourseTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_id_School, objvcc_CourseType_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_SchoolId) == true)
{
const strComparisonOp_SchoolId:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_SchoolId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_SchoolId, objvcc_CourseType_Cond.schoolId, strComparisonOp_SchoolId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_SchoolName) == true)
{
const strComparisonOp_SchoolName:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_SchoolName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_SchoolName, objvcc_CourseType_Cond.schoolName, strComparisonOp_SchoolName);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_IsUse) == true)
{
if (objvcc_CourseType_Cond.isUse == true)
{
strWhereCond += Format(" And {0} = '1'", clsvcc_CourseTypeEN.con_IsUse);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvcc_CourseTypeEN.con_IsUse);
}
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_UpdDate, objvcc_CourseType_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_UpdUserId) == true)
{
const strComparisonOp_UpdUserId:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_UpdUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_UpdUserId, objvcc_CourseType_Cond.updUserId, strComparisonOp_UpdUserId);
}
if (Object.prototype.hasOwnProperty.call(objvcc_CourseType_Cond.dicFldComparisonOp, clsvcc_CourseTypeEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvcc_CourseType_Cond.dicFldComparisonOp[clsvcc_CourseTypeEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvcc_CourseTypeEN.con_Memo, objvcc_CourseType_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvcc_CourseTypeENS:源对象
 * @param objvcc_CourseTypeENT:目标对象
*/
export function vcc_CourseType_CopyObjTo(objvcc_CourseTypeENS: clsvcc_CourseTypeEN , objvcc_CourseTypeENT: clsvcc_CourseTypeEN ): void 
{
objvcc_CourseTypeENT.courseTypeID = objvcc_CourseTypeENS.courseTypeID; //课程类型ID
objvcc_CourseTypeENT.courseTypeName = objvcc_CourseTypeENS.courseTypeName; //课程类型名称
objvcc_CourseTypeENT.id_School = objvcc_CourseTypeENS.id_School; //学校流水号
objvcc_CourseTypeENT.schoolId = objvcc_CourseTypeENS.schoolId; //学校编号
objvcc_CourseTypeENT.schoolName = objvcc_CourseTypeENS.schoolName; //学校名称
objvcc_CourseTypeENT.isUse = objvcc_CourseTypeENS.isUse; //是否使用
objvcc_CourseTypeENT.updDate = objvcc_CourseTypeENS.updDate; //修改日期
objvcc_CourseTypeENT.updUserId = objvcc_CourseTypeENS.updUserId; //修改用户Id
objvcc_CourseTypeENT.memo = objvcc_CourseTypeENS.memo; //备注
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvcc_CourseTypeENS:源对象
 * @param objvcc_CourseTypeENT:目标对象
*/
export function vcc_CourseType_GetObjFromJsonObj(objvcc_CourseTypeENS: clsvcc_CourseTypeEN): clsvcc_CourseTypeEN 
{
 const objvcc_CourseTypeENT: clsvcc_CourseTypeEN = new clsvcc_CourseTypeEN();
ObjectAssign(objvcc_CourseTypeENT, objvcc_CourseTypeENS);
 return objvcc_CourseTypeENT;
}