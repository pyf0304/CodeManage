
 /**
 * 类名:clsvUsersWApi
 * 表名:vUsers(01120027)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:22
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
 * v用户(vUsers)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvUsersEN } from "../../L0_Entity/UserManage/clsvUsersEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vUsers_Controller = "vUsersApi";
 export const vUsers_ConstructorName = "vUsers";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strUserId:关键字
 * @returns 对象
 **/
export async function vUsers_GetObjByUserIdAsync(strUserId: string): Promise<clsvUsersEN>  
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
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvUsers = vUsers_GetObjFromJsonObj(returnObj);
return objvUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjByUserId_Cache(strUserId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
try
{
const arrvUsers_Sel: Array <clsvUsersEN> = arrvUsersObjLst_Cache.filter(x => x.userId == strUserId);
let objvUsers: clsvUsersEN;
if (arrvUsers_Sel.length > 0)
{
objvUsers = arrvUsers_Sel[0];
return objvUsers;
}
else
{
if (bolTryAsyncOnce == true)
{
objvUsers = await vUsers_GetObjByUserIdAsync(strUserId);
if (objvUsers != null)
{
vUsers_ReFreshThisCache();
return objvUsers;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjByUserId_localStorage(strUserId: string) {
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
const strKey = Format("{0}_{1}", clsvUsersEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvUsers_Cache: clsvUsersEN = JSON.parse(strTempObj);
return objvUsers_Cache;
}
try
{
const objvUsers = await vUsers_GetObjByUserIdAsync(strUserId);
if (objvUsers != null)
{
localStorage.setItem(strKey, JSON.stringify(objvUsers));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvUsers;
}
return objvUsers;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
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
 * @returns 返回一个输出字段值
*/
export async function vUsers_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvUsersEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvUsersEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvUsersEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strUserId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvUsers = await vUsers_GetObjByUserId_Cache(strUserId );
if (objvUsers == null) return "";
return objvUsers.GetFldValue(strOutFldName).toString();
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
export function vUsers_SortFun_Defa(a:clsvUsersEN , b:clsvUsersEN): number 
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
export function vUsers_SortFun_Defa_2Fld(a:clsvUsersEN , b:clsvUsersEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userName == b.userName) return a.userStateId.localeCompare(b.userStateId);
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
export function vUsers_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvUsersEN.con_UserId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvUsersEN.con_UserName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvUsersEN.con_UserStateId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.userStateId.localeCompare(b.userStateId);
}
case clsvUsersEN.con_UserStateName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.userStateName.localeCompare(b.userStateName);
}
case clsvUsersEN.con_Password:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.password.localeCompare(b.password);
}
case clsvUsersEN.con_IsGpUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsvUsersEN.con_BeginYearMonth:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.beginYearMonth.localeCompare(b.beginYearMonth);
}
case clsvUsersEN.con_EndYearMonth:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.endYearMonth.localeCompare(b.endYearMonth);
}
case clsvUsersEN.con_id_GradeBase:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsvUsersEN.con_GradeBaseName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.gradeBaseName.localeCompare(b.gradeBaseName);
}
case clsvUsersEN.con_id_XzCollege:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvUsersEN.con_CollegeID:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvUsersEN.con_CollegeName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvUsersEN.con_CollegeNameA:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvUsersEN.con_id_XzMajor:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvUsersEN.con_MajorName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvUsersEN.con_IsLeaved:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (a.isLeaved == true) return 1;
else return -1
}
case clsvUsersEN.con_StuIdTeacherId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.stuIdTeacherId.localeCompare(b.stuIdTeacherId);
}
case clsvUsersEN.con_IdentityID:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.identityID.localeCompare(b.identityID);
}
case clsvUsersEN.con_IdentityDesc:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.identityDesc.localeCompare(b.identityDesc);
}
case clsvUsersEN.con_AuditDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.auditDate.localeCompare(b.auditDate);
}
case clsvUsersEN.con_AuditUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.auditUser.localeCompare(b.auditUser);
}
case clsvUsersEN.con_IsAudit:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (a.isAudit == true) return 1;
else return -1
}
case clsvUsersEN.con_IsRegister:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (a.isRegister == true) return 1;
else return -1
}
case clsvUsersEN.con_RegisterDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.registerDate.localeCompare(b.registerDate);
}
case clsvUsersEN.con_MobilePhone:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.mobilePhone.localeCompare(b.mobilePhone);
}
case clsvUsersEN.con_UpdDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvUsersEN.con_UpdUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvUsersEN.con_Memo:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvUsersEN.con_UserNameWithUserId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.userNameWithUserId.localeCompare(b.userNameWithUserId);
}
case clsvUsersEN.con_OpenId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.openId.localeCompare(b.openId);
}
case clsvUsersEN.con_AvatarsPicture:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.avatarsPicture.localeCompare(b.avatarsPicture);
}
case clsvUsersEN.con_Email:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.email.localeCompare(b.email);
}
case clsvUsersEN.con_PhoneNumber:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsvUsersEN.con_HeadPic:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return a.headPic.localeCompare(b.headPic);
}
case clsvUsersEN.con_IsGSuser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (a.isGSuser == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${ vUsers_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvUsersEN.con_UserId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvUsersEN.con_UserName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvUsersEN.con_UserStateId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.userStateId.localeCompare(a.userStateId);
}
case clsvUsersEN.con_UserStateName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.userStateName.localeCompare(a.userStateName);
}
case clsvUsersEN.con_Password:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.password.localeCompare(a.password);
}
case clsvUsersEN.con_IsGpUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsvUsersEN.con_BeginYearMonth:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.beginYearMonth.localeCompare(a.beginYearMonth);
}
case clsvUsersEN.con_EndYearMonth:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.endYearMonth.localeCompare(a.endYearMonth);
}
case clsvUsersEN.con_id_GradeBase:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsvUsersEN.con_GradeBaseName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.gradeBaseName.localeCompare(a.gradeBaseName);
}
case clsvUsersEN.con_id_XzCollege:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvUsersEN.con_CollegeID:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvUsersEN.con_CollegeName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvUsersEN.con_CollegeNameA:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvUsersEN.con_id_XzMajor:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvUsersEN.con_MajorName:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvUsersEN.con_IsLeaved:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (b.isLeaved == true) return 1;
else return -1
}
case clsvUsersEN.con_StuIdTeacherId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.stuIdTeacherId.localeCompare(a.stuIdTeacherId);
}
case clsvUsersEN.con_IdentityID:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.identityID.localeCompare(a.identityID);
}
case clsvUsersEN.con_IdentityDesc:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.identityDesc.localeCompare(a.identityDesc);
}
case clsvUsersEN.con_AuditDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.auditDate.localeCompare(a.auditDate);
}
case clsvUsersEN.con_AuditUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.auditUser.localeCompare(a.auditUser);
}
case clsvUsersEN.con_IsAudit:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (b.isAudit == true) return 1;
else return -1
}
case clsvUsersEN.con_IsRegister:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (b.isRegister == true) return 1;
else return -1
}
case clsvUsersEN.con_RegisterDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.registerDate.localeCompare(a.registerDate);
}
case clsvUsersEN.con_MobilePhone:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.mobilePhone.localeCompare(a.mobilePhone);
}
case clsvUsersEN.con_UpdDate:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvUsersEN.con_UpdUser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvUsersEN.con_Memo:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvUsersEN.con_UserNameWithUserId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.userNameWithUserId.localeCompare(a.userNameWithUserId);
}
case clsvUsersEN.con_OpenId:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.openId.localeCompare(a.openId);
}
case clsvUsersEN.con_AvatarsPicture:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.avatarsPicture.localeCompare(a.avatarsPicture);
}
case clsvUsersEN.con_Email:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.email.localeCompare(a.email);
}
case clsvUsersEN.con_PhoneNumber:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsvUsersEN.con_HeadPic:
return (a: clsvUsersEN, b: clsvUsersEN) => {
return b.headPic.localeCompare(a.headPic);
}
case clsvUsersEN.con_IsGSuser:
return (a: clsvUsersEN, b: clsvUsersEN) => {
if (b.isGSuser == true) return 1;
else return -1
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${ vUsers_ConstructorName}.${ strThisFuncName})`;
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
export async function vUsers_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvUsersEN.con_UserId:
return (obj: clsvUsersEN) => {
return obj.userId === value;
}
case clsvUsersEN.con_UserName:
return (obj: clsvUsersEN) => {
return obj.userName === value;
}
case clsvUsersEN.con_UserStateId:
return (obj: clsvUsersEN) => {
return obj.userStateId === value;
}
case clsvUsersEN.con_UserStateName:
return (obj: clsvUsersEN) => {
return obj.userStateName === value;
}
case clsvUsersEN.con_Password:
return (obj: clsvUsersEN) => {
return obj.password === value;
}
case clsvUsersEN.con_IsGpUser:
return (obj: clsvUsersEN) => {
return obj.isGpUser === value;
}
case clsvUsersEN.con_BeginYearMonth:
return (obj: clsvUsersEN) => {
return obj.beginYearMonth === value;
}
case clsvUsersEN.con_EndYearMonth:
return (obj: clsvUsersEN) => {
return obj.endYearMonth === value;
}
case clsvUsersEN.con_id_GradeBase:
return (obj: clsvUsersEN) => {
return obj.id_GradeBase === value;
}
case clsvUsersEN.con_GradeBaseName:
return (obj: clsvUsersEN) => {
return obj.gradeBaseName === value;
}
case clsvUsersEN.con_id_XzCollege:
return (obj: clsvUsersEN) => {
return obj.id_XzCollege === value;
}
case clsvUsersEN.con_CollegeID:
return (obj: clsvUsersEN) => {
return obj.collegeID === value;
}
case clsvUsersEN.con_CollegeName:
return (obj: clsvUsersEN) => {
return obj.collegeName === value;
}
case clsvUsersEN.con_CollegeNameA:
return (obj: clsvUsersEN) => {
return obj.collegeNameA === value;
}
case clsvUsersEN.con_id_XzMajor:
return (obj: clsvUsersEN) => {
return obj.id_XzMajor === value;
}
case clsvUsersEN.con_MajorName:
return (obj: clsvUsersEN) => {
return obj.majorName === value;
}
case clsvUsersEN.con_IsLeaved:
return (obj: clsvUsersEN) => {
return obj.isLeaved === value;
}
case clsvUsersEN.con_StuIdTeacherId:
return (obj: clsvUsersEN) => {
return obj.stuIdTeacherId === value;
}
case clsvUsersEN.con_IdentityID:
return (obj: clsvUsersEN) => {
return obj.identityID === value;
}
case clsvUsersEN.con_IdentityDesc:
return (obj: clsvUsersEN) => {
return obj.identityDesc === value;
}
case clsvUsersEN.con_AuditDate:
return (obj: clsvUsersEN) => {
return obj.auditDate === value;
}
case clsvUsersEN.con_AuditUser:
return (obj: clsvUsersEN) => {
return obj.auditUser === value;
}
case clsvUsersEN.con_IsAudit:
return (obj: clsvUsersEN) => {
return obj.isAudit === value;
}
case clsvUsersEN.con_IsRegister:
return (obj: clsvUsersEN) => {
return obj.isRegister === value;
}
case clsvUsersEN.con_RegisterDate:
return (obj: clsvUsersEN) => {
return obj.registerDate === value;
}
case clsvUsersEN.con_MobilePhone:
return (obj: clsvUsersEN) => {
return obj.mobilePhone === value;
}
case clsvUsersEN.con_UpdDate:
return (obj: clsvUsersEN) => {
return obj.updDate === value;
}
case clsvUsersEN.con_UpdUser:
return (obj: clsvUsersEN) => {
return obj.updUser === value;
}
case clsvUsersEN.con_Memo:
return (obj: clsvUsersEN) => {
return obj.memo === value;
}
case clsvUsersEN.con_UserNameWithUserId:
return (obj: clsvUsersEN) => {
return obj.userNameWithUserId === value;
}
case clsvUsersEN.con_OpenId:
return (obj: clsvUsersEN) => {
return obj.openId === value;
}
case clsvUsersEN.con_AvatarsPicture:
return (obj: clsvUsersEN) => {
return obj.avatarsPicture === value;
}
case clsvUsersEN.con_Email:
return (obj: clsvUsersEN) => {
return obj.email === value;
}
case clsvUsersEN.con_PhoneNumber:
return (obj: clsvUsersEN) => {
return obj.phoneNumber === value;
}
case clsvUsersEN.con_HeadPic:
return (obj: clsvUsersEN) => {
return obj.headPic === value;
}
case clsvUsersEN.con_IsGSuser:
return (obj: clsvUsersEN) => {
return obj.isGSuser === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vUsers]中不存在！(in ${ vUsers_ConstructorName}.${ strThisFuncName})`;
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
export async function vUsers_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetFirstObjAsync(strWhereCond: string): Promise<clsvUsersEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvUsers = vUsers_GetObjFromJsonObj(returnObj);
return objvUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersEN._CurrTabName;
clsvUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvUsersExObjLst_Cache: Array<clsvUsersEN> = CacheHelper.Get(strKey);
const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
return arrvUsersObjLst_T;
}
try
{
const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvUsersExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
console.log(strInfo);
return arrvUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsers_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersEN._CurrTabName;
clsvUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersEN.CacheAddiCondition);
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
const arrvUsersExObjLst_Cache: Array<clsvUsersEN> = JSON.parse(strTempObjLst);
const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
return arrvUsersObjLst_T;
}
try
{
const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvUsersExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
console.log(strInfo);
return arrvUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsers_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvUsersObjLst_Cache: Array<clsvUsersEN> = JSON.parse(strTempObjLst);
return arrvUsersObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vUsers_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvUsersEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvUsersEN._CurrTabName;
clsvUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvUsersEN.CacheAddiCondition);
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
const arrvUsersExObjLst_Cache: Array<clsvUsersEN> = JSON.parse(strTempObjLst);
const arrvUsersObjLst_T = vUsers_GetObjLstByJSONObjLst(arrvUsersExObjLst_Cache);
return arrvUsersObjLst_T;
}
try
{
const arrvUsersExObjLst = await vUsers_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvUsersExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvUsersExObjLst.length);
console.log(strInfo);
return arrvUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsers_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvUsersObjLst_Cache: Array<clsvUsersEN> = JSON.parse(strTempObjLst);
return arrvUsersObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsers_GetObjLst_Cache(): Promise<Array<clsvUsersEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvUsersObjLst_Cache;
switch (clsvUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrvUsersObjLst_Cache = await vUsers_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvUsersObjLst_Cache = await vUsers_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvUsersObjLst_Cache = await vUsers_GetObjLst_ClientCache();
break;
default:
arrvUsersObjLst_Cache = await vUsers_GetObjLst_ClientCache();
break;
}
const arrvUsersObjLst = vUsers_GetObjLstByJSONObjLst(arrvUsersObjLst_Cache);
return arrvUsersObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vUsers_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvUsersObjLst_Cache;
switch (clsvUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrvUsersObjLst_Cache = await vUsers_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvUsersObjLst_Cache = await vUsers_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvUsersObjLst_Cache = null;
break;
default:
arrvUsersObjLst_Cache = null;
break;
}
return arrvUsersObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vUsers_GetSubObjLst_Cache(objvUsers_Cond: clsvUsersEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
let arrvUsers_Sel: Array < clsvUsersEN > = arrvUsersObjLst_Cache;
if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "") return arrvUsers_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
//console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvUsers_Cond), vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrUserId:关键字列表
 * @returns 对象列表
 **/
export async function vUsers_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsvUsersEN>>  
{
const strThisFuncName = "GetObjLstByUserIdLstAsync";
const strAction = "GetObjLstByUserIdLst";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByUserIdLst_Cache";
try
{
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
const arrvUsers_Sel: Array <clsvUsersEN> = arrvUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId)>-1);
return arrvUsers_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vUsers_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvUsersEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvUsersEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
if (arrvUsersObjLst_Cache.length == 0) return arrvUsersObjLst_Cache;
let arrvUsers_Sel = arrvUsersObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvUsers_Cond = new clsvUsersEN();
ObjectAssign(objvUsers_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvUsers_Sel.length == 0) return arrvUsers_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvUsers_Sel = arrvUsers_Sel.sort(vUsers_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvUsers_Sel = arrvUsers_Sel.sort(objPagerPara.sortFun);
}
arrvUsers_Sel = arrvUsers_Sel.slice(intStart, intEnd);     
return arrvUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvUsersEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vUsers_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvUsersEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_IsExistRecord_Cache(objvUsers_Cond: clsvUsersEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
if (arrvUsersObjLst_Cache == null) return false;
let arrvUsers_Sel: Array < clsvUsersEN > = arrvUsersObjLst_Cache;
if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "") return arrvUsers_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
//console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvUsers_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvUsers_Cond), vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_IsExist_Cache(strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
if (arrvUsersObjLst_Cache == null) return false;
try
{
const arrvUsers_Sel: Array <clsvUsersEN> = arrvUsersObjLst_Cache.filter(x => x.userId == strUserId);
if (arrvUsers_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_IsExistAsync(strUserId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
export async function vUsers_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vUsers_ConstructorName, strThisFuncName);
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
 * @param objvUsers_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vUsers_GetRecCountByCond_Cache(objvUsers_Cond: clsvUsersEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvUsersObjLst_Cache = await vUsers_GetObjLst_Cache();
if (arrvUsersObjLst_Cache == null) return 0;
let arrvUsers_Sel: Array < clsvUsersEN > = arrvUsersObjLst_Cache;
if (objvUsers_Cond.sf_FldComparisonOp == null || objvUsers_Cond.sf_FldComparisonOp == "") return arrvUsers_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvUsers_Cond.sf_FldComparisonOp);
//console.log("clsvUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvUsers_Sel = arrvUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvUsers_Sel = arrvUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvUsers_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvUsers_Cond), vUsers_ConstructorName, strThisFuncName);
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
export function vUsers_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vUsers_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvUsersEN._CurrTabName;
switch (clsvUsersEN.CacheModeId)
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
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vUsers_GetJSONStrByObj (pobjvUsersEN: clsvUsersEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvUsersEN);
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
export function vUsers_GetObjLstByJSONStr (strJSON: string): Array<clsvUsersEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvUsersObjLst = new Array<clsvUsersEN>();
if (strJSON === "")
{
return arrvUsersObjLst;
}
try
{
arrvUsersObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvUsersObjLst;
}
return arrvUsersObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvUsersObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vUsers_GetObjLstByJSONObjLst (arrvUsersObjLstS: Array<clsvUsersEN>): Array<clsvUsersEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvUsersObjLst = new Array<clsvUsersEN>();
for (const objInFor of arrvUsersObjLstS) {
const obj1 = vUsers_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvUsersObjLst.push(obj1);
}
return arrvUsersObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vUsers_GetObjByJSONStr (strJSON: string): clsvUsersEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvUsersEN = new clsvUsersEN();
if (strJSON === "")
{
return pobjvUsersEN;
}
try
{
pobjvUsersEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvUsersEN;
}
return pobjvUsersEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vUsers_GetCombineCondition(objvUsers_Cond: clsvUsersEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UserId, objvUsers_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UserName, objvUsers_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UserStateId) == true)
{
const strComparisonOp_UserStateId:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UserStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UserStateId, objvUsers_Cond.userStateId, strComparisonOp_UserStateId);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UserStateName) == true)
{
const strComparisonOp_UserStateName:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UserStateName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UserStateName, objvUsers_Cond.userStateName, strComparisonOp_UserStateName);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_Password) == true)
{
const strComparisonOp_Password:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_Password];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_Password, objvUsers_Cond.password, strComparisonOp_Password);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IsGpUser) == true)
{
if (objvUsers_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_BeginYearMonth) == true)
{
const strComparisonOp_BeginYearMonth:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_BeginYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_BeginYearMonth, objvUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_EndYearMonth) == true)
{
const strComparisonOp_EndYearMonth:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_EndYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_EndYearMonth, objvUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_id_GradeBase, objvUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_GradeBaseName) == true)
{
const strComparisonOp_GradeBaseName:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_GradeBaseName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_GradeBaseName, objvUsers_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_id_XzCollege, objvUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_CollegeID, objvUsers_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_CollegeName, objvUsers_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_CollegeNameA, objvUsers_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_id_XzMajor, objvUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_MajorName, objvUsers_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IsLeaved) == true)
{
if (objvUsers_Cond.isLeaved == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersEN.con_IsLeaved);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersEN.con_IsLeaved);
}
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_StuIdTeacherId) == true)
{
const strComparisonOp_StuIdTeacherId:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_StuIdTeacherId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_StuIdTeacherId, objvUsers_Cond.stuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IdentityID) == true)
{
const strComparisonOp_IdentityID:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_IdentityID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_IdentityID, objvUsers_Cond.identityID, strComparisonOp_IdentityID);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IdentityDesc) == true)
{
const strComparisonOp_IdentityDesc:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_IdentityDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_IdentityDesc, objvUsers_Cond.identityDesc, strComparisonOp_IdentityDesc);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_AuditDate) == true)
{
const strComparisonOp_AuditDate:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_AuditDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_AuditDate, objvUsers_Cond.auditDate, strComparisonOp_AuditDate);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_AuditUser) == true)
{
const strComparisonOp_AuditUser:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_AuditUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_AuditUser, objvUsers_Cond.auditUser, strComparisonOp_AuditUser);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IsAudit) == true)
{
if (objvUsers_Cond.isAudit == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersEN.con_IsAudit);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersEN.con_IsAudit);
}
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IsRegister) == true)
{
if (objvUsers_Cond.isRegister == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersEN.con_IsRegister);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersEN.con_IsRegister);
}
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_RegisterDate) == true)
{
const strComparisonOp_RegisterDate:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_RegisterDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_RegisterDate, objvUsers_Cond.registerDate, strComparisonOp_RegisterDate);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_MobilePhone) == true)
{
const strComparisonOp_MobilePhone:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_MobilePhone];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_MobilePhone, objvUsers_Cond.mobilePhone, strComparisonOp_MobilePhone);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UpdDate, objvUsers_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UpdUser, objvUsers_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_Memo, objvUsers_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_UserNameWithUserId) == true)
{
const strComparisonOp_UserNameWithUserId:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_UserNameWithUserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_UserNameWithUserId, objvUsers_Cond.userNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_OpenId) == true)
{
const strComparisonOp_OpenId:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_OpenId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_OpenId, objvUsers_Cond.openId, strComparisonOp_OpenId);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_AvatarsPicture) == true)
{
const strComparisonOp_AvatarsPicture:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_AvatarsPicture];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_AvatarsPicture, objvUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_Email) == true)
{
const strComparisonOp_Email:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_Email, objvUsers_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_PhoneNumber, objvUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_HeadPic) == true)
{
const strComparisonOp_HeadPic:string = objvUsers_Cond.dicFldComparisonOp[clsvUsersEN.con_HeadPic];
strWhereCond += Format(" And {0} {2} '{1}'", clsvUsersEN.con_HeadPic, objvUsers_Cond.headPic, strComparisonOp_HeadPic);
}
if (Object.prototype.hasOwnProperty.call(objvUsers_Cond.dicFldComparisonOp, clsvUsersEN.con_IsGSuser) == true)
{
if (objvUsers_Cond.isGSuser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvUsersEN.con_IsGSuser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvUsersEN.con_IsGSuser);
}
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvUsersENS:源对象
 * @param objvUsersENT:目标对象
*/
export function vUsers_CopyObjTo(objvUsersENS: clsvUsersEN , objvUsersENT: clsvUsersEN ): void 
{
objvUsersENT.userId = objvUsersENS.userId; //用户ID
objvUsersENT.userName = objvUsersENS.userName; //用户名
objvUsersENT.userStateId = objvUsersENS.userStateId; //用户状态Id
objvUsersENT.userStateName = objvUsersENS.userStateName; //用户状态名
objvUsersENT.password = objvUsersENS.password; //Password
objvUsersENT.isGpUser = objvUsersENS.isGpUser; //是否Gp用户
objvUsersENT.beginYearMonth = objvUsersENS.beginYearMonth; //开始年月
objvUsersENT.endYearMonth = objvUsersENS.endYearMonth; //结束年月
objvUsersENT.id_GradeBase = objvUsersENS.id_GradeBase; //年级流水号
objvUsersENT.gradeBaseName = objvUsersENS.gradeBaseName; //年级名称
objvUsersENT.id_XzCollege = objvUsersENS.id_XzCollege; //学院流水号
objvUsersENT.collegeID = objvUsersENS.collegeID; //学院ID
objvUsersENT.collegeName = objvUsersENS.collegeName; //学院名称
objvUsersENT.collegeNameA = objvUsersENS.collegeNameA; //学院名称简写
objvUsersENT.id_XzMajor = objvUsersENS.id_XzMajor; //专业流水号
objvUsersENT.majorName = objvUsersENS.majorName; //专业名称
objvUsersENT.isLeaved = objvUsersENS.isLeaved; //IsLeaved
objvUsersENT.stuIdTeacherId = objvUsersENS.stuIdTeacherId; //学工号
objvUsersENT.identityID = objvUsersENS.identityID; //身份编号
objvUsersENT.identityDesc = objvUsersENS.identityDesc; //身份描述
objvUsersENT.auditDate = objvUsersENS.auditDate; //AuditDate
objvUsersENT.auditUser = objvUsersENS.auditUser; //AuditUser
objvUsersENT.isAudit = objvUsersENS.isAudit; //是否审核
objvUsersENT.isRegister = objvUsersENS.isRegister; //IsRegister
objvUsersENT.registerDate = objvUsersENS.registerDate; //RegisterDate
objvUsersENT.mobilePhone = objvUsersENS.mobilePhone; //手机
objvUsersENT.updDate = objvUsersENS.updDate; //修改日期
objvUsersENT.updUser = objvUsersENS.updUser; //修改人
objvUsersENT.memo = objvUsersENS.memo; //备注
objvUsersENT.userNameWithUserId = objvUsersENS.userNameWithUserId; //UserNameWithUserId
objvUsersENT.openId = objvUsersENS.openId; //微信OpenId
objvUsersENT.avatarsPicture = objvUsersENS.avatarsPicture; //AvatarsPicture
objvUsersENT.email = objvUsersENS.email; //电子邮箱
objvUsersENT.phoneNumber = objvUsersENS.phoneNumber; //PhoneNumber
objvUsersENT.headPic = objvUsersENS.headPic; //头像
objvUsersENT.isGSuser = objvUsersENS.isGSuser; //是否GS用户
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvUsersENS:源对象
 * @param objvUsersENT:目标对象
*/
export function vUsers_GetObjFromJsonObj(objvUsersENS: clsvUsersEN): clsvUsersEN 
{
 const objvUsersENT: clsvUsersEN = new clsvUsersEN();
ObjectAssign(objvUsersENT, objvUsersENS);
 return objvUsersENT;
}