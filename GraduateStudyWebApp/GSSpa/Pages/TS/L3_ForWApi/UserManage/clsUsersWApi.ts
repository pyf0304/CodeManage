
 /**
 * 类名:clsUsersWApi
 * 表名:Users(01120034)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:58
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * 用户(Users)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsUsersEN } from "../../L0_Entity/UserManage/clsUsersEN.js";
import { vUsers_ReFreshThisCache } from "../../L3_ForWApi/UserManage/clsvUsersWApi.js";
import { vUsersSim_ReFreshThisCache } from "../../L3_ForWApi/UserManage/clsvUsersSimWApi.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const users_Controller = "UsersApi";
 export const users_ConstructorName = "users";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strUserId:关键字
 * @returns 对象
 **/
export async function Users_GetObjByUserIdAsync(strUserId: string): Promise<clsUsersEN>  
{
const strThisFuncName = "GetObjByUserIdAsync";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByUserId";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strUserId": strUserId,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objUsers = Users_GetObjFromJsonObj(returnObj);
return objUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function Users_GetObjByUserId_Cache(strUserId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
try
{
const arrUsers_Sel: Array <clsUsersEN> = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
let objUsers: clsUsersEN;
if (arrUsers_Sel.length > 0)
{
objUsers = arrUsers_Sel[0];
return objUsers;
}
else
{
if (bolTryAsyncOnce == true)
{
objUsers = await Users_GetObjByUserIdAsync(strUserId);
if (objUsers != null)
{
Users_ReFreshThisCache();
return objUsers;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, users_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function Users_GetObjByUserId_localStorage(strUserId: string) {
const strThisFuncName = "GetObjByUserId_localStorage";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsUsersEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objUsers_Cache: clsUsersEN = JSON.parse(strTempObj);
return objUsers_Cache;
}
try
{
const objUsers = await Users_GetObjByUserIdAsync(strUserId);
if (objUsers != null)
{
localStorage.setItem(strKey, JSON.stringify(objUsers));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objUsers;
}
return objUsers;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, users_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objUsers:所给的对象
 * @returns 对象
*/
export async function Users_UpdateObjInLst_Cache(objUsers: clsUsersEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
const obj = arrUsersObjLst_Cache.find(x => 
x.userId == objUsers.userId);
if (obj != null)
{
objUsers.userId = obj.userId;
ObjectAssign( obj, objUsers);
}
else
{
arrUsersObjLst_Cache.push(objUsers);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, users_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function Users_GetNameByUserId_Cache(strUserId: string) {
const strThisFuncName = "GetNameByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetNameByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strUserId.length != 20)
{
const strMsg = Format("缓存分类变量:[strUserId]的长度:[{0}]不正确！", strUserId.length);
console.error(strMsg);
throw (strMsg);
}
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
if (arrUsersObjLst_Cache == null) return "";
try
{
const arrUsers_Sel: Array <clsUsersEN> = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
let objUsers: clsUsersEN;
if (arrUsers_Sel.length > 0)
{
objUsers = arrUsers_Sel[0];
return objUsers.userName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strUserId);
console.error(strMsg);
alert(strMsg);
}
return "";
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function Users_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsUsersEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsUsersEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsUsersEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strUserId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objUsers = await Users_GetObjByUserId_Cache(strUserId );
if (objUsers == null) return "";
return objUsers.GetFldValue(strOutFldName).toString();
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
export function Users_SortFun_Defa(a:clsUsersEN , b:clsUsersEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.userId.localeCompare(b.userId);
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
export function Users_SortFun_Defa_2Fld(a:clsUsersEN , b:clsUsersEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userName == b.userName) return a.departmentId.localeCompare(b.departmentId);
else return a.userName.localeCompare(b.userName);
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
export function Users_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsUsersEN.con_UserId:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.userId.localeCompare(b.userId);
}
case clsUsersEN.con_UserName:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.userName.localeCompare(b.userName);
}
case clsUsersEN.con_DepartmentId:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.departmentId.localeCompare(b.departmentId);
}
case clsUsersEN.con_UserStateId:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.userStateId.localeCompare(b.userStateId);
}
case clsUsersEN.con_Password:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.password.localeCompare(b.password);
}
case clsUsersEN.con_IsGpUser:
return (a: clsUsersEN, b: clsUsersEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsUsersEN.con_SchoolID1:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.schoolID1.localeCompare(b.schoolID1);
}
case clsUsersEN.con_BeginYearMonth:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.beginYearMonth.localeCompare(b.beginYearMonth);
}
case clsUsersEN.con_EndYearMonth:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.endYearMonth.localeCompare(b.endYearMonth);
}
case clsUsersEN.con_id_GradeBase:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsUsersEN.con_id_XzCollege:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsUsersEN.con_id_XzMajor:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsUsersEN.con_IsLeaved:
return (a: clsUsersEN, b: clsUsersEN) => {
if (a.isLeaved == true) return 1;
else return -1
}
case clsUsersEN.con_StuIdTeacherId:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.stuIdTeacherId.localeCompare(b.stuIdTeacherId);
}
case clsUsersEN.con_Email:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.email.localeCompare(b.email);
}
case clsUsersEN.con_PhoneNumber:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsUsersEN.con_AvatarsPicture:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.avatarsPicture.localeCompare(b.avatarsPicture);
}
case clsUsersEN.con_IdentityID:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.identityID.localeCompare(b.identityID);
}
case clsUsersEN.con_AuditDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.auditDate.localeCompare(b.auditDate);
}
case clsUsersEN.con_AuditUser:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.auditUser.localeCompare(b.auditUser);
}
case clsUsersEN.con_IsAudit:
return (a: clsUsersEN, b: clsUsersEN) => {
if (a.isAudit == true) return 1;
else return -1
}
case clsUsersEN.con_IsRegister:
return (a: clsUsersEN, b: clsUsersEN) => {
if (a.isRegister == true) return 1;
else return -1
}
case clsUsersEN.con_RegisterDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.registerDate.localeCompare(b.registerDate);
}
case clsUsersEN.con_MobilePhone:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.mobilePhone.localeCompare(b.mobilePhone);
}
case clsUsersEN.con_OpenId:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.openId.localeCompare(b.openId);
}
case clsUsersEN.con_UpdDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsUsersEN.con_UpdUser:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsUsersEN.con_Memo:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.memo.localeCompare(b.memo);
}
case clsUsersEN.con_HeadPic:
return (a: clsUsersEN, b: clsUsersEN) => {
return a.headPic.localeCompare(b.headPic);
}
case clsUsersEN.con_IsGSuser:
return (a: clsUsersEN, b: clsUsersEN) => {
if (a.isGSuser == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${ users_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsUsersEN.con_UserId:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.userId.localeCompare(a.userId);
}
case clsUsersEN.con_UserName:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.userName.localeCompare(a.userName);
}
case clsUsersEN.con_DepartmentId:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.departmentId.localeCompare(a.departmentId);
}
case clsUsersEN.con_UserStateId:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.userStateId.localeCompare(a.userStateId);
}
case clsUsersEN.con_Password:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.password.localeCompare(a.password);
}
case clsUsersEN.con_IsGpUser:
return (a: clsUsersEN, b: clsUsersEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsUsersEN.con_SchoolID1:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.schoolID1.localeCompare(a.schoolID1);
}
case clsUsersEN.con_BeginYearMonth:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.beginYearMonth.localeCompare(a.beginYearMonth);
}
case clsUsersEN.con_EndYearMonth:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.endYearMonth.localeCompare(a.endYearMonth);
}
case clsUsersEN.con_id_GradeBase:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsUsersEN.con_id_XzCollege:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsUsersEN.con_id_XzMajor:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsUsersEN.con_IsLeaved:
return (a: clsUsersEN, b: clsUsersEN) => {
if (b.isLeaved == true) return 1;
else return -1
}
case clsUsersEN.con_StuIdTeacherId:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.stuIdTeacherId.localeCompare(a.stuIdTeacherId);
}
case clsUsersEN.con_Email:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.email.localeCompare(a.email);
}
case clsUsersEN.con_PhoneNumber:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsUsersEN.con_AvatarsPicture:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.avatarsPicture.localeCompare(a.avatarsPicture);
}
case clsUsersEN.con_IdentityID:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.identityID.localeCompare(a.identityID);
}
case clsUsersEN.con_AuditDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.auditDate.localeCompare(a.auditDate);
}
case clsUsersEN.con_AuditUser:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.auditUser.localeCompare(a.auditUser);
}
case clsUsersEN.con_IsAudit:
return (a: clsUsersEN, b: clsUsersEN) => {
if (b.isAudit == true) return 1;
else return -1
}
case clsUsersEN.con_IsRegister:
return (a: clsUsersEN, b: clsUsersEN) => {
if (b.isRegister == true) return 1;
else return -1
}
case clsUsersEN.con_RegisterDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.registerDate.localeCompare(a.registerDate);
}
case clsUsersEN.con_MobilePhone:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.mobilePhone.localeCompare(a.mobilePhone);
}
case clsUsersEN.con_OpenId:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.openId.localeCompare(a.openId);
}
case clsUsersEN.con_UpdDate:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsUsersEN.con_UpdUser:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsUsersEN.con_Memo:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.memo.localeCompare(a.memo);
}
case clsUsersEN.con_HeadPic:
return (a: clsUsersEN, b: clsUsersEN) => {
return b.headPic.localeCompare(a.headPic);
}
case clsUsersEN.con_IsGSuser:
return (a: clsUsersEN, b: clsUsersEN) => {
if (b.isGSuser == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${ users_ConstructorName}.${ strThisFuncName})`;
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
export async function Users_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsUsersEN.con_UserId:
return (obj: clsUsersEN) => {
return obj.userId === value;
}
case clsUsersEN.con_UserName:
return (obj: clsUsersEN) => {
return obj.userName === value;
}
case clsUsersEN.con_DepartmentId:
return (obj: clsUsersEN) => {
return obj.departmentId === value;
}
case clsUsersEN.con_UserStateId:
return (obj: clsUsersEN) => {
return obj.userStateId === value;
}
case clsUsersEN.con_Password:
return (obj: clsUsersEN) => {
return obj.password === value;
}
case clsUsersEN.con_IsGpUser:
return (obj: clsUsersEN) => {
return obj.isGpUser === value;
}
case clsUsersEN.con_SchoolID1:
return (obj: clsUsersEN) => {
return obj.schoolID1 === value;
}
case clsUsersEN.con_BeginYearMonth:
return (obj: clsUsersEN) => {
return obj.beginYearMonth === value;
}
case clsUsersEN.con_EndYearMonth:
return (obj: clsUsersEN) => {
return obj.endYearMonth === value;
}
case clsUsersEN.con_id_GradeBase:
return (obj: clsUsersEN) => {
return obj.id_GradeBase === value;
}
case clsUsersEN.con_id_XzCollege:
return (obj: clsUsersEN) => {
return obj.id_XzCollege === value;
}
case clsUsersEN.con_id_XzMajor:
return (obj: clsUsersEN) => {
return obj.id_XzMajor === value;
}
case clsUsersEN.con_IsLeaved:
return (obj: clsUsersEN) => {
return obj.isLeaved === value;
}
case clsUsersEN.con_StuIdTeacherId:
return (obj: clsUsersEN) => {
return obj.stuIdTeacherId === value;
}
case clsUsersEN.con_Email:
return (obj: clsUsersEN) => {
return obj.email === value;
}
case clsUsersEN.con_PhoneNumber:
return (obj: clsUsersEN) => {
return obj.phoneNumber === value;
}
case clsUsersEN.con_AvatarsPicture:
return (obj: clsUsersEN) => {
return obj.avatarsPicture === value;
}
case clsUsersEN.con_IdentityID:
return (obj: clsUsersEN) => {
return obj.identityID === value;
}
case clsUsersEN.con_AuditDate:
return (obj: clsUsersEN) => {
return obj.auditDate === value;
}
case clsUsersEN.con_AuditUser:
return (obj: clsUsersEN) => {
return obj.auditUser === value;
}
case clsUsersEN.con_IsAudit:
return (obj: clsUsersEN) => {
return obj.isAudit === value;
}
case clsUsersEN.con_IsRegister:
return (obj: clsUsersEN) => {
return obj.isRegister === value;
}
case clsUsersEN.con_RegisterDate:
return (obj: clsUsersEN) => {
return obj.registerDate === value;
}
case clsUsersEN.con_MobilePhone:
return (obj: clsUsersEN) => {
return obj.mobilePhone === value;
}
case clsUsersEN.con_OpenId:
return (obj: clsUsersEN) => {
return obj.openId === value;
}
case clsUsersEN.con_UpdDate:
return (obj: clsUsersEN) => {
return obj.updDate === value;
}
case clsUsersEN.con_UpdUser:
return (obj: clsUsersEN) => {
return obj.updUser === value;
}
case clsUsersEN.con_Memo:
return (obj: clsUsersEN) => {
return obj.memo === value;
}
case clsUsersEN.con_HeadPic:
return (obj: clsUsersEN) => {
return obj.headPic === value;
}
case clsUsersEN.con_IsGSuser:
return (obj: clsUsersEN) => {
return obj.isGSuser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[Users]中不存在！(in ${ users_ConstructorName}.${ strThisFuncName})`;
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
export async function Users_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetFirstObjAsync(strWhereCond: string): Promise<clsUsersEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objUsers = Users_GetObjFromJsonObj(returnObj);
return objUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsUsersEN._CurrTabName;
clsUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsUsersEN._CurrTabName);
if (IsNullOrEmpty(clsUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsUsersEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrUsersExObjLst_Cache: Array<clsUsersEN> = CacheHelper.Get(strKey);
const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
return arrUsersObjLst_T;
}
try
{
const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrUsersExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
console.log(strInfo);
return arrUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Users_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsUsersEN._CurrTabName;
clsUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsUsersEN._CurrTabName);
if (IsNullOrEmpty(clsUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsUsersEN.CacheAddiCondition);
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
const arrUsersExObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
return arrUsersObjLst_T;
}
try
{
const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrUsersExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
console.log(strInfo);
return arrUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Users_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrUsersObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
return arrUsersObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function Users_GetObjLstAsync(strWhereCond: string): Promise<Array<clsUsersEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsUsersEN._CurrTabName;
clsUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsUsersEN._CurrTabName);
if (IsNullOrEmpty(clsUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsUsersEN.CacheAddiCondition);
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
const arrUsersExObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
const arrUsersObjLst_T = Users_GetObjLstByJSONObjLst(arrUsersExObjLst_Cache);
return arrUsersObjLst_T;
}
try
{
const arrUsersExObjLst = await Users_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrUsersExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrUsersExObjLst.length);
console.log(strInfo);
return arrUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Users_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrUsersObjLst_Cache: Array<clsUsersEN> = JSON.parse(strTempObjLst);
return arrUsersObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Users_GetObjLst_Cache(): Promise<Array<clsUsersEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrUsersObjLst_Cache;
switch (clsUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrUsersObjLst_Cache = await Users_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrUsersObjLst_Cache = await Users_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrUsersObjLst_Cache = await Users_GetObjLst_ClientCache();
break;
default:
arrUsersObjLst_Cache = await Users_GetObjLst_ClientCache();
break;
}
const arrUsersObjLst = Users_GetObjLstByJSONObjLst(arrUsersObjLst_Cache);
return arrUsersObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function Users_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrUsersObjLst_Cache;
switch (clsUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrUsersObjLst_Cache = await Users_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrUsersObjLst_Cache = await Users_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrUsersObjLst_Cache = null;
break;
default:
arrUsersObjLst_Cache = null;
break;
}
return arrUsersObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Users_GetSubObjLst_Cache(objUsers_Cond: clsUsersEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
let arrUsers_Sel: Array < clsUsersEN > = arrUsersObjLst_Cache;
if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
//console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objUsers_Cond), users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsUsersEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrUserId:关键字列表
 * @returns 对象列表
 **/
export async function Users_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsUsersEN>>  
{
const strThisFuncName = "GetObjLstByUserIdLstAsync";
const strAction = "GetObjLstByUserIdLst";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param arrstrUserIdLst:关键字列表
 * @returns 对象列表
*/
export async function Users_GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByUserIdLst_Cache";
try
{
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
const arrUsers_Sel: Array <clsUsersEN> = arrUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId)>-1);
return arrUsers_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsUsersEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function Users_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsUsersEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsUsersEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
if (arrUsersObjLst_Cache.length == 0) return arrUsersObjLst_Cache;
let arrUsers_Sel = arrUsersObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objUsers_Cond = new clsUsersEN();
ObjectAssign(objUsers_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrUsers_Sel.length == 0) return arrUsers_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrUsers_Sel = arrUsers_Sel.sort(Users_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrUsers_Sel = arrUsers_Sel.sort(objPagerPara.sortFun);
}
arrUsers_Sel = arrUsers_Sel.slice(intStart, intEnd);     
return arrUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsUsersEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function Users_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsUsersEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", users_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = Users_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param strUserId:关键字
 * @returns 获取删除的结果
 **/
export async function Users_DelRecordAsync(strUserId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(users_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strUserId);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strUserId, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param arrUserId:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function Users_DelUserssAsync(arrUserId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelUserssAsync";
const strAction = "DelUserss";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_DelUserssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelUserssByCondAsync";
const strAction = "DelUserssByCond";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Users_AddNewRecordAsync(objUsersEN: clsUsersEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objUsersEN.userId === null || objUsersEN.userId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objUsersEN);
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function Users_AddNewRecordWithMaxIdAsync(objUsersEN: clsUsersEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function Users_AddNewRecordWithReturnKeyAsync(objUsersEN: clsUsersEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function Users_AddNewRecordWithReturnKey(objUsersEN: clsUsersEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objUsersEN.userId === null || objUsersEN.userId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function Users_UpdateRecordAsync(objUsersEN: clsUsersEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objUsersEN.sf_UpdFldSetStr === undefined || objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUsersEN.userId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsersEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function Users_UpdateWithConditionAsync(objUsersEN: clsUsersEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objUsersEN.sf_UpdFldSetStr === undefined || objUsersEN.sf_UpdFldSetStr === null || objUsersEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objUsersEN.userId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(users_Controller, strAction);
objUsersEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function Users_IsExistRecord_Cache(objUsers_Cond: clsUsersEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
if (arrUsersObjLst_Cache == null) return false;
let arrUsers_Sel: Array < clsUsersEN > = arrUsersObjLst_Cache;
if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
//console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrUsers_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objUsers_Cond), users_ConstructorName, strThisFuncName);
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
export async function Users_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param strUserId:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function Users_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"UserId": strUserId,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param strUserId:所给的关键字
 * @returns 对象
*/
export async function Users_IsExist_Cache(strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
if (arrUsersObjLst_Cache == null) return false;
try
{
const arrUsers_Sel: Array <clsUsersEN> = arrUsersObjLst_Cache.filter(x => x.userId == strUserId);
if (arrUsers_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, users_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strUserId:关键字
 * @returns 是否存在?存在返回True
 **/
export async function Users_IsExistAsync(strUserId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(users_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strUserId": strUserId }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export async function Users_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
 * @param objUsers_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function Users_GetRecCountByCond_Cache(objUsers_Cond: clsUsersEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrUsersObjLst_Cache = await Users_GetObjLst_Cache();
if (arrUsersObjLst_Cache == null) return 0;
let arrUsers_Sel: Array < clsUsersEN > = arrUsersObjLst_Cache;
if (objUsers_Cond.sf_FldComparisonOp == null || objUsers_Cond.sf_FldComparisonOp == "") return arrUsers_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objUsers_Cond.sf_FldComparisonOp);
//console.log("clsUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrUsers_Sel = arrUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrUsers_Sel = arrUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrUsers_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objUsers_Cond), users_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}
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
export async function Users_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(users_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, users_ConstructorName, strThisFuncName);
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
export function Users_GetWebApiUrl(strController: string, strAction: string): string {
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
export function Users_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsUsersEN._CurrTabName;
switch (clsUsersEN.CacheModeId)
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
vUsers_ReFreshThisCache();
vUsersSim_ReFreshThisCache();
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function Users_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsUsersEN._CurrTabName;
switch (clsUsersEN.CacheModeId)
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
export async function Users__Cache(strDivName: string, strDdlName: string )
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
const arrObjLst_Sel = await Users_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsUsersEN.con_UserId, clsUsersEN.con_UserName, "用户");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Users_CheckPropertyNew(pobjUsersEN: clsUsersEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjUsersEN.userName) === true )
{
 throw new Error("(errid:Watl000058)字段[用户名]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.userStateId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户状态Id]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.identityID) === true 
 || pobjUsersEN.identityID.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[身份编号]不能为空(In 用户)!(clsUsersBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjUsersEN.userId) == false && GetStrLen(pobjUsersEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.userId)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.userName) == false && GetStrLen(pobjUsersEN.userName) > 50)
{
 throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.userName)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.departmentId) == false && GetStrLen(pobjUsersEN.departmentId) > 8)
{
 throw new Error("(errid:Watl000059)字段[部门Id(departmentId)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.departmentId)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.userStateId) == false && GetStrLen(pobjUsersEN.userStateId) > 2)
{
 throw new Error("(errid:Watl000059)字段[用户状态Id(userStateId)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.userStateId)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.password) == false && GetStrLen(pobjUsersEN.password) > 20)
{
 throw new Error("(errid:Watl000059)字段[Password(password)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.password)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.schoolID1) == false && GetStrLen(pobjUsersEN.schoolID1) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校编号(schoolID1)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.schoolID1)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.beginYearMonth) == false && GetStrLen(pobjUsersEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.beginYearMonth)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.endYearMonth) == false && GetStrLen(pobjUsersEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.endYearMonth)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_GradeBase) == false && GetStrLen(pobjUsersEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_GradeBase)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzCollege) == false && GetStrLen(pobjUsersEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_XzCollege)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzMajor) == false && GetStrLen(pobjUsersEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.id_XzMajor)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.stuIdTeacherId) == false && GetStrLen(pobjUsersEN.stuIdTeacherId) > 20)
{
 throw new Error("(errid:Watl000059)字段[学工号(stuIdTeacherId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.stuIdTeacherId)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.email) == false && GetStrLen(pobjUsersEN.email) > 100)
{
 throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.email)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.phoneNumber) == false && GetStrLen(pobjUsersEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 用户(Users))!值:$(pobjUsersEN.phoneNumber)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.avatarsPicture) == false && GetStrLen(pobjUsersEN.avatarsPicture) > 100)
{
 throw new Error("(errid:Watl000059)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.avatarsPicture)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.identityID) == false && GetStrLen(pobjUsersEN.identityID) > 2)
{
 throw new Error("(errid:Watl000059)字段[身份编号(identityID)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.identityID)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.auditDate) == false && GetStrLen(pobjUsersEN.auditDate) > 14)
{
 throw new Error("(errid:Watl000059)字段[AuditDate(auditDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.auditDate)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.auditUser) == false && GetStrLen(pobjUsersEN.auditUser) > 18)
{
 throw new Error("(errid:Watl000059)字段[AuditUser(auditUser)]的长度不能超过18(In 用户(Users))!值:$(pobjUsersEN.auditUser)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.registerDate) == false && GetStrLen(pobjUsersEN.registerDate) > 14)
{
 throw new Error("(errid:Watl000059)字段[RegisterDate(registerDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.registerDate)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.mobilePhone) == false && GetStrLen(pobjUsersEN.mobilePhone) > 20)
{
 throw new Error("(errid:Watl000059)字段[手机(mobilePhone)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.mobilePhone)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.openId) == false && GetStrLen(pobjUsersEN.openId) > 50)
{
 throw new Error("(errid:Watl000059)字段[微信OpenId(openId)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.openId)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.updDate) == false && GetStrLen(pobjUsersEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updDate)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.updUser) == false && GetStrLen(pobjUsersEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updUser)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.memo) == false && GetStrLen(pobjUsersEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 用户(Users))!值:$(pobjUsersEN.memo)(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.headPic) == false && GetStrLen(pobjUsersEN.headPic) > 500)
{
 throw new Error("(errid:Watl000059)字段[头像(headPic)]的长度不能超过500(In 用户(Users))!值:$(pobjUsersEN.headPic)(clsUsersBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjUsersEN.userId) == false && undefined !== pobjUsersEN.userId && tzDataType.isString(pobjUsersEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.userName) == false && undefined !== pobjUsersEN.userName && tzDataType.isString(pobjUsersEN.userName) === false)
{
 throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.departmentId) == false && undefined !== pobjUsersEN.departmentId && tzDataType.isString(pobjUsersEN.departmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.userStateId) == false && undefined !== pobjUsersEN.userStateId && tzDataType.isString(pobjUsersEN.userStateId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.password) == false && undefined !== pobjUsersEN.password && tzDataType.isString(pobjUsersEN.password) === false)
{
 throw new Error("(errid:Watl000060)字段[Password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (null != pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && tzDataType.isBoolean(pobjUsersEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.schoolID1) == false && undefined !== pobjUsersEN.schoolID1 && tzDataType.isString(pobjUsersEN.schoolID1) === false)
{
 throw new Error("(errid:Watl000060)字段[学校编号(schoolID1)]的值:[$(pobjUsersEN.schoolID1)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.beginYearMonth) == false && undefined !== pobjUsersEN.beginYearMonth && tzDataType.isString(pobjUsersEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjUsersEN.beginYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.endYearMonth) == false && undefined !== pobjUsersEN.endYearMonth && tzDataType.isString(pobjUsersEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjUsersEN.endYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_GradeBase) == false && undefined !== pobjUsersEN.id_GradeBase && tzDataType.isString(pobjUsersEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzCollege) == false && undefined !== pobjUsersEN.id_XzCollege && tzDataType.isString(pobjUsersEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzMajor) == false && undefined !== pobjUsersEN.id_XzMajor && tzDataType.isString(pobjUsersEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (null != pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && tzDataType.isBoolean(pobjUsersEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.stuIdTeacherId) == false && undefined !== pobjUsersEN.stuIdTeacherId && tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false)
{
 throw new Error("(errid:Watl000060)字段[学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.email) == false && undefined !== pobjUsersEN.email && tzDataType.isString(pobjUsersEN.email) === false)
{
 throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.phoneNumber) == false && undefined !== pobjUsersEN.phoneNumber && tzDataType.isString(pobjUsersEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjUsersEN.phoneNumber)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.avatarsPicture) == false && undefined !== pobjUsersEN.avatarsPicture && tzDataType.isString(pobjUsersEN.avatarsPicture) === false)
{
 throw new Error("(errid:Watl000060)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjUsersEN.avatarsPicture)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.identityID) == false && undefined !== pobjUsersEN.identityID && tzDataType.isString(pobjUsersEN.identityID) === false)
{
 throw new Error("(errid:Watl000060)字段[身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.auditDate) == false && undefined !== pobjUsersEN.auditDate && tzDataType.isString(pobjUsersEN.auditDate) === false)
{
 throw new Error("(errid:Watl000060)字段[AuditDate(auditDate)]的值:[$(pobjUsersEN.auditDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.auditUser) == false && undefined !== pobjUsersEN.auditUser && tzDataType.isString(pobjUsersEN.auditUser) === false)
{
 throw new Error("(errid:Watl000060)字段[AuditUser(auditUser)]的值:[$(pobjUsersEN.auditUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (null != pobjUsersEN.isAudit && undefined !== pobjUsersEN.isAudit && tzDataType.isBoolean(pobjUsersEN.isAudit) === false)
{
 throw new Error("(errid:Watl000060)字段[是否审核(isAudit)]的值:[$(pobjUsersEN.isAudit)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (null != pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && tzDataType.isBoolean(pobjUsersEN.isRegister) === false)
{
 throw new Error("(errid:Watl000060)字段[IsRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.registerDate) == false && undefined !== pobjUsersEN.registerDate && tzDataType.isString(pobjUsersEN.registerDate) === false)
{
 throw new Error("(errid:Watl000060)字段[RegisterDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.mobilePhone) == false && undefined !== pobjUsersEN.mobilePhone && tzDataType.isString(pobjUsersEN.mobilePhone) === false)
{
 throw new Error("(errid:Watl000060)字段[手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.openId) == false && undefined !== pobjUsersEN.openId && tzDataType.isString(pobjUsersEN.openId) === false)
{
 throw new Error("(errid:Watl000060)字段[微信OpenId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.updDate) == false && undefined !== pobjUsersEN.updDate && tzDataType.isString(pobjUsersEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.updUser) == false && undefined !== pobjUsersEN.updUser && tzDataType.isString(pobjUsersEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.memo) == false && undefined !== pobjUsersEN.memo && tzDataType.isString(pobjUsersEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjUsersEN.headPic) == false && undefined !== pobjUsersEN.headPic && tzDataType.isString(pobjUsersEN.headPic) === false)
{
 throw new Error("(errid:Watl000060)字段[头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
if (null != pobjUsersEN.isGSuser && undefined !== pobjUsersEN.isGSuser && tzDataType.isBoolean(pobjUsersEN.isGSuser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否GS用户(isGSuser)]的值:[$(pobjUsersEN.isGSuser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjUsersEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function Users_CheckProperty4Update (pobjUsersEN: clsUsersEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjUsersEN.userId) == false && GetStrLen(pobjUsersEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.userId)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.userName) == false && GetStrLen(pobjUsersEN.userName) > 50)
{
 throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.userName)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.departmentId) == false && GetStrLen(pobjUsersEN.departmentId) > 8)
{
 throw new Error("(errid:Watl000062)字段[部门Id(departmentId)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.departmentId)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.userStateId) == false && GetStrLen(pobjUsersEN.userStateId) > 2)
{
 throw new Error("(errid:Watl000062)字段[用户状态Id(userStateId)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.userStateId)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.password) == false && GetStrLen(pobjUsersEN.password) > 20)
{
 throw new Error("(errid:Watl000062)字段[Password(password)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.password)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.schoolID1) == false && GetStrLen(pobjUsersEN.schoolID1) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校编号(schoolID1)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.schoolID1)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.beginYearMonth) == false && GetStrLen(pobjUsersEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.beginYearMonth)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.endYearMonth) == false && GetStrLen(pobjUsersEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.endYearMonth)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_GradeBase) == false && GetStrLen(pobjUsersEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_GradeBase)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzCollege) == false && GetStrLen(pobjUsersEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 用户(Users))!值:$(pobjUsersEN.id_XzCollege)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzMajor) == false && GetStrLen(pobjUsersEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 用户(Users))!值:$(pobjUsersEN.id_XzMajor)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.stuIdTeacherId) == false && GetStrLen(pobjUsersEN.stuIdTeacherId) > 20)
{
 throw new Error("(errid:Watl000062)字段[学工号(stuIdTeacherId)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.stuIdTeacherId)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.email) == false && GetStrLen(pobjUsersEN.email) > 100)
{
 throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.email)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.phoneNumber) == false && GetStrLen(pobjUsersEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 用户(Users))!值:$(pobjUsersEN.phoneNumber)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.avatarsPicture) == false && GetStrLen(pobjUsersEN.avatarsPicture) > 100)
{
 throw new Error("(errid:Watl000062)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In 用户(Users))!值:$(pobjUsersEN.avatarsPicture)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.identityID) == false && GetStrLen(pobjUsersEN.identityID) > 2)
{
 throw new Error("(errid:Watl000062)字段[身份编号(identityID)]的长度不能超过2(In 用户(Users))!值:$(pobjUsersEN.identityID)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.auditDate) == false && GetStrLen(pobjUsersEN.auditDate) > 14)
{
 throw new Error("(errid:Watl000062)字段[AuditDate(auditDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.auditDate)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.auditUser) == false && GetStrLen(pobjUsersEN.auditUser) > 18)
{
 throw new Error("(errid:Watl000062)字段[AuditUser(auditUser)]的长度不能超过18(In 用户(Users))!值:$(pobjUsersEN.auditUser)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.registerDate) == false && GetStrLen(pobjUsersEN.registerDate) > 14)
{
 throw new Error("(errid:Watl000062)字段[RegisterDate(registerDate)]的长度不能超过14(In 用户(Users))!值:$(pobjUsersEN.registerDate)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.mobilePhone) == false && GetStrLen(pobjUsersEN.mobilePhone) > 20)
{
 throw new Error("(errid:Watl000062)字段[手机(mobilePhone)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.mobilePhone)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.openId) == false && GetStrLen(pobjUsersEN.openId) > 50)
{
 throw new Error("(errid:Watl000062)字段[微信OpenId(openId)]的长度不能超过50(In 用户(Users))!值:$(pobjUsersEN.openId)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.updDate) == false && GetStrLen(pobjUsersEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updDate)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.updUser) == false && GetStrLen(pobjUsersEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 用户(Users))!值:$(pobjUsersEN.updUser)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.memo) == false && GetStrLen(pobjUsersEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 用户(Users))!值:$(pobjUsersEN.memo)(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.headPic) == false && GetStrLen(pobjUsersEN.headPic) > 500)
{
 throw new Error("(errid:Watl000062)字段[头像(headPic)]的长度不能超过500(In 用户(Users))!值:$(pobjUsersEN.headPic)(clsUsersBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjUsersEN.userId) == false && undefined !== pobjUsersEN.userId && tzDataType.isString(pobjUsersEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjUsersEN.userId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.userName) == false && undefined !== pobjUsersEN.userName && tzDataType.isString(pobjUsersEN.userName) === false)
{
 throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjUsersEN.userName)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.departmentId) == false && undefined !== pobjUsersEN.departmentId && tzDataType.isString(pobjUsersEN.departmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[部门Id(departmentId)]的值:[$(pobjUsersEN.departmentId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.userStateId) == false && undefined !== pobjUsersEN.userStateId && tzDataType.isString(pobjUsersEN.userStateId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户状态Id(userStateId)]的值:[$(pobjUsersEN.userStateId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.password) == false && undefined !== pobjUsersEN.password && tzDataType.isString(pobjUsersEN.password) === false)
{
 throw new Error("(errid:Watl000063)字段[Password(password)]的值:[$(pobjUsersEN.password)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (null != pobjUsersEN.isGpUser && undefined !== pobjUsersEN.isGpUser && tzDataType.isBoolean(pobjUsersEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjUsersEN.isGpUser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.schoolID1) == false && undefined !== pobjUsersEN.schoolID1 && tzDataType.isString(pobjUsersEN.schoolID1) === false)
{
 throw new Error("(errid:Watl000063)字段[学校编号(schoolID1)]的值:[$(pobjUsersEN.schoolID1)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.beginYearMonth) == false && undefined !== pobjUsersEN.beginYearMonth && tzDataType.isString(pobjUsersEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjUsersEN.beginYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.endYearMonth) == false && undefined !== pobjUsersEN.endYearMonth && tzDataType.isString(pobjUsersEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjUsersEN.endYearMonth)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_GradeBase) == false && undefined !== pobjUsersEN.id_GradeBase && tzDataType.isString(pobjUsersEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjUsersEN.id_GradeBase)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzCollege) == false && undefined !== pobjUsersEN.id_XzCollege && tzDataType.isString(pobjUsersEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjUsersEN.id_XzCollege)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.id_XzMajor) == false && undefined !== pobjUsersEN.id_XzMajor && tzDataType.isString(pobjUsersEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjUsersEN.id_XzMajor)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (null != pobjUsersEN.isLeaved && undefined !== pobjUsersEN.isLeaved && tzDataType.isBoolean(pobjUsersEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjUsersEN.isLeaved)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.stuIdTeacherId) == false && undefined !== pobjUsersEN.stuIdTeacherId && tzDataType.isString(pobjUsersEN.stuIdTeacherId) === false)
{
 throw new Error("(errid:Watl000063)字段[学工号(stuIdTeacherId)]的值:[$(pobjUsersEN.stuIdTeacherId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.email) == false && undefined !== pobjUsersEN.email && tzDataType.isString(pobjUsersEN.email) === false)
{
 throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjUsersEN.email)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.phoneNumber) == false && undefined !== pobjUsersEN.phoneNumber && tzDataType.isString(pobjUsersEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjUsersEN.phoneNumber)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.avatarsPicture) == false && undefined !== pobjUsersEN.avatarsPicture && tzDataType.isString(pobjUsersEN.avatarsPicture) === false)
{
 throw new Error("(errid:Watl000063)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjUsersEN.avatarsPicture)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.identityID) == false && undefined !== pobjUsersEN.identityID && tzDataType.isString(pobjUsersEN.identityID) === false)
{
 throw new Error("(errid:Watl000063)字段[身份编号(identityID)]的值:[$(pobjUsersEN.identityID)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.auditDate) == false && undefined !== pobjUsersEN.auditDate && tzDataType.isString(pobjUsersEN.auditDate) === false)
{
 throw new Error("(errid:Watl000063)字段[AuditDate(auditDate)]的值:[$(pobjUsersEN.auditDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.auditUser) == false && undefined !== pobjUsersEN.auditUser && tzDataType.isString(pobjUsersEN.auditUser) === false)
{
 throw new Error("(errid:Watl000063)字段[AuditUser(auditUser)]的值:[$(pobjUsersEN.auditUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (null != pobjUsersEN.isAudit && undefined !== pobjUsersEN.isAudit && tzDataType.isBoolean(pobjUsersEN.isAudit) === false)
{
 throw new Error("(errid:Watl000063)字段[是否审核(isAudit)]的值:[$(pobjUsersEN.isAudit)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (null != pobjUsersEN.isRegister && undefined !== pobjUsersEN.isRegister && tzDataType.isBoolean(pobjUsersEN.isRegister) === false)
{
 throw new Error("(errid:Watl000063)字段[IsRegister(isRegister)]的值:[$(pobjUsersEN.isRegister)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.registerDate) == false && undefined !== pobjUsersEN.registerDate && tzDataType.isString(pobjUsersEN.registerDate) === false)
{
 throw new Error("(errid:Watl000063)字段[RegisterDate(registerDate)]的值:[$(pobjUsersEN.registerDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.mobilePhone) == false && undefined !== pobjUsersEN.mobilePhone && tzDataType.isString(pobjUsersEN.mobilePhone) === false)
{
 throw new Error("(errid:Watl000063)字段[手机(mobilePhone)]的值:[$(pobjUsersEN.mobilePhone)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.openId) == false && undefined !== pobjUsersEN.openId && tzDataType.isString(pobjUsersEN.openId) === false)
{
 throw new Error("(errid:Watl000063)字段[微信OpenId(openId)]的值:[$(pobjUsersEN.openId)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.updDate) == false && undefined !== pobjUsersEN.updDate && tzDataType.isString(pobjUsersEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjUsersEN.updDate)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.updUser) == false && undefined !== pobjUsersEN.updUser && tzDataType.isString(pobjUsersEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjUsersEN.updUser)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.memo) == false && undefined !== pobjUsersEN.memo && tzDataType.isString(pobjUsersEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjUsersEN.memo)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjUsersEN.headPic) == false && undefined !== pobjUsersEN.headPic && tzDataType.isString(pobjUsersEN.headPic) === false)
{
 throw new Error("(errid:Watl000063)字段[头像(headPic)]的值:[$(pobjUsersEN.headPic)], 非法，应该为字符型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
if (null != pobjUsersEN.isGSuser && undefined !== pobjUsersEN.isGSuser && tzDataType.isBoolean(pobjUsersEN.isGSuser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否GS用户(isGSuser)]的值:[$(pobjUsersEN.isGSuser)], 非法，应该为布尔型(In 用户(Users))!(clsUsersBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjUsersEN.userId) === true )
{
 throw new Error("(errid:Watl000064)字段[用户ID]不能为空(In 用户)!(clsUsersBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjUsersEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Users_GetJSONStrByObj (pobjUsersEN: clsUsersEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjUsersEN.sf_UpdFldSetStr = pobjUsersEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjUsersEN);
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
export function Users_GetObjLstByJSONStr (strJSON: string): Array<clsUsersEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrUsersObjLst = new Array<clsUsersEN>();
if (strJSON === "")
{
return arrUsersObjLst;
}
try
{
arrUsersObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrUsersObjLst;
}
return arrUsersObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrUsersObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function Users_GetObjLstByJSONObjLst (arrUsersObjLstS: Array<clsUsersEN>): Array<clsUsersEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrUsersObjLst = new Array<clsUsersEN>();
for (const objInFor of arrUsersObjLstS) {
const obj1 = Users_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrUsersObjLst.push(obj1);
}
return arrUsersObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function Users_GetObjByJSONStr (strJSON: string): clsUsersEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjUsersEN = new clsUsersEN();
if (strJSON === "")
{
return pobjUsersEN;
}
try
{
pobjUsersEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjUsersEN;
}
return pobjUsersEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function Users_GetCombineCondition(objUsers_Cond: clsUsersEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_UserId, objUsers_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_UserName, objUsers_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_DepartmentId) == true)
{
const strComparisonOp_DepartmentId:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_DepartmentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_DepartmentId, objUsers_Cond.departmentId, strComparisonOp_DepartmentId);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_UserStateId) == true)
{
const strComparisonOp_UserStateId:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_UserStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_UserStateId, objUsers_Cond.userStateId, strComparisonOp_UserStateId);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_Password) == true)
{
const strComparisonOp_Password:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_Password];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_Password, objUsers_Cond.password, strComparisonOp_Password);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IsGpUser) == true)
{
if (objUsers_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsUsersEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsUsersEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_SchoolID1) == true)
{
const strComparisonOp_SchoolID1:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_SchoolID1];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_SchoolID1, objUsers_Cond.schoolID1, strComparisonOp_SchoolID1);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_BeginYearMonth) == true)
{
const strComparisonOp_BeginYearMonth:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_BeginYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_BeginYearMonth, objUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_EndYearMonth) == true)
{
const strComparisonOp_EndYearMonth:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_EndYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_EndYearMonth, objUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_id_GradeBase, objUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_id_XzCollege, objUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_id_XzMajor, objUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IsLeaved) == true)
{
if (objUsers_Cond.isLeaved == true)
{
strWhereCond += Format(" And {0} = '1'", clsUsersEN.con_IsLeaved);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsUsersEN.con_IsLeaved);
}
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_StuIdTeacherId) == true)
{
const strComparisonOp_StuIdTeacherId:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_StuIdTeacherId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_StuIdTeacherId, objUsers_Cond.stuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_Email) == true)
{
const strComparisonOp_Email:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_Email, objUsers_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_PhoneNumber, objUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_AvatarsPicture) == true)
{
const strComparisonOp_AvatarsPicture:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_AvatarsPicture];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_AvatarsPicture, objUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IdentityID) == true)
{
const strComparisonOp_IdentityID:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_IdentityID];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_IdentityID, objUsers_Cond.identityID, strComparisonOp_IdentityID);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_AuditDate) == true)
{
const strComparisonOp_AuditDate:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_AuditDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_AuditDate, objUsers_Cond.auditDate, strComparisonOp_AuditDate);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_AuditUser) == true)
{
const strComparisonOp_AuditUser:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_AuditUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_AuditUser, objUsers_Cond.auditUser, strComparisonOp_AuditUser);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IsAudit) == true)
{
if (objUsers_Cond.isAudit == true)
{
strWhereCond += Format(" And {0} = '1'", clsUsersEN.con_IsAudit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsUsersEN.con_IsAudit);
}
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IsRegister) == true)
{
if (objUsers_Cond.isRegister == true)
{
strWhereCond += Format(" And {0} = '1'", clsUsersEN.con_IsRegister);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsUsersEN.con_IsRegister);
}
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_RegisterDate) == true)
{
const strComparisonOp_RegisterDate:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_RegisterDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_RegisterDate, objUsers_Cond.registerDate, strComparisonOp_RegisterDate);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_MobilePhone) == true)
{
const strComparisonOp_MobilePhone:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_MobilePhone];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_MobilePhone, objUsers_Cond.mobilePhone, strComparisonOp_MobilePhone);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_OpenId) == true)
{
const strComparisonOp_OpenId:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_OpenId];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_OpenId, objUsers_Cond.openId, strComparisonOp_OpenId);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_UpdDate, objUsers_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_UpdUser, objUsers_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_Memo, objUsers_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_HeadPic) == true)
{
const strComparisonOp_HeadPic:string = objUsers_Cond.dicFldComparisonOp[clsUsersEN.con_HeadPic];
strWhereCond += Format(" And {0} {2} '{1}'", clsUsersEN.con_HeadPic, objUsers_Cond.headPic, strComparisonOp_HeadPic);
}
if (Object.prototype.hasOwnProperty.call(objUsers_Cond.dicFldComparisonOp, clsUsersEN.con_IsGSuser) == true)
{
if (objUsers_Cond.isGSuser == true)
{
strWhereCond += Format(" And {0} = '1'", clsUsersEN.con_IsGSuser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsUsersEN.con_IsGSuser);
}
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objUsersENS:源对象
 * @param objUsersENT:目标对象
*/
export function Users_CopyObjTo(objUsersENS: clsUsersEN , objUsersENT: clsUsersEN ): void 
{
objUsersENT.userId = objUsersENS.userId; //用户ID
objUsersENT.userName = objUsersENS.userName; //用户名
objUsersENT.departmentId = objUsersENS.departmentId; //部门Id
objUsersENT.userStateId = objUsersENS.userStateId; //用户状态Id
objUsersENT.password = objUsersENS.password; //Password
objUsersENT.isGpUser = objUsersENS.isGpUser; //是否Gp用户
objUsersENT.schoolID1 = objUsersENS.schoolID1; //学校编号
objUsersENT.beginYearMonth = objUsersENS.beginYearMonth; //开始年月
objUsersENT.endYearMonth = objUsersENS.endYearMonth; //结束年月
objUsersENT.id_GradeBase = objUsersENS.id_GradeBase; //年级流水号
objUsersENT.id_XzCollege = objUsersENS.id_XzCollege; //学院流水号
objUsersENT.id_XzMajor = objUsersENS.id_XzMajor; //专业流水号
objUsersENT.isLeaved = objUsersENS.isLeaved; //IsLeaved
objUsersENT.stuIdTeacherId = objUsersENS.stuIdTeacherId; //学工号
objUsersENT.email = objUsersENS.email; //电子邮箱
objUsersENT.phoneNumber = objUsersENS.phoneNumber; //PhoneNumber
objUsersENT.avatarsPicture = objUsersENS.avatarsPicture; //AvatarsPicture
objUsersENT.identityID = objUsersENS.identityID; //身份编号
objUsersENT.auditDate = objUsersENS.auditDate; //AuditDate
objUsersENT.auditUser = objUsersENS.auditUser; //AuditUser
objUsersENT.isAudit = objUsersENS.isAudit; //是否审核
objUsersENT.isRegister = objUsersENS.isRegister; //IsRegister
objUsersENT.registerDate = objUsersENS.registerDate; //RegisterDate
objUsersENT.mobilePhone = objUsersENS.mobilePhone; //手机
objUsersENT.openId = objUsersENS.openId; //微信OpenId
objUsersENT.updDate = objUsersENS.updDate; //修改日期
objUsersENT.updUser = objUsersENS.updUser; //修改人
objUsersENT.memo = objUsersENS.memo; //备注
objUsersENT.headPic = objUsersENS.headPic; //头像
objUsersENT.isGSuser = objUsersENS.isGSuser; //是否GS用户
objUsersENT.sf_UpdFldSetStr = objUsersENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objUsersENS:源对象
 * @param objUsersENT:目标对象
*/
export function Users_GetObjFromJsonObj(objUsersENS: clsUsersEN): clsUsersEN 
{
 const objUsersENT: clsUsersEN = new clsUsersEN();
ObjectAssign(objUsersENT, objUsersENS);
 return objUsersENT;
}