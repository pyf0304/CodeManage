
 /**
 * 类名:clsTeacherInfoWApi
 * 表名:TeacherInfo(01120093)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:05
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
 * 教师(TeacherInfo)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { GetSession_CacheAdditionCondition } from "../../PubFun/CacheHelper.js";
import { clsTeacherInfoEN } from "../../L0_Entity/BaseInfo/clsTeacherInfoEN.js";
import { BindDdl_ObjLstInDiv, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { tzDataType } from "../../PubFun/jsString.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const teacherInfo_Controller = "TeacherInfoApi";
 export const teacherInfo_ConstructorName = "teacherInfo";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_Teacher:关键字
 * @returns 对象
 **/
export async function TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher: string): Promise<clsTeacherInfoEN>  
{
const strThisFuncName = "GetObjByid_TeacherAsync";

if (IsNullOrEmpty(strid_Teacher) == true)
{
  const strMsg = Format("参数:[strid_Teacher]不能为空！(In GetObjByid_TeacherAsync)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Teacher.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
console.error(strMsg);
throw (strMsg);
}
const strAction = "GetObjByid_Teacher";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: {
"strid_Teacher": strid_Teacher,
}
});
const data = response.data;
if (data.errorId == 0)
{
const returnObj = data.returnObj;
if (returnObj == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objTeacherInfo = TeacherInfo_GetObjFromJsonObj(returnObj);
return objTeacherInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param strid_Teacher:所给的关键字
 * @returns 对象
*/
export async function TeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher: string, bolTryAsyncOnce: boolean = true) {
const strThisFuncName = "GetObjByid_Teacher_Cache";

if (IsNullOrEmpty(strid_Teacher) == true)
{
  const strMsg = Format("参数:[strid_Teacher]不能为空！(In GetObjByid_Teacher_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Teacher.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
console.error(strMsg);
throw (strMsg);
}
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
try
{
const arrTeacherInfo_Sel: Array <clsTeacherInfoEN> = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
let objTeacherInfo: clsTeacherInfoEN;
if (arrTeacherInfo_Sel.length > 0)
{
objTeacherInfo = arrTeacherInfo_Sel[0];
return objTeacherInfo;
}
else
{
if (bolTryAsyncOnce == true)
{
objTeacherInfo = await TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
if (objTeacherInfo != null)
{
TeacherInfo_ReFreshThisCache();
return objTeacherInfo;
}
}
return null;
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
}
return null;
}

/**
 * 根据关键字获取相关对象, 从localStorage缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
 * @param strid_Teacher:所给的关键字
 * @returns 对象
*/
export async function TeacherInfo_GetObjByid_Teacher_localStorage(strid_Teacher: string) {
const strThisFuncName = "GetObjByid_Teacher_localStorage";

if (IsNullOrEmpty(strid_Teacher) == true)
{
  const strMsg = Format("参数:[strid_Teacher]不能为空！(In GetObjByid_Teacher_localStorage)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Teacher.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
console.error(strMsg);
throw (strMsg);
}
const strKey = Format("{0}_{1}", clsTeacherInfoEN._CurrTabName, strid_Teacher);
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObj = localStorage.getItem(strKey) as string;
const objTeacherInfo_Cache: clsTeacherInfoEN = JSON.parse(strTempObj);
return objTeacherInfo_Cache;
}
try
{
const objTeacherInfo = await TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
if (objTeacherInfo != null)
{
localStorage.setItem(strKey, JSON.stringify(objTeacherInfo));
const strInfo = Format("Key:[${ strKey}]的缓存已经建立!");
console.log(strInfo);
return objTeacherInfo;
}
return objTeacherInfo;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
return;
}
}

/**
 * 修改在缓存对象列表中的对象, 与后台数据库无关.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
 * @param objTeacherInfo:所给的对象
 * @returns 对象
*/
export async function TeacherInfo_UpdateObjInLst_Cache(objTeacherInfo: clsTeacherInfoEN) {
const strThisFuncName = "UpdateObjInLst_Cache";
try
{
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
const obj = arrTeacherInfoObjLst_Cache.find(x => x.teacherID == objTeacherInfo.teacherID);
if (obj != null)
{
objTeacherInfo.id_Teacher = obj.id_Teacher;
ObjectAssign( obj, objTeacherInfo);
}
else
{
arrTeacherInfoObjLst_Cache.push(objTeacherInfo);
}
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
}

/**
 * 根据关键字获取相关对象的名称属性, 从缓存中获取.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
 * @param strid_Teacher:所给的关键字
 * @returns 对象
*/
export async function TeacherInfo_GetNameByid_Teacher_Cache(strid_Teacher: string) {
const strThisFuncName = "GetNameByid_Teacher_Cache";

if (IsNullOrEmpty(strid_Teacher) == true)
{
  const strMsg = Format("参数:[strid_Teacher]不能为空！(In GetNameByid_Teacher_Cache)");
console.error(strMsg);
 throw (strMsg);
}
if (strid_Teacher.length != 8)
{
const strMsg = Format("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
console.error(strMsg);
throw (strMsg);
}
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
if (arrTeacherInfoObjLst_Cache == null) return "";
try
{
const arrTeacherInfo_Sel: Array <clsTeacherInfoEN> = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
let objTeacherInfo: clsTeacherInfoEN;
if (arrTeacherInfo_Sel.length > 0)
{
objTeacherInfo = arrTeacherInfo_Sel[0];
return objTeacherInfo.teacherName;
}
else
{
return "";
}
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_Teacher);
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
export async function TeacherInfo_func(strInFldName:string , strOutFldName:string ,  strInValue: string) 
{
//const strThisFuncName = "func";

if (strInFldName != clsTeacherInfoEN.con_id_Teacher)
{
const strMsg = Format("输入字段名:[{0}]不正确!", strInFldName);
console.error(strMsg);
throw new Error(strMsg);
}
if (clsTeacherInfoEN.AttributeName.indexOf(strOutFldName) == -1)
{
const strMsg = Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, clsTeacherInfoEN.AttributeName.join(','));
console.error(strMsg);
throw new Error(strMsg);
}
const strid_Teacher = strInValue;
if (IsNullOrEmpty(strInValue) == true)
{
return "";
}
const objTeacherInfo = await TeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher );
if (objTeacherInfo == null) return "";
return objTeacherInfo.GetFldValue(strOutFldName).toString();
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
export function TeacherInfo_SortFun_Defa(a:clsTeacherInfoEN , b:clsTeacherInfoEN): number 
{
const strThisFuncName = "SortFun_Defa";
return a.id_Teacher.localeCompare(b.id_Teacher);
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
export function TeacherInfo_SortFun_Defa_2Fld(a:clsTeacherInfoEN , b:clsTeacherInfoEN): number 
{
const strThisFuncName = "SortFun_Defa_2Fld";
if (a.teacherID == b.teacherID) return a.teacherName.localeCompare(b.teacherName);
else return a.teacherID.localeCompare(b.teacherID);
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
export function TeacherInfo_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsTeacherInfoEN.con_id_Teacher:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Teacher.localeCompare(b.id_Teacher);
}
case clsTeacherInfoEN.con_TeacherID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.teacherID.localeCompare(b.teacherID);
}
case clsTeacherInfoEN.con_TeacherName:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.teacherName.localeCompare(b.teacherName);
}
case clsTeacherInfoEN.con_id_Sex:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Sex.localeCompare(b.id_Sex);
}
case clsTeacherInfoEN.con_id_School_Ps:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_School_Ps.localeCompare(b.id_School_Ps);
}
case clsTeacherInfoEN.con_id_Discipline_Ps:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Discipline_Ps.localeCompare(b.id_Discipline_Ps);
}
case clsTeacherInfoEN.con_id_UniZone:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsTeacherInfoEN.con_id_Ethnic:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Ethnic.localeCompare(b.id_Ethnic);
}
case clsTeacherInfoEN.con_id_Politics:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Politics.localeCompare(b.id_Politics);
}
case clsTeacherInfoEN.con_id_AdminGrade:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_AdminGrade.localeCompare(b.id_AdminGrade);
}
case clsTeacherInfoEN.con_id_ProfGrade:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
}
case clsTeacherInfoEN.con_id_Qualif:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Qualif.localeCompare(b.id_Qualif);
}
case clsTeacherInfoEN.con_id_Degree:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Degree.localeCompare(b.id_Degree);
}
case clsTeacherInfoEN.con_id_StaffType:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_StaffType.localeCompare(b.id_StaffType);
}
case clsTeacherInfoEN.con_id_Province:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Province.localeCompare(b.id_Province);
}
case clsTeacherInfoEN.con_CitizenID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.citizenID.localeCompare(b.citizenID);
}
case clsTeacherInfoEN.con_CardNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.cardNo.localeCompare(b.cardNo);
}
case clsTeacherInfoEN.con_Birthday:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.birthday.localeCompare(b.birthday);
}
case clsTeacherInfoEN.con_GraduationMajor:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.graduationMajor.localeCompare(b.graduationMajor);
}
case clsTeacherInfoEN.con_TelNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.telNo.localeCompare(b.telNo);
}
case clsTeacherInfoEN.con_Email:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.email.localeCompare(b.email);
}
case clsTeacherInfoEN.con_WebSite:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.webSite.localeCompare(b.webSite);
}
case clsTeacherInfoEN.con_PersonBlog:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.personBlog.localeCompare(b.personBlog);
}
case clsTeacherInfoEN.con_EntryDate:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.entryDate.localeCompare(b.entryDate);
}
case clsTeacherInfoEN.con_Offed:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.offed == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_Id_CardNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_CardNo.localeCompare(b.id_CardNo);
}
case clsTeacherInfoEN.con_IsAvconUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.isAvconUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_IsGpUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_IsLocalUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.isLocalUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_FromUnit:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.fromUnit.localeCompare(b.fromUnit);
}
case clsTeacherInfoEN.con_Memo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.memo.localeCompare(b.memo);
}
case clsTeacherInfoEN.con_id_XzCollege:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsTeacherInfoEN.con_id_XzMajor:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsTeacherInfoEN.con_EntryDay:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.entryDay.localeCompare(b.entryDay);
}
case clsTeacherInfoEN.con_id_Photo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Photo.localeCompare(b.id_Photo);
}
case clsTeacherInfoEN.con_id_Religion:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.id_Religion.localeCompare(b.id_Religion);
}
case clsTeacherInfoEN.con_IsMessage:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.isMessage == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_Microblog:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.microblog.localeCompare(b.microblog);
}
case clsTeacherInfoEN.con_ModifyUserID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsTeacherInfoEN.con_OffedBak:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (a.offedBak == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_PhoneNumber:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsTeacherInfoEN.con_QQ:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.qQ.localeCompare(b.qQ);
}
case clsTeacherInfoEN.con_Teach_id_College:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.teach_id_College.localeCompare(b.teach_id_College);
}
case clsTeacherInfoEN.con_Teach_id_Major:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.teach_id_Major.localeCompare(b.teach_id_Major);
}
case clsTeacherInfoEN.con_Tel:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.tel.localeCompare(b.tel);
}
case clsTeacherInfoEN.con_Headphoto:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.headphoto.localeCompare(b.headphoto);
}
case clsTeacherInfoEN.con_ModifyDate:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsTeacherInfoEN.con_RegisterPassword:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.registerPassword.localeCompare(b.registerPassword);
}
case clsTeacherInfoEN.con_TeacherPhoto:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return a.teacherPhoto.localeCompare(b.teacherPhoto);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${ teacherInfo_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsTeacherInfoEN.con_id_Teacher:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Teacher.localeCompare(a.id_Teacher);
}
case clsTeacherInfoEN.con_TeacherID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.teacherID.localeCompare(a.teacherID);
}
case clsTeacherInfoEN.con_TeacherName:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.teacherName.localeCompare(a.teacherName);
}
case clsTeacherInfoEN.con_id_Sex:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Sex.localeCompare(a.id_Sex);
}
case clsTeacherInfoEN.con_id_School_Ps:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_School_Ps.localeCompare(a.id_School_Ps);
}
case clsTeacherInfoEN.con_id_Discipline_Ps:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Discipline_Ps.localeCompare(a.id_Discipline_Ps);
}
case clsTeacherInfoEN.con_id_UniZone:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsTeacherInfoEN.con_id_Ethnic:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Ethnic.localeCompare(a.id_Ethnic);
}
case clsTeacherInfoEN.con_id_Politics:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Politics.localeCompare(a.id_Politics);
}
case clsTeacherInfoEN.con_id_AdminGrade:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_AdminGrade.localeCompare(a.id_AdminGrade);
}
case clsTeacherInfoEN.con_id_ProfGrade:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
}
case clsTeacherInfoEN.con_id_Qualif:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Qualif.localeCompare(a.id_Qualif);
}
case clsTeacherInfoEN.con_id_Degree:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Degree.localeCompare(a.id_Degree);
}
case clsTeacherInfoEN.con_id_StaffType:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_StaffType.localeCompare(a.id_StaffType);
}
case clsTeacherInfoEN.con_id_Province:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Province.localeCompare(a.id_Province);
}
case clsTeacherInfoEN.con_CitizenID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.citizenID.localeCompare(a.citizenID);
}
case clsTeacherInfoEN.con_CardNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.cardNo.localeCompare(a.cardNo);
}
case clsTeacherInfoEN.con_Birthday:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.birthday.localeCompare(a.birthday);
}
case clsTeacherInfoEN.con_GraduationMajor:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.graduationMajor.localeCompare(a.graduationMajor);
}
case clsTeacherInfoEN.con_TelNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.telNo.localeCompare(a.telNo);
}
case clsTeacherInfoEN.con_Email:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.email.localeCompare(a.email);
}
case clsTeacherInfoEN.con_WebSite:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.webSite.localeCompare(a.webSite);
}
case clsTeacherInfoEN.con_PersonBlog:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.personBlog.localeCompare(a.personBlog);
}
case clsTeacherInfoEN.con_EntryDate:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.entryDate.localeCompare(a.entryDate);
}
case clsTeacherInfoEN.con_Offed:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.offed == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_Id_CardNo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_CardNo.localeCompare(a.id_CardNo);
}
case clsTeacherInfoEN.con_IsAvconUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.isAvconUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_IsGpUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_IsLocalUser:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.isLocalUser == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_FromUnit:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.fromUnit.localeCompare(a.fromUnit);
}
case clsTeacherInfoEN.con_Memo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.memo.localeCompare(a.memo);
}
case clsTeacherInfoEN.con_id_XzCollege:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsTeacherInfoEN.con_id_XzMajor:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsTeacherInfoEN.con_EntryDay:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.entryDay.localeCompare(a.entryDay);
}
case clsTeacherInfoEN.con_id_Photo:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Photo.localeCompare(a.id_Photo);
}
case clsTeacherInfoEN.con_id_Religion:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.id_Religion.localeCompare(a.id_Religion);
}
case clsTeacherInfoEN.con_IsMessage:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.isMessage == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_Microblog:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.microblog.localeCompare(a.microblog);
}
case clsTeacherInfoEN.con_ModifyUserID:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsTeacherInfoEN.con_OffedBak:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
if (b.offedBak == true) return 1;
else return -1
}
case clsTeacherInfoEN.con_PhoneNumber:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsTeacherInfoEN.con_QQ:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.qQ.localeCompare(a.qQ);
}
case clsTeacherInfoEN.con_Teach_id_College:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.teach_id_College.localeCompare(a.teach_id_College);
}
case clsTeacherInfoEN.con_Teach_id_Major:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.teach_id_Major.localeCompare(a.teach_id_Major);
}
case clsTeacherInfoEN.con_Tel:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.tel.localeCompare(a.tel);
}
case clsTeacherInfoEN.con_Headphoto:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.headphoto.localeCompare(a.headphoto);
}
case clsTeacherInfoEN.con_ModifyDate:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsTeacherInfoEN.con_RegisterPassword:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.registerPassword.localeCompare(a.registerPassword);
}
case clsTeacherInfoEN.con_TeacherPhoto:
return (a: clsTeacherInfoEN, b: clsTeacherInfoEN) => {
return b.teacherPhoto.localeCompare(a.teacherPhoto);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${ teacherInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function TeacherInfo_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsTeacherInfoEN.con_id_Teacher:
return (obj: clsTeacherInfoEN) => {
return obj.id_Teacher === value;
}
case clsTeacherInfoEN.con_TeacherID:
return (obj: clsTeacherInfoEN) => {
return obj.teacherID === value;
}
case clsTeacherInfoEN.con_TeacherName:
return (obj: clsTeacherInfoEN) => {
return obj.teacherName === value;
}
case clsTeacherInfoEN.con_id_Sex:
return (obj: clsTeacherInfoEN) => {
return obj.id_Sex === value;
}
case clsTeacherInfoEN.con_id_School_Ps:
return (obj: clsTeacherInfoEN) => {
return obj.id_School_Ps === value;
}
case clsTeacherInfoEN.con_id_Discipline_Ps:
return (obj: clsTeacherInfoEN) => {
return obj.id_Discipline_Ps === value;
}
case clsTeacherInfoEN.con_id_UniZone:
return (obj: clsTeacherInfoEN) => {
return obj.id_UniZone === value;
}
case clsTeacherInfoEN.con_id_Ethnic:
return (obj: clsTeacherInfoEN) => {
return obj.id_Ethnic === value;
}
case clsTeacherInfoEN.con_id_Politics:
return (obj: clsTeacherInfoEN) => {
return obj.id_Politics === value;
}
case clsTeacherInfoEN.con_id_AdminGrade:
return (obj: clsTeacherInfoEN) => {
return obj.id_AdminGrade === value;
}
case clsTeacherInfoEN.con_id_ProfGrade:
return (obj: clsTeacherInfoEN) => {
return obj.id_ProfGrade === value;
}
case clsTeacherInfoEN.con_id_Qualif:
return (obj: clsTeacherInfoEN) => {
return obj.id_Qualif === value;
}
case clsTeacherInfoEN.con_id_Degree:
return (obj: clsTeacherInfoEN) => {
return obj.id_Degree === value;
}
case clsTeacherInfoEN.con_id_StaffType:
return (obj: clsTeacherInfoEN) => {
return obj.id_StaffType === value;
}
case clsTeacherInfoEN.con_id_Province:
return (obj: clsTeacherInfoEN) => {
return obj.id_Province === value;
}
case clsTeacherInfoEN.con_CitizenID:
return (obj: clsTeacherInfoEN) => {
return obj.citizenID === value;
}
case clsTeacherInfoEN.con_CardNo:
return (obj: clsTeacherInfoEN) => {
return obj.cardNo === value;
}
case clsTeacherInfoEN.con_Birthday:
return (obj: clsTeacherInfoEN) => {
return obj.birthday === value;
}
case clsTeacherInfoEN.con_GraduationMajor:
return (obj: clsTeacherInfoEN) => {
return obj.graduationMajor === value;
}
case clsTeacherInfoEN.con_TelNo:
return (obj: clsTeacherInfoEN) => {
return obj.telNo === value;
}
case clsTeacherInfoEN.con_Email:
return (obj: clsTeacherInfoEN) => {
return obj.email === value;
}
case clsTeacherInfoEN.con_WebSite:
return (obj: clsTeacherInfoEN) => {
return obj.webSite === value;
}
case clsTeacherInfoEN.con_PersonBlog:
return (obj: clsTeacherInfoEN) => {
return obj.personBlog === value;
}
case clsTeacherInfoEN.con_EntryDate:
return (obj: clsTeacherInfoEN) => {
return obj.entryDate === value;
}
case clsTeacherInfoEN.con_Offed:
return (obj: clsTeacherInfoEN) => {
return obj.offed === value;
}
case clsTeacherInfoEN.con_Id_CardNo:
return (obj: clsTeacherInfoEN) => {
return obj.id_CardNo === value;
}
case clsTeacherInfoEN.con_IsAvconUser:
return (obj: clsTeacherInfoEN) => {
return obj.isAvconUser === value;
}
case clsTeacherInfoEN.con_IsGpUser:
return (obj: clsTeacherInfoEN) => {
return obj.isGpUser === value;
}
case clsTeacherInfoEN.con_IsLocalUser:
return (obj: clsTeacherInfoEN) => {
return obj.isLocalUser === value;
}
case clsTeacherInfoEN.con_FromUnit:
return (obj: clsTeacherInfoEN) => {
return obj.fromUnit === value;
}
case clsTeacherInfoEN.con_Memo:
return (obj: clsTeacherInfoEN) => {
return obj.memo === value;
}
case clsTeacherInfoEN.con_id_XzCollege:
return (obj: clsTeacherInfoEN) => {
return obj.id_XzCollege === value;
}
case clsTeacherInfoEN.con_id_XzMajor:
return (obj: clsTeacherInfoEN) => {
return obj.id_XzMajor === value;
}
case clsTeacherInfoEN.con_EntryDay:
return (obj: clsTeacherInfoEN) => {
return obj.entryDay === value;
}
case clsTeacherInfoEN.con_id_Photo:
return (obj: clsTeacherInfoEN) => {
return obj.id_Photo === value;
}
case clsTeacherInfoEN.con_id_Religion:
return (obj: clsTeacherInfoEN) => {
return obj.id_Religion === value;
}
case clsTeacherInfoEN.con_IsMessage:
return (obj: clsTeacherInfoEN) => {
return obj.isMessage === value;
}
case clsTeacherInfoEN.con_Microblog:
return (obj: clsTeacherInfoEN) => {
return obj.microblog === value;
}
case clsTeacherInfoEN.con_ModifyUserID:
return (obj: clsTeacherInfoEN) => {
return obj.modifyUserID === value;
}
case clsTeacherInfoEN.con_OffedBak:
return (obj: clsTeacherInfoEN) => {
return obj.offedBak === value;
}
case clsTeacherInfoEN.con_PhoneNumber:
return (obj: clsTeacherInfoEN) => {
return obj.phoneNumber === value;
}
case clsTeacherInfoEN.con_QQ:
return (obj: clsTeacherInfoEN) => {
return obj.qQ === value;
}
case clsTeacherInfoEN.con_Teach_id_College:
return (obj: clsTeacherInfoEN) => {
return obj.teach_id_College === value;
}
case clsTeacherInfoEN.con_Teach_id_Major:
return (obj: clsTeacherInfoEN) => {
return obj.teach_id_Major === value;
}
case clsTeacherInfoEN.con_Tel:
return (obj: clsTeacherInfoEN) => {
return obj.tel === value;
}
case clsTeacherInfoEN.con_Headphoto:
return (obj: clsTeacherInfoEN) => {
return obj.headphoto === value;
}
case clsTeacherInfoEN.con_ModifyDate:
return (obj: clsTeacherInfoEN) => {
return obj.modifyDate === value;
}
case clsTeacherInfoEN.con_RegisterPassword:
return (obj: clsTeacherInfoEN) => {
return obj.registerPassword === value;
}
case clsTeacherInfoEN.con_TeacherPhoto:
return (obj: clsTeacherInfoEN) => {
return obj.teacherPhoto === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${ teacherInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function TeacherInfo_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetFirstObjAsync(strWhereCond: string): Promise<clsTeacherInfoEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objTeacherInfo = TeacherInfo_GetObjFromJsonObj(returnObj);
return objTeacherInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetObjLst_ClientCache() 
{
const strThisFuncName = "GetObjLst_ClientCache";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTeacherInfoEN._CurrTabName;
clsTeacherInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsTeacherInfoEN._CurrTabName);
if (IsNullOrEmpty(clsTeacherInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTeacherInfoEN.CacheAddiCondition);
}
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (CacheHelper.Exsits(strKey))
{
//缓存存在，直接返回
const arrTeacherInfoExObjLst_Cache: Array<clsTeacherInfoEN> = CacheHelper.Get(strKey);
const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
return arrTeacherInfoObjLst_T;
}
try
{
const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
CacheHelper.Add(strKey, arrTeacherInfoExObjLst);
const strInfo = Format("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
console.log(strInfo);
return arrTeacherInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TeacherInfo_GetObjLst_localStorage() 
{
const strThisFuncName = "GetObjLst_localStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTeacherInfoEN._CurrTabName;
clsTeacherInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsTeacherInfoEN._CurrTabName);
if (IsNullOrEmpty(clsTeacherInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTeacherInfoEN.CacheAddiCondition);
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
const arrTeacherInfoExObjLst_Cache: Array<clsTeacherInfoEN> = JSON.parse(strTempObjLst);
const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
return arrTeacherInfoObjLst_T;
}
try
{
const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
localStorage.setItem(strKey, JSON.stringify(arrTeacherInfoExObjLst));
const strInfo = Format("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
console.log(strInfo);
return arrTeacherInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TeacherInfo_GetObjLst_localStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_localStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsTeacherInfoEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(localStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = localStorage.getItem(strKey) as string;
const arrTeacherInfoObjLst_Cache: Array<clsTeacherInfoEN> = JSON.parse(strTempObjLst);
return arrTeacherInfoObjLst_Cache;
}
else return null;
}

 /**
 * 根据条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
 * @param strWhereCond:条件
 * @returns 获取的相应对象列表
 **/
export async function TeacherInfo_GetObjLstAsync(strWhereCond: string): Promise<Array<clsTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetObjLst_sessionStorage() 
{
const strThisFuncName = "GetObjLst_sessionStorage";
//初始化列表缓存
let strWhereCond = "1=1";
const strKey = clsTeacherInfoEN._CurrTabName;
clsTeacherInfoEN.CacheAddiCondition = GetSession_CacheAdditionCondition(clsTeacherInfoEN._CurrTabName);
if (IsNullOrEmpty(clsTeacherInfoEN.CacheAddiCondition) == false)
{
strWhereCond += Format(" and {0}", clsTeacherInfoEN.CacheAddiCondition);
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
const arrTeacherInfoExObjLst_Cache: Array<clsTeacherInfoEN> = JSON.parse(strTempObjLst);
const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
return arrTeacherInfoObjLst_T;
}
try
{
const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
sessionStorage.setItem(strKey, JSON.stringify(arrTeacherInfoExObjLst));
const strInfo = Format("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
console.log(strInfo);
return arrTeacherInfoExObjLst;
}
catch (e)
{
const strMsg = Format("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw (strMsg);
}
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TeacherInfo_GetObjLst_sessionStorage_PureCache() 
{
const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
//初始化列表缓存
const strWhereCond = "1=1";
const strKey = clsTeacherInfoEN._CurrTabName;
if (strKey == "")
{
console.error("关键字为空！不正确");
throw new Error("关键字为空！不正确");
}
 if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))
{
//缓存存在，直接返回
const strTempObjLst:string = sessionStorage.getItem(strKey) as string;
const arrTeacherInfoObjLst_Cache: Array<clsTeacherInfoEN> = JSON.parse(strTempObjLst);
return arrTeacherInfoObjLst_Cache;
}
else return null;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TeacherInfo_GetObjLst_Cache(): Promise<Array<clsTeacherInfoEN>> 
{
//const strThisFuncName = "GetObjLst_Cache";
let arrTeacherInfoObjLst_Cache;
switch (clsTeacherInfoEN.CacheModeId)
{
case "04"://sessionStorage
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_sessionStorage();
break;
case "03"://localStorage
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_localStorage();
break;
case "02"://ClientCache
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_ClientCache();
break;
default:
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_ClientCache();
break;
}
const arrTeacherInfoObjLst = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoObjLst_Cache);
return arrTeacherInfoObjLst_Cache;
}

 /**
 * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
 * @returns 从本地缓存中获取的对象列表
 **/
export async function TeacherInfo_GetObjLst_PureCache() 
{
//const strThisFuncName = "GetObjLst_PureCache";
let arrTeacherInfoObjLst_Cache;
switch (clsTeacherInfoEN.CacheModeId)
{
case "04"://sessionStorage
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_sessionStorage_PureCache();
break;
case "03"://localStorage
arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_localStorage_PureCache();
break;
case "02"://ClientCache
arrTeacherInfoObjLst_Cache = null;
break;
default:
arrTeacherInfoObjLst_Cache = null;
break;
}
return arrTeacherInfoObjLst_Cache;
}

/**
 * 根据条件对象, 从缓存的对象列表中获取子集.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
 * @param objstrid_Teacher_Cond:条件对象
 * @returns 对象列表子集
*/
export async function TeacherInfo_GetSubObjLst_Cache(objTeacherInfo_Cond: clsTeacherInfoEN) {
const strThisFuncName = "GetSubObjLst_Cache";
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
let arrTeacherInfo_Sel: Array < clsTeacherInfoEN > = arrTeacherInfoObjLst_Cache;
if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "") return arrTeacherInfo_Sel;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
//console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTeacherInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrTeacherInfo_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify( objTeacherInfo_Cond), teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsTeacherInfoEN>();
}

 /**
 * 根据关键字列表获取相关对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
 * @param arrid_Teacher:关键字列表
 * @returns 对象列表
 **/
export async function TeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher: Array<string>): Promise<Array<clsTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByid_TeacherLstAsync";
const strAction = "GetObjLstByid_TeacherLst";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Teacher);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param arrstrid_TeacherLst:关键字列表
 * @returns 对象列表
*/
export async function TeacherInfo_GetObjLstByid_TeacherLst_Cache(arrid_TeacherLst: Array<string>) {
const strThisFuncName = "GetObjLstByid_TeacherLst_Cache";
try
{
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
const arrTeacherInfo_Sel: Array <clsTeacherInfoEN> = arrTeacherInfoObjLst_Cache.filter(x => arrid_TeacherLst.indexOf(x.id_Teacher)>-1);
return arrTeacherInfo_Sel;
}
catch (e)
{
const strMsg = Format("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_TeacherLst.join(","), teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsTeacherInfoEN>();
}

 /**
 * 根据顶部条件获取相应的记录对象列表
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
 * @param objTopPara:获取顶部对象列表的参数对象
 * @returns 获取的相应对象列表
 **/
export async function TeacherInfo_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsTeacherInfoEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetObjLstByPager_Cache(objPagerPara: stuPagerPara) {
const strThisFuncName = "GetObjLstByPager_Cache";
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
if (arrTeacherInfoObjLst_Cache.length == 0) return arrTeacherInfoObjLst_Cache;
let arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache;
const obj_Cond = JSON.parse(objPagerPara.whereCond);
const objTeacherInfo_Cond = new clsTeacherInfoEN();
ObjectAssign(objTeacherInfo_Cond, obj_Cond);
let dicFldComparisonOp: { [index: string]: string } = {};
if (obj_Cond.sf_FldComparisonOp != "")
{
dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
}
//console.log("clsTeacherInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(obj_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrTeacherInfo_Sel.length == 0) return arrTeacherInfo_Sel;
let intStart: number = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);
if (intStart <= 0) intStart = 0;
const intEnd = intStart + objPagerPara.pageSize;
if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {
const sstrSplit: string[] = objPagerPara.orderBy.split(" ");
let strSortType = "asc";
const strSortFld = sstrSplit[0];
if (sstrSplit.length > 1) strSortType = sstrSplit[1];
arrTeacherInfo_Sel = arrTeacherInfo_Sel.sort(TeacherInfo_SortFunByKey(strSortFld, strSortType));
}
else {
//如果排序字段名[OrderBy]为空，就调用排序函数
arrTeacherInfo_Sel = arrTeacherInfo_Sel.sort(objPagerPara.sortFun);
}
arrTeacherInfo_Sel = arrTeacherInfo_Sel.slice(intStart, intEnd);     
return arrTeacherInfo_Sel;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
throw new Error(strMsg);
}
return new Array<clsTeacherInfoEN>();
}

 /**
 * 根据分页条件获取相应的记录对象列表，只获取一页
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
 * @param objPagerPara:分页获取对象列表的参数对象
 * @returns 获取的相应记录对象列表
 **/
export async function TeacherInfo_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", teacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param strid_Teacher:关键字
 * @returns 获取删除的结果
 **/
export async function TeacherInfo_DelRecordAsync(strid_Teacher: string): Promise<number>  
{
const strThisFuncName = "DelRecordAsync";
const strAction = "DelRecord";
let strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
strUrl = Format("{0}/?Id={1}", strUrl, strid_Teacher);
try
{
const response = await axios.delete(strUrl,
{
params: { "Id": strid_Teacher, }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param arrid_Teacher:关键字列表
 * @returns 实际删除记录的个数
 **/
export async function TeacherInfo_DelTeacherInfosAsync(arrid_Teacher: Array<string>): Promise<number> 
{
const strThisFuncName = "DelTeacherInfosAsync";
const strAction = "DelTeacherInfos";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Teacher);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_DelTeacherInfosByCondAsync(strWhereCond: string): Promise<number> 
{
const strThisFuncName = "DelTeacherInfosByCondAsync";
const strAction = "DelTeacherInfosByCond";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TeacherInfo_AddNewRecordAsync(objTeacherInfoEN: clsTeacherInfoEN): Promise<boolean> 
{
const strThisFuncName = "AddNewRecordAsync";
const strAction = "AddNewRecord";
 //var strJSON = JSON.stringify(objTeacherInfoEN);
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要添加的对象
 * @returns 获取相应的记录的对象
 **/
export async function TeacherInfo_AddNewRecordWithMaxIdAsync(objTeacherInfoEN: clsTeacherInfoEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithMaxIdAsync";
const strAction = "AddNewRecordWithMaxId";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要添加的表对象
 * @returns 返回新添加记录的关键字
 **/
export async function TeacherInfo_AddNewRecordWithReturnKeyAsync(objTeacherInfoEN: clsTeacherInfoEN): Promise<string> 
{
const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
const strAction = "AddNewRecordWithReturnKey";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要添加的表对象
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 返回新添加记录的关键字
*/
export async function TeacherInfo_AddNewRecordWithReturnKey(objTeacherInfoEN: clsTeacherInfoEN, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "AddNewRecordWithReturnKey";
const strAction = "AddNewRecordWithReturnKey";
if (objTeacherInfoEN.id_Teacher === null || objTeacherInfoEN.id_Teacher === "")
{
const strMsg = "需要的对象的关键字为空，不能添加!";
console.error(strMsg);
throw new Error(strMsg);
}
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要添加的对象
 * @returns 获取修改是否成功？
 **/
export async function TeacherInfo_UpdateRecordAsync(objTeacherInfoEN: clsTeacherInfoEN): Promise<boolean>  
{
const strThisFuncName = "UpdateRecordAsync";
const strAction = "UpdateRecord";
 if (objTeacherInfoEN.sf_UpdFldSetStr === undefined || objTeacherInfoEN.sf_UpdFldSetStr === null || objTeacherInfoEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTeacherInfoEN.id_Teacher);
 throw strMsg;
 }
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfoEN:需要修改的对象
 * @param strWhereCond:条件串
 * @returns 返回的第一条记录的关键字值
 **/
export async function TeacherInfo_UpdateWithConditionAsync(objTeacherInfoEN: clsTeacherInfoEN, strWhereCond: string ): Promise<boolean> 
{
const strThisFuncName = "UpdateWithConditionAsync";
const strAction = "UpdateWithCondition";
 if (objTeacherInfoEN.sf_UpdFldSetStr === undefined || objTeacherInfoEN.sf_UpdFldSetStr === null || objTeacherInfoEN.sf_UpdFldSetStr === "")
{
const strMsg = Format("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTeacherInfoEN.id_Teacher);
 throw new Error(strMsg);
 }
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
objTeacherInfoEN.whereCond = strWhereCond;
try
{
const response = await axios.post(strUrl, objTeacherInfoEN);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objstrid_Teacher_Cond:条件对象
 * @returns 对象列表子集
*/
export async function TeacherInfo_IsExistRecord_Cache(objTeacherInfo_Cond: clsTeacherInfoEN) {
const strThisFuncName = "IsExistRecord_Cache";
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
if (arrTeacherInfoObjLst_Cache == null) return false;
let arrTeacherInfo_Sel: Array < clsTeacherInfoEN > = arrTeacherInfoObjLst_Cache;
if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "") return arrTeacherInfo_Sel.length>0?true:false;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
//console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTeacherInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
if (arrTeacherInfo_Sel.length > 0)
{
return true;
}
else
{
return false;
}
}
catch (e) {
const strMsg = Format("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify( objTeacherInfo_Cond), teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param strid_Teacher:关键字
 * @param cb:CallBack函数，用于显示正确结果数据
 * @param errorCb:CallBack函数，用于显示错误信息
 * @returns 是否存在?存在返回True
*/
export async function TeacherInfo_IsExist(strid_Teacher: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { 
"id_Teacher": strid_Teacher,
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param strid_Teacher:所给的关键字
 * @returns 对象
*/
export async function TeacherInfo_IsExist_Cache(strid_Teacher:string) {
const strThisFuncName = "IsExist_Cache";
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
if (arrTeacherInfoObjLst_Cache == null) return false;
try
{
const arrTeacherInfo_Sel: Array <clsTeacherInfoEN> = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
if (arrTeacherInfo_Sel.length > 0)
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
const strMsg = Format("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Teacher, teacherInfo_ConstructorName, strThisFuncName);
console.error(strMsg);
alert(strMsg);
}
return false;
}

 /**
 * 根据关键字判断是否存在记录
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
 * @param strid_Teacher:关键字
 * @returns 是否存在?存在返回True
 **/
export async function TeacherInfo_IsExistAsync(strid_Teacher: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
try
{
const response = await axios.get(strUrl,
{
params: { "strid_Teacher": strid_Teacher }
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
 * @param objTeacherInfo_Cond:条件对象
 * @returns 对象列表记录数
*/
export async function TeacherInfo_GetRecCountByCond_Cache(objTeacherInfo_Cond: clsTeacherInfoEN) {
const strThisFuncName = "GetRecCountByCond_Cache";
const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
if (arrTeacherInfoObjLst_Cache == null) return 0;
let arrTeacherInfo_Sel: Array < clsTeacherInfoEN > = arrTeacherInfoObjLst_Cache;
if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "") return arrTeacherInfo_Sel.length;
const dicFldComparisonOp: { [index: string]: string } = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
//console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
//console.log(dicFldComparisonOp);
try {
const sstrKeys = GetObjKeys(objTeacherInfo_Cond);
//console.log(sstrKeys);
for (const strKey of sstrKeys) {
if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
const strComparisonOp = dicFldComparisonOp[strKey];
const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
const strType = typeof(strValue);
switch (strType) {
case "string":
if (strValue == null) continue;
if (strValue == "") continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
}
else if (strComparisonOp == "like") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
}
else if (strComparisonOp == "in") {
const arrValues = strValue.toString().split(',');
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
}
break;
case "boolean":
if (strValue == null) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
break;
case "number":
if (Number(strValue) == 0) continue;
if (strComparisonOp == "=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
}
else if (strComparisonOp == ">=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
}
else if (strComparisonOp == "<=") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
else if (strComparisonOp == ">") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
}
else if (strComparisonOp == "<") {
arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
}
break;
}
}
return arrTeacherInfo_Sel.length;
}
catch (e) {
const strMsg = Format("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify( objTeacherInfo_Cond), teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetMaxStrIdAsync(): Promise<string>  
{
const strThisFuncName = "GetMaxStrIdAsync";
const strAction = "GetMaxStrId";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export async function TeacherInfo_GetMaxStrIdByPrefix(strPrefix: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetMaxStrIdByPrefix";
const strAction = "GetMaxStrIdByPrefix";
const strUrl = GetWebApiUrl(teacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, teacherInfo_ConstructorName, strThisFuncName);
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
export function TeacherInfo_GetWebApiUrl(strController: string, strAction: string): string {
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
export function TeacherInfo_ReFreshCache():void
{
const strThisFuncName = "ReFreshCache";

 const strMsg:string = Format("刷新缓存成功！");
console.trace(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
const strKey = clsTeacherInfoEN._CurrTabName;
switch (clsTeacherInfoEN.CacheModeId)
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
export function TeacherInfo_ReFreshThisCache():void
{
const strThisFuncName = "ReFreshThisCache";
if (clsSysPara4WebApi.spSetRefreshCacheOn == true)
{
const strKey = clsTeacherInfoEN._CurrTabName;
switch (clsTeacherInfoEN.CacheModeId)
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
export async function TeacherInfo_BindDdl_id_TeacherInDiv_Cache(strDivName: string, strDdlName: string )
{
const strThisFuncName = "BindDdl_id_TeacherInDiv_Cache";

const objDdl = document.getElementById(strDdlName);
if (objDdl == null)
{
const strMsg = Format("下拉框：{0} 不存在！(In BindDdl_id_TeacherInDiv)", strDdlName);
alert(strMsg);
console.error(strMsg);
throw (strMsg);
}
//为数据源于表的下拉框设置内容
//console.log("开始：BindDdl_id_TeacherInDiv_Cache");
const arrObjLst_Sel = await TeacherInfo_GetObjLst_Cache();
if (arrObjLst_Sel == null) return;
BindDdl_ObjLstInDiv(strDivName, strDdlName, arrObjLst_Sel, clsTeacherInfoEN.con_id_Teacher, clsTeacherInfoEN.con_TeacherName, "教师");
}

/**
 * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TeacherInfo_CheckPropertyNew(pobjTeacherInfoEN: clsTeacherInfoEN)
{
//检查字段非空， 即数据表要求非常非空的字段，不能为空！
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherID) === true )
{
 throw new Error("(errid:Watl000058)字段[教师工号]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherName) === true )
{
 throw new Error("(errid:Watl000058)字段[教师姓名]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Sex) === true )
{
 throw new Error("(errid:Watl000058)字段[性别流水号]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
}
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Teacher) == false && GetStrLen(pobjTeacherInfoEN.id_Teacher) > 8)
{
 throw new Error("(errid:Watl000059)字段[教师流水号(id_Teacher)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Teacher)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherID) == false && GetStrLen(pobjTeacherInfoEN.teacherID) > 12)
{
 throw new Error("(errid:Watl000059)字段[教师工号(teacherID)]的长度不能超过12(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherID)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherName) == false && GetStrLen(pobjTeacherInfoEN.teacherName) > 50)
{
 throw new Error("(errid:Watl000059)字段[教师姓名(teacherName)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherName)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Sex) == false && GetStrLen(pobjTeacherInfoEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Sex)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_School_Ps) == false && GetStrLen(pobjTeacherInfoEN.id_School_Ps) > 4)
{
 throw new Error("(errid:Watl000059)字段[学校流水号(id_School_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_School_Ps)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Discipline_Ps) == false && GetStrLen(pobjTeacherInfoEN.id_Discipline_Ps) > 4)
{
 throw new Error("(errid:Watl000059)字段[学科流水号(id_Discipline_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Discipline_Ps)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_UniZone) == false && GetStrLen(pobjTeacherInfoEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_UniZone)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Ethnic) == false && GetStrLen(pobjTeacherInfoEN.id_Ethnic) > 4)
{
 throw new Error("(errid:Watl000059)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Ethnic)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Politics) == false && GetStrLen(pobjTeacherInfoEN.id_Politics) > 4)
{
 throw new Error("(errid:Watl000059)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Politics)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_AdminGrade) == false && GetStrLen(pobjTeacherInfoEN.id_AdminGrade) > 4)
{
 throw new Error("(errid:Watl000059)字段[行政职务流水号(id_AdminGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_AdminGrade)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_ProfGrade) == false && GetStrLen(pobjTeacherInfoEN.id_ProfGrade) > 4)
{
 throw new Error("(errid:Watl000059)字段[专业职称流水号(id_ProfGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_ProfGrade)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Qualif) == false && GetStrLen(pobjTeacherInfoEN.id_Qualif) > 4)
{
 throw new Error("(errid:Watl000059)字段[学历流水号(id_Qualif)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Qualif)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Degree) == false && GetStrLen(pobjTeacherInfoEN.id_Degree) > 4)
{
 throw new Error("(errid:Watl000059)字段[学位流水号(id_Degree)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Degree)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && GetStrLen(pobjTeacherInfoEN.id_StaffType) > 4)
{
 throw new Error("(errid:Watl000059)字段[职工类型流水号(id_StaffType)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_StaffType)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Province) == false && GetStrLen(pobjTeacherInfoEN.id_Province) > 4)
{
 throw new Error("(errid:Watl000059)字段[省份流水号(id_Province)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Province)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.citizenID) == false && GetStrLen(pobjTeacherInfoEN.citizenID) > 25)
{
 throw new Error("(errid:Watl000059)字段[身份证号(citizenID)]的长度不能超过25(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.citizenID)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.cardNo) == false && GetStrLen(pobjTeacherInfoEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.cardNo)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.birthday) == false && GetStrLen(pobjTeacherInfoEN.birthday) > 8)
{
 throw new Error("(errid:Watl000059)字段[出生日期(birthday)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.birthday)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.graduationMajor) == false && GetStrLen(pobjTeacherInfoEN.graduationMajor) > 40)
{
 throw new Error("(errid:Watl000059)字段[毕业专业(graduationMajor)]的长度不能超过40(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.graduationMajor)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.telNo) == false && GetStrLen(pobjTeacherInfoEN.telNo) > 50)
{
 throw new Error("(errid:Watl000059)字段[电话(telNo)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.telNo)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.email) == false && GetStrLen(pobjTeacherInfoEN.email) > 100)
{
 throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.email)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.webSite) == false && GetStrLen(pobjTeacherInfoEN.webSite) > 60)
{
 throw new Error("(errid:Watl000059)字段[个人主页(webSite)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.webSite)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.personBlog) == false && GetStrLen(pobjTeacherInfoEN.personBlog) > 60)
{
 throw new Error("(errid:Watl000059)字段[个人博客(personBlog)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.personBlog)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDate) == false && GetStrLen(pobjTeacherInfoEN.entryDate) > 8)
{
 throw new Error("(errid:Watl000059)字段[进校日期(entryDate)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDate)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_CardNo) == false && GetStrLen(pobjTeacherInfoEN.id_CardNo) > 20)
{
 throw new Error("(errid:Watl000059)字段[内卡号(id_CardNo)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_CardNo)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.fromUnit) == false && GetStrLen(pobjTeacherInfoEN.fromUnit) > 100)
{
 throw new Error("(errid:Watl000059)字段[来自单位(fromUnit)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.fromUnit)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.memo) == false && GetStrLen(pobjTeacherInfoEN.memo) > 1000)
{
 throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.memo)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzCollege) == false && GetStrLen(pobjTeacherInfoEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzCollege)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzMajor) == false && GetStrLen(pobjTeacherInfoEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzMajor)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDay) == false && GetStrLen(pobjTeacherInfoEN.entryDay) > 8)
{
 throw new Error("(errid:Watl000059)字段[EntryDay(entryDay)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDay)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Photo) == false && GetStrLen(pobjTeacherInfoEN.id_Photo) > 8)
{
 throw new Error("(errid:Watl000059)字段[id_Photo(id_Photo)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Photo)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Religion) == false && GetStrLen(pobjTeacherInfoEN.id_Religion) > 4)
{
 throw new Error("(errid:Watl000059)字段[id_Religion(id_Religion)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Religion)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.microblog) == false && GetStrLen(pobjTeacherInfoEN.microblog) > 200)
{
 throw new Error("(errid:Watl000059)字段[Microblog(microblog)]的长度不能超过200(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.microblog)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyUserID) == false && GetStrLen(pobjTeacherInfoEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyUserID)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.phoneNumber) == false && GetStrLen(pobjTeacherInfoEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.phoneNumber)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.qQ) == false && GetStrLen(pobjTeacherInfoEN.qQ) > 100)
{
 throw new Error("(errid:Watl000059)字段[QQ(qQ)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.qQ)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_College) == false && GetStrLen(pobjTeacherInfoEN.teach_id_College) > 6)
{
 throw new Error("(errid:Watl000059)字段[Teach_id_College(teach_id_College)]的长度不能超过6(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_College)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_Major) == false && GetStrLen(pobjTeacherInfoEN.teach_id_Major) > 8)
{
 throw new Error("(errid:Watl000059)字段[Teach_id_Major(teach_id_Major)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_Major)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.tel) == false && GetStrLen(pobjTeacherInfoEN.tel) > 50)
{
 throw new Error("(errid:Watl000059)字段[Tel(tel)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.tel)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.headphoto) == false && GetStrLen(pobjTeacherInfoEN.headphoto) > 500)
{
 throw new Error("(errid:Watl000059)字段[Headphoto(headphoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.headphoto)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyDate) == false && GetStrLen(pobjTeacherInfoEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyDate)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.registerPassword) == false && GetStrLen(pobjTeacherInfoEN.registerPassword) > 30)
{
 throw new Error("(errid:Watl000059)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.registerPassword)(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherPhoto) == false && GetStrLen(pobjTeacherInfoEN.teacherPhoto) > 500)
{
 throw new Error("(errid:Watl000059)字段[TeacherPhoto(teacherPhoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherPhoto)(clsTeacherInfoBL:CheckPropertyNew)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Teacher) == false && undefined !== pobjTeacherInfoEN.id_Teacher && tzDataType.isString(pobjTeacherInfoEN.id_Teacher) === false)
{
 throw new Error("(errid:Watl000060)字段[教师流水号(id_Teacher)]的值:[$(pobjTeacherInfoEN.id_Teacher)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherID) == false && undefined !== pobjTeacherInfoEN.teacherID && tzDataType.isString(pobjTeacherInfoEN.teacherID) === false)
{
 throw new Error("(errid:Watl000060)字段[教师工号(teacherID)]的值:[$(pobjTeacherInfoEN.teacherID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherName) == false && undefined !== pobjTeacherInfoEN.teacherName && tzDataType.isString(pobjTeacherInfoEN.teacherName) === false)
{
 throw new Error("(errid:Watl000060)字段[教师姓名(teacherName)]的值:[$(pobjTeacherInfoEN.teacherName)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Sex) == false && undefined !== pobjTeacherInfoEN.id_Sex && tzDataType.isString(pobjTeacherInfoEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjTeacherInfoEN.id_Sex)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_School_Ps) == false && undefined !== pobjTeacherInfoEN.id_School_Ps && tzDataType.isString(pobjTeacherInfoEN.id_School_Ps) === false)
{
 throw new Error("(errid:Watl000060)字段[学校流水号(id_School_Ps)]的值:[$(pobjTeacherInfoEN.id_School_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Discipline_Ps) == false && undefined !== pobjTeacherInfoEN.id_Discipline_Ps && tzDataType.isString(pobjTeacherInfoEN.id_Discipline_Ps) === false)
{
 throw new Error("(errid:Watl000060)字段[学科流水号(id_Discipline_Ps)]的值:[$(pobjTeacherInfoEN.id_Discipline_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_UniZone) == false && undefined !== pobjTeacherInfoEN.id_UniZone && tzDataType.isString(pobjTeacherInfoEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjTeacherInfoEN.id_UniZone)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Ethnic) == false && undefined !== pobjTeacherInfoEN.id_Ethnic && tzDataType.isString(pobjTeacherInfoEN.id_Ethnic) === false)
{
 throw new Error("(errid:Watl000060)字段[民族流水号(id_Ethnic)]的值:[$(pobjTeacherInfoEN.id_Ethnic)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Politics) == false && undefined !== pobjTeacherInfoEN.id_Politics && tzDataType.isString(pobjTeacherInfoEN.id_Politics) === false)
{
 throw new Error("(errid:Watl000060)字段[政治面貌流水号(id_Politics)]的值:[$(pobjTeacherInfoEN.id_Politics)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_AdminGrade) == false && undefined !== pobjTeacherInfoEN.id_AdminGrade && tzDataType.isString(pobjTeacherInfoEN.id_AdminGrade) === false)
{
 throw new Error("(errid:Watl000060)字段[行政职务流水号(id_AdminGrade)]的值:[$(pobjTeacherInfoEN.id_AdminGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_ProfGrade) == false && undefined !== pobjTeacherInfoEN.id_ProfGrade && tzDataType.isString(pobjTeacherInfoEN.id_ProfGrade) === false)
{
 throw new Error("(errid:Watl000060)字段[专业职称流水号(id_ProfGrade)]的值:[$(pobjTeacherInfoEN.id_ProfGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Qualif) == false && undefined !== pobjTeacherInfoEN.id_Qualif && tzDataType.isString(pobjTeacherInfoEN.id_Qualif) === false)
{
 throw new Error("(errid:Watl000060)字段[学历流水号(id_Qualif)]的值:[$(pobjTeacherInfoEN.id_Qualif)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Degree) == false && undefined !== pobjTeacherInfoEN.id_Degree && tzDataType.isString(pobjTeacherInfoEN.id_Degree) === false)
{
 throw new Error("(errid:Watl000060)字段[学位流水号(id_Degree)]的值:[$(pobjTeacherInfoEN.id_Degree)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && undefined !== pobjTeacherInfoEN.id_StaffType && tzDataType.isString(pobjTeacherInfoEN.id_StaffType) === false)
{
 throw new Error("(errid:Watl000060)字段[职工类型流水号(id_StaffType)]的值:[$(pobjTeacherInfoEN.id_StaffType)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Province) == false && undefined !== pobjTeacherInfoEN.id_Province && tzDataType.isString(pobjTeacherInfoEN.id_Province) === false)
{
 throw new Error("(errid:Watl000060)字段[省份流水号(id_Province)]的值:[$(pobjTeacherInfoEN.id_Province)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.citizenID) == false && undefined !== pobjTeacherInfoEN.citizenID && tzDataType.isString(pobjTeacherInfoEN.citizenID) === false)
{
 throw new Error("(errid:Watl000060)字段[身份证号(citizenID)]的值:[$(pobjTeacherInfoEN.citizenID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.cardNo) == false && undefined !== pobjTeacherInfoEN.cardNo && tzDataType.isString(pobjTeacherInfoEN.cardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjTeacherInfoEN.cardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.birthday) == false && undefined !== pobjTeacherInfoEN.birthday && tzDataType.isString(pobjTeacherInfoEN.birthday) === false)
{
 throw new Error("(errid:Watl000060)字段[出生日期(birthday)]的值:[$(pobjTeacherInfoEN.birthday)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.graduationMajor) == false && undefined !== pobjTeacherInfoEN.graduationMajor && tzDataType.isString(pobjTeacherInfoEN.graduationMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[毕业专业(graduationMajor)]的值:[$(pobjTeacherInfoEN.graduationMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.telNo) == false && undefined !== pobjTeacherInfoEN.telNo && tzDataType.isString(pobjTeacherInfoEN.telNo) === false)
{
 throw new Error("(errid:Watl000060)字段[电话(telNo)]的值:[$(pobjTeacherInfoEN.telNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.email) == false && undefined !== pobjTeacherInfoEN.email && tzDataType.isString(pobjTeacherInfoEN.email) === false)
{
 throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjTeacherInfoEN.email)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.webSite) == false && undefined !== pobjTeacherInfoEN.webSite && tzDataType.isString(pobjTeacherInfoEN.webSite) === false)
{
 throw new Error("(errid:Watl000060)字段[个人主页(webSite)]的值:[$(pobjTeacherInfoEN.webSite)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.personBlog) == false && undefined !== pobjTeacherInfoEN.personBlog && tzDataType.isString(pobjTeacherInfoEN.personBlog) === false)
{
 throw new Error("(errid:Watl000060)字段[个人博客(personBlog)]的值:[$(pobjTeacherInfoEN.personBlog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDate) == false && undefined !== pobjTeacherInfoEN.entryDate && tzDataType.isString(pobjTeacherInfoEN.entryDate) === false)
{
 throw new Error("(errid:Watl000060)字段[进校日期(entryDate)]的值:[$(pobjTeacherInfoEN.entryDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.offed && undefined !== pobjTeacherInfoEN.offed && tzDataType.isBoolean(pobjTeacherInfoEN.offed) === false)
{
 throw new Error("(errid:Watl000060)字段[是否离校(offed)]的值:[$(pobjTeacherInfoEN.offed)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_CardNo) == false && undefined !== pobjTeacherInfoEN.id_CardNo && tzDataType.isString(pobjTeacherInfoEN.id_CardNo) === false)
{
 throw new Error("(errid:Watl000060)字段[内卡号(id_CardNo)]的值:[$(pobjTeacherInfoEN.id_CardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.isAvconUser && undefined !== pobjTeacherInfoEN.isAvconUser && tzDataType.isBoolean(pobjTeacherInfoEN.isAvconUser) === false)
{
 throw new Error("(errid:Watl000060)字段[IsAvconUser(isAvconUser)]的值:[$(pobjTeacherInfoEN.isAvconUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.isGpUser && undefined !== pobjTeacherInfoEN.isGpUser && tzDataType.isBoolean(pobjTeacherInfoEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjTeacherInfoEN.isGpUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.isLocalUser && undefined !== pobjTeacherInfoEN.isLocalUser && tzDataType.isBoolean(pobjTeacherInfoEN.isLocalUser) === false)
{
 throw new Error("(errid:Watl000060)字段[是否本地用户(isLocalUser)]的值:[$(pobjTeacherInfoEN.isLocalUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.fromUnit) == false && undefined !== pobjTeacherInfoEN.fromUnit && tzDataType.isString(pobjTeacherInfoEN.fromUnit) === false)
{
 throw new Error("(errid:Watl000060)字段[来自单位(fromUnit)]的值:[$(pobjTeacherInfoEN.fromUnit)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.memo) == false && undefined !== pobjTeacherInfoEN.memo && tzDataType.isString(pobjTeacherInfoEN.memo) === false)
{
 throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTeacherInfoEN.memo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzCollege) == false && undefined !== pobjTeacherInfoEN.id_XzCollege && tzDataType.isString(pobjTeacherInfoEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjTeacherInfoEN.id_XzCollege)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzMajor) == false && undefined !== pobjTeacherInfoEN.id_XzMajor && tzDataType.isString(pobjTeacherInfoEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjTeacherInfoEN.id_XzMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDay) == false && undefined !== pobjTeacherInfoEN.entryDay && tzDataType.isString(pobjTeacherInfoEN.entryDay) === false)
{
 throw new Error("(errid:Watl000060)字段[EntryDay(entryDay)]的值:[$(pobjTeacherInfoEN.entryDay)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Photo) == false && undefined !== pobjTeacherInfoEN.id_Photo && tzDataType.isString(pobjTeacherInfoEN.id_Photo) === false)
{
 throw new Error("(errid:Watl000060)字段[id_Photo(id_Photo)]的值:[$(pobjTeacherInfoEN.id_Photo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Religion) == false && undefined !== pobjTeacherInfoEN.id_Religion && tzDataType.isString(pobjTeacherInfoEN.id_Religion) === false)
{
 throw new Error("(errid:Watl000060)字段[id_Religion(id_Religion)]的值:[$(pobjTeacherInfoEN.id_Religion)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.isMessage && undefined !== pobjTeacherInfoEN.isMessage && tzDataType.isBoolean(pobjTeacherInfoEN.isMessage) === false)
{
 throw new Error("(errid:Watl000060)字段[IsMessage(isMessage)]的值:[$(pobjTeacherInfoEN.isMessage)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.microblog) == false && undefined !== pobjTeacherInfoEN.microblog && tzDataType.isString(pobjTeacherInfoEN.microblog) === false)
{
 throw new Error("(errid:Watl000060)字段[Microblog(microblog)]的值:[$(pobjTeacherInfoEN.microblog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyUserID) == false && undefined !== pobjTeacherInfoEN.modifyUserID && tzDataType.isString(pobjTeacherInfoEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjTeacherInfoEN.modifyUserID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (null != pobjTeacherInfoEN.offedBak && undefined !== pobjTeacherInfoEN.offedBak && tzDataType.isBoolean(pobjTeacherInfoEN.offedBak) === false)
{
 throw new Error("(errid:Watl000060)字段[OffedBak(offedBak)]的值:[$(pobjTeacherInfoEN.offedBak)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.phoneNumber) == false && undefined !== pobjTeacherInfoEN.phoneNumber && tzDataType.isString(pobjTeacherInfoEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjTeacherInfoEN.phoneNumber)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.qQ) == false && undefined !== pobjTeacherInfoEN.qQ && tzDataType.isString(pobjTeacherInfoEN.qQ) === false)
{
 throw new Error("(errid:Watl000060)字段[QQ(qQ)]的值:[$(pobjTeacherInfoEN.qQ)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_College) == false && undefined !== pobjTeacherInfoEN.teach_id_College && tzDataType.isString(pobjTeacherInfoEN.teach_id_College) === false)
{
 throw new Error("(errid:Watl000060)字段[Teach_id_College(teach_id_College)]的值:[$(pobjTeacherInfoEN.teach_id_College)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_Major) == false && undefined !== pobjTeacherInfoEN.teach_id_Major && tzDataType.isString(pobjTeacherInfoEN.teach_id_Major) === false)
{
 throw new Error("(errid:Watl000060)字段[Teach_id_Major(teach_id_Major)]的值:[$(pobjTeacherInfoEN.teach_id_Major)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.tel) == false && undefined !== pobjTeacherInfoEN.tel && tzDataType.isString(pobjTeacherInfoEN.tel) === false)
{
 throw new Error("(errid:Watl000060)字段[Tel(tel)]的值:[$(pobjTeacherInfoEN.tel)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.headphoto) == false && undefined !== pobjTeacherInfoEN.headphoto && tzDataType.isString(pobjTeacherInfoEN.headphoto) === false)
{
 throw new Error("(errid:Watl000060)字段[Headphoto(headphoto)]的值:[$(pobjTeacherInfoEN.headphoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyDate) == false && undefined !== pobjTeacherInfoEN.modifyDate && tzDataType.isString(pobjTeacherInfoEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjTeacherInfoEN.modifyDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.registerPassword) == false && undefined !== pobjTeacherInfoEN.registerPassword && tzDataType.isString(pobjTeacherInfoEN.registerPassword) === false)
{
 throw new Error("(errid:Watl000060)字段[RegisterPassword(registerPassword)]的值:[$(pobjTeacherInfoEN.registerPassword)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherPhoto) == false && undefined !== pobjTeacherInfoEN.teacherPhoto && tzDataType.isString(pobjTeacherInfoEN.teacherPhoto) === false)
{
 throw new Error("(errid:Watl000060)字段[TeacherPhoto(teacherPhoto)]的值:[$(pobjTeacherInfoEN.teacherPhoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && GetStrLen(pobjTeacherInfoEN.id_StaffType) !=  4)
{
 throw ("(errid:Watl000061)字段[职工类型流水号]作为外键字段,长度应该为4(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
}

//设置说明该对象已经检查过了，后面不需要再检查，即非法！
 pobjTeacherInfoEN.SetIsCheckProperty(true);
}
/**
 * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
*/
export function TeacherInfo_CheckProperty4Update (pobjTeacherInfoEN: clsTeacherInfoEN)
{
//检查字段长度， 若字符型字段长度超出规定的长度，即非法！
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Teacher) == false && GetStrLen(pobjTeacherInfoEN.id_Teacher) > 8)
{
 throw new Error("(errid:Watl000062)字段[教师流水号(id_Teacher)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Teacher)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherID) == false && GetStrLen(pobjTeacherInfoEN.teacherID) > 12)
{
 throw new Error("(errid:Watl000062)字段[教师工号(teacherID)]的长度不能超过12(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherID)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherName) == false && GetStrLen(pobjTeacherInfoEN.teacherName) > 50)
{
 throw new Error("(errid:Watl000062)字段[教师姓名(teacherName)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherName)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Sex) == false && GetStrLen(pobjTeacherInfoEN.id_Sex) > 4)
{
 throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Sex)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_School_Ps) == false && GetStrLen(pobjTeacherInfoEN.id_School_Ps) > 4)
{
 throw new Error("(errid:Watl000062)字段[学校流水号(id_School_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_School_Ps)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Discipline_Ps) == false && GetStrLen(pobjTeacherInfoEN.id_Discipline_Ps) > 4)
{
 throw new Error("(errid:Watl000062)字段[学科流水号(id_Discipline_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Discipline_Ps)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_UniZone) == false && GetStrLen(pobjTeacherInfoEN.id_UniZone) > 4)
{
 throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_UniZone)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Ethnic) == false && GetStrLen(pobjTeacherInfoEN.id_Ethnic) > 4)
{
 throw new Error("(errid:Watl000062)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Ethnic)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Politics) == false && GetStrLen(pobjTeacherInfoEN.id_Politics) > 4)
{
 throw new Error("(errid:Watl000062)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Politics)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_AdminGrade) == false && GetStrLen(pobjTeacherInfoEN.id_AdminGrade) > 4)
{
 throw new Error("(errid:Watl000062)字段[行政职务流水号(id_AdminGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_AdminGrade)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_ProfGrade) == false && GetStrLen(pobjTeacherInfoEN.id_ProfGrade) > 4)
{
 throw new Error("(errid:Watl000062)字段[专业职称流水号(id_ProfGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_ProfGrade)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Qualif) == false && GetStrLen(pobjTeacherInfoEN.id_Qualif) > 4)
{
 throw new Error("(errid:Watl000062)字段[学历流水号(id_Qualif)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Qualif)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Degree) == false && GetStrLen(pobjTeacherInfoEN.id_Degree) > 4)
{
 throw new Error("(errid:Watl000062)字段[学位流水号(id_Degree)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Degree)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && GetStrLen(pobjTeacherInfoEN.id_StaffType) > 4)
{
 throw new Error("(errid:Watl000062)字段[职工类型流水号(id_StaffType)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_StaffType)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Province) == false && GetStrLen(pobjTeacherInfoEN.id_Province) > 4)
{
 throw new Error("(errid:Watl000062)字段[省份流水号(id_Province)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Province)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.citizenID) == false && GetStrLen(pobjTeacherInfoEN.citizenID) > 25)
{
 throw new Error("(errid:Watl000062)字段[身份证号(citizenID)]的长度不能超过25(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.citizenID)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.cardNo) == false && GetStrLen(pobjTeacherInfoEN.cardNo) > 18)
{
 throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.cardNo)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.birthday) == false && GetStrLen(pobjTeacherInfoEN.birthday) > 8)
{
 throw new Error("(errid:Watl000062)字段[出生日期(birthday)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.birthday)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.graduationMajor) == false && GetStrLen(pobjTeacherInfoEN.graduationMajor) > 40)
{
 throw new Error("(errid:Watl000062)字段[毕业专业(graduationMajor)]的长度不能超过40(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.graduationMajor)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.telNo) == false && GetStrLen(pobjTeacherInfoEN.telNo) > 50)
{
 throw new Error("(errid:Watl000062)字段[电话(telNo)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.telNo)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.email) == false && GetStrLen(pobjTeacherInfoEN.email) > 100)
{
 throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.email)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.webSite) == false && GetStrLen(pobjTeacherInfoEN.webSite) > 60)
{
 throw new Error("(errid:Watl000062)字段[个人主页(webSite)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.webSite)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.personBlog) == false && GetStrLen(pobjTeacherInfoEN.personBlog) > 60)
{
 throw new Error("(errid:Watl000062)字段[个人博客(personBlog)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.personBlog)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDate) == false && GetStrLen(pobjTeacherInfoEN.entryDate) > 8)
{
 throw new Error("(errid:Watl000062)字段[进校日期(entryDate)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDate)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_CardNo) == false && GetStrLen(pobjTeacherInfoEN.id_CardNo) > 20)
{
 throw new Error("(errid:Watl000062)字段[内卡号(id_CardNo)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_CardNo)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.fromUnit) == false && GetStrLen(pobjTeacherInfoEN.fromUnit) > 100)
{
 throw new Error("(errid:Watl000062)字段[来自单位(fromUnit)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.fromUnit)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.memo) == false && GetStrLen(pobjTeacherInfoEN.memo) > 1000)
{
 throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.memo)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzCollege) == false && GetStrLen(pobjTeacherInfoEN.id_XzCollege) > 4)
{
 throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzCollege)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzMajor) == false && GetStrLen(pobjTeacherInfoEN.id_XzMajor) > 8)
{
 throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzMajor)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDay) == false && GetStrLen(pobjTeacherInfoEN.entryDay) > 8)
{
 throw new Error("(errid:Watl000062)字段[EntryDay(entryDay)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDay)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Photo) == false && GetStrLen(pobjTeacherInfoEN.id_Photo) > 8)
{
 throw new Error("(errid:Watl000062)字段[id_Photo(id_Photo)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Photo)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Religion) == false && GetStrLen(pobjTeacherInfoEN.id_Religion) > 4)
{
 throw new Error("(errid:Watl000062)字段[id_Religion(id_Religion)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Religion)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.microblog) == false && GetStrLen(pobjTeacherInfoEN.microblog) > 200)
{
 throw new Error("(errid:Watl000062)字段[Microblog(microblog)]的长度不能超过200(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.microblog)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyUserID) == false && GetStrLen(pobjTeacherInfoEN.modifyUserID) > 18)
{
 throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyUserID)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.phoneNumber) == false && GetStrLen(pobjTeacherInfoEN.phoneNumber) > 15)
{
 throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.phoneNumber)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.qQ) == false && GetStrLen(pobjTeacherInfoEN.qQ) > 100)
{
 throw new Error("(errid:Watl000062)字段[QQ(qQ)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.qQ)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_College) == false && GetStrLen(pobjTeacherInfoEN.teach_id_College) > 6)
{
 throw new Error("(errid:Watl000062)字段[Teach_id_College(teach_id_College)]的长度不能超过6(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_College)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_Major) == false && GetStrLen(pobjTeacherInfoEN.teach_id_Major) > 8)
{
 throw new Error("(errid:Watl000062)字段[Teach_id_Major(teach_id_Major)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_Major)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.tel) == false && GetStrLen(pobjTeacherInfoEN.tel) > 50)
{
 throw new Error("(errid:Watl000062)字段[Tel(tel)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.tel)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.headphoto) == false && GetStrLen(pobjTeacherInfoEN.headphoto) > 500)
{
 throw new Error("(errid:Watl000062)字段[Headphoto(headphoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.headphoto)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyDate) == false && GetStrLen(pobjTeacherInfoEN.modifyDate) > 20)
{
 throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyDate)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.registerPassword) == false && GetStrLen(pobjTeacherInfoEN.registerPassword) > 30)
{
 throw new Error("(errid:Watl000062)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.registerPassword)(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherPhoto) == false && GetStrLen(pobjTeacherInfoEN.teacherPhoto) > 500)
{
 throw new Error("(errid:Watl000062)字段[TeacherPhoto(teacherPhoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherPhoto)(clsTeacherInfoBL:CheckProperty4Update)");
}
//检查字段的数据类型是否正确
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Teacher) == false && undefined !== pobjTeacherInfoEN.id_Teacher && tzDataType.isString(pobjTeacherInfoEN.id_Teacher) === false)
{
 throw new Error("(errid:Watl000063)字段[教师流水号(id_Teacher)]的值:[$(pobjTeacherInfoEN.id_Teacher)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherID) == false && undefined !== pobjTeacherInfoEN.teacherID && tzDataType.isString(pobjTeacherInfoEN.teacherID) === false)
{
 throw new Error("(errid:Watl000063)字段[教师工号(teacherID)]的值:[$(pobjTeacherInfoEN.teacherID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherName) == false && undefined !== pobjTeacherInfoEN.teacherName && tzDataType.isString(pobjTeacherInfoEN.teacherName) === false)
{
 throw new Error("(errid:Watl000063)字段[教师姓名(teacherName)]的值:[$(pobjTeacherInfoEN.teacherName)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Sex) == false && undefined !== pobjTeacherInfoEN.id_Sex && tzDataType.isString(pobjTeacherInfoEN.id_Sex) === false)
{
 throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjTeacherInfoEN.id_Sex)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_School_Ps) == false && undefined !== pobjTeacherInfoEN.id_School_Ps && tzDataType.isString(pobjTeacherInfoEN.id_School_Ps) === false)
{
 throw new Error("(errid:Watl000063)字段[学校流水号(id_School_Ps)]的值:[$(pobjTeacherInfoEN.id_School_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Discipline_Ps) == false && undefined !== pobjTeacherInfoEN.id_Discipline_Ps && tzDataType.isString(pobjTeacherInfoEN.id_Discipline_Ps) === false)
{
 throw new Error("(errid:Watl000063)字段[学科流水号(id_Discipline_Ps)]的值:[$(pobjTeacherInfoEN.id_Discipline_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_UniZone) == false && undefined !== pobjTeacherInfoEN.id_UniZone && tzDataType.isString(pobjTeacherInfoEN.id_UniZone) === false)
{
 throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjTeacherInfoEN.id_UniZone)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Ethnic) == false && undefined !== pobjTeacherInfoEN.id_Ethnic && tzDataType.isString(pobjTeacherInfoEN.id_Ethnic) === false)
{
 throw new Error("(errid:Watl000063)字段[民族流水号(id_Ethnic)]的值:[$(pobjTeacherInfoEN.id_Ethnic)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Politics) == false && undefined !== pobjTeacherInfoEN.id_Politics && tzDataType.isString(pobjTeacherInfoEN.id_Politics) === false)
{
 throw new Error("(errid:Watl000063)字段[政治面貌流水号(id_Politics)]的值:[$(pobjTeacherInfoEN.id_Politics)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_AdminGrade) == false && undefined !== pobjTeacherInfoEN.id_AdminGrade && tzDataType.isString(pobjTeacherInfoEN.id_AdminGrade) === false)
{
 throw new Error("(errid:Watl000063)字段[行政职务流水号(id_AdminGrade)]的值:[$(pobjTeacherInfoEN.id_AdminGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_ProfGrade) == false && undefined !== pobjTeacherInfoEN.id_ProfGrade && tzDataType.isString(pobjTeacherInfoEN.id_ProfGrade) === false)
{
 throw new Error("(errid:Watl000063)字段[专业职称流水号(id_ProfGrade)]的值:[$(pobjTeacherInfoEN.id_ProfGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Qualif) == false && undefined !== pobjTeacherInfoEN.id_Qualif && tzDataType.isString(pobjTeacherInfoEN.id_Qualif) === false)
{
 throw new Error("(errid:Watl000063)字段[学历流水号(id_Qualif)]的值:[$(pobjTeacherInfoEN.id_Qualif)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Degree) == false && undefined !== pobjTeacherInfoEN.id_Degree && tzDataType.isString(pobjTeacherInfoEN.id_Degree) === false)
{
 throw new Error("(errid:Watl000063)字段[学位流水号(id_Degree)]的值:[$(pobjTeacherInfoEN.id_Degree)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && undefined !== pobjTeacherInfoEN.id_StaffType && tzDataType.isString(pobjTeacherInfoEN.id_StaffType) === false)
{
 throw new Error("(errid:Watl000063)字段[职工类型流水号(id_StaffType)]的值:[$(pobjTeacherInfoEN.id_StaffType)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Province) == false && undefined !== pobjTeacherInfoEN.id_Province && tzDataType.isString(pobjTeacherInfoEN.id_Province) === false)
{
 throw new Error("(errid:Watl000063)字段[省份流水号(id_Province)]的值:[$(pobjTeacherInfoEN.id_Province)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.citizenID) == false && undefined !== pobjTeacherInfoEN.citizenID && tzDataType.isString(pobjTeacherInfoEN.citizenID) === false)
{
 throw new Error("(errid:Watl000063)字段[身份证号(citizenID)]的值:[$(pobjTeacherInfoEN.citizenID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.cardNo) == false && undefined !== pobjTeacherInfoEN.cardNo && tzDataType.isString(pobjTeacherInfoEN.cardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjTeacherInfoEN.cardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.birthday) == false && undefined !== pobjTeacherInfoEN.birthday && tzDataType.isString(pobjTeacherInfoEN.birthday) === false)
{
 throw new Error("(errid:Watl000063)字段[出生日期(birthday)]的值:[$(pobjTeacherInfoEN.birthday)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.graduationMajor) == false && undefined !== pobjTeacherInfoEN.graduationMajor && tzDataType.isString(pobjTeacherInfoEN.graduationMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[毕业专业(graduationMajor)]的值:[$(pobjTeacherInfoEN.graduationMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.telNo) == false && undefined !== pobjTeacherInfoEN.telNo && tzDataType.isString(pobjTeacherInfoEN.telNo) === false)
{
 throw new Error("(errid:Watl000063)字段[电话(telNo)]的值:[$(pobjTeacherInfoEN.telNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.email) == false && undefined !== pobjTeacherInfoEN.email && tzDataType.isString(pobjTeacherInfoEN.email) === false)
{
 throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjTeacherInfoEN.email)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.webSite) == false && undefined !== pobjTeacherInfoEN.webSite && tzDataType.isString(pobjTeacherInfoEN.webSite) === false)
{
 throw new Error("(errid:Watl000063)字段[个人主页(webSite)]的值:[$(pobjTeacherInfoEN.webSite)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.personBlog) == false && undefined !== pobjTeacherInfoEN.personBlog && tzDataType.isString(pobjTeacherInfoEN.personBlog) === false)
{
 throw new Error("(errid:Watl000063)字段[个人博客(personBlog)]的值:[$(pobjTeacherInfoEN.personBlog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDate) == false && undefined !== pobjTeacherInfoEN.entryDate && tzDataType.isString(pobjTeacherInfoEN.entryDate) === false)
{
 throw new Error("(errid:Watl000063)字段[进校日期(entryDate)]的值:[$(pobjTeacherInfoEN.entryDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.offed && undefined !== pobjTeacherInfoEN.offed && tzDataType.isBoolean(pobjTeacherInfoEN.offed) === false)
{
 throw new Error("(errid:Watl000063)字段[是否离校(offed)]的值:[$(pobjTeacherInfoEN.offed)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_CardNo) == false && undefined !== pobjTeacherInfoEN.id_CardNo && tzDataType.isString(pobjTeacherInfoEN.id_CardNo) === false)
{
 throw new Error("(errid:Watl000063)字段[内卡号(id_CardNo)]的值:[$(pobjTeacherInfoEN.id_CardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.isAvconUser && undefined !== pobjTeacherInfoEN.isAvconUser && tzDataType.isBoolean(pobjTeacherInfoEN.isAvconUser) === false)
{
 throw new Error("(errid:Watl000063)字段[IsAvconUser(isAvconUser)]的值:[$(pobjTeacherInfoEN.isAvconUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.isGpUser && undefined !== pobjTeacherInfoEN.isGpUser && tzDataType.isBoolean(pobjTeacherInfoEN.isGpUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjTeacherInfoEN.isGpUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.isLocalUser && undefined !== pobjTeacherInfoEN.isLocalUser && tzDataType.isBoolean(pobjTeacherInfoEN.isLocalUser) === false)
{
 throw new Error("(errid:Watl000063)字段[是否本地用户(isLocalUser)]的值:[$(pobjTeacherInfoEN.isLocalUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.fromUnit) == false && undefined !== pobjTeacherInfoEN.fromUnit && tzDataType.isString(pobjTeacherInfoEN.fromUnit) === false)
{
 throw new Error("(errid:Watl000063)字段[来自单位(fromUnit)]的值:[$(pobjTeacherInfoEN.fromUnit)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.memo) == false && undefined !== pobjTeacherInfoEN.memo && tzDataType.isString(pobjTeacherInfoEN.memo) === false)
{
 throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTeacherInfoEN.memo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzCollege) == false && undefined !== pobjTeacherInfoEN.id_XzCollege && tzDataType.isString(pobjTeacherInfoEN.id_XzCollege) === false)
{
 throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjTeacherInfoEN.id_XzCollege)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_XzMajor) == false && undefined !== pobjTeacherInfoEN.id_XzMajor && tzDataType.isString(pobjTeacherInfoEN.id_XzMajor) === false)
{
 throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjTeacherInfoEN.id_XzMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.entryDay) == false && undefined !== pobjTeacherInfoEN.entryDay && tzDataType.isString(pobjTeacherInfoEN.entryDay) === false)
{
 throw new Error("(errid:Watl000063)字段[EntryDay(entryDay)]的值:[$(pobjTeacherInfoEN.entryDay)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Photo) == false && undefined !== pobjTeacherInfoEN.id_Photo && tzDataType.isString(pobjTeacherInfoEN.id_Photo) === false)
{
 throw new Error("(errid:Watl000063)字段[id_Photo(id_Photo)]的值:[$(pobjTeacherInfoEN.id_Photo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Religion) == false && undefined !== pobjTeacherInfoEN.id_Religion && tzDataType.isString(pobjTeacherInfoEN.id_Religion) === false)
{
 throw new Error("(errid:Watl000063)字段[id_Religion(id_Religion)]的值:[$(pobjTeacherInfoEN.id_Religion)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.isMessage && undefined !== pobjTeacherInfoEN.isMessage && tzDataType.isBoolean(pobjTeacherInfoEN.isMessage) === false)
{
 throw new Error("(errid:Watl000063)字段[IsMessage(isMessage)]的值:[$(pobjTeacherInfoEN.isMessage)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.microblog) == false && undefined !== pobjTeacherInfoEN.microblog && tzDataType.isString(pobjTeacherInfoEN.microblog) === false)
{
 throw new Error("(errid:Watl000063)字段[Microblog(microblog)]的值:[$(pobjTeacherInfoEN.microblog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyUserID) == false && undefined !== pobjTeacherInfoEN.modifyUserID && tzDataType.isString(pobjTeacherInfoEN.modifyUserID) === false)
{
 throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjTeacherInfoEN.modifyUserID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (null != pobjTeacherInfoEN.offedBak && undefined !== pobjTeacherInfoEN.offedBak && tzDataType.isBoolean(pobjTeacherInfoEN.offedBak) === false)
{
 throw new Error("(errid:Watl000063)字段[OffedBak(offedBak)]的值:[$(pobjTeacherInfoEN.offedBak)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.phoneNumber) == false && undefined !== pobjTeacherInfoEN.phoneNumber && tzDataType.isString(pobjTeacherInfoEN.phoneNumber) === false)
{
 throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjTeacherInfoEN.phoneNumber)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.qQ) == false && undefined !== pobjTeacherInfoEN.qQ && tzDataType.isString(pobjTeacherInfoEN.qQ) === false)
{
 throw new Error("(errid:Watl000063)字段[QQ(qQ)]的值:[$(pobjTeacherInfoEN.qQ)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_College) == false && undefined !== pobjTeacherInfoEN.teach_id_College && tzDataType.isString(pobjTeacherInfoEN.teach_id_College) === false)
{
 throw new Error("(errid:Watl000063)字段[Teach_id_College(teach_id_College)]的值:[$(pobjTeacherInfoEN.teach_id_College)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teach_id_Major) == false && undefined !== pobjTeacherInfoEN.teach_id_Major && tzDataType.isString(pobjTeacherInfoEN.teach_id_Major) === false)
{
 throw new Error("(errid:Watl000063)字段[Teach_id_Major(teach_id_Major)]的值:[$(pobjTeacherInfoEN.teach_id_Major)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.tel) == false && undefined !== pobjTeacherInfoEN.tel && tzDataType.isString(pobjTeacherInfoEN.tel) === false)
{
 throw new Error("(errid:Watl000063)字段[Tel(tel)]的值:[$(pobjTeacherInfoEN.tel)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.headphoto) == false && undefined !== pobjTeacherInfoEN.headphoto && tzDataType.isString(pobjTeacherInfoEN.headphoto) === false)
{
 throw new Error("(errid:Watl000063)字段[Headphoto(headphoto)]的值:[$(pobjTeacherInfoEN.headphoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.modifyDate) == false && undefined !== pobjTeacherInfoEN.modifyDate && tzDataType.isString(pobjTeacherInfoEN.modifyDate) === false)
{
 throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjTeacherInfoEN.modifyDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.registerPassword) == false && undefined !== pobjTeacherInfoEN.registerPassword && tzDataType.isString(pobjTeacherInfoEN.registerPassword) === false)
{
 throw new Error("(errid:Watl000063)字段[RegisterPassword(registerPassword)]的值:[$(pobjTeacherInfoEN.registerPassword)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
if (IsNullOrEmpty(pobjTeacherInfoEN.teacherPhoto) == false && undefined !== pobjTeacherInfoEN.teacherPhoto && tzDataType.isString(pobjTeacherInfoEN.teacherPhoto) === false)
{
 throw new Error("(errid:Watl000063)字段[TeacherPhoto(teacherPhoto)]的值:[$(pobjTeacherInfoEN.teacherPhoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
}
//检查主键是否为Null或者空！
if (IsNullOrEmpty(pobjTeacherInfoEN.id_Teacher) === true 
 || pobjTeacherInfoEN.id_Teacher.toString()  ===  "0" )
{
 throw new Error("(errid:Watl000064)字段[教师流水号]不能为空(In 教师)!(clsTeacherInfoBL:CheckProperty4Update)");
}
//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
if (IsNullOrEmpty(pobjTeacherInfoEN.id_StaffType) == false && GetStrLen(pobjTeacherInfoEN.id_StaffType) !=  4)
{
 throw ("(errid:Watl000065)字段[职工类型流水号]作为外键字段,长度应该为4(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
}

 pobjTeacherInfoEN.SetIsCheckProperty(true);
}

/**
 * 把一个对象转化为一个JSON串
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TeacherInfo_GetJSONStrByObj (pobjTeacherInfoEN: clsTeacherInfoEN): string
{
const strThisFuncName = "GetJSONStrByObj";
pobjTeacherInfoEN.sf_UpdFldSetStr = pobjTeacherInfoEN.updFldString;
let strJson = "";
try
{
strJson = JSON.stringify(pobjTeacherInfoEN);
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
export function TeacherInfo_GetObjLstByJSONStr (strJSON: string): Array<clsTeacherInfoEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrTeacherInfoObjLst = new Array<clsTeacherInfoEN>();
if (strJSON === "")
{
return arrTeacherInfoObjLst;
}
try
{
arrTeacherInfoObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrTeacherInfoObjLst;
}
return arrTeacherInfoObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrTeacherInfoObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function TeacherInfo_GetObjLstByJSONObjLst (arrTeacherInfoObjLstS: Array<clsTeacherInfoEN>): Array<clsTeacherInfoEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrTeacherInfoObjLst = new Array<clsTeacherInfoEN>();
for (const objInFor of arrTeacherInfoObjLstS) {
const obj1 = TeacherInfo_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrTeacherInfoObjLst.push(obj1);
}
return arrTeacherInfoObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function TeacherInfo_GetObjByJSONStr (strJSON: string): clsTeacherInfoEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjTeacherInfoEN = new clsTeacherInfoEN();
if (strJSON === "")
{
return pobjTeacherInfoEN;
}
try
{
pobjTeacherInfoEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjTeacherInfoEN;
}
return pobjTeacherInfoEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function TeacherInfo_GetCombineCondition(objTeacherInfo_Cond: clsTeacherInfoEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Teacher) == true)
{
const strComparisonOp_id_Teacher:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Teacher];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Teacher, objTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_TeacherID) == true)
{
const strComparisonOp_TeacherID:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_TeacherID];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_TeacherID, objTeacherInfo_Cond.teacherID, strComparisonOp_TeacherID);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_TeacherName) == true)
{
const strComparisonOp_TeacherName:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_TeacherName];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_TeacherName, objTeacherInfo_Cond.teacherName, strComparisonOp_TeacherName);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Sex) == true)
{
const strComparisonOp_id_Sex:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Sex];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Sex, objTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_School_Ps) == true)
{
const strComparisonOp_id_School_Ps:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_School_Ps];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_School_Ps, objTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Discipline_Ps) == true)
{
const strComparisonOp_id_Discipline_Ps:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Discipline_Ps];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Discipline_Ps, objTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_UniZone, objTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Ethnic) == true)
{
const strComparisonOp_id_Ethnic:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Ethnic];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Ethnic, objTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Politics) == true)
{
const strComparisonOp_id_Politics:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Politics];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Politics, objTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_AdminGrade) == true)
{
const strComparisonOp_id_AdminGrade:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_AdminGrade];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_AdminGrade, objTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_ProfGrade) == true)
{
const strComparisonOp_id_ProfGrade:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_ProfGrade];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_ProfGrade, objTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Qualif) == true)
{
const strComparisonOp_id_Qualif:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Qualif];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Qualif, objTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Degree) == true)
{
const strComparisonOp_id_Degree:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Degree];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Degree, objTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_StaffType) == true)
{
const strComparisonOp_id_StaffType:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_StaffType];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_StaffType, objTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Province) == true)
{
const strComparisonOp_id_Province:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Province];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Province, objTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_CitizenID) == true)
{
const strComparisonOp_CitizenID:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_CitizenID];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_CitizenID, objTeacherInfo_Cond.citizenID, strComparisonOp_CitizenID);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_CardNo) == true)
{
const strComparisonOp_CardNo:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_CardNo, objTeacherInfo_Cond.cardNo, strComparisonOp_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Birthday) == true)
{
const strComparisonOp_Birthday:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Birthday];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Birthday, objTeacherInfo_Cond.birthday, strComparisonOp_Birthday);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_GraduationMajor) == true)
{
const strComparisonOp_GraduationMajor:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_GraduationMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_GraduationMajor, objTeacherInfo_Cond.graduationMajor, strComparisonOp_GraduationMajor);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_TelNo) == true)
{
const strComparisonOp_TelNo:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_TelNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_TelNo, objTeacherInfo_Cond.telNo, strComparisonOp_TelNo);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Email) == true)
{
const strComparisonOp_Email:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Email, objTeacherInfo_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_WebSite) == true)
{
const strComparisonOp_WebSite:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_WebSite];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_WebSite, objTeacherInfo_Cond.webSite, strComparisonOp_WebSite);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_PersonBlog) == true)
{
const strComparisonOp_PersonBlog:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_PersonBlog];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_PersonBlog, objTeacherInfo_Cond.personBlog, strComparisonOp_PersonBlog);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_EntryDate) == true)
{
const strComparisonOp_EntryDate:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_EntryDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_EntryDate, objTeacherInfo_Cond.entryDate, strComparisonOp_EntryDate);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Offed) == true)
{
if (objTeacherInfo_Cond.offed == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_Offed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_Offed);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Id_CardNo) == true)
{
const strComparisonOp_Id_CardNo:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Id_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Id_CardNo, objTeacherInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_IsAvconUser) == true)
{
if (objTeacherInfo_Cond.isAvconUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_IsAvconUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_IsAvconUser);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_IsGpUser) == true)
{
if (objTeacherInfo_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_IsLocalUser) == true)
{
if (objTeacherInfo_Cond.isLocalUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_IsLocalUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_IsLocalUser);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_FromUnit) == true)
{
const strComparisonOp_FromUnit:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_FromUnit];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_FromUnit, objTeacherInfo_Cond.fromUnit, strComparisonOp_FromUnit);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Memo, objTeacherInfo_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_XzCollege, objTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_XzMajor, objTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_EntryDay) == true)
{
const strComparisonOp_EntryDay:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_EntryDay];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_EntryDay, objTeacherInfo_Cond.entryDay, strComparisonOp_EntryDay);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Photo) == true)
{
const strComparisonOp_id_Photo:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Photo];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Photo, objTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_id_Religion) == true)
{
const strComparisonOp_id_Religion:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_id_Religion];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_id_Religion, objTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_IsMessage) == true)
{
if (objTeacherInfo_Cond.isMessage == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_IsMessage);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_IsMessage);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Microblog) == true)
{
const strComparisonOp_Microblog:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Microblog];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Microblog, objTeacherInfo_Cond.microblog, strComparisonOp_Microblog);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_ModifyUserID, objTeacherInfo_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_OffedBak) == true)
{
if (objTeacherInfo_Cond.offedBak == true)
{
strWhereCond += Format(" And {0} = '1'", clsTeacherInfoEN.con_OffedBak);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsTeacherInfoEN.con_OffedBak);
}
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_PhoneNumber, objTeacherInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_QQ) == true)
{
const strComparisonOp_QQ:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_QQ];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_QQ, objTeacherInfo_Cond.qQ, strComparisonOp_QQ);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Teach_id_College) == true)
{
const strComparisonOp_Teach_id_College:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Teach_id_College];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Teach_id_College, objTeacherInfo_Cond.teach_id_College, strComparisonOp_Teach_id_College);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Teach_id_Major) == true)
{
const strComparisonOp_Teach_id_Major:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Teach_id_Major];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Teach_id_Major, objTeacherInfo_Cond.teach_id_Major, strComparisonOp_Teach_id_Major);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Tel) == true)
{
const strComparisonOp_Tel:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Tel];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Tel, objTeacherInfo_Cond.tel, strComparisonOp_Tel);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_Headphoto) == true)
{
const strComparisonOp_Headphoto:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_Headphoto];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_Headphoto, objTeacherInfo_Cond.headphoto, strComparisonOp_Headphoto);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_ModifyDate, objTeacherInfo_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_RegisterPassword) == true)
{
const strComparisonOp_RegisterPassword:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_RegisterPassword];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_RegisterPassword, objTeacherInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
}
if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN.con_TeacherPhoto) == true)
{
const strComparisonOp_TeacherPhoto:string = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN.con_TeacherPhoto];
strWhereCond += Format(" And {0} {2} '{1}'", clsTeacherInfoEN.con_TeacherPhoto, objTeacherInfo_Cond.teacherPhoto, strComparisonOp_TeacherPhoto);
}
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TeacherInfo(教师),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
 * @param strTeacherID: 教师工号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TeacherInfo_GetUniCondStr_TeacherID(objTeacherInfoEN: clsTeacherInfoEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond +=  Format(" and TeacherID = '{0}'", objTeacherInfoEN.teacherID);
 return strWhereCond;
}

 /**
 *获取唯一性条件串(Uniqueness)--TeacherInfo(教师),根据唯一约束条件来生成
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
 * @param strTeacherID: 教师工号(要求唯一的字段)
 * @returns 条件串(strWhereCond)
 **/
export function TeacherInfo_GetUniCondStr4Update_TeacherID(objTeacherInfoEN: clsTeacherInfoEN ):string
{
let strWhereCond = " 1 = 1 ";
 strWhereCond += Format(" and id_Teacher <> '{0}'", objTeacherInfoEN.id_Teacher);
 strWhereCond +=  Format(" and TeacherID = '{0}'", objTeacherInfoEN.teacherID);
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objTeacherInfoENS:源对象
 * @param objTeacherInfoENT:目标对象
*/
export function TeacherInfo_CopyObjTo(objTeacherInfoENS: clsTeacherInfoEN , objTeacherInfoENT: clsTeacherInfoEN ): void 
{
objTeacherInfoENT.id_Teacher = objTeacherInfoENS.id_Teacher; //教师流水号
objTeacherInfoENT.teacherID = objTeacherInfoENS.teacherID; //教师工号
objTeacherInfoENT.teacherName = objTeacherInfoENS.teacherName; //教师姓名
objTeacherInfoENT.id_Sex = objTeacherInfoENS.id_Sex; //性别流水号
objTeacherInfoENT.id_School_Ps = objTeacherInfoENS.id_School_Ps; //学校流水号
objTeacherInfoENT.id_Discipline_Ps = objTeacherInfoENS.id_Discipline_Ps; //学科流水号
objTeacherInfoENT.id_UniZone = objTeacherInfoENS.id_UniZone; //校区流水号
objTeacherInfoENT.id_Ethnic = objTeacherInfoENS.id_Ethnic; //民族流水号
objTeacherInfoENT.id_Politics = objTeacherInfoENS.id_Politics; //政治面貌流水号
objTeacherInfoENT.id_AdminGrade = objTeacherInfoENS.id_AdminGrade; //行政职务流水号
objTeacherInfoENT.id_ProfGrade = objTeacherInfoENS.id_ProfGrade; //专业职称流水号
objTeacherInfoENT.id_Qualif = objTeacherInfoENS.id_Qualif; //学历流水号
objTeacherInfoENT.id_Degree = objTeacherInfoENS.id_Degree; //学位流水号
objTeacherInfoENT.id_StaffType = objTeacherInfoENS.id_StaffType; //职工类型流水号
objTeacherInfoENT.id_Province = objTeacherInfoENS.id_Province; //省份流水号
objTeacherInfoENT.citizenID = objTeacherInfoENS.citizenID; //身份证号
objTeacherInfoENT.cardNo = objTeacherInfoENS.cardNo; //卡号
objTeacherInfoENT.birthday = objTeacherInfoENS.birthday; //出生日期
objTeacherInfoENT.graduationMajor = objTeacherInfoENS.graduationMajor; //毕业专业
objTeacherInfoENT.telNo = objTeacherInfoENS.telNo; //电话
objTeacherInfoENT.email = objTeacherInfoENS.email; //电子邮箱
objTeacherInfoENT.webSite = objTeacherInfoENS.webSite; //个人主页
objTeacherInfoENT.personBlog = objTeacherInfoENS.personBlog; //个人博客
objTeacherInfoENT.entryDate = objTeacherInfoENS.entryDate; //进校日期
objTeacherInfoENT.offed = objTeacherInfoENS.offed; //是否离校
objTeacherInfoENT.id_CardNo = objTeacherInfoENS.id_CardNo; //内卡号
objTeacherInfoENT.isAvconUser = objTeacherInfoENS.isAvconUser; //IsAvconUser
objTeacherInfoENT.isGpUser = objTeacherInfoENS.isGpUser; //是否Gp用户
objTeacherInfoENT.isLocalUser = objTeacherInfoENS.isLocalUser; //是否本地用户
objTeacherInfoENT.fromUnit = objTeacherInfoENS.fromUnit; //来自单位
objTeacherInfoENT.memo = objTeacherInfoENS.memo; //备注
objTeacherInfoENT.id_XzCollege = objTeacherInfoENS.id_XzCollege; //学院流水号
objTeacherInfoENT.id_XzMajor = objTeacherInfoENS.id_XzMajor; //专业流水号
objTeacherInfoENT.entryDay = objTeacherInfoENS.entryDay; //EntryDay
objTeacherInfoENT.id_Photo = objTeacherInfoENS.id_Photo; //id_Photo
objTeacherInfoENT.id_Religion = objTeacherInfoENS.id_Religion; //id_Religion
objTeacherInfoENT.isMessage = objTeacherInfoENS.isMessage; //IsMessage
objTeacherInfoENT.microblog = objTeacherInfoENS.microblog; //Microblog
objTeacherInfoENT.modifyUserID = objTeacherInfoENS.modifyUserID; //修改人
objTeacherInfoENT.offedBak = objTeacherInfoENS.offedBak; //OffedBak
objTeacherInfoENT.phoneNumber = objTeacherInfoENS.phoneNumber; //PhoneNumber
objTeacherInfoENT.qQ = objTeacherInfoENS.qQ; //QQ
objTeacherInfoENT.teach_id_College = objTeacherInfoENS.teach_id_College; //Teach_id_College
objTeacherInfoENT.teach_id_Major = objTeacherInfoENS.teach_id_Major; //Teach_id_Major
objTeacherInfoENT.tel = objTeacherInfoENS.tel; //Tel
objTeacherInfoENT.headphoto = objTeacherInfoENS.headphoto; //Headphoto
objTeacherInfoENT.modifyDate = objTeacherInfoENS.modifyDate; //修改日期
objTeacherInfoENT.registerPassword = objTeacherInfoENS.registerPassword; //RegisterPassword
objTeacherInfoENT.teacherPhoto = objTeacherInfoENS.teacherPhoto; //TeacherPhoto
objTeacherInfoENT.sf_UpdFldSetStr = objTeacherInfoENS.updFldString; //sf_UpdFldSetStr
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objTeacherInfoENS:源对象
 * @param objTeacherInfoENT:目标对象
*/
export function TeacherInfo_GetObjFromJsonObj(objTeacherInfoENS: clsTeacherInfoEN): clsTeacherInfoEN 
{
 const objTeacherInfoENT: clsTeacherInfoEN = new clsTeacherInfoEN();
ObjectAssign(objTeacherInfoENT, objTeacherInfoENS);
 return objTeacherInfoENT;
}