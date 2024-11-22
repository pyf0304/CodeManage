
 /**
 * 类名:clsQxUsersWApi
 * 表名:QxUsers(01120258)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:34
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
 * Qx用户(QxUsers)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2023年03月13日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { enumComparisonOp } from "../../PubFun/enumComparisonOp.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { clsQxUsersEN } from "../../L0_Entity/BaseInfo/clsQxUsersEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubConfig/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { tzDataType } from "../../PubFun/clsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const qxUsers_Controller = "QxUsersApi";
 export const qxUsers_ConstructorName = "qxUsers";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strUserId:关键字
 * @returns 对象
 **/
export async function QxUsers_GetObjByUserIdAsync(strUserId: string): Promise<clsQxUsersEN|null>  
{
const strThisFuncName = "GetObjByUserIdAsync";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserIdAsync)");
console.error(strMsg);
 throw (strMsg);
}
const strAction = "GetObjByUserId";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
return null;
}
//console.log(returnObj);
const objQxUsers = QxUsers_GetObjFromJsonObj(returnObj);
return objQxUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjByUserId_Cache(strUserId: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByUserId_Cache";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserId_Cache)");
console.error(strMsg);
 throw (strMsg);
}
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
try
{
const arrQxUsers_Sel: Array <clsQxUsersEN> = arrQxUsersObjLst_Cache.filter(x => 
 x.userId == strUserId );
let objQxUsers: clsQxUsersEN;
if (arrQxUsers_Sel.length > 0)
{
objQxUsers = arrQxUsers_Sel[0];
return objQxUsers;
}
else
{
if (bolTryAsyncOnce == true)
{
const objQxUsers_Const = await QxUsers_GetObjByUserIdAsync(strUserId);
if (objQxUsers_Const != null)
{
QxUsers_ReFreshThisCache();
return objQxUsers_Const;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjByUserId_localStorage(strUserId: string) {
const strThisFuncName = "GetObjByUserId_localStorage";

if (IsNullOrEmpty(strUserId) == true)
{
  const strMsg = Format("参数:[strUserId]不能为空！(In clsQxUsersWApi.GetObjByUserId_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
const strKey = Format("{0}_{1}", clsQxUsersEN._CurrTabName, strUserId);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objQxUsers_Cache: clsQxUsersEN = JSON.parse(strTempObj);
return objQxUsers_Cache;
}
try
{
const objQxUsers = await QxUsers_GetObjByUserIdAsync(strUserId);
if (objQxUsers != null)
{
localStorage.setItem(strKey, JSON.stringify(objQxUsers));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objQxUsers;
}
return objQxUsers;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strUserId, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objQxUsers:所给的对象
 * @returns 对象
*/
export async function QxUsers_UpdateObjInLst_Cache(objQxUsers: clsQxUsersEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
const obj = arrQxUsersObjLst_Cache.find(x => 
x.userId == objQxUsers.userId);
if (obj != null)
{
objQxUsers.userId = obj.userId;
ObjectAssign( obj, objQxUsers);
}
else
{
arrQxUsersObjLst_Cache.push(objQxUsers);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}
/*该表没有名称字段，不能生成此函数！*/

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
 * @param strInFldName:输入字段名
 * @param strOutFldName:输出字段名
 * @param strInValue:输入字段值
 * @returns 返回一个输出字段值
*/
export async function QxUsers_func(strInFldName:string , strOutFldName:string , strInValue:string )
{
//const strThisFuncName = "func";

if (strInFldName != clsQxUsersEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsQxUsersEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strOutFldName, clsQxUsersEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strUserId = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objQxUsers = await QxUsers_GetObjByUserId_Cache(strUserId );
if (objQxUsers == null) return "";
if (objQxUsers.GetFldValue(strOutFldName) == null) return "";
return objQxUsers.GetFldValue(strOutFldName).toString();
}

/**
 * 排序函数。根据关键字字段的值进行比较
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
 * @param a:比较的第1个对象
 * @param  b:比较的第1个对象
 * @returns 返回两个对象比较的结果
*/
export function QxUsers_SortFun_Defa(a:clsQxUsersEN , b:clsQxUsersEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.userId.localeCompare(b.userId);
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
export function QxUsers_SortFun_Defa_2Fld(a:clsQxUsersEN , b:clsQxUsersEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.userName == b.userName) return a.departmentId.localeCompare(b.departmentId);
else return a.userName.localeCompare(b.userName);
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
export function QxUsers_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsQxUsersEN.con_UserId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.userId.localeCompare(b.userId);
}
case clsQxUsersEN.con_UserName:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.userName.localeCompare(b.userName);
}
case clsQxUsersEN.con_DepartmentId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.departmentId == null) return -1;
if (b.departmentId == null) return 1;
return a.departmentId.localeCompare(b.departmentId);
}
case clsQxUsersEN.con_id_XzCollege:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.id_XzCollege == null) return -1;
if (b.id_XzCollege == null) return 1;
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsQxUsersEN.con_UserStateId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.userStateId.localeCompare(b.userStateId);
}
case clsQxUsersEN.con_id_GradeBase:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.id_GradeBase == null) return -1;
if (b.id_GradeBase == null) return 1;
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsQxUsersEN.con_Card_State:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.card_State == null) return -1;
if (b.card_State == null) return 1;
return a.card_State.localeCompare(b.card_State);
}
case clsQxUsersEN.con_IsLeaved:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.isLeaved == true) return 1;
else return -1
}
case clsQxUsersEN.con_CardNo:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.cardNo == null) return -1;
if (b.cardNo == null) return 1;
return a.cardNo.localeCompare(b.cardNo);
}
case clsQxUsersEN.con_BeginYearMonth:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.beginYearMonth == null) return -1;
if (b.beginYearMonth == null) return 1;
return a.beginYearMonth.localeCompare(b.beginYearMonth);
}
case clsQxUsersEN.con_EndYearMonth:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.endYearMonth == null) return -1;
if (b.endYearMonth == null) return 1;
return a.endYearMonth.localeCompare(b.endYearMonth);
}
case clsQxUsersEN.con_OptUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.optUser == null) return -1;
if (b.optUser == null) return 1;
return a.optUser.localeCompare(b.optUser);
}
case clsQxUsersEN.con_OptDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.optDate == null) return -1;
if (b.optDate == null) return 1;
return a.optDate.localeCompare(b.optDate);
}
case clsQxUsersEN.con_Memo:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.memo == null) return -1;
if (b.memo == null) return 1;
return a.memo.localeCompare(b.memo);
}
case clsQxUsersEN.con_Password:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.password == null) return -1;
if (b.password == null) return 1;
return a.password.localeCompare(b.password);
}
case clsQxUsersEN.con_IsGpUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsQxUsersEN.con_SchoolID1:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.schoolID1 == null) return -1;
if (b.schoolID1 == null) return 1;
return a.schoolID1.localeCompare(b.schoolID1);
}
case clsQxUsersEN.con_AvatarsPicture:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.avatarsPicture == null) return -1;
if (b.avatarsPicture == null) return 1;
return a.avatarsPicture.localeCompare(b.avatarsPicture);
}
case clsQxUsersEN.con_Email:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.email == null) return -1;
if (b.email == null) return 1;
return a.email.localeCompare(b.email);
}
case clsQxUsersEN.con_PhoneNumber:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.phoneNumber == null) return -1;
if (b.phoneNumber == null) return 1;
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsQxUsersEN.con_EffectiveDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.effectiveDate == null) return -1;
if (b.effectiveDate == null) return 1;
return a.effectiveDate.localeCompare(b.effectiveDate);
}
case clsQxUsersEN.con_UpdDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.updDate == null) return -1;
if (b.updDate == null) return 1;
return a.updDate.localeCompare(b.updDate);
}
case clsQxUsersEN.con_UpdUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.updUser == null) return -1;
if (b.updUser == null) return 1;
return a.updUser.localeCompare(b.updUser);
}
case clsQxUsersEN.con_EffitiveBeginDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.effitiveBeginDate.localeCompare(b.effitiveBeginDate);
}
case clsQxUsersEN.con_EffitiveEndDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.effitiveEndDate.localeCompare(b.effitiveEndDate);
}
case clsQxUsersEN.con_id_College:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.id_College.localeCompare(b.id_College);
}
case clsQxUsersEN.con_StuTeacherID:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return a.stuTeacherID.localeCompare(b.stuTeacherID);
}
case clsQxUsersEN.con_IdentityID:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.identityID == null) return -1;
if (b.identityID == null) return 1;
return a.identityID.localeCompare(b.identityID);
}
case clsQxUsersEN.con_IsArchive:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.isArchive == true) return 1;
else return -1
}
case clsQxUsersEN.con_HeadimgUrl:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.headimgUrl == null) return -1;
if (b.headimgUrl == null) return 1;
return a.headimgUrl.localeCompare(b.headimgUrl);
}
case clsQxUsersEN.con_OpenId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.openId == null) return -1;
if (b.openId == null) return 1;
return a.openId.localeCompare(b.openId);
}
case clsQxUsersEN.con_NickName:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.nickName == null) return -1;
if (b.nickName == null) return 1;
return a.nickName.localeCompare(b.nickName);
}
case clsQxUsersEN.con_IsSynch:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.isSynch == true) return 1;
else return -1
}
case clsQxUsersEN.con_SynchDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (a.synchDate == null) return -1;
if (b.synchDate == null) return 1;
return a.synchDate.localeCompare(b.synchDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${ qxUsers_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsQxUsersEN.con_UserId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.userId.localeCompare(a.userId);
}
case clsQxUsersEN.con_UserName:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.userName.localeCompare(a.userName);
}
case clsQxUsersEN.con_DepartmentId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.departmentId == null) return -1;
if (a.departmentId == null) return 1;
return b.departmentId.localeCompare(a.departmentId);
}
case clsQxUsersEN.con_id_XzCollege:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.id_XzCollege == null) return -1;
if (a.id_XzCollege == null) return 1;
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsQxUsersEN.con_UserStateId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.userStateId.localeCompare(a.userStateId);
}
case clsQxUsersEN.con_id_GradeBase:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.id_GradeBase == null) return -1;
if (a.id_GradeBase == null) return 1;
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsQxUsersEN.con_Card_State:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.card_State == null) return -1;
if (a.card_State == null) return 1;
return b.card_State.localeCompare(a.card_State);
}
case clsQxUsersEN.con_IsLeaved:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.isLeaved == true) return 1;
else return -1
}
case clsQxUsersEN.con_CardNo:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.cardNo == null) return -1;
if (a.cardNo == null) return 1;
return b.cardNo.localeCompare(a.cardNo);
}
case clsQxUsersEN.con_BeginYearMonth:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.beginYearMonth == null) return -1;
if (a.beginYearMonth == null) return 1;
return b.beginYearMonth.localeCompare(a.beginYearMonth);
}
case clsQxUsersEN.con_EndYearMonth:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.endYearMonth == null) return -1;
if (a.endYearMonth == null) return 1;
return b.endYearMonth.localeCompare(a.endYearMonth);
}
case clsQxUsersEN.con_OptUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.optUser == null) return -1;
if (a.optUser == null) return 1;
return b.optUser.localeCompare(a.optUser);
}
case clsQxUsersEN.con_OptDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.optDate == null) return -1;
if (a.optDate == null) return 1;
return b.optDate.localeCompare(a.optDate);
}
case clsQxUsersEN.con_Memo:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.memo == null) return -1;
if (a.memo == null) return 1;
return b.memo.localeCompare(a.memo);
}
case clsQxUsersEN.con_Password:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.password == null) return -1;
if (a.password == null) return 1;
return b.password.localeCompare(a.password);
}
case clsQxUsersEN.con_IsGpUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsQxUsersEN.con_SchoolID1:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.schoolID1 == null) return -1;
if (a.schoolID1 == null) return 1;
return b.schoolID1.localeCompare(a.schoolID1);
}
case clsQxUsersEN.con_AvatarsPicture:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.avatarsPicture == null) return -1;
if (a.avatarsPicture == null) return 1;
return b.avatarsPicture.localeCompare(a.avatarsPicture);
}
case clsQxUsersEN.con_Email:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.email == null) return -1;
if (a.email == null) return 1;
return b.email.localeCompare(a.email);
}
case clsQxUsersEN.con_PhoneNumber:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.phoneNumber == null) return -1;
if (a.phoneNumber == null) return 1;
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsQxUsersEN.con_EffectiveDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.effectiveDate == null) return -1;
if (a.effectiveDate == null) return 1;
return b.effectiveDate.localeCompare(a.effectiveDate);
}
case clsQxUsersEN.con_UpdDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.updDate == null) return -1;
if (a.updDate == null) return 1;
return b.updDate.localeCompare(a.updDate);
}
case clsQxUsersEN.con_UpdUser:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.updUser == null) return -1;
if (a.updUser == null) return 1;
return b.updUser.localeCompare(a.updUser);
}
case clsQxUsersEN.con_EffitiveBeginDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.effitiveBeginDate.localeCompare(a.effitiveBeginDate);
}
case clsQxUsersEN.con_EffitiveEndDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.effitiveEndDate.localeCompare(a.effitiveEndDate);
}
case clsQxUsersEN.con_id_College:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.id_College.localeCompare(a.id_College);
}
case clsQxUsersEN.con_StuTeacherID:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
return b.stuTeacherID.localeCompare(a.stuTeacherID);
}
case clsQxUsersEN.con_IdentityID:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.identityID == null) return -1;
if (a.identityID == null) return 1;
return b.identityID.localeCompare(a.identityID);
}
case clsQxUsersEN.con_IsArchive:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.isArchive == true) return 1;
else return -1
}
case clsQxUsersEN.con_HeadimgUrl:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.headimgUrl == null) return -1;
if (a.headimgUrl == null) return 1;
return b.headimgUrl.localeCompare(a.headimgUrl);
}
case clsQxUsersEN.con_OpenId:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.openId == null) return -1;
if (a.openId == null) return 1;
return b.openId.localeCompare(a.openId);
}
case clsQxUsersEN.con_NickName:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.nickName == null) return -1;
if (a.nickName == null) return 1;
return b.nickName.localeCompare(a.nickName);
}
case clsQxUsersEN.con_IsSynch:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.isSynch == true) return 1;
else return -1
}
case clsQxUsersEN.con_SynchDate:
return (a: clsQxUsersEN, b: clsQxUsersEN) => {
if (b.synchDate == null) return -1;
if (a.synchDate == null) return 1;
return b.synchDate.localeCompare(a.synchDate);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${ qxUsers_ConstructorName}.${ strThisFuncName})`;
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
export async function QxUsers_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsQxUsersEN.con_UserId:
return (obj: clsQxUsersEN) => {
return obj.userId === value;
}
case clsQxUsersEN.con_UserName:
return (obj: clsQxUsersEN) => {
return obj.userName === value;
}
case clsQxUsersEN.con_DepartmentId:
return (obj: clsQxUsersEN) => {
return obj.departmentId === value;
}
case clsQxUsersEN.con_id_XzCollege:
return (obj: clsQxUsersEN) => {
return obj.id_XzCollege === value;
}
case clsQxUsersEN.con_UserStateId:
return (obj: clsQxUsersEN) => {
return obj.userStateId === value;
}
case clsQxUsersEN.con_id_GradeBase:
return (obj: clsQxUsersEN) => {
return obj.id_GradeBase === value;
}
case clsQxUsersEN.con_Card_State:
return (obj: clsQxUsersEN) => {
return obj.card_State === value;
}
case clsQxUsersEN.con_IsLeaved:
return (obj: clsQxUsersEN) => {
return obj.isLeaved === value;
}
case clsQxUsersEN.con_CardNo:
return (obj: clsQxUsersEN) => {
return obj.cardNo === value;
}
case clsQxUsersEN.con_BeginYearMonth:
return (obj: clsQxUsersEN) => {
return obj.beginYearMonth === value;
}
case clsQxUsersEN.con_EndYearMonth:
return (obj: clsQxUsersEN) => {
return obj.endYearMonth === value;
}
case clsQxUsersEN.con_OptUser:
return (obj: clsQxUsersEN) => {
return obj.optUser === value;
}
case clsQxUsersEN.con_OptDate:
return (obj: clsQxUsersEN) => {
return obj.optDate === value;
}
case clsQxUsersEN.con_Memo:
return (obj: clsQxUsersEN) => {
return obj.memo === value;
}
case clsQxUsersEN.con_Password:
return (obj: clsQxUsersEN) => {
return obj.password === value;
}
case clsQxUsersEN.con_IsGpUser:
return (obj: clsQxUsersEN) => {
return obj.isGpUser === value;
}
case clsQxUsersEN.con_SchoolID1:
return (obj: clsQxUsersEN) => {
return obj.schoolID1 === value;
}
case clsQxUsersEN.con_AvatarsPicture:
return (obj: clsQxUsersEN) => {
return obj.avatarsPicture === value;
}
case clsQxUsersEN.con_Email:
return (obj: clsQxUsersEN) => {
return obj.email === value;
}
case clsQxUsersEN.con_PhoneNumber:
return (obj: clsQxUsersEN) => {
return obj.phoneNumber === value;
}
case clsQxUsersEN.con_EffectiveDate:
return (obj: clsQxUsersEN) => {
return obj.effectiveDate === value;
}
case clsQxUsersEN.con_UpdDate:
return (obj: clsQxUsersEN) => {
return obj.updDate === value;
}
case clsQxUsersEN.con_UpdUser:
return (obj: clsQxUsersEN) => {
return obj.updUser === value;
}
case clsQxUsersEN.con_EffitiveBeginDate:
return (obj: clsQxUsersEN) => {
return obj.effitiveBeginDate === value;
}
case clsQxUsersEN.con_EffitiveEndDate:
return (obj: clsQxUsersEN) => {
return obj.effitiveEndDate === value;
}
case clsQxUsersEN.con_id_College:
return (obj: clsQxUsersEN) => {
return obj.id_College === value;
}
case clsQxUsersEN.con_StuTeacherID:
return (obj: clsQxUsersEN) => {
return obj.stuTeacherID === value;
}
case clsQxUsersEN.con_IdentityID:
return (obj: clsQxUsersEN) => {
return obj.identityID === value;
}
case clsQxUsersEN.con_IsArchive:
return (obj: clsQxUsersEN) => {
return obj.isArchive === value;
}
case clsQxUsersEN.con_HeadimgUrl:
return (obj: clsQxUsersEN) => {
return obj.headimgUrl === value;
}
case clsQxUsersEN.con_OpenId:
return (obj: clsQxUsersEN) => {
return obj.openId === value;
}
case clsQxUsersEN.con_NickName:
return (obj: clsQxUsersEN) => {
return obj.nickName === value;
}
case clsQxUsersEN.con_IsSynch:
return (obj: clsQxUsersEN) => {
return obj.isSynch === value;
}
case clsQxUsersEN.con_SynchDate:
return (obj: clsQxUsersEN) => {
return obj.synchDate === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[QxUsers]中不存在！(in ${ qxUsers_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
}

/**
 * 映射函数。根据表映射把输入字段值，映射成输出字段值
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
 * @param strInFldName:输入字段名
 * @param strInValue:输入字段值
 * @param strComparisonOp:比较操作符
 * @returns 返回一个关键字值列表
*/
export async function QxUsers_funcKey(strInFldName:string, strInValue: any, strComparisonOp:string): Promise<Array<string>> 
{
//const strThisFuncName = "funcKey";

if (strInFldName == clsQxUsersEN.con_UserId)
{
const strMsg = Format("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (IsNullOrEmpty(strInValue) == true)
{
return [];
}
const arrQxUsers = await QxUsers_GetObjLst_Cache();
if (arrQxUsers == null) return [];
let arrQxUsers_Sel = arrQxUsers;
const strType = typeof(strInValue);
switch (strType)
{
case "string":
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01: // " = "
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
break;
case enumComparisonOp.Like_03:
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
break;
case enumComparisonOp.In_04:
const arrValues = strInValue.split(',');
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
break;
}
break;
case "boolean":
if (strInValue == null) return [];
if (strComparisonOp == enumComparisonOp.Equal_01)
{
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
}
break;
case "number":
if (Number(strInValue) == 0) return [];
switch (strComparisonOp)
{
case enumComparisonOp.Equal_01:
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
break;
case enumComparisonOp.NotEqual_02:
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
break;
case enumComparisonOp.NotLessThan_05://" >= ":
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
break;
case enumComparisonOp.NotGreaterThan_06://" <= ":
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
case enumComparisonOp.GreaterThan_07://" > ":
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
break;
case enumComparisonOp.LessThan_08://" < ":
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
break;
}
break;
}
if (arrQxUsers_Sel.length == 0) return [];
return arrQxUsers_Sel.map(x=>x.userId);
}

 /**
 * 根据条件获取满足条件的第一条记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
 * @param strWhereCond:条件
 * @returns 返回的第一条记录的关键字值
 **/
export async function QxUsers_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetFirstObjAsync(strWhereCond: string): Promise<clsQxUsersEN|null>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const objQxUsers = QxUsers_GetObjFromJsonObj(returnObj);
return objQxUsers;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUsersEN._CurrTabName;
if (IsNullOrEmpty(clsQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUsersEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrQxUsersExObjLst_Cache: Array<clsQxUsersEN> = CacheHelper.Get(strKey);
const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
return arrQxUsersObjLst_T;
}
try
{
const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrQxUsersExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
console.log(strInfo);
return arrQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUsers_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUsersEN._CurrTabName;
if (IsNullOrEmpty(clsQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUsersEN.CacheAddiCondition);
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
const arrQxUsersExObjLst_Cache: Array<clsQxUsersEN> = JSON.parse(strTempObjLst);
const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
return arrQxUsersObjLst_T;
}
try
{
const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrQxUsersExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
console.log(strInfo);
return arrQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUsers_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsQxUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrQxUsersObjLst_Cache: Array<clsQxUsersEN> = JSON.parse(strTempObjLst);
return arrQxUsersObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function QxUsers_GetObjLstAsync(strWhereCond: string): Promise<Array<clsQxUsersEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsQxUsersEN._CurrTabName;
if (IsNullOrEmpty(clsQxUsersEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsQxUsersEN.CacheAddiCondition);
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
const arrQxUsersExObjLst_Cache: Array<clsQxUsersEN> = JSON.parse(strTempObjLst);
const arrQxUsersObjLst_T = QxUsers_GetObjLstByJSONObjLst(arrQxUsersExObjLst_Cache);
return arrQxUsersObjLst_T;
}
try
{
const arrQxUsersExObjLst = await QxUsers_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrQxUsersExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQxUsersExObjLst.length);
console.log(strInfo);
return arrQxUsersExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUsers_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsQxUsersEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrQxUsersObjLst_Cache: Array<clsQxUsersEN> = JSON.parse(strTempObjLst);
return arrQxUsersObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUsers_GetObjLst_Cache(): Promise<Array<clsQxUsersEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrQxUsersObjLst_Cache;
switch (clsQxUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_ClientCache();
break;
default:
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_ClientCache();
break;
}
const arrQxUsersObjLst = QxUsers_GetObjLstByJSONObjLst(arrQxUsersObjLst_Cache);
return arrQxUsersObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function QxUsers_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrQxUsersObjLst_Cache;
switch (clsQxUsersEN.CacheModeId)
{
case "04"://sessionStorage
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrQxUsersObjLst_Cache = null;
break;
default:
arrQxUsersObjLst_Cache = null;
break;
}
return arrQxUsersObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrUserId_Cond:条件对象
 * @returns 对象列表子集
*/
export async function QxUsers_GetSubObjLst_Cache(objQxUsers_Cond: clsQxUsersEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
let arrQxUsers_Sel: Array < clsQxUsersEN > = arrQxUsersObjLst_Cache;
if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "") return arrQxUsers_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrQxUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objQxUsers_Cond), qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsQxUsersEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrUserId:关键字列表
 * @returns 对象列表
 **/
export async function QxUsers_GetObjLstByUserIdLstAsync(arrUserId: Array<string>): Promise<Array<clsQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByUserIdLstAsync";
const strAction = "GetObjLstByUserIdLst";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrUserId);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLstByUserIdLst_Cache(arrUserIdLst: Array<string>) {
const strThisFuncName = "GetObjLstByUserIdLst_Cache";
try
{
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
const arrQxUsers_Sel: Array <clsQxUsersEN> = arrQxUsersObjLst_Cache.filter(x => arrUserIdLst.indexOf(x.userId)>-1);
return arrQxUsers_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrUserIdLst.join(","), qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function QxUsers_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsQxUsersEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
if (objPagerPara.pageIndex == 0) return new Array<clsQxUsersEN>();
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
if (arrQxUsersObjLst_Cache.length == 0) return arrQxUsersObjLst_Cache;
let arrQxUsers_Sel = arrQxUsersObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objQxUsers_Cond = new clsQxUsersEN();
ObjectAssign(objQxUsers_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsQxUsersWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrQxUsers_Sel.length == 0) return arrQxUsers_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrQxUsers_Sel = arrQxUsers_Sel.sort(QxUsers_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrQxUsers_Sel = arrQxUsers_Sel.sort(objPagerPara.sortFun);
}
arrQxUsers_Sel = arrQxUsers_Sel.slice(intStart, intEnd);     
return arrQxUsers_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, qxUsers_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsQxUsersEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function QxUsers_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsQxUsersEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
if (objPagerPara.pageIndex == 0) return new Array<clsQxUsersEN>();
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", qxUsers_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = QxUsers_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_DelRecordAsync(strUserId: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strUserId);
try
{
const response = await axios.delete(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_DelQxUserssAsync(arrUserId: Array<string>): Promise<number> 
{
const strThisFuncName = "DelQxUserssAsync";
const strAction = "DelQxUserss";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_DelQxUserssByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelQxUserssByCondAsync";
const strAction = "DelQxUserssByCond";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function QxUsers_AddNewRecordAsync(objQxUsersEN: clsQxUsersEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
if (objQxUsersEN.userId === null || objQxUsersEN.userId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
throw strMsg;
}
 //var strJSON = JSON.stringify(objQxUsersEN);
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function QxUsers_AddNewRecordWithMaxIdAsync(objQxUsersEN: clsQxUsersEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function QxUsers_AddNewRecordWithReturnKeyAsync(objQxUsersEN: clsQxUsersEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function QxUsers_AddNewRecordWithReturnKey(objQxUsersEN: clsQxUsersEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objQxUsersEN.userId === null || objQxUsersEN.userId === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function QxUsers_UpdateRecordAsync(objQxUsersEN: clsQxUsersEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objQxUsersEN.sfUpdFldSetStr === undefined || objQxUsersEN.sfUpdFldSetStr === null || objQxUsersEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUsersEN.userId);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsersEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function QxUsers_UpdateWithConditionAsync(objQxUsersEN: clsQxUsersEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objQxUsersEN.sfUpdFldSetStr === undefined || objQxUsersEN.sfUpdFldSetStr === null || objQxUsersEN.sfUpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQxUsersEN.userId);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
objQxUsersEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objQxUsersEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_IsExistRecord_Cache(objQxUsers_Cond: clsQxUsersEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
if (arrQxUsersObjLst_Cache == null) return false;
let arrQxUsers_Sel: Array < clsQxUsersEN > = arrQxUsersObjLst_Cache;
if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "") return arrQxUsers_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrQxUsers_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objQxUsers_Cond), qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_IsExist(strUserId: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_IsExist_Cache(strUserId:string) {
const strThisFuncName = "IsExist_Cache";
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
if (arrQxUsersObjLst_Cache == null) return false;
try
{
const arrQxUsers_Sel: Array <clsQxUsersEN> = arrQxUsersObjLst_Cache.filter(x => x.userId == strUserId);
if (arrQxUsers_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strUserId, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_IsExistAsync(strUserId: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
 * @param objQxUsers_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function QxUsers_GetRecCountByCond_Cache(objQxUsers_Cond: clsQxUsersEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrQxUsersObjLst_Cache = await QxUsers_GetObjLst_Cache();
if (arrQxUsersObjLst_Cache == null) return 0;
let arrQxUsers_Sel: Array < clsQxUsersEN > = arrQxUsersObjLst_Cache;
if (objQxUsers_Cond.sf_FldComparisonOp == null || objQxUsers_Cond.sf_FldComparisonOp == "") return arrQxUsers_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objQxUsers_Cond.sf_FldComparisonOp);
//console.log("clsQxUsersWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objQxUsers_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objQxUsers_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "length greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
}
else if (strComparisonOp == "length not greater") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
}
else if (strComparisonOp == "length not less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
}
else if (strComparisonOp == "length less") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
}
else if (strComparisonOp == "length equal") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrQxUsers_Sel = arrQxUsers_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrQxUsers_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objQxUsers_Cond), qxUsers_ConstructorName, strThisFuncName);
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
export async function QxUsers_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(qxUsers_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, qxUsers_ConstructorName, strThisFuncName);
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
export function QxUsers_GetWebApiUrl(strController: string, strAction: string): string {
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
export function QxUsers_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsQxUsersEN._CurrTabName;
switch (clsQxUsersEN.CacheModeId)
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
}

 /**
 * 刷新本类中的缓存.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
 **/
export function QxUsers_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsQxUsersEN._CurrTabName;
switch (clsQxUsersEN.CacheModeId)
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
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function QxUsers_CheckPropertyNew(pobjQxUsersEN: clsQxUsersEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjQxUsersEN.userName) === true )
{
 throw new Error("(errid:Watl000058)字段[用户名]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userStateId) === true )
{
 throw new Error("(errid:Watl000058)字段[用户状态Id]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveBeginDate) === true )
{
 throw new Error("(errid:Watl000058)字段[EffitiveBeginDate]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveEndDate) === true )
{
 throw new Error("(errid:Watl000058)字段[EffitiveEndDate]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_College) === true 
 || pobjQxUsersEN.id_College.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000058)字段[学院流水号]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.stuTeacherID) === true )
{
 throw new Error("(errid:Watl000058)字段[学工号]不能为空(In Qx用户)!(clsQxUsersBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjQxUsersEN.userId) == false && GetStrLen(pobjQxUsersEN.userId) > 18)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userId)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userName) == false && GetStrLen(pobjQxUsersEN.userName) > 30)
{
 throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userName)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.departmentId) == false && GetStrLen(pobjQxUsersEN.departmentId) > 8)
{
 throw new Error("(errid:Watl000059)字段[部门Id(departmentId)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.departmentId)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_XzCollege) == false && GetStrLen(pobjQxUsersEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_XzCollege)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userStateId) == false && GetStrLen(pobjQxUsersEN.userStateId) > 2)
{
 throw new Error("(errid:Watl000059)字段[用户状态Id(userStateId)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userStateId)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_GradeBase) == false && GetStrLen(pobjQxUsersEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_GradeBase)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.card_State) == false && GetStrLen(pobjQxUsersEN.card_State) > 10)
{
 throw new Error("(errid:Watl000059)字段[Card_State(card_State)]的长度不能超过10(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.card_State)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.cardNo) == false && GetStrLen(pobjQxUsersEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.cardNo)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.beginYearMonth) == false && GetStrLen(pobjQxUsersEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[开始年月(beginYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.beginYearMonth)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.endYearMonth) == false && GetStrLen(pobjQxUsersEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000059)字段[结束年月(endYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.endYearMonth)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optUser) == false && GetStrLen(pobjQxUsersEN.optUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[OptUser(optUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optUser)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optDate) == false && GetStrLen(pobjQxUsersEN.optDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[OptDate(optDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optDate)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.memo) == false && GetStrLen(pobjQxUsersEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.memo)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.password) == false && GetStrLen(pobjQxUsersEN.password) > 20)
{
 throw new Error("(errid:Watl000059)字段[Password(password)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.password)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.schoolID1) == false && GetStrLen(pobjQxUsersEN.schoolID1) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校编号(schoolID1)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.schoolID1)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.avatarsPicture) == false && GetStrLen(pobjQxUsersEN.avatarsPicture) > 100)
{
 throw new Error("(errid:Watl000059)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.avatarsPicture)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.email) == false && GetStrLen(pobjQxUsersEN.email) > 100)
{
 throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.email)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.phoneNumber) == false && GetStrLen(pobjQxUsersEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.phoneNumber)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effectiveDate) == false && GetStrLen(pobjQxUsersEN.effectiveDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[EffectiveDate(effectiveDate)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effectiveDate)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updDate) == false && GetStrLen(pobjQxUsersEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updDate)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updUser) == false && GetStrLen(pobjQxUsersEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updUser)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveBeginDate) == false && GetStrLen(pobjQxUsersEN.effitiveBeginDate) > 14)
{
 throw new Error("(errid:Watl000059)字段[EffitiveBeginDate(effitiveBeginDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveBeginDate)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveEndDate) == false && GetStrLen(pobjQxUsersEN.effitiveEndDate) > 14)
{
 throw new Error("(errid:Watl000059)字段[EffitiveEndDate(effitiveEndDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveEndDate)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_College) == false && GetStrLen(pobjQxUsersEN.id_College) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_College)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_College)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.stuTeacherID) == false && GetStrLen(pobjQxUsersEN.stuTeacherID) > 20)
{
 throw new Error("(errid:Watl000059)字段[学工号(stuTeacherID)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.stuTeacherID)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.identityID) == false && GetStrLen(pobjQxUsersEN.identityID) > 2)
{
 throw new Error("(errid:Watl000059)字段[身份编号(identityID)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.identityID)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.headimgUrl) == false && GetStrLen(pobjQxUsersEN.headimgUrl) > 1000)
{
 throw new Error("(errid:Watl000059)字段[微信头像(headimgUrl)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.headimgUrl)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.openId) == false && GetStrLen(pobjQxUsersEN.openId) > 50)
{
 throw new Error("(errid:Watl000059)字段[微信OpenId(openId)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.openId)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.nickName) == false && GetStrLen(pobjQxUsersEN.nickName) > 50)
{
 throw new Error("(errid:Watl000059)字段[昵称(nickName)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.nickName)(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.synchDate) == false && GetStrLen(pobjQxUsersEN.synchDate) > 30)
{
 throw new Error("(errid:Watl000059)字段[同步日期(synchDate)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.synchDate)(clsQxUsersBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjQxUsersEN.userId) == false && undefined !== pobjQxUsersEN.userId && tzDataType.isString(pobjQxUsersEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjQxUsersEN.userId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userName) == false && undefined !== pobjQxUsersEN.userName && tzDataType.isString(pobjQxUsersEN.userName) === false)
{
 throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjQxUsersEN.userName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.departmentId) == false && undefined !== pobjQxUsersEN.departmentId && tzDataType.isString(pobjQxUsersEN.departmentId) === false)
{
 throw new Error("(errid:Watl000060)字段[部门Id(departmentId)]的值:[$(pobjQxUsersEN.departmentId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_XzCollege) == false && undefined !== pobjQxUsersEN.id_XzCollege && tzDataType.isString(pobjQxUsersEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjQxUsersEN.id_XzCollege)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userStateId) == false && undefined !== pobjQxUsersEN.userStateId && tzDataType.isString(pobjQxUsersEN.userStateId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户状态Id(userStateId)]的值:[$(pobjQxUsersEN.userStateId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_GradeBase) == false && undefined !== pobjQxUsersEN.id_GradeBase && tzDataType.isString(pobjQxUsersEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjQxUsersEN.id_GradeBase)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.card_State) == false && undefined !== pobjQxUsersEN.card_State && tzDataType.isString(pobjQxUsersEN.card_State) === false)
{
 throw new Error("(errid:Watl000060)字段[Card_State(card_State)]的值:[$(pobjQxUsersEN.card_State)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (null != pobjQxUsersEN.isLeaved && undefined !== pobjQxUsersEN.isLeaved && tzDataType.isBoolean(pobjQxUsersEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjQxUsersEN.isLeaved)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.cardNo) == false && undefined !== pobjQxUsersEN.cardNo && tzDataType.isString(pobjQxUsersEN.cardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjQxUsersEN.cardNo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.beginYearMonth) == false && undefined !== pobjQxUsersEN.beginYearMonth && tzDataType.isString(pobjQxUsersEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[开始年月(beginYearMonth)]的值:[$(pobjQxUsersEN.beginYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.endYearMonth) == false && undefined !== pobjQxUsersEN.endYearMonth && tzDataType.isString(pobjQxUsersEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000060)字段[结束年月(endYearMonth)]的值:[$(pobjQxUsersEN.endYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optUser) == false && undefined !== pobjQxUsersEN.optUser && tzDataType.isString(pobjQxUsersEN.optUser) === false)
{
 throw new Error("(errid:Watl000060)字段[OptUser(optUser)]的值:[$(pobjQxUsersEN.optUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optDate) == false && undefined !== pobjQxUsersEN.optDate && tzDataType.isString(pobjQxUsersEN.optDate) === false)
{
 throw new Error("(errid:Watl000060)字段[OptDate(optDate)]的值:[$(pobjQxUsersEN.optDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.memo) == false && undefined !== pobjQxUsersEN.memo && tzDataType.isString(pobjQxUsersEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQxUsersEN.memo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.password) == false && undefined !== pobjQxUsersEN.password && tzDataType.isString(pobjQxUsersEN.password) === false)
{
 throw new Error("(errid:Watl000060)字段[Password(password)]的值:[$(pobjQxUsersEN.password)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (null != pobjQxUsersEN.isGpUser && undefined !== pobjQxUsersEN.isGpUser && tzDataType.isBoolean(pobjQxUsersEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjQxUsersEN.isGpUser)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.schoolID1) == false && undefined !== pobjQxUsersEN.schoolID1 && tzDataType.isString(pobjQxUsersEN.schoolID1) === false)
{
 throw new Error("(errid:Watl000060)字段[学校编号(schoolID1)]的值:[$(pobjQxUsersEN.schoolID1)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.avatarsPicture) == false && undefined !== pobjQxUsersEN.avatarsPicture && tzDataType.isString(pobjQxUsersEN.avatarsPicture) === false)
{
 throw new Error("(errid:Watl000060)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjQxUsersEN.avatarsPicture)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.email) == false && undefined !== pobjQxUsersEN.email && tzDataType.isString(pobjQxUsersEN.email) === false)
{
 throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjQxUsersEN.email)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.phoneNumber) == false && undefined !== pobjQxUsersEN.phoneNumber && tzDataType.isString(pobjQxUsersEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjQxUsersEN.phoneNumber)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effectiveDate) == false && undefined !== pobjQxUsersEN.effectiveDate && tzDataType.isString(pobjQxUsersEN.effectiveDate) === false)
{
 throw new Error("(errid:Watl000060)字段[EffectiveDate(effectiveDate)]的值:[$(pobjQxUsersEN.effectiveDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updDate) == false && undefined !== pobjQxUsersEN.updDate && tzDataType.isString(pobjQxUsersEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjQxUsersEN.updDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updUser) == false && undefined !== pobjQxUsersEN.updUser && tzDataType.isString(pobjQxUsersEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjQxUsersEN.updUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveBeginDate) == false && undefined !== pobjQxUsersEN.effitiveBeginDate && tzDataType.isString(pobjQxUsersEN.effitiveBeginDate) === false)
{
 throw new Error("(errid:Watl000060)字段[EffitiveBeginDate(effitiveBeginDate)]的值:[$(pobjQxUsersEN.effitiveBeginDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveEndDate) == false && undefined !== pobjQxUsersEN.effitiveEndDate && tzDataType.isString(pobjQxUsersEN.effitiveEndDate) === false)
{
 throw new Error("(errid:Watl000060)字段[EffitiveEndDate(effitiveEndDate)]的值:[$(pobjQxUsersEN.effitiveEndDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_College) == false && undefined !== pobjQxUsersEN.id_College && tzDataType.isString(pobjQxUsersEN.id_College) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_College)]的值:[$(pobjQxUsersEN.id_College)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.stuTeacherID) == false && undefined !== pobjQxUsersEN.stuTeacherID && tzDataType.isString(pobjQxUsersEN.stuTeacherID) === false)
{
 throw new Error("(errid:Watl000060)字段[学工号(stuTeacherID)]的值:[$(pobjQxUsersEN.stuTeacherID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.identityID) == false && undefined !== pobjQxUsersEN.identityID && tzDataType.isString(pobjQxUsersEN.identityID) === false)
{
 throw new Error("(errid:Watl000060)字段[身份编号(identityID)]的值:[$(pobjQxUsersEN.identityID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (null != pobjQxUsersEN.isArchive && undefined !== pobjQxUsersEN.isArchive && tzDataType.isBoolean(pobjQxUsersEN.isArchive) === false)
{
 throw new Error("(errid:Watl000060)字段[IsArchive(isArchive)]的值:[$(pobjQxUsersEN.isArchive)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.headimgUrl) == false && undefined !== pobjQxUsersEN.headimgUrl && tzDataType.isString(pobjQxUsersEN.headimgUrl) === false)
{
 throw new Error("(errid:Watl000060)字段[微信头像(headimgUrl)]的值:[$(pobjQxUsersEN.headimgUrl)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.openId) == false && undefined !== pobjQxUsersEN.openId && tzDataType.isString(pobjQxUsersEN.openId) === false)
{
 throw new Error("(errid:Watl000060)字段[微信OpenId(openId)]的值:[$(pobjQxUsersEN.openId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.nickName) == false && undefined !== pobjQxUsersEN.nickName && tzDataType.isString(pobjQxUsersEN.nickName) === false)
{
 throw new Error("(errid:Watl000060)字段[昵称(nickName)]的值:[$(pobjQxUsersEN.nickName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (null != pobjQxUsersEN.isSynch && undefined !== pobjQxUsersEN.isSynch && tzDataType.isBoolean(pobjQxUsersEN.isSynch) === false)
{
 throw new Error("(errid:Watl000060)字段[是否同步(isSynch)]的值:[$(pobjQxUsersEN.isSynch)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjQxUsersEN.synchDate) == false && undefined !== pobjQxUsersEN.synchDate && tzDataType.isString(pobjQxUsersEN.synchDate) === false)
{
 throw new Error("(errid:Watl000060)字段[同步日期(synchDate)]的值:[$(pobjQxUsersEN.synchDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjQxUsersEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function QxUsers_CheckProperty4Update (pobjQxUsersEN: clsQxUsersEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjQxUsersEN.userId) == false && GetStrLen(pobjQxUsersEN.userId) > 18)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userId)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userName) == false && GetStrLen(pobjQxUsersEN.userName) > 30)
{
 throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userName)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.departmentId) == false && GetStrLen(pobjQxUsersEN.departmentId) > 8)
{
 throw new Error("(errid:Watl000062)字段[部门Id(departmentId)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.departmentId)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_XzCollege) == false && GetStrLen(pobjQxUsersEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_XzCollege)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userStateId) == false && GetStrLen(pobjQxUsersEN.userStateId) > 2)
{
 throw new Error("(errid:Watl000062)字段[用户状态Id(userStateId)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.userStateId)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_GradeBase) == false && GetStrLen(pobjQxUsersEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_GradeBase)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.card_State) == false && GetStrLen(pobjQxUsersEN.card_State) > 10)
{
 throw new Error("(errid:Watl000062)字段[Card_State(card_State)]的长度不能超过10(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.card_State)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.cardNo) == false && GetStrLen(pobjQxUsersEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.cardNo)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.beginYearMonth) == false && GetStrLen(pobjQxUsersEN.beginYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[开始年月(beginYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.beginYearMonth)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.endYearMonth) == false && GetStrLen(pobjQxUsersEN.endYearMonth) > 8)
{
 throw new Error("(errid:Watl000062)字段[结束年月(endYearMonth)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.endYearMonth)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optUser) == false && GetStrLen(pobjQxUsersEN.optUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[OptUser(optUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optUser)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optDate) == false && GetStrLen(pobjQxUsersEN.optDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[OptDate(optDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.optDate)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.memo) == false && GetStrLen(pobjQxUsersEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.memo)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.password) == false && GetStrLen(pobjQxUsersEN.password) > 20)
{
 throw new Error("(errid:Watl000062)字段[Password(password)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.password)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.schoolID1) == false && GetStrLen(pobjQxUsersEN.schoolID1) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校编号(schoolID1)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.schoolID1)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.avatarsPicture) == false && GetStrLen(pobjQxUsersEN.avatarsPicture) > 100)
{
 throw new Error("(errid:Watl000062)字段[AvatarsPicture(avatarsPicture)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.avatarsPicture)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.email) == false && GetStrLen(pobjQxUsersEN.email) > 100)
{
 throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.email)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.phoneNumber) == false && GetStrLen(pobjQxUsersEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.phoneNumber)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effectiveDate) == false && GetStrLen(pobjQxUsersEN.effectiveDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[EffectiveDate(effectiveDate)]的长度不能超过8(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effectiveDate)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updDate) == false && GetStrLen(pobjQxUsersEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updDate)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updUser) == false && GetStrLen(pobjQxUsersEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.updUser)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveBeginDate) == false && GetStrLen(pobjQxUsersEN.effitiveBeginDate) > 14)
{
 throw new Error("(errid:Watl000062)字段[EffitiveBeginDate(effitiveBeginDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveBeginDate)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveEndDate) == false && GetStrLen(pobjQxUsersEN.effitiveEndDate) > 14)
{
 throw new Error("(errid:Watl000062)字段[EffitiveEndDate(effitiveEndDate)]的长度不能超过14(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.effitiveEndDate)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_College) == false && GetStrLen(pobjQxUsersEN.id_College) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_College)]的长度不能超过4(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.id_College)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.stuTeacherID) == false && GetStrLen(pobjQxUsersEN.stuTeacherID) > 20)
{
 throw new Error("(errid:Watl000062)字段[学工号(stuTeacherID)]的长度不能超过20(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.stuTeacherID)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.identityID) == false && GetStrLen(pobjQxUsersEN.identityID) > 2)
{
 throw new Error("(errid:Watl000062)字段[身份编号(identityID)]的长度不能超过2(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.identityID)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.headimgUrl) == false && GetStrLen(pobjQxUsersEN.headimgUrl) > 1000)
{
 throw new Error("(errid:Watl000062)字段[微信头像(headimgUrl)]的长度不能超过1000(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.headimgUrl)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.openId) == false && GetStrLen(pobjQxUsersEN.openId) > 50)
{
 throw new Error("(errid:Watl000062)字段[微信OpenId(openId)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.openId)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.nickName) == false && GetStrLen(pobjQxUsersEN.nickName) > 50)
{
 throw new Error("(errid:Watl000062)字段[昵称(nickName)]的长度不能超过50(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.nickName)(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.synchDate) == false && GetStrLen(pobjQxUsersEN.synchDate) > 30)
{
 throw new Error("(errid:Watl000062)字段[同步日期(synchDate)]的长度不能超过30(In Qx用户(QxUsers))!值:$(pobjQxUsersEN.synchDate)(clsQxUsersBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjQxUsersEN.userId) == false && undefined !== pobjQxUsersEN.userId && tzDataType.isString(pobjQxUsersEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjQxUsersEN.userId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userName) == false && undefined !== pobjQxUsersEN.userName && tzDataType.isString(pobjQxUsersEN.userName) === false)
{
 throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjQxUsersEN.userName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.departmentId) == false && undefined !== pobjQxUsersEN.departmentId && tzDataType.isString(pobjQxUsersEN.departmentId) === false)
{
 throw new Error("(errid:Watl000063)字段[部门Id(departmentId)]的值:[$(pobjQxUsersEN.departmentId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_XzCollege) == false && undefined !== pobjQxUsersEN.id_XzCollege && tzDataType.isString(pobjQxUsersEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjQxUsersEN.id_XzCollege)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.userStateId) == false && undefined !== pobjQxUsersEN.userStateId && tzDataType.isString(pobjQxUsersEN.userStateId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户状态Id(userStateId)]的值:[$(pobjQxUsersEN.userStateId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_GradeBase) == false && undefined !== pobjQxUsersEN.id_GradeBase && tzDataType.isString(pobjQxUsersEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjQxUsersEN.id_GradeBase)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.card_State) == false && undefined !== pobjQxUsersEN.card_State && tzDataType.isString(pobjQxUsersEN.card_State) === false)
{
 throw new Error("(errid:Watl000063)字段[Card_State(card_State)]的值:[$(pobjQxUsersEN.card_State)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (null != pobjQxUsersEN.isLeaved && undefined !== pobjQxUsersEN.isLeaved && tzDataType.isBoolean(pobjQxUsersEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjQxUsersEN.isLeaved)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.cardNo) == false && undefined !== pobjQxUsersEN.cardNo && tzDataType.isString(pobjQxUsersEN.cardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjQxUsersEN.cardNo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.beginYearMonth) == false && undefined !== pobjQxUsersEN.beginYearMonth && tzDataType.isString(pobjQxUsersEN.beginYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[开始年月(beginYearMonth)]的值:[$(pobjQxUsersEN.beginYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.endYearMonth) == false && undefined !== pobjQxUsersEN.endYearMonth && tzDataType.isString(pobjQxUsersEN.endYearMonth) === false)
{
 throw new Error("(errid:Watl000063)字段[结束年月(endYearMonth)]的值:[$(pobjQxUsersEN.endYearMonth)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optUser) == false && undefined !== pobjQxUsersEN.optUser && tzDataType.isString(pobjQxUsersEN.optUser) === false)
{
 throw new Error("(errid:Watl000063)字段[OptUser(optUser)]的值:[$(pobjQxUsersEN.optUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.optDate) == false && undefined !== pobjQxUsersEN.optDate && tzDataType.isString(pobjQxUsersEN.optDate) === false)
{
 throw new Error("(errid:Watl000063)字段[OptDate(optDate)]的值:[$(pobjQxUsersEN.optDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.memo) == false && undefined !== pobjQxUsersEN.memo && tzDataType.isString(pobjQxUsersEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQxUsersEN.memo)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.password) == false && undefined !== pobjQxUsersEN.password && tzDataType.isString(pobjQxUsersEN.password) === false)
{
 throw new Error("(errid:Watl000063)字段[Password(password)]的值:[$(pobjQxUsersEN.password)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (null != pobjQxUsersEN.isGpUser && undefined !== pobjQxUsersEN.isGpUser && tzDataType.isBoolean(pobjQxUsersEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjQxUsersEN.isGpUser)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.schoolID1) == false && undefined !== pobjQxUsersEN.schoolID1 && tzDataType.isString(pobjQxUsersEN.schoolID1) === false)
{
 throw new Error("(errid:Watl000063)字段[学校编号(schoolID1)]的值:[$(pobjQxUsersEN.schoolID1)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.avatarsPicture) == false && undefined !== pobjQxUsersEN.avatarsPicture && tzDataType.isString(pobjQxUsersEN.avatarsPicture) === false)
{
 throw new Error("(errid:Watl000063)字段[AvatarsPicture(avatarsPicture)]的值:[$(pobjQxUsersEN.avatarsPicture)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.email) == false && undefined !== pobjQxUsersEN.email && tzDataType.isString(pobjQxUsersEN.email) === false)
{
 throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjQxUsersEN.email)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.phoneNumber) == false && undefined !== pobjQxUsersEN.phoneNumber && tzDataType.isString(pobjQxUsersEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjQxUsersEN.phoneNumber)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effectiveDate) == false && undefined !== pobjQxUsersEN.effectiveDate && tzDataType.isString(pobjQxUsersEN.effectiveDate) === false)
{
 throw new Error("(errid:Watl000063)字段[EffectiveDate(effectiveDate)]的值:[$(pobjQxUsersEN.effectiveDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updDate) == false && undefined !== pobjQxUsersEN.updDate && tzDataType.isString(pobjQxUsersEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjQxUsersEN.updDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.updUser) == false && undefined !== pobjQxUsersEN.updUser && tzDataType.isString(pobjQxUsersEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjQxUsersEN.updUser)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveBeginDate) == false && undefined !== pobjQxUsersEN.effitiveBeginDate && tzDataType.isString(pobjQxUsersEN.effitiveBeginDate) === false)
{
 throw new Error("(errid:Watl000063)字段[EffitiveBeginDate(effitiveBeginDate)]的值:[$(pobjQxUsersEN.effitiveBeginDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.effitiveEndDate) == false && undefined !== pobjQxUsersEN.effitiveEndDate && tzDataType.isString(pobjQxUsersEN.effitiveEndDate) === false)
{
 throw new Error("(errid:Watl000063)字段[EffitiveEndDate(effitiveEndDate)]的值:[$(pobjQxUsersEN.effitiveEndDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.id_College) == false && undefined !== pobjQxUsersEN.id_College && tzDataType.isString(pobjQxUsersEN.id_College) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_College)]的值:[$(pobjQxUsersEN.id_College)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.stuTeacherID) == false && undefined !== pobjQxUsersEN.stuTeacherID && tzDataType.isString(pobjQxUsersEN.stuTeacherID) === false)
{
 throw new Error("(errid:Watl000063)字段[学工号(stuTeacherID)]的值:[$(pobjQxUsersEN.stuTeacherID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.identityID) == false && undefined !== pobjQxUsersEN.identityID && tzDataType.isString(pobjQxUsersEN.identityID) === false)
{
 throw new Error("(errid:Watl000063)字段[身份编号(identityID)]的值:[$(pobjQxUsersEN.identityID)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (null != pobjQxUsersEN.isArchive && undefined !== pobjQxUsersEN.isArchive && tzDataType.isBoolean(pobjQxUsersEN.isArchive) === false)
{
 throw new Error("(errid:Watl000063)字段[IsArchive(isArchive)]的值:[$(pobjQxUsersEN.isArchive)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.headimgUrl) == false && undefined !== pobjQxUsersEN.headimgUrl && tzDataType.isString(pobjQxUsersEN.headimgUrl) === false)
{
 throw new Error("(errid:Watl000063)字段[微信头像(headimgUrl)]的值:[$(pobjQxUsersEN.headimgUrl)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.openId) == false && undefined !== pobjQxUsersEN.openId && tzDataType.isString(pobjQxUsersEN.openId) === false)
{
 throw new Error("(errid:Watl000063)字段[微信OpenId(openId)]的值:[$(pobjQxUsersEN.openId)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.nickName) == false && undefined !== pobjQxUsersEN.nickName && tzDataType.isString(pobjQxUsersEN.nickName) === false)
{
 throw new Error("(errid:Watl000063)字段[昵称(nickName)]的值:[$(pobjQxUsersEN.nickName)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (null != pobjQxUsersEN.isSynch && undefined !== pobjQxUsersEN.isSynch && tzDataType.isBoolean(pobjQxUsersEN.isSynch) === false)
{
 throw new Error("(errid:Watl000063)字段[是否同步(isSynch)]的值:[$(pobjQxUsersEN.isSynch)], 非法，应该为布尔型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjQxUsersEN.synchDate) == false && undefined !== pobjQxUsersEN.synchDate && tzDataType.isString(pobjQxUsersEN.synchDate) === false)
{
 throw new Error("(errid:Watl000063)字段[同步日期(synchDate)]的值:[$(pobjQxUsersEN.synchDate)], 非法，应该为字符型(In Qx用户(QxUsers))!(clsQxUsersBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjQxUsersEN.userId) === true )
{
 throw new Error("(errid:Watl000064)字段[用户ID]不能为空(In Qx用户)!(clsQxUsersBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjQxUsersEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function QxUsers_GetJSONStrByObj (pobjQxUsersEN: clsQxUsersEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjQxUsersEN.sfUpdFldSetStr = pobjQxUsersEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjQxUsersEN);
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
export function QxUsers_GetObjLstByJSONStr (strJSON: string): Array<clsQxUsersEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrQxUsersObjLst = new Array<clsQxUsersEN>();
if (strJSON === "")
{
return arrQxUsersObjLst;
}
try
{
arrQxUsersObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrQxUsersObjLst;
}
return arrQxUsersObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrQxUsersObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function QxUsers_GetObjLstByJSONObjLst (arrQxUsersObjLstS: Array<clsQxUsersEN>): Array<clsQxUsersEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrQxUsersObjLst = new Array<clsQxUsersEN>();
for (const objInFor of arrQxUsersObjLstS) {
const obj1 = QxUsers_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrQxUsersObjLst.push(obj1);
}
return arrQxUsersObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2023-03-13
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function QxUsers_GetObjByJSONStr (strJSON: string): clsQxUsersEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjQxUsersEN = new clsQxUsersEN();
if (strJSON === "")
{
return pobjQxUsersEN;
}
try
{
pobjQxUsersEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjQxUsersEN;
}
return pobjQxUsersEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function QxUsers_GetCombineCondition(objQxUsers_Cond: clsQxUsersEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_UserId, objQxUsers_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_UserName) == true)
{
const strComparisonOp_UserName:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_UserName];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_UserName, objQxUsers_Cond.userName, strComparisonOp_UserName);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_DepartmentId) == true)
{
const strComparisonOp_DepartmentId:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_DepartmentId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_DepartmentId, objQxUsers_Cond.departmentId, strComparisonOp_DepartmentId);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_id_XzCollege, objQxUsers_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_UserStateId) == true)
{
const strComparisonOp_UserStateId:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_UserStateId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_UserStateId, objQxUsers_Cond.userStateId, strComparisonOp_UserStateId);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_id_GradeBase, objQxUsers_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_Card_State) == true)
{
const strComparisonOp_Card_State:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_Card_State];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_Card_State, objQxUsers_Cond.card_State, strComparisonOp_Card_State);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_IsLeaved) == true)
{
if (objQxUsers_Cond.isLeaved == true)
{
strWhereCond += Format(" And {0} = '1'", clsQxUsersEN.con_IsLeaved);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsQxUsersEN.con_IsLeaved);
}
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_CardNo) == true)
{
const strComparisonOp_CardNo:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_CardNo, objQxUsers_Cond.cardNo, strComparisonOp_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_BeginYearMonth) == true)
{
const strComparisonOp_BeginYearMonth:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_BeginYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_BeginYearMonth, objQxUsers_Cond.beginYearMonth, strComparisonOp_BeginYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_EndYearMonth) == true)
{
const strComparisonOp_EndYearMonth:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_EndYearMonth];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_EndYearMonth, objQxUsers_Cond.endYearMonth, strComparisonOp_EndYearMonth);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_OptUser) == true)
{
const strComparisonOp_OptUser:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_OptUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_OptUser, objQxUsers_Cond.optUser, strComparisonOp_OptUser);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_OptDate) == true)
{
const strComparisonOp_OptDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_OptDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_OptDate, objQxUsers_Cond.optDate, strComparisonOp_OptDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_Memo, objQxUsers_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_Password) == true)
{
const strComparisonOp_Password:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_Password];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_Password, objQxUsers_Cond.password, strComparisonOp_Password);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_IsGpUser) == true)
{
if (objQxUsers_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsQxUsersEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsQxUsersEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_SchoolID1) == true)
{
const strComparisonOp_SchoolID1:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_SchoolID1];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_SchoolID1, objQxUsers_Cond.schoolID1, strComparisonOp_SchoolID1);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_AvatarsPicture) == true)
{
const strComparisonOp_AvatarsPicture:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_AvatarsPicture];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_AvatarsPicture, objQxUsers_Cond.avatarsPicture, strComparisonOp_AvatarsPicture);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_Email) == true)
{
const strComparisonOp_Email:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_Email, objQxUsers_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_PhoneNumber, objQxUsers_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_EffectiveDate) == true)
{
const strComparisonOp_EffectiveDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_EffectiveDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_EffectiveDate, objQxUsers_Cond.effectiveDate, strComparisonOp_EffectiveDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_UpdDate, objQxUsers_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_UpdUser, objQxUsers_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_EffitiveBeginDate) == true)
{
const strComparisonOp_EffitiveBeginDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_EffitiveBeginDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_EffitiveBeginDate, objQxUsers_Cond.effitiveBeginDate, strComparisonOp_EffitiveBeginDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_EffitiveEndDate) == true)
{
const strComparisonOp_EffitiveEndDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_EffitiveEndDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_EffitiveEndDate, objQxUsers_Cond.effitiveEndDate, strComparisonOp_EffitiveEndDate);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_id_College) == true)
{
const strComparisonOp_id_College:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_id_College];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_id_College, objQxUsers_Cond.id_College, strComparisonOp_id_College);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_StuTeacherID) == true)
{
const strComparisonOp_StuTeacherID:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_StuTeacherID];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_StuTeacherID, objQxUsers_Cond.stuTeacherID, strComparisonOp_StuTeacherID);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_IdentityID) == true)
{
const strComparisonOp_IdentityID:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_IdentityID];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_IdentityID, objQxUsers_Cond.identityID, strComparisonOp_IdentityID);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_IsArchive) == true)
{
if (objQxUsers_Cond.isArchive == true)
{
strWhereCond += Format(" And {0} = '1'", clsQxUsersEN.con_IsArchive);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsQxUsersEN.con_IsArchive);
}
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_HeadimgUrl) == true)
{
const strComparisonOp_HeadimgUrl:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_HeadimgUrl];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_HeadimgUrl, objQxUsers_Cond.headimgUrl, strComparisonOp_HeadimgUrl);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_OpenId) == true)
{
const strComparisonOp_OpenId:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_OpenId];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_OpenId, objQxUsers_Cond.openId, strComparisonOp_OpenId);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_NickName) == true)
{
const strComparisonOp_NickName:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_NickName];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_NickName, objQxUsers_Cond.nickName, strComparisonOp_NickName);
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_IsSynch) == true)
{
if (objQxUsers_Cond.isSynch == true)
{
strWhereCond += Format(" And {0} = '1'", clsQxUsersEN.con_IsSynch);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsQxUsersEN.con_IsSynch);
}
}
if (Object.prototype.hasOwnProperty.call(objQxUsers_Cond.dicFldComparisonOp, clsQxUsersEN.con_SynchDate) == true)
{
const strComparisonOp_SynchDate:string = objQxUsers_Cond.dicFldComparisonOp[clsQxUsersEN.con_SynchDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsQxUsersEN.con_SynchDate, objQxUsers_Cond.synchDate, strComparisonOp_SynchDate);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objQxUsersENS:源对象
 * @param objQxUsersENT:目标对象
*/
export function QxUsers_CopyObjTo(objQxUsersENS: clsQxUsersEN , objQxUsersENT: clsQxUsersEN ): void 
{
objQxUsersENT.userId = objQxUsersENS.userId; //用户ID
objQxUsersENT.userName = objQxUsersENS.userName; //用户名
objQxUsersENT.departmentId = objQxUsersENS.departmentId; //部门Id
objQxUsersENT.id_XzCollege = objQxUsersENS.id_XzCollege; //学院流水号
objQxUsersENT.userStateId = objQxUsersENS.userStateId; //用户状态Id
objQxUsersENT.id_GradeBase = objQxUsersENS.id_GradeBase; //年级流水号
objQxUsersENT.card_State = objQxUsersENS.card_State; //Card_State
objQxUsersENT.isLeaved = objQxUsersENS.isLeaved; //IsLeaved
objQxUsersENT.cardNo = objQxUsersENS.cardNo; //卡号
objQxUsersENT.beginYearMonth = objQxUsersENS.beginYearMonth; //开始年月
objQxUsersENT.endYearMonth = objQxUsersENS.endYearMonth; //结束年月
objQxUsersENT.optUser = objQxUsersENS.optUser; //OptUser
objQxUsersENT.optDate = objQxUsersENS.optDate; //OptDate
objQxUsersENT.memo = objQxUsersENS.memo; //备注
objQxUsersENT.password = objQxUsersENS.password; //Password
objQxUsersENT.isGpUser = objQxUsersENS.isGpUser; //是否Gp用户
objQxUsersENT.schoolID1 = objQxUsersENS.schoolID1; //学校编号
objQxUsersENT.avatarsPicture = objQxUsersENS.avatarsPicture; //AvatarsPicture
objQxUsersENT.email = objQxUsersENS.email; //电子邮箱
objQxUsersENT.phoneNumber = objQxUsersENS.phoneNumber; //PhoneNumber
objQxUsersENT.effectiveDate = objQxUsersENS.effectiveDate; //EffectiveDate
objQxUsersENT.updDate = objQxUsersENS.updDate; //修改日期
objQxUsersENT.updUser = objQxUsersENS.updUser; //修改人
objQxUsersENT.effitiveBeginDate = objQxUsersENS.effitiveBeginDate; //EffitiveBeginDate
objQxUsersENT.effitiveEndDate = objQxUsersENS.effitiveEndDate; //EffitiveEndDate
objQxUsersENT.id_College = objQxUsersENS.id_College; //学院流水号
objQxUsersENT.stuTeacherID = objQxUsersENS.stuTeacherID; //学工号
objQxUsersENT.identityID = objQxUsersENS.identityID; //身份编号
objQxUsersENT.isArchive = objQxUsersENS.isArchive; //IsArchive
objQxUsersENT.headimgUrl = objQxUsersENS.headimgUrl; //微信头像
objQxUsersENT.openId = objQxUsersENS.openId; //微信OpenId
objQxUsersENT.nickName = objQxUsersENS.nickName; //昵称
objQxUsersENT.isSynch = objQxUsersENS.isSynch; //是否同步
objQxUsersENT.synchDate = objQxUsersENS.synchDate; //同步日期
objQxUsersENT.sfUpdFldSetStr = objQxUsersENS.updFldString; //sfUpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objQxUsersENS:源对象
 * @param objQxUsersENT:目标对象
*/
export function QxUsers_GetObjFromJsonObj(objQxUsersENS: clsQxUsersEN): clsQxUsersEN 
{
 const objQxUsersENT: clsQxUsersEN = new clsQxUsersEN();
ObjectAssign(objQxUsersENT, objQxUsersENS);
 return objQxUsersENT;
}