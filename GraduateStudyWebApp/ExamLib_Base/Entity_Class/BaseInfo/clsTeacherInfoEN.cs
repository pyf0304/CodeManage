
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeacherInfoEN
 表名:TeacherInfo(01120093)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 框架-层名:实体层(CS)(EntityLayer,0001)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ExamLib.Entity
{
 /// <summary>
 /// 表TeacherInfo的关键字(IdTeacher)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdTeacher_TeacherInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdTeacher">表关键字</param>
public K_IdTeacher_TeacherInfo(string strIdTeacher)
{
if (IsValid(strIdTeacher)) Value = strIdTeacher;
else
{
Value = null;
}
}
private static bool IsValid(string strIdTeacher)
{
if (string.IsNullOrEmpty(strIdTeacher) == true) return false;
if (strIdTeacher.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdTeacher_TeacherInfo]类型的对象</returns>
public static implicit operator K_IdTeacher_TeacherInfo(string value)
{
return new K_IdTeacher_TeacherInfo(value);
}
}
 /// <summary>
 /// 教师(TeacherInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTeacherInfoEN : clsEntityBase2
{
public static List<string> _RefreshTimeLst = new List<string>();
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "TeacherInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 49;
public static string[] AttributeName = new string[] {"IdTeacher", "TeacherId", "TeacherName", "IdSex", "IdSchoolPs", "IdDisciplinePs", "IdUniZone", "IdEthnic", "IdPolitics", "IdAdminGrade", "IdProfGrade", "IdQualif", "IdDegree", "IdStaffType", "IdProvince", "CitizenId", "CardNo", "Birthday", "GraduationMajor", "TelNo", "Email", "WebSite", "PersonBlog", "EntryDate", "Offed", "IsAvconUser", "IsGpUser", "IsLocalUser", "FromUnit", "Memo", "IdXzCollege", "IdXzMajor", "EntryDay", "IdPhoto", "IdReligion", "IsMessage", "Microblog", "ModifyUserId", "OffedBak", "PhoneNumber", "QQ", "TeachIdCollege", "TeachIdMajor", "Tel", "Headphoto", "ModifyDate", "RegisterPassword", "TeacherPhoto", "IdCardNo"};

protected string mstrIdTeacher;    //教师流水号
protected string mstrTeacherId;    //教师工号
protected string mstrTeacherName;    //教师姓名
protected string mstrIdSex;    //性别流水号
protected string mstrIdSchoolPs;    //学校流水号
protected string mstrIdDisciplinePs;    //学科流水号
protected string mstrIdUniZone;    //校区流水号
protected string mstrIdEthnic;    //民族流水号
protected string mstrIdPolitics;    //政治面貌流水号
protected string mstrIdAdminGrade;    //行政职务流水号
protected string mstrIdProfGrade;    //专业职称流水号
protected string mstrIdQualif;    //学历流水号
protected string mstrIdDegree;    //学位流水号
protected string mstrIdStaffType;    //职工类型流水号
protected string mstrIdProvince;    //省份流水号
protected string mstrCitizenId;    //身份证号
protected string mstrCardNo;    //卡号
protected string mstrBirthday;    //出生日期
protected string mstrGraduationMajor;    //毕业专业
protected string mstrTelNo;    //电话
protected string mstrEmail;    //电子邮箱
protected string mstrWebSite;    //个人主页
protected string mstrPersonBlog;    //个人博客
protected string mstrEntryDate;    //进校日期
protected bool mbolOffed;    //是否离校
protected bool mbolIsAvconUser;    //IsAvconUser
protected bool mbolIsGpUser;    //是否Gp用户
protected bool mbolIsLocalUser;    //是否本地用户
protected string mstrFromUnit;    //来自单位
protected string mstrMemo;    //备注
protected string mstrIdXzCollege;    //学院流水号
protected string mstrIdXzMajor;    //专业流水号
protected string mstrEntryDay;    //EntryDay
protected string mstrIdPhoto;    //id_Photo
protected string mstrIdReligion;    //id_Religion
protected bool mbolIsMessage;    //IsMessage
protected string mstrMicroblog;    //Microblog
protected string mstrModifyUserId;    //修改人
protected bool mbolOffedBak;    //OffedBak
protected string mstrPhoneNumber;    //电话
protected string mstrQQ;    //QQ
protected string mstrTeachIdCollege;    //Teach_id_College
protected string mstrTeachIdMajor;    //Teach_id_Major
protected string mstrTel;    //Tel
protected string mstrHeadphoto;    //Headphoto
protected string mstrModifyDate;    //修改日期
protected string mstrRegisterPassword;    //RegisterPassword
protected string mstrTeacherPhoto;    //TeacherPhoto
protected string mstrIdCardNo;    //身份证号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTeacherInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeacher");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdTeacher">关键字:教师流水号</param>
public clsTeacherInfoEN(string strIdTeacher)
 {
strIdTeacher = strIdTeacher.Replace("'", "''");
if (strIdTeacher.Length > 8)
{
throw new Exception("在表:TeacherInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdTeacher)  ==  true)
{
throw new Exception("在表:TeacherInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeacher);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdTeacher = strIdTeacher;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdTeacher");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  conTeacherInfo.IdTeacher)
{
return mstrIdTeacher;
}
else if (strAttributeName  ==  conTeacherInfo.TeacherId)
{
return mstrTeacherId;
}
else if (strAttributeName  ==  conTeacherInfo.TeacherName)
{
return mstrTeacherName;
}
else if (strAttributeName  ==  conTeacherInfo.IdSex)
{
return mstrIdSex;
}
else if (strAttributeName  ==  conTeacherInfo.IdSchoolPs)
{
return mstrIdSchoolPs;
}
else if (strAttributeName  ==  conTeacherInfo.IdDisciplinePs)
{
return mstrIdDisciplinePs;
}
else if (strAttributeName  ==  conTeacherInfo.IdUniZone)
{
return mstrIdUniZone;
}
else if (strAttributeName  ==  conTeacherInfo.IdEthnic)
{
return mstrIdEthnic;
}
else if (strAttributeName  ==  conTeacherInfo.IdPolitics)
{
return mstrIdPolitics;
}
else if (strAttributeName  ==  conTeacherInfo.IdAdminGrade)
{
return mstrIdAdminGrade;
}
else if (strAttributeName  ==  conTeacherInfo.IdProfGrade)
{
return mstrIdProfGrade;
}
else if (strAttributeName  ==  conTeacherInfo.IdQualif)
{
return mstrIdQualif;
}
else if (strAttributeName  ==  conTeacherInfo.IdDegree)
{
return mstrIdDegree;
}
else if (strAttributeName  ==  conTeacherInfo.IdStaffType)
{
return mstrIdStaffType;
}
else if (strAttributeName  ==  conTeacherInfo.IdProvince)
{
return mstrIdProvince;
}
else if (strAttributeName  ==  conTeacherInfo.CitizenId)
{
return mstrCitizenId;
}
else if (strAttributeName  ==  conTeacherInfo.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  conTeacherInfo.Birthday)
{
return mstrBirthday;
}
else if (strAttributeName  ==  conTeacherInfo.GraduationMajor)
{
return mstrGraduationMajor;
}
else if (strAttributeName  ==  conTeacherInfo.TelNo)
{
return mstrTelNo;
}
else if (strAttributeName  ==  conTeacherInfo.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conTeacherInfo.WebSite)
{
return mstrWebSite;
}
else if (strAttributeName  ==  conTeacherInfo.PersonBlog)
{
return mstrPersonBlog;
}
else if (strAttributeName  ==  conTeacherInfo.EntryDate)
{
return mstrEntryDate;
}
else if (strAttributeName  ==  conTeacherInfo.Offed)
{
return mbolOffed;
}
else if (strAttributeName  ==  conTeacherInfo.IsAvconUser)
{
return mbolIsAvconUser;
}
else if (strAttributeName  ==  conTeacherInfo.IsGpUser)
{
return mbolIsGpUser;
}
else if (strAttributeName  ==  conTeacherInfo.IsLocalUser)
{
return mbolIsLocalUser;
}
else if (strAttributeName  ==  conTeacherInfo.FromUnit)
{
return mstrFromUnit;
}
else if (strAttributeName  ==  conTeacherInfo.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conTeacherInfo.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conTeacherInfo.IdXzMajor)
{
return mstrIdXzMajor;
}
else if (strAttributeName  ==  conTeacherInfo.EntryDay)
{
return mstrEntryDay;
}
else if (strAttributeName  ==  conTeacherInfo.IdPhoto)
{
return mstrIdPhoto;
}
else if (strAttributeName  ==  conTeacherInfo.IdReligion)
{
return mstrIdReligion;
}
else if (strAttributeName  ==  conTeacherInfo.IsMessage)
{
return mbolIsMessage;
}
else if (strAttributeName  ==  conTeacherInfo.Microblog)
{
return mstrMicroblog;
}
else if (strAttributeName  ==  conTeacherInfo.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conTeacherInfo.OffedBak)
{
return mbolOffedBak;
}
else if (strAttributeName  ==  conTeacherInfo.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conTeacherInfo.QQ)
{
return mstrQQ;
}
else if (strAttributeName  ==  conTeacherInfo.TeachIdCollege)
{
return mstrTeachIdCollege;
}
else if (strAttributeName  ==  conTeacherInfo.TeachIdMajor)
{
return mstrTeachIdMajor;
}
else if (strAttributeName  ==  conTeacherInfo.Tel)
{
return mstrTel;
}
else if (strAttributeName  ==  conTeacherInfo.Headphoto)
{
return mstrHeadphoto;
}
else if (strAttributeName  ==  conTeacherInfo.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conTeacherInfo.RegisterPassword)
{
return mstrRegisterPassword;
}
else if (strAttributeName  ==  conTeacherInfo.TeacherPhoto)
{
return mstrTeacherPhoto;
}
else if (strAttributeName  ==  conTeacherInfo.IdCardNo)
{
return mstrIdCardNo;
}
return null;
}
set
{
if (strAttributeName  ==  conTeacherInfo.IdTeacher)
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdTeacher);
}
else if (strAttributeName  ==  conTeacherInfo.TeacherId)
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherId);
}
else if (strAttributeName  ==  conTeacherInfo.TeacherName)
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherName);
}
else if (strAttributeName  ==  conTeacherInfo.IdSex)
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdSex);
}
else if (strAttributeName  ==  conTeacherInfo.IdSchoolPs)
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdSchoolPs);
}
else if (strAttributeName  ==  conTeacherInfo.IdDisciplinePs)
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdDisciplinePs);
}
else if (strAttributeName  ==  conTeacherInfo.IdUniZone)
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdUniZone);
}
else if (strAttributeName  ==  conTeacherInfo.IdEthnic)
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdEthnic);
}
else if (strAttributeName  ==  conTeacherInfo.IdPolitics)
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdPolitics);
}
else if (strAttributeName  ==  conTeacherInfo.IdAdminGrade)
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdAdminGrade);
}
else if (strAttributeName  ==  conTeacherInfo.IdProfGrade)
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdProfGrade);
}
else if (strAttributeName  ==  conTeacherInfo.IdQualif)
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdQualif);
}
else if (strAttributeName  ==  conTeacherInfo.IdDegree)
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdDegree);
}
else if (strAttributeName  ==  conTeacherInfo.IdStaffType)
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdStaffType);
}
else if (strAttributeName  ==  conTeacherInfo.IdProvince)
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdProvince);
}
else if (strAttributeName  ==  conTeacherInfo.CitizenId)
{
mstrCitizenId = value.ToString();
 AddUpdatedFld(conTeacherInfo.CitizenId);
}
else if (strAttributeName  ==  conTeacherInfo.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.CardNo);
}
else if (strAttributeName  ==  conTeacherInfo.Birthday)
{
mstrBirthday = value.ToString();
 AddUpdatedFld(conTeacherInfo.Birthday);
}
else if (strAttributeName  ==  conTeacherInfo.GraduationMajor)
{
mstrGraduationMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.GraduationMajor);
}
else if (strAttributeName  ==  conTeacherInfo.TelNo)
{
mstrTelNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.TelNo);
}
else if (strAttributeName  ==  conTeacherInfo.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conTeacherInfo.Email);
}
else if (strAttributeName  ==  conTeacherInfo.WebSite)
{
mstrWebSite = value.ToString();
 AddUpdatedFld(conTeacherInfo.WebSite);
}
else if (strAttributeName  ==  conTeacherInfo.PersonBlog)
{
mstrPersonBlog = value.ToString();
 AddUpdatedFld(conTeacherInfo.PersonBlog);
}
else if (strAttributeName  ==  conTeacherInfo.EntryDate)
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(conTeacherInfo.EntryDate);
}
else if (strAttributeName  ==  conTeacherInfo.Offed)
{
mbolOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.Offed);
}
else if (strAttributeName  ==  conTeacherInfo.IsAvconUser)
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsAvconUser);
}
else if (strAttributeName  ==  conTeacherInfo.IsGpUser)
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsGpUser);
}
else if (strAttributeName  ==  conTeacherInfo.IsLocalUser)
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsLocalUser);
}
else if (strAttributeName  ==  conTeacherInfo.FromUnit)
{
mstrFromUnit = value.ToString();
 AddUpdatedFld(conTeacherInfo.FromUnit);
}
else if (strAttributeName  ==  conTeacherInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeacherInfo.Memo);
}
else if (strAttributeName  ==  conTeacherInfo.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdXzCollege);
}
else if (strAttributeName  ==  conTeacherInfo.IdXzMajor)
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdXzMajor);
}
else if (strAttributeName  ==  conTeacherInfo.EntryDay)
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(conTeacherInfo.EntryDay);
}
else if (strAttributeName  ==  conTeacherInfo.IdPhoto)
{
mstrIdPhoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdPhoto);
}
else if (strAttributeName  ==  conTeacherInfo.IdReligion)
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdReligion);
}
else if (strAttributeName  ==  conTeacherInfo.IsMessage)
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsMessage);
}
else if (strAttributeName  ==  conTeacherInfo.Microblog)
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(conTeacherInfo.Microblog);
}
else if (strAttributeName  ==  conTeacherInfo.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conTeacherInfo.ModifyUserId);
}
else if (strAttributeName  ==  conTeacherInfo.OffedBak)
{
mbolOffedBak = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.OffedBak);
}
else if (strAttributeName  ==  conTeacherInfo.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conTeacherInfo.PhoneNumber);
}
else if (strAttributeName  ==  conTeacherInfo.QQ)
{
mstrQQ = value.ToString();
 AddUpdatedFld(conTeacherInfo.QQ);
}
else if (strAttributeName  ==  conTeacherInfo.TeachIdCollege)
{
mstrTeachIdCollege = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeachIdCollege);
}
else if (strAttributeName  ==  conTeacherInfo.TeachIdMajor)
{
mstrTeachIdMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeachIdMajor);
}
else if (strAttributeName  ==  conTeacherInfo.Tel)
{
mstrTel = value.ToString();
 AddUpdatedFld(conTeacherInfo.Tel);
}
else if (strAttributeName  ==  conTeacherInfo.Headphoto)
{
mstrHeadphoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.Headphoto);
}
else if (strAttributeName  ==  conTeacherInfo.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conTeacherInfo.ModifyDate);
}
else if (strAttributeName  ==  conTeacherInfo.RegisterPassword)
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conTeacherInfo.RegisterPassword);
}
else if (strAttributeName  ==  conTeacherInfo.TeacherPhoto)
{
mstrTeacherPhoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherPhoto);
}
else if (strAttributeName  ==  conTeacherInfo.IdCardNo)
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdCardNo);
}
}
}
public object this[int intIndex]
{
get
{
if (conTeacherInfo.IdTeacher  ==  AttributeName[intIndex])
{
return mstrIdTeacher;
}
else if (conTeacherInfo.TeacherId  ==  AttributeName[intIndex])
{
return mstrTeacherId;
}
else if (conTeacherInfo.TeacherName  ==  AttributeName[intIndex])
{
return mstrTeacherName;
}
else if (conTeacherInfo.IdSex  ==  AttributeName[intIndex])
{
return mstrIdSex;
}
else if (conTeacherInfo.IdSchoolPs  ==  AttributeName[intIndex])
{
return mstrIdSchoolPs;
}
else if (conTeacherInfo.IdDisciplinePs  ==  AttributeName[intIndex])
{
return mstrIdDisciplinePs;
}
else if (conTeacherInfo.IdUniZone  ==  AttributeName[intIndex])
{
return mstrIdUniZone;
}
else if (conTeacherInfo.IdEthnic  ==  AttributeName[intIndex])
{
return mstrIdEthnic;
}
else if (conTeacherInfo.IdPolitics  ==  AttributeName[intIndex])
{
return mstrIdPolitics;
}
else if (conTeacherInfo.IdAdminGrade  ==  AttributeName[intIndex])
{
return mstrIdAdminGrade;
}
else if (conTeacherInfo.IdProfGrade  ==  AttributeName[intIndex])
{
return mstrIdProfGrade;
}
else if (conTeacherInfo.IdQualif  ==  AttributeName[intIndex])
{
return mstrIdQualif;
}
else if (conTeacherInfo.IdDegree  ==  AttributeName[intIndex])
{
return mstrIdDegree;
}
else if (conTeacherInfo.IdStaffType  ==  AttributeName[intIndex])
{
return mstrIdStaffType;
}
else if (conTeacherInfo.IdProvince  ==  AttributeName[intIndex])
{
return mstrIdProvince;
}
else if (conTeacherInfo.CitizenId  ==  AttributeName[intIndex])
{
return mstrCitizenId;
}
else if (conTeacherInfo.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (conTeacherInfo.Birthday  ==  AttributeName[intIndex])
{
return mstrBirthday;
}
else if (conTeacherInfo.GraduationMajor  ==  AttributeName[intIndex])
{
return mstrGraduationMajor;
}
else if (conTeacherInfo.TelNo  ==  AttributeName[intIndex])
{
return mstrTelNo;
}
else if (conTeacherInfo.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conTeacherInfo.WebSite  ==  AttributeName[intIndex])
{
return mstrWebSite;
}
else if (conTeacherInfo.PersonBlog  ==  AttributeName[intIndex])
{
return mstrPersonBlog;
}
else if (conTeacherInfo.EntryDate  ==  AttributeName[intIndex])
{
return mstrEntryDate;
}
else if (conTeacherInfo.Offed  ==  AttributeName[intIndex])
{
return mbolOffed;
}
else if (conTeacherInfo.IsAvconUser  ==  AttributeName[intIndex])
{
return mbolIsAvconUser;
}
else if (conTeacherInfo.IsGpUser  ==  AttributeName[intIndex])
{
return mbolIsGpUser;
}
else if (conTeacherInfo.IsLocalUser  ==  AttributeName[intIndex])
{
return mbolIsLocalUser;
}
else if (conTeacherInfo.FromUnit  ==  AttributeName[intIndex])
{
return mstrFromUnit;
}
else if (conTeacherInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conTeacherInfo.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conTeacherInfo.IdXzMajor  ==  AttributeName[intIndex])
{
return mstrIdXzMajor;
}
else if (conTeacherInfo.EntryDay  ==  AttributeName[intIndex])
{
return mstrEntryDay;
}
else if (conTeacherInfo.IdPhoto  ==  AttributeName[intIndex])
{
return mstrIdPhoto;
}
else if (conTeacherInfo.IdReligion  ==  AttributeName[intIndex])
{
return mstrIdReligion;
}
else if (conTeacherInfo.IsMessage  ==  AttributeName[intIndex])
{
return mbolIsMessage;
}
else if (conTeacherInfo.Microblog  ==  AttributeName[intIndex])
{
return mstrMicroblog;
}
else if (conTeacherInfo.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conTeacherInfo.OffedBak  ==  AttributeName[intIndex])
{
return mbolOffedBak;
}
else if (conTeacherInfo.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conTeacherInfo.QQ  ==  AttributeName[intIndex])
{
return mstrQQ;
}
else if (conTeacherInfo.TeachIdCollege  ==  AttributeName[intIndex])
{
return mstrTeachIdCollege;
}
else if (conTeacherInfo.TeachIdMajor  ==  AttributeName[intIndex])
{
return mstrTeachIdMajor;
}
else if (conTeacherInfo.Tel  ==  AttributeName[intIndex])
{
return mstrTel;
}
else if (conTeacherInfo.Headphoto  ==  AttributeName[intIndex])
{
return mstrHeadphoto;
}
else if (conTeacherInfo.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conTeacherInfo.RegisterPassword  ==  AttributeName[intIndex])
{
return mstrRegisterPassword;
}
else if (conTeacherInfo.TeacherPhoto  ==  AttributeName[intIndex])
{
return mstrTeacherPhoto;
}
else if (conTeacherInfo.IdCardNo  ==  AttributeName[intIndex])
{
return mstrIdCardNo;
}
return null;
}
set
{
if (conTeacherInfo.IdTeacher  ==  AttributeName[intIndex])
{
mstrIdTeacher = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdTeacher);
}
else if (conTeacherInfo.TeacherId  ==  AttributeName[intIndex])
{
mstrTeacherId = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherId);
}
else if (conTeacherInfo.TeacherName  ==  AttributeName[intIndex])
{
mstrTeacherName = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherName);
}
else if (conTeacherInfo.IdSex  ==  AttributeName[intIndex])
{
mstrIdSex = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdSex);
}
else if (conTeacherInfo.IdSchoolPs  ==  AttributeName[intIndex])
{
mstrIdSchoolPs = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdSchoolPs);
}
else if (conTeacherInfo.IdDisciplinePs  ==  AttributeName[intIndex])
{
mstrIdDisciplinePs = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdDisciplinePs);
}
else if (conTeacherInfo.IdUniZone  ==  AttributeName[intIndex])
{
mstrIdUniZone = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdUniZone);
}
else if (conTeacherInfo.IdEthnic  ==  AttributeName[intIndex])
{
mstrIdEthnic = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdEthnic);
}
else if (conTeacherInfo.IdPolitics  ==  AttributeName[intIndex])
{
mstrIdPolitics = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdPolitics);
}
else if (conTeacherInfo.IdAdminGrade  ==  AttributeName[intIndex])
{
mstrIdAdminGrade = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdAdminGrade);
}
else if (conTeacherInfo.IdProfGrade  ==  AttributeName[intIndex])
{
mstrIdProfGrade = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdProfGrade);
}
else if (conTeacherInfo.IdQualif  ==  AttributeName[intIndex])
{
mstrIdQualif = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdQualif);
}
else if (conTeacherInfo.IdDegree  ==  AttributeName[intIndex])
{
mstrIdDegree = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdDegree);
}
else if (conTeacherInfo.IdStaffType  ==  AttributeName[intIndex])
{
mstrIdStaffType = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdStaffType);
}
else if (conTeacherInfo.IdProvince  ==  AttributeName[intIndex])
{
mstrIdProvince = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdProvince);
}
else if (conTeacherInfo.CitizenId  ==  AttributeName[intIndex])
{
mstrCitizenId = value.ToString();
 AddUpdatedFld(conTeacherInfo.CitizenId);
}
else if (conTeacherInfo.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.CardNo);
}
else if (conTeacherInfo.Birthday  ==  AttributeName[intIndex])
{
mstrBirthday = value.ToString();
 AddUpdatedFld(conTeacherInfo.Birthday);
}
else if (conTeacherInfo.GraduationMajor  ==  AttributeName[intIndex])
{
mstrGraduationMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.GraduationMajor);
}
else if (conTeacherInfo.TelNo  ==  AttributeName[intIndex])
{
mstrTelNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.TelNo);
}
else if (conTeacherInfo.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conTeacherInfo.Email);
}
else if (conTeacherInfo.WebSite  ==  AttributeName[intIndex])
{
mstrWebSite = value.ToString();
 AddUpdatedFld(conTeacherInfo.WebSite);
}
else if (conTeacherInfo.PersonBlog  ==  AttributeName[intIndex])
{
mstrPersonBlog = value.ToString();
 AddUpdatedFld(conTeacherInfo.PersonBlog);
}
else if (conTeacherInfo.EntryDate  ==  AttributeName[intIndex])
{
mstrEntryDate = value.ToString();
 AddUpdatedFld(conTeacherInfo.EntryDate);
}
else if (conTeacherInfo.Offed  ==  AttributeName[intIndex])
{
mbolOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.Offed);
}
else if (conTeacherInfo.IsAvconUser  ==  AttributeName[intIndex])
{
mbolIsAvconUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsAvconUser);
}
else if (conTeacherInfo.IsGpUser  ==  AttributeName[intIndex])
{
mbolIsGpUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsGpUser);
}
else if (conTeacherInfo.IsLocalUser  ==  AttributeName[intIndex])
{
mbolIsLocalUser = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsLocalUser);
}
else if (conTeacherInfo.FromUnit  ==  AttributeName[intIndex])
{
mstrFromUnit = value.ToString();
 AddUpdatedFld(conTeacherInfo.FromUnit);
}
else if (conTeacherInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conTeacherInfo.Memo);
}
else if (conTeacherInfo.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdXzCollege);
}
else if (conTeacherInfo.IdXzMajor  ==  AttributeName[intIndex])
{
mstrIdXzMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdXzMajor);
}
else if (conTeacherInfo.EntryDay  ==  AttributeName[intIndex])
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(conTeacherInfo.EntryDay);
}
else if (conTeacherInfo.IdPhoto  ==  AttributeName[intIndex])
{
mstrIdPhoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdPhoto);
}
else if (conTeacherInfo.IdReligion  ==  AttributeName[intIndex])
{
mstrIdReligion = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdReligion);
}
else if (conTeacherInfo.IsMessage  ==  AttributeName[intIndex])
{
mbolIsMessage = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.IsMessage);
}
else if (conTeacherInfo.Microblog  ==  AttributeName[intIndex])
{
mstrMicroblog = value.ToString();
 AddUpdatedFld(conTeacherInfo.Microblog);
}
else if (conTeacherInfo.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conTeacherInfo.ModifyUserId);
}
else if (conTeacherInfo.OffedBak  ==  AttributeName[intIndex])
{
mbolOffedBak = TransNullToBool(value.ToString());
 AddUpdatedFld(conTeacherInfo.OffedBak);
}
else if (conTeacherInfo.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conTeacherInfo.PhoneNumber);
}
else if (conTeacherInfo.QQ  ==  AttributeName[intIndex])
{
mstrQQ = value.ToString();
 AddUpdatedFld(conTeacherInfo.QQ);
}
else if (conTeacherInfo.TeachIdCollege  ==  AttributeName[intIndex])
{
mstrTeachIdCollege = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeachIdCollege);
}
else if (conTeacherInfo.TeachIdMajor  ==  AttributeName[intIndex])
{
mstrTeachIdMajor = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeachIdMajor);
}
else if (conTeacherInfo.Tel  ==  AttributeName[intIndex])
{
mstrTel = value.ToString();
 AddUpdatedFld(conTeacherInfo.Tel);
}
else if (conTeacherInfo.Headphoto  ==  AttributeName[intIndex])
{
mstrHeadphoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.Headphoto);
}
else if (conTeacherInfo.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conTeacherInfo.ModifyDate);
}
else if (conTeacherInfo.RegisterPassword  ==  AttributeName[intIndex])
{
mstrRegisterPassword = value.ToString();
 AddUpdatedFld(conTeacherInfo.RegisterPassword);
}
else if (conTeacherInfo.TeacherPhoto  ==  AttributeName[intIndex])
{
mstrTeacherPhoto = value.ToString();
 AddUpdatedFld(conTeacherInfo.TeacherPhoto);
}
else if (conTeacherInfo.IdCardNo  ==  AttributeName[intIndex])
{
mstrIdCardNo = value.ToString();
 AddUpdatedFld(conTeacherInfo.IdCardNo);
}
}
}

/// <summary>
/// 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdTeacher
{
get
{
return mstrIdTeacher;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdTeacher = value;
}
else
{
 mstrIdTeacher = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdTeacher);
}
}
/// <summary>
/// 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherId
{
get
{
return mstrTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherId = value;
}
else
{
 mstrTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TeacherId);
}
}
/// <summary>
/// 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherName
{
get
{
return mstrTeacherName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherName = value;
}
else
{
 mstrTeacherName = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TeacherName);
}
}
/// <summary>
/// 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSex
{
get
{
return mstrIdSex;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSex = value;
}
else
{
 mstrIdSex = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdSex);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchoolPs
{
get
{
return mstrIdSchoolPs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchoolPs = value;
}
else
{
 mstrIdSchoolPs = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdSchoolPs);
}
}
/// <summary>
/// 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDisciplinePs
{
get
{
return mstrIdDisciplinePs;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDisciplinePs = value;
}
else
{
 mstrIdDisciplinePs = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdDisciplinePs);
}
}
/// <summary>
/// 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUniZone
{
get
{
return mstrIdUniZone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUniZone = value;
}
else
{
 mstrIdUniZone = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdUniZone);
}
}
/// <summary>
/// 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdEthnic
{
get
{
return mstrIdEthnic;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdEthnic = value;
}
else
{
 mstrIdEthnic = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdEthnic);
}
}
/// <summary>
/// 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPolitics
{
get
{
return mstrIdPolitics;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPolitics = value;
}
else
{
 mstrIdPolitics = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdPolitics);
}
}
/// <summary>
/// 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdAdminGrade
{
get
{
return mstrIdAdminGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdAdminGrade = value;
}
else
{
 mstrIdAdminGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdAdminGrade);
}
}
/// <summary>
/// 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdProfGrade
{
get
{
return mstrIdProfGrade;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdProfGrade = value;
}
else
{
 mstrIdProfGrade = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdProfGrade);
}
}
/// <summary>
/// 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdQualif
{
get
{
return mstrIdQualif;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdQualif = value;
}
else
{
 mstrIdQualif = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdQualif);
}
}
/// <summary>
/// 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdDegree
{
get
{
return mstrIdDegree;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdDegree = value;
}
else
{
 mstrIdDegree = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdDegree);
}
}
/// <summary>
/// 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStaffType
{
get
{
return mstrIdStaffType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStaffType = value;
}
else
{
 mstrIdStaffType = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdStaffType);
}
}
/// <summary>
/// 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdProvince
{
get
{
return mstrIdProvince;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdProvince = value;
}
else
{
 mstrIdProvince = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdProvince);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:25;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CitizenId
{
get
{
return mstrCitizenId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCitizenId = value;
}
else
{
 mstrCitizenId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.CitizenId);
}
}
/// <summary>
/// 卡号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CardNo
{
get
{
return mstrCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCardNo = value;
}
else
{
 mstrCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.CardNo);
}
}
/// <summary>
/// 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Birthday
{
get
{
return mstrBirthday;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBirthday = value;
}
else
{
 mstrBirthday = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Birthday);
}
}
/// <summary>
/// 毕业专业(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GraduationMajor
{
get
{
return mstrGraduationMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGraduationMajor = value;
}
else
{
 mstrGraduationMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.GraduationMajor);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TelNo
{
get
{
return mstrTelNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTelNo = value;
}
else
{
 mstrTelNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TelNo);
}
}
/// <summary>
/// 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Email);
}
}
/// <summary>
/// 个人主页(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSite
{
get
{
return mstrWebSite;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSite = value;
}
else
{
 mstrWebSite = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.WebSite);
}
}
/// <summary>
/// 个人博客(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PersonBlog
{
get
{
return mstrPersonBlog;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPersonBlog = value;
}
else
{
 mstrPersonBlog = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.PersonBlog);
}
}
/// <summary>
/// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryDate
{
get
{
return mstrEntryDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryDate = value;
}
else
{
 mstrEntryDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.EntryDate);
}
}
/// <summary>
/// 是否离校(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool Offed
{
get
{
return mbolOffed;
}
set
{
 mbolOffed = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Offed);
}
}
/// <summary>
/// IsAvconUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsAvconUser
{
get
{
return mbolIsAvconUser;
}
set
{
 mbolIsAvconUser = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IsAvconUser);
}
}
/// <summary>
/// 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGpUser
{
get
{
return mbolIsGpUser;
}
set
{
 mbolIsGpUser = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IsGpUser);
}
}
/// <summary>
/// 是否本地用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLocalUser
{
get
{
return mbolIsLocalUser;
}
set
{
 mbolIsLocalUser = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IsLocalUser);
}
}
/// <summary>
/// 来自单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FromUnit
{
get
{
return mstrFromUnit;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFromUnit = value;
}
else
{
 mstrFromUnit = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.FromUnit);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Memo);
}
}
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzCollege
{
get
{
return mstrIdXzCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzCollege = value;
}
else
{
 mstrIdXzCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdXzCollege);
}
}
/// <summary>
/// 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdXzMajor
{
get
{
return mstrIdXzMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdXzMajor = value;
}
else
{
 mstrIdXzMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdXzMajor);
}
}
/// <summary>
/// EntryDay(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EntryDay
{
get
{
return mstrEntryDay;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryDay = value;
}
else
{
 mstrEntryDay = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.EntryDay);
}
}
/// <summary>
/// id_Photo(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdPhoto
{
get
{
return mstrIdPhoto;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdPhoto = value;
}
else
{
 mstrIdPhoto = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdPhoto);
}
}
/// <summary>
/// id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdReligion
{
get
{
return mstrIdReligion;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdReligion = value;
}
else
{
 mstrIdReligion = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdReligion);
}
}
/// <summary>
/// IsMessage(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsMessage
{
get
{
return mbolIsMessage;
}
set
{
 mbolIsMessage = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IsMessage);
}
}
/// <summary>
/// Microblog(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Microblog
{
get
{
return mstrMicroblog;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMicroblog = value;
}
else
{
 mstrMicroblog = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Microblog);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.ModifyUserId);
}
}
/// <summary>
/// OffedBak(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool OffedBak
{
get
{
return mbolOffedBak;
}
set
{
 mbolOffedBak = value;
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.OffedBak);
}
}
/// <summary>
/// 电话(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PhoneNumber
{
get
{
return mstrPhoneNumber;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPhoneNumber = value;
}
else
{
 mstrPhoneNumber = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.PhoneNumber);
}
}
/// <summary>
/// QQ(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QQ
{
get
{
return mstrQQ;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQQ = value;
}
else
{
 mstrQQ = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.QQ);
}
}
/// <summary>
/// Teach_id_College(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachIdCollege
{
get
{
return mstrTeachIdCollege;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachIdCollege = value;
}
else
{
 mstrTeachIdCollege = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TeachIdCollege);
}
}
/// <summary>
/// Teach_id_Major(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeachIdMajor
{
get
{
return mstrTeachIdMajor;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeachIdMajor = value;
}
else
{
 mstrTeachIdMajor = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TeachIdMajor);
}
}
/// <summary>
/// Tel(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Tel
{
get
{
return mstrTel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTel = value;
}
else
{
 mstrTel = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Tel);
}
}
/// <summary>
/// Headphoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Headphoto
{
get
{
return mstrHeadphoto;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrHeadphoto = value;
}
else
{
 mstrHeadphoto = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.Headphoto);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.ModifyDate);
}
}
/// <summary>
/// RegisterPassword(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RegisterPassword
{
get
{
return mstrRegisterPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRegisterPassword = value;
}
else
{
 mstrRegisterPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.RegisterPassword);
}
}
/// <summary>
/// TeacherPhoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TeacherPhoto
{
get
{
return mstrTeacherPhoto;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTeacherPhoto = value;
}
else
{
 mstrTeacherPhoto = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.TeacherPhoto);
}
}
/// <summary>
/// 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdCardNo
{
get
{
return mstrIdCardNo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdCardNo = value;
}
else
{
 mstrIdCardNo = value;
}
//记录修改过的字段
 AddUpdatedFld(conTeacherInfo.IdCardNo);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrIdTeacher;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrTeacherName;
 }
 }
}
 /// <summary>
 /// 教师(TeacherInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conTeacherInfo
{
public const string _CurrTabName = "TeacherInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdTeacher", "TeacherId", "TeacherName", "IdSex", "IdSchoolPs", "IdDisciplinePs", "IdUniZone", "IdEthnic", "IdPolitics", "IdAdminGrade", "IdProfGrade", "IdQualif", "IdDegree", "IdStaffType", "IdProvince", "CitizenId", "CardNo", "Birthday", "GraduationMajor", "TelNo", "Email", "WebSite", "PersonBlog", "EntryDate", "Offed", "IsAvconUser", "IsGpUser", "IsLocalUser", "FromUnit", "Memo", "IdXzCollege", "IdXzMajor", "EntryDay", "IdPhoto", "IdReligion", "IsMessage", "Microblog", "ModifyUserId", "OffedBak", "PhoneNumber", "QQ", "TeachIdCollege", "TeachIdMajor", "Tel", "Headphoto", "ModifyDate", "RegisterPassword", "TeacherPhoto", "IdCardNo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdTeacher"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdTeacher = "IdTeacher";    //教师流水号

 /// <summary>
 /// 常量:"TeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherId = "TeacherId";    //教师工号

 /// <summary>
 /// 常量:"TeacherName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherName = "TeacherName";    //教师姓名

 /// <summary>
 /// 常量:"IdSex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSex = "IdSex";    //性别流水号

 /// <summary>
 /// 常量:"IdSchoolPs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchoolPs = "IdSchoolPs";    //学校流水号

 /// <summary>
 /// 常量:"IdDisciplinePs"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDisciplinePs = "IdDisciplinePs";    //学科流水号

 /// <summary>
 /// 常量:"IdUniZone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUniZone = "IdUniZone";    //校区流水号

 /// <summary>
 /// 常量:"IdEthnic"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdEthnic = "IdEthnic";    //民族流水号

 /// <summary>
 /// 常量:"IdPolitics"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPolitics = "IdPolitics";    //政治面貌流水号

 /// <summary>
 /// 常量:"IdAdminGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdAdminGrade = "IdAdminGrade";    //行政职务流水号

 /// <summary>
 /// 常量:"IdProfGrade"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProfGrade = "IdProfGrade";    //专业职称流水号

 /// <summary>
 /// 常量:"IdQualif"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdQualif = "IdQualif";    //学历流水号

 /// <summary>
 /// 常量:"IdDegree"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdDegree = "IdDegree";    //学位流水号

 /// <summary>
 /// 常量:"IdStaffType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStaffType = "IdStaffType";    //职工类型流水号

 /// <summary>
 /// 常量:"IdProvince"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdProvince = "IdProvince";    //省份流水号

 /// <summary>
 /// 常量:"CitizenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CitizenId = "CitizenId";    //身份证号

 /// <summary>
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"Birthday"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Birthday = "Birthday";    //出生日期

 /// <summary>
 /// 常量:"GraduationMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GraduationMajor = "GraduationMajor";    //毕业专业

 /// <summary>
 /// 常量:"TelNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TelNo = "TelNo";    //电话

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //电子邮箱

 /// <summary>
 /// 常量:"WebSite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSite = "WebSite";    //个人主页

 /// <summary>
 /// 常量:"PersonBlog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PersonBlog = "PersonBlog";    //个人博客

 /// <summary>
 /// 常量:"EntryDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryDate = "EntryDate";    //进校日期

 /// <summary>
 /// 常量:"Offed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Offed = "Offed";    //是否离校

 /// <summary>
 /// 常量:"IsAvconUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsAvconUser = "IsAvconUser";    //IsAvconUser

 /// <summary>
 /// 常量:"IsGpUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGpUser = "IsGpUser";    //是否Gp用户

 /// <summary>
 /// 常量:"IsLocalUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLocalUser = "IsLocalUser";    //是否本地用户

 /// <summary>
 /// 常量:"FromUnit"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FromUnit = "FromUnit";    //来自单位

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院流水号

 /// <summary>
 /// 常量:"IdXzMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzMajor = "IdXzMajor";    //专业流水号

 /// <summary>
 /// 常量:"EntryDay"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EntryDay = "EntryDay";    //EntryDay

 /// <summary>
 /// 常量:"IdPhoto"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdPhoto = "IdPhoto";    //id_Photo

 /// <summary>
 /// 常量:"IdReligion"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdReligion = "IdReligion";    //id_Religion

 /// <summary>
 /// 常量:"IsMessage"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsMessage = "IsMessage";    //IsMessage

 /// <summary>
 /// 常量:"Microblog"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Microblog = "Microblog";    //Microblog

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"OffedBak"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OffedBak = "OffedBak";    //OffedBak

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话

 /// <summary>
 /// 常量:"QQ"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QQ = "QQ";    //QQ

 /// <summary>
 /// 常量:"TeachIdCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachIdCollege = "TeachIdCollege";    //Teach_id_College

 /// <summary>
 /// 常量:"TeachIdMajor"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeachIdMajor = "TeachIdMajor";    //Teach_id_Major

 /// <summary>
 /// 常量:"Tel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Tel = "Tel";    //Tel

 /// <summary>
 /// 常量:"Headphoto"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Headphoto = "Headphoto";    //Headphoto

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"RegisterPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RegisterPassword = "RegisterPassword";    //RegisterPassword

 /// <summary>
 /// 常量:"TeacherPhoto"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TeacherPhoto = "TeacherPhoto";    //TeacherPhoto

 /// <summary>
 /// 常量:"IdCardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdCardNo = "IdCardNo";    //身份证号
}

}