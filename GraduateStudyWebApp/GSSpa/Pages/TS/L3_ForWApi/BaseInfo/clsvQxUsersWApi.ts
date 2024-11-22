
 /**
 * 类名:clsvQxUsersWApi
 * 表名:vQxUsers(01120564)
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
 * vQx用户(vQxUsers)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsvQxUsersEN } from "../../L0_Entity/BaseInfo/clsvQxUsersEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vQxUsers_Controller = "vQxUsersApi";
 export const vQxUsers_ConstructorName = "vQxUsers";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strUserId:关键字
 * @returns 对象
 **/
export async function vQxUsers_GetObjByUserIdAsync(strUserId: string): Promise<clsvQxUsersEN>  
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
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvQxUsers = vQxUsers_GetObjFromJsonObj(returnObj);
return objvQxUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjByUserId_Cache(strUserId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In GetObjByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
try
{
const arrvQxUsers_Sel: Array <clsvQxUsersEN> = arrvQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
let objvQxUsers: clsvQxUsersEN;
if (arrvQxUsers_Sel.length > 0)
{
objvQxUsers = arrvQxUsers_Sel[0];
return objvQxUsers;
}
else
{
if (bolTryAsyncOnce == true)
{
objvQxUsers = await vQxUsers_GetObjByUserIdAsync(strUserId);
if (objvQxUsers != null)
{
vQxUsers_ReFreshThisCache();
return objvQxUsers;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjByUserId_localStorage(strUserId: string) {
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
const strKey = Format("{0}_{1}", clsvQxUsersEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objvQxUsers_Cache: clsvQxUsersEN = JSON.parse(strTempObj);
return objvQxUsers_Cache;
}
try
{
const objvQxUsers = await vQxUsers_GetObjByUserIdAsync(strUserId);
if (objvQxUsers != null)
{
localStorage.setItem(strKey, JSON.stringify(objvQxUsers));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objvQxUsers;
}
return objvQxUsers;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsvQxUsersEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsvQxUsersEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsvQxUsersEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strUserId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objvQxUsers = await vQxUsers_GetObjByUserId_Cache(strUserId );
if (objvQxUsers == null) return "";
return objvQxUsers.GetFldValue(strOutFldName).toString();
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
export function vQxUsers_SortFun_Defa(a:clsvQxUsersEN , b:clsvQxUsersEN): number 
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
export function vQxUsers_SortFun_Defa_2Fld(a:clsvQxUsersEN , b:clsvQxUsersEN): number 
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
export function vQxUsers_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvQxUsersEN.con_UserId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.userId.localeCompare(b.userId);
}
case clsvQxUsersEN.con_UserName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.userName.localeCompare(b.userName);
}
case clsvQxUsersEN.con_UserStateId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.userStateId.localeCompare(b.userStateId);
}
case clsvQxUsersEN.con_Memo:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvQxUsersEN.con_UserStateName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.userStateName.localeCompare(b.userStateName);
}
case clsvQxUsersEN.con_DepartmentId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.departmentId.localeCompare(b.departmentId);
}
case clsvQxUsersEN.con_UpDepartmentId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.upDepartmentId.localeCompare(b.upDepartmentId);
}
case clsvQxUsersEN.con_DepartmentName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.departmentName.localeCompare(b.departmentName);
}
case clsvQxUsersEN.con_UpDepartmentName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.upDepartmentName.localeCompare(b.upDepartmentName);
}
case clsvQxUsersEN.con_DepartmentTypeName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.departmentTypeName.localeCompare(b.departmentTypeName);
}
case clsvQxUsersEN.con_DepartmentTypeId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.departmentTypeId.localeCompare(b.departmentTypeId);
}
case clsvQxUsersEN.con_DepartmentAbbrName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.departmentAbbrName.localeCompare(b.departmentAbbrName);
}
case clsvQxUsersEN.con_EffectiveDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.effectiveDate.localeCompare(b.effectiveDate);
}
case clsvQxUsersEN.con_UpdDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsvQxUsersEN.con_UpdUser:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsvQxUsersEN.con_EffitiveBeginDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.effitiveBeginDate.localeCompare(b.effitiveBeginDate);
}
case clsvQxUsersEN.con_EffitiveEndDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.effitiveEndDate.localeCompare(b.effitiveEndDate);
}
case clsvQxUsersEN.con_StuTeacherID:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.stuTeacherID.localeCompare(b.stuTeacherID);
}
case clsvQxUsersEN.con_IdentityID:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.identityID.localeCompare(b.identityID);
}
case clsvQxUsersEN.con_Password:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.password.localeCompare(b.password);
}
case clsvQxUsersEN.con_IdentityDesc:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.identityDesc.localeCompare(b.identityDesc);
}
case clsvQxUsersEN.con_IsSynch:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
if (a.isSynch == true) return 1;
else return -1
}
case clsvQxUsersEN.con_SynchDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.synchDate.localeCompare(b.synchDate);
}
case clsvQxUsersEN.con_OpenId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.openId.localeCompare(b.openId);
}
case clsvQxUsersEN.con_NickName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.nickName.localeCompare(b.nickName);
}
case clsvQxUsersEN.con_headimgUrl:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.headimgUrl.localeCompare(b.headimgUrl);
}
case clsvQxUsersEN.con_CollegeName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvQxUsersEN.con_id_XzCollege:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvQxUsersEN.con_id_XzMajor:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvQxUsersEN.con_MajorName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.majorName.localeCompare(b.majorName);
}
case clsvQxUsersEN.con_Email:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.email.localeCompare(b.email);
}
case clsvQxUsersEN.con_id_College:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return a.id_College.localeCompare(b.id_College);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${ vQxUsers_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvQxUsersEN.con_UserId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.userId.localeCompare(a.userId);
}
case clsvQxUsersEN.con_UserName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.userName.localeCompare(a.userName);
}
case clsvQxUsersEN.con_UserStateId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.userStateId.localeCompare(a.userStateId);
}
case clsvQxUsersEN.con_Memo:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvQxUsersEN.con_UserStateName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.userStateName.localeCompare(a.userStateName);
}
case clsvQxUsersEN.con_DepartmentId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.departmentId.localeCompare(a.departmentId);
}
case clsvQxUsersEN.con_UpDepartmentId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.upDepartmentId.localeCompare(a.upDepartmentId);
}
case clsvQxUsersEN.con_DepartmentName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.departmentName.localeCompare(a.departmentName);
}
case clsvQxUsersEN.con_UpDepartmentName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.upDepartmentName.localeCompare(a.upDepartmentName);
}
case clsvQxUsersEN.con_DepartmentTypeName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.departmentTypeName.localeCompare(a.departmentTypeName);
}
case clsvQxUsersEN.con_DepartmentTypeId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.departmentTypeId.localeCompare(a.departmentTypeId);
}
case clsvQxUsersEN.con_DepartmentAbbrName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.departmentAbbrName.localeCompare(a.departmentAbbrName);
}
case clsvQxUsersEN.con_EffectiveDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.effectiveDate.localeCompare(a.effectiveDate);
}
case clsvQxUsersEN.con_UpdDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsvQxUsersEN.con_UpdUser:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsvQxUsersEN.con_EffitiveBeginDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.effitiveBeginDate.localeCompare(a.effitiveBeginDate);
}
case clsvQxUsersEN.con_EffitiveEndDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.effitiveEndDate.localeCompare(a.effitiveEndDate);
}
case clsvQxUsersEN.con_StuTeacherID:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.stuTeacherID.localeCompare(a.stuTeacherID);
}
case clsvQxUsersEN.con_IdentityID:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.identityID.localeCompare(a.identityID);
}
case clsvQxUsersEN.con_Password:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.password.localeCompare(a.password);
}
case clsvQxUsersEN.con_IdentityDesc:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.identityDesc.localeCompare(a.identityDesc);
}
case clsvQxUsersEN.con_IsSynch:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
if (b.isSynch == true) return 1;
else return -1
}
case clsvQxUsersEN.con_SynchDate:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.synchDate.localeCompare(a.synchDate);
}
case clsvQxUsersEN.con_OpenId:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.openId.localeCompare(a.openId);
}
case clsvQxUsersEN.con_NickName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.nickName.localeCompare(a.nickName);
}
case clsvQxUsersEN.con_headimgUrl:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.headimgUrl.localeCompare(a.headimgUrl);
}
case clsvQxUsersEN.con_CollegeName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvQxUsersEN.con_id_XzCollege:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvQxUsersEN.con_id_XzMajor:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvQxUsersEN.con_MajorName:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.majorName.localeCompare(a.majorName);
}
case clsvQxUsersEN.con_Email:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.email.localeCompare(a.email);
}
case clsvQxUsersEN.con_id_College:
return (a: clsvQxUsersEN, b: clsvQxUsersEN) => {
return b.id_College.localeCompare(a.id_College);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${ vQxUsers_ConstructorName}.${ strThisFuncName})`;
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
export async function vQxUsers_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvQxUsersEN.con_UserId:
return (obj: clsvQxUsersEN) => {
return obj.userId === value;
}
case clsvQxUsersEN.con_UserName:
return (obj: clsvQxUsersEN) => {
return obj.userName === value;
}
case clsvQxUsersEN.con_UserStateId:
return (obj: clsvQxUsersEN) => {
return obj.userStateId === value;
}
case clsvQxUsersEN.con_Memo:
return (obj: clsvQxUsersEN) => {
return obj.memo === value;
}
case clsvQxUsersEN.con_UserStateName:
return (obj: clsvQxUsersEN) => {
return obj.userStateName === value;
}
case clsvQxUsersEN.con_DepartmentId:
return (obj: clsvQxUsersEN) => {
return obj.departmentId === value;
}
case clsvQxUsersEN.con_UpDepartmentId:
return (obj: clsvQxUsersEN) => {
return obj.upDepartmentId === value;
}
case clsvQxUsersEN.con_DepartmentName:
return (obj: clsvQxUsersEN) => {
return obj.departmentName === value;
}
case clsvQxUsersEN.con_UpDepartmentName:
return (obj: clsvQxUsersEN) => {
return obj.upDepartmentName === value;
}
case clsvQxUsersEN.con_DepartmentTypeName:
return (obj: clsvQxUsersEN) => {
return obj.departmentTypeName === value;
}
case clsvQxUsersEN.con_DepartmentTypeId:
return (obj: clsvQxUsersEN) => {
return obj.departmentTypeId === value;
}
case clsvQxUsersEN.con_DepartmentAbbrName:
return (obj: clsvQxUsersEN) => {
return obj.departmentAbbrName === value;
}
case clsvQxUsersEN.con_EffectiveDate:
return (obj: clsvQxUsersEN) => {
return obj.effectiveDate === value;
}
case clsvQxUsersEN.con_UpdDate:
return (obj: clsvQxUsersEN) => {
return obj.updDate === value;
}
case clsvQxUsersEN.con_UpdUser:
return (obj: clsvQxUsersEN) => {
return obj.updUser === value;
}
case clsvQxUsersEN.con_EffitiveBeginDate:
return (obj: clsvQxUsersEN) => {
return obj.effitiveBeginDate === value;
}
case clsvQxUsersEN.con_EffitiveEndDate:
return (obj: clsvQxUsersEN) => {
return obj.effitiveEndDate === value;
}
case clsvQxUsersEN.con_StuTeacherID:
return (obj: clsvQxUsersEN) => {
return obj.stuTeacherID === value;
}
case clsvQxUsersEN.con_IdentityID:
return (obj: clsvQxUsersEN) => {
return obj.identityID === value;
}
case clsvQxUsersEN.con_Password:
return (obj: clsvQxUsersEN) => {
return obj.password === value;
}
case clsvQxUsersEN.con_IdentityDesc:
return (obj: clsvQxUsersEN) => {
return obj.identityDesc === value;
}
case clsvQxUsersEN.con_IsSynch:
return (obj: clsvQxUsersEN) => {
return obj.isSynch === value;
}
case clsvQxUsersEN.con_SynchDate:
return (obj: clsvQxUsersEN) => {
return obj.synchDate === value;
}
case clsvQxUsersEN.con_OpenId:
return (obj: clsvQxUsersEN) => {
return obj.openId === value;
}
case clsvQxUsersEN.con_NickName:
return (obj: clsvQxUsersEN) => {
return obj.nickName === value;
}
case clsvQxUsersEN.con_headimgUrl:
return (obj: clsvQxUsersEN) => {
return obj.headimgUrl === value;
}
case clsvQxUsersEN.con_CollegeName:
return (obj: clsvQxUsersEN) => {
return obj.collegeName === value;
}
case clsvQxUsersEN.con_id_XzCollege:
return (obj: clsvQxUsersEN) => {
return obj.id_XzCollege === value;
}
case clsvQxUsersEN.con_id_XzMajor:
return (obj: clsvQxUsersEN) => {
return obj.id_XzMajor === value;
}
case clsvQxUsersEN.con_MajorName:
return (obj: clsvQxUsersEN) => {
return obj.majorName === value;
}
case clsvQxUsersEN.con_Email:
return (obj: clsvQxUsersEN) => {
return obj.email === value;
}
case clsvQxUsersEN.con_id_College:
return (obj: clsvQxUsersEN) => {
return obj.id_College === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vQxUsers]中不存在！(in ${ vQxUsers_ConstructorName}.${ strThisFuncName})`;
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
export async function vQxUsers_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetFirstObjAsync(strWhereCond: string): Promise<clsvQxUsersEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvQxUsers = vQxUsers_GetObjFromJsonObj(returnObj);
return objvQxUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvQxUsersEN._CurrTabName;
clsvQxUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvQxUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvQxUsersEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrvQxUsersExObjLst_Cache: Array<clsvQxUsersEN> = CacheHelper.Get(strKey);
const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
return arrvQxUsersObjLst_T;
}
try
{
const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrvQxUsersExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
console.log(strInfo);
return arrvQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vQxUsers_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvQxUsersEN._CurrTabName;
clsvQxUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvQxUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvQxUsersEN.CacheAddiCondition);
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
const arrvQxUsersExObjLst_Cache: Array<clsvQxUsersEN> = JSON.parse(strTempObjLst);
const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
return arrvQxUsersObjLst_T;
}
try
{
const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrvQxUsersExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
console.log(strInfo);
return arrvQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vQxUsers_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvQxUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrvQxUsersObjLst_Cache: Array<clsvQxUsersEN> = JSON.parse(strTempObjLst);
return arrvQxUsersObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function vQxUsers_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvQxUsersEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsvQxUsersEN._CurrTabName;
clsvQxUsersEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsvQxUsersEN._CurrTabName);
if (IsNullOrEmpty(clsvQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsvQxUsersEN.CacheAddiCondition);
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
const arrvQxUsersExObjLst_Cache: Array<clsvQxUsersEN> = JSON.parse(strTempObjLst);
const arrvQxUsersObjLst_T = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersExObjLst_Cache);
return arrvQxUsersObjLst_T;
}
try
{
const arrvQxUsersExObjLst = await vQxUsers_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrvQxUsersExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQxUsersExObjLst.length);
console.log(strInfo);
return arrvQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vQxUsers_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsvQxUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrvQxUsersObjLst_Cache: Array<clsvQxUsersEN> = JSON.parse(strTempObjLst);
return arrvQxUsersObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vQxUsers_GetObjLst_Cache(): Promise<Array<clsvQxUsersEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrvQxUsersObjLst_Cache;
switch (clsvQxUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_ClientCache();
break;
default:
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_ClientCache();
break;
}
const arrvQxUsersObjLst = vQxUsers_GetObjLstByJSONObjLst(arrvQxUsersObjLst_Cache);
return arrvQxUsersObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function vQxUsers_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrvQxUsersObjLst_Cache;
switch (clsvQxUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrvQxUsersObjLst_Cache = null;
break;
default:
arrvQxUsersObjLst_Cache = null;
break;
}
return arrvQxUsersObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function vQxUsers_GetSubObjLst_Cache(objvQxUsers_Cond: clsvQxUsersEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
let arrvQxUsers_Sel: Array < clsvQxUsersEN > = arrvQxUsersObjLst_Cache;
if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "") return arrvQxUsers_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvQxUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objvQxUsers_Cond), vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvQxUsersEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrUserId:关键字列表
 * @returns 对象列表
 **/
export async function vQxUsers_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsvQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByUserIdLstAsync";
const strAction = "GetObjLstByUserIdLst";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByUserIdLst_Cache";
try
{
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
const arrvQxUsers_Sel: Array <clsvQxUsersEN> = arrvQxUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId)>-1);
return arrvQxUsers_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvQxUsersEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function vQxUsers_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvQxUsersEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
if (arrvQxUsersObjLst_Cache.length == 0) return arrvQxUsersObjLst_Cache;
let arrvQxUsers_Sel = arrvQxUsersObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objvQxUsers_Cond = new clsvQxUsersEN();
ObjectAssign(objvQxUsers_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsvQxUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvQxUsers_Sel.length == 0) return arrvQxUsers_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrvQxUsers_Sel = arrvQxUsers_Sel.sort(vQxUsers_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrvQxUsers_Sel = arrvQxUsers_Sel.sort(objPagerPara.sortFun);
}
arrvQxUsers_Sel = arrvQxUsers_Sel.slice(intStart, intEnd);     
return arrvQxUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, vQxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsvQxUsersEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function vQxUsers_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vQxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vQxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_IsExistRecord_Cache(objvQxUsers_Cond: clsvQxUsersEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
if (arrvQxUsersObjLst_Cache == null) return false;
let arrvQxUsers_Sel: Array < clsvQxUsersEN > = arrvQxUsersObjLst_Cache;
if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "") return arrvQxUsers_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrvQxUsers_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objvQxUsers_Cond), vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_IsExist_Cache(strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
if (arrvQxUsersObjLst_Cache == null) return false;
try
{
const arrvQxUsers_Sel: Array <clsvQxUsersEN> = arrvQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
if (arrvQxUsers_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_IsExistAsync(strUserId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
export async function vQxUsers_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vQxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vQxUsers_ConstructorName, strThisFuncName);
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
 * @param objvQxUsers_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function vQxUsers_GetRecCountByCond_Cache(objvQxUsers_Cond: clsvQxUsersEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrvQxUsersObjLst_Cache = await vQxUsers_GetObjLst_Cache();
if (arrvQxUsersObjLst_Cache == null) return 0;
let arrvQxUsers_Sel: Array < clsvQxUsersEN > = arrvQxUsersObjLst_Cache;
if (objvQxUsers_Cond.sf_FldComparisonOp == null || objvQxUsers_Cond.sf_FldComparisonOp == "") return arrvQxUsers_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objvQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsvQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objvQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objvQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrvQxUsers_Sel = arrvQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrvQxUsers_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objvQxUsers_Cond), vQxUsers_ConstructorName, strThisFuncName);
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
export function vQxUsers_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vQxUsers_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsvQxUsersEN._CurrTabName;
switch (clsvQxUsersEN.CacheModeId)
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
export function vQxUsers_GetJSONStrByObj (pobjvQxUsersEN: clsvQxUsersEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvQxUsersEN);
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
export function vQxUsers_GetObjLstByJSONStr (strJSON: string): Array<clsvQxUsersEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvQxUsersObjLst = new Array<clsvQxUsersEN>();
if (strJSON === "")
{
return arrvQxUsersObjLst;
}
try
{
arrvQxUsersObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvQxUsersObjLst;
}
return arrvQxUsersObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvQxUsersObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vQxUsers_GetObjLstByJSONObjLst (arrvQxUsersObjLstS: Array<clsvQxUsersEN>): Array<clsvQxUsersEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvQxUsersObjLst = new Array<clsvQxUsersEN>();
for (const objInFor of arrvQxUsersObjLstS) {
const obj1 = vQxUsers_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvQxUsersObjLst.push(obj1);
}
return arrvQxUsersObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vQxUsers_GetObjByJSONStr (strJSON: string): clsvQxUsersEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvQxUsersEN = new clsvQxUsersEN();
if (strJSON === "")
{
return pobjvQxUsersEN;
}
try
{
pobjvQxUsersEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvQxUsersEN;
}
return pobjvQxUsersEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vQxUsers_GetCombineCondition(objvQxUsers_Cond: clsvQxUsersEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UserId, objvQxUsers_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UserName, objvQxUsers_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UserStateId) == true)
{
const strComparisonOp_UserStateId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UserStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UserStateId, objvQxUsers_Cond.userStateId, strComparisonOp_UserStateId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_Memo, objvQxUsers_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UserStateName) == true)
{
const strComparisonOp_UserStateName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UserStateName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UserStateName, objvQxUsers_Cond.userStateName, strComparisonOp_UserStateName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_DepartmentId) == true)
{
const strComparisonOp_DepartmentId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_DepartmentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_DepartmentId, objvQxUsers_Cond.departmentId, strComparisonOp_DepartmentId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UpDepartmentId) == true)
{
const strComparisonOp_UpDepartmentId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UpDepartmentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UpDepartmentId, objvQxUsers_Cond.upDepartmentId, strComparisonOp_UpDepartmentId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_DepartmentName) == true)
{
const strComparisonOp_DepartmentName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_DepartmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_DepartmentName, objvQxUsers_Cond.departmentName, strComparisonOp_DepartmentName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UpDepartmentName) == true)
{
const strComparisonOp_UpDepartmentName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UpDepartmentName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UpDepartmentName, objvQxUsers_Cond.upDepartmentName, strComparisonOp_UpDepartmentName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_DepartmentTypeName) == true)
{
const strComparisonOp_DepartmentTypeName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_DepartmentTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_DepartmentTypeName, objvQxUsers_Cond.departmentTypeName, strComparisonOp_DepartmentTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_DepartmentTypeId) == true)
{
const strComparisonOp_DepartmentTypeId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_DepartmentTypeId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_DepartmentTypeId, objvQxUsers_Cond.departmentTypeId, strComparisonOp_DepartmentTypeId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_DepartmentAbbrName) == true)
{
const strComparisonOp_DepartmentAbbrName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_DepartmentAbbrName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_DepartmentAbbrName, objvQxUsers_Cond.departmentAbbrName, strComparisonOp_DepartmentAbbrName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_EffectiveDate) == true)
{
const strComparisonOp_EffectiveDate:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_EffectiveDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_EffectiveDate, objvQxUsers_Cond.effectiveDate, strComparisonOp_EffectiveDate);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UpdDate, objvQxUsers_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_UpdUser, objvQxUsers_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_EffitiveBeginDate) == true)
{
const strComparisonOp_EffitiveBeginDate:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_EffitiveBeginDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_EffitiveBeginDate, objvQxUsers_Cond.effitiveBeginDate, strComparisonOp_EffitiveBeginDate);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_EffitiveEndDate) == true)
{
const strComparisonOp_EffitiveEndDate:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_EffitiveEndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_EffitiveEndDate, objvQxUsers_Cond.effitiveEndDate, strComparisonOp_EffitiveEndDate);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_StuTeacherID) == true)
{
const strComparisonOp_StuTeacherID:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_StuTeacherID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_StuTeacherID, objvQxUsers_Cond.stuTeacherID, strComparisonOp_StuTeacherID);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_IdentityID) == true)
{
const strComparisonOp_IdentityID:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_IdentityID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_IdentityID, objvQxUsers_Cond.identityID, strComparisonOp_IdentityID);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_Password) == true)
{
const strComparisonOp_Password:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_Password];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_Password, objvQxUsers_Cond.password, strComparisonOp_Password);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_IdentityDesc) == true)
{
const strComparisonOp_IdentityDesc:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_IdentityDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_IdentityDesc, objvQxUsers_Cond.identityDesc, strComparisonOp_IdentityDesc);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_IsSynch) == true)
{
if (objvQxUsers_Cond.isSynch == true)
{
strWhereCond += Format(" And {0} = '1'", clsvQxUsersEN.con_IsSynch);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvQxUsersEN.con_IsSynch);
}
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_SynchDate) == true)
{
const strComparisonOp_SynchDate:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_SynchDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_SynchDate, objvQxUsers_Cond.synchDate, strComparisonOp_SynchDate);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_OpenId) == true)
{
const strComparisonOp_OpenId:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_OpenId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_OpenId, objvQxUsers_Cond.openId, strComparisonOp_OpenId);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_NickName) == true)
{
const strComparisonOp_NickName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_NickName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_NickName, objvQxUsers_Cond.nickName, strComparisonOp_NickName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_headimgUrl) == true)
{
const strComparisonOp_headimgUrl:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_headimgUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_headimgUrl, objvQxUsers_Cond.headimgUrl, strComparisonOp_headimgUrl);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_CollegeName, objvQxUsers_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_id_XzCollege, objvQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_id_XzMajor, objvQxUsers_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_MajorName) == true)
{
const strComparisonOp_MajorName:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_MajorName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_MajorName, objvQxUsers_Cond.majorName, strComparisonOp_MajorName);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_Email) == true)
{
const strComparisonOp_Email:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_Email, objvQxUsers_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objvQxUsers_Cond.dicFldComparisonOp, clsvQxUsersEN.con_id_College) == true)
{
const strComparisonOp_id_College:string = objvQxUsers_Cond.dicFldComparisonOp[clsvQxUsersEN.con_id_College];
strWhereCond += Format(" And {0} {2} '{1}'", clsvQxUsersEN.con_id_College, objvQxUsers_Cond.id_College, strComparisonOp_id_College);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvQxUsersENS:源对象
 * @param objvQxUsersENT:目标对象
*/
export function vQxUsers_CopyObjTo(objvQxUsersENS: clsvQxUsersEN , objvQxUsersENT: clsvQxUsersEN ): void 
{
objvQxUsersENT.userId = objvQxUsersENS.userId; //用户ID
objvQxUsersENT.userName = objvQxUsersENS.userName; //用户名
objvQxUsersENT.userStateId = objvQxUsersENS.userStateId; //用户状态Id
objvQxUsersENT.memo = objvQxUsersENS.memo; //备注
objvQxUsersENT.userStateName = objvQxUsersENS.userStateName; //用户状态名
objvQxUsersENT.departmentId = objvQxUsersENS.departmentId; //部门Id
objvQxUsersENT.upDepartmentId = objvQxUsersENS.upDepartmentId; //UpDepartmentId
objvQxUsersENT.departmentName = objvQxUsersENS.departmentName; //部门名称
objvQxUsersENT.upDepartmentName = objvQxUsersENS.upDepartmentName; //UpDepartmentName
objvQxUsersENT.departmentTypeName = objvQxUsersENS.departmentTypeName; //DepartmentTypeName
objvQxUsersENT.departmentTypeId = objvQxUsersENS.departmentTypeId; //DepartmentTypeId
objvQxUsersENT.departmentAbbrName = objvQxUsersENS.departmentAbbrName; //DepartmentAbbrName
objvQxUsersENT.effectiveDate = objvQxUsersENS.effectiveDate; //EffectiveDate
objvQxUsersENT.updDate = objvQxUsersENS.updDate; //修改日期
objvQxUsersENT.updUser = objvQxUsersENS.updUser; //修改人
objvQxUsersENT.effitiveBeginDate = objvQxUsersENS.effitiveBeginDate; //EffitiveBeginDate
objvQxUsersENT.effitiveEndDate = objvQxUsersENS.effitiveEndDate; //EffitiveEndDate
objvQxUsersENT.stuTeacherID = objvQxUsersENS.stuTeacherID; //学工号
objvQxUsersENT.identityID = objvQxUsersENS.identityID; //身份编号
objvQxUsersENT.password = objvQxUsersENS.password; //Password
objvQxUsersENT.identityDesc = objvQxUsersENS.identityDesc; //身份描述
objvQxUsersENT.isSynch = objvQxUsersENS.isSynch; //是否同步
objvQxUsersENT.synchDate = objvQxUsersENS.synchDate; //同步日期
objvQxUsersENT.openId = objvQxUsersENS.openId; //微信OpenId
objvQxUsersENT.nickName = objvQxUsersENS.nickName; //昵称
objvQxUsersENT.headimgUrl = objvQxUsersENS.headimgUrl; //微信头像
objvQxUsersENT.collegeName = objvQxUsersENS.collegeName; //学院名称
objvQxUsersENT.id_XzCollege = objvQxUsersENS.id_XzCollege; //学院流水号
objvQxUsersENT.id_XzMajor = objvQxUsersENS.id_XzMajor; //专业流水号
objvQxUsersENT.majorName = objvQxUsersENS.majorName; //专业名称
objvQxUsersENT.email = objvQxUsersENS.email; //电子邮箱
objvQxUsersENT.id_College = objvQxUsersENS.id_College; //学院流水号
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvQxUsersENS:源对象
 * @param objvQxUsersENT:目标对象
*/
export function vQxUsers_GetObjFromJsonObj(objvQxUsersENS: clsvQxUsersEN): clsvQxUsersEN 
{
 const objvQxUsersENT: clsvQxUsersEN = new clsvQxUsersEN();
ObjectAssign(objvQxUsersENT, objvQxUsersENS);
 return objvQxUsersENT;
}