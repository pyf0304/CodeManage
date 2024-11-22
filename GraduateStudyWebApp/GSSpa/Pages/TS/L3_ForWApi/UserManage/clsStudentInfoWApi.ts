
 /**
 * 类名:clsStudentInfoWApi
 * 表名:StudentInfo(01120131)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:57
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
 * 学生(StudentInfo)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsStudentInfoEN } from "../../L0_Entity/UserManage/clsStudentInfoEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const studentInfo_Controller = "StudentInfoApi";
 export const studentInfo_ConstructorName = "studentInfo";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_StudentInfo:关键字
 * @returns 对象
 **/
export async function StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo: string): Promise<clsStudentInfoEN>  
{
const strThisFuncName = "GetObjByid_StudentInfoAsync";

if (IsNullOrEmpty(strid_StudentInfo) == true)
{
  const strMsg = Format("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfoAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StudentInfo.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_StudentInfo";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_StudentInfo": strid_StudentInfo,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objStudentInfo = StudentInfo_GetObjFromJsonObj(returnObj);
return objStudentInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param strid_StudentInfo:所给的关键字
 * @returns 对象
*/
export async function StudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_StudentInfo_Cache";

if (IsNullOrEmpty(strid_StudentInfo) == true)
{
  const strMsg = Format("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfo_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StudentInfo.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
console.error(strMsg);
throw (strMsg);
}
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
try
{
const arrStudentInfo_Sel: Array <clsStudentInfoEN> = arrStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
let objStudentInfo: clsStudentInfoEN;
if (arrStudentInfo_Sel.length > 0)
{
objStudentInfo = arrStudentInfo_Sel[0];
return objStudentInfo;
}
else
{
if (bolTryAsyncOnce == true)
{
objStudentInfo = await StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
if (objStudentInfo != null)
{
StudentInfo_ReFreshThisCache();
return objStudentInfo;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_StudentInfo:所给的关键字
 * @returns 对象
*/
export async function StudentInfo_GetObjByid_StudentInfo_localStorage(strid_StudentInfo: string) {
const strThisFuncName = "GetObjByid_StudentInfo_localStorage";

if (IsNullOrEmpty(strid_StudentInfo) == true)
{
  const strMsg = Format("参数:[strid_StudentInfo]不能为空！(In GetObjByid_StudentInfo_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_StudentInfo.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_StudentInfo]的长度:[{0}]不正确！", strid_StudentInfo.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsStudentInfoEN._CurrTabName, strid_StudentInfo);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objStudentInfo_Cache: clsStudentInfoEN = JSON.parse(strTempObj);
return objStudentInfo_Cache;
}
try
{
const objStudentInfo = await StudentInfo_GetObjByid_StudentInfoAsync(strid_StudentInfo);
if (objStudentInfo != null)
{
localStorage.setItem(strKey, JSON.stringify(objStudentInfo));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objStudentInfo;
}
return objStudentInfo;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StudentInfo, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objStudentInfo:所给的对象
 * @returns 对象
*/
export async function StudentInfo_UpdateObjInLst_Cache(objStudentInfo: clsStudentInfoEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
const obj = arrStudentInfoObjLst_Cache.find(x => x.stuID == objStudentInfo.stuID);
if (obj != null)
{
objStudentInfo.id_StudentInfo = obj.id_StudentInfo;
ObjectAssign( obj, objStudentInfo);
}
else
{
arrStudentInfoObjLst_Cache.push(objStudentInfo);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
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
export async function StudentInfo_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsStudentInfoEN.con_id_StudentInfo)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsStudentInfoEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsStudentInfoEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_StudentInfo = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objStudentInfo = await StudentInfo_GetObjByid_StudentInfo_Cache(strid_StudentInfo );
if (objStudentInfo == null) return "";
return objStudentInfo.GetFldValue(strOutFldName).toString();
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
export function StudentInfo_SortFun_Defa(a:clsStudentInfoEN , b:clsStudentInfoEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
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
export function StudentInfo_SortFun_Defa_2Fld(a:clsStudentInfoEN , b:clsStudentInfoEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.stuID == b.stuID) return a.stuName.localeCompare(b.stuName);
else return a.stuID.localeCompare(b.stuID);
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
export function StudentInfo_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsStudentInfoEN.con_id_StudentInfo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_StudentInfo.localeCompare(b.id_StudentInfo);
}
case clsStudentInfoEN.con_StuID:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.stuID.localeCompare(b.stuID);
}
case clsStudentInfoEN.con_StuName:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.stuName.localeCompare(b.stuName);
}
case clsStudentInfoEN.con_id_Politics:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_Politics.localeCompare(b.id_Politics);
}
case clsStudentInfoEN.con_id_Sex:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_Sex.localeCompare(b.id_Sex);
}
case clsStudentInfoEN.con_id_Ethnic:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_Ethnic.localeCompare(b.id_Ethnic);
}
case clsStudentInfoEN.con_id_UniZone:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsStudentInfoEN.con_id_StuType:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_StuType.localeCompare(b.id_StuType);
}
case clsStudentInfoEN.con_id_XzCollege:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsStudentInfoEN.con_id_XzMajor:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsStudentInfoEN.con_id_GradeBase:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_GradeBase.localeCompare(b.id_GradeBase);
}
case clsStudentInfoEN.con_id_AdminCls:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_AdminCls.localeCompare(b.id_AdminCls);
}
case clsStudentInfoEN.con_Birthday:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.birthday.localeCompare(b.birthday);
}
case clsStudentInfoEN.con_NativePlace:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.nativePlace.localeCompare(b.nativePlace);
}
case clsStudentInfoEN.con_Duty:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.duty.localeCompare(b.duty);
}
case clsStudentInfoEN.con_IDCardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.idCardNo.localeCompare(b.idCardNo);
}
case clsStudentInfoEN.con_StuCardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.stuCardNo.localeCompare(b.stuCardNo);
}
case clsStudentInfoEN.con_LiveAddress:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.liveAddress.localeCompare(b.liveAddress);
}
case clsStudentInfoEN.con_HomePhone:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.homePhone.localeCompare(b.homePhone);
}
case clsStudentInfoEN.con_Id_CardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.id_CardNo.localeCompare(b.id_CardNo);
}
case clsStudentInfoEN.con_CardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.cardNo.localeCompare(b.cardNo);
}
case clsStudentInfoEN.con_IsAvconClassUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isAvconClassUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsAvconUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isAvconUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsGpUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsLocalUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isLocalUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsLeaved:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isLeaved == true) return 1;
else return -1
}
case clsStudentInfoEN.con_UserId:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.userId.localeCompare(b.userId);
}
case clsStudentInfoEN.con_UserID4Avcon:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.userID4Avcon.localeCompare(b.userID4Avcon);
}
case clsStudentInfoEN.con_EnrollmentDate:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.enrollmentDate.localeCompare(b.enrollmentDate);
}
case clsStudentInfoEN.con_PostCode:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.postCode.localeCompare(b.postCode);
}
case clsStudentInfoEN.con_Email:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.email.localeCompare(b.email);
}
case clsStudentInfoEN.con_IsMessage:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (a.isMessage == true) return 1;
else return -1
}
case clsStudentInfoEN.con_Microblog:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.microblog.localeCompare(b.microblog);
}
case clsStudentInfoEN.con_PhoneNumber:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsStudentInfoEN.con_Headphoto:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.headphoto.localeCompare(b.headphoto);
}
case clsStudentInfoEN.con_QQ:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.qQ.localeCompare(b.qQ);
}
case clsStudentInfoEN.con_RegisterPassword:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.registerPassword.localeCompare(b.registerPassword);
}
case clsStudentInfoEN.con_UpdDate:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.updDate.localeCompare(b.updDate);
}
case clsStudentInfoEN.con_UpdUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.updUser.localeCompare(b.updUser);
}
case clsStudentInfoEN.con_Memo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return a.memo.localeCompare(b.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${ studentInfo_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsStudentInfoEN.con_id_StudentInfo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_StudentInfo.localeCompare(a.id_StudentInfo);
}
case clsStudentInfoEN.con_StuID:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.stuID.localeCompare(a.stuID);
}
case clsStudentInfoEN.con_StuName:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.stuName.localeCompare(a.stuName);
}
case clsStudentInfoEN.con_id_Politics:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_Politics.localeCompare(a.id_Politics);
}
case clsStudentInfoEN.con_id_Sex:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_Sex.localeCompare(a.id_Sex);
}
case clsStudentInfoEN.con_id_Ethnic:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_Ethnic.localeCompare(a.id_Ethnic);
}
case clsStudentInfoEN.con_id_UniZone:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsStudentInfoEN.con_id_StuType:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_StuType.localeCompare(a.id_StuType);
}
case clsStudentInfoEN.con_id_XzCollege:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsStudentInfoEN.con_id_XzMajor:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsStudentInfoEN.con_id_GradeBase:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_GradeBase.localeCompare(a.id_GradeBase);
}
case clsStudentInfoEN.con_id_AdminCls:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_AdminCls.localeCompare(a.id_AdminCls);
}
case clsStudentInfoEN.con_Birthday:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.birthday.localeCompare(a.birthday);
}
case clsStudentInfoEN.con_NativePlace:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.nativePlace.localeCompare(a.nativePlace);
}
case clsStudentInfoEN.con_Duty:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.duty.localeCompare(a.duty);
}
case clsStudentInfoEN.con_IDCardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.idCardNo.localeCompare(a.idCardNo);
}
case clsStudentInfoEN.con_StuCardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.stuCardNo.localeCompare(a.stuCardNo);
}
case clsStudentInfoEN.con_LiveAddress:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.liveAddress.localeCompare(a.liveAddress);
}
case clsStudentInfoEN.con_HomePhone:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.homePhone.localeCompare(a.homePhone);
}
case clsStudentInfoEN.con_Id_CardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.id_CardNo.localeCompare(a.id_CardNo);
}
case clsStudentInfoEN.con_CardNo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.cardNo.localeCompare(a.cardNo);
}
case clsStudentInfoEN.con_IsAvconClassUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isAvconClassUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsAvconUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isAvconUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsGpUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsLocalUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isLocalUser == true) return 1;
else return -1
}
case clsStudentInfoEN.con_IsLeaved:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isLeaved == true) return 1;
else return -1
}
case clsStudentInfoEN.con_UserId:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.userId.localeCompare(a.userId);
}
case clsStudentInfoEN.con_UserID4Avcon:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.userID4Avcon.localeCompare(a.userID4Avcon);
}
case clsStudentInfoEN.con_EnrollmentDate:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.enrollmentDate.localeCompare(a.enrollmentDate);
}
case clsStudentInfoEN.con_PostCode:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.postCode.localeCompare(a.postCode);
}
case clsStudentInfoEN.con_Email:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.email.localeCompare(a.email);
}
case clsStudentInfoEN.con_IsMessage:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
if (b.isMessage == true) return 1;
else return -1
}
case clsStudentInfoEN.con_Microblog:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.microblog.localeCompare(a.microblog);
}
case clsStudentInfoEN.con_PhoneNumber:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsStudentInfoEN.con_Headphoto:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.headphoto.localeCompare(a.headphoto);
}
case clsStudentInfoEN.con_QQ:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.qQ.localeCompare(a.qQ);
}
case clsStudentInfoEN.con_RegisterPassword:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.registerPassword.localeCompare(a.registerPassword);
}
case clsStudentInfoEN.con_UpdDate:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.updDate.localeCompare(a.updDate);
}
case clsStudentInfoEN.con_UpdUser:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.updUser.localeCompare(a.updUser);
}
case clsStudentInfoEN.con_Memo:
return (a: clsStudentInfoEN, b: clsStudentInfoEN) => {
return b.memo.localeCompare(a.memo);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${ studentInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function StudentInfo_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsStudentInfoEN.con_id_StudentInfo:
return (obj: clsStudentInfoEN) => {
return obj.id_StudentInfo === value;
}
case clsStudentInfoEN.con_StuID:
return (obj: clsStudentInfoEN) => {
return obj.stuID === value;
}
case clsStudentInfoEN.con_StuName:
return (obj: clsStudentInfoEN) => {
return obj.stuName === value;
}
case clsStudentInfoEN.con_id_Politics:
return (obj: clsStudentInfoEN) => {
return obj.id_Politics === value;
}
case clsStudentInfoEN.con_id_Sex:
return (obj: clsStudentInfoEN) => {
return obj.id_Sex === value;
}
case clsStudentInfoEN.con_id_Ethnic:
return (obj: clsStudentInfoEN) => {
return obj.id_Ethnic === value;
}
case clsStudentInfoEN.con_id_UniZone:
return (obj: clsStudentInfoEN) => {
return obj.id_UniZone === value;
}
case clsStudentInfoEN.con_id_StuType:
return (obj: clsStudentInfoEN) => {
return obj.id_StuType === value;
}
case clsStudentInfoEN.con_id_XzCollege:
return (obj: clsStudentInfoEN) => {
return obj.id_XzCollege === value;
}
case clsStudentInfoEN.con_id_XzMajor:
return (obj: clsStudentInfoEN) => {
return obj.id_XzMajor === value;
}
case clsStudentInfoEN.con_id_GradeBase:
return (obj: clsStudentInfoEN) => {
return obj.id_GradeBase === value;
}
case clsStudentInfoEN.con_id_AdminCls:
return (obj: clsStudentInfoEN) => {
return obj.id_AdminCls === value;
}
case clsStudentInfoEN.con_Birthday:
return (obj: clsStudentInfoEN) => {
return obj.birthday === value;
}
case clsStudentInfoEN.con_NativePlace:
return (obj: clsStudentInfoEN) => {
return obj.nativePlace === value;
}
case clsStudentInfoEN.con_Duty:
return (obj: clsStudentInfoEN) => {
return obj.duty === value;
}
case clsStudentInfoEN.con_IDCardNo:
return (obj: clsStudentInfoEN) => {
return obj.idCardNo === value;
}
case clsStudentInfoEN.con_StuCardNo:
return (obj: clsStudentInfoEN) => {
return obj.stuCardNo === value;
}
case clsStudentInfoEN.con_LiveAddress:
return (obj: clsStudentInfoEN) => {
return obj.liveAddress === value;
}
case clsStudentInfoEN.con_HomePhone:
return (obj: clsStudentInfoEN) => {
return obj.homePhone === value;
}
case clsStudentInfoEN.con_Id_CardNo:
return (obj: clsStudentInfoEN) => {
return obj.id_CardNo === value;
}
case clsStudentInfoEN.con_CardNo:
return (obj: clsStudentInfoEN) => {
return obj.cardNo === value;
}
case clsStudentInfoEN.con_IsAvconClassUser:
return (obj: clsStudentInfoEN) => {
return obj.isAvconClassUser === value;
}
case clsStudentInfoEN.con_IsAvconUser:
return (obj: clsStudentInfoEN) => {
return obj.isAvconUser === value;
}
case clsStudentInfoEN.con_IsGpUser:
return (obj: clsStudentInfoEN) => {
return obj.isGpUser === value;
}
case clsStudentInfoEN.con_IsLocalUser:
return (obj: clsStudentInfoEN) => {
return obj.isLocalUser === value;
}
case clsStudentInfoEN.con_IsLeaved:
return (obj: clsStudentInfoEN) => {
return obj.isLeaved === value;
}
case clsStudentInfoEN.con_UserId:
return (obj: clsStudentInfoEN) => {
return obj.userId === value;
}
case clsStudentInfoEN.con_UserID4Avcon:
return (obj: clsStudentInfoEN) => {
return obj.userID4Avcon === value;
}
case clsStudentInfoEN.con_EnrollmentDate:
return (obj: clsStudentInfoEN) => {
return obj.enrollmentDate === value;
}
case clsStudentInfoEN.con_PostCode:
return (obj: clsStudentInfoEN) => {
return obj.postCode === value;
}
case clsStudentInfoEN.con_Email:
return (obj: clsStudentInfoEN) => {
return obj.email === value;
}
case clsStudentInfoEN.con_IsMessage:
return (obj: clsStudentInfoEN) => {
return obj.isMessage === value;
}
case clsStudentInfoEN.con_Microblog:
return (obj: clsStudentInfoEN) => {
return obj.microblog === value;
}
case clsStudentInfoEN.con_PhoneNumber:
return (obj: clsStudentInfoEN) => {
return obj.phoneNumber === value;
}
case clsStudentInfoEN.con_Headphoto:
return (obj: clsStudentInfoEN) => {
return obj.headphoto === value;
}
case clsStudentInfoEN.con_QQ:
return (obj: clsStudentInfoEN) => {
return obj.qQ === value;
}
case clsStudentInfoEN.con_RegisterPassword:
return (obj: clsStudentInfoEN) => {
return obj.registerPassword === value;
}
case clsStudentInfoEN.con_UpdDate:
return (obj: clsStudentInfoEN) => {
return obj.updDate === value;
}
case clsStudentInfoEN.con_UpdUser:
return (obj: clsStudentInfoEN) => {
return obj.updUser === value;
}
case clsStudentInfoEN.con_Memo:
return (obj: clsStudentInfoEN) => {
return obj.memo === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[StudentInfo]中不存在！(in ${ studentInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function StudentInfo_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetFirstObjAsync(strWhereCond: string): Promise<clsStudentInfoEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objStudentInfo = StudentInfo_GetObjFromJsonObj(returnObj);
return objStudentInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsStudentInfoEN._CurrTabName;
clsStudentInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsStudentInfoEN._CurrTabName);
if (IsNullOrEmpty(clsStudentInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsStudentInfoEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrStudentInfoExObjLst_Cache: Array<clsStudentInfoEN> = CacheHelper.Get(strKey);
const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
return arrStudentInfoObjLst_T;
}
try
{
const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrStudentInfoExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
console.log(strInfo);
return arrStudentInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function StudentInfo_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsStudentInfoEN._CurrTabName;
clsStudentInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsStudentInfoEN._CurrTabName);
if (IsNullOrEmpty(clsStudentInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsStudentInfoEN.CacheAddiCondition);
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
const arrStudentInfoExObjLst_Cache: Array<clsStudentInfoEN> = JSON.parse(strTempObjLst);
const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
return arrStudentInfoObjLst_T;
}
try
{
const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrStudentInfoExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
console.log(strInfo);
return arrStudentInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function StudentInfo_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsStudentInfoEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrStudentInfoObjLst_Cache: Array<clsStudentInfoEN> = JSON.parse(strTempObjLst);
return arrStudentInfoObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function StudentInfo_GetObjLstAsync(strWhereCond: string): Promise<Array<clsStudentInfoEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsStudentInfoEN._CurrTabName;
clsStudentInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsStudentInfoEN._CurrTabName);
if (IsNullOrEmpty(clsStudentInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsStudentInfoEN.CacheAddiCondition);
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
const arrStudentInfoExObjLst_Cache: Array<clsStudentInfoEN> = JSON.parse(strTempObjLst);
const arrStudentInfoObjLst_T = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoExObjLst_Cache);
return arrStudentInfoObjLst_T;
}
try
{
const arrStudentInfoExObjLst = await StudentInfo_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrStudentInfoExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrStudentInfoExObjLst.length);
console.log(strInfo);
return arrStudentInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function StudentInfo_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsStudentInfoEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrStudentInfoObjLst_Cache: Array<clsStudentInfoEN> = JSON.parse(strTempObjLst);
return arrStudentInfoObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function StudentInfo_GetObjLst_Cache(): Promise<Array<clsStudentInfoEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrStudentInfoObjLst_Cache;
switch (clsStudentInfoEN.CacheModeId)
{
case "04"://sessionStorage
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_ClientCache();
break;
default:
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_ClientCache();
break;
}
const arrStudentInfoObjLst = StudentInfo_GetObjLstByJSONObjLst(arrStudentInfoObjLst_Cache);
return arrStudentInfoObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function StudentInfo_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrStudentInfoObjLst_Cache;
switch (clsStudentInfoEN.CacheModeId)
{
case "04"://sessionStorage
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrStudentInfoObjLst_Cache = null;
break;
default:
arrStudentInfoObjLst_Cache = null;
break;
}
return arrStudentInfoObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_StudentInfo_Cond:条件对象
 * @returns 对象列表子集
*/
export async function StudentInfo_GetSubObjLst_Cache(objStudentInfo_Cond: clsStudentInfoEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
let arrStudentInfo_Sel: Array < clsStudentInfoEN > = arrStudentInfoObjLst_Cache;
if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "") return arrStudentInfo_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
//console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objStudentInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objStudentInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrStudentInfo_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objStudentInfo_Cond), studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsStudentInfoEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_StudentInfo:关键字列表
 * @returns 对象列表
 **/
export async function StudentInfo_GetObjLstByid_StudentInfoLstAsync(arrid_StudentInfo: Array<string>): Promise<Array<clsStudentInfoEN>>  
{
const strThisFuncName = "GetObjLstByid_StudentInfoLstAsync";
const strAction = "GetObjLstByid_StudentInfoLst";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_StudentInfo);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param arrstrid_StudentInfoLst:关键字列表
 * @returns 对象列表
*/
export async function StudentInfo_GetObjLstByid_StudentInfoLst_Cache(arrid_StudentInfoLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_StudentInfoLst_Cache";
try
{
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
const arrStudentInfo_Sel: Array <clsStudentInfoEN> = arrStudentInfoObjLst_Cache.filter(x => arrid_StudentInfoLst.indexOf(x.id_StudentInfo)>-1);
return arrStudentInfo_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_StudentInfoLst.join(","), studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsStudentInfoEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function StudentInfo_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsStudentInfoEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsStudentInfoEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
if (arrStudentInfoObjLst_Cache.length == 0) return arrStudentInfoObjLst_Cache;
let arrStudentInfo_Sel = arrStudentInfoObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objStudentInfo_Cond = new clsStudentInfoEN();
ObjectAssign(objStudentInfo_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsStudentInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objStudentInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrStudentInfo_Sel.length == 0) return arrStudentInfo_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrStudentInfo_Sel = arrStudentInfo_Sel.sort(StudentInfo_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrStudentInfo_Sel = arrStudentInfo_Sel.sort(objPagerPara.sortFun);
}
arrStudentInfo_Sel = arrStudentInfo_Sel.slice(intStart, intEnd);     
return arrStudentInfo_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsStudentInfoEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function StudentInfo_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsStudentInfoEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", studentInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = StudentInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param strid_StudentInfo:关键字
 * @returns 获取删除的结果
 **/
export async function StudentInfo_DelRecordAsync(strid_StudentInfo: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_StudentInfo);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strid_StudentInfo, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param arrid_StudentInfo:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function StudentInfo_DelStudentInfosAsync(arrid_StudentInfo: Array<string>): Promise<number> 
{
const strThisFuncName = "DelStudentInfosAsync";
const strAction = "DelStudentInfos";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_StudentInfo);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_DelStudentInfosByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelStudentInfosByCondAsync";
const strAction = "DelStudentInfosByCond";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function StudentInfo_AddNewRecordAsync(objStudentInfoEN: clsStudentInfoEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objStudentInfoEN);
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function StudentInfo_AddNewRecordWithMaxIdAsync(objStudentInfoEN: clsStudentInfoEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function StudentInfo_AddNewRecordWithReturnKeyAsync(objStudentInfoEN: clsStudentInfoEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function StudentInfo_AddNewRecordWithReturnKey(objStudentInfoEN: clsStudentInfoEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objStudentInfoEN.id_StudentInfo === null || objStudentInfoEN.id_StudentInfo === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function StudentInfo_UpdateRecordAsync(objStudentInfoEN: clsStudentInfoEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objStudentInfoEN.sf_UpdFldSetStr === undefined || objStudentInfoEN.sf_UpdFldSetStr === null || objStudentInfoEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objStudentInfoEN.id_StudentInfo);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfoEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function StudentInfo_UpdateWithConditionAsync(objStudentInfoEN: clsStudentInfoEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objStudentInfoEN.sf_UpdFldSetStr === undefined || objStudentInfoEN.sf_UpdFldSetStr === null || objStudentInfoEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objStudentInfoEN.id_StudentInfo);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
objStudentInfoEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objStudentInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objstrid_StudentInfo_Cond:条件对象
 * @returns 对象列表子集
*/
export async function StudentInfo_IsExistRecord_Cache(objStudentInfo_Cond: clsStudentInfoEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
if (arrStudentInfoObjLst_Cache == null) return false;
let arrStudentInfo_Sel: Array < clsStudentInfoEN > = arrStudentInfoObjLst_Cache;
if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "") return arrStudentInfo_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
//console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objStudentInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objStudentInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrStudentInfo_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objStudentInfo_Cond), studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param strid_StudentInfo:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function StudentInfo_IsExist(strid_StudentInfo: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_StudentInfo": strid_StudentInfo,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param strid_StudentInfo:所给的关键字
 * @returns 对象
*/
export async function StudentInfo_IsExist_Cache(strid_StudentInfo:string) {
const strThisFuncName = "IsExist_Cache";
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
if (arrStudentInfoObjLst_Cache == null) return false;
try
{
const arrStudentInfo_Sel: Array <clsStudentInfoEN> = arrStudentInfoObjLst_Cache.filter(x => x.id_StudentInfo == strid_StudentInfo);
if (arrStudentInfo_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_StudentInfo, studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_StudentInfo:关键字
 * @returns 是否存在?存在返回True
 **/
export async function StudentInfo_IsExistAsync(strid_StudentInfo: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_StudentInfo": strid_StudentInfo }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export async function StudentInfo_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
 * @param objStudentInfo_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function StudentInfo_GetRecCountByCond_Cache(objStudentInfo_Cond: clsStudentInfoEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrStudentInfoObjLst_Cache = await StudentInfo_GetObjLst_Cache();
if (arrStudentInfoObjLst_Cache == null) return 0;
let arrStudentInfo_Sel: Array < clsStudentInfoEN > = arrStudentInfoObjLst_Cache;
if (objStudentInfo_Cond.sf_FldComparisonOp == null || objStudentInfo_Cond.sf_FldComparisonOp == "") return arrStudentInfo_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objStudentInfo_Cond.sf_FldComparisonOp);
//console.log("clsStudentInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objStudentInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objStudentInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrStudentInfo_Sel = arrStudentInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrStudentInfo_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objStudentInfo_Cond), studentInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return 0;
}

 /**
 * 获取表的最大关键字
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
 * @returns 获取表的最大关键字
 **/
export async function StudentInfo_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else
{
throw(error.statusText);
}
}
}
/*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/

/**
 * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
 * @param mapParam:参数列表
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 获取当前表关键字值的最大值
*/
export async function StudentInfo_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(studentInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, studentInfo_ConstructorName, strThisFuncName);
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
export function StudentInfo_GetWebApiUrl(strController: string, strAction: string): string {
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
export function StudentInfo_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsStudentInfoEN._CurrTabName;
switch (clsStudentInfoEN.CacheModeId)
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
export function StudentInfo_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsStudentInfoEN._CurrTabName;
switch (clsStudentInfoEN.CacheModeId)
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
export function StudentInfo_CheckPropertyNew(pobjStudentInfoEN: clsStudentInfoEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjStudentInfoEN.stuID) === true )
{
 throw new Error("(errid:Watl000058)字段[学号]不能为空(In 学生)!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuName) === true )
{
 throw new Error("(errid:Watl000058)字段[姓名]不能为空(In 学生)!(clsStudentInfoBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjStudentInfoEN.id_StudentInfo) == false && GetStrLen(pobjStudentInfoEN.id_StudentInfo) > 8)
{
 throw new Error("(errid:Watl000059)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StudentInfo)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuID) == false && GetStrLen(pobjStudentInfoEN.stuID) > 20)
{
 throw new Error("(errid:Watl000059)字段[学号(stuID)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuID)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuName) == false && GetStrLen(pobjStudentInfoEN.stuName) > 50)
{
 throw new Error("(errid:Watl000059)字段[姓名(stuName)]的长度不能超过50(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuName)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Politics) == false && GetStrLen(pobjStudentInfoEN.id_Politics) > 4)
{
 throw new Error("(errid:Watl000059)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Politics)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Sex) == false && GetStrLen(pobjStudentInfoEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Sex)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Ethnic) == false && GetStrLen(pobjStudentInfoEN.id_Ethnic) > 4)
{
 throw new Error("(errid:Watl000059)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Ethnic)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_UniZone) == false && GetStrLen(pobjStudentInfoEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_UniZone)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_StuType) == false && GetStrLen(pobjStudentInfoEN.id_StuType) > 4)
{
 throw new Error("(errid:Watl000059)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StuType)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzCollege) == false && GetStrLen(pobjStudentInfoEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzCollege)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzMajor) == false && GetStrLen(pobjStudentInfoEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzMajor)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_GradeBase) == false && GetStrLen(pobjStudentInfoEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000059)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_GradeBase)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_AdminCls) == false && GetStrLen(pobjStudentInfoEN.id_AdminCls) > 8)
{
 throw new Error("(errid:Watl000059)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_AdminCls)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.birthday) == false && GetStrLen(pobjStudentInfoEN.birthday) > 8)
{
 throw new Error("(errid:Watl000059)字段[出生日期(birthday)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.birthday)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.nativePlace) == false && GetStrLen(pobjStudentInfoEN.nativePlace) > 200)
{
 throw new Error("(errid:Watl000059)字段[籍贯(nativePlace)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.nativePlace)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.duty) == false && GetStrLen(pobjStudentInfoEN.duty) > 30)
{
 throw new Error("(errid:Watl000059)字段[职位(duty)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.duty)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.idCardNo) == false && GetStrLen(pobjStudentInfoEN.idCardNo) > 20)
{
 throw new Error("(errid:Watl000059)字段[身份证号(idCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.idCardNo)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuCardNo) == false && GetStrLen(pobjStudentInfoEN.stuCardNo) > 20)
{
 throw new Error("(errid:Watl000059)字段[学生证号(stuCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuCardNo)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.liveAddress) == false && GetStrLen(pobjStudentInfoEN.liveAddress) > 200)
{
 throw new Error("(errid:Watl000059)字段[居住地址(liveAddress)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.liveAddress)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.homePhone) == false && GetStrLen(pobjStudentInfoEN.homePhone) > 20)
{
 throw new Error("(errid:Watl000059)字段[住宅电话(homePhone)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.homePhone)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_CardNo) == false && GetStrLen(pobjStudentInfoEN.id_CardNo) > 20)
{
 throw new Error("(errid:Watl000059)字段[内卡号(id_CardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_CardNo)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.cardNo) == false && GetStrLen(pobjStudentInfoEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.cardNo)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userId) == false && GetStrLen(pobjStudentInfoEN.userId) > 20)
{
 throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userId)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userID4Avcon) == false && GetStrLen(pobjStudentInfoEN.userID4Avcon) > 20)
{
 throw new Error("(errid:Watl000059)字段[UserID4Avcon(userID4Avcon)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userID4Avcon)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.enrollmentDate) == false && GetStrLen(pobjStudentInfoEN.enrollmentDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[入校日期(enrollmentDate)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.enrollmentDate)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.postCode) == false && GetStrLen(pobjStudentInfoEN.postCode) > 6)
{
 throw new Error("(errid:Watl000059)字段[邮编(postCode)]的长度不能超过6(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.postCode)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.email) == false && GetStrLen(pobjStudentInfoEN.email) > 100)
{
 throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.email)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.microblog) == false && GetStrLen(pobjStudentInfoEN.microblog) > 200)
{
 throw new Error("(errid:Watl000059)字段[Microblog(microblog)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.microblog)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.phoneNumber) == false && GetStrLen(pobjStudentInfoEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.phoneNumber)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.headphoto) == false && GetStrLen(pobjStudentInfoEN.headphoto) > 500)
{
 throw new Error("(errid:Watl000059)字段[Headphoto(headphoto)]的长度不能超过500(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.headphoto)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.qQ) == false && GetStrLen(pobjStudentInfoEN.qQ) > 100)
{
 throw new Error("(errid:Watl000059)字段[QQ(qQ)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.qQ)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.registerPassword) == false && GetStrLen(pobjStudentInfoEN.registerPassword) > 30)
{
 throw new Error("(errid:Watl000059)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.registerPassword)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updDate) == false && GetStrLen(pobjStudentInfoEN.updDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updDate)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updUser) == false && GetStrLen(pobjStudentInfoEN.updUser) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updUser)(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.memo) == false && GetStrLen(pobjStudentInfoEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.memo)(clsStudentInfoBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjStudentInfoEN.id_StudentInfo) == false && undefined !== pobjStudentInfoEN.id_StudentInfo && tzDataType.isString(pobjStudentInfoEN.id_StudentInfo) === false)
{
 throw new Error("(errid:Watl000060)字段[学生流水号(id_StudentInfo)]的值:[$(pobjStudentInfoEN.id_StudentInfo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuID) == false && undefined !== pobjStudentInfoEN.stuID && tzDataType.isString(pobjStudentInfoEN.stuID) === false)
{
 throw new Error("(errid:Watl000060)字段[学号(stuID)]的值:[$(pobjStudentInfoEN.stuID)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuName) == false && undefined !== pobjStudentInfoEN.stuName && tzDataType.isString(pobjStudentInfoEN.stuName) === false)
{
 throw new Error("(errid:Watl000060)字段[姓名(stuName)]的值:[$(pobjStudentInfoEN.stuName)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Politics) == false && undefined !== pobjStudentInfoEN.id_Politics && tzDataType.isString(pobjStudentInfoEN.id_Politics) === false)
{
 throw new Error("(errid:Watl000060)字段[政治面貌流水号(id_Politics)]的值:[$(pobjStudentInfoEN.id_Politics)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Sex) == false && undefined !== pobjStudentInfoEN.id_Sex && tzDataType.isString(pobjStudentInfoEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjStudentInfoEN.id_Sex)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Ethnic) == false && undefined !== pobjStudentInfoEN.id_Ethnic && tzDataType.isString(pobjStudentInfoEN.id_Ethnic) === false)
{
 throw new Error("(errid:Watl000060)字段[民族流水号(id_Ethnic)]的值:[$(pobjStudentInfoEN.id_Ethnic)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_UniZone) == false && undefined !== pobjStudentInfoEN.id_UniZone && tzDataType.isString(pobjStudentInfoEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjStudentInfoEN.id_UniZone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_StuType) == false && undefined !== pobjStudentInfoEN.id_StuType && tzDataType.isString(pobjStudentInfoEN.id_StuType) === false)
{
 throw new Error("(errid:Watl000060)字段[学生类别流水号(id_StuType)]的值:[$(pobjStudentInfoEN.id_StuType)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzCollege) == false && undefined !== pobjStudentInfoEN.id_XzCollege && tzDataType.isString(pobjStudentInfoEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjStudentInfoEN.id_XzCollege)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzMajor) == false && undefined !== pobjStudentInfoEN.id_XzMajor && tzDataType.isString(pobjStudentInfoEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjStudentInfoEN.id_XzMajor)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_GradeBase) == false && undefined !== pobjStudentInfoEN.id_GradeBase && tzDataType.isString(pobjStudentInfoEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000060)字段[年级流水号(id_GradeBase)]的值:[$(pobjStudentInfoEN.id_GradeBase)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_AdminCls) == false && undefined !== pobjStudentInfoEN.id_AdminCls && tzDataType.isString(pobjStudentInfoEN.id_AdminCls) === false)
{
 throw new Error("(errid:Watl000060)字段[行政班流水号(id_AdminCls)]的值:[$(pobjStudentInfoEN.id_AdminCls)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.birthday) == false && undefined !== pobjStudentInfoEN.birthday && tzDataType.isString(pobjStudentInfoEN.birthday) === false)
{
 throw new Error("(errid:Watl000060)字段[出生日期(birthday)]的值:[$(pobjStudentInfoEN.birthday)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.nativePlace) == false && undefined !== pobjStudentInfoEN.nativePlace && tzDataType.isString(pobjStudentInfoEN.nativePlace) === false)
{
 throw new Error("(errid:Watl000060)字段[籍贯(nativePlace)]的值:[$(pobjStudentInfoEN.nativePlace)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.duty) == false && undefined !== pobjStudentInfoEN.duty && tzDataType.isString(pobjStudentInfoEN.duty) === false)
{
 throw new Error("(errid:Watl000060)字段[职位(duty)]的值:[$(pobjStudentInfoEN.duty)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.idCardNo) == false && undefined !== pobjStudentInfoEN.idCardNo && tzDataType.isString(pobjStudentInfoEN.idCardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[身份证号(idCardNo)]的值:[$(pobjStudentInfoEN.idCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuCardNo) == false && undefined !== pobjStudentInfoEN.stuCardNo && tzDataType.isString(pobjStudentInfoEN.stuCardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[学生证号(stuCardNo)]的值:[$(pobjStudentInfoEN.stuCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.liveAddress) == false && undefined !== pobjStudentInfoEN.liveAddress && tzDataType.isString(pobjStudentInfoEN.liveAddress) === false)
{
 throw new Error("(errid:Watl000060)字段[居住地址(liveAddress)]的值:[$(pobjStudentInfoEN.liveAddress)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.homePhone) == false && undefined !== pobjStudentInfoEN.homePhone && tzDataType.isString(pobjStudentInfoEN.homePhone) === false)
{
 throw new Error("(errid:Watl000060)字段[住宅电话(homePhone)]的值:[$(pobjStudentInfoEN.homePhone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_CardNo) == false && undefined !== pobjStudentInfoEN.id_CardNo && tzDataType.isString(pobjStudentInfoEN.id_CardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[内卡号(id_CardNo)]的值:[$(pobjStudentInfoEN.id_CardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.cardNo) == false && undefined !== pobjStudentInfoEN.cardNo && tzDataType.isString(pobjStudentInfoEN.cardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjStudentInfoEN.cardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isAvconClassUser && undefined !== pobjStudentInfoEN.isAvconClassUser && tzDataType.isBoolean(pobjStudentInfoEN.isAvconClassUser) === false)
{
 throw new Error("(errid:Watl000060)字段[IsAvconClassUser(isAvconClassUser)]的值:[$(pobjStudentInfoEN.isAvconClassUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isAvconUser && undefined !== pobjStudentInfoEN.isAvconUser && tzDataType.isBoolean(pobjStudentInfoEN.isAvconUser) === false)
{
 throw new Error("(errid:Watl000060)字段[IsAvconUser(isAvconUser)]的值:[$(pobjStudentInfoEN.isAvconUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isGpUser && undefined !== pobjStudentInfoEN.isGpUser && tzDataType.isBoolean(pobjStudentInfoEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjStudentInfoEN.isGpUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isLocalUser && undefined !== pobjStudentInfoEN.isLocalUser && tzDataType.isBoolean(pobjStudentInfoEN.isLocalUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否本地用户(isLocalUser)]的值:[$(pobjStudentInfoEN.isLocalUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isLeaved && undefined !== pobjStudentInfoEN.isLeaved && tzDataType.isBoolean(pobjStudentInfoEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000060)字段[IsLeaved(isLeaved)]的值:[$(pobjStudentInfoEN.isLeaved)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userId) == false && undefined !== pobjStudentInfoEN.userId && tzDataType.isString(pobjStudentInfoEN.userId) === false)
{
 throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjStudentInfoEN.userId)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userID4Avcon) == false && undefined !== pobjStudentInfoEN.userID4Avcon && tzDataType.isString(pobjStudentInfoEN.userID4Avcon) === false)
{
 throw new Error("(errid:Watl000060)字段[UserID4Avcon(userID4Avcon)]的值:[$(pobjStudentInfoEN.userID4Avcon)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.enrollmentDate) == false && undefined !== pobjStudentInfoEN.enrollmentDate && tzDataType.isString(pobjStudentInfoEN.enrollmentDate) === false)
{
 throw new Error("(errid:Watl000060)字段[入校日期(enrollmentDate)]的值:[$(pobjStudentInfoEN.enrollmentDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.postCode) == false && undefined !== pobjStudentInfoEN.postCode && tzDataType.isString(pobjStudentInfoEN.postCode) === false)
{
 throw new Error("(errid:Watl000060)字段[邮编(postCode)]的值:[$(pobjStudentInfoEN.postCode)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.email) == false && undefined !== pobjStudentInfoEN.email && tzDataType.isString(pobjStudentInfoEN.email) === false)
{
 throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjStudentInfoEN.email)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (null != pobjStudentInfoEN.isMessage && undefined !== pobjStudentInfoEN.isMessage && tzDataType.isBoolean(pobjStudentInfoEN.isMessage) === false)
{
 throw new Error("(errid:Watl000060)字段[IsMessage(isMessage)]的值:[$(pobjStudentInfoEN.isMessage)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.microblog) == false && undefined !== pobjStudentInfoEN.microblog && tzDataType.isString(pobjStudentInfoEN.microblog) === false)
{
 throw new Error("(errid:Watl000060)字段[Microblog(microblog)]的值:[$(pobjStudentInfoEN.microblog)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.phoneNumber) == false && undefined !== pobjStudentInfoEN.phoneNumber && tzDataType.isString(pobjStudentInfoEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjStudentInfoEN.phoneNumber)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.headphoto) == false && undefined !== pobjStudentInfoEN.headphoto && tzDataType.isString(pobjStudentInfoEN.headphoto) === false)
{
 throw new Error("(errid:Watl000060)字段[Headphoto(headphoto)]的值:[$(pobjStudentInfoEN.headphoto)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.qQ) == false && undefined !== pobjStudentInfoEN.qQ && tzDataType.isString(pobjStudentInfoEN.qQ) === false)
{
 throw new Error("(errid:Watl000060)字段[QQ(qQ)]的值:[$(pobjStudentInfoEN.qQ)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.registerPassword) == false && undefined !== pobjStudentInfoEN.registerPassword && tzDataType.isString(pobjStudentInfoEN.registerPassword) === false)
{
 throw new Error("(errid:Watl000060)字段[RegisterPassword(registerPassword)]的值:[$(pobjStudentInfoEN.registerPassword)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updDate) == false && undefined !== pobjStudentInfoEN.updDate && tzDataType.isString(pobjStudentInfoEN.updDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjStudentInfoEN.updDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updUser) == false && undefined !== pobjStudentInfoEN.updUser && tzDataType.isString(pobjStudentInfoEN.updUser) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjStudentInfoEN.updUser)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.memo) == false && undefined !== pobjStudentInfoEN.memo && tzDataType.isString(pobjStudentInfoEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjStudentInfoEN.memo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjStudentInfoEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function StudentInfo_CheckProperty4Update (pobjStudentInfoEN: clsStudentInfoEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjStudentInfoEN.id_StudentInfo) == false && GetStrLen(pobjStudentInfoEN.id_StudentInfo) > 8)
{
 throw new Error("(errid:Watl000062)字段[学生流水号(id_StudentInfo)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StudentInfo)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuID) == false && GetStrLen(pobjStudentInfoEN.stuID) > 20)
{
 throw new Error("(errid:Watl000062)字段[学号(stuID)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuID)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuName) == false && GetStrLen(pobjStudentInfoEN.stuName) > 50)
{
 throw new Error("(errid:Watl000062)字段[姓名(stuName)]的长度不能超过50(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuName)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Politics) == false && GetStrLen(pobjStudentInfoEN.id_Politics) > 4)
{
 throw new Error("(errid:Watl000062)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Politics)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Sex) == false && GetStrLen(pobjStudentInfoEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Sex)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Ethnic) == false && GetStrLen(pobjStudentInfoEN.id_Ethnic) > 4)
{
 throw new Error("(errid:Watl000062)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_Ethnic)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_UniZone) == false && GetStrLen(pobjStudentInfoEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_UniZone)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_StuType) == false && GetStrLen(pobjStudentInfoEN.id_StuType) > 4)
{
 throw new Error("(errid:Watl000062)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_StuType)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzCollege) == false && GetStrLen(pobjStudentInfoEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzCollege)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzMajor) == false && GetStrLen(pobjStudentInfoEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_XzMajor)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_GradeBase) == false && GetStrLen(pobjStudentInfoEN.id_GradeBase) > 4)
{
 throw new Error("(errid:Watl000062)字段[年级流水号(id_GradeBase)]的长度不能超过4(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_GradeBase)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_AdminCls) == false && GetStrLen(pobjStudentInfoEN.id_AdminCls) > 8)
{
 throw new Error("(errid:Watl000062)字段[行政班流水号(id_AdminCls)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_AdminCls)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.birthday) == false && GetStrLen(pobjStudentInfoEN.birthday) > 8)
{
 throw new Error("(errid:Watl000062)字段[出生日期(birthday)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.birthday)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.nativePlace) == false && GetStrLen(pobjStudentInfoEN.nativePlace) > 200)
{
 throw new Error("(errid:Watl000062)字段[籍贯(nativePlace)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.nativePlace)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.duty) == false && GetStrLen(pobjStudentInfoEN.duty) > 30)
{
 throw new Error("(errid:Watl000062)字段[职位(duty)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.duty)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.idCardNo) == false && GetStrLen(pobjStudentInfoEN.idCardNo) > 20)
{
 throw new Error("(errid:Watl000062)字段[身份证号(idCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.idCardNo)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuCardNo) == false && GetStrLen(pobjStudentInfoEN.stuCardNo) > 20)
{
 throw new Error("(errid:Watl000062)字段[学生证号(stuCardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.stuCardNo)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.liveAddress) == false && GetStrLen(pobjStudentInfoEN.liveAddress) > 200)
{
 throw new Error("(errid:Watl000062)字段[居住地址(liveAddress)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.liveAddress)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.homePhone) == false && GetStrLen(pobjStudentInfoEN.homePhone) > 20)
{
 throw new Error("(errid:Watl000062)字段[住宅电话(homePhone)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.homePhone)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_CardNo) == false && GetStrLen(pobjStudentInfoEN.id_CardNo) > 20)
{
 throw new Error("(errid:Watl000062)字段[内卡号(id_CardNo)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.id_CardNo)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.cardNo) == false && GetStrLen(pobjStudentInfoEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.cardNo)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userId) == false && GetStrLen(pobjStudentInfoEN.userId) > 20)
{
 throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userId)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userID4Avcon) == false && GetStrLen(pobjStudentInfoEN.userID4Avcon) > 20)
{
 throw new Error("(errid:Watl000062)字段[UserID4Avcon(userID4Avcon)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.userID4Avcon)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.enrollmentDate) == false && GetStrLen(pobjStudentInfoEN.enrollmentDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[入校日期(enrollmentDate)]的长度不能超过8(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.enrollmentDate)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.postCode) == false && GetStrLen(pobjStudentInfoEN.postCode) > 6)
{
 throw new Error("(errid:Watl000062)字段[邮编(postCode)]的长度不能超过6(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.postCode)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.email) == false && GetStrLen(pobjStudentInfoEN.email) > 100)
{
 throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.email)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.microblog) == false && GetStrLen(pobjStudentInfoEN.microblog) > 200)
{
 throw new Error("(errid:Watl000062)字段[Microblog(microblog)]的长度不能超过200(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.microblog)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.phoneNumber) == false && GetStrLen(pobjStudentInfoEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.phoneNumber)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.headphoto) == false && GetStrLen(pobjStudentInfoEN.headphoto) > 500)
{
 throw new Error("(errid:Watl000062)字段[Headphoto(headphoto)]的长度不能超过500(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.headphoto)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.qQ) == false && GetStrLen(pobjStudentInfoEN.qQ) > 100)
{
 throw new Error("(errid:Watl000062)字段[QQ(qQ)]的长度不能超过100(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.qQ)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.registerPassword) == false && GetStrLen(pobjStudentInfoEN.registerPassword) > 30)
{
 throw new Error("(errid:Watl000062)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.registerPassword)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updDate) == false && GetStrLen(pobjStudentInfoEN.updDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updDate)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updUser) == false && GetStrLen(pobjStudentInfoEN.updUser) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.updUser)(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.memo) == false && GetStrLen(pobjStudentInfoEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学生(StudentInfo))!值:$(pobjStudentInfoEN.memo)(clsStudentInfoBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjStudentInfoEN.id_StudentInfo) == false && undefined !== pobjStudentInfoEN.id_StudentInfo && tzDataType.isString(pobjStudentInfoEN.id_StudentInfo) === false)
{
 throw new Error("(errid:Watl000063)字段[学生流水号(id_StudentInfo)]的值:[$(pobjStudentInfoEN.id_StudentInfo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuID) == false && undefined !== pobjStudentInfoEN.stuID && tzDataType.isString(pobjStudentInfoEN.stuID) === false)
{
 throw new Error("(errid:Watl000063)字段[学号(stuID)]的值:[$(pobjStudentInfoEN.stuID)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuName) == false && undefined !== pobjStudentInfoEN.stuName && tzDataType.isString(pobjStudentInfoEN.stuName) === false)
{
 throw new Error("(errid:Watl000063)字段[姓名(stuName)]的值:[$(pobjStudentInfoEN.stuName)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Politics) == false && undefined !== pobjStudentInfoEN.id_Politics && tzDataType.isString(pobjStudentInfoEN.id_Politics) === false)
{
 throw new Error("(errid:Watl000063)字段[政治面貌流水号(id_Politics)]的值:[$(pobjStudentInfoEN.id_Politics)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Sex) == false && undefined !== pobjStudentInfoEN.id_Sex && tzDataType.isString(pobjStudentInfoEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjStudentInfoEN.id_Sex)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_Ethnic) == false && undefined !== pobjStudentInfoEN.id_Ethnic && tzDataType.isString(pobjStudentInfoEN.id_Ethnic) === false)
{
 throw new Error("(errid:Watl000063)字段[民族流水号(id_Ethnic)]的值:[$(pobjStudentInfoEN.id_Ethnic)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_UniZone) == false && undefined !== pobjStudentInfoEN.id_UniZone && tzDataType.isString(pobjStudentInfoEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjStudentInfoEN.id_UniZone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_StuType) == false && undefined !== pobjStudentInfoEN.id_StuType && tzDataType.isString(pobjStudentInfoEN.id_StuType) === false)
{
 throw new Error("(errid:Watl000063)字段[学生类别流水号(id_StuType)]的值:[$(pobjStudentInfoEN.id_StuType)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzCollege) == false && undefined !== pobjStudentInfoEN.id_XzCollege && tzDataType.isString(pobjStudentInfoEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjStudentInfoEN.id_XzCollege)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_XzMajor) == false && undefined !== pobjStudentInfoEN.id_XzMajor && tzDataType.isString(pobjStudentInfoEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjStudentInfoEN.id_XzMajor)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_GradeBase) == false && undefined !== pobjStudentInfoEN.id_GradeBase && tzDataType.isString(pobjStudentInfoEN.id_GradeBase) === false)
{
 throw new Error("(errid:Watl000063)字段[年级流水号(id_GradeBase)]的值:[$(pobjStudentInfoEN.id_GradeBase)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_AdminCls) == false && undefined !== pobjStudentInfoEN.id_AdminCls && tzDataType.isString(pobjStudentInfoEN.id_AdminCls) === false)
{
 throw new Error("(errid:Watl000063)字段[行政班流水号(id_AdminCls)]的值:[$(pobjStudentInfoEN.id_AdminCls)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.birthday) == false && undefined !== pobjStudentInfoEN.birthday && tzDataType.isString(pobjStudentInfoEN.birthday) === false)
{
 throw new Error("(errid:Watl000063)字段[出生日期(birthday)]的值:[$(pobjStudentInfoEN.birthday)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.nativePlace) == false && undefined !== pobjStudentInfoEN.nativePlace && tzDataType.isString(pobjStudentInfoEN.nativePlace) === false)
{
 throw new Error("(errid:Watl000063)字段[籍贯(nativePlace)]的值:[$(pobjStudentInfoEN.nativePlace)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.duty) == false && undefined !== pobjStudentInfoEN.duty && tzDataType.isString(pobjStudentInfoEN.duty) === false)
{
 throw new Error("(errid:Watl000063)字段[职位(duty)]的值:[$(pobjStudentInfoEN.duty)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.idCardNo) == false && undefined !== pobjStudentInfoEN.idCardNo && tzDataType.isString(pobjStudentInfoEN.idCardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[身份证号(idCardNo)]的值:[$(pobjStudentInfoEN.idCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.stuCardNo) == false && undefined !== pobjStudentInfoEN.stuCardNo && tzDataType.isString(pobjStudentInfoEN.stuCardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[学生证号(stuCardNo)]的值:[$(pobjStudentInfoEN.stuCardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.liveAddress) == false && undefined !== pobjStudentInfoEN.liveAddress && tzDataType.isString(pobjStudentInfoEN.liveAddress) === false)
{
 throw new Error("(errid:Watl000063)字段[居住地址(liveAddress)]的值:[$(pobjStudentInfoEN.liveAddress)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.homePhone) == false && undefined !== pobjStudentInfoEN.homePhone && tzDataType.isString(pobjStudentInfoEN.homePhone) === false)
{
 throw new Error("(errid:Watl000063)字段[住宅电话(homePhone)]的值:[$(pobjStudentInfoEN.homePhone)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.id_CardNo) == false && undefined !== pobjStudentInfoEN.id_CardNo && tzDataType.isString(pobjStudentInfoEN.id_CardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[内卡号(id_CardNo)]的值:[$(pobjStudentInfoEN.id_CardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.cardNo) == false && undefined !== pobjStudentInfoEN.cardNo && tzDataType.isString(pobjStudentInfoEN.cardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjStudentInfoEN.cardNo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isAvconClassUser && undefined !== pobjStudentInfoEN.isAvconClassUser && tzDataType.isBoolean(pobjStudentInfoEN.isAvconClassUser) === false)
{
 throw new Error("(errid:Watl000063)字段[IsAvconClassUser(isAvconClassUser)]的值:[$(pobjStudentInfoEN.isAvconClassUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isAvconUser && undefined !== pobjStudentInfoEN.isAvconUser && tzDataType.isBoolean(pobjStudentInfoEN.isAvconUser) === false)
{
 throw new Error("(errid:Watl000063)字段[IsAvconUser(isAvconUser)]的值:[$(pobjStudentInfoEN.isAvconUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isGpUser && undefined !== pobjStudentInfoEN.isGpUser && tzDataType.isBoolean(pobjStudentInfoEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjStudentInfoEN.isGpUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isLocalUser && undefined !== pobjStudentInfoEN.isLocalUser && tzDataType.isBoolean(pobjStudentInfoEN.isLocalUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否本地用户(isLocalUser)]的值:[$(pobjStudentInfoEN.isLocalUser)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isLeaved && undefined !== pobjStudentInfoEN.isLeaved && tzDataType.isBoolean(pobjStudentInfoEN.isLeaved) === false)
{
 throw new Error("(errid:Watl000063)字段[IsLeaved(isLeaved)]的值:[$(pobjStudentInfoEN.isLeaved)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userId) == false && undefined !== pobjStudentInfoEN.userId && tzDataType.isString(pobjStudentInfoEN.userId) === false)
{
 throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjStudentInfoEN.userId)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.userID4Avcon) == false && undefined !== pobjStudentInfoEN.userID4Avcon && tzDataType.isString(pobjStudentInfoEN.userID4Avcon) === false)
{
 throw new Error("(errid:Watl000063)字段[UserID4Avcon(userID4Avcon)]的值:[$(pobjStudentInfoEN.userID4Avcon)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.enrollmentDate) == false && undefined !== pobjStudentInfoEN.enrollmentDate && tzDataType.isString(pobjStudentInfoEN.enrollmentDate) === false)
{
 throw new Error("(errid:Watl000063)字段[入校日期(enrollmentDate)]的值:[$(pobjStudentInfoEN.enrollmentDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.postCode) == false && undefined !== pobjStudentInfoEN.postCode && tzDataType.isString(pobjStudentInfoEN.postCode) === false)
{
 throw new Error("(errid:Watl000063)字段[邮编(postCode)]的值:[$(pobjStudentInfoEN.postCode)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.email) == false && undefined !== pobjStudentInfoEN.email && tzDataType.isString(pobjStudentInfoEN.email) === false)
{
 throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjStudentInfoEN.email)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (null != pobjStudentInfoEN.isMessage && undefined !== pobjStudentInfoEN.isMessage && tzDataType.isBoolean(pobjStudentInfoEN.isMessage) === false)
{
 throw new Error("(errid:Watl000063)字段[IsMessage(isMessage)]的值:[$(pobjStudentInfoEN.isMessage)], 非法，应该为布尔型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.microblog) == false && undefined !== pobjStudentInfoEN.microblog && tzDataType.isString(pobjStudentInfoEN.microblog) === false)
{
 throw new Error("(errid:Watl000063)字段[Microblog(microblog)]的值:[$(pobjStudentInfoEN.microblog)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.phoneNumber) == false && undefined !== pobjStudentInfoEN.phoneNumber && tzDataType.isString(pobjStudentInfoEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjStudentInfoEN.phoneNumber)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.headphoto) == false && undefined !== pobjStudentInfoEN.headphoto && tzDataType.isString(pobjStudentInfoEN.headphoto) === false)
{
 throw new Error("(errid:Watl000063)字段[Headphoto(headphoto)]的值:[$(pobjStudentInfoEN.headphoto)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.qQ) == false && undefined !== pobjStudentInfoEN.qQ && tzDataType.isString(pobjStudentInfoEN.qQ) === false)
{
 throw new Error("(errid:Watl000063)字段[QQ(qQ)]的值:[$(pobjStudentInfoEN.qQ)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.registerPassword) == false && undefined !== pobjStudentInfoEN.registerPassword && tzDataType.isString(pobjStudentInfoEN.registerPassword) === false)
{
 throw new Error("(errid:Watl000063)字段[RegisterPassword(registerPassword)]的值:[$(pobjStudentInfoEN.registerPassword)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updDate) == false && undefined !== pobjStudentInfoEN.updDate && tzDataType.isString(pobjStudentInfoEN.updDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjStudentInfoEN.updDate)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.updUser) == false && undefined !== pobjStudentInfoEN.updUser && tzDataType.isString(pobjStudentInfoEN.updUser) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjStudentInfoEN.updUser)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjStudentInfoEN.memo) == false && undefined !== pobjStudentInfoEN.memo && tzDataType.isString(pobjStudentInfoEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjStudentInfoEN.memo)], 非法，应该为字符型(In 学生(StudentInfo))!(clsStudentInfoBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjStudentInfoEN.id_StudentInfo) === true )
{
 throw new Error("(errid:Watl000064)字段[学生流水号]不能为空(In 学生)!(clsStudentInfoBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！

 pobjStudentInfoEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function StudentInfo_GetJSONStrByObj (pobjStudentInfoEN: clsStudentInfoEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjStudentInfoEN.sf_UpdFldSetStr = pobjStudentInfoEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjStudentInfoEN);
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
export function StudentInfo_GetObjLstByJSONStr (strJSON: string): Array<clsStudentInfoEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrStudentInfoObjLst = new Array<clsStudentInfoEN>();
if (strJSON === "")
{
return arrStudentInfoObjLst;
}
try
{
arrStudentInfoObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrStudentInfoObjLst;
}
return arrStudentInfoObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrStudentInfoObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function StudentInfo_GetObjLstByJSONObjLst (arrStudentInfoObjLstS: Array<clsStudentInfoEN>): Array<clsStudentInfoEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrStudentInfoObjLst = new Array<clsStudentInfoEN>();
for (const objInFor of arrStudentInfoObjLstS) {
const obj1 = StudentInfo_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrStudentInfoObjLst.push(obj1);
}
return arrStudentInfoObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function StudentInfo_GetObjByJSONStr (strJSON: string): clsStudentInfoEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjStudentInfoEN = new clsStudentInfoEN();
if (strJSON === "")
{
return pobjStudentInfoEN;
}
try
{
pobjStudentInfoEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjStudentInfoEN;
}
return pobjStudentInfoEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function StudentInfo_GetCombineCondition(objStudentInfo_Cond: clsStudentInfoEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_StudentInfo) == true)
{
const strComparisonOp_id_StudentInfo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_StudentInfo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_StudentInfo, objStudentInfo_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_StuID) == true)
{
const strComparisonOp_StuID:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_StuID];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_StuID, objStudentInfo_Cond.stuID, strComparisonOp_StuID);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_StuName) == true)
{
const strComparisonOp_StuName:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_StuName];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_StuName, objStudentInfo_Cond.stuName, strComparisonOp_StuName);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_Politics) == true)
{
const strComparisonOp_id_Politics:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_Politics];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_Politics, objStudentInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_Sex) == true)
{
const strComparisonOp_id_Sex:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_Sex];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_Sex, objStudentInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_Ethnic) == true)
{
const strComparisonOp_id_Ethnic:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_Ethnic];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_Ethnic, objStudentInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_UniZone, objStudentInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_StuType) == true)
{
const strComparisonOp_id_StuType:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_StuType];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_StuType, objStudentInfo_Cond.id_StuType, strComparisonOp_id_StuType);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_XzCollege, objStudentInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_XzMajor, objStudentInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_GradeBase) == true)
{
const strComparisonOp_id_GradeBase:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_GradeBase];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_GradeBase, objStudentInfo_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_id_AdminCls) == true)
{
const strComparisonOp_id_AdminCls:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_id_AdminCls];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_id_AdminCls, objStudentInfo_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Birthday) == true)
{
const strComparisonOp_Birthday:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Birthday];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Birthday, objStudentInfo_Cond.birthday, strComparisonOp_Birthday);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_NativePlace) == true)
{
const strComparisonOp_NativePlace:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_NativePlace];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_NativePlace, objStudentInfo_Cond.nativePlace, strComparisonOp_NativePlace);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Duty) == true)
{
const strComparisonOp_Duty:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Duty];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Duty, objStudentInfo_Cond.duty, strComparisonOp_Duty);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IDCardNo) == true)
{
const strComparisonOp_IDCardNo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_IDCardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_IDCardNo, objStudentInfo_Cond.idCardNo, strComparisonOp_IDCardNo);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_StuCardNo) == true)
{
const strComparisonOp_StuCardNo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_StuCardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_StuCardNo, objStudentInfo_Cond.stuCardNo, strComparisonOp_StuCardNo);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_LiveAddress) == true)
{
const strComparisonOp_LiveAddress:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_LiveAddress];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_LiveAddress, objStudentInfo_Cond.liveAddress, strComparisonOp_LiveAddress);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_HomePhone) == true)
{
const strComparisonOp_HomePhone:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_HomePhone];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_HomePhone, objStudentInfo_Cond.homePhone, strComparisonOp_HomePhone);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Id_CardNo) == true)
{
const strComparisonOp_Id_CardNo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Id_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Id_CardNo, objStudentInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_CardNo) == true)
{
const strComparisonOp_CardNo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_CardNo, objStudentInfo_Cond.cardNo, strComparisonOp_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsAvconClassUser) == true)
{
if (objStudentInfo_Cond.isAvconClassUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsAvconClassUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsAvconClassUser);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsAvconUser) == true)
{
if (objStudentInfo_Cond.isAvconUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsAvconUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsAvconUser);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsGpUser) == true)
{
if (objStudentInfo_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsLocalUser) == true)
{
if (objStudentInfo_Cond.isLocalUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsLocalUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsLocalUser);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsLeaved) == true)
{
if (objStudentInfo_Cond.isLeaved == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsLeaved);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsLeaved);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_UserId) == true)
{
const strComparisonOp_UserId:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_UserId];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_UserId, objStudentInfo_Cond.userId, strComparisonOp_UserId);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_UserID4Avcon) == true)
{
const strComparisonOp_UserID4Avcon:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_UserID4Avcon];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_UserID4Avcon, objStudentInfo_Cond.userID4Avcon, strComparisonOp_UserID4Avcon);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_EnrollmentDate) == true)
{
const strComparisonOp_EnrollmentDate:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_EnrollmentDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_EnrollmentDate, objStudentInfo_Cond.enrollmentDate, strComparisonOp_EnrollmentDate);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_PostCode) == true)
{
const strComparisonOp_PostCode:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_PostCode];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_PostCode, objStudentInfo_Cond.postCode, strComparisonOp_PostCode);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Email) == true)
{
const strComparisonOp_Email:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Email, objStudentInfo_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_IsMessage) == true)
{
if (objStudentInfo_Cond.isMessage == true)
{
strWhereCond += Format(" And {0} = '1'", clsStudentInfoEN.con_IsMessage);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsStudentInfoEN.con_IsMessage);
}
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Microblog) == true)
{
const strComparisonOp_Microblog:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Microblog];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Microblog, objStudentInfo_Cond.microblog, strComparisonOp_Microblog);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_PhoneNumber, objStudentInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Headphoto) == true)
{
const strComparisonOp_Headphoto:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Headphoto];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Headphoto, objStudentInfo_Cond.headphoto, strComparisonOp_Headphoto);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_QQ) == true)
{
const strComparisonOp_QQ:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_QQ];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_QQ, objStudentInfo_Cond.qQ, strComparisonOp_QQ);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_RegisterPassword) == true)
{
const strComparisonOp_RegisterPassword:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_RegisterPassword];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_RegisterPassword, objStudentInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_UpdDate) == true)
{
const strComparisonOp_UpdDate:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_UpdDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_UpdDate, objStudentInfo_Cond.updDate, strComparisonOp_UpdDate);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_UpdUser) == true)
{
const strComparisonOp_UpdUser:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_UpdUser];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_UpdUser, objStudentInfo_Cond.updUser, strComparisonOp_UpdUser);
}
if (Object.prototype.hasOwnProperty.call(objStudentInfo_Cond.dicFldComparisonOp, clsStudentInfoEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objStudentInfo_Cond.dicFldComparisonOp[clsStudentInfoEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsStudentInfoEN.con_Memo, objStudentInfo_Cond.memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--StudentInfo(学生),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strStuID: 学号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function StudentInfo_GetUniCondStr_StuID(objStudentInfoEN: clsStudentInfoEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and StuID = '{0}'", objStudentInfoEN.stuID);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--StudentInfo(学生),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strStuID: 学号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function StudentInfo_GetUniCondStr4Update_StuID(objStudentInfoEN: clsStudentInfoEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_StudentInfo <> '{0}'", objStudentInfoEN.id_StudentInfo);
 strWhereCond +=  Format(" and StuID = '{0}'", objStudentInfoEN.stuID);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objStudentInfoENS:源对象
 * @param objStudentInfoENT:目标对象
*/
export function StudentInfo_CopyObjTo(objStudentInfoENS: clsStudentInfoEN , objStudentInfoENT: clsStudentInfoEN ): void 
{
objStudentInfoENT.id_StudentInfo = objStudentInfoENS.id_StudentInfo; //学生流水号
objStudentInfoENT.stuID = objStudentInfoENS.stuID; //学号
objStudentInfoENT.stuName = objStudentInfoENS.stuName; //姓名
objStudentInfoENT.id_Politics = objStudentInfoENS.id_Politics; //政治面貌流水号
objStudentInfoENT.id_Sex = objStudentInfoENS.id_Sex; //性别流水号
objStudentInfoENT.id_Ethnic = objStudentInfoENS.id_Ethnic; //民族流水号
objStudentInfoENT.id_UniZone = objStudentInfoENS.id_UniZone; //校区流水号
objStudentInfoENT.id_StuType = objStudentInfoENS.id_StuType; //学生类别流水号
objStudentInfoENT.id_XzCollege = objStudentInfoENS.id_XzCollege; //学院流水号
objStudentInfoENT.id_XzMajor = objStudentInfoENS.id_XzMajor; //专业流水号
objStudentInfoENT.id_GradeBase = objStudentInfoENS.id_GradeBase; //年级流水号
objStudentInfoENT.id_AdminCls = objStudentInfoENS.id_AdminCls; //行政班流水号
objStudentInfoENT.birthday = objStudentInfoENS.birthday; //出生日期
objStudentInfoENT.nativePlace = objStudentInfoENS.nativePlace; //籍贯
objStudentInfoENT.duty = objStudentInfoENS.duty; //职位
objStudentInfoENT.idCardNo = objStudentInfoENS.idCardNo; //身份证号
objStudentInfoENT.stuCardNo = objStudentInfoENS.stuCardNo; //学生证号
objStudentInfoENT.liveAddress = objStudentInfoENS.liveAddress; //居住地址
objStudentInfoENT.homePhone = objStudentInfoENS.homePhone; //住宅电话
objStudentInfoENT.id_CardNo = objStudentInfoENS.id_CardNo; //内卡号
objStudentInfoENT.cardNo = objStudentInfoENS.cardNo; //卡号
objStudentInfoENT.isAvconClassUser = objStudentInfoENS.isAvconClassUser; //IsAvconClassUser
objStudentInfoENT.isAvconUser = objStudentInfoENS.isAvconUser; //IsAvconUser
objStudentInfoENT.isGpUser = objStudentInfoENS.isGpUser; //是否Gp用户
objStudentInfoENT.isLocalUser = objStudentInfoENS.isLocalUser; //是否本地用户
objStudentInfoENT.isLeaved = objStudentInfoENS.isLeaved; //IsLeaved
objStudentInfoENT.userId = objStudentInfoENS.userId; //用户ID
objStudentInfoENT.userID4Avcon = objStudentInfoENS.userID4Avcon; //UserID4Avcon
objStudentInfoENT.enrollmentDate = objStudentInfoENS.enrollmentDate; //入校日期
objStudentInfoENT.postCode = objStudentInfoENS.postCode; //邮编
objStudentInfoENT.email = objStudentInfoENS.email; //电子邮箱
objStudentInfoENT.isMessage = objStudentInfoENS.isMessage; //IsMessage
objStudentInfoENT.microblog = objStudentInfoENS.microblog; //Microblog
objStudentInfoENT.phoneNumber = objStudentInfoENS.phoneNumber; //PhoneNumber
objStudentInfoENT.headphoto = objStudentInfoENS.headphoto; //Headphoto
objStudentInfoENT.qQ = objStudentInfoENS.qQ; //QQ
objStudentInfoENT.registerPassword = objStudentInfoENS.registerPassword; //RegisterPassword
objStudentInfoENT.updDate = objStudentInfoENS.updDate; //修改日期
objStudentInfoENT.updUser = objStudentInfoENS.updUser; //修改人
objStudentInfoENT.memo = objStudentInfoENS.memo; //备注
objStudentInfoENT.sf_UpdFldSetStr = objStudentInfoENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objStudentInfoENS:源对象
 * @param objStudentInfoENT:目标对象
*/
export function StudentInfo_GetObjFromJsonObj(objStudentInfoENS: clsStudentInfoEN): clsStudentInfoEN 
{
 const objStudentInfoENT: clsStudentInfoEN = new clsStudentInfoEN();
ObjectAssign(objStudentInfoENT, objStudentInfoENS);
 return objStudentInfoENT;
}