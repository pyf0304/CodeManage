
 /**
 * 类名:clsvXzClgWApi
 * 表名:vXzClg(01120139)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:26
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v学院(vXzClg)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvXzClgEN } from "../../L0_Entity/BaseInfo/clsvXzClgEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vXzClg_Controller = "vXzClgApi";
 export const vXzClg_ConstructorName = "vXzClg";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_XzCollege:关键字
 * @returns 对象
 **/
export async function vXzClg_GetObjByid_XzCollegeAsync(strid_XzCollege: string): Promise<clsvXzClgEN>  
{
const strThisFuncName = "GetObjByid_XzCollegeAsync";

if (IsNullOrEmpty(strid_XzCollege) == true)
{
  const strMsg = Format("参数:[strid_XzCollege]不能为空！(In GetObjByid_XzCollegeAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_XzCollege.length != 4)
{
const strMsg = Format("缓存分类变量:[strid_XzCollege]的长度:[{0}]不正确！", strid_XzCollege.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_XzCollege";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_XzCollege": strid_XzCollege,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzClg = vXzClg_GetObjFromJsonObj(returnObj);
return objvXzClg;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export function vXzClg_SortFun_Defa(a:clsvXzClgEN , b:clsvXzClgEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_XzCollege.localeCompare(b.id_XzCollege);
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
export function vXzClg_SortFun_Defa_2Fld(a:clsvXzClgEN , b:clsvXzClgEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.collegeID == b.collegeID) return a.collegeName.localeCompare(b.collegeName);
else return a.collegeID.localeCompare(b.collegeID);
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
export function vXzClg_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvXzClgEN.con_id_XzCollege:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvXzClgEN.con_CollegeID:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvXzClgEN.con_CollegeName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvXzClgEN.con_CollegeIdInGP:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.collegeIdInGP.localeCompare(b.collegeIdInGP);
}
case clsvXzClgEN.con_ClgEnglishName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.clgEnglishName.localeCompare(b.clgEnglishName);
}
case clsvXzClgEN.con_CollegeNameA:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvXzClgEN.con_PhoneNumber:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsvXzClgEN.con_WebSite:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.webSite.localeCompare(b.webSite);
}
case clsvXzClgEN.con_id_School:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.id_School.localeCompare(b.id_School);
}
case clsvXzClgEN.con_SchoolId:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.schoolId.localeCompare(b.schoolId);
}
case clsvXzClgEN.con_SchoolName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.schoolName.localeCompare(b.schoolName);
}
case clsvXzClgEN.con_SchoolNameA:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.schoolNameA.localeCompare(b.schoolNameA);
}
case clsvXzClgEN.con_id_Uni:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.id_Uni.localeCompare(b.id_Uni);
}
case clsvXzClgEN.con_IsVisible:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
if (a.isVisible == true) return 1;
else return -1
}
case clsvXzClgEN.con_OrderNum:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.orderNum-b.orderNum;
}
case clsvXzClgEN.con_ModifyDate:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvXzClgEN.con_ModifyUserID:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvXzClgEN.con_Memo:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvXzClgEN.con_MajorNum:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return a.majorNum-b.majorNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${ vXzClg_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvXzClgEN.con_id_XzCollege:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvXzClgEN.con_CollegeID:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvXzClgEN.con_CollegeName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvXzClgEN.con_CollegeIdInGP:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.collegeIdInGP.localeCompare(a.collegeIdInGP);
}
case clsvXzClgEN.con_ClgEnglishName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.clgEnglishName.localeCompare(a.clgEnglishName);
}
case clsvXzClgEN.con_CollegeNameA:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvXzClgEN.con_PhoneNumber:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsvXzClgEN.con_WebSite:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.webSite.localeCompare(a.webSite);
}
case clsvXzClgEN.con_id_School:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.id_School.localeCompare(a.id_School);
}
case clsvXzClgEN.con_SchoolId:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.schoolId.localeCompare(a.schoolId);
}
case clsvXzClgEN.con_SchoolName:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.schoolName.localeCompare(a.schoolName);
}
case clsvXzClgEN.con_SchoolNameA:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.schoolNameA.localeCompare(a.schoolNameA);
}
case clsvXzClgEN.con_id_Uni:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.id_Uni.localeCompare(a.id_Uni);
}
case clsvXzClgEN.con_IsVisible:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
if (b.isVisible == true) return 1;
else return -1
}
case clsvXzClgEN.con_OrderNum:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.orderNum-a.orderNum;
}
case clsvXzClgEN.con_ModifyDate:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvXzClgEN.con_ModifyUserID:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvXzClgEN.con_Memo:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvXzClgEN.con_MajorNum:
return (a: clsvXzClgEN, b: clsvXzClgEN) => {
return b.majorNum-a.majorNum;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${ vXzClg_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzClg_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvXzClgEN.con_id_XzCollege:
return (obj: clsvXzClgEN) => {
return obj.id_XzCollege === value;
}
case clsvXzClgEN.con_CollegeID:
return (obj: clsvXzClgEN) => {
return obj.collegeID === value;
}
case clsvXzClgEN.con_CollegeName:
return (obj: clsvXzClgEN) => {
return obj.collegeName === value;
}
case clsvXzClgEN.con_CollegeIdInGP:
return (obj: clsvXzClgEN) => {
return obj.collegeIdInGP === value;
}
case clsvXzClgEN.con_ClgEnglishName:
return (obj: clsvXzClgEN) => {
return obj.clgEnglishName === value;
}
case clsvXzClgEN.con_CollegeNameA:
return (obj: clsvXzClgEN) => {
return obj.collegeNameA === value;
}
case clsvXzClgEN.con_PhoneNumber:
return (obj: clsvXzClgEN) => {
return obj.phoneNumber === value;
}
case clsvXzClgEN.con_WebSite:
return (obj: clsvXzClgEN) => {
return obj.webSite === value;
}
case clsvXzClgEN.con_id_School:
return (obj: clsvXzClgEN) => {
return obj.id_School === value;
}
case clsvXzClgEN.con_SchoolId:
return (obj: clsvXzClgEN) => {
return obj.schoolId === value;
}
case clsvXzClgEN.con_SchoolName:
return (obj: clsvXzClgEN) => {
return obj.schoolName === value;
}
case clsvXzClgEN.con_SchoolNameA:
return (obj: clsvXzClgEN) => {
return obj.schoolNameA === value;
}
case clsvXzClgEN.con_id_Uni:
return (obj: clsvXzClgEN) => {
return obj.id_Uni === value;
}
case clsvXzClgEN.con_IsVisible:
return (obj: clsvXzClgEN) => {
return obj.isVisible === value;
}
case clsvXzClgEN.con_OrderNum:
return (obj: clsvXzClgEN) => {
return obj.orderNum === value;
}
case clsvXzClgEN.con_ModifyDate:
return (obj: clsvXzClgEN) => {
return obj.modifyDate === value;
}
case clsvXzClgEN.con_ModifyUserID:
return (obj: clsvXzClgEN) => {
return obj.modifyUserID === value;
}
case clsvXzClgEN.con_Memo:
return (obj: clsvXzClgEN) => {
return obj.memo === value;
}
case clsvXzClgEN.con_MajorNum:
return (obj: clsvXzClgEN) => {
return obj.majorNum === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vXzClg]中不存在！(in ${ vXzClg_ConstructorName}.${ strThisFuncName})`;
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
export async function vXzClg_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetFirstObjAsync(strWhereCond: string): Promise<clsvXzClgEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvXzClg = vXzClg_GetObjFromJsonObj(returnObj);
return objvXzClg;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvXzClgEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
 * @param arrid_XzCollege:关键字列表
 * @returns 对象列表
 **/
export async function vXzClg_GetObjLstByid_XzCollegeLstAsync(arrid_XzCollege: Array<string>): Promise<Array<clsvXzClgEN>>  
{
const strThisFuncName = "GetObjLstByid_XzCollegeLstAsync";
const strAction = "GetObjLstByid_XzCollegeLst";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_XzCollege);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvXzClgEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvXzClgEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvXzClgEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vXzClg_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vXzClg_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
 * @param strid_XzCollege:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function vXzClg_IsExist(strid_XzCollege: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_XzCollege": strid_XzCollege,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
 * @param strid_XzCollege:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vXzClg_IsExistAsync(strid_XzCollege: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_XzCollege": strid_XzCollege }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export async function vXzClg_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vXzClg_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vXzClg_ConstructorName, strThisFuncName);
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
export function vXzClg_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vXzClg_GetJSONStrByObj (pobjvXzClgEN: clsvXzClgEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvXzClgEN);
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
export function vXzClg_GetObjLstByJSONStr (strJSON: string): Array<clsvXzClgEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvXzClgObjLst = new Array<clsvXzClgEN>();
if (strJSON === "")
{
return arrvXzClgObjLst;
}
try
{
arrvXzClgObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvXzClgObjLst;
}
return arrvXzClgObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvXzClgObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vXzClg_GetObjLstByJSONObjLst (arrvXzClgObjLstS: Array<clsvXzClgEN>): Array<clsvXzClgEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvXzClgObjLst = new Array<clsvXzClgEN>();
for (const objInFor of arrvXzClgObjLstS) {
const obj1 = vXzClg_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvXzClgObjLst.push(obj1);
}
return arrvXzClgObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vXzClg_GetObjByJSONStr (strJSON: string): clsvXzClgEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvXzClgEN = new clsvXzClgEN();
if (strJSON === "")
{
return pobjvXzClgEN;
}
try
{
pobjvXzClgEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvXzClgEN;
}
return pobjvXzClgEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vXzClg_GetCombineCondition(objvXzClg_Cond: clsvXzClgEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_id_XzCollege, objvXzClg_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_CollegeID, objvXzClg_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_CollegeName, objvXzClg_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_CollegeIdInGP) == true)
{
const strComparisonOp_CollegeIdInGP:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_CollegeIdInGP];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_CollegeIdInGP, objvXzClg_Cond.collegeIdInGP, strComparisonOp_CollegeIdInGP);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_ClgEnglishName) == true)
{
const strComparisonOp_ClgEnglishName:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_ClgEnglishName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_ClgEnglishName, objvXzClg_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_CollegeNameA, objvXzClg_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_PhoneNumber, objvXzClg_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_WebSite) == true)
{
const strComparisonOp_WebSite:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_WebSite];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_WebSite, objvXzClg_Cond.webSite, strComparisonOp_WebSite);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_id_School) == true)
{
const strComparisonOp_id_School:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_id_School];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_id_School, objvXzClg_Cond.id_School, strComparisonOp_id_School);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_SchoolId) == true)
{
const strComparisonOp_SchoolId:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_SchoolId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_SchoolId, objvXzClg_Cond.schoolId, strComparisonOp_SchoolId);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_SchoolName) == true)
{
const strComparisonOp_SchoolName:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_SchoolName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_SchoolName, objvXzClg_Cond.schoolName, strComparisonOp_SchoolName);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_SchoolNameA) == true)
{
const strComparisonOp_SchoolNameA:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_SchoolNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_SchoolNameA, objvXzClg_Cond.schoolNameA, strComparisonOp_SchoolNameA);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_id_Uni) == true)
{
const strComparisonOp_id_Uni:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_id_Uni];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_id_Uni, objvXzClg_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_IsVisible) == true)
{
if (objvXzClg_Cond.isVisible == true)
{
strWhereCond += Format(" And {0} = '1'", clsvXzClgEN.con_IsVisible);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvXzClgEN.con_IsVisible);
}
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_OrderNum) == true)
{
const strComparisonOp_OrderNum:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_OrderNum];
strWhereCond += Format(" And {0} {2} {1}", clsvXzClgEN.con_OrderNum, objvXzClg_Cond.orderNum, strComparisonOp_OrderNum);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_ModifyDate, objvXzClg_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_ModifyUserID, objvXzClg_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvXzClgEN.con_Memo, objvXzClg_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvXzClg_Cond.dicFldComparisonOp, clsvXzClgEN.con_MajorNum) == true)
{
const strComparisonOp_MajorNum:string = objvXzClg_Cond.dicFldComparisonOp[clsvXzClgEN.con_MajorNum];
strWhereCond += Format(" And {0} {2} {1}", clsvXzClgEN.con_MajorNum, objvXzClg_Cond.majorNum, strComparisonOp_MajorNum);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvXzClgENS:源对象
 * @param objvXzClgENT:目标对象
*/
export function vXzClg_CopyObjTo(objvXzClgENS: clsvXzClgEN , objvXzClgENT: clsvXzClgEN ): void 
{
objvXzClgENT.id_XzCollege = objvXzClgENS.id_XzCollege; //学院流水号
objvXzClgENT.collegeID = objvXzClgENS.collegeID; //学院ID
objvXzClgENT.collegeName = objvXzClgENS.collegeName; //学院名称
objvXzClgENT.collegeIdInGP = objvXzClgENS.collegeIdInGP; //CollegeIdInGP
objvXzClgENT.clgEnglishName = objvXzClgENS.clgEnglishName; //ClgEnglishName
objvXzClgENT.collegeNameA = objvXzClgENS.collegeNameA; //学院名称简写
objvXzClgENT.phoneNumber = objvXzClgENS.phoneNumber; //PhoneNumber
objvXzClgENT.webSite = objvXzClgENS.webSite; //个人主页
objvXzClgENT.id_School = objvXzClgENS.id_School; //学校流水号
objvXzClgENT.schoolId = objvXzClgENS.schoolId; //学校编号
objvXzClgENT.schoolName = objvXzClgENS.schoolName; //学校名称
objvXzClgENT.schoolNameA = objvXzClgENS.schoolNameA; //学校简称
objvXzClgENT.id_Uni = objvXzClgENS.id_Uni; //id_Uni
objvXzClgENT.isVisible = objvXzClgENS.isVisible; //是否显示
objvXzClgENT.orderNum = objvXzClgENS.orderNum; //序号
objvXzClgENT.modifyDate = objvXzClgENS.modifyDate; //修改日期
objvXzClgENT.modifyUserID = objvXzClgENS.modifyUserID; //修改人
objvXzClgENT.memo = objvXzClgENS.memo; //备注
objvXzClgENT.majorNum = objvXzClgENS.majorNum; //MajorNum
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvXzClgENS:源对象
 * @param objvXzClgENT:目标对象
*/
export function vXzClg_GetObjFromJsonObj(objvXzClgENS: clsvXzClgEN): clsvXzClgEN 
{
 const objvXzClgENT: clsvXzClgEN = new clsvXzClgEN();
ObjectAssign(objvXzClgENT, objvXzClgENS);
 return objvXzClgENT;
}