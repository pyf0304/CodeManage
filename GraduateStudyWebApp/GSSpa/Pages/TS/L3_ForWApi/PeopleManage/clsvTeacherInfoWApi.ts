
 /**
 * 类名:clsvTeacherInfoWApi
 * 表名:vTeacherInfo(01120094)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:27
 * 生成者:pyf
 * 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
 * 框架-层名:WA_访问层(TS)(WA_Access)
 * 编程语言:TypeScript
 * 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
   *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 **/

/**
 * v教师(vTeacherInfo)
 * (AutoGCLib.WA_Access4TypeScript:GeneCode)
* Created by pyf on 2022年11月02日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
 **/
import axios from "axios";
import { clsvTeacherInfoEN } from "../../L0_Entity/PeopleManage/clsvTeacherInfoEN.js";
import { BindDdl_ObjLstInDiv_V, GetExceptionStr, GetObjKeys, myShowErrorMsg, ObjectAssign } from "../../PubFun/clsCommFunc4Web.js";
import { clsSysPara4WebApi, GetWebApiUrl } from "../../PubFun/clsSysPara4WebApi.js";
import { stuTopPara } from "../../PubFun/stuTopPara.js";
import { stuRangePara } from "../../PubFun/stuRangePara.js";
import { stuPagerPara } from "../../PubFun/stuPagerPara.js";
import { CacheHelper } from "../../PubFun/CacheHelper.js";
import { Format, GetStrLen, IsNullOrEmpty } from "../../PubFun/clsString.js";

 export const vTeacherInfo_Controller = "vTeacherInfoApi";
 export const vTeacherInfo_ConstructorName = "vTeacherInfo";

 /**
 * 根据关键字获取相应记录的对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
 * @param strid_Teacher:关键字
 * @returns 对象
 **/
export async function vTeacherInfo_GetObjByid_TeacherAsync(strid_Teacher: string): Promise<clsvTeacherInfoEN>  
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
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
return objvTeacherInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export function vTeacherInfo_SortFun_Defa(a:clsvTeacherInfoEN , b:clsvTeacherInfoEN): number 
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
export function vTeacherInfo_SortFun_Defa_2Fld(a:clsvTeacherInfoEN , b:clsvTeacherInfoEN): number 
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
export function vTeacherInfo_SortFunByKey(strKey:string, AscOrDesc: string)
{
const strThisFuncName = "SortFunByKey";
let strMsg ="";
if (AscOrDesc == "Asc" || AscOrDesc == "")
{
switch (strKey)
{
case clsvTeacherInfoEN.con_id_Teacher:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Teacher.localeCompare(b.id_Teacher);
}
case clsvTeacherInfoEN.con_TeacherID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.teacherID.localeCompare(b.teacherID);
}
case clsvTeacherInfoEN.con_TeacherName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.teacherName.localeCompare(b.teacherName);
}
case clsvTeacherInfoEN.con_id_Sex:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Sex.localeCompare(b.id_Sex);
}
case clsvTeacherInfoEN.con_SexDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.sexDesc.localeCompare(b.sexDesc);
}
case clsvTeacherInfoEN.con_id_School_Ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_School_Ps.localeCompare(b.id_School_Ps);
}
case clsvTeacherInfoEN.con_SchoolId:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.schoolId.localeCompare(b.schoolId);
}
case clsvTeacherInfoEN.con_SchoolName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.schoolName.localeCompare(b.schoolName);
}
case clsvTeacherInfoEN.con_id_Discipline_Ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Discipline_Ps.localeCompare(b.id_Discipline_Ps);
}
case clsvTeacherInfoEN.con_id_UniZone:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_UniZone.localeCompare(b.id_UniZone);
}
case clsvTeacherInfoEN.con_UniZoneDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
}
case clsvTeacherInfoEN.con_id_Ethnic:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Ethnic.localeCompare(b.id_Ethnic);
}
case clsvTeacherInfoEN.con_EthnicName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.ethnicName.localeCompare(b.ethnicName);
}
case clsvTeacherInfoEN.con_id_Politics:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Politics.localeCompare(b.id_Politics);
}
case clsvTeacherInfoEN.con_PoliticsName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.politicsName.localeCompare(b.politicsName);
}
case clsvTeacherInfoEN.con_id_AdminGrade:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_AdminGrade.localeCompare(b.id_AdminGrade);
}
case clsvTeacherInfoEN.con_AdminGradeDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.adminGradeDesc.localeCompare(b.adminGradeDesc);
}
case clsvTeacherInfoEN.con_id_ProfGrade:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
}
case clsvTeacherInfoEN.con_ProfenssionalGradeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.profenssionalGradeName.localeCompare(b.profenssionalGradeName);
}
case clsvTeacherInfoEN.con_id_Qualif:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Qualif.localeCompare(b.id_Qualif);
}
case clsvTeacherInfoEN.con_QualifDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.qualifDesc.localeCompare(b.qualifDesc);
}
case clsvTeacherInfoEN.con_id_Degree:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Degree.localeCompare(b.id_Degree);
}
case clsvTeacherInfoEN.con_DegreeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.degreeName.localeCompare(b.degreeName);
}
case clsvTeacherInfoEN.con_id_StaffType:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_StaffType.localeCompare(b.id_StaffType);
}
case clsvTeacherInfoEN.con_StaffTypeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.staffTypeName.localeCompare(b.staffTypeName);
}
case clsvTeacherInfoEN.con_id_Province:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Province.localeCompare(b.id_Province);
}
case clsvTeacherInfoEN.con_ProvinceName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.provinceName.localeCompare(b.provinceName);
}
case clsvTeacherInfoEN.con_CitizenID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.citizenID.localeCompare(b.citizenID);
}
case clsvTeacherInfoEN.con_CardNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.cardNo.localeCompare(b.cardNo);
}
case clsvTeacherInfoEN.con_Birthday:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.birthday.localeCompare(b.birthday);
}
case clsvTeacherInfoEN.con_GraduationMajor:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.graduationMajor.localeCompare(b.graduationMajor);
}
case clsvTeacherInfoEN.con_TelNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.telNo.localeCompare(b.telNo);
}
case clsvTeacherInfoEN.con_Email:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.email.localeCompare(b.email);
}
case clsvTeacherInfoEN.con_WebSite:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.webSite.localeCompare(b.webSite);
}
case clsvTeacherInfoEN.con_PersonBlog:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.personBlog.localeCompare(b.personBlog);
}
case clsvTeacherInfoEN.con_EntryDate:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.entryDate.localeCompare(b.entryDate);
}
case clsvTeacherInfoEN.con_Offed:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.offed == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_Id_CardNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_CardNo.localeCompare(b.id_CardNo);
}
case clsvTeacherInfoEN.con_IsAvconUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.isAvconUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_IsGpUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.isGpUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_IsLocalUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.isLocalUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_FromUnit:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.fromUnit.localeCompare(b.fromUnit);
}
case clsvTeacherInfoEN.con_Memo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.memo.localeCompare(b.memo);
}
case clsvTeacherInfoEN.con_id_XzCollege:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_XzCollege.localeCompare(b.id_XzCollege);
}
case clsvTeacherInfoEN.con_CollegeID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.collegeID.localeCompare(b.collegeID);
}
case clsvTeacherInfoEN.con_CollegeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.collegeName.localeCompare(b.collegeName);
}
case clsvTeacherInfoEN.con_CollegeNameA:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.collegeNameA.localeCompare(b.collegeNameA);
}
case clsvTeacherInfoEN.con_id_XzMajor:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_XzMajor.localeCompare(b.id_XzMajor);
}
case clsvTeacherInfoEN.con_EntryDay:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.entryDay.localeCompare(b.entryDay);
}
case clsvTeacherInfoEN.con_id_Photo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Photo.localeCompare(b.id_Photo);
}
case clsvTeacherInfoEN.con_id_Religion:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.id_Religion.localeCompare(b.id_Religion);
}
case clsvTeacherInfoEN.con_ReligionName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.religionName.localeCompare(b.religionName);
}
case clsvTeacherInfoEN.con_IsMessage:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.isMessage == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_Microblog:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.microblog.localeCompare(b.microblog);
}
case clsvTeacherInfoEN.con_ModifyUserID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.modifyUserID.localeCompare(b.modifyUserID);
}
case clsvTeacherInfoEN.con_OffedBak:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (a.offedBak == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_PhoneNumber:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.phoneNumber.localeCompare(b.phoneNumber);
}
case clsvTeacherInfoEN.con_QQ:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.qQ.localeCompare(b.qQ);
}
case clsvTeacherInfoEN.con_Teach_id_College:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.teach_id_College.localeCompare(b.teach_id_College);
}
case clsvTeacherInfoEN.con_Teach_id_Major:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.teach_id_Major.localeCompare(b.teach_id_Major);
}
case clsvTeacherInfoEN.con_Tel:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.tel.localeCompare(b.tel);
}
case clsvTeacherInfoEN.con_ModifyDate:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.modifyDate.localeCompare(b.modifyDate);
}
case clsvTeacherInfoEN.con_RegisterPassword:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.registerPassword.localeCompare(b.registerPassword);
}
case clsvTeacherInfoEN.con_EntryYear:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.entryYear.localeCompare(b.entryYear);
}
case clsvTeacherInfoEN.con_DisciplineName_ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return a.disciplineName_ps.localeCompare(b.disciplineName_ps);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${ vTeacherInfo_ConstructorName}.${ strThisFuncName})`;
       console.error(strMsg);
     break;
 }
 }
  else
 {
switch (strKey)
{
case clsvTeacherInfoEN.con_id_Teacher:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Teacher.localeCompare(a.id_Teacher);
}
case clsvTeacherInfoEN.con_TeacherID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.teacherID.localeCompare(a.teacherID);
}
case clsvTeacherInfoEN.con_TeacherName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.teacherName.localeCompare(a.teacherName);
}
case clsvTeacherInfoEN.con_id_Sex:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Sex.localeCompare(a.id_Sex);
}
case clsvTeacherInfoEN.con_SexDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.sexDesc.localeCompare(a.sexDesc);
}
case clsvTeacherInfoEN.con_id_School_Ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_School_Ps.localeCompare(a.id_School_Ps);
}
case clsvTeacherInfoEN.con_SchoolId:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.schoolId.localeCompare(a.schoolId);
}
case clsvTeacherInfoEN.con_SchoolName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.schoolName.localeCompare(a.schoolName);
}
case clsvTeacherInfoEN.con_id_Discipline_Ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Discipline_Ps.localeCompare(a.id_Discipline_Ps);
}
case clsvTeacherInfoEN.con_id_UniZone:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_UniZone.localeCompare(a.id_UniZone);
}
case clsvTeacherInfoEN.con_UniZoneDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
}
case clsvTeacherInfoEN.con_id_Ethnic:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Ethnic.localeCompare(a.id_Ethnic);
}
case clsvTeacherInfoEN.con_EthnicName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.ethnicName.localeCompare(a.ethnicName);
}
case clsvTeacherInfoEN.con_id_Politics:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Politics.localeCompare(a.id_Politics);
}
case clsvTeacherInfoEN.con_PoliticsName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.politicsName.localeCompare(a.politicsName);
}
case clsvTeacherInfoEN.con_id_AdminGrade:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_AdminGrade.localeCompare(a.id_AdminGrade);
}
case clsvTeacherInfoEN.con_AdminGradeDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.adminGradeDesc.localeCompare(a.adminGradeDesc);
}
case clsvTeacherInfoEN.con_id_ProfGrade:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
}
case clsvTeacherInfoEN.con_ProfenssionalGradeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.profenssionalGradeName.localeCompare(a.profenssionalGradeName);
}
case clsvTeacherInfoEN.con_id_Qualif:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Qualif.localeCompare(a.id_Qualif);
}
case clsvTeacherInfoEN.con_QualifDesc:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.qualifDesc.localeCompare(a.qualifDesc);
}
case clsvTeacherInfoEN.con_id_Degree:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Degree.localeCompare(a.id_Degree);
}
case clsvTeacherInfoEN.con_DegreeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.degreeName.localeCompare(a.degreeName);
}
case clsvTeacherInfoEN.con_id_StaffType:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_StaffType.localeCompare(a.id_StaffType);
}
case clsvTeacherInfoEN.con_StaffTypeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.staffTypeName.localeCompare(a.staffTypeName);
}
case clsvTeacherInfoEN.con_id_Province:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Province.localeCompare(a.id_Province);
}
case clsvTeacherInfoEN.con_ProvinceName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.provinceName.localeCompare(a.provinceName);
}
case clsvTeacherInfoEN.con_CitizenID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.citizenID.localeCompare(a.citizenID);
}
case clsvTeacherInfoEN.con_CardNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.cardNo.localeCompare(a.cardNo);
}
case clsvTeacherInfoEN.con_Birthday:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.birthday.localeCompare(a.birthday);
}
case clsvTeacherInfoEN.con_GraduationMajor:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.graduationMajor.localeCompare(a.graduationMajor);
}
case clsvTeacherInfoEN.con_TelNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.telNo.localeCompare(a.telNo);
}
case clsvTeacherInfoEN.con_Email:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.email.localeCompare(a.email);
}
case clsvTeacherInfoEN.con_WebSite:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.webSite.localeCompare(a.webSite);
}
case clsvTeacherInfoEN.con_PersonBlog:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.personBlog.localeCompare(a.personBlog);
}
case clsvTeacherInfoEN.con_EntryDate:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.entryDate.localeCompare(a.entryDate);
}
case clsvTeacherInfoEN.con_Offed:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.offed == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_Id_CardNo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_CardNo.localeCompare(a.id_CardNo);
}
case clsvTeacherInfoEN.con_IsAvconUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.isAvconUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_IsGpUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.isGpUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_IsLocalUser:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.isLocalUser == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_FromUnit:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.fromUnit.localeCompare(a.fromUnit);
}
case clsvTeacherInfoEN.con_Memo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.memo.localeCompare(a.memo);
}
case clsvTeacherInfoEN.con_id_XzCollege:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_XzCollege.localeCompare(a.id_XzCollege);
}
case clsvTeacherInfoEN.con_CollegeID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.collegeID.localeCompare(a.collegeID);
}
case clsvTeacherInfoEN.con_CollegeName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.collegeName.localeCompare(a.collegeName);
}
case clsvTeacherInfoEN.con_CollegeNameA:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.collegeNameA.localeCompare(a.collegeNameA);
}
case clsvTeacherInfoEN.con_id_XzMajor:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_XzMajor.localeCompare(a.id_XzMajor);
}
case clsvTeacherInfoEN.con_EntryDay:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.entryDay.localeCompare(a.entryDay);
}
case clsvTeacherInfoEN.con_id_Photo:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Photo.localeCompare(a.id_Photo);
}
case clsvTeacherInfoEN.con_id_Religion:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.id_Religion.localeCompare(a.id_Religion);
}
case clsvTeacherInfoEN.con_ReligionName:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.religionName.localeCompare(a.religionName);
}
case clsvTeacherInfoEN.con_IsMessage:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.isMessage == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_Microblog:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.microblog.localeCompare(a.microblog);
}
case clsvTeacherInfoEN.con_ModifyUserID:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.modifyUserID.localeCompare(a.modifyUserID);
}
case clsvTeacherInfoEN.con_OffedBak:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
if (b.offedBak == true) return 1;
else return -1
}
case clsvTeacherInfoEN.con_PhoneNumber:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.phoneNumber.localeCompare(a.phoneNumber);
}
case clsvTeacherInfoEN.con_QQ:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.qQ.localeCompare(a.qQ);
}
case clsvTeacherInfoEN.con_Teach_id_College:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.teach_id_College.localeCompare(a.teach_id_College);
}
case clsvTeacherInfoEN.con_Teach_id_Major:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.teach_id_Major.localeCompare(a.teach_id_Major);
}
case clsvTeacherInfoEN.con_Tel:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.tel.localeCompare(a.tel);
}
case clsvTeacherInfoEN.con_ModifyDate:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.modifyDate.localeCompare(a.modifyDate);
}
case clsvTeacherInfoEN.con_RegisterPassword:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.registerPassword.localeCompare(a.registerPassword);
}
case clsvTeacherInfoEN.con_EntryYear:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.entryYear.localeCompare(a.entryYear);
}
case clsvTeacherInfoEN.con_DisciplineName_ps:
return (a: clsvTeacherInfoEN, b: clsvTeacherInfoEN) => {
return b.disciplineName_ps.localeCompare(a.disciplineName_ps);
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${ vTeacherInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function vTeacherInfo_FilterFunByKey(strKey:string, value: any)
{
const strThisFuncName = "FilterFunByKey";
let strMsg ="";
switch (strKey)
{
case clsvTeacherInfoEN.con_id_Teacher:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Teacher === value;
}
case clsvTeacherInfoEN.con_TeacherID:
return (obj: clsvTeacherInfoEN) => {
return obj.teacherID === value;
}
case clsvTeacherInfoEN.con_TeacherName:
return (obj: clsvTeacherInfoEN) => {
return obj.teacherName === value;
}
case clsvTeacherInfoEN.con_id_Sex:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Sex === value;
}
case clsvTeacherInfoEN.con_SexDesc:
return (obj: clsvTeacherInfoEN) => {
return obj.sexDesc === value;
}
case clsvTeacherInfoEN.con_id_School_Ps:
return (obj: clsvTeacherInfoEN) => {
return obj.id_School_Ps === value;
}
case clsvTeacherInfoEN.con_SchoolId:
return (obj: clsvTeacherInfoEN) => {
return obj.schoolId === value;
}
case clsvTeacherInfoEN.con_SchoolName:
return (obj: clsvTeacherInfoEN) => {
return obj.schoolName === value;
}
case clsvTeacherInfoEN.con_id_Discipline_Ps:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Discipline_Ps === value;
}
case clsvTeacherInfoEN.con_id_UniZone:
return (obj: clsvTeacherInfoEN) => {
return obj.id_UniZone === value;
}
case clsvTeacherInfoEN.con_UniZoneDesc:
return (obj: clsvTeacherInfoEN) => {
return obj.uniZoneDesc === value;
}
case clsvTeacherInfoEN.con_id_Ethnic:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Ethnic === value;
}
case clsvTeacherInfoEN.con_EthnicName:
return (obj: clsvTeacherInfoEN) => {
return obj.ethnicName === value;
}
case clsvTeacherInfoEN.con_id_Politics:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Politics === value;
}
case clsvTeacherInfoEN.con_PoliticsName:
return (obj: clsvTeacherInfoEN) => {
return obj.politicsName === value;
}
case clsvTeacherInfoEN.con_id_AdminGrade:
return (obj: clsvTeacherInfoEN) => {
return obj.id_AdminGrade === value;
}
case clsvTeacherInfoEN.con_AdminGradeDesc:
return (obj: clsvTeacherInfoEN) => {
return obj.adminGradeDesc === value;
}
case clsvTeacherInfoEN.con_id_ProfGrade:
return (obj: clsvTeacherInfoEN) => {
return obj.id_ProfGrade === value;
}
case clsvTeacherInfoEN.con_ProfenssionalGradeName:
return (obj: clsvTeacherInfoEN) => {
return obj.profenssionalGradeName === value;
}
case clsvTeacherInfoEN.con_id_Qualif:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Qualif === value;
}
case clsvTeacherInfoEN.con_QualifDesc:
return (obj: clsvTeacherInfoEN) => {
return obj.qualifDesc === value;
}
case clsvTeacherInfoEN.con_id_Degree:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Degree === value;
}
case clsvTeacherInfoEN.con_DegreeName:
return (obj: clsvTeacherInfoEN) => {
return obj.degreeName === value;
}
case clsvTeacherInfoEN.con_id_StaffType:
return (obj: clsvTeacherInfoEN) => {
return obj.id_StaffType === value;
}
case clsvTeacherInfoEN.con_StaffTypeName:
return (obj: clsvTeacherInfoEN) => {
return obj.staffTypeName === value;
}
case clsvTeacherInfoEN.con_id_Province:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Province === value;
}
case clsvTeacherInfoEN.con_ProvinceName:
return (obj: clsvTeacherInfoEN) => {
return obj.provinceName === value;
}
case clsvTeacherInfoEN.con_CitizenID:
return (obj: clsvTeacherInfoEN) => {
return obj.citizenID === value;
}
case clsvTeacherInfoEN.con_CardNo:
return (obj: clsvTeacherInfoEN) => {
return obj.cardNo === value;
}
case clsvTeacherInfoEN.con_Birthday:
return (obj: clsvTeacherInfoEN) => {
return obj.birthday === value;
}
case clsvTeacherInfoEN.con_GraduationMajor:
return (obj: clsvTeacherInfoEN) => {
return obj.graduationMajor === value;
}
case clsvTeacherInfoEN.con_TelNo:
return (obj: clsvTeacherInfoEN) => {
return obj.telNo === value;
}
case clsvTeacherInfoEN.con_Email:
return (obj: clsvTeacherInfoEN) => {
return obj.email === value;
}
case clsvTeacherInfoEN.con_WebSite:
return (obj: clsvTeacherInfoEN) => {
return obj.webSite === value;
}
case clsvTeacherInfoEN.con_PersonBlog:
return (obj: clsvTeacherInfoEN) => {
return obj.personBlog === value;
}
case clsvTeacherInfoEN.con_EntryDate:
return (obj: clsvTeacherInfoEN) => {
return obj.entryDate === value;
}
case clsvTeacherInfoEN.con_Offed:
return (obj: clsvTeacherInfoEN) => {
return obj.offed === value;
}
case clsvTeacherInfoEN.con_Id_CardNo:
return (obj: clsvTeacherInfoEN) => {
return obj.id_CardNo === value;
}
case clsvTeacherInfoEN.con_IsAvconUser:
return (obj: clsvTeacherInfoEN) => {
return obj.isAvconUser === value;
}
case clsvTeacherInfoEN.con_IsGpUser:
return (obj: clsvTeacherInfoEN) => {
return obj.isGpUser === value;
}
case clsvTeacherInfoEN.con_IsLocalUser:
return (obj: clsvTeacherInfoEN) => {
return obj.isLocalUser === value;
}
case clsvTeacherInfoEN.con_FromUnit:
return (obj: clsvTeacherInfoEN) => {
return obj.fromUnit === value;
}
case clsvTeacherInfoEN.con_Memo:
return (obj: clsvTeacherInfoEN) => {
return obj.memo === value;
}
case clsvTeacherInfoEN.con_id_XzCollege:
return (obj: clsvTeacherInfoEN) => {
return obj.id_XzCollege === value;
}
case clsvTeacherInfoEN.con_CollegeID:
return (obj: clsvTeacherInfoEN) => {
return obj.collegeID === value;
}
case clsvTeacherInfoEN.con_CollegeName:
return (obj: clsvTeacherInfoEN) => {
return obj.collegeName === value;
}
case clsvTeacherInfoEN.con_CollegeNameA:
return (obj: clsvTeacherInfoEN) => {
return obj.collegeNameA === value;
}
case clsvTeacherInfoEN.con_id_XzMajor:
return (obj: clsvTeacherInfoEN) => {
return obj.id_XzMajor === value;
}
case clsvTeacherInfoEN.con_EntryDay:
return (obj: clsvTeacherInfoEN) => {
return obj.entryDay === value;
}
case clsvTeacherInfoEN.con_id_Photo:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Photo === value;
}
case clsvTeacherInfoEN.con_id_Religion:
return (obj: clsvTeacherInfoEN) => {
return obj.id_Religion === value;
}
case clsvTeacherInfoEN.con_ReligionName:
return (obj: clsvTeacherInfoEN) => {
return obj.religionName === value;
}
case clsvTeacherInfoEN.con_IsMessage:
return (obj: clsvTeacherInfoEN) => {
return obj.isMessage === value;
}
case clsvTeacherInfoEN.con_Microblog:
return (obj: clsvTeacherInfoEN) => {
return obj.microblog === value;
}
case clsvTeacherInfoEN.con_ModifyUserID:
return (obj: clsvTeacherInfoEN) => {
return obj.modifyUserID === value;
}
case clsvTeacherInfoEN.con_OffedBak:
return (obj: clsvTeacherInfoEN) => {
return obj.offedBak === value;
}
case clsvTeacherInfoEN.con_PhoneNumber:
return (obj: clsvTeacherInfoEN) => {
return obj.phoneNumber === value;
}
case clsvTeacherInfoEN.con_QQ:
return (obj: clsvTeacherInfoEN) => {
return obj.qQ === value;
}
case clsvTeacherInfoEN.con_Teach_id_College:
return (obj: clsvTeacherInfoEN) => {
return obj.teach_id_College === value;
}
case clsvTeacherInfoEN.con_Teach_id_Major:
return (obj: clsvTeacherInfoEN) => {
return obj.teach_id_Major === value;
}
case clsvTeacherInfoEN.con_Tel:
return (obj: clsvTeacherInfoEN) => {
return obj.tel === value;
}
case clsvTeacherInfoEN.con_ModifyDate:
return (obj: clsvTeacherInfoEN) => {
return obj.modifyDate === value;
}
case clsvTeacherInfoEN.con_RegisterPassword:
return (obj: clsvTeacherInfoEN) => {
return obj.registerPassword === value;
}
case clsvTeacherInfoEN.con_EntryYear:
return (obj: clsvTeacherInfoEN) => {
return obj.entryYear === value;
}
case clsvTeacherInfoEN.con_DisciplineName_ps:
return (obj: clsvTeacherInfoEN) => {
return obj.disciplineName_ps === value;
}
        default:
strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${ vTeacherInfo_ConstructorName}.${ strThisFuncName})`;
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
export async function vTeacherInfo_GetFirstIDAsync(strWhereCond: string): Promise<string>  
{
const strThisFuncName = "GetFirstIDAsync";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetFirstID(strWhereCond: string, cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetFirstID";
const strAction = "GetFirstID";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetFirstObjAsync(strWhereCond: string): Promise<clsvTeacherInfoEN>  
{
const strThisFuncName = "GetFirstObjAsync";
const strAction = "GetFirstObj";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObj);
const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
return objvTeacherInfo;
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetObjLstAsync(strWhereCond: string): Promise<Array<clsvTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstAsync";
const strAction = "GetObjLst";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
 * @param arrid_Teacher:关键字列表
 * @returns 对象列表
 **/
export async function vTeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher: Array<string>): Promise<Array<clsvTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByid_TeacherLstAsync";
const strAction = "GetObjLstByid_TeacherLst";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, arrid_Teacher);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetTopObjLstAsync(objTopPara: stuTopPara): Promise<Array<clsvTeacherInfoEN>>  
{
const strThisFuncName = "GetTopObjLstAsync";
const strAction = "GetTopObjLst";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objTopPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetObjLstByRangeAsync(objRangePara: stuRangePara): Promise<Array<clsvTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByRangeAsync";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objRangePara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetObjLstByRange(intMinNum: number, intMaxNum: number, strWhereCond: string, strOrderBy:string="", cb: (json: any) => void, errorCb: (json: any) => void) 
{
const strThisFuncName = "GetObjLstByRange";
const strAction = "GetObjLstByRange";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetObjLstByPagerAsync(objPagerPara: stuPagerPara): Promise<Array<clsvTeacherInfoEN>>  
{
const strThisFuncName = "GetObjLstByPagerAsync";
const strAction = "GetObjLstByPager";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
try
{
const response = await axios.post(strUrl, objPagerPara);
const data = response.data;
if (data.errorId == 0)
{
const returnObjLst = data.returnObjLst;
if (returnObjLst == null)
{
const strNullInfo = Format("获取数据为null, 请注意!(in {0}.{1})", vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strNullInfo);
throw(strNullInfo);
}
//console.log(returnObjLst);
const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_IsExistRecordAsync(strWhereCond: string): Promise<boolean>  
{
const strThisFuncName = "IsExistRecordAsync";
const strAction = "IsExistRecord";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_IsExist(strid_Teacher: string, cb: (json: any) => void, errorCb: (json: any) => void)
{
const strThisFuncName = "IsExist";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
 * @param strid_Teacher:关键字
 * @returns 是否存在?存在返回True
 **/
export async function vTeacherInfo_IsExistAsync(strid_Teacher: string): Promise<boolean> 
{
const strThisFuncName = "IsExistAsync";
//检测记录是否存在
const strAction = "IsExist";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export async function vTeacherInfo_GetRecCountByCondAsync(strWhereCond: string): Promise<number>  
{
const strThisFuncName = "GetRecCountByCondAsync";
const strAction = "GetRecCountByCond";
const strUrl = GetWebApiUrl(vTeacherInfo_Controller, strAction);
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
const strInfo = Format("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
console.error(strInfo);
throw(strInfo);
}
else if (error.statusText == "Not Found")
{
const strInfo = Format("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, vTeacherInfo_ConstructorName, strThisFuncName);
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
export function vTeacherInfo_GetWebApiUrl(strController: string, strAction: string): string {
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
export function vTeacherInfo_GetJSONStrByObj (pobjvTeacherInfoEN: clsvTeacherInfoEN): string
{
const strThisFuncName = "GetJSONStrByObj";
let strJson = "";
try
{
strJson = JSON.stringify(pobjvTeacherInfoEN);
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
export function vTeacherInfo_GetObjLstByJSONStr (strJSON: string): Array<clsvTeacherInfoEN>
{
const strThisFuncName = "GetObjLstByJSONStr";
let arrvTeacherInfoObjLst = new Array<clsvTeacherInfoEN>();
if (strJSON === "")
{
return arrvTeacherInfoObjLst;
}
try
{
arrvTeacherInfoObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvTeacherInfoObjLst;
}
return arrvTeacherInfoObjLst;
}

/**
 * 把一个JSON对象列表转化为一个实体对象列表
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
 * @param arrvTeacherInfoObjLstS:需要转化的JSON对象列表
 * @returns 返回一个生成的对象列表
*/
export function vTeacherInfo_GetObjLstByJSONObjLst (arrvTeacherInfoObjLstS: Array<clsvTeacherInfoEN>): Array<clsvTeacherInfoEN>
{
const strThisFuncName = "GetObjLstByJSONObjLst";
const arrvTeacherInfoObjLst = new Array<clsvTeacherInfoEN>();
for (const objInFor of arrvTeacherInfoObjLstS) {
const obj1 = vTeacherInfo_GetObjFromJsonObj(objInFor);
if (obj1 == null) continue;
arrvTeacherInfoObjLst.push(obj1);
}
return arrvTeacherInfoObjLst;
}

/**
 * 把一个JSON串转化为一个对象
 * 作者:pyf
 * 日期:2022-11-02
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
 * @param strJSON:需要转化的JSON串
 * @returns 返回一个生成的对象
*/
export function vTeacherInfo_GetObjByJSONStr (strJSON: string): clsvTeacherInfoEN
{
const strThisFuncName = "GetObjByJSONStr";
let pobjvTeacherInfoEN = new clsvTeacherInfoEN();
if (strJSON === "")
{
return pobjvTeacherInfoEN;
}
try
{
pobjvTeacherInfoEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvTeacherInfoEN;
}
return pobjvTeacherInfoEN;
}

/**
 * 根据条件对象中的字段内容组合成一个条件串
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
 * @returns 条件串(strWhereCond)
*/
export function vTeacherInfo_GetCombineCondition(objvTeacherInfo_Cond: clsvTeacherInfoEN ):string
{
const strThisFuncName = "GetCombineCondition";
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
let strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Teacher) == true)
{
const strComparisonOp_id_Teacher:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Teacher];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Teacher, objvTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_TeacherID) == true)
{
const strComparisonOp_TeacherID:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_TeacherID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_TeacherID, objvTeacherInfo_Cond.teacherID, strComparisonOp_TeacherID);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_TeacherName) == true)
{
const strComparisonOp_TeacherName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_TeacherName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_TeacherName, objvTeacherInfo_Cond.teacherName, strComparisonOp_TeacherName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Sex) == true)
{
const strComparisonOp_id_Sex:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Sex];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Sex, objvTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_SexDesc) == true)
{
const strComparisonOp_SexDesc:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_SexDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_SexDesc, objvTeacherInfo_Cond.sexDesc, strComparisonOp_SexDesc);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_School_Ps) == true)
{
const strComparisonOp_id_School_Ps:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_School_Ps];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_School_Ps, objvTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_SchoolId) == true)
{
const strComparisonOp_SchoolId:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_SchoolId];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_SchoolId, objvTeacherInfo_Cond.schoolId, strComparisonOp_SchoolId);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_SchoolName) == true)
{
const strComparisonOp_SchoolName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_SchoolName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_SchoolName, objvTeacherInfo_Cond.schoolName, strComparisonOp_SchoolName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Discipline_Ps) == true)
{
const strComparisonOp_id_Discipline_Ps:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Discipline_Ps];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Discipline_Ps, objvTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_UniZone) == true)
{
const strComparisonOp_id_UniZone:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_UniZone];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_UniZone, objvTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_UniZoneDesc) == true)
{
const strComparisonOp_UniZoneDesc:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_UniZoneDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_UniZoneDesc, objvTeacherInfo_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Ethnic) == true)
{
const strComparisonOp_id_Ethnic:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Ethnic];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Ethnic, objvTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_EthnicName) == true)
{
const strComparisonOp_EthnicName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_EthnicName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_EthnicName, objvTeacherInfo_Cond.ethnicName, strComparisonOp_EthnicName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Politics) == true)
{
const strComparisonOp_id_Politics:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Politics];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Politics, objvTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_PoliticsName) == true)
{
const strComparisonOp_PoliticsName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_PoliticsName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_PoliticsName, objvTeacherInfo_Cond.politicsName, strComparisonOp_PoliticsName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_AdminGrade) == true)
{
const strComparisonOp_id_AdminGrade:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_AdminGrade];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_AdminGrade, objvTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_AdminGradeDesc) == true)
{
const strComparisonOp_AdminGradeDesc:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_AdminGradeDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_AdminGradeDesc, objvTeacherInfo_Cond.adminGradeDesc, strComparisonOp_AdminGradeDesc);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_ProfGrade) == true)
{
const strComparisonOp_id_ProfGrade:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_ProfGrade];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_ProfGrade, objvTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_ProfenssionalGradeName) == true)
{
const strComparisonOp_ProfenssionalGradeName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_ProfenssionalGradeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_ProfenssionalGradeName, objvTeacherInfo_Cond.profenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Qualif) == true)
{
const strComparisonOp_id_Qualif:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Qualif];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Qualif, objvTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_QualifDesc) == true)
{
const strComparisonOp_QualifDesc:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_QualifDesc];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_QualifDesc, objvTeacherInfo_Cond.qualifDesc, strComparisonOp_QualifDesc);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Degree) == true)
{
const strComparisonOp_id_Degree:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Degree];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Degree, objvTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_DegreeName) == true)
{
const strComparisonOp_DegreeName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_DegreeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_DegreeName, objvTeacherInfo_Cond.degreeName, strComparisonOp_DegreeName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_StaffType) == true)
{
const strComparisonOp_id_StaffType:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_StaffType];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_StaffType, objvTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_StaffTypeName) == true)
{
const strComparisonOp_StaffTypeName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_StaffTypeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_StaffTypeName, objvTeacherInfo_Cond.staffTypeName, strComparisonOp_StaffTypeName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Province) == true)
{
const strComparisonOp_id_Province:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Province];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Province, objvTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_ProvinceName) == true)
{
const strComparisonOp_ProvinceName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_ProvinceName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_ProvinceName, objvTeacherInfo_Cond.provinceName, strComparisonOp_ProvinceName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_CitizenID) == true)
{
const strComparisonOp_CitizenID:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_CitizenID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_CitizenID, objvTeacherInfo_Cond.citizenID, strComparisonOp_CitizenID);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_CardNo) == true)
{
const strComparisonOp_CardNo:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_CardNo, objvTeacherInfo_Cond.cardNo, strComparisonOp_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Birthday) == true)
{
const strComparisonOp_Birthday:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Birthday];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Birthday, objvTeacherInfo_Cond.birthday, strComparisonOp_Birthday);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_GraduationMajor) == true)
{
const strComparisonOp_GraduationMajor:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_GraduationMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_GraduationMajor, objvTeacherInfo_Cond.graduationMajor, strComparisonOp_GraduationMajor);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_TelNo) == true)
{
const strComparisonOp_TelNo:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_TelNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_TelNo, objvTeacherInfo_Cond.telNo, strComparisonOp_TelNo);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Email) == true)
{
const strComparisonOp_Email:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Email];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Email, objvTeacherInfo_Cond.email, strComparisonOp_Email);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_WebSite) == true)
{
const strComparisonOp_WebSite:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_WebSite];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_WebSite, objvTeacherInfo_Cond.webSite, strComparisonOp_WebSite);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_PersonBlog) == true)
{
const strComparisonOp_PersonBlog:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_PersonBlog];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_PersonBlog, objvTeacherInfo_Cond.personBlog, strComparisonOp_PersonBlog);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_EntryDate) == true)
{
const strComparisonOp_EntryDate:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_EntryDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_EntryDate, objvTeacherInfo_Cond.entryDate, strComparisonOp_EntryDate);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Offed) == true)
{
if (objvTeacherInfo_Cond.offed == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_Offed);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_Offed);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Id_CardNo) == true)
{
const strComparisonOp_Id_CardNo:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Id_CardNo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Id_CardNo, objvTeacherInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_IsAvconUser) == true)
{
if (objvTeacherInfo_Cond.isAvconUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_IsAvconUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_IsAvconUser);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_IsGpUser) == true)
{
if (objvTeacherInfo_Cond.isGpUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_IsGpUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_IsGpUser);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_IsLocalUser) == true)
{
if (objvTeacherInfo_Cond.isLocalUser == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_IsLocalUser);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_IsLocalUser);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_FromUnit) == true)
{
const strComparisonOp_FromUnit:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_FromUnit];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_FromUnit, objvTeacherInfo_Cond.fromUnit, strComparisonOp_FromUnit);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Memo) == true)
{
const strComparisonOp_Memo:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Memo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Memo, objvTeacherInfo_Cond.memo, strComparisonOp_Memo);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_XzCollege) == true)
{
const strComparisonOp_id_XzCollege:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_XzCollege];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_XzCollege, objvTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_CollegeID) == true)
{
const strComparisonOp_CollegeID:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_CollegeID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_CollegeID, objvTeacherInfo_Cond.collegeID, strComparisonOp_CollegeID);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_CollegeName) == true)
{
const strComparisonOp_CollegeName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_CollegeName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_CollegeName, objvTeacherInfo_Cond.collegeName, strComparisonOp_CollegeName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_CollegeNameA) == true)
{
const strComparisonOp_CollegeNameA:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_CollegeNameA];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_CollegeNameA, objvTeacherInfo_Cond.collegeNameA, strComparisonOp_CollegeNameA);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_XzMajor) == true)
{
const strComparisonOp_id_XzMajor:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_XzMajor];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_XzMajor, objvTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_EntryDay) == true)
{
const strComparisonOp_EntryDay:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_EntryDay];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_EntryDay, objvTeacherInfo_Cond.entryDay, strComparisonOp_EntryDay);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Photo) == true)
{
const strComparisonOp_id_Photo:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Photo];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Photo, objvTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_id_Religion) == true)
{
const strComparisonOp_id_Religion:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_id_Religion];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_id_Religion, objvTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_ReligionName) == true)
{
const strComparisonOp_ReligionName:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_ReligionName];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_ReligionName, objvTeacherInfo_Cond.religionName, strComparisonOp_ReligionName);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_IsMessage) == true)
{
if (objvTeacherInfo_Cond.isMessage == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_IsMessage);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_IsMessage);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Microblog) == true)
{
const strComparisonOp_Microblog:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Microblog];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Microblog, objvTeacherInfo_Cond.microblog, strComparisonOp_Microblog);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_ModifyUserID) == true)
{
const strComparisonOp_ModifyUserID:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_ModifyUserID];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_ModifyUserID, objvTeacherInfo_Cond.modifyUserID, strComparisonOp_ModifyUserID);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_OffedBak) == true)
{
if (objvTeacherInfo_Cond.offedBak == true)
{
strWhereCond += Format(" And {0} = '1'", clsvTeacherInfoEN.con_OffedBak);
}
else
{
strWhereCond += Format(" And {0} = '0'", clsvTeacherInfoEN.con_OffedBak);
}
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_PhoneNumber) == true)
{
const strComparisonOp_PhoneNumber:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_PhoneNumber];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_PhoneNumber, objvTeacherInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_QQ) == true)
{
const strComparisonOp_QQ:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_QQ];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_QQ, objvTeacherInfo_Cond.qQ, strComparisonOp_QQ);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Teach_id_College) == true)
{
const strComparisonOp_Teach_id_College:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Teach_id_College];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Teach_id_College, objvTeacherInfo_Cond.teach_id_College, strComparisonOp_Teach_id_College);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Teach_id_Major) == true)
{
const strComparisonOp_Teach_id_Major:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Teach_id_Major];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Teach_id_Major, objvTeacherInfo_Cond.teach_id_Major, strComparisonOp_Teach_id_Major);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_Tel) == true)
{
const strComparisonOp_Tel:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_Tel];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_Tel, objvTeacherInfo_Cond.tel, strComparisonOp_Tel);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_ModifyDate) == true)
{
const strComparisonOp_ModifyDate:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_ModifyDate];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_ModifyDate, objvTeacherInfo_Cond.modifyDate, strComparisonOp_ModifyDate);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_RegisterPassword) == true)
{
const strComparisonOp_RegisterPassword:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_RegisterPassword];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_RegisterPassword, objvTeacherInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_EntryYear) == true)
{
const strComparisonOp_EntryYear:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_EntryYear];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_EntryYear, objvTeacherInfo_Cond.entryYear, strComparisonOp_EntryYear);
}
if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN.con_DisciplineName_ps) == true)
{
const strComparisonOp_DisciplineName_ps:string = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN.con_DisciplineName_ps];
strWhereCond += Format(" And {0} {2} '{1}'", clsvTeacherInfoEN.con_DisciplineName_ps, objvTeacherInfo_Cond.disciplineName_ps, strComparisonOp_DisciplineName_ps);
}
 return strWhereCond;
}

/**
 * 把同一个类的对象,复制到另一个对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
 * @param objvTeacherInfoENS:源对象
 * @param objvTeacherInfoENT:目标对象
*/
export function vTeacherInfo_CopyObjTo(objvTeacherInfoENS: clsvTeacherInfoEN , objvTeacherInfoENT: clsvTeacherInfoEN ): void 
{
objvTeacherInfoENT.id_Teacher = objvTeacherInfoENS.id_Teacher; //教师流水号
objvTeacherInfoENT.teacherID = objvTeacherInfoENS.teacherID; //教师工号
objvTeacherInfoENT.teacherName = objvTeacherInfoENS.teacherName; //教师姓名
objvTeacherInfoENT.id_Sex = objvTeacherInfoENS.id_Sex; //性别流水号
objvTeacherInfoENT.sexDesc = objvTeacherInfoENS.sexDesc; //性别名称
objvTeacherInfoENT.id_School_Ps = objvTeacherInfoENS.id_School_Ps; //学校流水号
objvTeacherInfoENT.schoolId = objvTeacherInfoENS.schoolId; //学校编号
objvTeacherInfoENT.schoolName = objvTeacherInfoENS.schoolName; //学校名称
objvTeacherInfoENT.id_Discipline_Ps = objvTeacherInfoENS.id_Discipline_Ps; //学科流水号
objvTeacherInfoENT.id_UniZone = objvTeacherInfoENS.id_UniZone; //校区流水号
objvTeacherInfoENT.uniZoneDesc = objvTeacherInfoENS.uniZoneDesc; //校区名称
objvTeacherInfoENT.id_Ethnic = objvTeacherInfoENS.id_Ethnic; //民族流水号
objvTeacherInfoENT.ethnicName = objvTeacherInfoENS.ethnicName; //民族名称
objvTeacherInfoENT.id_Politics = objvTeacherInfoENS.id_Politics; //政治面貌流水号
objvTeacherInfoENT.politicsName = objvTeacherInfoENS.politicsName; //政治面貌
objvTeacherInfoENT.id_AdminGrade = objvTeacherInfoENS.id_AdminGrade; //行政职务流水号
objvTeacherInfoENT.adminGradeDesc = objvTeacherInfoENS.adminGradeDesc; //行政职务描述
objvTeacherInfoENT.id_ProfGrade = objvTeacherInfoENS.id_ProfGrade; //专业职称流水号
objvTeacherInfoENT.profenssionalGradeName = objvTeacherInfoENS.profenssionalGradeName; //专业职称
objvTeacherInfoENT.id_Qualif = objvTeacherInfoENS.id_Qualif; //学历流水号
objvTeacherInfoENT.qualifDesc = objvTeacherInfoENS.qualifDesc; //QualifDesc
objvTeacherInfoENT.id_Degree = objvTeacherInfoENS.id_Degree; //学位流水号
objvTeacherInfoENT.degreeName = objvTeacherInfoENS.degreeName; //学位名称
objvTeacherInfoENT.id_StaffType = objvTeacherInfoENS.id_StaffType; //职工类型流水号
objvTeacherInfoENT.staffTypeName = objvTeacherInfoENS.staffTypeName; //职工类型名称
objvTeacherInfoENT.id_Province = objvTeacherInfoENS.id_Province; //省份流水号
objvTeacherInfoENT.provinceName = objvTeacherInfoENS.provinceName; //ProvinceName
objvTeacherInfoENT.citizenID = objvTeacherInfoENS.citizenID; //身份证号
objvTeacherInfoENT.cardNo = objvTeacherInfoENS.cardNo; //卡号
objvTeacherInfoENT.birthday = objvTeacherInfoENS.birthday; //出生日期
objvTeacherInfoENT.graduationMajor = objvTeacherInfoENS.graduationMajor; //毕业专业
objvTeacherInfoENT.telNo = objvTeacherInfoENS.telNo; //电话
objvTeacherInfoENT.email = objvTeacherInfoENS.email; //电子邮箱
objvTeacherInfoENT.webSite = objvTeacherInfoENS.webSite; //个人主页
objvTeacherInfoENT.personBlog = objvTeacherInfoENS.personBlog; //个人博客
objvTeacherInfoENT.entryDate = objvTeacherInfoENS.entryDate; //进校日期
objvTeacherInfoENT.offed = objvTeacherInfoENS.offed; //是否离校
objvTeacherInfoENT.id_CardNo = objvTeacherInfoENS.id_CardNo; //内卡号
objvTeacherInfoENT.isAvconUser = objvTeacherInfoENS.isAvconUser; //IsAvconUser
objvTeacherInfoENT.isGpUser = objvTeacherInfoENS.isGpUser; //是否Gp用户
objvTeacherInfoENT.isLocalUser = objvTeacherInfoENS.isLocalUser; //是否本地用户
objvTeacherInfoENT.fromUnit = objvTeacherInfoENS.fromUnit; //来自单位
objvTeacherInfoENT.memo = objvTeacherInfoENS.memo; //备注
objvTeacherInfoENT.id_XzCollege = objvTeacherInfoENS.id_XzCollege; //学院流水号
objvTeacherInfoENT.collegeID = objvTeacherInfoENS.collegeID; //学院ID
objvTeacherInfoENT.collegeName = objvTeacherInfoENS.collegeName; //学院名称
objvTeacherInfoENT.collegeNameA = objvTeacherInfoENS.collegeNameA; //学院名称简写
objvTeacherInfoENT.id_XzMajor = objvTeacherInfoENS.id_XzMajor; //专业流水号
objvTeacherInfoENT.entryDay = objvTeacherInfoENS.entryDay; //EntryDay
objvTeacherInfoENT.id_Photo = objvTeacherInfoENS.id_Photo; //id_Photo
objvTeacherInfoENT.id_Religion = objvTeacherInfoENS.id_Religion; //id_Religion
objvTeacherInfoENT.religionName = objvTeacherInfoENS.religionName; //ReligionName
objvTeacherInfoENT.isMessage = objvTeacherInfoENS.isMessage; //IsMessage
objvTeacherInfoENT.microblog = objvTeacherInfoENS.microblog; //Microblog
objvTeacherInfoENT.modifyUserID = objvTeacherInfoENS.modifyUserID; //修改人
objvTeacherInfoENT.offedBak = objvTeacherInfoENS.offedBak; //OffedBak
objvTeacherInfoENT.phoneNumber = objvTeacherInfoENS.phoneNumber; //PhoneNumber
objvTeacherInfoENT.qQ = objvTeacherInfoENS.qQ; //QQ
objvTeacherInfoENT.teach_id_College = objvTeacherInfoENS.teach_id_College; //Teach_id_College
objvTeacherInfoENT.teach_id_Major = objvTeacherInfoENS.teach_id_Major; //Teach_id_Major
objvTeacherInfoENT.tel = objvTeacherInfoENS.tel; //Tel
objvTeacherInfoENT.modifyDate = objvTeacherInfoENS.modifyDate; //修改日期
objvTeacherInfoENT.registerPassword = objvTeacherInfoENS.registerPassword; //RegisterPassword
objvTeacherInfoENT.entryYear = objvTeacherInfoENS.entryYear; //EntryYear
objvTeacherInfoENT.disciplineName_ps = objvTeacherInfoENS.disciplineName_ps; //学科
}

/**
 * 把一个JSON的对象,复制到另一个实体对象
 * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
 * @param objvTeacherInfoENS:源对象
 * @param objvTeacherInfoENT:目标对象
*/
export function vTeacherInfo_GetObjFromJsonObj(objvTeacherInfoENS: clsvTeacherInfoEN): clsvTeacherInfoEN 
{
 const objvTeacherInfoENT: clsvTeacherInfoEN = new clsvTeacherInfoEN();
ObjectAssign(objvTeacherInfoENT, objvTeacherInfoENS);
 return objvTeacherInfoENT;
}